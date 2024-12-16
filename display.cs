using System;
using System.Runtime.InteropServices.Marshalling;

public class Display
{
    private string estorcoAccount = "Roy";
    private string bsitPin = "123456";
    private double accountBalance = 1000.00;
    private int choice; 
    private int padayun;
    private double transfer;
    private Method method = new Method();
    public string EstorcoAccount
    {
        get { return estorcoAccount; }
        set { estorcoAccount = value; }
    }

    public int Choice
    {
        get { return choice; }
        set { choice = value; }
    }

    public int Padayun
    {
        get { return padayun; }
        set { padayun = value; }
    }

    

    public string BsitPin
    {
        get { return bsitPin; }
        set { bsitPin = value; }
    }

    public double AccountBalance
    {
        get { return accountBalance; }
        set { accountBalance = value; }
    }
    public double Transfer{
        get{return transfer;}
        set{transfer = value;}
    }

    public void SetBsitPin(string newPin)
    {
        BsitPin = newPin;
    }
    
    
    
    public void Sing()
    {  
        Console.WriteLine(" ");
        Console.ForegroundColor = ConsoleColor.White;
        string userInputPin;
        do{
        Console.WriteLine("ROY'S BANK");
        Console.WriteLine();
        Console.Write("Enter your PIN: ");
           Thread.Sleep(250);
             userInputPin = "";
            Thread.Sleep(250);
            ConsoleKeyInfo key;
        
          do{
                 key = Console.ReadKey(true);

                if (char.IsDigit(key.KeyChar) && userInputPin.Length < 6)
                {
                    Console.Write(key.KeyChar);
                    Thread.Sleep(100);
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    Console.Write("*");
                    userInputPin += key.KeyChar;
                }
                else if (key.Key == ConsoleKey.Backspace && userInputPin.Length > 0)
                {
                    userInputPin = userInputPin.Substring(0, userInputPin.Length - 1);
                    Console.Write("\b \b");
                }
            } while (key.Key != ConsoleKey.Enter);
               Console.WriteLine();
           if(string.IsNullOrEmpty(userInputPin) || userInputPin.Length < 6){
            Console.WriteLine("Anga a oi! error..Pin must be 6 digits");
           }
        }while(string.IsNullOrEmpty(userInputPin) || userInputPin.Length < 6);
            do{
            if (userInputPin == BsitPin)
            {
                Console.WriteLine("Authentication successful!");
                Console.Clear();
                Console.WriteLine("             Please select an option               ");
                Console.WriteLine("||===============================================||");
                Console.WriteLine("||  1. Deposit               2. Inquire balance  ||");
                Console.WriteLine("||                                               ||");
                Console.WriteLine("||  3. Withdraw              4. Others Services  ||");
                Console.WriteLine("||                                               ||");
                Console.WriteLine("||  5. Fastcash              6. Bank Transfer    ||");
                Console.WriteLine("||===============================================||");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ");
                Console.Write("Enter your choice:");

                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 6)
                {
                    Console.WriteLine("Invalid input");
                    Console.Write("Enter your choice: ");
                }

                switch (choice)
                {
                    case 1:
                    Animal animal = new Animal();
                    animal.Depo(ref accountBalance,ref transfer);
                        break;
                    case 2:
                    Human smart = new Human();
                    smart.Bal(ref accountBalance,this,ref transfer,ref bsitPin);
                        break;
                    case 3:
                    Hacker ko = new Hacker();
                    ko.Withdraw(ref accountBalance);
                        break;
                    case 4:
                    News fire = new News();
                        fire.Others(this);
                        break;
                    case 5:
                        method.Fast(ref accountBalance);
                    break;
                    case 6:
                        method.Bank(ref accountBalance,ref bsitPin,this,ref transfer);
                    break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
             else
            {
                Console.WriteLine("Authentication failed. Please try again.");
                Sing();
            }
            Console.WriteLine("Enter 1 to continue and 0 to exit");
            Console.WriteLine("Enter: ");
            while(!int.TryParse(Console.ReadLine(),out padayun)){
                Console.WriteLine("ERROR");
                Console.WriteLine("Enter: ");
            }
            }while(padayun!=0);
            
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Bawi ta Self");
    }
   

}








