using System;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Console.WriteLine("a" == "a");
        Console.WriteLine("a" == "A");
        Console.WriteLine(1 == 2);

        string myValue = "a";
        Console.WriteLine(myValue == "a");*/

        /*string value1 = " a";
        string value2 = "A ";
        Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());*/

        /*Console.WriteLine("a" != "a");
        Console.WriteLine("a" != "A");
        Console.WriteLine(1 != 2);

        string myValue = "a";
        Console.WriteLine(myValue != "a");

        Console.WriteLine(1 > 2);
        Console.WriteLine(1 < 2);
        Console.WriteLine(1 >= 1);
        Console.WriteLine(1 <= 1);*/

        /*string pangram = "The quick brown fox jumps over the lazy dog.";
        /*Console.WriteLine(pangram.Contains("fox"));
        Console.WriteLine(pangram.Contains("cow"));

        Console.WriteLine(!pangram.Contains("fox"));
        Console.WriteLine(!pangram.Contains("cow"));*/

        /*int saleAmount = 1001;
        //int discount = saleAmount > 1000 ? 100 : 50;
        Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");*/

        /*Random coin = new Random();
        string headsOrTails = coin.Next(101) >= 50 ? "heads" : "tails";
        Console.WriteLine(headsOrTails);*/


        /*string permission = "Admin|Manager";
        int level = 55;
        if (permission.Contains("Admin"))
        {
            if (level > 55)
            {
                Console.WriteLine("Welcome, Super Admin user.");
            }
            else
            {
                Console.WriteLine("Welcome, Admin user.");
            }
        }
        else if (permission.Contains("Manager"))
        {
            if (level >= 20)
            {
                Console.WriteLine("Contact an Admin for access.");
            }
            else
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }
        }
        else
        {
            Console.WriteLine("You do not have sufficient privileges.");
        }*/

        /*bool flag = true;
        int value = 0;

        if (flag)
        {
            Console.WriteLine($"Inside the code block: {value}");
        }

        value = 10;
        Console.WriteLine($"Outside the code block: {value}");*/

        /*bool flag = true;
        if (flag) Console.WriteLine(flag);


        string name = "steve";

        if (name == "bob")
            Console.WriteLine("Found Bob");
        else if (name == "steve")
            Console.WriteLine("Found Steve");
        else
            Console.WriteLine("Found Chuck");*/

        /*int[] numbers = { 4, 8, 15, 16, 23, 42 };
        bool found = false;
        int total = 0;

        foreach (int number in numbers)
        {
           
            total += number;

            if (number == 42)
            {
                found = true;

            }
        }

        if (found)
        {
            Console.WriteLine("Set contains 42");

        }

        Console.WriteLine($"Total: {total}");*/


        /*int employeeLevel = 100;
        string employeeName = "John Smith";

        string title = "";

        switch (employeeLevel)
        {
            case 100:
            case 200:
                title = "Senior Associate";
                break;
            case 300:
                title = "Manager";
                break;
            case 400:
                title = "Senior Manager";
                break;
            default:
                title = "Associate";
                break;
        }

        Console.WriteLine($"{employeeName}, {title}");*/


        /*string sku = "01-MN-L";

        string[] product = sku.Split('-');

        string type = "";
        string color = "";
        string size = "";

        switch (product[0])
        {
            case "01":
                type = "Sweat shirt";
                break;
            case "02":
                type = "T-Shirt";
                break;
            case "03":
                type = "Sweat pants";
                break;
            default:
                type = "Other";
                break;
        }

        switch (product[1])
        {
            case "BL":
                color = "Black";
                break;
            case "MN":
                color = "Maroon";
                break;
            default:
                color = "White";
                break;
        }

        switch (product[2])
        {
            case "S":
                size = "Small";
                break;
            case "M":
                size = "Medium";
                break;
            case "L":
                size = "Large";
                break;
            default:
                size = "One Size Fits All";
                break;
        }

        Console.WriteLine($"Product: {size} {color} {type}");*/


        /*for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            if (i == 7) break;
        }*/

        /*string[] names = { "Alex", "Eddie", "David", "Michael" };
        for (int i = names.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(names[i]);
        }*/


        /*string[] names = { "Alex", "Eddie", "David", "Michael" };

        for (int i = 0; i < names.Length; i++)
        {
            if (names[i] == "David")
            {
                names[i] = "Sammy";
            }
        }

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }*/

        /*for (int i = 1; i < 101; i++)
        {
            if (i % 5 == 0 && i % 3 == 0)
            {
                Console.WriteLine(i + " - FizzBuzz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine(i + " - Buzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine(i + " - Fizz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }*/

        /*Random random = new Random();
        int current = random.Next(1, 11);

        do
        {
            current = random.Next(1, 11);

            if (current >= 8) continue;

            Console.WriteLine(current);
        } while (current != 7);

        
        while (current >= 3)
        {
            Console.WriteLine(current);
            current = random.Next(1, 11);
        }
        Console.WriteLine($"Last number: {current}");*/

        int heroHealth = 10;
        int monsterHealth = 10;
        Random rand = new Random();
        bool gameActive = true;
        bool heroTurn = true;

        do
        {
            if (!heroTurn)
            {
                int damage = rand.Next(1, 11);
                heroHealth -= damage;
                Console.WriteLine($"Hero was damaged and lost {damage} health and now has {heroHealth} health.");
                heroTurn = true;
            }
            else if (heroTurn)
            {
                int damage = rand.Next(1, 11);
                monsterHealth -= damage;
                Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monsterHealth} health.");
                heroTurn = false;
            }


            if (monsterHealth <= 0)
            {
                Console.WriteLine("Hero wins!");
                gameActive = false;
                break;
            }
            if (heroHealth <= 0)
            {
                Console.WriteLine("Monster wins!");
                gameActive = false;
                break;
            }

        } while (gameActive);
    }
}