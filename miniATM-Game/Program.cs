/*Hello dear user This app just for game
 In ths game we show you how to use (if else while switch case) statemants
And nothing else */
Console.WriteLine("---------------\n m i n i A T M \n---------------\n");
Console.WriteLine("secret code is 12345  and your Balane is  $100,000,000");

int Balance = 100000000;
bool loggedin=false;
while (!loggedin)
{
    Console.Write("Enter your secret code :");
    string user=Console.ReadLine();
    int secret;
    int.TryParse(user, out secret);
    if(secret == 12345)
    {
        loggedin = true;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("----WRONG----");
        Console.ResetColor();
    }
}
bool exitApp=false;

while (!exitApp)
{
    Console.Clear();
    Menu();
    Console.Write("\tEnter a number :");
    string cho=Console.ReadLine();
    int choice;
    int.TryParse(cho, out choice);
    switch (choice)
    {
        case 1:
            Console.WriteLine($"your Balance is {Balance:C0}");
            Console.ReadKey();
            break;
        case 2:
            Console.Write("enter your need: ");
            string y_b = Console.ReadLine();
            int withdraw;
            int.TryParse(y_b,out withdraw);
            if (withdraw > 0 && Balance >= withdraw)
            {
                Balance-=withdraw;
                Console.WriteLine($"Your New Balance = {Balance:C0}");
            }
            else
            {
                Console.WriteLine($"---your numer is les than your Balance:{Balance:C0}");
            }  
            Console.ReadKey();
            break;
        case 3:
            exitApp = true;
            break;
        default:
            Console.WriteLine("wrong");
            Console.ReadKey();
            break;
    }
}


static void Menu()
{
    Console.WriteLine("\n\t------------\n\t1.chek your Balance\n\t2.Withdraw\n\t3.Exit\n\t----------");
}