====================================================
PROJECT
====================================================

Name
----
BankOps Observatory

Repository
----------
https://github.com/UmutUlupinar/BankOps-Observatory

Project Type
------------
Personal Project
Technical Demonstration
Interview Showcase

Status
------
Completed

Difficulty
----------
Enterprise Demonstration

Purpose
-------
BankOps Observatory is a production-inspired banking observability platform created to demonstrate software engineering, service engineering and production monitoring skills commonly required in enterprise banking environments.

The project simulates a distributed banking system and allows interviewers to observe how incidents are detected, investigated and analyzed using modern observability tools.

Business Scenario
-----------------
The application simulates a banking environment where users can perform money transfer operations while developers monitor the system exactly as they would in production.

The platform demonstrates how software engineers investigate production incidents, analyze distributed transactions, inspect logs, examine traces and monitor service health.

Architecture
------------
Frontend
- React

Backend
- FastAPI
- Python

Database
- PostgreSQL
- Redis

Observability Stack
- OpenTelemetry
- Jaeger
- Prometheus
- Grafana
- Elasticsearch
- Logstash
- Kibana
- Zabbix

Infrastructure
--------------
Docker
Docker Compose

Concepts Demonstrated
---------------------
Microservice Architecture

Distributed Systems

REST APIs

Distributed Tracing

Structured Logging

Metrics Collection

Monitoring

Alerting

Incident Response

Root Cause Analysis (RCA)

SLI

SLO

Service Health Monitoring

Performance Analysis

Production Troubleshooting

Technologies
------------
Python

FastAPI

React

Docker

PostgreSQL

Redis

OpenTelemetry

Jaeger

Prometheus

Grafana

Elasticsearch

Logstash

Kibana

Zabbix

Key Features
------------
Interactive banking simulation

Money transfer workflow

Distributed tracing visualization

Metrics dashboard

Production-like logging

Incident simulation

Slow database scenario

Learning center for observability concepts

Trace ID navigation

Performance dashboard

Production monitoring dashboard

Learning Outcomes
-----------------
Designed a complete observability platform from scratch.

Learned how enterprise systems are monitored.

Learned distributed tracing using OpenTelemetry and Jaeger.

Learned metrics collection using Prometheus.

Learned dashboard creation using Grafana.

Learned structured logging using Elasticsearch and Kibana.

Learned infrastructure monitoring using Zabbix.

Learned incident investigation workflow.

Learned production troubleshooting techniques.

Demonstrated Skills
-------------------
Backend Development

Distributed Systems

Observability

Monitoring

Logging

Tracing

Infrastructure

Performance Analysis

Root Cause Analysis

DevOps Fundamentals

Production Engineering

Related Professional Experience
-------------------------------
Vepara Digital Payment and Services

Worked with Jaeger, Elasticsearch, Kibana, Docker, Kubernetes and distributed microservices in a production fintech environment.

Experience Level
----------------
Python
Hands-on

FastAPI
Hands-on

Docker
Hands-on

PostgreSQL
Hands-on

Redis
Hands-on

Grafana
Hands-on

Jaeger
Hands-on

OpenTelemetry
Hands-on

Prometheus
Hands-on

Elasticsearch
Hands-on

Kibana
Hands-on

Zabbix
Hands-on

Interview Notes
---------------
This project was developed specifically to strengthen production engineering knowledge and prepare for senior backend and banking software engineering interviews.

Although it is a personal project, it follows production-inspired architecture and demonstrates technologies commonly used in enterprise environments.

Possible Interview Questions
----------------------------
Explain distributed tracing.

What is OpenTelemetry?

How does Jaeger work?

What is Grafana used for?

How do you investigate production incidents?

How do metrics differ from logs?

What is Root Cause Analysis?

How would you monitor a banking application?

Repository
----------
https://github.com/UmutUlupinar/BankOps-Observatory



====================================================
PROJECT
====================================================

Name
----
MyPersonalChatBot

Repository
----------
https://github.com/UmutUlupinar/MyPersonalChatBot

Project Type
------------
Personal Project
AI Application
Portfolio Project

Status
------
Completed
Actively Maintained

Difficulty
----------
Advanced

