using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//C# Function or method

//Method is a block of code that has a signature.

//Method is used to execute statements specified in the code block.

//A Method consists of the following components:

//Method name: It is a unique name that is used to make Method call.

//Return type: It is used to specify the data type of function return value.

//Body: It is a block that contains executable statements.

//Access specifier: It is used to specify function accessibility in the application.

//Parameters: It is a list of arguments that we can pass to the function during call.



namespace CallByValue
{

    //==========C# Call By Value=========

    //In C#, value-type parameters are that pass a copy of original value to the function rather than reference.
    //It does not modify the original value. A change made in passed value does not alter the actual value.
    //In the following example, we have pass value during function call.


    class Program
    {
        // User defined function  
        public void Show(int val)
        {
            val *= val; // Manipulating value  
            Console.WriteLine("Value inside the show function " + val);
            // No return statement  
        }
        // Main function, execution entry point of the program  
        static void Main1(string[] args)
        {
            int val = 50;
            Program program = new Program(); // Creating Object  
            Console.WriteLine("Value before calling the function " + val);
            program.Show(val); // Calling Function by passing value            
            Console.WriteLine("Value after calling the function " + val);
        }
    }

    // output
    //Value before calling the function 50
    //Value inside the show function 2500
    //Value after calling the function 50

}


namespace CallByReference
{

    //C# Call By Reference
   //C# provides a ref keyword to pass argument as reference-type.
   //It passes reference of arguments to the function rather than copy of original value.
   //The changes in passed values are permanent and modify the original variable value.


    class Program
    {
        // User defined function  
        public void Show(int val)
        {
            val *= val; // Manipulating value  
            Console.WriteLine("Value inside the show function " + val);
            // No return statement  
        }
        // Main function, execution entry point of the program  
        static void Main1(string[] args)
        {
            int val = 50;
            Program program = new Program(); // Creating Object  
            Console.WriteLine("Value before calling the function " + val);
            program.Show(val); // Calling Function by passing value            
            Console.WriteLine("Value after calling the function " + val);
        }
    }

    // output
    //Value before calling the function 50
    //Value inside the show function 2500
    //Value after calling the function 50

}


namespace OutParameter
{
    //C# Out Parameter

    //C# provides out keyword to pass arguments as out-type.
    //It is like reference-type, except that it does not require variable to initialize before passing.
    //We must use out keyword to pass argument as out-type.
    //It is useful when we want a function to return multiple values.


    class Program
    {
        // User defined function  
        public void Show(out int a, out int b) // Out parameter  
        {
            int square = 5;
            a = square;
            b = square;
            // Manipulating value  
            a *= a;
            b *= b;
        }
        // Main function, execution entry point of the program  
        static void Main(string[] args)
        {
            int val1 = 50, val2 = 100;
            Program program = new Program(); // Creating Object  
            Console.WriteLine("Value before passing \n val1 = " + val1 + " \n val2 = " + val2);
            program.Show(out val1, out val2); // Passing out argument  
            Console.WriteLine("Value after passing \n val1 = " + val1 + " \n val2 = " + val2);
        }
    }

    // output
    //Value before passing
    // val1 = 50
    // val2 = 100
    //Value after passing
    // val1 = 25
    // val2 = 25
}