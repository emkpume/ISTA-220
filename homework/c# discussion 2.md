# Emeka Mkpume
## HomeWork 02 C# discussion
### January 15, 2020


1. What is a local variable ?

	They are variables that exist only in a method or another small section of code.

2. What is a statement ?

	A statement is a command that performs an action, such as calculating a value and 
	storing the result or displaying a message to a user. 
	You combine statements to create methods. if it ends with a semi colon, then it is a statement.
	An expression is a piece of code that evaluates to a value.

3. What is an identifier ?

	Identiﬁers are the names that you use to identify the elements in your programs, 
	such as namespaces, classes, methods, and variables. You cannot use special character in an identifier.	
	Dont start an identifier with an underscore.
	Dont create identifier that only differ by case.
	Start the name with a lowercase letter
	In a multi-word identifier, start the second and each subsequent word with an uppercase letter(camelCase notation). 

4. What is a variable ?

	A variable is a storage location that holds a value. A variable is a name locator in memory
	that contains a value with a type. You can think of a variable
	as a box in the computer’s memory that holds temporary information. You must give 
	each variable in a program an unambiguous name that uniquely identiﬁ es it in the 
	context in which it is used. You use a variable’s name to refer to the value it holds. 
	For example, if you want to store the value of the cost of an item in a store, you might 
	create a variable simply called cost and store the item’s cost in this variable. Later on,
	if you refer to the cost variable, the value retrieved will be the item’s cost that you stored there earlier.
	
5. What is a method ?

	A method is a named sequence of statements.it is a code of blocks that contains a series of statements.
	If you have previously programmed by using a  language such as C, C++,
	or Microsoft Visual Basic, you will see that a method is similar to a function or a  subroutine. A method has a name
	and a body. The method name should be a meaningful  identiﬁ er that indicates the overall purpose of the method 
	(calculateIncomeTax, for example). The method body  contains the actual statements to be run when the method is called.
	Additionally, methods can be given some data for processing and can return information, which is usually the result of the  processing. 
	Methods are a fundamental and powerful mechanism.

6. Are primitive types and value types the same thing ?

	primitive types are the basic types of data (something that already exist in your knowledge) e.g.
        byte, short, int, long, float, double, boolean, char, string.
        primitive variables store primitive values.
	A value type is where the content of the variable is the value itself.
   	reference types(memory address) are any instantiable class as well as arrays
        String, Scanner, Random, Die, int[], String[], etc.
        reference variables store addresses
	The main difference between primitive and reference type is that primitive type always 
	has a value, it can never be null but reference type can be null, which denotes the absence of value. 
	
7. How are arithmetic operators and variable types related ?
	
	Arithmetic Operators are used to perform basic arithmetic calculations like addition, subtraction, division.
	All variables in the Java language must have a data type. A variable's type determines the values that the variable can have and the
	operations that can be performed on it. For example, the declaration int count declares that count is an integer (int). Integers can 
	have only whole number values (both positive and negative) and you can use the standard arithmetic operators (+, -, and so on) on integers
	to perform the standard arithmetic operations (addition, subtraction, and so on). 
	
8. How do you turn an integer into a string ?
	
	by using the string method
	one method is to create an instance of Integer class and then invoke it's toString() method. This is a little less efficient than the first 
	two options shown above. This is because a new instance of Integer is created before conversion is performed.
	

9. How do you turn a string into an integer ?

	The most direct solution to convert a string to an integer is to use the parseInt method of the Java Integer class. parseInt converts the String 
	to an int, and throws a NumberFormatException if the string can’t be converted to an int type.
	
10. What is the difference between precedent and associativity ? Give an example where this makes a difference.
	precedence is priority in vertical. associativity is also precedence in horizontal dimension.
	precedence governs the order in which an expression's operators are evaluated. 
	associativity becomes important when an expression contains different operators that have the same precedence.
	associativity is the direction (left or right) in which the operator are evaluated.
	
11. What is the definite assignment rule ?

	You must assign a value to a variable before you can use it.

12. How are the prefix and postfix increment and decrement operators evaluated differently ?

	In Increment operators the computer add one and decrement substarcts one. 

13.what is string interpolation ?

	It is a method of including a variable in string. 
	An interpolated string is a string literal that might contain interpolation expressions. 
	When an interpolated string is resolved to a result string,
	items with interpolation expressions are replaced by the string representations of the expression results.
	 
14. What does the var keyword do ?

	the var is a storage. The C# var keyword is used to declare implicit type variables in C#. Let's learn when to use a var in C#.
	 C# allows variables to be declared as explicit type or implicit type.
	In ASP.NET programming, you use var if you are not sure and let the computer figure it out for you.


