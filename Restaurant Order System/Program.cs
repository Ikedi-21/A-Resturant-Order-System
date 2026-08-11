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
            // 1. INDIVIDUAL ITEM & PRICE VARIABLES (NO ARRAYS)
            string item1 = "Burger"; double price1 = 8.50;
            string item2 = "Pizza"; double price2 = 10.00;
            string item3 = "Pasta"; double price3 = 9.25;
            string item4 = "Fries"; double price4 = 3.50;
            string item5 = "Soda"; double price5 = 2.00;

            double totalCost = 0.0;

            // 2. DISPLAY MENU
            Console.WriteLine("=================================");
            Console.WriteLine("    WELCOME TO THE IJFOODS       ");
            Console.WriteLine("=================================");
            Console.WriteLine($"1. {item1} - ${price1:F2}");
            Console.WriteLine($"2. {item2} - ${price2:F2}");
            Console.WriteLine($"3. {item3} - ${price3:F2}");
            Console.WriteLine($"4. {item4} - ${price4:F2}");
            Console.WriteLine($"5. {item5} - ${price5:F2}");
            Console.WriteLine("=================================\n");

            // 3. ORDERING LOOP
            bool isOrdering = true;

            while (isOrdering)
            {
                Console.Write("Enter item number (1-5) to add to order, or 0 to finish: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    totalCost += price1;
                    Console.WriteLine($"Added {item1} - Current Total: ${totalCost:F2}\n");
                }
                else if (choice == 2)
                {
                    totalCost += price2;
                    Console.WriteLine($"Added {item2} - Current Total: ${totalCost:F2}\n");
                }
                else if (choice == 3)
                {
                    totalCost += price3;
                    Console.WriteLine($"Added {item3} - Current Total: ${totalCost:F2}\n");
                }
                else if (choice == 4)
                {
                    totalCost += price4;
                    Console.WriteLine($"Added {item4} - Current Total: ${totalCost:F2}\n");
                }
                else if (choice == 5)
                {
                    totalCost += price5;
                    Console.WriteLine($"Added {item5} - Current Total: ${totalCost:F2}\n");
                }
                else if (choice == 0)
                {
                    isOrdering = false;
                    Console.WriteLine("Order complete! Processing receipt...\n");
                }
                else
                {
                    Console.WriteLine("Invalid option. Please choose between 1 and 5 (or 0 to stop).\n");
                }
            }

            // 4. RECEIPT COMPUTATION
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