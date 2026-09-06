# Chain of Responsibility — Order Processing Demo (C#)

## 📖 Overview
This project demonstrates the **Chain of Responsibility Pattern** through an **Order Processing** scenario.  
Instead of using a single `OrderProcessor` with a long list of `if/else` checks, the logic is split into a **chain of handlers**.  
Each handler performs **one responsibility only** and either:
- Processes the request and passes it to the next handler, or  
- Stops the chain with a clear message.  

---

## ⚡ Problem (Before)
In the legacy class `OrderProcessor`:
- Authentication, permissions, stock, balance, payment, order creation, and notifications were all mixed in one method.  
- Any small change required editing the entire method, making it error-prone and hard to maintain.  

---

## ✅ Solution (After)
With the **Chain of Responsibility**:
- Each rule is encapsulated in its own **Handler class**.  
- The chain is built using a **Chain Builder**.  
- The client just calls `handler.Handle(...)`, without worrying about the order of validations or how the process flows.  

---

## 🧩 Project Structure
```
/ChainOfResponsibility
├─ Handlers/
│  ├─ AuthinticatioHandler.cs        # Checks if user is authenticated
│  ├─ AuthorizationHandler.cs        # Checks if user has permission to buy
│  ├─ BalanceHandler.cs              # Ensures user has enough balance
│  ├─ NotificationHandler.cs         # Sends confirmation email/notification
│  ├─ OrderHandler.cs                # Creates the order
│  ├─ PaymentHandler.cs              # Processes the payment
│  └─ StockHandler.cs                # Validates product stock
│
├─ Main/
│  ├─ BaseHandler.cs                 # Implements IOrderHandler and chain logic
│  ├─ IOrderHandler.cs               # Interface for all handlers
│  └─ OrderHandlerChainBuiler.cs     # Builds the chain in correct order
│
├─ OrderProcessor.cs                 # Legacy implementation (Before)
├─ Product.cs                        # Product entity
├─ Program.cs                        # Entry point, demo usage
└─ User.cs                           # User entity
```

---

## ▶ Example Usage
```csharp
using ChainOfResponsibility;
using ChainOfResponsibility.Main;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var user = new User
{
    Id = 1,
    IsAuthenticated = true,
    CanBuy = true,
    Balance = 500,
    Email = "customer@example.com"
};

var product = new Product
{
    Id = 100,
    Price = 120,
    Stock = 5
};

int quantity = 2;

// Old way (Before):
// var processor = new OrderProcessor();
// processor.Process(user, product, quantity);

// New way (After - Chain of Responsibility):
var chainBuilder = new OrderHandlerChainBuiler();
var handler = chainBuilder.Build();
handler.Handle(user, product, quantity);
```

---

## 💻 Example Output
```
🚀 Start Order Process...

✅ Authentication OK
✅ Authorization OK
✅ Stock OK
✅ Balance OK
💳 Payment processed
🧾 Order #4381 created
📧 Email sent to customer@example.com

🏁 Process Complete.
```

---

## 🔧 How to Run
```bash
dotnet build
dotnet run
```

Make sure the **Console project** is set as the startup project.

---

## 🚀 Why This Design?
- **Open/Closed Principle** → Add new handlers without modifying existing ones.  
- **Single Responsibility** → Each handler does exactly one thing.  
- **Testability** → Test handlers independently.  
- **Reusability** → Handlers can be rearranged or reused in different flows (refund, cancellation, etc.).  

---

## 🔗 Resources
- 🎥 Video: https://youtu.be/MDb9TtH3sOQ  
- 💻 Source Code: https://github.com/EAhmedFetouh/ChainOfResponsibility  

---