Purpose
-------
MyPersonalChatBot was developed as an AI-powered personal assistant that answers questions about my professional background, technical skills, work experience, education and GitHub projects.

The project serves as an intelligent extension of my CV and portfolio, allowing recruiters and interviewers to interact with an AI assistant instead of reading a traditional resume.

Business Scenario
-----------------
The application simulates an AI assistant that can answer interview-related questions about a software engineer.

Instead of relying only on a static CV, users can ask technical or career-related questions and receive contextual responses generated by an LLM using a structured knowledge base.

Architecture
------------
Frontend
- HTML
- CSS
- JavaScript

Backend
- .NET 10 Minimal API

AI Integration
--------------
OpenAI Chat Completions API

Hosting
-------
Render.com

Frontend Hosting
----------------
GitHub Pages

Knowledge Base
--------------
Prompt Engineering

System Prompt

CV Knowledge

Company Experience

GitHub Projects

Interview Notes

Sample Answers

Current Context

Technologies
------------
.NET 10

ASP.NET Core Minimal API

C#

HTML

CSS

JavaScript

REST API

OpenAI API

JSON

GitHub Pages

Render

Prompt Engineering

LLMs

Key Features
------------
AI-powered CV assistant

Prompt-based knowledge management

Structured knowledge base

OpenAI API integration

Rate limiting

CORS support

Minimal API architecture

Environment-based API key configuration

Static frontend hosted on GitHub Pages

Backend hosted on Render

Interview-oriented responses

Professional experience awareness

GitHub repository awareness

Context-aware response generation

Learning Outcomes
-----------------
Learned how to integrate Large Language Models into .NET applications.

Learned prompt engineering techniques for improving response quality.

Designed a modular prompt architecture for maintainability.

Implemented secure API key management using environment variables.

Designed a lightweight REST API for AI-powered applications.

Built and deployed a complete AI application using free cloud hosting.

Learned how to structure knowledge for retrieval by an LLM.

Demonstrated Skills
-------------------
Artificial Intelligence

Prompt Engineering

LLM Integration

REST API Development

Minimal APIs

Backend Development

Cloud Deployment

Knowledge Base Design

Software Architecture

Environment Configuration

API Security

Related Professional Experience
-------------------------------
Although no production project has yet required direct LLM integration, this project demonstrates practical experience with OpenAI APIs, prompt engineering and AI application development.

Experience Level
----------------
.NET
Professional

Minimal API
Professional

REST APIs
Professional

OpenAI API
Hands-on

Prompt Engineering
Hands-on

LLMs
Hands-on

Render
Hands-on

GitHub Pages
Hands-on

JavaScript
Professional

Interview Notes
---------------
This project demonstrates practical AI engineering skills rather than simply consuming an API.

Special attention was given to prompt engineering, knowledge organization, modular prompt files and response consistency.

The project is continuously improved by expanding the knowledge base and refining prompt design.

Possible Interview Questions
----------------------------
How do you integrate OpenAI into a .NET application?

How do system prompts work?

How do you prevent hallucinations?

How is your knowledge base organized?

Why did you choose Minimal API?

How do you secure API keys?

Why did you separate the prompts into multiple files?

How would you scale this project?

What improvements would you make using RAG?

Repository
----------
https://github.com/UmutUlupinar/MyPersonalChatBot



====================================================
PROJECT
====================================================

Name
----
JaegerTracerDotNet

Repository
----------
https://github.com/UmutUlupinar/JaegerTracerDotNet

Project Type
------------
Personal Project
Technical Demonstration
Microservices

Status
------
Completed

Difficulty
----------
Advanced

Purpose
-------
JaegerTracerDotNet was developed to demonstrate distributed tracing between multiple .NET microservices using OpenTelemetry and Jaeger.

The project focuses on observing service-to-service communication and understanding how requests flow across distributed systems.

Business Scenario
-----------------
The project simulates two independent microservices communicating with each other while preserving trace context.

Each request generates distributed traces that can be inspected in Jaeger UI, allowing developers to analyze request latency, dependencies and failures.

Architecture
------------
Microservice Architecture

REST APIs

gRPC Communication

Distributed Systems

OpenTelemetry

Jaeger

ActivitySource

HttpClient

