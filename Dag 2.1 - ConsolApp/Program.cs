using System.Diagnostics.Contracts;
using System.Xml;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Random dice = new Random();
        int roll = dice.Next(1, 7);
        Console.WriteLine(roll);*/


        /*Random dice = new Random();
        int roll1 = dice.Next();
        int roll2 = dice.Next(101);
        int roll3 = dice.Next(50, 101);

        Console.WriteLine($"First roll: {roll1}");
        Console.WriteLine($"Second roll: {roll2}");
        Console.WriteLine($"Third roll: {roll3}");*/


        /*int firstValue = 500;
        int secondValue = 600;
        int largerValue = Math.Max(firstValue, secondValue);

        Console.WriteLine(largerValue);*/


        /*string message = "The quick brown fox jump over the lazy dog.";
        bool result = message.Contains("dog");
        Console.WriteLine(result);

        if (message.Contains("fox"))
        {
            Console.WriteLine("What does the fox say?");
        }*/

        /*Random dice = new Random();

        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3}");        


        if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3))
        {
            Console.WriteLine("You rolled doubles! +2 bonus to total!");
            total += 2;
        }

        if ((roll1 == roll2) && (roll2 == roll3))
        {
            Console.WriteLine("You rolled triples! +6 bonus to total!");
            total += 6;
        }

        Console.WriteLine($"Total: {total}");

        string result = (total >= 15) ? "You win!" : "You lose.";
        Console.WriteLine(result);*/



        /*Random dice = new Random();

        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
        {
            if ((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("You rolled triples! +6 bonus to total!");
                total += 6;
            }
            else
            {
                Console.WriteLine("You rolled doubles! +2 bonus to total!");
                total += 2;
            }

            Console.WriteLine($"Your total including the bonus: {total}");
        }

        if (total >= 16)
        {
            Console.WriteLine("You win a new car!");
        }
        else if (total >= 10)
        {
            Console.WriteLine("You win a new laptop!");
        }
        else if (total == 7)
        {
            Console.WriteLine("You win a trip for two!");
        }
        else
        {
            Console.WriteLine("You win a kitten!");
        }*/


        /*Random random = new Random();
        int daysUntilExpiration = random.Next(12);
        int discountPercentage = 0;
        Console.WriteLine(daysUntilExpiration);

        if (daysUntilExpiration <= 10 && daysUntilExpiration >= 6)
        {
            Console.WriteLine("Your subscription will expire soon. Renew now!");
        }

        else if (daysUntilExpiration <= 5 && daysUntilExpiration >= 2) 
        {
            discountPercentage = 10;
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
            Console.WriteLine($"Renew now and save {discountPercentage}%!");
        }

        else if (daysUntilExpiration == 1)
        {
            discountPercentage = 20;
            Console.WriteLine("You subscription expires within a day!");
            Console.WriteLine($"Renew now and save {discountPercentage}%!");
        }
        else if (daysUntilExpiration == 0)
        {
            Console.WriteLine("Your subscription has expired.");
        }*/

        /*string[] fraudulentOrderIDs = new string[3];
        fraudulentOrderIDs[0] = "A123";
        fraudulentOrderIDs[1] = "B456";
        fraudulentOrderIDs[2] = "C789";
        // fraudulentOrderIDs[3] = "D000";

        Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
        Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
        Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

        fraudulentOrderIDs[0] = "F000";

        Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");*/

        /*string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

        Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
        Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
        Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

        fraudulentOrderIDs[0] = "F000";

        Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

        Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");*/


        /*string[] names = { "Rowena", "Robin", "Bao" };
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }*/

        /*int[] inventory = { 200, 450, 700, 175, 250 };
        int bin = 0;
        int sum = 0;
        foreach (int items in inventory)
        {
            sum += items;
            bin++;
            Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
        }
        Console.WriteLine($"We have {sum} items in inventory.");*/


        /*string[] fraudulentOrderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
        foreach (string id in fraudulentOrderIDs) 
        {
            if (id.StartsWith("B"))
            {
                Console.WriteLine(id);
            }

        }*/


        /*string firstName = "Bob";
        int widgetsPurchased = 7;
        Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");*/



        /* 
         * The following code creates five random orderIDs
         * to test the fraud detection process. OrderIds
         * consist of a letter from A to E, and a three
         * digit number. Ex. A123.
        */

        /*Random random = new Random();
        string[] orderIDs = new string[5];
        // Loop through each blank orderID
        for (int i = 0; i < orderIDs.Length; i++)
        {
            // Get a random value that equates to ASCII letters A through E
            int prefixValue = random.Next(65, 70);
            // Convert the random value into a char, then a string
            string prefix = Convert.ToChar(prefixValue).ToString();
            // Create a random number, pad with zeroes
            string suffix = random.Next(1, 1000).ToString("000");
            // Combine the prefix and suffix together, then assign to current OrderID
            orderIDs[i] = prefix + suffix;
        }
        // Print out each orderID
        foreach (var orderID in orderIDs)
        {
            Console.WriteLine(orderID);
        }*/


        /*Console
        .
        WriteLine
        (
        "Hello Example 1!"
        )
        ;

        string firstWord = "Hello"; string lastWord = "Example 2"; Console.WriteLine(firstWord + " " + lastWord + "!");*/



        /*Random dice = new Random();

        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        int total = roll1 + roll2 + roll3;
        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

        if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
        {
            if ((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("You rolled triples!  +6 bonus to total!");
                total += 6;
            }
            else
            {
                Console.WriteLine("You rolled doubles!  +2 bonus to total!");
                total += 2;
            }
        }*/


        /*string str = "The quick brown fox jumps over the lazy dog.";
        // convert the message into a char array
        char[] charMessage = str.ToCharArray();
        // Reverse the chars
        Array.Reverse(charMessage);
        int x = 0;
        // count the o's
        foreach (char i in charMessage) { if (i == 'o') x++; }
        // convert it back into a string
        string new_message = new string(charMessage);
        // print it out
        Console.WriteLine(new_message);
        Console.WriteLine($"'o' appears {x} tiems.");*/



        /*string originalMessage = "The quick brown fox jumps over the lazy dog.";

        char[] message = originalMessage.ToCharArray();
        Array.Reverse(message);

        int letterCount = 0;

        foreach (char letter in message)
        {
            if (letter == 'o')
            {
                letterCount++;
            }
        }

        string newMessage = new string(message);

        Console.WriteLine(newMessage);
        Console.WriteLine($"'o' appears {letterCount} times.");*/


    }
}