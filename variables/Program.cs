namespace variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // data integrity
            // performance
            // security
            // reliability

            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, World!");
            Console.ReadKey();
            // declaration
            int num;
            //assignment 
            num = 5;
            //initialization
            int num2 = 10;

            //string refernce type
            string firstName = "Yasmin";
            string lastName = "Kasem";

            //regular concatanition  + sign
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
            //string interpolation 
            string fullName2 =   $" {firstName} {lastName}";
            Console.WriteLine(fullName2);


            //var:data type resolved in compile time s it's only resolved once

            var f = 0f;
            var d = 0d;
            var m= 0m;
            var l =0l;
            var ul = 0ul;

            //dynamic :data type resolved in run  time s it's only resolved once
            dynamic x = 1;
            x = "yasmin";

            char letter = 'A';

        }
    }
}
