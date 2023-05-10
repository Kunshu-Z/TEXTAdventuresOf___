using System.Threading;

//Initial dialogue for the player to input their name and change the title
Console.WriteLine("...");
Thread.Sleep(1000);
Console.WriteLine("'Light'");
Thread.Sleep(1000);
Console.WriteLine("...");
Thread.Sleep(1000);
Console.WriteLine("''I see light''");
Thread.Sleep(1000);
Console.WriteLine("...");
Thread.Sleep(1000);
Console.WriteLine("What's my name?");
Thread.Sleep(1000);
Console.WriteLine("Who am I?");
Thread.Sleep(1000);
Console.WriteLine("*A sweeping breeze hits the back of your head*");
Thread.Sleep(1000);
Console.WriteLine("*You come to a revelation*");
Thread.Sleep(1000);
Console.WriteLine("My name... It's - ");
string myName = Console.ReadLine();
Console.WriteLine($"My name... It's {myName} ");
Thread.Sleep(1000);
Console.WriteLine("Suddenly a loud roar is heard and you are transported to grassy plains");
Thread.Sleep(1000);
Console.WriteLine("And then...");
Thread.Sleep(1000);
Console.WriteLine("...");
Thread.Sleep(1000);
Console.WriteLine("...");
Thread.Sleep(1000);
Console.WriteLine(" ");
//Game uses player's inputted name as the title
Console.WriteLine($"Welcome to The Adventures of {myName}");
Console.WriteLine("1. Start Game");
Console.WriteLine("2. Options");
Console.WriteLine("3. Quit");
Console.WriteLine("Select your option: ");

string menuSelect = Console.ReadLine();