Technologies
------------
.NET 10

ASP.NET Core Web API

OpenTelemetry

Jaeger

ActivitySource

HttpClient

REST API

gRPC

Swagger

Docker

Key Features
------------
Two independent microservices

Distributed tracing

Automatic trace propagation

OpenTelemetry instrumentation

ActivitySource integration

Jaeger visualization

Service layer architecture

Shared client library

HTTP communication

gRPC communication

Exception handling

Swagger documentation

Learning Outcomes
-----------------
Learned distributed tracing concepts.

Implemented trace propagation across services.

Learned OpenTelemetry instrumentation.

Learned ActivitySource usage.

Learned how Jaeger visualizes distributed requests.

Compared REST and gRPC communication.

Designed reusable client services.

Demonstrated Skills
-------------------
Distributed Systems

Observability

Distributed Tracing

Microservices

REST APIs

gRPC

Backend Development

OpenTelemetry

Jaeger

Software Architecture

Related Professional Experience
-------------------------------
Vepara Digital Payment and Services

Worked with distributed microservices and Jaeger tracing in a production fintech environment.

Experience Level
----------------
Jaeger
Hands-on

OpenTelemetry
Hands-on

Distributed Tracing
Hands-on

gRPC
Hands-on

REST API
Professional

.NET
Professional

Interview Notes
---------------
This project demonstrates how distributed tracing works between multiple APIs and how OpenTelemetry integrates with Jaeger.

It was created to strengthen observability knowledge beyond daily production experience.

Possible Interview Questions
----------------------------
What is distributed tracing?

What is OpenTelemetry?

How does Jaeger work?

What is ActivitySource?

How is trace context propagated?

Why use gRPC instead of REST?

Repository
----------
https://github.com/UmutUlupinar/JaegerTracerDotNet


====================================================
PROJECT
====================================================

Name
----
ElasticSearchDotNet

Repository
----------
https://github.com/UmutUlupinar/ElasticSearchDotNet

Project Type
------------
Personal Project
Search Platform
Technical Demonstration

Status
------
Completed

Difficulty
----------
Advanced

Purpose
-------
ElasticSearchDotNet demonstrates how Elasticsearch can be integrated into a .NET application to build scalable search functionality using structured location data.

The project focuses on indexing, searching and managing large datasets through REST APIs and a modern web interface.

Business Scenario
-----------------
The application manages Turkish cities, districts and neighborhoods using Elasticsearch.

It demonstrates how enterprise applications perform high-performance search operations using indexing and fuzzy search instead of traditional SQL queries.

Architecture
------------
ASP.NET Core Web API

Blazor Server

REST APIs

Service Layer

Repository Pattern

Middleware

Elasticsearch

Technologies
------------
.NET 10

ASP.NET Core

Blazor Server

Elasticsearch 8.x

Swagger

Docker

REST API

C#

Bootstrap

OpenAPI

Key Features
------------
Elasticsearch integration

CRUD operations

Bulk indexing

Dynamic index creation

Fuzzy search

Location search

Health checks

Exception middleware

Swagger documentation

Blazor frontend

REST APIs

Learning Outcomes
-----------------
Learned Elasticsearch architecture.

Learned indexing strategies.

Implemented fuzzy search.

Worked with Elasticsearch .NET Client.

Designed REST APIs around Elasticsearch.

Built a Blazor application consuming backend APIs.

Implemented centralized exception handling.

Demonstrated Skills
-------------------
Search Technologies

Backend Development

REST APIs

Blazor

Elasticsearch

Index Management

Middleware

API Design

Enterprise Search

Related Professional Experience
-------------------------------
Vepara Digital Payment and Services

Worked with Elasticsearch and Kibana for log analysis and observability in production systems.

Experience Level
----------------
Elasticsearch
Hands-on

Blazor
Hands-on

REST API
Professional

.NET
Professional

Swagger
Professional

Docker
Hands-on

Interview Notes
---------------
This project demonstrates practical Elasticsearch integration beyond log management.

It focuses on search optimization, indexing strategies and enterprise API development.

Possible Interview Questions
----------------------------
Why use Elasticsearch instead of SQL?

What is an index?

How does fuzzy search work?

How do shards and replicas work?

