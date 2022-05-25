// See https://aka.ms/new-console-template for more information

double coffeeCount = 0;
double waterCount = 0;


    Console.WriteLine("Welcome to Larry's Buffet, live like larry for just $9.99 per person!");
    Console.WriteLine("We offer two beverage options: coffee and water. We do not charge extra for water, coffee costs $2.00.");
    Console.WriteLine("How many people in your party? We can accomidate parties up to 6.");
    double partySize = int.Parse(Console.ReadLine());

    if (partySize >= 7)
    {
        Console.WriteLine("Your party is too big for Larry's Buffet. Please consider dining in smaller groups. That's how Larry lives.");
    }
    else if (partySize == 0)
    {
        Console.WriteLine("Umm.. You need to have at least one person in your party to eat at this buffet.");
        Console.WriteLine("How are you even talking to me right now?");
    }
    else if (partySize < 0)
    {
        Console.WriteLine("We don't allow that kind of negativity here at Larry's Buffet.");
    }
    else
    {
        Console.WriteLine("A table for " + partySize + "! Please, come take a seat.");
        Console.WriteLine("Let's get started with drinks. We have coffee and water.");

        //int guestNumber = 1;

        for (double guestNumber = 1; guestNumber <= partySize; guestNumber++)
        {
            Console.WriteLine("Alright, Guest " + guestNumber);
            Console.WriteLine("Would you like water or coffee?");
            string response = Console.ReadLine();
            if (response == "coffee")
            {
                Console.WriteLine(response + ", okay!");
                coffeeCount++;
            }
            else if (response == "water")
            {
                Console.WriteLine(response + ", okay!");
                waterCount++;
            }
            else
            {
                Console.WriteLine("We dont offer that beverage here, please try to live more like Larry.");
            }
        }

        double buffetTotal = partySize * 9.99;
        double coffeeTotal = coffeeCount * 2.00;
        double total = buffetTotal + coffeeTotal;

        Console.WriteLine("");
        Console.WriteLine("Okay, so that's " + coffeeCount + " coffees and " + waterCount + " waters.");
        Console.WriteLine("");
        Console.WriteLine("I'll be right back with your beverages, feel free to go get your food.");
        Console.WriteLine("");
        Console.WriteLine("Congratulations for living like Larry! Here is your bill:");
        Console.WriteLine(partySize + " buffets = " + partySize + " x $9.99 = $" + buffetTotal);
        Console.WriteLine(coffeeCount + " coffees = " + coffeeCount + " x 2.00 = $" + coffeeTotal);
        Console.WriteLine(waterCount + " waters = free");
        Console.WriteLine("total = $" + total);

        
    }




