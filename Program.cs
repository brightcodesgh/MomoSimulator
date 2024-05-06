using System;

class MTNMobileMoneyUI
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to MTN Mobile Money\nSend, Withdraw and Deposit");

        MainMenu();
    }

    static void MainMenu()
    {
        Console.WriteLine("\nSelect an option:");
        Console.WriteLine("1. Send Money");
        Console.WriteLine("2. Buy Airtime");
        Console.WriteLine("3. Pay Bill");
        Console.WriteLine("4. Check Balance");
        Console.WriteLine("5. My Account");
        Console.WriteLine("6. Exit");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                SendMoney();
                break;
            case 2:
                BuyAirtime();
                break;
            case 3:
                PayBill();
                break;
            case 4:
                CheckBalance();
                break;
            case 5:
               // MyAccount();
                break;
            case 6:
                Console.WriteLine("Thank you for using MTN Mobile Money");
                return;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                MainMenu();

                break;
        }
    }



    static void CheckBalance()
    {
        Console.WriteLine("Your balance is \n" + "GHC" + 5000 +"\n");
        Console.WriteLine("NB: This is your default Momo balance");
    }

    static void SendMoney()
    {
        Console.WriteLine("\nEnter recipient's phone number:");
        string recipientNumber = Console.ReadLine();

        Console.WriteLine("Enter amount to send (GHS):");
        decimal amount = decimal.Parse(Console.ReadLine());

        // Simulate confirmation (without actual money transfer)
        Console.WriteLine("\nYou are about to send " + "GHC " + amount + " to "+ recipientNumber);
        Console.WriteLine("Enter Pin: ");
        String pin =  Console.ReadLine();

        Console.WriteLine("You are about to send " + amount + " to " + recipientNumber + " \n");
        Console.WriteLine("Confirm (y/n)?");
	    char confirm = char.Parse(Console.ReadLine().ToLower());
	    if (confirm == 'y' && pin == "1231")
	    {
	    Console.WriteLine("Sending Money....");
        System.Threading.Thread.Sleep(4000); // Sleep for 4000 milliseconds (4 seconds)
        Console.WriteLine("Transaction Successful!");

        } else
        {
            Console.WriteLine("Transaction canceled.");
        }

        System.Threading.Thread.Sleep(1000);
        // Return to main menu
        MainMenu();
     }

    static void PayBill()
    // Bill Payment Option
    {
        Console.WriteLine("\nSelect bill category:");
        Console.WriteLine("1. Electricity");
        Console.WriteLine("2. Water");
        Console.WriteLine("3. Cable TV");
        Console.WriteLine("4. Other");

        int choice = int.Parse(Console.ReadLine());

        string billProvider;
        string accountNumber;
        decimal billAmount;

        switch (choice)
        {
            case 1:
                billProvider = "Enter electricity provider (e.g., ECG):";
                break;
            case 2:
                billProvider = "Enter water provider (e.g., GWCL):";
                break;
            case 3:
                billProvider = "Enter cable TV provider (e.g., DStv):";
                break;
            case 4:
                billProvider = "Enter bill provider:";
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                PayBill();
                return;
        }

        Console.WriteLine($"\n{billProvider}");
        billProvider = Console.ReadLine();

        Console.WriteLine("\nEnter account number:");
        accountNumber = Console.ReadLine();


        Console.WriteLine("\nEnter Amount:");
        billAmount = decimal.Parse(Console.ReadLine());

        Console.WriteLine("\nYou are about to Pay a bill of " + "GHC " + billAmount + " to " + accountNumber +" (+" +billProvider+")");
        Console.WriteLine("Confirm (y/n)?");

        char confirm = char.Parse(Console.ReadLine().ToLower());

        if (confirm == 'y')
        {
            Console.WriteLine("Processing Bill payment...");
            Console.WriteLine("Bill payment successful!");
        }
        else
        {
            Console.WriteLine("Airtime purchase canceled.");
        }




    }


    static void BuyAirtime()
	{
	Console.WriteLine("\nEnter your phone number:");
	string phoneNumber = Console.ReadLine();
	Console.WriteLine("Enter amount to buy:");
	decimal amount = decimal.Parse(Console.ReadLine());
	// Simulate confirmation \(without actual airtime purchase\)
	Console.WriteLine("\nYou are about to buy an airtime of " + "GHC " + amount + " to " + phoneNumber);
        Console.WriteLine("Confirm (y/n)?");
        char confirm = char.Parse(Console.ReadLine().ToLower());

        if (confirm == 'y')
        {
            Console.WriteLine("Processing airtime purchase...");
            Console.WriteLine("Airtime purchase successful!");
        }
        else
        {
        Console.WriteLine("Airtime purchase canceled.");
        }

        // Return to main menu
        MainMenu();
    }

}



