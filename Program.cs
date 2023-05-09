import random
import time
import pickle

def start():

    print("Welcome to The Adventures of ___")

    print("1. Start Game")

    print("2. Options")

    print("3. Quit")

menu = input("Select your option: ")

#If the player selects 1 to start the game
if menu == "1":
    print("...")
    print("...")
    print("*Inaudable noise*")
    print("Ugh, what happened?")
    print("Where am I?")
    print("*Stands up*")
    print("I gotta ask someone what this place is")
    print("Last time I remember, I was out in the fields before a beast appeared out of the ground")
    print("...")
    print("Why are some people giving me a strange glance...")
    print("I gotta ask someone about this place")
    print("*Approches person*")

    selection1 = input("Oh, hello! What can I help you with?\n1. Inquire about the place\n2. Pickpocket ")

    if selection1 == "1":
        print("Oh, you're a newcomer huh? Well, this is Saber village.\n")
    elif selection1 == "2":
        print("Hey! What are you doing?! GET BACK HERE!")
        print("*After reaching a safe space within the village...*")
        print("Right, looks like I'm away from him")
        print("Now that I have some money, I guess I should get some food.\nI'm starving...")
        print("After having a meal from a local restaurant")
        selection2b = input("")

#If the player selects 2 for settings
elif menu == "2":
    print("Settings:")

#If the player selects 3 to quit the game
elif menu == "3":
    print("Thank you for visiting ___!")
    quit()
