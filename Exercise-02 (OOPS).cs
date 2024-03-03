
// Go through below article for in-depth knowledge

// https://www.tutorialsteacher.com/csharp/object-oriented-programming

// https://www.c-sharpcorner.com/UploadFile/mkagrahari/introduction-to-object-oriented-programming-concepts-in-C-Sharp/


// Abstraction Example

namespace Abstraction 
{
    // Abstract class
    public abstract class Shape
    {
        // Abstract method to calculate area
        public abstract double CalculateArea();
    }

    // Concrete class Circle inheriting from Shape
    public class Circle : Shape
    {
        public double Radius { get; set; }

        // Constructor
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Implementation of abstract method
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Concrete class Rectangle inheriting from Shape
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        // Constructor
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Implementation of abstract method
        public override double CalculateArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating instances of concrete classes
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 6);

            // Calling abstract method without knowing the actual implementation
            Console.WriteLine("Area of Circle: " + circle.CalculateArea());
            Console.WriteLine("Area of Rectangle: " + rectangle.CalculateArea());
        }
    }

}

// Example of Encapsulation

namespace Encapsulation
{
    
    public class BankAccount
    {
        // Private fields
        private string accountNumber;
        private double balance;

        // Public properties with encapsulated access
        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public double Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        // Constructor
        public BankAccount(string accountNumber, double initialBalance)
        {
            this.accountNumber = accountNumber;
            this.balance = initialBalance;
        }

        // Method to deposit money
        public void Deposit(double amount)
        {
            if (amount > 0)
                balance += amount;
            else
                Console.WriteLine("Invalid amount for deposit.");
        }

        // Method to withdraw money
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
                balance -= amount;
            else
                Console.WriteLine("Invalid amount for withdrawal or insufficient balance.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of BankAccount
            BankAccount account = new BankAccount("123456789", 1000);

            // Accessing properties and methods
            Console.WriteLine("Account Number: " + account.AccountNumber);
            Console.WriteLine("Balance: " + account.Balance);

            account.Deposit(500);
            Console.WriteLine("New Balance after deposit: " + account.Balance);

            account.Withdraw(200);
            Console.WriteLine("New Balance after withdrawal: " + account.Balance);
        }
    }
}