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

 

