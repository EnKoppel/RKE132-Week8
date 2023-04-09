string folderPath = @"C:\Users\endri\OneDrive\Documents\Data\";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));


//string[] heroes = { "Batman", "Superman", "Hulk", "Iron Man","Black Panther" };
//string[] villains = { "Joker", "Darth Vader", "Bane", "Magneto", "Venom", "Doctor Octopus" };


string[] weapon = { "Plastic Fork", "Lasso", "Batarands", "Mjolnir", "AK-47", "Banana", "Wooden Sword" };



string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"You are {hero} and your weapon is {heroWeapon}!");



string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Your enemy is {villain} with {villainWeapon}!");

static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0,someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}