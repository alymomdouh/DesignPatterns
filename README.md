### Here Found Some Learned Design Patterns With Examples In C # 

### the Sources is 

### 1- [Design Patterns بالعربي Youtube PlayList](https://www.youtube.com/playlist?list=PL6DpjIj6ySiHPDuN_JN49rYbQwnsxRdee)


# The Pref And Interview Questions 

 
 ## What is the Design Patterns
 
 Design Patterns are proven, **reusable solutions to common software design problems**.
 
 They are not ready-made code, but rather templates or best practices for structuring classes and objects.

Think of them as:

- Algorithms solve coding problems.
- Design Patterns solve design problems.

## What Categories of Design Patterns

The Gang of Four (GoF) patterns are divided into 3 categories:

####  1. Creational Patterns
 Concerned with object creation
####  2. Structural Patterns
Concerned with relationships between classes.
####  3. Behavioral Patterns
Concerned with communication between objects.

-------------------------------------------
##  1. Creational Patterns
###  1.1 Prototype

	Is a creational design pattern that allows you to create new objects by copying (cloning) an existing object instead of creating them from scratch.

	It's useful when:


 - Creating an object is expensive or complex.
 - You need many similar objects with slight modifications.
 - You want to avoid repeating initialization logic.

####  Prototype Structure

The Prototype pattern usually consists of:

- 1-Prototype Interface
  
Declares a clone method.

- 2-Concrete Prototype
 
Implements cloning logic.

- 3-Client

Uses the prototype to create new objects.