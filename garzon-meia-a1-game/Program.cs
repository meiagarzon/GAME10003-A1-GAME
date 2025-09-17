//Context
using System.ComponentModel.Design;

Console.WriteLine("What's your name?");
string playerName = Console.ReadLine();
Console.WriteLine($"Oh no, {playerName}! You've run out of some ingredients to make lunch with...");
Console.WriteLine("[You leave the house with a budget of $20 and head to the grocery store.]");
int playerMoney = 100;
int playerTotal = 0;

//Present carb options
Console.WriteLine("Let's see.. A loaf of bread costs $3 and a bag of rice costs $7.");
Console.WriteLine("Which one would you like to get? Type BREAD or RICE.");
int playerBread = 3;
int playerRice = 7;
string response = Console.ReadLine();

//Player chooses bread
if (response == "BREAD")
{
    Console.WriteLine("Great! Now, let's look for meat to put on the bread..");
    playerTotal += playerBread;
}

//Player chooses rice
else if (response == "RICE")
{
    Console.WriteLine("Hooray! Now, let's look for meat to go with the rice..");
    playerTotal += playerRice;
}

//Invalid response
else
{
    Console.WriteLine($"Invalid response {response}. Use BREAD or RICE.");
}

//Present meat options
Console.WriteLine("Ooh, there's ham for $9 or chicken for $8!");
Console.WriteLine("Which one do you want to get? Type HAM or CHICKEN.");
int playerHam = 9;
int playerChicken = 8;
string responseMeat = Console.ReadLine();

//Player chooses ham
if (responseMeat == "HAM")
{
    Console.WriteLine("Mmm, that is an excellent choice!");
    playerTotal += playerHam;
}

//Player chooses chicken
else if (responseMeat == "CHICKEN")
{
    Console.WriteLine("Mmm, this is going to be a delicious lunch!");
    playerTotal += playerChicken;
}

else
{
    Console.WriteLine($"Invalid response {responseMeat}! Use HAM or CHICKEN.");
}

//Player is distracted by snacks; ask for quantity of chips at home
Console.WriteLine("[On the way to the cash register, you pass by the snack aisle and it catches your attention...]");
Console.WriteLine("Would you like to pick up a bag of chips for $2? Type YES or NO.");
string responseChips = Console.ReadLine();

//Player picks up chips
if (responseChips == "YES")
{
    Console.WriteLine("WAIT!!! How many bags of chips do you already have at home!?");
    int playerChipsOwned = int.Parse(Console.ReadLine());
    Console.WriteLine($"Hmm, {playerChipsOwned} seems like enough.. {++playerChipsOwned} is one too many!");
    Console.WriteLine("[You continue to the cash register.]");
}

//Player leaves chips
else if (responseChips == "NO")
{
    Console.WriteLine("That's 2 less dollars spent today!");
    Console.WriteLine("[You continue to the cash register.]");
}

//Invalid response
else
{
    Console.WriteLine($"Invalid response {responseChips}. Use YES or NO.");
    Console.WriteLine("[You turn around and leave the aisle..]");
}

//Player total is calculated
Console.WriteLine("The cashier scans your items and says, \"Good morning!\"");
Console.WriteLine($"\"Your total is ${playerTotal}!\"");

//Player payment method
Console.WriteLine("Then, they say, \"Would you like to pay by card or cash?\"");
Console.WriteLine("Type CARD or CASH.");
string responsePayment = Console.ReadLine();

//By card
if (responsePayment == "CARD")
{
    Console.WriteLine("[Your payment has been approved!]");
}

//By cash
if (responsePayment == "CASH")
{
    playerMoney -= playerTotal;
    Console.WriteLine($"[You have ${playerMoney} left!]");
}


/*bool isUsingCard = true;

if (isUsingCard)
{
    Console.WriteLine("[Your payment has been approved!]");
}

else
{
    Console.WriteLine($"[You have ${playerMoney} - {playerTotal} left!]");
}*/