How do you design scalable search APIs?

Repository
----------
https://github.com/UmutUlupinar/ElasticSearchDotNet



====================================================
PROJECT
====================================================

Name
----
RabbitMQDotNet

Repository
----------
https://github.com/UmutUlupinar/RabbitMQDotNet

Project Type
------------
Personal Project
Messaging
Technical Demonstration

Status
------
Completed

Difficulty
----------
Intermediate

Purpose
-------
RabbitMQDotNet demonstrates asynchronous communication between applications using RabbitMQ in a modern .NET environment.

The project was developed to understand message brokers, producer-consumer architecture and event-driven communication patterns commonly used in microservice architectures.

Business Scenario
-----------------
The application simulates an API that publishes messages to RabbitMQ while background services consume and process those messages asynchronously.

The project also demonstrates broadcast communication using Fanout Exchange.

Architecture
------------
Minimal API

Background Hosted Services

Producer / Consumer

Message Broker

Dependency Injection

Configuration Pattern

Technologies
------------
.NET 10

RabbitMQ

Minimal API

Hosted Service

Docker

Swagger

REST API

JSON

Key Features
------------
Message publishing

Message consuming

Fanout Exchange

Background consumers

Configuration-based setup

Queue declaration

Routing Key support

Exchange support

Hosted Services

Swagger integration

Learning Outcomes
-----------------
Learned asynchronous communication.

Learned message queue concepts.

Implemented Producer and Consumer patterns.

Worked with Fanout Exchange.

Learned routing key configuration.

Learned background workers.

Learned event-driven architecture fundamentals.

Demonstrated Skills
-------------------
RabbitMQ

Messaging

Event Driven Architecture

Producer Consumer Pattern

Background Services

Minimal APIs

Backend Development

Related Professional Experience
-------------------------------
Vepara Digital Payment and Services

Worked with event-driven communication using NATS in production microservices.

This project was created to strengthen RabbitMQ knowledge and compare different messaging systems.

Experience Level
----------------
RabbitMQ
Hands-on

Messaging Systems
Hands-on

Hosted Services
Hands-on

Minimal API
Professional

.NET
Professional

Interview Notes
---------------
This project demonstrates messaging fundamentals including producers, consumers, exchanges, routing keys and asynchronous processing.

Possible Interview Questions
----------------------------
What is RabbitMQ?

What is a Queue?

What is an Exchange?

What is Fanout Exchange?

Producer vs Consumer?

When would you use RabbitMQ?

Difference between RabbitMQ and Kafka?

Difference between RabbitMQ and NATS?

Repository
----------
https://github.com/UmutUlupinar/RabbitMQDotNet


====================================================
PROJECT
====================================================

Name
----
MongoDBw.Net

Repository
----------
https://github.com/UmutUlupinar/MongoDBw.Net

Project Type
------------
Personal Project
Database
Technical Demonstration

Status
------
Completed

Difficulty
----------
Intermediate

Purpose
-------
MongoDBw.Net demonstrates how MongoDB can be integrated into a modern .NET application using document-oriented data modeling.

The project was created to strengthen NoSQL database knowledge and compare document databases with relational databases.

Business Scenario
-----------------
The application demonstrates CRUD operations using MongoDB and illustrates how document databases differ from traditional relational database systems.

Architecture
------------
REST API

Service Layer

Repository Pattern

MongoDB

Dependency Injection

Technologies
------------
.NET

ASP.NET Core

MongoDB

MongoDB.Driver

Swagger

REST API

Docker

Key Features
------------
CRUD operations

Collection management

Document-based storage

Repository pattern

Dependency Injection

Swagger integration

RESTful APIs

Learning Outcomes
-----------------
Learned document database concepts.

Learned MongoDB collections.

Worked with BSON documents.

Compared relational databases and NoSQL databases.

Implemented Repository Pattern using MongoDB.

Demonstrated Skills
-------------------
MongoDB

NoSQL

Backend Development

REST APIs

Repository Pattern

Database Design

Related Professional Experience
-------------------------------
Konuşarak Öğren

Worked with MongoDB in production microservices.

Experience Level
----------------
MongoDB
Professional

REST APIs
Professional

.NET
Professional

