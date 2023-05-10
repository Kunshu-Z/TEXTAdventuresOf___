﻿using System.Threading;

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
Console.WriteLine("My name... It's - \n (type your name here)");
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
            Console.WriteLine("Your self esteem suddenly dropped to a new low,\n will you let this man just walk away after what he did?\n1. Suck it up and walk into the Saber Guild \n2. Attack the man from behind!");
            string selection1c = Console.ReadLine();
            if (selection1c == "1")
            {
                Console.WriteLine($"{myName}: No point in fighting that guy, I've got things to do, starting with my current area.");
                Thread.Sleep(1000);
                Console.WriteLine("            (To the sky for the Sabers)");
                Console.WriteLine("Receptionist: Ad caelum pro gladiis, welcome to the Saber guild.");
            }

            else if (selection1c == "2")
            {
                Console.WriteLine();
            }
        }

        else if (selection1a == "2")
        {
            Console.WriteLine($"{myName}: Maybe I will go to that guild, but only if I want to waste my time!\nI bet I could find that beast that knocked me out without their help!");
            Thread.Sleep(2000);
            Console.WriteLine("Stranger: Wha- well excuse me, how dare you insult our village's bastion against the darkness, \nI think you should leave right now and never return!");
            Thread.Sleep(1000);
            Console.WriteLine($"{myName}: Well then, disgrace me and kick me out? \nThen you're not invited to my banquet when I become super powerful, fine I'll just leave.");
            Thread.Sleep(1000);
            Console.WriteLine("I'll take my power and make my own story. When I find this place again I'm coming for you!");
            Thread.Sleep(1000);
            Console.WriteLine("Stranger: I've had about enough of you, GUARDS!");
            Thread.Sleep(1000);
            Console.WriteLine("(maybe I shouldn't have done that)\nYou start running and notice a potions stand nearby, you're also quite tired.\n1. Turn yourself in \n2. Throw a potion at the guards");
            string selection1d = Console.ReadLine();
            if (selection1d == "1")
            {
                Thread.Sleep(1000);
                Console.WriteLine("Guards: GET THEM!");
                Console.WriteLine($"*The guards grab {myName} and sends them to prison.");
            }

            else if (selection1d == "2")
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
            Thread.Sleep(1000);
            Console.WriteLine("*After following the stranger to the guild...*");
            Thread.Sleep(1000);
            Console.WriteLine("*You walk to the building with the huge sign down the road and walk to the door.*");
            Thread.Sleep(1000);
            Console.WriteLine("*Suddenly a large bulky man bursts through, shoving you to the ground.*");
            Thread.Sleep(1000);
            Console.WriteLine($"{myName}: Arrgh watch i- WOAH YOU'RE HUGE!!!");
            Thread.Sleep(1000);
            Console.WriteLine("Man: Hmph...");
            Thread.Sleep(1000);
            Console.WriteLine("*It was so sudden, the man just starts walking away*");
            Thread.Sleep(1000);
            Console.WriteLine("*Your self esteem suddenly dropped to a new low*,\n will you let this man just walk away after what he did?\n1. Suck it up and walk into the Saber Guild \n2. Attack the man from behind!");
            string selection1c = Console.ReadLine();
            if (selection1c == "1")
            {
                Console.WriteLine($"{myName}: No point in fighting that guy, I've got things to do, starting with my current area.");
                Thread.Sleep(1000);
                Console.WriteLine("Receptionist: Ad caelum pro gladiis, welcome to the Saber guild.");
            }

            else if (selection1c == "2")
            {
                Console.WriteLine();
            }
        }
    

        else if (selection1b == "2")
        {
            Thread.Sleep(1000);
            Console.WriteLine("HEY! YOU'RE NOT GETTING AWAY WITH THIS!");
            Console.WriteLine("GUARDS! THAT PERSON IS RUNNING AWAY WITHOUT HAVING PAID FOR THEIR MEAL! GET THEM!");
            Thread.Sleep(1000);
            Console.WriteLine($"{myName}: 'DARN! Now I have the guards on my tail'");
            Thread.Sleep(1000);
            Console.WriteLine("Distant voice: I thought you were gonna throw away those potions. They're far too dangerous to sell.");
            Thread.Sleep(1000);
            Console.WriteLine($"{myName}: I'm starting to get exhausted...\n1. Turn yourself in\n2. Grab and throw a potion on the guards");
            string selection2b = Console.ReadLine();

            if (selection2b == "1")
            {
                Thread.Sleep(1000);
                Console.WriteLine("Guards: GET THEM!");
                Console.WriteLine($"*The guards grab {myName} and sends them to prison.");
            }

            else if (selection2b == "2")
            {
                Thread.Sleep(1000);
                Console.WriteLine($"*{myName} Grabs and throws potion to the guards*");
                Thread.Sleep(1000);
                Console.WriteLine("Guards: ARGH! CAN'T SEE ANYTHING! SOMEONE GET THEM!");
                Thread.Sleep(1000);
                Console.WriteLine("Shop owner: Hey you have to pay for th-\nWhere'd they go?!");
                Thread.Sleep(1000);
                Console.WriteLine("...");
                Thread.Sleep(1000);
                Console.WriteLine($"{myName}: 'I've managed to escape the guards but it looks like I'm no longer safe in this village...'");
                Thread.Sleep(1000);
                Console.WriteLine("Argh, how do I get out of this village now without having the guards come after me?");
                Thread.Sleep(1000);
                Console.WriteLine("Unknown voice: Seems like you've ended in quite the predicament there...");
                Thread.Sleep(1000);
                Console.WriteLine($"{myName}: Who's there?!");
                Thread.Sleep(1000);
                Console.WriteLine("Unknown voice: Right, I should probably introduce myself before we continue");
                Thread.Sleep(1000);
                Console.WriteLine("Unkown voice: Ever heard of the... Grim Reaper?");
                Thread.Sleep(1000);
                Console.WriteLine($"{myName}: Yeah right, must be some cheesy name you just made up to make yourself sound 'intimidating'");
                Thread.Sleep(1000);
                Console.WriteLine("Grim Reaper: Well, seeing as you don't believe me, I guess I have no choice but to show you...");
                Thread.Sleep(1000);
                Console.WriteLine("*A shadowy figure unravels themself as you see the Grim Reaper in front of your very eyes...*");
                Thread.Sleep(1000);
                Console.WriteLine($"{myName}: Woa- i-I mean, that's a pretty cool costume you got there.");
                Thread.Sleep(1000);
                Console.WriteLine("Grim Reaper: Regardless of whether or not you believe me, I have come for a separate reason...\nWould you like to join forces and throw everyone in this village into despair?");
                Thread.Sleep(1000);
                Console.WriteLine("1. Join forces\n2. Decline the offer");
                string selection3b = Console.ReadLine();

                if (selection3b == "1")
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("Grim Reaper: You have made a wise choice...");
                    Thread.Sleep(1000);
                    Console.WriteLine("Reach your hand out to recieve your powers");
                    Thread.Sleep(1000);
                    Console.WriteLine($"{myName}: *'This sounds really cheesy, but I'll just go with it'\n'I don't seem to have any other choice...'");
                    Thread.Sleep(1000);
                    Console.WriteLine($"As {myName} reaches their hand out to the Grim Reaper, they feel strange powers flowing within them.");
                    Thread.Sleep(1000);
                    Console.WriteLine("Grim Reaper: Now you can unleash your wrath upon these mortals");
                    Thread.Sleep(1000);
                    Console.WriteLine($"{myName}: I appreciate the fact that you gave me these powers, but you really have to stop making these cheesy statements...");
                    Thread.Sleep(1000);
                    Console.WriteLine("Grim Reaper: That won't be happening anytime soon... Goodbye!");
                    Thread.Sleep(1000);
                    Console.WriteLine("*The Grim Reaper snaps their fingers and vanishes back to their realm*");
                    Thread.Sleep(1000);
                    Console.WriteLine($"{myName}: Well, with powers like these, I basically have no other option but to destroy.");
                    Thread.Sleep(1000);
                    Console.WriteLine("*The guards find you*");
                    Thread.Sleep(1000);
                    Console.WriteLine("Guards: There they are. GET THEM!");
                    Console.WriteLine("1. Kill the guards\n2. Kill the guards");
                    string selectionDark1 = Console.ReadLine();
                }

                else if (selection3b == "2")
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"{myName}: I don't care what offer you give me. I'm not going to end the lives of innocent people");
                    Thread.Sleep(1000);
                    Console.WriteLine("Grim Reaper: Very well, it seems that you have made your decision...");
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
        Console.WriteLine($"Thank you for visiting {myName}!");
    }
}

