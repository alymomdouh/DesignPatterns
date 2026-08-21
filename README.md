### Here Found Some Learned Design Patterns With Examples In C # 

### the Sources is 

### 1- [Design Patterns بالعربي Youtube PlayList](https://www.youtube.com/playlist?list=PL6DpjIj6ySiHPDuN_JN49rYbQwnsxRdee)


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