Interview Notes
---------------
This project demonstrates practical MongoDB integration and reinforces production experience gained while working with MongoDB in microservice environments.

Possible Interview Questions
----------------------------
What is MongoDB?

What is BSON?

Collection vs Table?

When should MongoDB be preferred?

Advantages of NoSQL?

Repository
----------
https://github.com/UmutUlupinar/MongoDBw.Net


====================================================
PROJECT
====================================================

Name
----
LC_Waikiki_AutomationTest

Repository
----------
https://github.com/UmutUlupinar/LC_Waikiki_AutomationTest

Project Type
------------
Personal Project
Test Automation

Status
------
Completed

Difficulty
----------
Intermediate

Purpose
-------
LC_Waikiki_AutomationTest demonstrates automated UI testing for a real-world e-commerce application.

The project focuses on creating maintainable automated tests using modern software testing practices.

Business Scenario
-----------------
The project simulates end-user interactions with an online shopping platform and validates expected behaviors through automated test scenarios.

Architecture
------------
Automation Framework

Page Object Model

UI Testing

Selenium

Technologies
------------
Java

Selenium

JUnit

ChromeDriver

Page Object Model

Test Automation

Key Features
------------
Automated UI testing

Page Object Model

Test scenarios

Element interaction

Assertions

Reusable page classes

Maintainable automation structure

Learning Outcomes
-----------------
Learned UI automation.

Worked with Selenium WebDriver.

Designed maintainable automation tests.

Applied Page Object Model principles.

Improved software quality assurance knowledge.

Demonstrated Skills
-------------------
Software Testing

UI Automation

Selenium

Quality Assurance

Automation Frameworks

Page Object Model

Related Professional Experience
-------------------------------
Although my professional experience primarily focuses on backend development, this project demonstrates my understanding of software quality, automation testing and maintainable test architecture.

Experience Level
----------------
Selenium
Hands-on

Automation Testing
Hands-on

Java
Hands-on

Interview Notes
---------------
The project demonstrates practical knowledge of automated software testing and complements backend development experience by covering software quality assurance practices.

Possible Interview Questions
----------------------------
What is Selenium?

What is Page Object Model?

Difference between Unit Test and UI Test?

Why automate UI tests?

What makes a good automation framework?

Repository
----------
https://github.com/UmutUlupinar/LC_Waikiki_AutomationTest

====================================================
PROJECT
====================================================

Name
----
AI_wPython_CourseNotesAndCodes

Project Type
------------
Learning Repository
Artificial Intelligence
Machine Learning

Status
------
In Progress

Difficulty
----------
Advanced

Purpose
-------
This repository contains my complete learning journey in Artificial Intelligence, Machine Learning, Data Science and Python programming.

It serves as both a structured study repository and a long-term knowledge base where I document concepts, code examples, exercises and projects completed throughout my AI education.

Business Scenario
-----------------
The repository is designed as a personal AI engineering curriculum covering the fundamental concepts required for Data Science, Machine Learning, Deep Learning and Generative AI development.

Rather than being a single application, it contains progressively organized modules that build practical knowledge from Python fundamentals to production-ready AI systems.

Topics Covered
--------------
Python Programming

Data Structures

Object-Oriented Programming

Algorithms

NumPy

Pandas

SciPy

SQL for Data Analysis

Data Cleaning

Data Manipulation

Exploratory Data Analysis

Matplotlib

Plotly

Bokeh

Dashboard Development

Statistics

Machine Learning

Scikit-Learn

Classification

Regression

Clustering

Dimensionality Reduction

Feature Engineering

Model Evaluation

Explainable AI

SHAP

LIME

Deep Learning

TensorFlow

Keras

Neural Networks

Large Language Models

Prompt Engineering

Retrieval Augmented Generation (RAG)

LangChain

AI Agents

OpenAI API

LLM Orchestration

Python Best Practices

Learning Outcomes
-----------------
Developed strong Python programming skills.

Learned modern data analysis workflows.

Built practical machine learning models.

Learned deep learning fundamentals.

Studied explainable AI techniques.

Learned prompt engineering.

Built AI-powered applications using OpenAI APIs.

Studied Retrieval Augmented Generation (RAG).

Learned AI Agent architectures.

