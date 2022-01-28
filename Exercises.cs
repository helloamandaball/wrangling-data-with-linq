// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace linq
// {
//     public class Fruit
//     {
//         //static void Main(string[] args)
//         // { 
//         //Given the collections of items shown below, use LINQ to build the requested collection, and then Console.WriteLine() each item in that resulting collection.

//         //Restriction/Filtering Operations
//         // Find the words in the collection that start with the letter 'L'
//         // List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

//         // IEnumerable<string> LFruits = from fruit in fruits 
//         //     where fruit.StartsWith("L") 
//         //     select fruit;

//         // Console.WriteLine(LFruits);


//         // // Which of the following numbers are multiples of 4 or 6
//         // List<int> numbers = new List<int>()
//         // {
//         //     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
//         // };

//         // IEnumerable<int> fourSixMultiples = numbers.Where(n => n % 4 == 0 || n % 6 == 0);

//         // Console.WriteLine(fourSixMultiples);


//         //Ordering Operations
//         // Order these student names alphabetically, in descending order (Z to A)
//         // List<string> names = new List<string>()
//         // {
//         //     "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
//         //     "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
//         //     "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
//         //     "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
//         //     "Francisco", "Tre"
//         // };

//         // IEnumerable<string> descendingOrder = names.OrderByDescending(name => name);
//         // // Console.WriteLine(descendingOrder);
//         // //in order to get it to show up in the console, instead of just looking at the debugger, add a foreach
//         // foreach (string orderedNames in descendingOrder)
//         // {
//         //     Console.WriteLine(orderedNames);
//         // }

//         // Build a collection of these numbers sorted in ascending order
//         // List<int> numbers = new List<int>()
//         // {
//         //     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
//         // };
//         // IEnumerable<int> sortedNumbers = numbers.OrderBy(numbers => numbers);
//         // foreach (int orderedNumbers in sortedNumbers)
//         // {
//         //     Console.WriteLine(orderedNumbers);
//         // }


//         //Aggregate Operations
//         // Output how many numbers are in this list
//         // List<int> numbersList = new List<int>()
//         // {
//         //     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
//         // };
//         // int numberCount = numbersList.Count();
//         // Console.WriteLine("Total of numbers:");
//         // Console.WriteLine(numberCount);

//         // // How much money have we made?
//         // List<double> purchases = new List<double>()
//         // {
//         //     2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
//         // };
//         // double total = purchases.Sum(n => n);
//         // Console.WriteLine("Total Purchase = ${0}", total);

//         // // What is our most expensive product?
//         // List<double> prices = new List<double>()
//         // {
//         //     879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
//         // };
//         // double mostExpensive = prices.Max();
//         // Console.WriteLine("Most Expensive: {0}", mostExpensive);


//         // Partitioning Operations
//         /* List<int> wheresSquaredo = new List<int>()
//         {
//             66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
//         };
//         // Store each number in the following List until a perfect square is detected.
//         // Expected output is { 66, 12, 8, 27, 82, 34, 7, 50, 19, 46 } 
//         // Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx

//         List<int> wheresSquaredoNot = wheresSquaredo.TakeWhile((n, i) => (Math.Sqrt(n)) % 1 != 0).ToList(); 
//             //add != 0  to set condition to not be true
//         foreach (int num in wheresSquaredoNot)
//         {
//             Console.WriteLine(num);
//         } */


//         //Using Custom Types
//         // Build a collection of customers who are millionaires
//         public class Customer
//         {
//             public string Name { get; set; }
//             public double Balance { get; set; }
//             public string Bank { get; set; }
//         }

//         public class MilliList
//         {
//             public string Bank { get; set; }
//             public int TotalMilliPerBank { get; set; }
//         }

//         static void Main(string[] args)
//         {

//             List<Customer> customers = new List<Customer>() {
//                     new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
//                     new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
//                     new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
//                     new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
//                     new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
//                     new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
//                     new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
//                     new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
//                     new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
//                     new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
//                 };

//             List<Customer> millionaires = customers.Where(c => c.Balance > 999999.99).ToList();
//             // JavaScript Comparison
//             // const millionaires = customers.filter(c => c.Balance > 999999.99)

//             foreach (Customer milliObj in millionaires)
//             {
//                 Console.WriteLine($"These are millionaires: {milliObj.Name}");
//             }

//             /*
//                 Given the same customer set, display how many millionaires per bank.
//                 Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

//                 Example Output:
//                 WF 2
//                 BOA 1
//                 FTB 1
//                 CITI 1
//             */
//             //group by bank, then determine the millionaires
//            List<MilliList> milliByBank = (from customer in millionaires
//                                         //  (from customer in customers
//                                         //  where customer.Balance >= 1000000
//                                            group customer by customer.Bank into bankGroup
//                                            select new MilliList
//                                            {
//                                                Bank = bankGroup.Key,
//                                                TotalMilliPerBank = bankGroup.Count()
//                                            }).ToList();

//             Console.WriteLine(milliByBank);
//             milliByBank.ForEach(x => Console.WriteLine($"{x.Bank} {x.TotalMilliPerBank}"));
//         }
//     }
// }

