using System;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Transactions;

public class Animal{
    public virtual void Depo(ref double accountBalance,ref double transfer)
    {
        double deposit;
        Console.WriteLine("Deposit option selected");
        Console.Write("Enter the amount to deposit: ");

        while (!double.TryParse(Console.ReadLine(), out deposit) || deposit < 1)
        {
            Console.WriteLine("Error");
            Console.Write("Enter the amount to deposit: ");
        }

        double balance = accountBalance + deposit;
        accountBalance = balance;
        Console.WriteLine("Deposited Amount of: " + deposit);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("||============================||");
        Console.WriteLine("||          RECEIPT           ||");
        Console.WriteLine("||============================||");
        Console.WriteLine("||Transaction type: Deposit   ||");
        Console.WriteLine("||                            ||");
        Console.WriteLine("||Account Balance:"+accountBalance +  "||");
        Console.WriteLine("||Deposit:"+deposit+"\t\t      ||");
        Console.WriteLine("||New Balance:"+balance+"\t      ||");
        Console.WriteLine("||============================||");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
public class Human{
     public virtual void Bal( ref double accountBalance,Display display,ref double transfer,ref string bsitPin)
    {
        Console.Clear();
        Console.WriteLine("         Inquire balance option selected     ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("||==========================================||");
        Console.WriteLine("||Your current balance is:"+accountBalance+"\t\t    ||");
        Console.WriteLine("||==========================================||");
        Console.WriteLine(" ");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
public class Hacker{
     public virtual void Withdraw(ref double accountBalance)
    {
        double withdraw;
        int con;
        Console.WriteLine("Withdraw option selected");
        Console.Write("Enter the amount to withdraw in: ");
        while (!double.TryParse(Console.ReadLine(), out withdraw))
        {
            Console.WriteLine("Error");
            Console.WriteLine("Enter the amount to withdraw: ");
        }

        if (withdraw <= accountBalance)
        {
            double newBalance = accountBalance - withdraw;
            accountBalance = newBalance;
            Console.WriteLine("Withdrawal successful. New balance: " + newBalance);
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("||===================================||");
        Console.WriteLine("||              RECIEPT              ||");
        Console.WriteLine("||===================================||");
        Console.WriteLine("||Transaction type: Withdraw         ||");
        Console.WriteLine("||                                   ||");
        Console.WriteLine("||Account Balance:"+accountBalance+"\t\t");
        Console.WriteLine("||                                   || ");
        Console.WriteLine("||Withdraw Amount:"+withdraw+"\t\t     ||");
        Console.WriteLine("||                                   ||");
        Console.WriteLine("||Remaining Balance:"+newBalance+"\t\t||");
        Console.WriteLine("||===================================||");
         Console.ForegroundColor = ConsoleColor.White;;
        Console.Write("Press any key to see a magic haha ");
        Console.ReadKey();
        Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Insufficient funds. Withdrawal failed.");
            Console.Write("Press 1 to continue: ");
            while (!int.TryParse(Console.ReadLine(), out con) || con == 1)
            {
                Console.Write("Press 1 to continue: ");
                if (con == 1)
                {
                    Withdraw(ref accountBalance);
                }
            }
        }
    }
    
}
public class News{
    public virtual void Others (Display display)
    {
        int choice, ikaw;
        do
        {
            Console.WriteLine(" ");
            Console.WriteLine("Estorco's ATM MACHINE Services!");
            Console.WriteLine("");
            Console.WriteLine("||===========================||");
            Console.WriteLine("||  1.Account Details        ||");
            Console.WriteLine("||  2.Change Pin             ||");
            Console.WriteLine("||  3.Payments               ||");
            Console.WriteLine("||===========================||");
            Console.Write("Enter your choice: ");
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("            Error             ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("||===========================||");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("||  1.Account Details        ||");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("||  2.Change Pin             ||");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("||  3.Payments               ||");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("||===========================||");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter your Choice: ");
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Hi Crush!");
                    Console.WriteLine("Your AccountName: " + display.EstorcoAccount);
                    Console.WriteLine("Your PIN: " + display.BsitPin);
                    break;
                case 2:
                    Console.WriteLine("Change a PIN");
                    do
                    {
                    Console.Write("Enter your current PIN: "); 
                     string  currentPin = "";
                    ConsoleKeyInfo key;
                  do
                   {
                     key = Console.ReadKey(true);

                     if (char.IsDigit(key.KeyChar) && currentPin.Length < 6)
                     {
                     Console.Write(key.KeyChar);
                     Thread.Sleep(100);
                     Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                     Console.Write("*");
                     currentPin += key.KeyChar;
                     }
                     else if (key.Key == ConsoleKey.Backspace && currentPin.Length > 0)
                     {
                       currentPin = currentPin.Substring(0, currentPin.Length - 1);
                        Console.Write("\b \b");
                     }
                     } while (key.Key != ConsoleKey.Enter);

                     Console.WriteLine();
                      
                       if (currentPin == display.BsitPin)
                        {
                             
                            string newPIN,confirmNewPin;  
                            
                            do{
                            Back: 
                            Console.Write("Enter your new PIN: ");
                            newPIN = "";
                            ConsoleKeyInfo newKey;
                            do
                            {
                                 newKey = Console.ReadKey(true);

                              if (char.IsDigit(newKey.KeyChar) && newPIN.Length < 6)
                               {
                                    Console.Write(newKey.KeyChar);
                                    Thread.Sleep(100);
                                    Console.SetCursorPosition(Console.CursorLeft -1, Console.CursorTop);
                                    Console.Write("*");
                                    newPIN += newKey.KeyChar;
                                }
                                else if (newKey.Key == ConsoleKey.Backspace && newPIN.Length > 0)
                                {
                                  newPIN = newPIN.Substring(0, newPIN.Length - 1);
                                  Console.Write("\b \b");
                                }
                                
                            } while (newKey.Key != ConsoleKey.Enter);
                              Console.WriteLine();
                              if(newPIN.Length <6){
                                Console.WriteLine("Error Pin must be 6 digits ok?");
                              }
                              if(newPIN == display.BsitPin){
                                Console.WriteLine("D PWEDE KAY SAME RAS IMONG DEFAULT PIN");
                                goto Back;
                              }
                            }while(newPIN.Length<6);
                            
                            Console.Write("Confirm your new PIN: ");
                            confirmNewPin = "";
                            ConsoleKeyInfo confirmKey;
                        
                           do
                           {
                              confirmKey = Console.ReadKey(true);

                             if (char.IsDigit(confirmKey.KeyChar) && confirmNewPin.Length < 6)
                              {
                              Console.Write(confirmKey.KeyChar);
                              Thread.Sleep(100);
                              Console.SetCursorPosition(Console.CursorLeft -1,Console.CursorTop);
                              Console.Write("*");
                               confirmNewPin += confirmKey.KeyChar;
                              }
                             else if (confirmKey.Key == ConsoleKey.Backspace && confirmNewPin.Length > 0)
                                {
                                 confirmNewPin = confirmNewPin.Substring(0, confirmNewPin.Length - 1);
                                 Console.Write("\b \b");
                                }
                           } while (confirmKey.Key != ConsoleKey.Enter);
                             Console.WriteLine();

                            if (newPIN == confirmNewPin)
                            {
                                int logout;
                                display.SetBsitPin(newPIN);
                                Console.WriteLine("Congrats! Your pin has successfully changed");
                                Console.WriteLine("Logout and Log in again to your new PIN");
                                Console.WriteLine("1.LOG OUT ");
                                Console.Write("Enter 1 to logout: ");
                                while (!int.TryParse(Console.ReadLine(), out logout) || logout < 1 || logout > 1)
                                {
                                    Console.WriteLine("Error");
                                    Console.Write("Enter 1 to logout: ");
                                }

                                switch (logout)
                                {
                                    case 1:
                                        int log;
                                        Console.WriteLine("LOG OUT SUCCESSFULLY HIHI");
                                        Console.WriteLine("HI CRUSH WELCOME BACK! Log in to your new PIN");
                                        Console.Write("Enter 1 to login: ");
                                        while (!int.TryParse(Console.ReadLine(), out log) || log < 1 || log > 1)
                                        {
                                            Console.WriteLine("Error");
                                            Console.Write("Enter 1 to login: ");
                                        }
                                        if (log == 1)
                                        {
                                            display.Sing();
                                        }
                                        break;
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Error! PINs do not match.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("INVALID PIN ");
                        }
                      if(string.IsNullOrEmpty(currentPin) || currentPin.Length < 6){
                       Console.WriteLine("Anga a oi! error..Pin must be 6 digits");
                    }  
                } while (true);
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Payments ");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

            Console.Write("Press 1 to continue and 0 to exit: ");
            while (!int.TryParse(Console.ReadLine(), out ikaw))
            {
                Console.WriteLine("Error");
                Console.Write("Press 1 to continue and 0 to exit: ");
                ikaw = int.Parse(Console.ReadLine()??"0");
            }
        } while (ikaw != 0);
        Console.WriteLine("exit");
    }
}

public class Method
{  
public void Fast(ref double accountBalance){
    int choce;
    double fastcash = 500.00;
    double money,honey;
    double addCash,depo;
    money = accountBalance - fastcash;
    Console.Clear();
    if(money>=500){
    Console.WriteLine("Fastcash successfully proccesed....");
    Console.WriteLine("Your accountBalance deducted by: 500.00");
    Console.WriteLine("");
    Console.WriteLine("||=================================||");
    Console.WriteLine("||            RECIEPT              ||");
    Console.WriteLine("||=================================||");
    Console.WriteLine("||Transaction type: Fastcash       ||");
    Console.WriteLine("||                                 || ");
    Console.WriteLine("||Account Balance:"+accountBalance+"\t\t   ||");
    Console.WriteLine("||                                 || ");
    Console.WriteLine("||Withdraw: 500.00                 ||");
    Console.WriteLine("||                                 ||");
    Console.WriteLine("||Remaining Balance:"+money+"\t\t   ||");
    Console.WriteLine("||=================================||");
    Console.WriteLine(" ");
    Console.WriteLine("Do you want to add more transaction by fastcash?");
    Console.WriteLine("Enter 1 to withdraw fastcash and 2 to deposit: ");
    Console.WriteLine("||==========================||");
    Console.WriteLine("||  1.FASTCASH   2.DEPOSIT  ||");
    Console.WriteLine("||==========================||");
    Console.Write("Enter: ");
    while(!int.TryParse(Console.ReadLine(),out choce)||choce<1||choce>2){
        Console.WriteLine("Anga oi..! sayup kas input bady");
        Console.Write("Enter: ");
    }
    switch(choce){
    case 1:
        addCash = money - fastcash;
        accountBalance=addCash;
    if(accountBalance >= addCash){
    Console.WriteLine("Balance is : "+ addCash);
    Console.WriteLine("");
    Console.WriteLine("||=================================||");
    Console.WriteLine("||            RECIEPT              ||");
    Console.WriteLine("||=================================||");
    Console.WriteLine("||Transaction type: Fastcash       ||");
    Console.WriteLine("||                                 || ");
    Console.WriteLine("||Account Balance:"+accountBalance+"\t\t   ||");
    Console.WriteLine("||                                 || ");
    Console.WriteLine("||Withdraw: 500.00                 ||");
    Console.WriteLine("||                                 ||");
    Console.WriteLine("||Remaining Balance:"+addCash+"\t\t   ||");
    Console.WriteLine("||=================================||");
    Console.WriteLine(" ");
     }
        else{
            
            Console.WriteLine("INSUFFICIENT BALANCE");
            
        }
        break;

        case 2:

        Console.WriteLine("Deposit selected ");
        Console.Write("Enter amount to deposit: ");
        while(!double.TryParse(Console.ReadLine(),out depo)){
            Console.WriteLine("Error");
            Console.WriteLine("Enter amount to deposit: ");  
        }
        honey = money + depo;
         accountBalance = honey;
        Console.WriteLine("Your current balance is: " +honey);

        break;
    }   
    }
    else{
        Console.WriteLine("Kulang");
    }
      
}
   
    public void Bank(ref double accountBalance,ref string bsitPin,Display display,ref double transfer){
        int imongBank;
        Console.Clear();
        Console.WriteLine("Choose a bank to tranfer your transaction");
        Console.WriteLine(" ");
        Console.WriteLine("||================================||");
        Console.WriteLine("||          BANKS' LIST           ||");
        Console.WriteLine("||================================||");
        Console.WriteLine("||1.BDO                2.BPI      ||");
        Console.WriteLine("||                                ||");
        Console.WriteLine("||3.Land Bank          4.Metrobank||");
        Console.WriteLine("||                                ||");
        Console.WriteLine("||        5.Security Bank         ||");
        Console.WriteLine("||================================||");
        Console.Write("Choose a Bank: ");
        while(!int.TryParse(Console.ReadLine(),out imongBank)||imongBank < 1||imongBank > 5){
            Console.WriteLine("Error");
            Console.Write("Choose a Bank: ");
        }
        switch(imongBank){
            case 1:
            
            string? Pin;
            int fire;
            Console.Clear();
            Console.ForegroundColor =ConsoleColor.Yellow;
            Console.WriteLine("                       ||============================|| ");
            Console.WriteLine("                       ||     BDO BANK TRANSACTION   || ");
            Console.WriteLine("                       ||============================|| ");
            Console.ForegroundColor =ConsoleColor.White;
            Bady:
            Console.Write("How much money you want tranfer>: ");
            while(!double.TryParse(Console.ReadLine(),out transfer)){
            Console.WriteLine("Error");
            Console.Write("How much money you want tranfer: ");
            }
            Console.WriteLine("your " + display.Transfer + " successfully transfer" );
           if(display.Transfer>accountBalance){
            Console.WriteLine("Insufficient balance");
            goto Bady;
           }

            backs:
            do{
            Console.Write("Enter your Pin: ");
            Thread.Sleep(250);
            Pin = "";
            Thread.Sleep(250);
            ConsoleKeyInfo key;
        
          do{
                 key = Console.ReadKey(true);

                if (char.IsDigit(key.KeyChar) && Pin.Length < 6)
                {
                    Console.Write(key.KeyChar);
                    Thread.Sleep(100);
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    Console.Write("*");
                    Pin += key.KeyChar;
                }
                else if (key.Key == ConsoleKey.Backspace && Pin.Length > 0)
                {
                    Pin =Pin.Substring(0, Pin.Length - 1);
                    Console.Write("\b \b");
                }
            } while (key.Key != ConsoleKey.Enter);
               Console.WriteLine();
           if(string.IsNullOrEmpty(Pin) || Pin.Length < 6){
            Console.WriteLine("Anga a oi! error..Pin must be 6 digits");
           }
        }while(string.IsNullOrEmpty(Pin) || Pin.Length < 6);
            if(Pin!=bsitPin){
             goto backs;
            }
            else{
            Console.WriteLine("=======================================");
            Console.WriteLine("1.Deposit          2.Inquire Balance   ");
            Console.WriteLine("                                       ");
            Console.WriteLine("3.Withdraw         4.Others Services   ");
            Console.WriteLine("                                       ");
            Console.WriteLine(" 6.Bank Tranfer      7.Roy's Bank      ");
            Console.WriteLine("                                       ");
            Console.WriteLine("=======================================");
            Console.Write("Enter your choice: ");    
            while(!int.TryParse(Console.ReadLine(),out fire)||fire<1||fire>7){
            Console.WriteLine("error");
            Console.Write("Enter your choice: ");
            }
            switch(fire){
            case 1:
             Dog ve = new Dog();
             ve.Depo(ref accountBalance,ref transfer);
            break;
            case 2:
             Boy laki = new Boy();
             laki.Bal(ref accountBalance,display,ref transfer,ref bsitPin);
            break;
            case 3:
            Girl baye = new Girl();
            baye.Withdraw(ref accountBalance);
            break;
            case 4: 
            Balita karon = new Balita();
            karon.Others(display);
            break;
            }
            }
            break;

            case 2:
            double puyo;
            Console.Clear();
            Console.ForegroundColor =ConsoleColor.Green;
            Console.WriteLine("                       ||============================|| ");
            Console.WriteLine("                       ||     BPI BANK TRANSACTION   || ");
            Console.WriteLine("                       ||============================|| ");
            Console.ForegroundColor =ConsoleColor.White;
            Console.Write("How much money you want tranfer>: ");
            while(!double.TryParse(Console.ReadLine(),out puyo)){
            Console.WriteLine("Error");
            Console.Write("How much money you want tranfer: ");
            }
            Console.WriteLine("your " + puyo + " successfully transfer!" );
            double ok = accountBalance - puyo;
            accountBalance = ok;
            display.Sing();
            break;

            case 3:
            double shesh;
            Console.Clear();
            Console.ForegroundColor =ConsoleColor.Magenta;
            Console.WriteLine("                       ||============================|| ");
            Console.WriteLine("                       ||     LANDBANK TRANSACTION   || ");
            Console.WriteLine("                       ||============================|| ");
            Console.Write("How much money you want tranfer>: ");
            while(!double.TryParse(Console.ReadLine(),out shesh)){
            Console.WriteLine("Error");
            Console.Write("How much money you want tranfer: ");
            }
            Console.WriteLine("your "+ shesh + " successfully transfer" );
            double love = accountBalance - shesh;
            accountBalance = love;
            display.Sing();
            break;

            case 4:
            double avatar;
            Console.Clear();
            Console.ForegroundColor =ConsoleColor.Cyan;
            Console.WriteLine("                       ||============================|| ");
            Console.WriteLine("                       ||     METROBANK TRANSACTION  || ");
            Console.WriteLine("                       ||============================|| ");
            Console.ForegroundColor =ConsoleColor.Blue;
            Console.Write("How much money you want tranfer>: ");
            while(!double.TryParse(Console.ReadLine(),out avatar)){
            Console.WriteLine("Error");
            Console.Write("How much money you want tranfer: ");
            }
            Console.WriteLine("your " + avatar + " successfully transfer" );
            double huhu = accountBalance - avatar;
            accountBalance = huhu;
            display.Sing();
            break;

            case 5:
            
            double saging;
            Console.Clear();
            Console.ForegroundColor =ConsoleColor.Cyan;
            Console.WriteLine("                       ||===============================||");
            Console.WriteLine("                       ||     SECURITYBANK TRANSACTION  ||");
            Console.WriteLine("                       ||===============================||");
            Console.ForegroundColor =ConsoleColor.Blue;
            Console.Write("How much money you want tranfer>: ");
            while(!double.TryParse(Console.ReadLine(),out saging)){
            Console.WriteLine("Error");
            Console.Write("How much money you want tranfer: ");
            }
            Console.WriteLine("your " + saging + " successfully transfer!" );
            double banana = accountBalance - saging;
            accountBalance = banana;
            display.Sing();
            break;
        }

    }




    class Dog: Animal{
        public override void Depo( ref double accountBalance,ref double transfer){
         double deposit;
        Console.WriteLine("Deposit option selected");
        Console.Write("Enter the amount to deposit: ");

        while (!double.TryParse(Console.ReadLine(), out deposit) || deposit < 1)
        {
            Console.WriteLine("Error");
            Console.Write("Enter the amount to deposit: ");
        }

        double bit = transfer + deposit;
        accountBalance = bit;
        Console.WriteLine("Deposited Amount of: " + deposit);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("||============================||");
        Console.WriteLine("||          RECEIPT           ||");
        Console.WriteLine("||============================||");
        Console.WriteLine("||Transaction type: Deposit   ||");
        Console.WriteLine("||                            ||");
        Console.WriteLine("||Account Balance:"+accountBalance +  "||");
        Console.WriteLine("||Deposit:"+deposit+"\t\t      ||");
        Console.WriteLine("||New Balance:"+bit+"\t      ||");
        Console.WriteLine("||============================||");
        Console.ForegroundColor = ConsoleColor.White;
        }
        
    }
    class Boy: Human{
      public override void Bal( ref double accountBalance,Display display,ref double transfer,ref string bsitPin)
    {
         int ga;
        Console.Clear();

        Console.WriteLine("         Inquire balance option selected     ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("||==========================================||");
        Console.WriteLine("||Your current balance is:"+transfer+"\t\t    ||");
        Console.WriteLine("||==========================================||");
        Console.WriteLine(" ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Options");
        Console.WriteLine("1.roys bank");
        Console.WriteLine("2.continue");
        Console.WriteLine();
        Console.Write("Enter: ");
        while(!int.TryParse(Console.ReadLine(),out ga)||ga<1||ga>2){
        Console.WriteLine("error");
        Console.WriteLine("Enter: ");
        }
        if(ga==1){
        string? uhaw;
        d:
        Console.WriteLine("Enter your pin: ");
        uhaw = Console.ReadLine()??"0";
        if(uhaw != bsitPin){
            Console.WriteLine("Error");
            goto d;
        } 
        }
         else if(ga ==2 ){
              int pick;
                Console.WriteLine("||===============================================||");
                Console.WriteLine("||  1. Deposit               2. Inquire balance  ||");
                Console.WriteLine("||                                               ||");
                Console.WriteLine("||  3. Withdraw              4. Others Services  ||");
                Console.WriteLine("||                                               ||");
                Console.WriteLine("||  5. Fastcash              6. Bank Transfer    ||");
                Console.WriteLine("||===============================================||");
                Console.WriteLine("Enter your choice: ");
                while(!int.TryParse(Console.ReadLine(),out pick)){
                    Console.WriteLine("error");
                    Console.Write("Enter your choice: ");
                }
                switch(pick){
                    case 1: 
                    break;
                    case 2:
                     Console.WriteLine("remaining balnce is "+ transfer);
                    break;
                    case 3:
                    break;
                    case 4:
                    break;

                }
        }    
        else{
            int atay;
            
          Console.WriteLine("             Please select an option               ");
                Console.WriteLine("||===============================================||");
                Console.WriteLine("||  1. Deposit               2. Inquire balance  ||");
                Console.WriteLine("||                                               ||");
                Console.WriteLine("||  3. Withdraw              4. Others Services  ||");
                Console.WriteLine("||                                               ||");
                Console.WriteLine("||  5. Fastcash              6. Bank Transfer    ||");
                Console.WriteLine("||===============================================||");
                Console.WriteLine("Enter your choice: ");
                while(!int.TryParse(Console.ReadLine(),out atay)||atay<1||atay>6){
                 Console.WriteLine("Error");              
                }
                switch(atay){
                    case 1:
                    
                    break;
                    case 2:{
                     double ac = accountBalance - transfer;
                     accountBalance = ac;
                     Console.WriteLine("remaining balnce is "+ accountBalance);
                    }
                    break;
                    case 3:
                    Console.Write(" ");
                    break;
                    case 4:
                    break;
                    case 5:
                    break;
                    case 6:
                    break;
                }
           }
        
       
    }
    }
    class Girl:Hacker{
        public override void Withdraw(ref double accountBalance)
        {
         double withdraw;
        int con;
        Console.WriteLine("Withdraw option selected");
        Console.Write("Enter the amount to withdraw in: ");
        while (!double.TryParse(Console.ReadLine(), out withdraw))
        {
            Console.WriteLine("Error");
            Console.WriteLine("Enter the amount to withdraw: ");
        }

        if (withdraw <= accountBalance)
        {
            double newBalance = accountBalance - withdraw;
            accountBalance = newBalance;
            Console.WriteLine("Withdrawal successful. New balance: " + newBalance);
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("||===================================||");
        Console.WriteLine("||              RECIEPT              ||");
        Console.WriteLine("||===================================||");
        Console.WriteLine("||Transaction type: Withdraw         ||");
        Console.WriteLine("||                                   ||");
        Console.WriteLine("||Account Balance:"+accountBalance+"\t\t");
        Console.WriteLine("||                                   || ");
        Console.WriteLine("||Withdraw Amount:"+withdraw+"\t\t     ||");
        Console.WriteLine("||                                   ||");
        Console.WriteLine("||Remaining Balance:"+newBalance+"\t\t||");
        Console.WriteLine("||===================================||");
         Console.ForegroundColor = ConsoleColor.White;;
        Console.Write("Press any key to see a magic haha ");
        Console.ReadKey();
        Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Insufficient funds. Withdrawal failed.");
            Console.Write("Press 1 to continue: ");
            while (!int.TryParse(Console.ReadLine(), out con) || con == 1)
            {
                Console.Write("Press 1 to continue: ");
                if (con == 1)
                {
                    Withdraw(ref accountBalance);
                }
            }
        }
        }
    }
    class Balita: News{
        public override void Others (Display display)
    {
        int choice, ikaw;
        do
        {
            Console.WriteLine(" ");
            Console.WriteLine("Estorco's ATM MACHINE Services!");
            Console.WriteLine("");
            Console.WriteLine("||===========================||");
            Console.WriteLine("||  1.Account Details        ||");
            Console.WriteLine("||  2.Change Pin             ||");
            Console.WriteLine("||  3.Payments               ||");
            Console.WriteLine("||===========================||");
            Console.Write("Enter your choice: ");
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("            Error             ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("||===========================||");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("||  1.Account Details        ||");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("||  2.Change Pin             ||");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("||  3.Payments               ||");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("||===========================||");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Enter your Choice: ");
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Hi Crush!");
                    Console.WriteLine("Your AccountName: " + display.EstorcoAccount);
                    Console.WriteLine("Your PIN: " + display.BsitPin);
                    break;
                case 2:
                    Console.WriteLine("Change a PIN");
                    do
                    {
                    Console.Write("Enter your current PIN: "); 
                     string  currentPin = "";
                    ConsoleKeyInfo key;
                  do
                   {
                     key = Console.ReadKey(true);

                     if (char.IsDigit(key.KeyChar) && currentPin.Length < 6)
                     {
                     Console.Write(key.KeyChar);
                     Thread.Sleep(100);
                     Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                     Console.Write("*");
                     currentPin += key.KeyChar;
                     }
                     else if (key.Key == ConsoleKey.Backspace && currentPin.Length > 0)
                     {
                       currentPin = currentPin.Substring(0, currentPin.Length - 1);
                        Console.Write("\b \b");
                     }
                    } while (key.Key != ConsoleKey.Enter);

                    Console.WriteLine();
                      
                       if (currentPin == display.BsitPin)
                        {
                             
                            string newPIN,confirmNewPin;  
                            
                            do{
                            Back: 
                            Console.Write("Enter your new PIN: ");
                            newPIN = "";
                            ConsoleKeyInfo newKey;
                            do
                            {
                                 newKey = Console.ReadKey(true);

                              if (char.IsDigit(newKey.KeyChar) && newPIN.Length < 6)
                               {
                                    Console.Write(newKey.KeyChar);
                                    Thread.Sleep(100);
                                    Console.SetCursorPosition(Console.CursorLeft -1, Console.CursorTop);
                                    Console.Write("*");
                                    newPIN += newKey.KeyChar;
                                }
                                else if (newKey.Key == ConsoleKey.Backspace && newPIN.Length > 0)
                                {
                                  newPIN = newPIN.Substring(0, newPIN.Length - 1);
                                  Console.Write("\b \b");
                                }
                                
                            } while (newKey.Key != ConsoleKey.Enter);
                              Console.WriteLine();
                              if(newPIN.Length <6){
                                Console.WriteLine("Error Pin must be 6 digits ok?");
                              }
                              if(newPIN == display.BsitPin){
                                Console.WriteLine("D PWEDE KAY SAME RAS IMONG DEFAULT PIN");
                                goto Back;
                              }
                            }while(newPIN.Length<6);
                            
                            Console.Write("Confirm your new PIN: ");
                            confirmNewPin = "";
                            ConsoleKeyInfo confirmKey;
                        
                           do
                           {
                              confirmKey = Console.ReadKey(true);

                             if (char.IsDigit(confirmKey.KeyChar) && confirmNewPin.Length < 6)
                              {
                              Console.Write(confirmKey.KeyChar);
                              Thread.Sleep(100);
                              Console.SetCursorPosition(Console.CursorLeft -1,Console.CursorTop);
                              Console.Write("*");
                               confirmNewPin += confirmKey.KeyChar;
                              }
                             else if (confirmKey.Key == ConsoleKey.Backspace && confirmNewPin.Length > 0)
                                {
                                 confirmNewPin = confirmNewPin.Substring(0, confirmNewPin.Length - 1);
                                 Console.Write("\b \b");
                                }
                           } while (confirmKey.Key != ConsoleKey.Enter);
                             Console.WriteLine();

                            if (newPIN == confirmNewPin)
                            {
                                int logout;
                                display.SetBsitPin(newPIN);
                                Console.WriteLine("Congrats! Your pin has successfully changed");
                                Console.WriteLine("Logout and Log in again to your new PIN");
                                Console.WriteLine("1.LOG OUT ");
                                Console.Write("Enter 1 to logout: ");
                                while (!int.TryParse(Console.ReadLine(), out logout) || logout < 1 || logout > 1)
                                {
                                    Console.WriteLine("Error");
                                    Console.Write("Enter 1 to logout: ");
                                }

                                switch (logout)
                                {
                                    case 1:
                                        int log;
                                        Console.WriteLine("LOG OUT SUCCESSFULLY HIHI");
                                        Console.WriteLine("HI CRUSH WELCOME BACK! Log in to your new PIN");
                                        Console.Write("Enter 1 to login: ");
                                        while (!int.TryParse(Console.ReadLine(), out log) || log < 1 || log > 1)
                                        {
                                            Console.WriteLine("Error");
                                            Console.Write("Enter 1 to login: ");
                                        }
                                        if (log == 1)
                                        {
                                            display.Sing();
                                        }
                                        break;
                                }
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Error! PINs do not match.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("INVALID PIN ");
                        }
                      if(string.IsNullOrEmpty(currentPin) || currentPin.Length < 6){
                       Console.WriteLine("Anga a oi! error..Pin must be 6 digits");
           }  
                    } while (true);
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Payments ");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

            Console.Write("Press 1 to continue and 0 to exit: ");
            while (!int.TryParse(Console.ReadLine(), out ikaw))
            {
                Console.WriteLine("Error");
                Console.Write("Press 1 to continue and 0 to exit: ");
                ikaw = int.Parse(Console.ReadLine()??"0");
            }
        } while (ikaw != 0);
        Console.WriteLine("exit");
    }
    }

   
 }

