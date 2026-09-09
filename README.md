### Here Found Some Learned Design Patterns With Examples In C # 

### the Sources is 

### 1- [Design Patterns بالعربي Youtube PlayList](https://www.youtube.com/playlist?list=PL6DpjIj6ySiHPDuN_JN49rYbQwnsxRdee)

[repositories links serach my name](https://github.com/EAhmedFetouh?tab=repositories)

# The Pref And Interview Questions 

 
 ## What is the Design Patterns
 
 Design Patterns are proven, **reusable solutions to common software design problems**.
 
 They are not ready-made code, but rather templates or best practices for structuring classes and objects.

Think of them as:
```
- Algorithms solve coding problems.
- Design Patterns solve design problems.
```

## What Categories of Design Patterns

The Gang of Four (GoF) patterns are divided into 3 categories:

####  1. Creational Patterns
 Concerned with object creation
####  2. Structural Patterns
Concerned with relationships between classes.
####  3. Behavioral Patterns
Concerned with communication between objects.
----------------------------------------------
###  Design patterns can be harmful when they are used just because they exist, 
rather than because they solve a real problem

##### 1. Overengineering

A simple problem can become unnecessarily complicated.
The code may technically follow "good practices," but it's much harder to understand and maintain.

#### Rule: Don't add a pattern until you have a problem that justifies it.


##### 2. Pattern overuse

Patterns are often recognizable structures, so developers may try to apply them everywhere.

For example, using the Singleton pattern for every service:

##### 3. Making code harder to understand

A pattern can add abstractions that don't provide enough value.

##### 4. Wrong pattern for the problem

Choosing the wrong pattern can create more problems than it solves.

For example, using Observer when you only need a simple method call can introduce:

##### 5. Premature abstraction

This is probably one of the biggest dangers.
If you don't have a real reason for the abstraction, the interface may just add another layer.

A useful principle is:

#####  Don't abstract based on what might happen. Abstract based on what is actually happening.

##### 6. Patterns can hide bad architecture

A project can contain lots of patterns and still have terrible architecture.
doesn't automatically mean the system is well designed.

You can have Clean Architecture + 20 design patterns + terrible business logic.

Patterns are tools, not proof of good architecture.


-------------------------------------------
##  1. Creational Patterns
###  1.1 Prototype


بدل ما تنشئ Object جديد من الصفر باستخدام new كل مرة، تقوم بعمل نسخة (Clone) من Object موجود بالفعل.

###  1.2 Simple Factory 

Simple Factory هو أسلوب بسيط لإنشاء الـ Objects، ويُستخدم عندما تريد وضع منطق إنشاء الـ Object في مكان واحد بدل توزيع new في كل مكان.

ملاحظة: Simple Factory ليس Design Pattern رسميًا من GoF، لكنه أسلوب شائع جدًا ويُعتبر مقدمة ممتازة لفهم Factory Method و Abstract Factory.

|           | Simple Factory    | Prototype          |
| --------- | ----------------- | ------------------ |
| الهدف     | إنشاء Object      | نسخ Object         |
| الطريقة   | `Create()`        | `Clone()`          |
| يعتمد على | نوع الـ Object    | Object موجود       |
| مثال      | `Create("email")` | `employee.Clone()` |
| Category  | Creational        | Creational         |


###  1.3 Factory Method

Factory Method هو Design Pattern من نوع Creational، وفكرته الأساسية:

بدل أن يكون الـ Client مسؤولًا عن اختيار وإنشاء الـ Object باستخدام new، نجعل الـ Factory نفسها هي التي تحدد أي Object سيتم إنشاؤه.

وهو أكثر مرونة من Simple Factory.
|                | Simple Factory     | Factory Method      |
| -------------- | ------------------ | ------------------- |
| Factory        | واحدة              | عدة Factories       |
| الاختيار       | `if/switch` غالبًا | Polymorphism        |
| إنشاء Object   | Factory واحدة      | Subclass            |
| إضافة نوع جديد | تعديل Factory      | إضافة Factory جديدة |
| OCP            | أقل التزامًا       | أفضل                |
| التعقيد        | أبسط               | أكثر                |
| مناسب          | مشاريع صغيرة       | أنظمة قابلة للتوسع  |

احفظ الفرق بهذه الجملة:

Simple Factory:

"أديني النوع وأنا هعمل لك الـ Object."
```
Factory.Create("Visa");
```
Factory Method:

"أنا Factory متخصصة في نوع معين، وأنا اللي هحدد الـ Object."
```
new VisaPaymentFactory()
    .CreatePayment();
```
والنقطة المهمة جدًا: Factory Method لا تعني مجرد أن عندك Method اسمها Create()؛ المقصود أن الـ creation method تكون قابلة للتخصيص/override بواسطة subclasses.

###  1.4 Abstract Factory

Abstract Factory هو Design Pattern من نوع Creational، وفكرته:

إنشاء عائلة من الـ Objects المرتبطة ببعضها بدون أن يكون الـ Client مسؤولًا عن معرفة الـ concrete classes التي يتم إنشاؤها.
يعني بدل ما يكون عندك Factory تنشئ Object واحد، يكون عندك Factory تنشئ مجموعة Objects متوافقة مع بعضها.

طريقة سهلة لحفظهم

Simple Factory

"اختار لي Object."
```
Create("Visa")
```
Factory Method

"الـ Factory المتخصصة هي التي تحدد الـ Object."
```
VisaFactory → VisaPayment
```
Abstract Factory

"أعطني مجموعة Objects متوافقة مع بعضها."
```
WindowsFactory
   ↓
Button + Checkbox + TextBox
```

###  1.5 Builder

الـ Builder Pattern هو أحد Creational Design Patterns، وفكرته الأساسية:

فصل عملية بناء Object معقد عن الـ Object نفسه، بحيث تستطيع إنشاء نفس الـ Object بطرق أو configurations مختلفة.

ببساطة: بدل Constructor ضخم فيه parameters كثيرة، تستخدم Builder لبناء الـ Object خطوة بخطوة.

Builder Pattern يسمح لك بإنشاء Object معقد خطوة بخطوة، مع فصل منطق البناء عن الـ Object النهائي.


###  1.6 Singleton


الـ Singleton Pattern هو أحد Creational Design Patterns، وفكرته الأساسية:

ضمان أن يكون هناك Instance واحد فقط من Class طوال فترة تشغيل التطبيق، مع توفير طريقة للوصول إليه.


###  2. Structural Patterns


###  2.1 Adapter

 

> **جعل Class أو System غير متوافق مع الـ Interface المطلوب في التطبيق يعمل معه، بدون تعديل الـ Class الأصلي.**

بمعنى بسيط جدًا:

**Adapter = محوّل**

مثل محول الكهرباء:

```text
Socket
  │
  ▼
Adapter
  │
  ▼
Device
```

الـ Socket والـ Device غير متوافقين، والـ Adapter يحل المشكلة.

---

# المشكلة التي يحلها Adapter

تخيل أن تطبيقك يتوقع:

```csharp
public interface IPaymentService
{
    void Pay(decimal amount);
}
```

وأنت تريد استخدام مكتبة خارجية، لكنها تعمل بهذا الشكل:

```csharp
public class PayPalApi
{
    public void MakePayment(double money)
    {
        Console.WriteLine($"Paid {money}");
    }
}
```

المشكلة أن التطبيق يتوقع:

```csharp
IPaymentService
```

لكن المكتبة تعطيك:

```csharp
PayPalApi
```

ولا تستطيع تغيير `PayPalApi` لأنها مكتبة خارجية.

إذن:

```text
Your Application
       │
       ▼
IPaymentService
       ❌
   PayPalApi
```

هنا نستخدم **Adapter**.

---

# إنشاء Adapter

نعمل Class جديد:

```csharp
public class PayPalAdapter : IPaymentService
{
    private readonly PayPalApi _payPal;

    public PayPalAdapter(PayPalApi payPal)
    {
        _payPal = payPal;
    }

    public void Pay(decimal amount)
    {
        _payPal.MakePayment((double)amount);
    }
}
```

الآن:

```text
Application
     │
     ▼
IPaymentService
     │
     ▼
PayPalAdapter
     │
     ▼
PayPalApi
```

التطبيق لا يحتاج أن يعرف أي شيء عن `PayPalApi`.

يعمل فقط مع:

```csharp
IPaymentService
```

---

# الاستخدام

```csharp
PayPalApi paypal = new PayPalApi();

IPaymentService paymentService =
    new PayPalAdapter(paypal);

paymentService.Pay(100);
```

عندما نستدعي:

```csharp
paymentService.Pay(100);
```

يحصل الآتي:

```text
Pay()
  ↓
PayPalAdapter
  ↓
MakePayment()
  ↓
PayPalApi
```

فالـ Adapter يقوم بعملية **الترجمة/التحويل** بين الواجهتين.

---

# الشكل العام للـ Adapter

احفظ هذا الشكل:

```text
        Client
          │
          ▼
    Target Interface
          ▲
          │
       Adapter
          │
          ▼
   Adaptee / Legacy
```

في مثالنا:

```text
       Application
            │
            ▼
     IPaymentService
            ▲
            │
      PayPalAdapter
            │
            ▼
        PayPalApi
```

---

# مكونات Adapter Pattern

عادةً عندنا 4 عناصر:

### 1. Client

الكود الذي يريد استخدام الخدمة.

```csharp
IPaymentService payment;
```

### 2. Target

الـ Interface الذي يتوقعه الـ Client.

```csharp
public interface IPaymentService
{
    void Pay(decimal amount);
}
```

### 3. Adaptee

الـ Class الموجود بالفعل ولكن الـ Interface الخاص به غير مناسب.

```csharp
public class PayPalApi
{
    public void MakePayment(double money)
    {
    }
}
```

### 4. Adapter

الذي يربط الاثنين.

```csharp
public class PayPalAdapter : IPaymentService
{
    private readonly PayPalApi _payPal;

    public PayPalAdapter(PayPalApi payPal)
    {
        _payPal = payPal;
    }

    public void Pay(decimal amount)
    {
        _payPal.MakePayment((double)amount);
    }
}
```

---

# لماذا لا نعدل PayPalApi مباشرة؟

لأنها ممكن تكون:

* Third-party library
* Legacy code
* Class مستخدم في أماكن كثيرة
* لا نملك Source Code الخاص به
* تغييره ممكن يكسر أجزاء أخرى من النظام

بدلًا من:

```text
❌ Modify PayPalApi
```

نعمل:

```text
✅ Create Adapter
```

---

# مثال أقرب للـ Real World

افترض أن عندك النظام التالي:

```csharp
public interface INotificationService
{
    void Send(string message);
}
```

وتريد استخدام SMS Provider خارجي:

```csharp
public class TwilioClient
{
    public void SendSms(string phoneNumber, string text)
    {
        Console.WriteLine($"SMS: {text}");
    }
}
```

الـ application يريد:

```csharp
Send(string message)
```

لكن Twilio يريد:

```csharp
SendSms(phoneNumber, text)
```

نعمل Adapter:

```csharp
public class TwilioAdapter : INotificationService
{
    private readonly TwilioClient _twilio;
    private readonly string _phoneNumber;

    public TwilioAdapter(
        TwilioClient twilio,
        string phoneNumber)
    {
        _twilio = twilio;
        _phoneNumber = phoneNumber;
    }

    public void Send(string message)
    {
        _twilio.SendSms(_phoneNumber, message);
    }
}
```

الآن التطبيق يتعامل مع:

```csharp
INotificationService
```

ولا يهتم بتفاصيل Twilio.

---

# Adapter باستخدام Composition

هذا يسمى غالبًا **Object Adapter**.

الـ Adapter يحتوي على object من الـ Adaptee:

```csharp
public class Adapter : ITarget
{
    private readonly Adaptee _adaptee;

    public Adapter(Adaptee adaptee)
    {
        _adaptee = adaptee;
    }
}
```

وهذا يعتمد على:

> **Composition**

وليس inheritance.

---

# لماذا Composition أفضل هنا؟

بدلاً من:

```csharp
class Adapter : Adaptee
```

نستخدم:

```csharp
class Adapter : ITarget
{
    private readonly Adaptee _adaptee;
}
```

لأننا نريد أن نقول:

> أنا أطبق الـ Interface الذي يحتاجه النظام، وأستخدم الـ Class القديم بداخلي.

وهذا يعطي مرونة أكبر.

---

###  2.2 Decorator
 

**Decorator** هو Design Pattern يسمح لك بإضافة **سلوك أو وظائف جديدة إلى Object موجود** بدون أن تعدّل الكلاس الأصلي.


مثلاً:

عندك نظام إرسال رسائل:

```text
MessageService
     ↓
Send Message
```

وعاوز تضيف:

* Logging
* Encryption
* Validation
* Caching

بدل ما تعدل `MessageService` نفسه، نضع Decorator حوله:

```text
LoggingDecorator
       ↓
EncryptionDecorator
       ↓
MessageService
```

كل Decorator يضيف وظيفة معينة.

---

# مثال بسيط في C#

نفترض أن عندنا:

```csharp
public interface INotifier
{
    void Send(string message);
}
```

والتنفيذ الأساسي:

```csharp
public class EmailNotifier : INotifier
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending Email: {message}");
    }
}
```

الاستخدام:

```csharp
INotifier notifier = new EmailNotifier();

notifier.Send("Hello");
```

الناتج:

```text
Sending Email: Hello
```

---

## نريد إضافة Logging

بدلاً من تعديل `EmailNotifier`، نعمل Decorator:

```csharp
public class LoggingNotifier : INotifier
{
    private readonly INotifier _notifier;

    public LoggingNotifier(INotifier notifier)
    {
        _notifier = notifier;
    }

    public void Send(string message)
    {
        Console.WriteLine("Logging: Message is being sent");

        _notifier.Send(message);

        Console.WriteLine("Logging: Message was sent");
    }
}
```

الآن:

```csharp
INotifier notifier = new EmailNotifier();

notifier = new LoggingNotifier(notifier);

notifier.Send("Hello");
```

الناتج:

```text
Logging: Message is being sent
Sending Email: Hello
Logging: Message was sent
```

لاحظ أن:

```csharp
LoggingNotifier
```

يحتوي على:

```csharp
private readonly INotifier _notifier;
```

أي أنه **يمسك الـ object الأصلي** ويستدعيه.

وهذه هي الفكرة الأساسية للـ Decorator.

---

# إضافة أكثر من Decorator

وهنا تظهر قوة الـ Pattern.

مثلاً نريد:

1. Logging
2. Encryption
3. Email

ننشئ Decorator آخر:

```csharp
public class EncryptionNotifier : INotifier
{
    private readonly INotifier _notifier;

    public EncryptionNotifier(INotifier notifier)
    {
        _notifier = notifier;
    }

    public void Send(string message)
    {
        string encryptedMessage = $"Encrypted({message})";

        _notifier.Send(encryptedMessage);
    }
}
```

يمكننا تركيبهم:

```csharp
INotifier notifier = new EmailNotifier();

notifier = new EncryptionNotifier(notifier);

notifier = new LoggingNotifier(notifier);

notifier.Send("Hello");
```

الشكل أصبح:

```text
LoggingNotifier
       ↓
EncryptionNotifier
       ↓
EmailNotifier
```

والتنفيذ:

```text
Logging
   ↓
Encryption
   ↓
Email
```

---

# الفكرة في شكل Diagram

```text
             INotifier
                 ▲
        ┌────────┴─────────┐
        │                  │
 EmailNotifier        Decorator
                           │
                    ┌──────┴──────┐
                    │             │
             LoggingDecorator  EncryptionDecorator
```

والـ Decorator نفسه يطبق نفس الـ Interface:

```csharp
INotifier
    ↑
LoggingNotifier
```

وفي داخله:

```csharp
INotifier _notifier;
```

وهذا يسمح لنا بعمل **Composition**.

---

# لماذا لا نستخدم Inheritance؟

ممكن نظرياً تعمل:

```text
EmailNotifier
    ↓
LoggingEmailNotifier
```

ثم:

```text
EmailNotifier
    ↓
EncryptedEmailNotifier
```

لكن لو عندك:

* Email + Logging
* Email + Encryption
* Email + Logging + Encryption
* SMS + Logging
* SMS + Encryption
* SMS + Logging + Encryption

عدد الـ Classes سيزيد جداً.

هذا يسمى أحياناً **Class Explosion**.

أما باستخدام Decorator:

```text
Logging
Encryption
Caching
Validation
    ↓
Email
```

تقدر تركبهم بأي ترتيب.

---

# Decorator vs Adapter

الفرق الأساسي بين **Decorator** و **Adapter** هو:

> **Adapter يغيّر الـ Interface لكي يجعل كودين غير متوافقين يعملان معًا.**

> **Decorator يحافظ على نفس الـ Interface ويضيف Behavior جديد للـ Object.**

## مقارنة مباشرة

| النقطة                             | Decorator                    | Adapter                            |
| ---------------------------------- | ---------------------------- | ---------------------------------- |
| الهدف                              | إضافة وظائف/سلوك             | جعل Interfaces مختلفة متوافقة      |
| الـ Interface                      | غالبًا **نفسه**              | يحوّل Interface إلى Interface آخر  |
| يضيف Behavior؟                     | ✅ نعم                        | ❌ ليس الهدف الأساسي                |
| يغيّر طريقة التعامل مع الـ Object؟ | لا                           | نعم                                |
| يعتمد على                          | Composition / Wrapping       | Composition / Conversion           |
| يمكن تركيب عدة منها؟               | ✅ بسهولة                     | ممكن، لكن ليس هذا الهدف            |
| الاستخدام الشائع                   | Logging, Caching, Validation | Legacy APIs, Third-party libraries |

---

# الفرق بصرياً

### Decorator

```text
        Same Interface
             │
             ▼
     ┌───────────────┐
     │   Decorator   │
     │   + Logging   │
     └───────┬───────┘
             │
             ▼
     ┌───────────────┐
     │ Original Obj  │
     └───────────────┘
```

يعني:

> **نفس الواجهة + وظيفة إضافية**

---

### Adapter

```text
Application
     │
     ▼
┌─────────────┐
│   Adapter   │
│ Translate   │
└──────┬──────┘
       │
       ▼
Third-party / Legacy
```

يعني:

> **واجهة مختلفة → تحويلها للواجهة التي أحتاجها**

---

# سؤال مهم في Interview

### هل Decorator و Adapter الاثنين يستخدمون Composition؟

**نعم.**

كلاهما غالباً يحتوي على object داخله:

```csharp
private readonly IService _service;
```

لكن **النية Intent** مختلفة.

### Decorator

```text
"I want to ADD something."
```

### Adapter

```text
"I want to MAKE THEM COMPATIBLE."
```

---

# مثال واحد يوضح الاثنين

افترض عندك:

```csharp
IPaymentService
```

وعندك:

```text
Stripe
PayPal
Old Bank API
```

### Old Bank API

لا يتوافق مع `IPaymentService`:

```text
IPaymentService
      ❌
OldBankApi
```

نستخدم:

```text
IPaymentService
      ↓
BankAdapter
      ↓
OldBankApi
```

**Adapter** يحل مشكلة الـ compatibility.

بعد ذلك تريد Logging:

```text
LoggingDecorator
       ↓
BankAdapter
       ↓
OldBankApi
```

هنا:

* **Adapter** جعل الـ API متوافقاً.
* **Decorator** أضاف Logging.

وهما يمكن أن يعملا معاً:

```text
Application
    ↓
LoggingDecorator
    ↓
PaymentAdapter
    ↓
OldBankApi
```

## 🧠 طريقة سهلة للحفظ

**Adapter = Change the interface**

> "خلّي ده يتكلم مع ده."

**Decorator = Add behavior**

> "خلّي ده يعمل حاجة زيادة."

إذا سألك الـ interviewer: **"What is the main difference?"**

قل:

> **Adapter changes an object's interface so it can work with existing clients, while Decorator keeps the same interface and adds new behavior to the object.**

 
###  2.3   Composite Pattern  

الـ **Composite Pattern** يسمح لك بالتعامل مع:

* **Object واحد (Leaf)**
* **مجموعة من Objects (Composite)**

بنفس الطريقة.

بمعنى:

> **Treat individual objects and compositions of objects uniformly.**

أو بالعربي:

> أتعامل مع العنصر المفرد والمجموعة التي تحتوي على عناصر بنفس الـ Interface.

---

# مثال واقعي جدًا: File System

تخيل نظام الملفات:

```text
📁 Documents
│
├── 📄 CV.pdf
├── 📄 Report.docx
│
└── 📁 Projects
    │
    ├── 📄 Project1.cs
    └── 📄 Project2.cs
```

عندنا نوعان من العناصر:

### File

عنصر مفرد:

```text
CV.pdf
```

### Folder

يحتوي على عناصر أخرى:

```text
Documents
   ├── CV.pdf
   ├── Report.docx
   └── Projects
```

المهم أن الـ Folder يمكن أن يحتوي على:

* Files
* Folders

وهذا بالضبط هو الـ Composite.

---

# الشكل الأساسي

```text
             Component
                 ▲
          ┌──────┴──────┐
          │             │
        Leaf         Composite
                        │
                    ┌───┴───┐
                    │       │
                  Leaf    Composite
```

لاحظ أن:

**Composite يحتوي على Component**

وهذه أهم نقطة.

---

# مثال C#

نعمل Interface مشترك:

```csharp
public interface IFileSystemItem
{
    void Display();
}
```

## Leaf

الـ File:

```csharp
public class FileItem : IFileSystemItem
{
    private readonly string _name;

    public FileItem(string name)
    {
        _name = name;
    }

    public void Display()
    {
        Console.WriteLine($"File: {_name}");
    }
}
```

ده **Leaf** لأنه لا يحتوي على عناصر أخرى.

---

# Composite

نعمل Folder:

```csharp
public class Folder : IFileSystemItem
{
    private readonly string _name;

    private readonly List<IFileSystemItem> _items = new();

    public Folder(string name)
    {
        _name = name;
    }

    public void Add(IFileSystemItem item)
    {
        _items.Add(item);
    }

    public void Remove(IFileSystemItem item)
    {
        _items.Remove(item);
    }

    public void Display()
    {
        Console.WriteLine($"Folder: {_name}");

        foreach (var item in _items)
        {
            item.Display();
        }
    }
}
```

لاحظ:

```csharp
private readonly List<IFileSystemItem> _items;
```

الـ `Folder` يحتوي على `IFileSystemItem`.

وهذا يعني أنه يستطيع احتواء:

```text
FileItem
Folder
FileItem
Folder
...
```

---

# الاستخدام

```csharp
var cv = new FileItem("CV.pdf");
var report = new FileItem("Report.docx");

var project1 = new FileItem("Project1.cs");
var project2 = new FileItem("Project2.cs");

var projects = new Folder("Projects");

projects.Add(project1);
projects.Add(project2);

var documents = new Folder("Documents");

documents.Add(cv);
documents.Add(report);
documents.Add(projects);

documents.Display();
```

الناتج:

```text
Folder: Documents
File: CV.pdf
File: Report.docx
Folder: Projects
File: Project1.cs
File: Project2.cs
```

لاحظ الـ Tree:

```text
Documents
├── CV.pdf
├── Report.docx
└── Projects
    ├── Project1.cs
    └── Project2.cs
```

---

# أين الـ Composite هنا؟

عندنا:

```text
IFileSystemItem
       ▲
       │
   ┌───┴────┐
   │        │
 File     Folder
 Leaf    Composite
```

والـ `Folder` نفسه عبارة عن:

```csharp
List<IFileSystemItem>
```

لذلك يمكن أن يحتوي على `File` أو `Folder`.

---

# الميزة المهمة جدًا

بسبب أن الاثنين يطبقون:

```csharp
IFileSystemItem
```

نستطيع التعامل معهم بنفس الطريقة.

مثلاً:

```csharp
IFileSystemItem item;
```

يمكن أن يكون:

```csharp
item = new FileItem("CV.pdf");
```

أو:

```csharp
item = new Folder("Documents");
```

وفي الحالتين:

```csharp
item.Display();
```

نفس الـ method.

وهذه هي **الفكرة الأساسية للـ Composite Pattern**.

---

# مثال أشهر في Interview: Employee

تخيل شركة:

```text
CEO
├── Manager
│   ├── Developer
│   └── Developer
│
└── Manager
    ├── Developer
    └── Designer
```

الـ Employee العادي = **Leaf**

والـ Manager = **Composite** لأنه يحتوي على Employees.

```csharp
public interface IEmployee
{
    void ShowDetails();
}
```

Developer:

```csharp
public class Developer : IEmployee
{
    public void ShowDetails()
    {
        Console.WriteLine("Developer");
    }
}
```

Manager:

```csharp
public class Manager : IEmployee
{
    private readonly List<IEmployee> _employees = new();

    public void Add(IEmployee employee)
    {
        _employees.Add(employee);
    }

    public void ShowDetails()
    {
        Console.WriteLine("Manager");

        foreach (var employee in _employees)
        {
            employee.ShowDetails();
        }
    }
}
```

الآن:

```csharp
var manager = new Manager();

manager.Add(new Developer());
manager.Add(new Developer());

IEmployee employee = manager;

employee.ShowDetails();
```

الـ Manager نفسه يتعامل كـ `IEmployee`، بالرغم من أنه يحتوي على Employees آخرين.

---

# Composite vs Adapter vs Decorator

| Pattern   | الهدف                                          |
| --------- | ---------------------------------------------- |
| Adapter   | جعل Interfaces غير المتوافقة تعمل معًا         |
| Decorator | إضافة Behavior إلى Object                      |
| Composite | التعامل مع Object ومجموعة Objects بنفس الطريقة |

احفظها:

```text
Adapter    → Compatibility
Decorator  → Add Behavior
Composite  → Tree / Hierarchy
```

---

# متى تستخدم Composite؟

غالبًا عندما يكون عندك **Hierarchical Structure** مثل:

* File System
* Organization / Employees
* UI Components
* Menus / Submenus
* Categories / Subcategories
* Products / Product Groups
* HTML DOM
* Permissions
* Expressions / Math trees

مثلاً:

```text
Menu
├── Home
├── Products
│   ├── Phones
│   ├── Laptops
│   └── Tablets
└── About
```

هنا `Menu` يمكن أن يحتوي على `MenuItem` أو `Menu` آخر، وبالتالي Composite مناسب جدًا.

---

## 🧠 أهم جملة تحفظها للـ Interview

> **Composite Pattern allows you to compose objects into tree structures and treat individual objects and compositions uniformly.**

وبالعربي:

> **الـ Composite يسمح ببناء Tree من Objects، والتعامل مع الـ Object المفرد والمجموعة من Objects بنفس الـ Interface.**

 
 ###  2.4   Facade Pattern  


**Facade = واجهة مبسطة**

الـ Facade يوفر **واجهة واحدة بسيطة** للتعامل مع System معقد يحتوي على عدة Classes وعمليات.

بدل ما الـ Client يتعامل مع:

```text
Service A
Service B
Service C
Service D
Service E
```

نعطيه:

```text
        Facade
          ↓
   ┌──────┼──────┐
   ↓      ↓      ↓
Service A B      C
```

يعني:

> **Facade hides the complexity of a subsystem and provides a simple interface to the client.**

---

# مثال واقعي: تشغيل الكمبيوتر

تخيل أنك تريد تشغيل الكمبيوتر.

داخليًا ممكن يحصل:

```text
CPU.Start()
Memory.Load()
HardDrive.Read()
OS.Load()
Display.Start()
```

لكن أنت كمستخدم تريد:

```csharp
computer.Start();
```

هنا `ComputerFacade` يخفي كل التعقيد.

---

# مثال C#

عندنا عدة Classes:

```csharp
public class CPU
{
    public void Start()
    {
        Console.WriteLine("CPU Started");
    }
}
```

```csharp
public class Memory
{
    public void Load()
    {
        Console.WriteLine("Memory Loaded");
    }
}
```

```csharp
public class HardDrive
{
    public void Read()
    {
        Console.WriteLine("Hard Drive Read");
    }
}
```

لو الـ Client تعامل معهم مباشرة:

```csharp
var cpu = new CPU();
var memory = new Memory();
var hardDrive = new HardDrive();

cpu.Start();
memory.Load();
hardDrive.Read();
```

الـ Client أصبح يعرف تفاصيل كثيرة.

---

# نستخدم Facade

نعمل:

```csharp
public class ComputerFacade
{
    private readonly CPU _cpu;
    private readonly Memory _memory;
    private readonly HardDrive _hardDrive;

    public ComputerFacade()
    {
        _cpu = new CPU();
        _memory = new Memory();
        _hardDrive = new HardDrive();
    }

    public void Start()
    {
        _cpu.Start();
        _memory.Load();
        _hardDrive.Read();
    }
}
```

الآن الـ Client:

```csharp
var computer = new ComputerFacade();

computer.Start();
```

بدلاً من:

```text
CPU
Memory
HardDrive
```

يتعامل فقط مع:

```text
ComputerFacade
```

---

# الشكل

```text
                 Client
                   │
                   ▼
          ┌─────────────────┐
          │     Facade      │
          │                 │
          │    Start()      │
          └────────┬────────┘
                   │
          ┌────────┼────────┐
          ▼        ▼        ▼
        CPU      Memory   HardDrive
```

الـ Facade لا يلغي الـ Classes الموجودة.

هو فقط:

> **يخفي تعقيدها عن الـ Client.**

---

# مثال أقرب للـ .NET

تخيل عندك عملية إنشاء Order.

العملية تحتاج:

```text
OrderService
PaymentService
InventoryService
EmailService
ShippingService
```

بدون Facade:

```csharp
orderService.Create();

paymentService.Pay();

inventoryService.Reserve();

shippingService.CreateShipment();

emailService.SendConfirmation();
```

الـ Controller أصبح يعرف تفاصيل كثيرة.

بدلاً من ذلك:

```csharp
public class OrderFacade
{
    private readonly OrderService _order;
    private readonly PaymentService _payment;
    private readonly InventoryService _inventory;
    private readonly ShippingService _shipping;
    private readonly EmailService _email;

    public async Task PlaceOrder()
    {
        _order.Create();

        _payment.Pay();

        _inventory.Reserve();

        _shipping.CreateShipment();

        _email.SendConfirmation();
    }
}
```

والـ Controller:

```csharp
await _orderFacade.PlaceOrder();
```

وهكذا أصبح الـ Controller لا يهتم بتفاصيل العملية.

---

# Facade لا يمنعك من الوصول للـ Subsystems

هذه نقطة مهمة.

الـ Facade **ليس Adapter** ولا يقوم بإجبارك على استخدامه.

يمكن أن يكون عندك:

```text
Client
 ├──────────────→ Facade
 │                  ↓
 │             Subsystems
 │
 └──────────────→ Subsystem مباشرة
```

لكن الـ Facade يوفر الطريقة الأسهل للتعامل مع النظام.

---

> **Facade = Make a complex system simple**

---


> **Facade is a structural design pattern that provides a simple and unified interface to a complex subsystem, hiding its internal complexity from the client.**

ودي أهم فكرة فيه: **Facade لا يجعل النظام أبسط من الداخل؛ هو يجعل التعامل معه أبسط من الخارج.**


 ###  2.5   Proxy Pattern  

أكيد. **Proxy Pattern** من الـ **Structural Design Patterns**، وهو قريب جدًا من Decorator في الشكل، لكن **الهدف مختلف**.



الـ **Proxy** هو Object يعمل كـ **بديل أو وسيط (substitute)** عن Object آخر.

> **Proxy provides a surrogate or placeholder for another object to control access to it.**

يعني بدل ما الـ Client يتعامل مباشرة مع الـ Real Object:

```text
Client
  ↓
Real Object
```

يصبح:

```text
Client
  ↓
 Proxy
  ↓
Real Object
```

والـ Proxy يمكنه التحكم في الوصول إلى الـ Real Object.

---

# مثال بسيط

لنفترض عندنا:

```csharp
public interface IVideoService
{
    void GetVideo(string name);
}
```

والـ Real Object:

```csharp
public class RealVideoService : IVideoService
{
    public void GetVideo(string name)
    {
        Console.WriteLine($"Loading video: {name}");
    }
}
```

بدون Proxy:

```csharp
IVideoService service = new RealVideoService();

service.GetVideo("movie.mp4");
```

---

# نضيف Proxy

```csharp
public class VideoServiceProxy : IVideoService
{
    private readonly RealVideoService _realService;

    public VideoServiceProxy()
    {
        _realService = new RealVideoService();
    }

    public void GetVideo(string name)
    {
        Console.WriteLine("Checking access...");

        _realService.GetVideo(name);
    }
}
```

الاستخدام:

```csharp
IVideoService service = new VideoServiceProxy();

service.GetVideo("movie.mp4");
```

الـ Client يعتقد أنه يتعامل مع:

```text
IVideoService
```

لكن فعليًا:

```text
Client
  ↓
VideoServiceProxy
  ↓
RealVideoService
```

---

# لماذا نستخدم Proxy؟

لأننا نريد التحكم في الوصول إلى الـ Real Object.

أشهر الاستخدامات:

### 1. Authorization

```text
Client
  ↓
Authorization Proxy
  ↓
Real Service
```

الـ Proxy يتحقق:

```csharp
if (!user.IsAuthorized)
    throw new UnauthorizedAccessException();
```

---

### 2. Lazy Loading

لا تنشئ الـ Real Object إلا عندما تحتاجه.

```csharp
public class VideoProxy : IVideoService
{
    private RealVideoService? _realService;

    public void GetVideo(string name)
    {
        _realService ??= new RealVideoService();

        _realService.GetVideo(name);
    }
}
```

بدلاً من إنشاء الخدمة من البداية:

```text
Application Start
       ↓
   Proxy فقط
```

وعندما تحتاجها:

```text
GetVideo()
    ↓
Create Real Object
```

---

### 3. Caching

```text
Client
  ↓
Cache Proxy
  ↓
Real Service
```

لو البيانات موجودة في Cache:

```text
Return Cache
```

وإلا:

```text
Call Real Service
      ↓
Save in Cache
      ↓
Return Result
```

---

### 4. Logging

```text
Client
  ↓
Logging Proxy
  ↓
Real Service
```

---

### 5. Remote Proxy

ممكن الـ Real Object يكون موجودًا على Server آخر:

```text
Client
   ↓
Proxy
   ↓
Network
   ↓
Remote Service
```

الـ Client يتعامل معه كأنه Object محلي.

---

# أهم أنواع Proxy

| النوع                | الاستخدام                      |
| -------------------- | ------------------------------ |
| **Virtual Proxy**    | Lazy Loading                   |
| **Protection Proxy** | Authorization / Access Control |
| **Remote Proxy**     | التعامل مع Remote Object       |
| **Caching Proxy**    | Cache النتائج                  |
| **Logging Proxy**    | تسجيل العمليات                 |

---

# Proxy vs Decorator

دي أهم مقارنة لأن الاثنين شكلهم متشابه جدًا:

```text
Client
  ↓
Wrapper
  ↓
Real Object
```

لكن الـ **Intent** مختلف.

### Decorator

هدفه:

> **إضافة Behavior**

```text
Logging
   ↓
Service
```

مثلاً:

```text
Service
+
Logging
+
Caching
```

---

### Proxy

هدفه:

> **التحكم في Access إلى Object**

```text
Proxy
  ↓
Real Object
```

مثلاً:

```text
Authorization
   ↓
Service
```

---

# لكن هناك نقطة مهمة جدًا

أحيانًا **Proxy يمكن أن يبدو وكأنه Decorator**.

مثلاً:

```csharp
public class LoggingProxy : IService
{
    private readonly IService _service;

    public void Execute()
    {
        Console.WriteLine("Log");

        _service.Execute();
    }
}
```

شكله نفس Decorator تقريبًا.

الفرق ليس في الـ syntax، وإنما في **النية Intent**:

```text
Decorator
→ أريد إضافة مسؤوليات/Behavior للـ Object.

Proxy
→ أريد التحكم في الوصول إلى الـ Object.
```

---
 
# مثال مهم في .NET

في عالم .NET ستجد فكرة الـ Proxy كثيرًا مع:

* **Lazy loading**
* **ORMs مثل EF Core**
* **Dynamic proxies**
* **Authorization**
* **Caching**
* **Remote service clients**

الفكرة العامة دائمًا:

```text
                 Same Interface
                      │
                      ▼
Client ─────────► Proxy
                      │
                      ▼
                 Real Object
```

---

# 🧠 احفظ الـ Structural Patterns التي أخذناها

| Pattern       | احفظها كـ           |
| ------------- | ------------------- |
| **Adapter**   | 🔄 Change Interface |
| **Decorator** | ➕ Add Behavior      |
| **Composite** | 🌳 Tree             |
| **Facade**    | 🎯 Simplify         |
| **Proxy**     | 🛡️ Control Access  |

وأقوى طريقة للتمييز بين **Decorator و Proxy**:

> **Decorator asks: "What extra behavior can I add?"**
> **Proxy asks: "Should/how can I access the real object?"**


###  3-Behavioral Patterns


 ###  3.1   Chain of Responsibility Pattern 
  

> عندك Request، وبدل ما تحدد بنفسك مين المسؤول عن معالجته، تمرره في **سلسلة من Handlers**، وكل Handler يقرر: هل أعالجه؟ أم أمرره للذي بعدي؟

الشكل:

```text
Request
   ↓
Handler 1
   ↓
Handler 2
   ↓
Handler 3
   ↓
Handler 4
```

كل Handler عنده اختيار:

```text
"أقدر أتعامل مع الطلب؟"
       │
   ┌───┴───┐
  Yes      No
   ↓        ↓
 Handle   Next Handler
```

---

# مثال واقعي: نظام الموافقات

تخيل شركة لديها طلب شراء:

```text
Purchase Request = 50,000 EGP
```

والصلاحيات:

```text
Employee       → حتى 1,000
Manager        → حتى 10,000
Director       → حتى 100,000
CEO            → أكثر من 100,000
```

بدل أن تعمل:

```csharp
if (amount <= 1000)
{
    // Employee
}
else if (amount <= 10000)
{
    // Manager
}
else if (amount <= 100000)
{
    // Director
}
else
{
    // CEO
}
```

يمكننا استخدام **Chain of Responsibility**.

---

# 1. نعمل Request

```csharp
public class PurchaseRequest
{
    public decimal Amount { get; }

    public PurchaseRequest(decimal amount)
    {
        Amount = amount;
    }
}
```

---

# 2. نعمل Handler Base

```csharp
public abstract class Approver
{
    protected Approver? Next { get; private set; }

    public void SetNext(Approver next)
    {
        Next = next;
    }

    public abstract void Approve(PurchaseRequest request);
}
```

كل Approver لديه:

```csharp
Next
```

أي الشخص التالي في السلسلة.

---

# 3. Employee Handler

```csharp
public class Employee : Approver
{
    public override void Approve(PurchaseRequest request)
    {
        if (request.Amount <= 1000)
        {
            Console.WriteLine("Employee approved the request.");
        }
        else
        {
            Next?.Approve(request);
        }
    }
}
```

---

# 4. Manager Handler

```csharp
public class Manager : Approver
{
    public override void Approve(PurchaseRequest request)
    {
        if (request.Amount <= 10000)
        {
            Console.WriteLine("Manager approved the request.");
        }
        else
        {
            Next?.Approve(request);
        }
    }
}
```

---

# 5. Director Handler

```csharp
public class Director : Approver
{
    public override void Approve(PurchaseRequest request)
    {
        if (request.Amount <= 100000)
        {
            Console.WriteLine("Director approved the request.");
        }
        else
        {
            Next?.Approve(request);
        }
    }
}
```

---

# 6. CEO Handler

```csharp
public class CEO : Approver
{
    public override void Approve(PurchaseRequest request)
    {
        Console.WriteLine("CEO approved the request.");
    }
}
```

---

# تكوين الـ Chain

```csharp
var employee = new Employee();
var manager = new Manager();
var director = new Director();
var ceo = new CEO();

employee.SetNext(manager);
manager.SetNext(director);
director.SetNext(ceo);
```

أصبح لدينا:

```text
Employee
   ↓
Manager
   ↓
Director
   ↓
CEO
```

---

# إرسال Request

```csharp
var request = new PurchaseRequest(50000);

employee.Approve(request);
```

ماذا يحدث؟

```text
Employee
   │
   │ 50000 > 1000
   ↓
Manager
   │
   │ 50000 > 10000
   ↓
Director
   │
   │ 50000 <= 100000
   ↓
Approve ✅
```

الناتج:

```text
Director approved the request.
```

---

# الفكرة الأساسية

لاحظ أن الـ Client قال فقط:

```csharp
employee.Approve(request);
```

ولم يقل:

```csharp
if (...)
    employee
else if (...)
    manager
else if (...)
    director
```

هو لا يعرف من سيعالج الـ Request.

وهذه نقطة مهمة جدًا:

> **The sender does not need to know which handler will process the request.**

---

# مثال أقرب للـ .NET

من أشهر الأمثلة: **HTTP Middleware Pipeline**.

تخيل:

```text
HTTP Request
     ↓
Authentication
     ↓
Authorization
     ↓
Logging
     ↓
Exception Handling
     ↓
Controller
```

كل Middleware يمكنه:

1. يعمل شيئًا قبل الـ next.
2. يمرر الطلب للـ next.
3. يعمل شيئًا بعد رجوع الـ next.

مثل:

```csharp
public async Task InvokeAsync(
    HttpContext context,
    RequestDelegate next)
{
    Console.WriteLine("Before");

    await next(context);

    Console.WriteLine("After");
}
```

الفكرة قريبة جدًا من Chain of Responsibility:

```text
Request
   ↓
Middleware 1
   ↓
Middleware 2
   ↓
Middleware 3
   ↓
Controller
```

---

# مثال آخر: Validation

عندك User Registration:

```text
Request
   ↓
Required Fields Handler
   ↓
Email Validation Handler
   ↓
Password Validation Handler
   ↓
Age Validation Handler
```

كل Handler ممكن:

```text
Valid?
 ├── No  → Stop / Reject
 └── Yes → Next
```

مثلاً:

```csharp
public interface IHandler
{
    void SetNext(IHandler handler);

    void Handle(Request request);
}
```

وهذا الشكل العام جدًا للـ Pattern.

---

# الشكل العام

```text
              Request
                 ↓
        ┌────────────────┐
        │   Handler 1    │
        └───────┬────────┘
                │
          Can Handle?
           /       \
         Yes        No
          ↓          ↓
       Handle     Handler 2
                    │
                    ↓
                 Handler 3
                    │
                    ↓
                  ...
```

---

# هل كل Handlers لازم تعالج الطلب؟

**لا.**

وهنا يوجد شكلان شائعان.

### 1. Handler يعالج الطلب ويتوقف

```text
Handler 1
   ↓
Handler 2
   ↓
Handle ✅
```

ولا يكمل.

### 2. Handler يعالج ثم يكمل

```text
Handler 1
   ↓
Handle
   ↓
Handler 2
   ↓
Handle
   ↓
Handler 3
```

وهذا يعتمد على تصميم الـ Chain.

---

# مميزات Chain of Responsibility

### 1. يقلل الـ if/else

بدلاً من:

```csharp
if (...)
else if (...)
else if (...)
else if (...)
```

توزع المسؤولية على Classes.

### 2. يقلل Coupling

الـ Client لا يعرف:

```text
مين المسؤول؟
```

### 3. سهل إضافة Handler

مثلاً عندك:

```text
Employee
Manager
Director
CEO
```

وتريد إضافة:

```text
Vice President
```

يمكن إضافته للسلسلة بدون تغيير الـ Client.

### 4. يمكن تغيير ترتيب الـ Chain

مثلاً:

```text
A → B → C
```

إلى:

```text
A → C → B
```

حسب احتياج النظام.

---

# العيوب

مش دايمًا Chain أفضل.

### 1. ممكن الطلب لا يتم التعامل معه

```text
Handler 1
   ↓
Handler 2
   ↓
Handler 3
   ↓
Nobody handled it ❌
```

لازم تحدد ماذا يحدث في هذه الحالة.

### 2. Debugging ممكن يكون أصعب

لأنك لا تعرف مباشرة:

```text
مين هيعالج الطلب؟
```

لازم تتبع الـ Chain.

### 3. ممكن يكون عندك Chain طويل جدًا

```text
A → B → C → D → E → F → G → H
```

فيصبح التنفيذ والتتبع أصعب.

---

وأهم جملة للـ Interview:

> **Chain of Responsibility is a behavioral design pattern that passes a request along a chain of handlers, allowing each handler to decide whether to process the request or pass it to the next handler.**

### الفكرة في سطر واحد:

```text
Request → Handler → Handler → Handler → ... → Handler
```

**كل Handler يقول: "أنا أقدر أتعامل معاه؟ نعم → أتعامل. لا → ابعته للي بعدي."**




 
 ###  3.2   Strategy Pattern 
 أكيد. **Strategy Pattern** من أهم الـ **Behavioral Design Patterns**، وخصوصًا في C# لأنه يظهر كثيرًا في تصميم الـ Services والـ Business Logic.

 
> عندك **أكثر من طريقة لتنفيذ نفس العملية**، وتريد أن تجعل كل طريقة مستقلة ويمكن تبديلها بدون تغيير الكود الذي يستخدمها.

بدل ما يكون عندك:

```csharp
if (type == "CreditCard")
{
    // طريقة 1
}
else if (type == "PayPal")
{
    // طريقة 2
}
else if (type == "Bank")
{
    // طريقة 3
}
```

نحوّل كل طريقة إلى **Strategy مستقلة**.

---

# مثال: طرق الدفع

عندنا عملية:

```text
Pay
```

لكن عندنا طرق مختلفة:

```text
Credit Card
PayPal
Bank Transfer
```

كل واحدة لها طريقة مختلفة لتنفيذ الدفع.

نبدأ بعمل Interface:

```csharp
public interface IPaymentStrategy
{
    void Pay(decimal amount);
}
```

---

## Strategy 1 — Credit Card

```csharp
public class CreditCardPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine(
            $"Paid {amount} using Credit Card");
    }
}
```

---

## Strategy 2 — PayPal

```csharp
public class PayPalPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine(
            $"Paid {amount} using PayPal");
    }
}
```

---

## Strategy 3 — Bank Transfer

```csharp
public class BankTransferPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine(
            $"Paid {amount} using Bank Transfer");
    }
}
```

الآن عندنا:

```text
        IPaymentStrategy
              ▲
       ┌──────┼───────┐
       │      │       │
 CreditCard PayPal   Bank
```

---

# الـ Context

نحتاج Class يستخدم الـ Strategy.

```csharp
public class PaymentContext
{
    private readonly IPaymentStrategy _strategy;

    public PaymentContext(IPaymentStrategy strategy)
    {
        _strategy = strategy;
    }

    public void Pay(decimal amount)
    {
        _strategy.Pay(amount);
    }
}
```

الآن:

```csharp
var payment = new PaymentContext(
    new CreditCardPayment());

payment.Pay(1000);
```

الناتج:

```text
Paid 1000 using Credit Card
```

لو أردنا PayPal:

```csharp
var payment = new PaymentContext(
    new PayPalPayment());

payment.Pay(1000);
```

الناتج:

```text
Paid 1000 using PayPal
```

لاحظ أننا **لم نغير `PaymentContext`**.

---

# الفكرة الأساسية

عندنا:

```text
                    Context
                       │
                       ▼
                IPaymentStrategy
                       ▲
              ┌────────┼────────┐
              │        │        │
          CreditCard  PayPal   Bank
```

الـ Context لا يعرف تفاصيل طريقة الدفع.

هو يعرف فقط:

```csharp
IPaymentStrategy
```

---

# لماذا Strategy أفضل من if/else؟

بدون Strategy:

```csharp
public void Pay(string type, decimal amount)
{
    if (type == "CreditCard")
    {
        // Credit Card logic
    }
    else if (type == "PayPal")
    {
        // PayPal logic
    }
    else if (type == "Bank")
    {
        // Bank logic
    }
}
```

كلما أضفت طريقة جديدة، ستعدل نفس الـ Class.

مثلاً:

```text
Credit Card
PayPal
Bank
Apple Pay
Fawry
Wallet
```

سيصبح الـ `if/else` كبيرًا جدًا.

---

## باستخدام Strategy

كل طريقة مستقلة:

```text
CreditCardPayment
PayPalPayment
BankPayment
ApplePayPayment
FawryPayment
```

وكلها:

```csharp
IPaymentStrategy
```

لو أردت إضافة:

```text
Vodafone Cash
```

تعمل فقط:

```csharp
public class VodafoneCashPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        // Vodafone Cash logic
    }
}
```

ولا تحتاج إلى تعديل الـ Strategies الموجودة.

---

# مثال مهم في .NET

تخيل أنك تعمل **Discount System**.

عندك:

```text
Regular Customer
VIP Customer
Employee
Black Friday
```

كل واحد له طريقة مختلفة لحساب الخصم.

نعمل:

```csharp
public interface IDiscountStrategy
{
    decimal CalculateDiscount(decimal price);
}
```

Regular:

```csharp
public class RegularDiscount : IDiscountStrategy
{
    public decimal CalculateDiscount(decimal price)
    {
        return price * 0.05m;
    }
}
```

VIP:

```csharp
public class VipDiscount : IDiscountStrategy
{
    public decimal CalculateDiscount(decimal price)
    {
        return price * 0.20m;
    }
}
```

Employee:

```csharp
public class EmployeeDiscount : IDiscountStrategy
{
    public decimal CalculateDiscount(decimal price)
    {
        return price * 0.30m;
    }
}
```

ثم:

```csharp
public class DiscountService
{
    private readonly IDiscountStrategy _strategy;

    public DiscountService(IDiscountStrategy strategy)
    {
        _strategy = strategy;
    }

    public decimal GetDiscount(decimal price)
    {
        return _strategy.CalculateDiscount(price);
    }
}
```

الاستخدام:

```csharp
var service = new DiscountService(
    new VipDiscount());

var discount = service.GetDiscount(1000);
```

النتيجة:

```text
200
```

---

# Strategy وعلاقتها بـ Dependency Injection

في .NET يمكن أن تستخدم **Dependency Injection** لاختيار الـ Strategy.

مثلاً:

```csharp
public class OrderService
{
    private readonly IPaymentStrategy _paymentStrategy;

    public OrderService(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }
}
```

ثم الـ DI Container يحدد الـ implementation المناسب.

وهذا يجعل Strategy Pattern مناسبًا جدًا مع تطبيقات ASP.NET Core.

---

# Strategy vs Chain of Responsibility

بما أننا شرحنا Chain of Responsibility قبله، الفرق مهم جدًا.

## Strategy

أنت تختار **Strategy واحدة**:

```text
             Payment
                ↓
        Choose ONE Strategy
          ↙      ↓      ↘
      Card     PayPal    Bank
```

مثلاً:

```text
Payment → PayPal
```

---

## Chain of Responsibility

الـ Request يمر على **عدة Handlers**:

```text
Request
   ↓
Handler A
   ↓
Handler B
   ↓
Handler C
```

كل Handler يقرر:

```text
أعالجه؟
  ↓
Yes → Handle
No  → Next
```

### باختصار:

```text
Strategy
→ Choose ONE algorithm

Chain of Responsibility
→ Pass request through handlers
```

---
 
# 🧠 الخلاصة

احفظها كالتالي:

```text
Strategy = Choose an Algorithm
```

عندك:

```text
        Context
           ↓
       Strategy
           ↑
    ┌──────┼──────┐
    ↓      ↓      ↓
    A      B      C
```

والفكرة الأساسية:

> **Define a family of algorithms, encapsulate each one, and make them interchangeable.**

 
**أهم كلمة لـ Strategy في الـ Interview: `Interchangeable Algorithms`.**


###  3.3   Template Method Pattern 


> نحدد **الخطوات الأساسية للـ Algorithm** في Base Class، ونترك بعض الخطوات للـ Subclasses لكي تحدد تفاصيل تنفيذها.

يعني عندنا Algorithm ثابت:

```text
Step 1
Step 2
Step 3
Step 4
```

لكن بعض الخطوات تختلف من Class إلى آخر.

فنضع الهيكل في الـ Base Class:

```text
        Base Class
       Template Method
             │
      ┌──────┼──────┐
      ↓      ↓      ↓
    Step1   Step2   Step3
              ↑
        Subclass defines
```

---

# مثال: تحضير مشروب ☕

تخيل أن عندنا:

* Tea
* Coffee

الاثنان لهما نفس خطوات التحضير:

```text
1. Boil Water
2. Brew
3. Pour Into Cup
4. Add Condiments
```

لكن:

```text
Tea:
Brew → Steep tea
Condiments → Add lemon

Coffee:
Brew → Drip coffee
Condiments → Add sugar
```

إذن الـ **Algorithm نفسه ثابت**، لكن بعض التفاصيل تختلف.

---

# 1. الـ Base Class

```csharp
public abstract class Beverage
{
    public void Prepare()
    {
        BoilWater();

        Brew();

        PourIntoCup();

        AddCondiments();
    }

    private void BoilWater()
    {
        Console.WriteLine("Boiling water");
    }

    protected abstract void Brew();

    private void PourIntoCup()
    {
        Console.WriteLine("Pouring into cup");
    }

    protected abstract void AddCondiments();
}
```

لاحظ أهم Method:

```csharp
public void Prepare()
```

هذه هي **Template Method**.

هي التي تحدد ترتيب الخطوات:

```text
BoilWater
    ↓
Brew
    ↓
PourIntoCup
    ↓
AddCondiments
```

والـ Subclasses لا تستطيع تغيير ترتيب الـ Algorithm.

---

# 2. Tea

```csharp
public class Tea : Beverage
{
    protected override void Brew()
    {
        Console.WriteLine("Steeping tea");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Adding lemon");
    }
}
```

---

# 3. Coffee

```csharp
public class Coffee : Beverage
{
    protected override void Brew()
    {
        Console.WriteLine("Dripping coffee through filter");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Adding sugar");
    }
}
```

---

# الاستخدام

```csharp
Beverage tea = new Tea();

tea.Prepare();
```

الناتج:

```text
Boiling water
Steeping tea
Pouring into cup
Adding lemon
```

ولو:

```csharp
Beverage coffee = new Coffee();

coffee.Prepare();
```

الناتج:

```text
Boiling water
Dripping coffee through filter
Pouring into cup
Adding sugar
```

لاحظ أن:

```csharp
Prepare()
```

لم تتغير.

الذي تغير فقط هو:

```text
Brew()
AddCondiments()
```

---

# أين الـ Template Method؟

الـ Template Method هي:

```csharp
public void Prepare()
{
    BoilWater();
    Brew();
    PourIntoCup();
    AddCondiments();
}
```

هي **Template** لأنها تحدد الشكل العام للـ Algorithm.

---

# الشكل

```text
                 Beverage
                    │
             Prepare() ← Template
                    │
        ┌───────────┴───────────┐
        ↓                       ↓
       Tea                    Coffee
        │                       │
     Brew()                  Brew()
     Condiments()            Condiments()
```

---

# لماذا نستخدمه؟

لنفترض أن عندك 10 أنواع من المشروبات.

كل واحد يعمل:

```text
Boil Water
   ↓
Brew
   ↓
Pour
   ↓
Add Condiments
```

لو كل Class كتب العملية بالكامل، ممكن يحصل اختلاف:

```text
Tea:
Boil → Brew → Pour → Condiments

Coffee:
Brew → Boil → Pour → Condiments ❌
```

أو واحد ينسى خطوة.

الـ Template Method يضمن أن:

> **الـ Algorithm structure ثابت، والـ subclasses تغير التفاصيل فقط.**

---

# Hook Methods

أحيانًا نريد أن تكون هناك خطوة **اختيارية**.

مثلاً:

```csharp
public abstract class Beverage
{
    public void Prepare()
    {
        BoilWater();
        Brew();
        PourIntoCup();

        if (CustomerWantsCondiments())
        {
            AddCondiments();
        }
    }

    private void BoilWater()
    {
        Console.WriteLine("Boiling water");
    }

    protected abstract void Brew();

    private void PourIntoCup()
    {
        Console.WriteLine("Pouring into cup");
    }

    protected abstract void AddCondiments();

    protected virtual bool CustomerWantsCondiments()
    {
        return true;
    }
}
```

الـ Subclass يمكنه تغيير الـ Hook:

```csharp
protected override bool CustomerWantsCondiments()
{
    return false;
}
```

فالـ **Hook** هو Method يوفر نقطة يمكن للـ Subclass أن يغير عندها السلوك، وغالبًا يكون له implementation افتراضي.

---

والجملة الذهبية للـ Interview:

> **Template Method defines the skeleton of an algorithm in a base class and lets subclasses override specific steps without changing the overall algorithm structure.**

وأهم كلمتين:

**Template Method = Inheritance + Fixed Algorithm Structure**.


###  3.4   🔄 State Design Pattern
 

> **State = Change Behavior When State Changes**


الـ Order ممكن يكون:

```text
Pending → Paid → Shipped → Delivered
```

وكل حالة لها سلوك مختلف:

* `Pending` → يمكن الدفع.
* `Paid` → يمكن الشحن.
* `Shipped` → يمكن التوصيل.
* `Delivered` → لا يمكن عمل أي شيء آخر.

---

# ❌ المشكلة بدون State Pattern

ممكن تعمل كل شيء داخل `Order`:

```csharp
public class Order
{
    public string Status { get; set; }

    public void Process()
    {
        if (Status == "Pending")
        {
            Console.WriteLine("Waiting for payment...");
        }
        else if (Status == "Paid")
        {
            Console.WriteLine("Preparing shipment...");
        }
        else if (Status == "Shipped")
        {
            Console.WriteLine("Order is on the way...");
        }
        else if (Status == "Delivered")
        {
            Console.WriteLine("Order already delivered.");
        }
    }
}
```

المشكلة أن الـ `Order` بدأ يحتوي على منطق خاص بكل State.

ومع زيادة الحالات:

```text
Pending
Paid
Shipped
Delivered
Cancelled
Returned
Refunded
...
```

الـ `if/else` سيصبح كبيرًا جدًا.

---

# ✅ الحل باستخدام State Pattern

ننشئ Interface يمثل الـ State:

```csharp
public interface IOrderState
{
    void Process(Order order);
}
```

ثم كل State يكون له Class خاص به.

### Pending State

```csharp
public class PendingState : IOrderState
{
    public void Process(Order order)
    {
        Console.WriteLine("Waiting for payment...");

        order.SetState(new PaidState());
    }
}
```

### Paid State

```csharp
public class PaidState : IOrderState
{
    public void Process(Order order)
    {
        Console.WriteLine("Preparing shipment...");

        order.SetState(new ShippedState());
    }
}
```

### Shipped State

```csharp
public class ShippedState : IOrderState
{
    public void Process(Order order)
    {
        Console.WriteLine("Order is on the way...");

        order.SetState(new DeliveredState());
    }
}
```

### Delivered State

```csharp
public class DeliveredState : IOrderState
{
    public void Process(Order order)
    {
        Console.WriteLine("Order already delivered.");
    }
}
```

---

# 🧠 الـ Context

الـ `Order` هنا يسمى **Context**.

هو لا يحتوي على تفاصيل كل State، وإنما يحتفظ بالـ State الحالي ويطلب منه تنفيذ العملية.

```csharp
public class Order
{
    private IOrderState _state;

    public Order()
    {
        _state = new PendingState();
    }

    public void SetState(IOrderState state)
    {
        _state = state;
    }

    public void Process()
    {
        _state.Process(this);
    }
}
```

الاستخدام:

```csharp
var order = new Order();

order.Process();
order.Process();
order.Process();
order.Process();
```

Output:

```text
Waiting for payment...
Preparing shipment...
Order is on the way...
Order already delivered.
```

لاحظ أن:

```csharp
order.Process();
```

نفس الـ method، لكن **السلوك تغير حسب الـ State الحالي**.

---

# 🔥 شكل الـ Pattern

```text
                ┌─────────────────┐
                │      Order      │
                │    Context      │
                └────────┬────────┘
                         │
                         │ Current State
                         ▼
                ┌─────────────────┐
                │ IOrderState     │
                │                 │
                │ + Process()     │
                └────────┬────────┘
                         │
          ┌──────────────┼──────────────┐
          ▼              ▼              ▼
 ┌──────────────┐ ┌──────────────┐ ┌──────────────┐
 │ PendingState │ │  PaidState   │ │ ShippedState │
 └──────────────┘ └──────────────┘ └──────────────┘
```

والـ State نفسه يستطيع الانتقال إلى State آخر:

```text
Pending
   │
   ▼
Paid
   │
   ▼
Shipped
   │
   ▼
Delivered
```

---

# 🎯 مثال أشهر في الـ .NET

تخيل **Document Workflow**:

```text
Draft
  ↓
Submitted
  ↓
UnderReview
  ↓
Approved
  ↓
Published
```

كل State له عمليات مختلفة.

مثلاً:

### Draft

```csharp
public class DraftState : IDocumentState
{
    public void Submit(Document document)
    {
        Console.WriteLine("Document submitted.");

        document.SetState(new UnderReviewState());
    }

    public void Approve(Document document)
    {
        Console.WriteLine("Cannot approve a draft.");
    }
}
```

بينما:

```csharp
public class UnderReviewState : IDocumentState
{
    public void Approve(Document document)
    {
        Console.WriteLine("Document approved.");

        document.SetState(new ApprovedState());
    }
}
```

وهذا مفيد جدًا في الأنظمة التي فيها **Workflow**.

---
 
---

## 🧠 احفظها للـ Interview

> **State Pattern allows an object to change its behavior when its internal state changes, by encapsulating state-specific behavior into separate state classes.**

وبالعربي:

> **State Pattern بيخلي الـ Object يغير سلوكه تلقائيًا حسب الـ State الحالي، عن طريق فصل سلوك كل State في Class مستقل.**

### أسهل طريقة تفتكره:

**State = Workflow / Lifecycle / Behavior depends on current state**

مثال تحفظه:

```text
Order

Pending → Paid → Shipped → Delivered
```

**لو شفت `switch` كبير على `Status` → فكر في State Pattern.**

