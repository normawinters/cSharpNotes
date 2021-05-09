using System;

namespace cSharpNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "answers quickly";
            Console.WriteLine(txt.ToUpper());   
            Console.WriteLine(txt.ToLower());  
            Console.WriteLine(txt.Length);


            Console.WriteLine("string interpolation, which substitutes values of variables into placeholders in a string. Note that you do not have to worry about spaces");
            string firstName = "Happy";
            string lastName = "Day";
            string name = $"Hello, have a {firstName} {lastName}";
            Console.WriteLine(name);

            string myString = "05/09/2021";
            Console.WriteLine("second Position : "+myString[2]);
            Console.WriteLine(myString.IndexOf("5"));

            // Location of the letter D
            int charPos = myString.LastIndexOf("/") +1;
            string newString = myString.Substring(charPos);
 
            Console.WriteLine("Year "+newString);

            int location2 = myString.IndexOf('/', myString.IndexOf('/') + 1);
            Console.WriteLine("location 2 of / in  "+myString+" " +location2);

            Console.WriteLine("Use \\ to escape special characters like double quote");

            string msg ="He said \"love others\" .";
            Console.WriteLine(msg);

            string msg1 = "first line\nNext line. ";
            Console.WriteLine(msg1);

            string msg2 = "This is a tab \tafter the tab.";
            Console.WriteLine(msg2);

            string msg3 = "This is a backspace\b after the backspace";
            Console.WriteLine(msg3);

            int nbrBox = 18;
            int maxBox = 20;
            if (nbrBox <= maxBox)
            {
                Console.WriteLine("Moving "+ nbrBox+" boxes.");
            }
            else
            {
                Console.WriteLine("Too many boxes to move.");
            }

            Console.WriteLine("***Short hand ternary operator***");
            string result = (maxBox < 18) ? "Move." : "too Many boxes.";
            Console.WriteLine(result);




            Console.WriteLine("**** Switch ****");


            string Street = "North Street";
            switch (Street)
            {
                case "Blues Avenue":
                    Console.WriteLine("stop and listen");
                    break;
                case "Hill Street":
                    Console.WriteLine("apply breaks");
                    break;
                case "North Street":
                    Console.WriteLine("going home");
                    break;
                default:
                    Console.WriteLine("stop");
                    break;
                
            }

            Console.WriteLine("break stops testing the cases , reduce time of unecessary checks.");

            Console.WriteLine(" ");
            Console.WriteLine("*** While Loop less than 5 ****");

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }


            Console.WriteLine(" ");
            Console.WriteLine("******* DO While Loop less than 5 ****");



            int n = 0;
            do
            {
                Console.WriteLine(n);
                n++;
            }
            while (n < 5);


            Console.WriteLine(" ");
            Console.WriteLine("* For loop  ****");

            Console.WriteLine("* Statement 1 is executed (one time) before the execution of the code block.  ****");
            Console.WriteLine("* Statement 2 defines the condition for executing the code block.  ****");
            Console.WriteLine("* Statement 3 is executed (every time) after the code block has been executed.");
            Console.WriteLine("* For loop  ****");


            for (int a = 0; a < 5; a++)
            {
                Console.WriteLine(a);
            }

            

            Console.WriteLine("loop through a string array");

            string[] box = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string c in box)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine(" ");

            Console.WriteLine("Example of continue on 3: ");

            int j = 0;
            while (j < 6)
            {
                if (j == 3)
                {
                    j++;
                    continue;
                }
                Console.WriteLine(j);
                j++;
            }

            Console.WriteLine(" ");
            Console.WriteLine("**** Array change value: ");

            string[] cars = { "Green", "Blue", "Red", "Blue" };
            cars[0] = "almost Green";
            Console.WriteLine(cars[0]);




        }
    }
}
