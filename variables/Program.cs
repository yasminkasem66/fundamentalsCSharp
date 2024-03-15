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
            // declaration
            int num;
            //assignment 
            num = 5;
            //initialization
            int num2 = 10;

            //string refernce type
            string firstName = "Yasmin";
            string lastName = "Yasmin";
            var isStringEqual = firstName == lastName;// true cmmon language run time run an equailty operator which make a special for string

            //regular concatanition  + sign
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
            //string interpolation 
            string fullName2 = $" {firstName} {lastName}";
            Console.WriteLine(fullName2);


            //var:data type resolved in compile time s it's only resolved once

            var f = 0f;
            var d = 0d;
            var m = 0m;
            var l = 0l;
            var ul = 0ul;

            //dynamic :data type resolved in run  time s it's only resolved once
            dynamic x = 1;
            x = "yasmin";

            char letter = 'A';

            //Expressions 
            var x1 = 10;
            var x2 = 10;

            var isValid = x1 == x2;
            Console.WriteLine(isValid);
            Console.ReadKey();

            //Comparison Operators  < <= > >= == !=
            //Equality Operators  =
            //negation   ! 
            //Conditional Operators &&  ||  ^  xor
            //  &&  || make  short circuit  while | & didn't make short circuit
            // ternary perator


            // array refernce type , fixed number, they stored beside each other , the pointer point at  the first element
            string[] friends = new string[5];
            friends[0] = "Jasmin";
            friends[1] = "Ali";
            friends[2] = "mohamed";
            friends[3] = "Dailia";
            friends[4] = "Jamal";
            //friends.Print();

            string[] friends1 = new string[5] {
              "Jasmin",
            "Ali",
            "mohamed",
            "Dailia",
            "Jamal",
        };
            var slice1 = friends[..2]; // get from 0 to 2 index
            var slice2 = friends[2..]; // skip first two elements
            var slice3 = friends[2..3]; //start from  two end till 3
            string[] friends2 = {
              "Jasmin",
            "Ali",
            "mohamed",
            "Dailia",
            "Jamal",
        };

            //multi deminission array
            //jadge array ( array inside an array) multidieminsion array but better performance

            // ----------------------------------------------------
            //Expression Types 
            var amunt = Math.Cos(30);  //1- primary expression
            Console.WriteLine("amunt"); //2- void expression
                                        //2- assign expression  % binary opertor  assignment from right to left  
            string s1 = null;  var s = s1 ?? "yasmin";  //null coalesing operator  //s1.tosth() null refernce exception
        }
    }
}
