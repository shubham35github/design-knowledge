# Design Pattern
> **Programming paradigm** <br /> 
It is a style/ way of pragramming.<br />
Langruage<br />
  has-->Building Blocks<br />
      has--->One or More Paradigms<br />
Types of Paradigm<br />
  --> Interactive: How to solve ? (Procedural object Oriented)<br />
  --> Declarative: What to solve ? (Functional , Logic)<br />
  
> **Object Orintation Thought Process**<br />
  Contains Objects<br />
    having-->"Role & Responsibility"<br />
    that--> "Collaborate & Communicate"<br />
                dialogue--> Vocabolary [Essential]<br />
                
> **Functional Orintation Thought Process**<br />
  has--> "Input" --> "Task" --> "Output" (Purely involment of Functions)<br />
  some chain to tasks, one function can call other and so on....<br />
  Example: F1.F2.F3.....<br />
  
  We have to wirte the code such that it should be Unit Testable and Maintainable( Less- refactoring) <br />
  
> **SOLID Principles for Good design pattern**:<br />
  -> Seperation of responsibility <br />
  -> Appropriate Reusability <br />
  -> Essential Abstraction <br />
  
> **Encapsulation** <br />
  -> exhibit Seperation of Resposibilities <br />
  -> Should not violate he SRP (Single Responsibility Principle)<br />
        -> High Cohesio <br />
              -> Example: <br />
              M : Information <br />
              V: Presentation <br />
              C: Event Handling <br />
 -> If we Violate SRP, that class we will call it as GOD class, and Method we call it as Brain Method. Because God and brain are doing everything.
  
> **Appropriate Resuability** <br />
  -> Demand: Relationship <br />
                     -> Relationship has <br />: IS-A : Inheritance -> Complete Code reusability <br />
                                        : Has-A : Where one object reuse by other Object. <br />
                                                -> Association, <br />
                                                -> Aggregation and<br />
                                                -> Composition  <br />
                                           -> Has-A has Dependecny Concept <br />
                                                  --> Inversion Principle <br />
                                                  --> Injection Principle <br />
                                                      ---> Contain Principle <br />


> **Dependency Inversion Principle** <br />
  -> High Level of Module should not depend on low Level of Module, instead it should depend on interface or any implementation of it. <br /> 
  ![image](https://user-images.githubusercontent.com/22257234/118754374-8dd9ff00-b884-11eb-8fa6-aefcfb6fed00.png) <br />
  
  Here this Principle follows **Strategy Pattern** : Everytime when you are using run-time polymorphism thenit should be strategy pattern, here in above example low-level module or family cab be use at run time and any strategy can be use at runtime. <br />
  Instead of implementing a single algorithm directly, code receives run-time instructions as to which in a family of algorithms to use. <br />
  ![image](https://user-images.githubusercontent.com/22257234/119303550-9155f780-bc83-11eb-95d0-e575f9a8f3c9.png) <br />
  _Strategy Pattern is compatible with Open/Closed Principle (OCP): Class should open for extension and Closed for modification_
  
> **Composite Pattern** <br />
Describes a group of objects that are treated the same way as a single instance of same type of object. A part-whole hierarchy should be represented as tree structure. <br />
![image](https://user-images.githubusercontent.com/22257234/119307396-44751f80-bc89-11eb-8e74-3c5ddcf38f01.png) <br />
Composite should be used when clients ignore the difference between compositions of objects and individual objects. If programmers find that they are using multiple objects in the same way, and often have nearly identical code to handle each of them, then composite is a good choice; it is less complex in this situation to treat primitives and composites as homogeneous. <br />
Below is the example of both Strategy and Composite Pattern <br />
![image](https://user-images.githubusercontent.com/22257234/119306898-7d60c480-bc88-11eb-8106-82ca5b66e7c8.png) <br />
_At Run-time you can allow to use any strategy (say search_by_MRN, Search_by_Name, etc... ) and One SearchStrategy component can be indiviudal object as well as compositions of Objects._ <br />
Two Design Variants for defining and implementing Composite Design Pattern : <br />
1. Design of Uniformity:  Child-related operations are defined in the Component interface. This enables clients to treat Leaf and Composite objects uniformly. But type safety is lost because clients can perform child-related operations on Leaf objects.<br />
2. Design for type safety: Child-related operations are defined only in the Composite class. Clients must treat Leaf and Composite objects differently. But type safety is gained because clients cannot perform child-related operations on Leaf objects. <br />
**Note: The Composite design pattern emphasizes uniformity over type safety.** <br />
![image](https://user-images.githubusercontent.com/22257234/119309412-e72e9d80-bc8b-11eb-93b2-4b4a68477981.png) <br />

> **Dynamic Composition** <br />
All behavior to be added to an individual object dynamically without affecting the behavior of other existing object. <br />
![image](https://user-images.githubusercontent.com/22257234/119312942-966d7380-bc90-11eb-91fd-bb3ed9477a14.png) <br />
Above example of pizza can be defined dynamic composition, Elder may have less Cheese toppins, Child may be no chilly flake, Adult may have both. But this will be dynamic decision Pizza company dont know the behavior at run time, it would be dynaamic decision at run time. <br />
-> We can Implement Dynamic Composition using Decorator Design Pattern <br />

> **Decorator Design Pattern** <br />
All behavior to be added to an individual object dynamically without affecting the behavior of other existing object  from the same class.<br />
-> Responsibilities should be added to (and removed from) an object dynamically at run-time. <br />
-> A flexible alternative to subclassing for extending functionality should be provided. <br />





