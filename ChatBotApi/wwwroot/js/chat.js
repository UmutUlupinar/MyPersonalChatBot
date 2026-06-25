(function () {
  const chat = document.getElementById("chat");
  const form = document.getElementById("form");
  const input = document.getElementById("question");
  const sendBtn = document.getElementById("send");
  const statusEl = document.getElementById("status");

  let busy = false;
  let cooldownUntil = 0;

  function setStatus(state) {
    statusEl.classList.remove("header__status--ok", "header__status--error");
    if (state === "ok") statusEl.classList.add("header__status--ok");
    if (state === "error") statusEl.classList.add("header__status--error");
  }

  async function checkHealth() {
    try {
      const res = await fetch("/health");
      setStatus(res.ok ? "ok" : "error");
    } catch {
      setStatus("error");
    }
  }

  function scrollToBottom() {
    chat.scrollTop = chat.scrollHeight;
  }

  function appendMessage(text, role) {
    const wrap = document.createElement("div");
    wrap.className = `message message--${role}`;
    const bubble = document.createElement("div");
    bubble.className = "message__bubble";
    bubble.textContent = text;
    wrap.appendChild(bubble);
    chat.appendChild(wrap);
    scrollToBottom();
    return wrap;
  }

  function appendError(text) {
    const wrap = document.createElement("div");
    wrap.className = "message message--assistant message--error";
    const bubble = document.createElement("div");
    bubble.className = "message__bubble";
    bubble.textContent = text;
    wrap.appendChild(bubble);
    chat.appendChild(wrap);
    scrollToBottom();
  }

  let typingEl = null;

  function showTyping() {
    typingEl = document.createElement("div");
    typingEl.className = "message message--assistant message--typing";
    typingEl.innerHTML =
      '<div class="message__bubble"><span class="typing-dot"></span><span class="typing-dot"></span><span class="typing-dot"></span></div>';
    chat.appendChild(typingEl);
    scrollToBottom();
  }

  function hideTyping() {
    typingEl?.remove();
    typingEl = null;
  }

  function resizeInput() {
    input.style.height = "auto";
    input.style.height = Math.min(input.scrollHeight, 120) + "px";
  }

  function updateSendState() {
    const onCooldown = Date.now() < cooldownUntil;
    sendBtn.disabled = busy || onCooldown || !input.value.trim();
  }

  async function ask(question) {
    busy = true;
    updateSendState();
    showTyping();

    try {
      const res = await fetch("/ask", {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ question }),
      });

      const data = await res.json().catch(() => ({}));

      if (res.status === 429) {
        appendError(data.error || "Çok fazla istek. Lütfen bir saniye bekleyin.");
        cooldownUntil = Date.now() + 1100;
        return;
      }

      if (!res.ok) {
        appendError(data.error || "Bir hata oluştu. Lütfen tekrar deneyin.");
        setStatus("error");
        return;
      }

      appendMessage(data.answer || "Yanıt alınamadı.", "assistant");
      setStatus("ok");
      cooldownUntil = Date.now() + 1100;
    } catch {
      appendError("Sunucuya bağlanılamadı. Bağlantınızı kontrol edin.");
      setStatus("error");
    } finally {
      hideTyping();
      busy = false;
      updateSendState();
    }
  }

  form.addEventListener("submit", (e) => {
    e.preventDefault();
    const question = input.value.trim();
    if (!question || busy || Date.now() < cooldownUntil) return;

    appendMessage(question, "user");
    input.value = "";
    resizeInput();
    ask(question);
  });

  input.addEventListener("input", () => {
    resizeInput();
    updateSendState();
  });

  input.addEventListener("keydown", (e) => {
    if (e.key === "Enter" && !e.shiftKey) {
      e.preventDefault();
      form.requestSubmit();
    }
  });

  setInterval(updateSendState, 200);
  checkHealth();
  updateSendState();
})();