Developed practical knowledge of modern AI engineering concepts.

Demonstrated Skills
-------------------
Python

Artificial Intelligence

Machine Learning

Deep Learning

Data Science

LLMs

Prompt Engineering

OpenAI API

LangChain

RAG

AI Agents

Statistics

Data Visualization

Related Professional Experience
-------------------------------
Knowledge gained through this repository directly supports my AI projects, including MyPersonalChatBot, and complements my backend software engineering experience.

Experience Level
----------------
Python
Professional

NumPy
Hands-on

Pandas
Hands-on

SQL
Professional

Scikit-Learn
Hands-on

TensorFlow
Hands-on

Keras
Hands-on

OpenAI API
Hands-on

Prompt Engineering
Hands-on

LangChain
Hands-on

RAG
Hands-on

LLM Concepts
Hands-on

Interview Notes
---------------
Although this repository is educational in nature, it reflects a structured and comprehensive AI engineering learning path with practical coding exercises and applied projects.

Possible Interview Questions
----------------------------
Why Python for AI?

What is RAG?

What are AI Agents?

Difference between Machine Learning and Deep Learning?

What is Prompt Engineering?

What is LangChain?

What is SHAP?

What is LIME?



====================================================
PROJECT
====================================================

Name
----
ShellScript_LVL1

Project Type
------------
Learning Project
Linux
DevOps

Status
------
Completed

Difficulty
----------
Beginner

Purpose
-------
This repository demonstrates my understanding of Linux shell scripting fundamentals and command-line automation.

It was created to improve Linux proficiency, scripting skills and server administration knowledge.

Topics Covered
--------------
Linux Commands

Bash

Variables

Loops

Conditions

Functions

File Operations

Permissions

Text Processing

Automation

Learning Outcomes
-----------------
Learned Linux command line usage.

Developed Bash scripting skills.

Automated repetitive tasks.

Improved server management knowledge.

Strengthened DevOps fundamentals.

Demonstrated Skills
-------------------
Linux

Bash

Shell Scripting

Automation

CLI

Related Professional Experience
-------------------------------
Working with Docker containers and Kubernetes environments required regular interaction with Linux systems. This repository strengthened my command-line skills and scripting knowledge.

Experience Level
----------------
Linux
Hands-on

Shell Script
Hands-on

Bash
Hands-on

Interview Notes
---------------
Although this repository focuses on Linux fundamentals, it supports backend development and DevOps workflows.

Possible Interview Questions
----------------------------
What is Bash?

Why use Shell Scripts?

What is chmod?

How do environment variables work?

How would you automate repetitive server tasks?



====================================================
PROJECT
====================================================

Name
----
JavaScript_Game-TheClimber

Repository
----------
https://github.com/UmutUlupinar/JavaScript_Game-TheClimber

Project Type
------------
Personal Project
Game Development

Status
------
Completed

Difficulty
----------
Intermediate

Purpose
-------
The Climber is a browser-based JavaScript game developed to improve frontend programming skills and better understand browser rendering, event handling and game logic.

Business Scenario
-----------------
The game demonstrates interactive programming concepts including keyboard input, collision detection, animations and score management.

Technologies
------------
JavaScript

HTML5

CSS3

Canvas API

DOM

Animation

Key Features
------------
Keyboard controls

Game loop

Collision detection

Score system

Responsive gameplay

Learning Outcomes
-----------------
Improved JavaScript programming skills.

Learned browser rendering concepts.

Worked with animations.

Implemented game mechanics.

Strengthened problem-solving abilities.

Demonstrated Skills
-------------------
JavaScript

Frontend Development

Game Logic

DOM Manipulation

Animation

Related Professional Experience
-------------------------------
Although my professional career focuses on backend development, this project demonstrates strong JavaScript fundamentals that are useful when developing modern web applications.

Experience Level
----------------
JavaScript
Professional

HTML
Professional

CSS
Professional

Interview Notes
---------------
The project demonstrates algorithmic thinking and frontend programming fundamentals rather than professional game development.

Possible Interview Questions
----------------------------
How does the game loop work?

How does collision detection work?

How are browser events handled?

How does requestAnimationFrame work?

What challenges did you encounter while developing the game?