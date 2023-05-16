using System;
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
Console.WriteLine("My name... It's - \n (type your name here)");
string myName = Console.ReadLine();
Console.WriteLine($"My name... It's {myName} ");
Thread.Sleep(1000);
Console.WriteLine("Suddenly a loud roar is heard and you are transported to grassy fields");
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
    Console.WriteLine("*Approaches person*");
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
                Thread.Sleep(1000);
                Console.WriteLine($"{myName}: Um ok so do you have a map or something around here?");
                Thread.Sleep(1000);
                Console.WriteLine("*The Receptionist points to a wall with a highly embellished grand continental map \n- with complementary minimaps you can take below - *");
                Thread.Sleep(1000);
                Console.WriteLine("Receptionist: Right there");
                Thread.Sleep(1000);
                Console.WriteLine($"{myName}: Oh ok thanks then");
                Thread.Sleep(1000);
                Console.WriteLine($"{myName} inspects the map carefully, an open field where you may have blacked out.");
                Thread.Sleep(1000);
                Console.WriteLine("You find two open fields on the map; Old Saber battlefield and the Sea of Wheat");
                Thread.Sleep(1000);
                Console.WriteLine("Clearly an open abandoned battlefield may have some beasts roaming around but who knows,\n maybe the Sea of Wheat might have some clues, it's a small world after all.");
                Thread.Sleep(1000);
                Console.WriteLine("1. Choose to go to the Old Saber Battlefield \n2. Choose to go to the Sea of Wheat");
                string selection1e = Console.ReadLine();
                if (selection1e == "1")
                {
                    Console.WriteLine($"{myName} chooses to go to the Old Saber Battlefield, a remnant of a more chaotic age for the Sabers\nwho attacked each other in a bloody civil war, {myName} realizes the dangers and needs a weapon.");
                    Thread.Sleep(1000);
                    Console.WriteLine($"{myName}: Excuse me miss receptionist, I might not be a member of the guild but do you have any weapons I could use for my journey?");
                    Thread.Sleep(1000);
                    Console.WriteLine("Receptionist: Certainly, we have 2 lost weapons in our posession, they weren't claimed by their owners so you may have one.");
                    Thread.Sleep(1000);
                    Console.WriteLine("She points to a slightly rusted sword (a saber to be exact) and an unremarkable bow and a quiver of 20 arrows.\n1. Choose the sword \n2. Choose the Bow");
                    string selection1f = Console.ReadLine();
                    if (selection1f == "1")
                    {
                        Console.WriteLine($"{myName} picks up the sword, takes a minimap, thanks the receptionist, \nand goes on their merry way to the Old Battlefield due west from the village.");
                        Thread.Sleep(1000);
                        Console.WriteLine("Hour One");
                        Console.WriteLine("On the road you pass a traveler who says not a single word, just a stare - a glare even - into your eyes, then keeps walking on.");
                        Thread.Sleep(3000);
                        Console.WriteLine("Hour Two");
                        Console.WriteLine("You get tired and rest beside a tree trunk, a few deer graze on some grass a few trees down.");
                        Thread.Sleep(3000);
                        Console.WriteLine("Hour Three");
                        Console.WriteLine("You get back up and continue, you come across an abandoned wooden barrel, nothing was inside");
                        Thread.Sleep(3000);
                        Console.WriteLine("Hour Three and a half");
                        Console.WriteLine("You come to a clearing, two old swords thrust in the ground long ago after the battles here, to mark the battleground.");
                        Thread.Sleep(1000);
                        Console.WriteLine("It's a quiet place with little vegetation, almost only dirt with old weapons lain about. Grim.");
                        Thread.Sleep(1000);
                        Console.WriteLine("(Maybe this is where that beast is, I never really got a good look at it)");
                        Thread.Sleep(3000);
                        Console.WriteLine("You start searching around for anything, anything at all.");
                        Thread.Sleep(3000);
                        Console.WriteLine("... nothing");
                        Thread.Sleep(3000);
                        Console.WriteLine("... nothing");
                        Thread.Sleep(3000);
                        Console.WriteLine("... something? ... nothing");
                        Thread.Sleep(5000);
                        Console.WriteLine($"{myName}: There's nothing here! Just rusty old swords and shields.");
                        Thread.Sleep(1000);
                        Console.WriteLine("You pick a shield to inspect it, holding it up to your face you suddenly feel a large thud on the face of the shield.");
                        Thread.Sleep(1000);
                        Console.WriteLine("A sharp needle pierced the shield, bewildered, you look up and see a huge beast a tail with needles at the end, \na face like a lizard, almost draconic, \na body like a horse, with plates of armor, \nit's legs were like a huge cat, nimble.");
                        Thread.Sleep(4000);
                        Console.WriteLine("Don't just stand there! Do something! \n1. Fight the beast \n2. Run away in fear");
                        string fight1 = Console.ReadLine();
                        if (fight1 == "1")
                        {
                            Console.WriteLine("Foolish choice, but it was your choice, this is your story after all.");
                            Thread.Sleep(1000);
                            Console.WriteLine($"{myName} brandishes their saber and the impaled shield, they ready the weapon.");
                            Thread.Sleep(1000);
                            Console.WriteLine($"The beast charges into {myName}, making them fall over");
                            Thread.Sleep(1000);
                            Console.WriteLine("The beast fires a needle from it's tail, it misses. \nIt tries again, it won't miss this time. \n1. Pull up the shield \n2. Panic and Roll");
                            string fight2 = Console.ReadLine();
                            if (fight2 == "1")
                            {
                                Console.WriteLine("Another needle is lodged into the shield");
                                Thread.Sleep(1000);
                                Console.WriteLine("The left of the beast's face is nearing you, something must be done. \n1. Bash its face with the shield \n2. Slash the face with your sword");
                                string fight3 = Console.ReadLine();
                                if (fight3 == "1")
                                {
                                    Console.WriteLine("The beast is stunned, ithe two shield needles dislodged into the beast's face and the neck is exposed!");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("Time slows, perhaps due to simply being in the moment, you should probably attack... \n1. Stab its neck \n2. Slash at its closest leg");
                                    string fight4 = Console.ReadLine();
                                    if (fight4 == "1")
                                    {
                                        Console.WriteLine("You stab its neck and past the roof of it's mouth, to the brain. You drag the blade along, causing even more pain.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("The beast is now in a rage, gurgling roars pierce your ears.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Suddenly the beasts's armor breaks off, revealing splendid black wings.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("The beast flies up and back down to charge into you!");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("You must grab onto the beast or else it'll just keep firing needles from the air, out of your reach.  Which side will you grab on from? \n1. Left Side \n2. Right side");
                                        string fight5 = Console.ReadLine();
                                        if (fight5 == "1")
                                        {
                                            Console.WriteLine($"{myName} dodges to their right and grab on its left where the needles were stuck");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("The beast flies east of the battlefield. Back to the village! You realize this beast must be killed now.");
                                            Thread.Sleep(4000);
                                            Console.WriteLine("You push in the needles while struggling to hold on, \nthe beast falls a little but still has some strength to fly.");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("For a split second");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("You and the beast starts falling into the market place, it roars and then...");
                                            Thread.Sleep(500);
                                            Console.WriteLine("THUD!!!");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("Stalls are squashed under the beast and needles fly into the sky in a final reflex from its tail, \neveryone in the village ducks for cover.");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"The beast is dead, {myName} yet lives");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"A sinister bony cackle is heard faintly, is this another villain? {myName} didn't care, right now they were a hero.");
                                        }
                                        else if (fight5 == "2")
                                        {
                                            Console.WriteLine($"{myName} dodges to their left and grab on its right.");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"The beast does a barrel roll! {myName} was flung onto it's left side where the needles are!");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("The beast flies east of the battlefield. Back to the village! You realize this beast must be killed now.");
                                            Thread.Sleep(4000);
                                            Console.WriteLine("You push in the needles while struggling to hold on, \nthe beast falls a little but still has some strength to fly.");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("For a split second");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("You and the beast starts falling into the market place, it roars and then...");
                                            Thread.Sleep(500);
                                            Console.WriteLine("THUD!!!");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("Stalls are squashed under the beast and needles fly into the sky in a final reflex from its tail, \neveryone in the village ducks for cover.");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"The beast is dead, {myName} yet lives");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"A sinister bony cackle is heard faintly, is this another villain? {myName} didn't care, right now they were a hero.");
                                        }
                                    }

                                    else if (fight4 == "2")
                                    {
                                        Console.WriteLine("Well you could've done more damage to it the other way but this is fine too.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("You slash at its leg, causing a large gash to appear.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Suddenly overcome by bloodlust, you slash at the beast some more even getting your sword, \nthen giving a final stab in its eye");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("The beast is now in a rage, gurgling roars pierce your ears.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Suddenly the beasts's armor breaks off, revealing splendid black wings.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("The beast flies up and back down to charge into you!");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("You must grab onto the beast or else it'll just keep firing needles from the air, out of your reach.  Which side will you grab on from? \n1. Left Side \n2. Right side");
                                        string fight5 = Console.ReadLine();
                                        if (fight5 == "1")
                                        {
                                            Console.WriteLine($"{myName} dodges to their right and grab on its left where the needles were stuck");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("The beast flies east of the battlefield. Back to the village! You realize this beast must be killed now.");
                                            Thread.Sleep(4000);
                                            Console.WriteLine("You push in the needles while struggling to hold on, \nthe beast falls a little but still has some strength to fly.");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("For a split second");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("You and the beast starts falling into the market place, it roars and then...");
                                            Thread.Sleep(500);
                                            Console.WriteLine("THUD!!!");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("Stalls are squashed under the beast and needles fly into the sky in a final reflex from its tail, \neveryone in the village ducks for cover.");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"The beast is dead, {myName} yet lives");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"A sinister bony cackle is heard faintly, is this another villain? {myName} didn't care, right now they were a hero.");
                                        }
                                        else if (fight5 == "2")
                                        {
                                            Console.WriteLine($"{myName} dodges to their left and grab on its right.");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"The beast does a barrel roll! {myName} was flung onto it's left side where the needles are!");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("The beast flies east of the battlefield. Back to the village! You realize this beast must be killed now.");
                                            Thread.Sleep(4000);
                                            Console.WriteLine("You push in the needles while struggling to hold on, \nthe beast falls a little but still has some strength to fly.");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("For a split second");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("You and the beast starts falling into the market place, it roars and then...");
                                            Thread.Sleep(500);
                                            Console.WriteLine("THUD!!!");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("Stalls are squashed under the beast and needles fly into the sky in a final reflex from its tail, \neveryone in the village ducks for cover.");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"The beast is dead, {myName} yet lives");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"A sinister bony cackle is heard faintly, is this another villain? {myName} didn't care, right now they were a hero.");
                                        }
                                    }
                                }
                                else if (fight3 == "2")
                                {
                                    Console.WriteLine("You slash at its face twice.");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("The skin is hard and scaly but you manage to get a cut in.");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("The beast turns its head away but then...");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("Time slows right as its left eye is facing you, perhaps due to simply being in the moment, \nyou should probably attack... \n1. Stab its eye \n2. Slash at its closest leg");
                                    string fight4 = Console.ReadLine();
                                    if (fight4 == "1")
                                    {
                                        Console.WriteLine("You stab your sword into its eye.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("The eye is thick but it works, the sword stabbed through, but you let go!.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("The beast roars then makes no more movement");
                                        Thread.Sleep(5000);
                                        Console.WriteLine("And then...");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("The beast stands up again! ");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Suddenly the beasts's armor breaks off, revealing splendid black wings.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("The beast flies up with the sword still in its left and back down to charge into you!");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("You must grab onto the beast, but which side?  \n1. Left side \n2. LEFT SIDE");
                                        string fight5 = Console.ReadLine();
                                        if (fight5 == "1" || fight5 == "2")
                                        {
                                            Console.WriteLine($"{myName} dodges to their right and grab on its left where the sword in its eye was stuck");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("The beast flies east of the battlefield. Back to the village! You realize this beast must be killed now.");
                                            Thread.Sleep(4000);
                                            Console.WriteLine("You push the sword even more while struggling to hold on, \nthe beast falls a little but still has a some strength to fly.");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("For a split second");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("You and the beast starts falling into the market place, it roars and then...");
                                            Thread.Sleep(500);
                                            Console.WriteLine("THUD!!!");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("Stalls are squashed under the beast and needles fly into the sky in a final reflex from its tail, \neveryone in the village ducks for cover.");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"The beast is dead, {myName} yet lives");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"A sinister bony cackle is heard faintly, is this another villain? {myName} didn't care, right now they were a hero.");
                                        }
                                    }

                                    else if (fight4 == "2")
                                    {
                                        Console.WriteLine("Well you could've done more damage to it the other way but this is fine too.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("You slash at its leg, causing a large gash to appear.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Suddenly overcome by bloodlust, you slash at the beast some more even getting your sword, \nthen giving a final stab in its eye.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("The beast is now in a rage, gurgling roars pierce your ears.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Suddenly the beasts's armor breaks off, revealing splendid black wings.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("The beast flies up and back down to charge into you!");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("You must grab onto the beast or else it'll just keep firing needles from the air, out of your reach.  Which side will you grab on from? \n1. Left Side \n2. Right side");
                                        string fight5 = Console.ReadLine();
                                        if (fight5 == "1")
                                        {
                                            Console.WriteLine($"{myName} dodges to their right and grab on its left");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("The beast flies east of the battlefield. Back to the village! You realize this beast must be killed now.");
                                            Thread.Sleep(4000);
                                            Console.WriteLine("You push in the sword while struggling to hold on, \nthe beast falls a little but still has some strength to fly.");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("For a split second");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("You and the beast starts falling into the market place, it roars and then...");
                                            Thread.Sleep(500);
                                            Console.WriteLine("THUD!!!");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("Stalls are squashed under the beast and needles fly into the sky in a final reflex from its tail, \neveryone in the village ducks for cover.");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"The beast is dead, {myName} yet lives");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"A sinister bony cackle is heard faintly, is this another villain? {myName} didn't care, right now they were a hero.");
                                        }
                                        else if (fight5 == "2")
                                        {
                                            Console.WriteLine($"{myName} dodges to their left and grab on its right.");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"The beast does a barrel roll! {myName} was flung onto it's left side where the sword was stuck!");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("The beast flies east of the battlefield. Back to the village! You realize this beast must be killed now.");
                                            Thread.Sleep(4000);
                                            Console.WriteLine("You push in the sword while struggling to hold on, \nthe beast falls a little but still has some strength to fly.");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("For a split second");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("You and the beast starts falling into the market place, it roars and then...");
                                            Thread.Sleep(500);
                                            Console.WriteLine("THUD!!!");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("Stalls are squashed under the beast and needles fly into the sky in a final reflex from its tail, \neveryone in the village ducks for cover.");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"The beast is dead, {myName} yet lives");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"A sinister bony cackle is heard faintly, is this another villain? {myName} didn't care, right now they were a hero.");
                                        }
                                    }
                                }
                            }
                            else if (fight2 == "2")
                            {
                                Console.WriteLine("You roll into the attack, almost like you phase through the needle. You now stand closer to the beast");
                                Thread.Sleep(1000);
                                Console.WriteLine("The left of the beast's face is nearing you, something must be done. \n1. Bash its face with the shield \n2. Slash the face with your sword");
                                string fight3 = Console.ReadLine();
                                if (fight3 == "1")
                                {
                                    Console.WriteLine("The beast is stunned, the shield needle was dislodged into the beast's face and the neck is exposed!");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("Time slows, perhaps due to simply being in the moment, you should probably attack... \n1. Stab its neck \n2. Slash at its closest leg");
                                    string fight4 = Console.ReadLine();
                                    if (fight4 == "1")
                                    {
                                        Console.WriteLine("You stab its neck and past the roof of it's mouth, to the brain. You drag the blade along, causing even more pain.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("The beast is now in a rage, gurgling roars pierce your ears.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Suddenly the beasts's armor breaks off, revealing splendid black wings.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("The beast flies up and back down to charge into you!");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("You must grab onto the beast or else it'll just keep firing needles from the air, out of your reach.  Which side will you grab on from? \n1. Left Side \n2. Right side");
                                        string fight5 = Console.ReadLine();
                                        if (fight5 == "1")
                                        {
                                            Console.WriteLine($"{myName} dodges to their right and grab on its left where the needle is stuck");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("The beast flies east of the battlefield. Back to the village! You realize this beast must be killed now.");
                                            Thread.Sleep(4000);
                                            Console.WriteLine("You push in the needle while struggling to hold on, \nthe beast falls a little but still has some strength to fly.");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("For a split second");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("You and the beast starts falling into the market place, it roars and then...");
                                            Thread.Sleep(500);
                                            Console.WriteLine("THUD!!!");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("Stalls are squashed under the beast and needles fly into the sky in a final reflex from its tail, \neveryone in the village ducks for cover.");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"The beast is dead, {myName} yet lives");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"A sinister bony cackle is heard faintly, is this another villain? {myName} didn't care, right now they were a hero.");
                                        }
                                        else if (fight5 == "2")
                                        {
                                            Console.WriteLine($"{myName} dodges to their left and grab on its right.");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"The beast does a barrel roll! {myName} was flung onto it's left side where the needle is stuck!");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("The beast flies east of the battlefield. Back to the village! You realize this beast must be killed now.");
                                            Thread.Sleep(4000);
                                            Console.WriteLine("You push in the needle while struggling to hold on, \nthe beast falls a little but still has some strength to fly.");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("For a split second");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("You and the beast starts falling into the market place, it roars and then...");
                                            Thread.Sleep(500);
                                            Console.WriteLine("THUD!!!");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("Stalls are squashed under the beast and needles fly into the sky in a final reflex from its tail, \neveryone in the village ducks for cover.");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"The beast is dead, {myName} yet lives");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"A sinister bony cackle is heard faintly, is this another villain? {myName} didn't care, right now they were a hero.");
                                        }
                                    }

                                    else if (fight4 == "2")
                                    {
                                        Console.WriteLine("Well you could've done more damage to it the other way but this is fine too.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("You slash at its leg, causing a large gash to appear.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Suddenly overcome by bloodlust, you slash at the beast some more even getting your sword, \nthen giving a final stab in its eye");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("The beast is now in a rage, gurgling roars pierce your ears.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Suddenly the beasts's armor breaks off, revealing splendid black wings.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("The beast flies up and back down to charge into you!");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("You must grab onto the beast or else it'll just keep firing needles from the air, out of your reach.  Which side will you grab on from? \n1. Left Side \n2. Right side");
                                        string fight5 = Console.ReadLine();
                                        if (fight5 == "1")
                                        {
                                            Console.WriteLine($"{myName} dodges to their right and grab on its left where the needle is stuck");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("The beast flies east of the battlefield. Back to the village! You realize this beast must be killed now.");
                                            Thread.Sleep(4000);
                                            Console.WriteLine("You push in the needle while struggling to hold on, \nthe beast falls a little but still has some strength to fly.");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("For a split second");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("You and the beast starts falling into the market place, it roars and then...");
                                            Thread.Sleep(500);
                                            Console.WriteLine("THUD!!!");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("Stalls are squashed under the beast and needles fly into the sky in a final reflex from its tail, \neveryone in the village ducks for cover.");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"The beast is dead, {myName} yet lives");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"A sinister bony cackle is heard faintly, is this another villain? {myName} didn't care, right now they were a hero.");
                                        }
                                        else if (fight5 == "2")
                                        {
                                            Console.WriteLine($"{myName} dodges to their left and grab on its right.");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"The beast does a barrel roll! {myName} was flung onto it's left side where the needle is stuck!");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("The beast flies east of the battlefield. Back to the village! You realize this beast must be killed now.");
                                            Thread.Sleep(4000);
                                            Console.WriteLine("You push in the needle while struggling to hold on, \nthe beast falls a little but still has some strength to fly.");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("For a split second");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("You and the beast starts falling into the market place, it roars and then...");
                                            Thread.Sleep(500);
                                            Console.WriteLine("THUD!!!");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("Stalls are squashed under the beast and needles fly into the sky in a final reflex from its tail, \neveryone in the village ducks for cover.");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"The beast is dead, {myName} yet lives");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"A sinister bony cackle is heard faintly, is this another villain? {myName} didn't care, right now they were a hero.");
                                        }
                                    }
                                }
                                else if (fight3 == "2")
                                {
                                    Console.WriteLine("You slash at its face twice.");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("The skin is hard and scaly but you manage to get a cut in.");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("The beast turns its head away but then...");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("Time slows right as its left eye is facing you, perhaps due to simply being in the moment, \nyou should probably attack... \n1. Stab its eye \n2. Slash at its closest leg");
                                    string fight4 = Console.ReadLine();
                                    if (fight4 == "1")
                                    {
                                        Console.WriteLine("You stab your sword into its eye.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("The eye is thick but it works, the sword stabbed through, but you let go!.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("The beast roars then makes no more movement");
                                        Thread.Sleep(5000);
                                        Console.WriteLine("And then...");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("The beast stands up again! ");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Suddenly the beasts's armor breaks off, revealing splendid black wings.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("The beast flies up with the sword still in its left and back down to charge into you!");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("You must grab onto the beast, but which side?  \n1. Left side \n2. LEFT SIDE");
                                        string fight5 = Console.ReadLine();
                                        if (fight5 == "1" || fight5 == "2")
                                        {
                                            Console.WriteLine($"{myName} dodges to their right and grab on its left where the sword in its eye was stuck");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("The beast flies east of the battlefield. Back to the village! You realize this beast must be killed now.");
                                            Thread.Sleep(4000);
                                            Console.WriteLine("You push the sword even more while struggling to hold on, \nthe beast falls a little but still has a some strength to fly.");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("For a split second");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("You and the beast starts falling into the market place, it roars and then...");
                                            Thread.Sleep(500);
                                            Console.WriteLine("THUD!!!");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("Stalls are squashed under the beast and needles fly into the sky in a final reflex from its tail, \neveryone in the village ducks for cover.");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"The beast is dead, {myName} yet lives");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"A sinister bony cackle is heard faintly, is this another villain? {myName} didn't care, right now they were a hero.");
                                        }
                                    }

                                    else if (fight4 == "2")
                                    {
                                        Console.WriteLine("Well you could've done more damage to it the other way but this is fine too.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("You slash at its leg, causing a large gash to appear.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Suddenly overcome by bloodlust, you slash at the beast some more even getting your sword, \nthen giving a final stab in its eye.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("The beast is now in a rage, gurgling roars pierce your ears.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Suddenly the beasts's armor breaks off, revealing splendid black wings.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("The beast flies up and back down to charge into you!");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("You must grab onto the beast or else it'll just keep firing needles from the air, out of your reach.  Which side will you grab on from? \n1. Left Side \n2. Right side");
                                        string fight5 = Console.ReadLine();
                                        if (fight5 == "1")
                                        {
                                            Console.WriteLine($"{myName} dodges to their right and grab on its left");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("The beast flies east of the battlefield. Back to the village! You realize this beast must be killed now.");
                                            Thread.Sleep(4000);
                                            Console.WriteLine("You push in the sword while struggling to hold on, \nthe beast falls a little but still has some strength to fly.");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("For a split second");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("You and the beast starts falling into the market place, it roars and then...");
                                            Thread.Sleep(500);
                                            Console.WriteLine("THUD!!!");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("Stalls are squashed under the beast and needles fly into the sky in a final reflex from its tail, \neveryone in the village ducks for cover.");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"The beast is dead, {myName} yet lives");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"A sinister bony cackle is heard faintly, is this another villain? {myName} didn't care, right now they were a hero.");
                                        }
                                        else if (fight5 == "2")
                                        {
                                            Console.WriteLine($"{myName} dodges to their left and grab on its right.");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"The beast does a barrel roll! {myName} was flung onto it's left side where the sword was stuck!");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("The beast flies east of the battlefield. Back to the village! You realize this beast must be killed now.");
                                            Thread.Sleep(4000);
                                            Console.WriteLine("You push in the sword while struggling to hold on, \nthe beast falls a little but still has some strength to fly.");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("For a split second");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("You and the beast starts falling into the market place, it roars and then...");
                                            Thread.Sleep(500);
                                            Console.WriteLine("THUD!!!");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("Stalls are squashed under the beast and needles fly into the sky in a final reflex from its tail, \neveryone in the village ducks for cover.");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"The beast is dead, {myName} yet lives");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"A sinister bony cackle is heard faintly, is this another villain? {myName} didn't care, right now they were a hero.");
                                        }
                                    }
                                }
                            }
                        }

                        else if (fight1 == "2")
                        {
                            Console.WriteLine($"The absolutely terrified {myName} starts running away from the battle field, back the way they came.");
                            Thread.Sleep(1000);
                            Console.WriteLine("You run a short distance but then the beast gives chase.");
                            Thread.Sleep(1000);
                            Console.WriteLine("The beast's armor then breaks off and reveals splendid black wings.");
                            Thread.Sleep(1000);
                            Console.WriteLine("The beast jumps high into the air and swoops down");
                            Thread.Sleep(1000);
                            Console.WriteLine("It will soon swoop back down and grab you but there's still time! Do Something! \n1. Lie flat on the ground \n2. Keep running in a straight line ");
                        }
                    }

                    else if (selection1f == "2")
                    {
                        Console.WriteLine($"{myName} picks up the bow and arrows, takes a minimap, thanks the receptionist, \nand goes on their merry way to the Old Battlefield due west from the village.");
                        Thread.Sleep(1000);
                        Console.WriteLine("Hour One");
                        Console.WriteLine("On the road you pass a traveler who says not a single word, just a stare - a glare even - into your eyes, then keeps walking on.");
                        Thread.Sleep(3000);
                        Console.WriteLine("Hour Two");
                        Console.WriteLine("You get tired and rest beside a tree trunk, a few deer graze on some grass a few trees down.");
                        Thread.Sleep(3000);
                        Console.WriteLine("Hour Three");
                        Console.WriteLine("You get back up and continue, you come across an abandoned wooden barrel, nothing was inside");
                        Thread.Sleep(3000);
                        Console.WriteLine("Hour Three and a half");
                        Console.WriteLine("You come to a clearing, two old swords thrust in the ground long ago after the battles here, to mark the battleground.");
                        Thread.Sleep(1000);
                        Console.WriteLine("It's a quiet place with little vegetation, almost only dirt with old weapons lain about. Grim.");
                        Thread.Sleep(1000);
                        Console.WriteLine("(Maybe this is where that beast is, I never really got a good look at it)");
                        Thread.Sleep(3000);
                        Console.WriteLine("You start searching around for anything, anything at all.");
                        Thread.Sleep(3000);
                        Console.WriteLine("... nothing");
                        Thread.Sleep(3000);
                        Console.WriteLine("... nothing");
                        Thread.Sleep(3000);
                        Console.WriteLine("... something? ... nothing");
                        Thread.Sleep(5000);
                        Console.WriteLine($"{myName}: There's nothing here! Just rusty old swords and shields.");
                        Thread.Sleep(1000);
                        Console.WriteLine("You pick a shield to inspect it, holding it up to your face you suddenly feel a large thud on the face of the shield.");
                        Thread.Sleep(1000);
                        Console.WriteLine("A sharp needle pierced the shield, bewildered, you look up and see a huge beast a tail with needles at the end, \na face like a lizard, almost draconic, \na body like a horse, with plates of armor, \nit's legs were like a huge cat, nimble.");
                        Thread.Sleep(4000);
                        Console.WriteLine("Don't just stand there! Do something! \n1. Fight the beast \n2. Run away in fear");
                        string fight1 = Console.ReadLine();
                        if (fight1 == "1")
                        {
                            Console.WriteLine("Foolish choice, but it was your choice, this is your story after all.");
                            Thread.Sleep(1000);
                            Console.WriteLine($"{myName} drops the shield, takes out their bow, and readies and arrow.");
                            Thread.Sleep(1000);
                            Console.WriteLine($"The beast charges into {myName}, making them let go of the arrow,it gets shot into a crack in the beast's armor, ineffective.");
                            Thread.Sleep(1000);
                            Console.WriteLine("The beast fires a needle from it's tail, it misses. \nIt tries again, it won't miss this time. \n1. Pull up a shield \n2. Panic and Roll");
                            string fight2 = Console.ReadLine();
                            if (fight2 == "1")
                            {
                                Console.WriteLine("...");
                                Thread.Sleep(3000);
                                Console.WriteLine("What shield?");
                                Thread.Sleep(3000);
                                Console.WriteLine($"{myName}: Crap");
                                Thread.Sleep(1000);
                                Console.WriteLine("A fired needle gets stuck in your leg, it's very painful");
                                Thread.Sleep(1000);
                                Console.WriteLine("The beast then rears onto its hind legs and prepares to slash at you with its cat-like claws.");
                                Console.WriteLine("Time slows, perhaps due to simply being in the moment, you should probably attack... \n1. Quickly fire an arrow into its exposed neck \n2. Get up and and push into it while its unstable");
                                string fight3 = Console.ReadLine();
                                if (fight3 == "1")
                                {
                                    Console.WriteLine($"Though {myName}'s leg was pierced, their arms are still strong, they ready the bow and an arrow.");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("The arrow is loosed and it pierces the beast's neck, \nit falls onto its back in pain and you run near its face to stab an arrow into its eye.");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("The eye is thick but it works, the arrow stabbed through.");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("The beast roars then makes no more movement");
                                    Thread.Sleep(5000);
                                    Console.WriteLine("And then...");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("The beast stands up again! ");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("Suddenly the beasts's armor breaks off, revealing splendid black wings.");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("The beast flies up with the arrow still in its left and back down to charge into you!");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("You must grab onto the beast, but which side?  \n1. Left side \n2. LEFT SIDE");
                                    string fight4 = Console.ReadLine();
                                    if (fight4 == "1" || fight4 == "2")
                                    {
                                        Console.WriteLine($"{myName} dodges to their right and grab on its left where the arrow in its eye was stuck");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("The beast flies east of the battlefield. Back to the village! You realize this beast must be killed now.");
                                        Thread.Sleep(4000);
                                        Console.WriteLine("You push the arrow even more while struggling to hold on, \nthe beast falls a little but still has a some strength to fly.");
                                        Thread.Sleep(3000);
                                        Console.WriteLine("For a split second");
                                        Thread.Sleep(3000);
                                        Console.WriteLine("You and the beast starts falling into the market place, it roars and then...");
                                        Thread.Sleep(500);
                                        Console.WriteLine("THUD!!!");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Stalls are squashed under the beast and needles fly into the sky in a final reflex from its tail, \neveryone in the village ducks for cover.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine($"The beast is dead, {myName} yet lives");
                                        Thread.Sleep(1000);
                                        Console.WriteLine($"A sinister bony cackle is heard faintly, is this another villain? {myName} didn't care, right now they were a hero.");
                                    }
                                }
                                else if (fight3 == "2")
                                {
                                    Console.WriteLine($"{myName} rushes to the beast's belly and pushes into it with all their might!");
                                    Thread.Sleep(3000);
                                    Console.WriteLine("The beast slowly falls onto its back and the armor on its back digs into the beast's skin.");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("Suddenly a needle fires from the beast's tail.");
                                    Thread.Sleep(1000);
                                    Console.WriteLine($"{myName} catches it!? Some wicked reflexes were suddenlt instilled within our hero.");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("So now there's a needle in your hand, what to do I wonder? \n1. Run up to the beast's left eye and stab it \n2. Stab the beast's left eye while the narrator ridicules it");
                                    string fight4 = Console.ReadLine();
                                    if (fight4 == "1")
                                    {
                                        Console.WriteLine("You run up to the beast's left eye and stab it deep, nearly to the brain");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("The beast roars then makes no more movement");
                                        Thread.Sleep(5000);
                                        Console.WriteLine("And then...");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("The beast stands up again! ");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Suddenly the beasts's armor breaks off, revealing splendid black wings.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("The beast flies up with the needle still in its left eye and back down to charge into you!");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("You must grab onto the beast, but which side?  \n1. Left side \n2. LEFT SIDE");
                                        string fight5 = Console.ReadLine();
                                        if (fight5 == "1" || fight5 == "2")
                                        {
                                            Console.WriteLine($"{myName} dodges to their right and grab on its left where the needle in its eye was stuck");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("The beast flies east of the battlefield. Back to the village! You realize this beast must be killed now.");
                                            Thread.Sleep(4000);
                                            Console.WriteLine("You push the needle even more while struggling to hold on, \nthe beast falls a little but still has a some strength to fly.");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("For a split second");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("You and the beast starts falling into the market place, it roars and then...");
                                            Thread.Sleep(500);
                                            Console.WriteLine("THUD!!!");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("Stalls are squashed under the beast and needles fly into the sky in a final reflex from its tail, \neveryone in the village ducks for cover.");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"The beast is dead, {myName} yet lives");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"A sinister bony cackle is heard faintly, is this another villain? {myName} didn't care, right now they were a hero.");
                                        }
                                    }
                                    else if (fight4 == "2")
                                    {
                                        Console.WriteLine("You run up to the beast's left eye and stab it deep indeed, nearly to the brain");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("The beast roars then makes no more movement, what an embarrassment");
                                        Thread.Sleep(5000);
                                        Console.WriteLine("And then...");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("The beast stands up again instead of taking the L! ");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Suddenly the beasts's shoddy armor breaks off, revealing off brand black wings.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("The beast flies up with the needle still in its left eye and back down to charge into you (which it won't)!");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("You must grab onto the beast, but which side?  \n1. Left side \n2. LEFT SIDE");
                                        string fight5 = Console.ReadLine();
                                        if (fight5 == "1" || fight5 == "2")
                                        {
                                            Console.WriteLine($"{myName} dodges to their right and grab on its left where the needle in its eye was stuck");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("The beast flies east of the battlefield. Back to the village! You realize this beast must be killed now.");
                                            Thread.Sleep(4000);
                                            Console.WriteLine("You push the needle even more while struggling to hold on, \nthe beast falls a little but still has a some strength to fly.");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("For a split second");
                                            Thread.Sleep(3000);
                                            Console.WriteLine("You and the beast starts falling into the market place, it roars and then...");
                                            Thread.Sleep(500);
                                            Console.WriteLine("THUD!!!");
                                            Thread.Sleep(1000);
                                            Console.WriteLine("Stalls are squashed under the beast and needles fly into the sky in a final reflex from its tail, \neveryone in the village ducks for cover.");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"The beast is dead, {myName} yet lives");
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"A sinister bony cackle is heard faintly, is this another villain? {myName} didn't care, right now they were a hero.");
                                        }
                                    }
                                }
                            }

                            else if (fight2 == "1")
                            {
                                Console.WriteLine("You roll into the attack, almost like you phase through the needle. You now stand closer to the beast");
                                Thread.Sleep(1000);
                                Console.WriteLine("The left of the beast's face is nearing you, something must be done. \n1. Fire an arrow into the beast's eye \n2. Jump and kick the beast's face then fire an arrow into its eye");
                                string fight3 = Console.ReadLine();
                                if (fight3 == "1")
                                {
                                    Console.WriteLine("You draw the arrow and fire - ");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("It missed the mark... (you were at point blank by the way)");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("Frustrated you grab an arrow from your quiver and stab at the beast like a madman.");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("The arrow in your hand suddenly disappeared...");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("Into the beast's left eye!");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("The beast roars then makes no more movement");
                                    Thread.Sleep(5000);
                                    Console.WriteLine("And then...");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("The beast stands up again! ");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("Suddenly the beasts's armor breaks off, revealing splendid black wings.");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("The beast flies up with the arrow still in its left and back down to charge into you!");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("You must grab onto the beast, but which side?  \n1. Left side \n2. LEFT SIDE");
                                    string fight4 = Console.ReadLine();
                                    if (fight4 == "1" || fight4 == "2")
                                    {
                                        Console.WriteLine($"{myName} dodges to their right and grab on its left where the arrow in its eye was stuck");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("The beast flies east of the battlefield. Back to the village! You realize this beast must be killed now.");
                                        Thread.Sleep(4000);
                                        Console.WriteLine("You push the arrow even more while struggling to hold on, \nthe beast falls a little but still has a some strength to fly.");
                                        Thread.Sleep(3000);
                                        Console.WriteLine("For a split second");
                                        Thread.Sleep(3000);
                                        Console.WriteLine("You and the beast starts falling into the market place, it roars and then...");
                                        Thread.Sleep(500);
                                        Console.WriteLine("THUD!!!");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Stalls are squashed under the beast and needles fly into the sky in a final reflex from its tail, \neveryone in the village ducks for cover.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine($"The beast is dead, {myName} yet lives");
                                        Thread.Sleep(1000);
                                        Console.WriteLine($"A sinister bony cackle is heard faintly, is this another villain? {myName} didn't care, right now they were a hero.");
                                    }
                                }
                                else if (fight3 == "2")
                                {
                                    Console.WriteLine("You messed up your order of operations...");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("You were meant to kick off the beast's face, then fire the arrow in the air looking all cool...");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("Instead you shot the arrow first into the beast's eye and pushed the arrow deeper by kicking it in, \nthe change in expected surface area you were meant to kick off of made you slip into the air.");
                                    Thread.Sleep(5000);
                                    Console.WriteLine("The beast by the way fell over from the pain.");
                                    Thread.Sleep(1000);
                                    Console.WriteLine($"For a moment {myName} believed the beast to be dead.");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("And then...");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("The beast stands up again! ");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("Suddenly the beasts's armor breaks off, revealing splendid black wings.");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("The beast flies up with the arrow still in its left and back down to charge into you!");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("You must grab onto the beast, but which side?  \n1. Left side \n2. LEFT SIDE");
                                    string fight4 = Console.ReadLine();
                                    if (fight4 == "1" || fight4 == "2")
                                    {
                                        Console.WriteLine($"{myName} dodges to their right and grab on its left where the arrow in its eye was stuck");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("The beast flies east of the battlefield. Back to the village! You realize this beast must be killed now.");
                                        Thread.Sleep(4000);
                                        Console.WriteLine("You push the arrow even more while struggling to hold on, \nthe beast falls a little but still has a some strength to fly.");
                                        Thread.Sleep(3000);
                                        Console.WriteLine("For a split second");
                                        Thread.Sleep(3000);
                                        Console.WriteLine("You and the beast starts falling into the market place, it roars and then...");
                                        Thread.Sleep(500);
                                        Console.WriteLine("THUD!!!");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Stalls are squashed under the beast and needles fly into the sky in a final reflex from its tail, \neveryone in the village ducks for cover.");
                                        Thread.Sleep(1000);
                                        Console.WriteLine($"The beast is dead, {myName} yet lives");
                                        Thread.Sleep(1000);
                                        Console.WriteLine($"A sinister bony cackle is heard faintly, is this another villain? {myName} didn't care, right now they were a hero.");
                                    }
                                }
                            }
                        }
                        else if (fight1 == "2")
                        {
                            
                        }
                    }
                }
                else if (selection1e == "2")
                {
                    Console.WriteLine($"{myName} chooses to go to the Sea of Wheat, no description was provided in the map legend for this place so it's shrouded in mystery,\n {myName} doesn't really see any danger in this place but needs a weapon just in case.");
                    Thread.Sleep(1000);
                    Console.WriteLine($"{myName}: Excuse me miss receptionist, I might not be a member of the guild but do you have any weapons I could use for my journey?");
                    Thread.Sleep(1000);
                    Console.WriteLine("Receptionist: Certainly, we have 2 lost weapons in our posession, they weren't claimed by their owners so you may have one.");
                    Thread.Sleep(1000);
                    Console.WriteLine("She points to a slightly rusted sword (a saber to be exact) and an unremarkable bow and a quiver of 20 arrows.\n1. Choose the sword \n2. Choose the Bow");
                    string selection1f = Console.ReadLine();
                    if (selection1f == "1")
                    {

                    }

                    else if (selection1f == "2")
                    {

                    }
                }
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

