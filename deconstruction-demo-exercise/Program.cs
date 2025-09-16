// Get Player Name
Console.WriteLine("Greetings Traveller! What is your name?");
string playerName = Console.ReadLine();
Console.WriteLine("");

// Get Player Gold Amount
Console.WriteLine("Forgive me for being rude, but how many gold coins do you have?");
int playerGold = int.Parse(Console.ReadLine());
Console.WriteLine("");

// Check if Player has enough Gold to trade
if (playerGold >= 15)
{
    Console.WriteLine($"Ah, Sir {playerName}, you are a wealthy one! Please, come in and have a look at this Bronze Sword I have.");
    Console.WriteLine("It's a fine weapon, perfect for any adventurer, and it costs 15 gold!");
    Console.WriteLine("");

    int swordPrice = 15;
    playerGold -= swordPrice;
    Console.WriteLine($"You have purchased the Bronze Sword for {swordPrice} gold. You now have {playerGold} gold left. Safe travels, Sir {playerName}!");
}
else
{
    Console.WriteLine($"I'm sorry, Sir {playerName}, but it seems you don't have enough gold to trade with me. Safe travels!");
}