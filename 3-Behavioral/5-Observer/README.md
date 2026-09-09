# Banking System: Observer Pattern Implementation 🏦💻

This project is a technical demonstration of how to transform a tightly coupled notification system into a flexible, scalable architecture using the **Observer Design Pattern**. It is designed as an educational resource to compare "Bad" vs. "Clean" code practices in C#.

---

## 🚀 Overview
In modern banking systems, various events (like deposits or withdrawals) must trigger notifications across multiple channels (SMS, Email, WhatsApp, etc.). This project illustrates the transition from a rigid implementation to one that follows the **Open/Closed Principle** and **Single Responsibility Principle**.

### 🏗️ Project Structure
The repository is divided into two main approaches:
1. **`ObserverPattern.Bad`**: The legacy/hard-coded implementation.
2. **`ObserverPattern.Observer`**: The refactored version using the Observer Pattern.

---

## 🔴 The Problem: Tightly Coupled Design
In the initial version (`BankingSystem.cs`), the system was "brittle" because:
* **Hard-coded Dependencies**: The bank was directly responsible for instantiating `SMSService`, `EmailService`, `WhatsAppService`, etc..
* **Violation of OCP**: Adding a new service required modifying the core `ProcessTransaction` method.
* **Complexity**: Managed user notification groups through complex `if-else` blocks.

## 🟢 The Solution: Observer Pattern
The refactored system decouples the bank from the notification logic using a "Subject-Observer" relationship.

### Core Components:
* **`ISubscriber` (Interface)**: Defines the contract with a single `Update(Transaction transaction)` method.
* **`NewBankingSystem` (Subject)**: Maintains a private list of subscribers and notifies them automatically upon transaction completion.
* **`Transaction` (DTO)**: A data object containing the amount, type, and balance.

### Concrete Subscribers:
Each subscriber handles its own logic independently:
* **`EmailSubscriber`**: Handles email alerts.
* **`SMSSubscriber`**: Handles mobile text alerts.
* **`PushNotificationSubscriber`**: Handles app notifications.
* **`WhatAppSubscriber`**: Handles WhatsApp messaging.

---

## 🛠️ Key Benefits
| Benefit | Description |
| :--- | :--- |
| **Scalability** | Add new subscribers (e.g., Telegram) without changing the banking logic. |
| **Maintainability** | Each notification channel is in its own class, making it easier to debug. |
| **Runtime Control** | Use `Subscribe()` and `UnSubscribe()` to manage notifications on the fly. |

---

## 💻 Technical Details
* **Language**: C# / .NET
* **Design Pattern**: Observer (Behavioral Pattern)
* **Principles**: SOLID (OCP, SRP, DIP)

---

## 📺 Educational Content
This project is part of a technical series explaining software architecture. 
- **Video Explanation**: [Insert Link Here]
- **LinkedIn Article**: [Insert Link Here]
- **Discussion Group**: [Insert Link Here]