//If the player selects 1 to start the game
if (menuSelect == "1")
{
    Console.WriteLine("...");
    Thread.Sleep(1000);
    Console.WriteLine("...");
    Thread.Sleep(1000);
    Console.WriteLine("*Inaudible noise*");
    Thread.Sleep(1000);
    Console.WriteLine($"{myName}: Ugh, what happened?");
    Thread.Sleep(1000);
    Console.WriteLine("Where am I?");
    Thread.Sleep(1000);
    Console.WriteLine("*Stands up*");
    Thread.Sleep(1000);
    Console.WriteLine("I gotta ask someone what this place is");
    Thread.Sleep(1000);
    Console.WriteLine("Last time I remember, I was out in the fields before a beast appeared out of the ground");
    Thread.Sleep(1000);
    Console.WriteLine("...");
    Thread.Sleep(1000);
    Console.WriteLine("Why are some people giving me a strange glance...");
    Thread.Sleep(1000);
    Console.WriteLine("I gotta ask someone about this place");
    Thread.Sleep(1000);
    Console.WriteLine("*Approches person*");
    Thread.Sleep(1000);
    Console.WriteLine("Stranger: Oh, hello! What can I help you with?\n1. Inquire about the place\n2. Pickpocket ");
    string selection1 = Console.ReadLine();

    //Light option one
    if (selection1 == "1")
    {
        Thread.Sleep(1000);
        Console.WriteLine("Stranger: Oh, you're a newcomer huh? Well, this is Saber village.");
        Thread.Sleep(1000);
        Console.WriteLine("We're currently in the market area, so it's not the best place to get information here. Go and visit the Saber Guild just down the road, they'll help you out.\n1. Go over to the Saber Guild \n2. Insult the man ");
        string selection1a = Console.ReadLine();
        if (selection1a == "1")
        {
            Console.WriteLine($"{myName}: Thanks stranger, I'll head over to the guild right now!");
            Thread.Sleep(1000);
            Console.WriteLine("Stranger: You're welcome, take care now.");
            Thread.Sleep(1000);
            Console.WriteLine("You walk to the building with the huge sign down the road and walk to the door.");
            Thread.Sleep(1000);
            Console.WriteLine("Suddenly a large bulky man bursts through, shoving you to the ground.");
            Thread.Sleep(1000);
            Console.WriteLine($"{myName}: Arrgh watch i- WOAH YOU'RE HUGE!!!");
            Thread.Sleep(1000);
            Console.WriteLine("Man: Hmph...");
            Thread.Sleep(1000);
            Console.WriteLine("It was so sudden, the man just starts walking away");
            Thread.Sleep(1000);
            Console.WriteLine("Your self esteem suddenly dropped to a new low,\n will you let this man just walk away after what he did?\n 1. Suck it up and walk into the Saber Guild \n 2. Attack the man from behind!");
            Console.ReadLine();
        }
    }

    //Dark option one
    else if (selection1 == "2")
    {
        Console.WriteLine("Stranger: Hey! What are you doing?! GET BACK HERE!");
        Thread.Sleep(1000);
        Console.WriteLine("*After reaching a safe space within the village...*");
        Thread.Sleep(1000);
        Console.WriteLine($"{myName}: Right, looks like I'm away from him");
        Thread.Sleep(1000);
        Console.WriteLine("Now that I have some money, I guess I should get some food.\nI'm starving...");
        Thread.Sleep(1000);
        Console.WriteLine("*Enters Restaurant...*");
        Thread.Sleep(1000);
        Console.WriteLine("Waiter: Welcome to the Dragon's Den! What would you like to have today?");
        Thread.Sleep(1000);
        Console.WriteLine($"{myName}: Just give me the cheapest meal you have.");
        Thread.Sleep(1000);
        Console.WriteLine("Waiter: Right, that's one Dragon style BLT. It will be ready shortly.");
        Thread.Sleep(1000);
        Console.WriteLine("*After having the food*");
        Thread.Sleep(1000);
        Console.WriteLine("Waiter: Right, your total comes to 500G.\n1. Pay the bill\n2. Dine n' Dash!");
        string selection1b = Console.ReadLine();
        if (selection1b == "1") 
        {  
            Thread.Sleep(1000);
            Console.WriteLine("Thank you for eating at Dragon's Den! Have a nice day!");
            Thread.Sleep(1000);
            Console.WriteLine($"{myName}: Well, now I'm out of gold...");
            Thread.Sleep(1000);
            Console.WriteLine("Random strangers from afar: Man, I'm all out of gold, and we're running out of food to eat");
            Thread.Sleep(1000);
            Console.WriteLine("Why don't you go to the guild? I've heard they give those with no gold a benefit");
            Thread.Sleep(1000);
            Console.WriteLine($"{myName}: *Huh, the Guild?*");
            Thread.Sleep(1000);
            Console.WriteLine("Random strangers from afar: Woah really? I'll go there now!");
            Thread.Sleep(1000);
            Console.WriteLine($"{myName}: I've gotta follow him there.");
        }

        else if (selection1b == "2") 
        {
            Thread.Sleep(1000);
            Console.WriteLine("HEY! YOU'RE NOT GETTING AWAY WITH THIS!");
            Console.WriteLine("GUARDS! THAT PERSON IS RUNNING AWAY WITHOUT HAVING PAID FOR THEIR MEAL! GET THEM!");
            Thread.Sleep(1000);
            Console.WriteLine($"{myName}: *DARN! Now I have the guards on my tail*");
            Thread.Sleep(1000);
            Console.WriteLine("Distant voice: I thought you were gonna throw away those potions. They're far too dangerous to sell.");
            Thread.Sleep(1000);
            Console.WriteLine($"{myName}: I'm starting to get exhausted...\n1. Turn yourself in\n Grab and throw a potion on the guards");
            string selection3b = Console.ReadLine();

            if (selection3b == "1")
            {
                Thread.Sleep(1000);
                Console.WriteLine("Guards: GET THEM!");
                Console.WriteLine($"*The gaurds grab {myName} and sends them to prison.");
            }

            else if (selection3b == "2")
            {
                Thread.Sleep(1000);
                Console.WriteLine("*Grabs and throws potion to the guards*");
                Thread.Sleep(1000);
                Console.WriteLine("Guards: ARGH! CAN'T SEE ANYTHING! SOMEONE GET THEM!");
                Thread.Sleep(1000);
                Console.WriteLine("Shop owner: Hey you have to pay for th-\n Where'd they go?!");
                Thread.Sleep(1000);
                Console.WriteLine("...");
                Thread.Sleep(1000);
                Console.WriteLine($"{myName}: *I've managed to escape the guards but it looks like I'm no longer safe in this village...");
            }
        }
    }

}


//If the player selects 2 for settings
else if (menuSelect == "2")
{
    Console.WriteLine("Settings:");
}

//If the player selects 3 to quit the game
else if (menuSelect == "3")
{
    Console.WriteLine("Thank you for visiting ___!");
}
   
