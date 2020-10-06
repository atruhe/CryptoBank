using System;

namespace CryptoBank
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            do
            { //start 
                decimal userCash = 5000m, userBitcoin = 0m, userEtherium = 0m, userLitecoin = 0m;
                decimal userAcctValue = userCash + userBitcoin + userEtherium + userLitecoin;

                decimal bitcoin = 7480m;
                decimal etherium = 586.15m;
                decimal litecoin = 119.04m;

                Console.WriteLine("Welcome to the currency market.");
                Console.WriteLine("Please pick one of the following options:\nP)urchase\nS)ell\nV)iew Balances\nT)ransfer currency\nE)xit");
                ConsoleKey userChoice = Console.ReadKey(true).Key;

                switch (userChoice)
                {
                    case ConsoleKey.P:
                        Console.WriteLine("Which currency would you like to purchase?\nB)itcoin\nE)therium\nL)itecoin\nE)xit");
                        ConsoleKey currencyChoice = Console.ReadKey(true).Key;
                        switch (currencyChoice)
                        {
                            case ConsoleKey.B:
                                Console.WriteLine("How many would you like to purchase?");
                                decimal bitcoinPurchase = Convert.ToDecimal(Console.ReadLine());
                                decimal bitcoinPurchaseValue = (bitcoinPurchase * bitcoin);

                                if (userCash >= bitcoinPurchaseValue)
                                {
                                    userCash = userCash - bitcoinPurchaseValue;
                                    userBitcoin = userBitcoin + bitcoinPurchaseValue;
                                    Console.WriteLine($"Current Cash: {userCash:c}\nCurrent Bitcoin: {userBitcoin/bitcoin}\nBitcoin Value: {userBitcoin:c}\n");

                                    Console.WriteLine("Make another transaction? Y/N\n");
                                    ConsoleKey userContB = Console.ReadKey(true).Key;
                                    switch (userContB)
                                    {
                                        case ConsoleKey.Y:
                                            break;
                                        case ConsoleKey.N:
                                            exit = false;
                                            break;
                                    }//end Transaction
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Insufficient Funds\n");
                                }
                                break;
                            case ConsoleKey.E:
                                Console.WriteLine("How many would you like to purchase?");
                                decimal etheriumPurchase = Convert.ToDecimal(Console.ReadLine());
                                decimal etheriumPurchaseValue = (etheriumPurchase * etherium);

                                if (userCash >= etheriumPurchaseValue)
                                {
                                    userCash = userCash - etheriumPurchaseValue;
                                    userEtherium = userEtherium + etheriumPurchaseValue;
                                    Console.WriteLine($"Current Cash: {userCash}\nEtherium: {userEtherium/etherium}\nCurrent Etherium Value: {userEtherium:c}\n");

                                    Console.WriteLine("Make another transaction? Y/N\n");
                                    ConsoleKey userContB = Console.ReadKey(true).Key;
                                    switch (userContB)
                                    {
                                        case ConsoleKey.Y:
                                            break;
                                        case ConsoleKey.N:
                                            exit = false;
                                            break;
                                    }//end Transaction
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Insufficient Funds\n");
                                }

                                break;
                                //end Etherium
                            case ConsoleKey.L:
                                Console.WriteLine("How many would you like to purchase?");
                                decimal litecoinPurchase = Convert.ToDecimal(Console.ReadLine());
                                decimal litecoinPurchaseValue = (litecoinPurchase * litecoin);

                                if (userCash >= litecoinPurchaseValue)
                                {
                                    userCash = userCash - litecoinPurchaseValue;
                                    userLitecoin = userLitecoin + litecoinPurchaseValue;
                                    Console.WriteLine($"Current Cash: {userCash}\nCurrent Litecoin: {userLitecoin/litecoin}\nCurrent Litecoin Value: {userLitecoin:C}\n");

                                    Console.WriteLine("Make another transaction? Y/N\n");
                                    ConsoleKey userContB = Console.ReadKey(true).Key;
                                    switch (userContB)
                                    {
                                        case ConsoleKey.Y:
                                            break;
                                        case ConsoleKey.N:
                                            exit = false;
                                            break;
                                    }//end Transaction
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Insufficient Funds\n");
                                }
                                break;
                        }
                        break;
                        //end Litecoin
                    case ConsoleKey.S:
                        break;
                    case ConsoleKey.V:
                        break;
                    case ConsoleKey.T:
                        break;
                    case ConsoleKey.E:
                        exit = true;
                        break;
                }

            } while (exit != true);
        }
    }
}
