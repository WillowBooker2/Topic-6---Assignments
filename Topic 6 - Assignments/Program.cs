using _5._5___More_classes;
using System;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace Topic_6___Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            while (choice != "q")
            {
                Console.Clear(); 
                Console.WriteLine("Welcome to my generic menu.  Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Menu Option 1");
                Console.WriteLine("2 - Menu Option 2");
                Console.WriteLine("3 - Menu Option 3");
                Console.WriteLine("4 - Menu Option 4");
                Console.WriteLine("5 - Menu Option 5");
                Console.WriteLine("...");
                Console.WriteLine("x - Menu Option x");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1")
                {
                   
                    Console.WriteLine("You chose option 1");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    Prompter();
                }
                else if (choice == "2")
                {

                    Console.WriteLine("You chose option 2");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    PercentPassing();
                }

                else if (choice == "3")
                {
                    
                    Console.WriteLine("You chose option 3");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    OddSum();
                }

                else if (choice == "4")
                {
                   
                    Console.WriteLine("You chose option 4");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    RandomNumber();
                }

                else if (choice == "5")
                {

                    Console.WriteLine("You chose option 5");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    DiceGame();
                }

                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                }
            }

            static void Prompter()
            {
                Console.WriteLine("Hello, please give me a minimum value.");
                int minimum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Okay, now please give me a maximum value.");
                int maximum = Convert.ToInt32(Console.ReadLine());
                while (minimum > maximum) 
                {
                 Console.Write("Invalid input, try again.");
                    Console.WriteLine("");
                   maximum = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Now please give a number in between those two.");
                int numb = Convert.ToInt32(Console.ReadLine());
                while (numb > maximum || numb < minimum) 
                {
                    Console.WriteLine("Invalid input, try again.");
                    numb = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine($"The numbers you have chosen are {minimum} for your minimum, {maximum} for your maximum, and {numb} for your number in between."); 
                Console.WriteLine("Thank you very much.");
                Thread.Sleep(100);
                Console.WriteLine("Press ENTER to continue.");
                Console.ReadLine();
            }

            static void PercentPassing() 
            {
                bool done = false;
                Console.WriteLine("Hello there teacher, it seems as if another test has been completed by your class.");
                
                int studentNum = 0;
                while (!done)





                {
                    studentNum++;
                int above70 = 0;
                    int below70 = 0;
                    
                Console.WriteLine($"This is student {studentNum}, please tell me their grade.");
                    double grade;
                    while (!Double.TryParse(Console.ReadLine(), out grade) || grade < 0 || grade > 100)
                    {
                        Console.WriteLine("Please give me a valid response.");
                    }
                    
                    if (grade >= 70)
                    {
                        above70++;
                    }
                    else if (grade < 70)
                    {
                        below70++;
                    }

                    Console.WriteLine($"So student {studentNum} had a grade of {grade}. I see.");

                    Console.WriteLine("Would you like to input another grade?");
                    string going = Console.ReadLine().ToUpper().Trim();

                    while (going != "YES" && going != "NO")
                    {
                        Console.WriteLine("Please give me a valid response.");
                        going = Console.ReadLine().ToUpper().Trim();


                    }
                    if (going == "YES")
                    {
                        Console.WriteLine("Okay, here we go again.");
                    }
                    else if (going == "NO")
                    {
                        done = true;
                        Console.WriteLine("Okay, thank you for using this program.");
                        Console.WriteLine($"Out of all {studentNum} grades, {above70} were above or equalled 70, while {below70} were below 70.");
                        Console.WriteLine($"With this information, {Math.Round((double)(above70 / studentNum * 100), 2)}% of the class was above or equal to 70.");
                        Console.WriteLine("Press ENTER to continue.");
                        Console.ReadLine();
                    }
                }



            }

            static void OddSum()
            {
                int num, total;
                total = 0;
                
                Console.WriteLine("Hello, welcome to the odd sum program!");
                Console.WriteLine("Please, give me an odd sum, I collect the sum of every odd number, starting at 1, and ending in the odd number you chose.");
                

                while (!Int32.TryParse(Console.ReadLine(), out num) || num < 1 )
                { 
                 Console.WriteLine("Please inpuit a valid number.");
                }

                Console.WriteLine("Okay, I will begin counting now.");
                for (int i = 1; i <= num; i += 2)
                    
                {
                    total += i;
                    Console.WriteLine(i);
                    Thread.Sleep(250);
                    
                }

                Console.WriteLine("All done.");
                Console.WriteLine($"Your sum is {total}. Come again.");
                Console.WriteLine("Press ENTER to continue.");
                Console.ReadLine();
            }

            static void RandomNumber() 
            {
                int min, max, numb;
                Random generator = new Random();
                Console.WriteLine("Hello. You will give me a maximum value and a minimum value, and in return,");
                Console.WriteLine("I will, generate 25 random numbers. Now, please give ma a maximum value.");
                while (!Int32.TryParse(Console.ReadLine(), out max))
                {
                    Console.WriteLine("Please inpuit a valid number.");
                }
                Console.WriteLine("Great, now please give me a minimum value.");
                while (!Int32.TryParse(Console.ReadLine(), out min) || min > max)
                {
                    Console.WriteLine("Please inpuit a valid number.");
                }
                Console.Write("Cool, now watch as I generate 25 random numbers.");
                for (int i = 0; i <= 25; i ++)

                {
                    numb = generator.Next(min, max);
                    Console.WriteLine(numb);
                    Thread.Sleep(250);

                }
                Console.WriteLine("Okay, those are the numbers I generated. Thank you for your time.");
                Console.WriteLine("Press ENTER to continue.");
                Console.ReadLine() ;
            }

            static void DiceGame() 
            {
                
                double bet;
                double total;
                double money = 100;
                bool done = false;
                Random coinFlip = new Random();
                int flip;
                double results;
                Die die1 = new Die();
                Die die2 = new Die();
                Console.WriteLine("Hello, care to play a little game?");
                Thread.Sleep(200);
                Console.WriteLine("You'll make a bet, and win money back if you guess correctly.");
                Thread.Sleep(200);
                Console.WriteLine("If you say 'Doubles', and the dice roll the same number, you'll gain double your bet.");
                Thread.Sleep(200);
                Console.WriteLine("If you say 'Not double', amd the die roll different numbers, you'll gain half yuour bet.");
                Thread.Sleep(200);
                Console.WriteLine("If you say 'Even sum', and the sum of the die roll is even you'll win your bet.");
                Thread.Sleep(200);
                Console.WriteLine("If you say 'Odd sum', and the sum of the die is even, you'll also win your bet. Now, let's play");
                Thread.Sleep(200);
                
                while (!done)
                {
                    Console.WriteLine("What option will you pick?");
                    Thread.Sleep(200);
                    string choice = Convert.ToString(Console.ReadLine().ToUpper());
                    while (choice != "DOUBLES" && choice != "NOT DOUBLES" && choice != "NOT" && choice != "EVEN SUM" && choice != "ODD SUM")
                    {
                        Console.WriteLine("Please give a valid response.");
                        choice = Console.ReadLine().ToUpper();
                    }

                    if (choice == "DOUBLES")
                    {
                        Console.WriteLine("You are rolling for doubles.");

                    }

                    else if (choice == "NOT DOUBLE" || choice == "NOT")
                    {
                        Console.WriteLine("You are rolling for NOT doubles.");
                    }

                    else if (choice == "EVEN")
                    {
                        Console.WriteLine("You are rolling for an even sum.");
                    }

                    else if (choice == "ODD")
                    {
                        Console.WriteLine("You are rolling for an odd sum.");
                    }

                    if (money <= 0)
                    {
                        done = true;
                        Console.WriteLine("It seems you have ran out of money, you can no longer play. Goodbye.");
                        
                        Console.ReadLine();
                    }

                    Console.WriteLine($"How much are you betting for this round? You have ${money} left.");
                    bet = Convert.ToDouble(Console.ReadLine());
                    while (bet < 0)
                    {
                        Console.WriteLine("Invalid bet, please bet again");
                        Console.ReadLine();
                    }
                    if (bet < 0 && bet > money)
                    {
                        Console.WriteLine($"You are betting {bet.ToString("C")}. May the odds be in your favour, good luck.");
                    }

                    else if (bet > money)
                    {
                        bet = money;
                        Console.WriteLine($"I'll just assume you're betting all of your money, and are specifically betting {money.ToString("C")}");
                    }
                    Thread.Sleep(500);
                    Console.WriteLine("Rolling...");
                    Thread.Sleep(500);

                    die1.RollDice();
                    die1.DrawDie();
                    die2.RollDice();
                    die2.DrawDie();


                    if (choice == "DOUBLES")
                    {
                        total = bet;

                        if (die1.Roll == die2.Roll)
                        {
                            total = bet * 2;
                            money = money + total;
                            Console.WriteLine($"Hey look at that, you won! You earned {total.ToString("C")}.");
                        }

                        else if (die1.Roll != die2.Roll)
                        {
                            money = money - total;
                            Console.WriteLine($"Oh no! You lost! You lost {total.ToString("C")}!");
                        }

                    }

                    else if (choice == "NOT DOUBLES" || choice == "NOT")
                    {
                        total = bet;

                        if (die1.Roll != die2.Roll)
                        {
                            total = bet / 2;
                            money = money + total;
                            Console.WriteLine($"Hey look at that, you won! You earned {total.ToString("C")}.");
                        }

                        else if (die1.Roll == die2.Roll)
                        {
                            money = money - total;
                            Console.WriteLine($"Oh no! You lost! You lost {total.ToString("C")}!");
                        }
                    }

                    else if (choice == "EVEN")
                    {
                        total = bet;
                        money = money + total;
                        int rollTotal = die1.Roll + die2.Roll;
                        if (rollTotal == 2 || rollTotal == 4 || rollTotal == 6 || rollTotal == 8 || rollTotal == 10 || rollTotal == 12)
                        {
                            Console.WriteLine($"Hey look at that, you won! You earned {total.ToString("C")}.");
                        }
                        else if (rollTotal == 1 || rollTotal == 3 || rollTotal == 5 || rollTotal == 7 || rollTotal == 9 || rollTotal == 11)
                        {
                            Console.WriteLine($"Oh no! You lost! You lost {total.ToString("C")}!");
                        }

                    }

                    else if (choice == "ODD")
                    {
                        total = bet;
                        money = money + total;
                        int rollTotal = die1.Roll + die2.Roll;
                        if (rollTotal == 1 || rollTotal == 3 || rollTotal == 5 || rollTotal == 7 || rollTotal == 9 || rollTotal == 11)
                        {
                            Console.WriteLine($"Hey look at that, you won! You earned {total.ToString("C")}.");
                        }

                        else if (rollTotal == 2 || rollTotal == 4 || rollTotal == 6 || rollTotal == 8 || rollTotal == 10 || rollTotal == 12)
                        {
                            Console.WriteLine($"Oh no! You lost! You lost {total.ToString("C")}!");
                        }


                    }


                    Console.WriteLine("Would you like roll again?");
                    string going = Console.ReadLine().ToUpper().Trim();

                    while (going != "YES" && going != "NO")
                    {
                        Console.WriteLine("Please give me a valid response.");
                        going = Console.ReadLine().ToUpper().Trim();


                    }
                    if (going == "YES")
                    {
                        Console.WriteLine("Okay, here we go again.");
                    }
                    else if (going == "NO")
                    {
                        done = true;
                        Console.WriteLine("Okay, thank you for using this program.");
                        Console.WriteLine("Press ENTER to continue.");
                        Console.ReadLine();
                    }
                }



                



                

                
            }

        }
    }
}