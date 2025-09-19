//Player info and context
Console.WriteLine("What's your name?");
string playerName = Console.ReadLine();
Console.WriteLine($"Oh no, {playerName}! You've run out of some ingredients to make lunch with...");
Console.WriteLine($"[You leave the house with a budget of $20 and head to the grocery store.]");
int playerMoney = 20;
int playerTotal = 0;

//Present carb options
Console.WriteLine("Let's see.. A loaf of bread costs $3 and a bag of rice costs $7.");
Console.WriteLine("Which one calls to you?");
Console.WriteLine("BREAD or RICE?");
int playerBread = 3;
int playerRice = 7;
string responseCarbs = Console.ReadLine();

//Player chooses bread
if (responseCarbs.ToLower() == "bread")
{
    Console.WriteLine("[A loaf of bread has been added to your cart!]");
    Console.WriteLine("Great! Now, let's look for meat to put on top of the bread..");
    playerTotal += playerBread;
}

//Player chooses rice
else if (responseCarbs.ToLower() == "rice")
{
    Console.WriteLine("[A bag of rice has been added to your cart!]");
    Console.WriteLine("Hooray! Now, let's look for meat to go with the rice..");
    playerTotal += playerRice;
}

//Invalid response
else
{
    Console.WriteLine($"You want to use {responseCarbs.ToLower()}?? Are you sure? BREAD or RICE sounds really good right now...");
}

//Present meat options
Console.WriteLine("Ooh, there's ham for $9 or chicken for $8!");
Console.WriteLine("Which one are you craving?");
Console.WriteLine("HAM or CHICKEN?");
int playerHam = 9;
int playerChicken = 8;
string responseMeat = Console.ReadLine();

//Player chooses ham
if (responseMeat.ToLower() == "ham")
{
    Console.WriteLine("[A pack of ham has been added to your cart!]");
    Console.WriteLine("Mmm, that is an excellent choice!");
    playerTotal += playerHam;
}

//Player chooses chicken
else if (responseMeat.ToLower() == "chicken")
{
    Console.WriteLine("[A pack of chicken has been added to your cart!]");
    Console.WriteLine("Mmm, this is going to be a delicious lunch!");
    playerTotal += playerChicken;
}

else
{
    Console.WriteLine($"You haven't cooked with {responseMeat.ToLower()} before... Best to stick with HAM or CHICKEN for now!");
}

//Player picks up chips
Console.WriteLine("[On the way to the cash register, you pass by the snack aisle and it catches your attention...]");
Console.WriteLine("[You pick up a bag of chips..]");

//Ask for quantity of chips at home
Console.WriteLine("WAIT!!! How many bags of chips do you already have at home?!");
Console.WriteLine("Type the digits.");
int playerChipsOwned = int.Parse(Console.ReadLine());

//Chips quantity < 0 message
if (playerChipsOwned <= 0)
{
    Console.WriteLine("There's definitely one in the back of the top left kitchen cabinet...");
}

//Chips quantity > 1 message
else if (playerChipsOwned >= 1)
{
    Console.WriteLine($"Hmm, {playerChipsOwned} seems like enough.. {++playerChipsOwned} is one too many!");
}

//Invalid response
else
{
    Console.WriteLine($"[{playerChipsOwned} you say? What's that? Does that really exist??]");
}

Console.WriteLine("[You put the chips back and continue to the cash register.]");

//Player total calculated
Console.WriteLine($"The cashier scans your items and says,");
Console.WriteLine($"\"Good morning!");
Console.WriteLine($"Your total is ${playerTotal}!");

//Player payment method
Console.WriteLine("Would you like to pay by card or cash?\"");
Console.WriteLine("Type CARD or CASH.");
string responsePayment = Console.ReadLine();

//By card
if (responsePayment.ToLower() == "card")
{
    Console.WriteLine("[Your payment has been approved!]");
}

//By cash
else if (responsePayment.ToLower() == "cash")
{
    playerMoney -= playerTotal;
    Console.WriteLine($"[You received ${playerMoney} back in change!]");
}

//Invalid answer
else
{
    Console.WriteLine($"Sorry we don't accept {responsePayment}, but we do accept CARD or CASH.");
}

//Player is asked for money
Console.WriteLine("As you exit the store, a stranger approaches you and asks,");
Console.WriteLine("\"Excuse, me!");
Console.WriteLine("Do you have any change?");
Console.WriteLine("I need to pay for my bus fare...\"");


//Player can spare change
bool hasChange = true;
if (hasChange)
{   
    Console.WriteLine("You answer,");
    Console.WriteLine("\"I might! Let me check my wallet..\"");
    Console.WriteLine("[You reach for your wallet and give them $2.]");
    Console.WriteLine("\"Thank you so much!!\"");
}

//Player cannot spare change
else
{
   Console.WriteLine("You say,");
   Console.WriteLine("\"Sorry, I don't have any on me right now...\"");
   Console.WriteLine("\"They reply,\"");
   Console.WriteLine("\"Aw, that's alright. Have a nice day!\"");
}

//End
Console.WriteLine("[Then, you continue your journey home.]");
Console.WriteLine("[After getting back home, you cook a meal worthy of being in a 3-Star Michelin restaurant menu.]");