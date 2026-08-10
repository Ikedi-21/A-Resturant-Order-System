//namespace RestaurantOrderSystem
//{
//    class Program
//    {

//        static void Main(string[] agrs)
//        {

//            // input: name of user(string), name of business(string)

//            string userName, businessName;

//            Console.WriteLine("Welcome to IJFOODS! \nYour best Restaurant Order System");

//            // getting input name for business and name

//            Console.WriteLine("What is your name");
//            userName = Console.ReadLine();
//            Console.WriteLine(userName);

//            Console.WriteLine("What is your name");
//            businessName = Console.ReadLine();
//            Console.WriteLine(businessName);


//            /* 
//             ConvertToint32() 
//             ConvertTo64()
//             */

//            string name;
//            int age;
//            name = Console.ReadLine();

//            Console.WriteLine("What is your Age");
//            age = Convert.ToInt32(Console.ReadLine());


//            Console.WriteLine($"my name is {name}");
//            Console.WriteLine($"my age is {age}");

//            // get product, name, prod in stock, total value of prod/

//            string foodName;
//            float foodValue;
//            int productCount;
//            // get product namen


//            string nanme, gender;
//            Console.WriteLine("What is  your gender");
//            gender = Console.ReadLine();

//            if ( gender == "male")
//            {
//                Console.WriteLine($"hello {name} you are a man");
//            }
//            else if ( gender == "female")
//            {
//                Console.WriteLine($"hello {name} you are a woman");
//            }

//            int int1, int2;
//            string result;

//            int1 = 10;
//            int2 = 10;
//            result = Console.ReadLine();

//            Console.WriteLine("Pick a maths operation()");

//            if ( result == "+")
//            {
//                Console.WriteLine(int1 + int2);
//            }
//            else if( result == "-") 
//            {
//                Console.WriteLine(int1 - int2);
//            }
//            else if (result == "*")
//            {
//                Console.WriteLine(int1 * int2);
//            }

//            else { Console.WriteLine(int1 / int2);

//        }

//    }


using System;

namespace RestaurantOrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. MENU SETUP
            string[] items = { "Burger", "Pizza", "Pasta", "Fries", "Soda" };
            double[] prices = { 8.50, 10.00, 9.25, 3.50, 2.00 };

            double totalCost = 0.0;

            // 2. DISPLAY MENU ONCE
            Console.WriteLine("=================================");
            Console.WriteLine("    WELCOME TO THE IJFOODS       ");
            Console.WriteLine("=================================");
            Console.WriteLine($"1. {items[0]} - ${prices[0]:F2}");
            Console.WriteLine($"2. {items[1]} - ${prices[1]:F2}");
            Console.WriteLine($"3. {items[2]} - ${prices[2]:F2}");
            Console.WriteLine($"4. {items[3]} - ${prices[3]:F2}");
            Console.WriteLine($"5. {items[4]} - ${prices[4]:F2}");
            Console.WriteLine("=================================\n");

            // 3. THE LOOP VARIABLE
            // We set 'ordering' to true to start taking orders.
            bool isOrdering = true;

            // 4. SIMPLE WHILE LOOP
            // As long as 'isOrdering' is true, this block keeps repeating.
            while (isOrdering)
            {
                Console.Write("Enter item number (1-5) to add to order, or 0 to finish: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    totalCost += prices[0];
                    Console.WriteLine($"Added {items[0]} - Current Total: ${totalCost:F2}\n");
                }
                else if (choice == 2)
                {
                    totalCost += prices[1];
                    Console.WriteLine($"Added {items[1]} - Current Total: ${totalCost:F2}\n");
                }
                else if (choice == 3)
                {
                    totalCost += prices[2];
                    Console.WriteLine($"Added {items[2]} - Current Total: ${totalCost:F2}\n");
                }
                else if (choice == 4)
                {
                    totalCost += prices[3];
                    Console.WriteLine($"Added {items[3]} - Current Total: ${totalCost:F2}\n");
                }
                else if (choice == 5)
                {
                    totalCost += prices[4];
                    Console.WriteLine($"Added {items[4]} - Current Total: ${totalCost:F2}\n");
                }
                else if (choice == 0)
                {
                    // Typing 0 changes the flag to false, which breaks out of the loop!
                    isOrdering = false;
                    Console.WriteLine("Order complete! Processing receipt...\n");
                }
                else
                {
                    Console.WriteLine("Invalid option. Please choose between 1 and 5 (or 0 to stop).\n");
                }
            }

            // 5. RECEIPT COMPUTATION
            double tax = totalCost * 0.075;
            double finalTotal = totalCost + tax;

            Console.WriteLine("=================================");
            Console.WriteLine("          ORDER SUMMARY          ");
            Console.WriteLine("=================================");
            Console.WriteLine($"Subtotal:    ${totalCost:F2}");
            Console.WriteLine($"Tax (7.5%):  ${tax:F2}");
            Console.WriteLine($"Grand Total: ${finalTotal:F2}");
            Console.WriteLine("=================================");
            Console.WriteLine("Thank you for your order!");
        }
    }
}