Console.WriteLine("Welcome to The Adventures of ___");
Console.WriteLine("1. Start Game");
Console.WriteLine("2. Options");
Console.WriteLine("3. Quit");
Console.WriteLine("Select your option: ");

string menuSelect = Console.ReadLine();

//If the player selects 1 to start the game
if (menuSelect == "1")
{
    Console.WriteLine("...");
    Console.WriteLine("...");
    Console.WriteLine("*Inaudable noise*");
    Console.WriteLine("Ugh, what happened?");
    Console.WriteLine("Where am I?");
    Console.WriteLine("*Stands up*");
    Console.WriteLine("I gotta ask someone what this place is");
    Console.WriteLine("Last time I remember, I was out in the fields before a beast appeared out of the ground");
    Console.WriteLine("...");
    Console.WriteLine("Why are some people giving me a strange glance...");
    Console.WriteLine("I gotta ask someone about this place");
    Console.WriteLine("*Approches person*");
    Console.WriteLine("Oh, hello! What can I help you with?\n1. Inquire about the place\n2. Pickpocket ");
    string selection1 = Console.ReadLine();

    if (selection1 == "1")
    {
        Console.WriteLine("Oh, you're a newcomer huh? Well, this is Saber village.\n");
    }

    else if (selection1 == "2")
    {
        Console.WriteLine("Hey! What are you doing?! GET BACK HERE!");
        Console.WriteLine("*After reaching a safe space within the village...*");
        Console.WriteLine("Right, looks like I'm away from him");
        Console.WriteLine("Now that I have some money, I guess I should get some food.\nI'm starving...");
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
   
//ijdjewidjediejdiwjee