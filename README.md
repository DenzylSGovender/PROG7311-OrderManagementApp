# Smart Order Management System (MVC Application)
## Applying SOLID Principles
---
## Project Overview

The **Smart Order Management System** is an ASP.NET MVC application developed to demonstrate **industry best practices in software design** through the application of the **SOLID principles**.

This project simulates a very basic enterprise ordering system.

The application emphasises **clean architecture**, **maintainability**, and **scalability** rather than only functional implementation.

---

## SOLID Principles Applied

---

# Single Responsibility Principle (SRP)

> A class should have only one reason to change.

Each component in the system performs a **single responsibility**.

| Class | Responsibility |
|------|---------------|
| `OrderController` | Handles HTTP requests |
| `OrderService` | Coordinates order workflow |
| `PaymentServices` | Manages payment selection |
| `NotificationServices` | Manages notifications |
| Payment Classes | Process payments only |
| Notification Classes | Send notifications only |

### Benefit
- Easier maintenance
- Improved readability
- Reduced system complexity

---

# Open/Closed Principle (OCP)

> Software entities should be open for extension but closed for modification.

New payment types can be added **without modifying existing business logic**.

Example: BitcoinPayment : IPaymentMethod

The system automatically supports new payment methods without changing the `OrderService`.

### Benefit
- Scalable architecture
- Safe feature expansion
- Reduced regression risk

---

# Liskov Substitution Principle (LSP)

> Derived classes must be substitutable for their base types.

All payment implementations follow the same contract:

IPaymentMethod
This allows the system to safely replace:
CreditCardPayment
PayPalPayment
without breaking application behaviour.

### Benefit
- Reliable polymorphism
- Predictable system behaviour

---
# Interface Segregation Principle (ISP)

> Clients should not depend on interfaces they do not use.

Small, focused interfaces were created:
IPaymentMethod
INotification

Classes implement only behaviour relevant to them.

Example:
- Payment classes do not implement notification logic.
- Notification classes do not process payments.

### Benefit
- Reduced coupling
- Cleaner contracts
- Easier testing

---

## Industry Best Practices Demonstrated

### Separation of Concerns
Controllers, services, and implementations are clearly separated.

### Interface-Driven Design
System behaviour depends on abstractions rather than concrete implementations.

### Maintainable Architecture
Changes remain isolated to specific components.

### Extensibility
New features can be introduced with minimal impact.

---

## Disclaimer
---
- Developed as a learning and teaching project demonstrating professional software engineering practices using ASP.NET MVC and SOLID design principles.
- If you notice any errors. Please bring it to my attention.
---



