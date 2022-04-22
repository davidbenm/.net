string[] userNames = new string[3] { "John", "" , "" };
// this is new
int currentIndex = 1;
Console.WriteLine("Welcome to our restaurant!");
string userType;
while (currentIndex < userNames.Length)
{
    /*if (currentIndex == userNames.Length)
    { 
        Console.WriteLine("\nThe restaurant is full, try again next week.");
        Environment.Exit(0);
    }*/
    Console.WriteLine("\n \nAre you a registered client? Write 'yes' if you are, or write 'no' to register.");
    userType = Console.ReadLine();
    if (userType == "yes")
    {
        Console.WriteLine("Hello, you are a registered user, please enter your user name:");
        string userToSearch = Console.ReadLine();
        Console.WriteLine($"The user you search is {userToSearch}.");
        int indexOfExistingUser = Array.IndexOf(userNames, userToSearch);
        if (indexOfExistingUser == -1)
        {
            Console.WriteLine("User not found, try again or register.");
        }
        else
        {
            Console.WriteLine($"Welcome {userNames[indexOfExistingUser]}, it's a pleasure to serve you.");
        }
    }
    else if (userType == "no")
    {
        Console.WriteLine("Please write and remember your user name.");
        userNames[currentIndex] = Console.ReadLine();
        Console.WriteLine($"Your user '{userNames[currentIndex]}' has been saved successfully.");
        currentIndex++;
    }
    else
    { 
        Console.WriteLine("You entered a wrong statement, please try again.");
    }
}
Console.WriteLine("\nThe restaurant is full, try again next week.\n \nThese are the registered clients:\n");
int auxIndex = 1;
foreach (string userName in userNames)
{ 
    Console.WriteLine("{0}. {1}.", auxIndex, userName);
    auxIndex++;
}
Environment.Exit(0);
