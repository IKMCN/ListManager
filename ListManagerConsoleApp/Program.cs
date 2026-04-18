string menuChoice = string.Empty;
String inputString = String.Empty;
List<string> strings = new();
strings.Add("Test1");
strings.Add("Test2");
strings.Add("Test3");

while (menuChoice != "0")
{
    
    menuChoice = DisplayMenu();

    switch (menuChoice)
    {
        case "0":
            Console.WriteLine("Exiting program");
            break;
        case "1":
            DisplayList();
            break;
            case"2":
            Console.Write("Enter item to add:");
            AddItemToList();
            DisplayList();
            break;
            case"3":
            Console.Write("Enter index of item to delete:");
            DeleteItemFromList();
            DisplayList();
            break;
            case"4":
            Console.Write("Enter index of item to Ammend:");
            AmmendItemInList();
            DisplayList();
            break;
            default:
            Console.WriteLine("Invalid choice!");
            break;
    }

}

string DisplayMenu()
{
    string menuChoice = string.Empty;
    Console.WriteLine("0 - Quit");
    Console.WriteLine("1 - Display List");
    Console.WriteLine("2 - Add to List");
    Console.WriteLine("3 - Remove from List");
    Console.WriteLine("4 - Ammend the List");
    menuChoice = Console.ReadLine();
    return menuChoice;
}

string ReadStringIn()
{
    string inputString = string.Empty;
    return inputString = Console.ReadLine();    
}

int  ConvertStringToInt(string inputString)
{    
    if (Int32.TryParse(inputString, out int numValue))
    {
        Console.WriteLine($"You entered:{numValue}");
    }
    else
    {
        Console.WriteLine($"Int32.TryParse could not parse '{inputString}' to an int.");        
    }
    return numValue;
}

void DeleteItemFromList()
{
    inputString = ReadStringIn();
    int inputInteger = ConvertStringToInt(inputString);
    strings.RemoveAt(inputInteger);
}

void AddItemToList()
{
    inputString = ReadStringIn();
    strings.Add(inputString);
}

void AmmendItemInList()
{
    inputString = ReadStringIn();
    int inputInteger = ConvertStringToInt(inputString);
    Console.WriteLine("Enter Text to Ammend Item:");
    inputString = ReadStringIn();
    strings[inputInteger] = inputString;

}

void DisplayList()
{
    Console.WriteLine("List Contents:");
    for (int i = 0; i < strings.Count; i++)
    {
        Console.WriteLine($"Item at Index{i.ToString()}:{ strings[i]}");
    }
    Console.ReadLine();
}



