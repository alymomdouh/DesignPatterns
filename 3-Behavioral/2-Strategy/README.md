# 🎯 Strategy Pattern — Salary Calculation Example (C#)

## 📖 Overview
This repository demonstrates the **Strategy Design Pattern** through a **real-world payroll example**.

Instead of writing long `if/else` or `switch` statements for every employee type,  
the Strategy Pattern lets you define a family of salary calculation algorithms,  
encapsulate each one in its own class, and make them interchangeable at runtime.

This keeps your code **clean, extensible, and easy to maintain**.

---

## 😵 Problem (Before)
In a typical payroll system, salary calculation often starts like this:

```csharp
if (emp.Type == EmployeeType.FullTime)
    return emp.BaseSalary + emp.Bonus;
else if (emp.Type == EmployeeType.Hourly)
    return emp.HoursWorked * emp.HourlyRate;
else if (emp.Type == EmployeeType.Freelancer)
    return emp.GrossAmount - (emp.GrossAmount * 0.15m);
else if (emp.Type == EmployeeType.Intern)
    return 1000;
```

This approach quickly becomes **rigid and messy**:
- Adding a new employee type means editing this method.
- Unit testing is painful.
- Code violates the **Open/Closed Principle**.

---

## ✅ Solution (After)
With the **Strategy Pattern**, each calculation logic is moved into its own class that implements a common interface:

```csharp
public interface ISalaryCalculationStrategy
{
    decimal Calculate(Employee emp);
}
```

Now each employee type has its own strategy:

| Employee Type | Strategy Class | Description |
|----------------|----------------|--------------|
| Full-time | `FulltimeStrategy` | Base salary + bonus |
| Hourly | `HourlyStrategy` | Hourly rate × worked hours |
| Task-based | `TaskBasedStrategy` | Pay per completed task |
| Freelancer | `FreelancerStrategy` | Gross amount minus tax & commission |
| Intern | `InternStrategy` | Fixed allowance |

The selection of the correct strategy is done by a **Factory** class,  
so the main logic (`PayrollService`) doesn’t need to know any implementation details.

---

## 🧩 Class Responsibilities

- **ISalaryCalculationStrategy** → Defines the contract for all salary strategies  
- **FulltimeStrategy**, **HourlyStrategy**, **FreelancerStrategy**, **TaskBasedStrategy**, **InternStrategy** → Implement different salary rules  
- **SalaryStrategyFactory** → Chooses which strategy to use based on `EmployeeType`  
- **PayrollService** → Uses the chosen strategy to calculate the final salary  

---

## ▶ Example Usage

```csharp
var emp = new Employee
{
    Name = "Ahmed",
    Type = EmployeeType.Freelancer,
    GrossAmount = 8000
};

var payroll = new PayrollService();
var salary = payroll.CalculateSalary(emp);

Console.WriteLine($"Employee: {emp.Name}, Salary: {salary:C}");
```

🧾 **Output Example**
```
Employee: Ahmed, Salary: 6,800.00
```

---

## ⚙️ Benefits

✅ Removes complex `if/else` and `switch` logic  
✅ Follows the **Open/Closed Principle** (easy to add new types)  
✅ Each strategy is **independent and testable**  
✅ Improves readability and maintainability  
✅ Makes behavior **interchangeable at runtime**

---

## 📦 Project Structure

```
/StrategyPattern
├── Strategies/
│   ├── ISalaryCalculationStrategy.cs
│   ├── FulltimeStrategy.cs
│   ├── HourlyStrategy.cs
│   ├── TaskBasedStrategy.cs
│   ├── FreelancerStrategy.cs
│   ├── InternStrategy.cs
│   ├── SalaryStrategyFactory.cs
│   └── PayrollService.cs
└── Program.cs
```

---

## 💬 Design Pattern Summary

> The **Strategy Pattern** defines a family of algorithms,  
> encapsulates each one, and makes them interchangeable.  
> This allows the algorithm to vary independently from the clients that use it.

---


