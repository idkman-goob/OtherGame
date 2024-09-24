namespace OtherGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1 = dealer attacks, 2 = he blocks, 3 = he parries
            string answer;
            int Gameongoing = 0;
            int dealerhealth = 100;
            int playerhealth = 100;
            while (Gameongoing == 0)
            {

                if (playerhealth > 0 && dealerhealth > 0)
                {
                    Console.WriteLine("Player attack, block or parry?");
                    Console.WriteLine("Player health:" + playerhealth);
                    Console.WriteLine("Dealer health:" + dealerhealth);

                    answer = Console.ReadLine();
                    if (answer == "block")
                    {
                        Random deal = new Random();
                        int dealchooser = deal.Next(1, 4);
                        if (dealchooser == 1)
                        {
                            Console.WriteLine("Dealer attacks while you are blocking dealing 5 hp");
                            playerhealth -= 5;
                        }
                        else if (dealchooser == 2)
                        {
                            Console.WriteLine("You both block and nothing happens");
                        }
                        else if (dealchooser == 3)
                        {
                            Console.WriteLine("Dealer tries parrying while you block he loses 10 hp");
                            dealerhealth -= 10;

                        }


                    }
                    else if (answer == "attack")
                    {


                        Random deal = new Random();
                        int dealchooser = deal.Next(1, 4);
                        if (dealchooser == 1)
                        {
                            Random attack = new Random();
                            int attacker = attack.Next(1, 3);
                            if (attacker == 1)
                            {
                                Console.WriteLine("You manage to attack first dealing 5 hp on the dealer");
                                dealerhealth -= 5;
                            }
                            else if (attacker == 2)
                            {
                                Console.WriteLine("He attacks first making you lose 5 hp");
                                playerhealth -= 5;

                            }
                        }
                        else if (dealchooser == 2)
                        {
                            Console.WriteLine("He blocks your attack but you deal 5 hp to him");
                            dealerhealth -= 5;
                        }
                        else if (dealchooser == 3)
                        {
                            Random parry = new Random();
                            int parrychance = parry.Next(1, 7);
                            if (parrychance >= 3)
                            {
                                Console.WriteLine("He correctly parries your attack dealing 15 hp to you");
                                playerhealth -= 15;
                            }
                            else
                            {
                                Console.WriteLine("He fails to parry your attack and he loses 10 hp");
                                dealerhealth -= 10;
                            }
                        }
                    }
                    else if (answer == "parry")
                    {
                        Random deal = new Random();
                        int dealchooser = deal.Next(1, 4);
                        if (dealchooser == 1)
                        {
                            Random parryplayer = new Random();
                            int parrytiming = parryplayer.Next(1, 3);
                            Console.WriteLine("He attacks get ready to time your parry!");
                            Console.WriteLine("In how many milliseconds will you parry?");
                            Console.WriteLine("Its between 1-6 milliseconds");
                            string goofygoober = Console.ReadLine();
                            if (parrytiming == 1)
                            {
                                Console.WriteLine("You parried the dealer hitting him for 15 damage");
                                dealerhealth -= 15;
                            }
                            else if (parrytiming == 2)
                            {
                                Console.WriteLine("You failed to parry him losing 10 hp");
                                playerhealth -= 10;
                            }
                        }
                        else if (dealchooser == 2)
                        {
                            Console.WriteLine("He blocks while you parry for a attack you lose 10 hp");
                            playerhealth -= 10;
                        }
                        else if (dealchooser == 3)
                        {
                            Console.WriteLine("You both try parrying resulting in a loss of 5 hp for both");
                            dealerhealth -= 5;
                            playerhealth -= 5;
                        }

                    }
                    else if (answer == "developer_mode")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("what would you like to do?");
                        Console.WriteLine("Kill dealer = 1");
                        Console.WriteLine("Kill player = 2");
                        Console.WriteLine("Set both bars to zero = 3");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        int svar2 = int.Parse(Console.ReadLine());
                        if (svar2 == 1)
                        {
                            dealerhealth = 0;
                            Console.WriteLine("{killed dealer}");
                        }
                        else if (svar2 == 2)
                        {
                            playerhealth = 0;
                            Console.WriteLine("{Killed player}");
                        }
                        else if (svar2 == 3)
                        {
                            playerhealth = 0;
                            dealerhealth = 0;
                            Console.WriteLine("{Killed player}");
                            Console.WriteLine("{killed dealer}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("That is not a viable option");
                        Console.WriteLine("");
                    }

                }
                else
                {
                    Gameongoing = 1;
                }


            }
            if (playerhealth > dealerhealth)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("You won!");
                Console.WriteLine("With " + playerhealth + " hp left");

            }
            else if (dealerhealth > playerhealth)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("You lost");
                if (dealerhealth >= 80)
                {
                    Console.WriteLine("Damn did you even hit him once? You a loser fr");
                }
                else if (dealerhealth < 80)
                {
                    Console.WriteLine("He only had " + dealerhealth + " hp left!");
                }

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Something went wrong?");
            }

        }
    }
}

