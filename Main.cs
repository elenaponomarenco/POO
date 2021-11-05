//  1. Create 10 classes with their names as first 10 aphabetical letters (A, B, C, D, ... , J).
// 	Each next class inherits from previous letter class (ex: `B inherits from A, C inherits from B ...`).
// 	2. Each class should have their own String property with corresponding letter as their reference (ex: `class A -> public String a; class B -> String b; ...; );
// 	3. Create by an object of each class type and print it in console in a clever way (so that all objects states are showed).
//  - _Medium Level_ (mark 7 || 8):
//  1. Change all states from previous classes from public access specifiers to protected.
// 	2. Create class X which has a private String name property that should have also a constructor for that X.
// 	3. Add a instance variable of X type to A class as a state and modify the constructor of A from `A(new String("blabla"))` to `A(new String("blabla"), new X("some name"))`.
// 	Checkout for errors if appeared in child classes and try to resolve the issue.     `hint: use super("blabla", x)`.
// 	4. Finally print J and see what states does it have.
//   - _Advanced Level_ (mark 9 || 10):
//  1. Add initial value to state X from class A. (ex: `protected X x = new X("xxx")`).  Print a object of J and see the result.
// 	2. Go in class D and create also a state with the same name `x` as in class A and give another initial value. Print the result and checkout if any changes.
// 	3. Now do the same in class H and add to a state x another initial value. Chackout again if any changes when printing object of class J.
// 	4. Make the property `x` from class `H` private and checkout now if any errors appeared and try to solve them.
// 	`hint: property x is not visible any more in child classes cause of private modifier in most near by hierarchy class containing this state.`

using System;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            X obj_X = new X("some text");
            J obj_J = new J("A ", "B ", "C ", "D ", "E ", "F ", "G ", "H ", "I ", "J ", obj_X);
            Console.WriteLine(obj_J.printClasses()); 
            A objA = new A("a", obj_X);
            Console.WriteLine(objA);
        }
    }
}
