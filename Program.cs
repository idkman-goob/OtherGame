using System.ComponentModel.Design;
using System.Data.Common;

namespace OtherGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //V.4: Balance changes, damage increases when you block with the wheel equipped, added unequip feature, you can now adapt as sukuna
            //1 = dealer attacks, 2 = he blocks, 3 = he parries, 4 = dodge
            int LCV = 0;
            int adaptation = 0;
            int adaptpoints = 0;
            int mahoraga = 0;
            int sukuna = 0;
            int blackflash = 0;
            int stungun = 0;
            int immortality = 0;
            string inv1 = "nothing";
            string inv2 = "nothing";
            string inv3 = "nothing";
            string inv4 = "nothing";
            string inv5 = "nothing";
            int inventory = 5;
            string answer;
            int Gameongoing = 0;
            int dealerhealth = 100;
            int playerhealth = 100;
            for (int g = 0; g < 100; g++)
            {
                if (playerhealth <= 0)
                {
                    Gameongoing = 1;
                    LCV = 1;
                }
                else if (playerhealth != 0)
                {


                    Console.WriteLine("");
                    Console.WriteLine("Round:" + g);
                    inventory = 5;
                    Gameongoing = 0;
                    dealerhealth = 100;
                    playerhealth = 100;
                    int truhp = g * 10;
                    dealerhealth += truhp;
                }
                while (Gameongoing == 0)
                {

                    if (playerhealth > 0 && dealerhealth > 0)
                    {
                        if (playerhealth > 100)
                        {
                            playerhealth = 100;
                        }
                        if (adaptpoints == 3)
                        {
                            if (adaptation <= 6)
                            {
                                adaptation += 2;
                                if (adaptation == 6)
                                {
                                    Console.WriteLine("---The wheel turns as you adapt to the Dealer---");
                                    Console.WriteLine("");
                                    Console.WriteLine("[Your adaptation level is now " + adaptation + "]");
                                    adaptpoints = 0;
                                }else if (adaptation > 6)
                                {
                                    adaptation = 6;
                                    Console.WriteLine("");
                                    Console.WriteLine("[Your adapation level is now maxed!]");
                                    Console.WriteLine("");
                                    adaptpoints = 0;
                                }
                                
                            }
                           
                        }

                        if (immortality > 0)
                        {
                            playerhealth = 100;
                            Console.WriteLine("Your immortality heals you!");
                            immortality -= 1;
                            Console.WriteLine("You have " + immortality + " more rounds of immortalty");
                        }
                        if (stungun > 0)
                        {
                            Console.WriteLine("The dealer is stunned for " + stungun + " more rounds");
                        }
                        if (inventory == 5)
                        {

                            Console.WriteLine("");
                            Console.WriteLine("Would you like to check your inventory?");
                            string invcheck = Console.ReadLine();
                            if (invcheck == "Yes" || invcheck == "y" || invcheck == "yes")
                            {
                                Console.WriteLine("{Showing Inventory}");
                                Console.WriteLine("You have " + inv1 + " in slot 1");
                                Console.WriteLine("You have " + inv2 + " in slot 2");
                                Console.WriteLine("You have " + inv3 + " in slot 3");
                                Console.WriteLine("You have " + inv4 + " in slot 4");
                                Console.WriteLine("You have " + inv5 + " in slot 5");
                                inventory = 0;
                                if (inv1 != "nothing" || inv2 != "nothing" || inv3 != "nothing" || inv4 != "nothing" || inv5 != "nothing")
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("[You have an item you can use!]");
                                    Console.WriteLine("");
                                    Console.WriteLine("Which item would you like to use?");
                                    Console.WriteLine("");
                                    string itemanswer = Console.ReadLine();
                                    if (itemanswer == "1" || itemanswer == "slot 1" || itemanswer == "Slot 1")
                                    {
                                        if (inv1 == "nothing")
                                        {
                                            Console.WriteLine("You dont have an item in that slot!");
                                        }
                                        else if (inv1 != "nothing")
                                        {
                                            Console.WriteLine("Healed for 20 hp!");
                                            playerhealth += 20;
                                            inv1 = "nothing";
                                        }
                                    }
                                    else if (itemanswer == "2" || itemanswer == "slot 2" || itemanswer == "Slot 2")
                                    {

                                        if (inv2 == "nothing")
                                        {
                                            Console.WriteLine("You dont have an item in that slot!");
                                        }
                                        else if (inv2 != "nothing")
                                        {
                                            Console.WriteLine("Used stungun!");
                                            Console.WriteLine("Dealer is now stunned for 3 turns");
                                            stungun = 3;
                                            inv2 = "nothing";
                                        }
                                    }
                                    else if (itemanswer == "3" || itemanswer == "slot 3" || itemanswer == "Slot 3")
                                    {
                                        if (inv3 == "nothing")
                                        {
                                            Console.WriteLine("You dont have an item in that slot!");
                                        }
                                        else if (inv3 != "nothing")
                                        {
                                            Console.WriteLine("Used BlackFlash");
                                            blackflash = 1;
                                            inv3 = "nothing";
                                        }
                                    }
                                    else if (itemanswer == "4" || itemanswer == "slot 4" || itemanswer == "Slot 4")
                                    {
                                        if (inv4 == "nothing")
                                        {
                                            Console.WriteLine("You dont have an item in that slot!");
                                        }
                                        else if (inv4 != "nothing")
                                        {
                                            Console.WriteLine("Used WHEEL");
                                            mahoraga = 1;
                                            inv4 = "nothing";
                                        }
                                    }
                                    else if (itemanswer == "5" || itemanswer == "slot 5" || itemanswer == "Slot 5")
                                    {
                                        if (inv5 == "nothing")
                                        {
                                            Console.WriteLine("You dont have a item in that slot!");
                                        }
                                        else if (inv5 != "nothing")
                                        {
                                            Console.WriteLine("Are you sure you want to eat this finger?");
                                            string Fanswer = Console.ReadLine();
                                            if (Fanswer == "Yes" || Fanswer == "yes" || Fanswer == "y")
                                            {
                                                Console.WriteLine("You ate the finger");
                                                Console.WriteLine("");
                                                Console.WriteLine("[Gained two abilities]");
                                                Console.WriteLine("");
                                                sukuna = 1;
                                                inv5 = "nothing";
                                            }
                                            else if (Fanswer == "No" || Fanswer == "no" || Fanswer == "n")
                                            {
                                                Console.WriteLine("You toss the finger away");
                                                Console.WriteLine("Probably for the best");
                                                inv5 = "nothing";
                                            }
                                        }
                                    }
                                }
                            }
                            else if (invcheck == "No " || invcheck == "n" || invcheck == "no")
                            {
                                Console.WriteLine("{Declined showing inventory}");
                                inventory = 0;
                            }
                            else
                            {
                                Console.WriteLine("That is not a valid input");
                                inventory = 0;
                            }
                        }
                        if (sukuna != 1)
                        {
                            Console.WriteLine("Player attack, block, parry, dodge, spin, griddy, unequip?");

                        }
                        else
                        {
                            Console.WriteLine("Player attack, block, parry, dodge, spin, cleave, dismantle or unequip?");

                        }
                        Console.WriteLine("Player health:" + playerhealth);
                        Console.WriteLine("Dealer health:" + dealerhealth);
                        answer = Console.ReadLine();
                        if (answer == "block" || answer == "b")
                        {
                            inventory += 1;
                            if (stungun <= 0)
                            {


                                Random deal = new Random();
                                int dealchooser = deal.Next(1, 5);
                                if (dealchooser == 1)
                                {
                                    if (mahoraga == 0)
                                    {


                                        Console.WriteLine("Dealer attacks while you are blocking dealing 5 hp");
                                        playerhealth -= 5;
                                    }
                                    if (mahoraga == 1)
                                    {
                                        Console.WriteLine("Dealer attacks while you are blocking dealing 10 hp");
                                        playerhealth -= 10;
                                        Console.WriteLine("");
                                        Console.WriteLine("The wheel shakes slightly");
                                        Console.WriteLine("");
                                        adaptpoints += 1;
                                    }
                                    playerhealth += adaptation;
                                    
                                }
                                else if (dealchooser == 2)
                                {
                                    Console.WriteLine("You both block and nothing happens");
                                }
                                else if (dealchooser == 3)
                                {
                                    Console.WriteLine("Dealer tries parrying while you block he loses 5 hp");
                                    dealerhealth -= 5;

                                }
                                else if (dealchooser == 4)
                                {
                                    Console.WriteLine("Dealer prepares to dodge but you block resulting in nothing happening");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Dealer was stunned while you blocked!");
                                stungun -= 1;
                            }
                        }
                        else if (answer == "attack" || answer == "a")
                        {

                            inventory += 1;
                            if (blackflash == 0)
                            {


                                if (stungun <= 0)
                                {


                                    Random deal = new Random();
                                    int dealchooser = deal.Next(1, 5);
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
                                            if (mahoraga == 0)
                                            {


                                                Console.WriteLine("He attacks first making you lose 5 hp");
                                                playerhealth -= 5;
                                                playerhealth += adaptation;
                                                if (mahoraga == 1)
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine("The wheel shakes slightly");
                                                    Console.WriteLine("");
                                                    adaptpoints += 1;
                                                }
                                            }else if (mahoraga == 1)
                                            {
                                                Console.WriteLine("He attacks first making you lose 10 hp");
                                                playerhealth -= 10;
                                                playerhealth += adaptation;
                                                if (mahoraga == 1)
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine("The wheel shakes slightly");
                                                    Console.WriteLine("");
                                                    adaptpoints += 1;
                                                }
                                            }

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
                                        int parrychance = parry.Next(1, 3);
                                        if (parrychance == 1)
                                        {
                                            Console.WriteLine("He correctly parries your attack dealing 15 hp to you");
                                            playerhealth -= 15;
                                            playerhealth += adaptation;
                                            if (mahoraga == 1)
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine("The wheel shakes slightly");
                                                Console.WriteLine("");
                                                adaptpoints += 1;
                                            }
                                        }
                                        else if (parrychance == 2)
                                        {
                                            Console.WriteLine("He fails to parry your attack and he loses 5 hp");
                                            dealerhealth -= 5;
                                        }
                                    }
                                    else if (dealchooser == 4)
                                    {
                                        Random dodge = new Random();
                                        int dodgechance = dodge.Next(1, 3);
                                        if (dodgechance == 1)
                                        {
                                            Console.WriteLine("Dealer succsessfully dodges your attack");
                                        }
                                        else if (dodgechance == 2)
                                        {
                                            Console.WriteLine("Dealer fails to dodge your attack losing 5 hp");
                                            dealerhealth -= 10;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("He was stunned while you attacked, dealer lost 10 hp");
                                    dealerhealth -= 10;
                                    stungun -= 1;
                                }
                            }
                            else if (blackflash == 1)
                            {
                                blackflash = 0;
                                Random Bhit = new Random();
                                int blackhit = Bhit.Next(100, 200);
                                Random DL = new Random();
                                int delay = DL.Next(1, 100);
                                Random DLA = new Random();
                                int delaytime = DLA.Next(1, 50);
                                Console.WriteLine("You attack the dealer at " + blackhit + " ms!");
                                Console.WriteLine("Your black flash will lag behind with " + delay + " ms!");
                                Console.WriteLine("You must hit him within " + delaytime + " ms!");
                                Console.WriteLine("How much do you delay your black flash?");
                                int delayanswer = int.Parse(Console.ReadLine());
                                int BLTIME = blackhit - delay;
                                int directdelay = BLTIME - delayanswer;
                                if (directdelay == delaytime)
                                {
                                    Console.WriteLine("You hit the dealer for 50 hp!");
                                    dealerhealth -= 50;
                                }
                                else
                                {
                                    Console.WriteLine("You fail to hit the black flash and the dealer attacks you for 20 hp");
                                    playerhealth -= 20;
                                }
                            }
                        }
                        else if (answer == "parry" || answer == "p")
                        {
                            inventory += 1;
                            if (stungun <= 0)
                            {


                                Random deal = new Random();
                                int dealchooser = deal.Next(1, 5);
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
                                        Console.WriteLine("You failed to parry him you lost 10 hp");
                                        playerhealth -= 10;
                                        playerhealth += adaptation;
                                        if (mahoraga == 1)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("The wheel shakes slightly");
                                            Console.WriteLine("");
                                            adaptpoints += 1;
                                        }
                                    }
                                }
                                else if (dealchooser == 2)
                                {
                                    if (mahoraga == 0)
                                    {


                                        Console.WriteLine("He blocks while you parry for a attack you lose 5 hp");
                                        playerhealth -= 5;
                                        playerhealth += adaptation;
                                        if (mahoraga == 1)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("The wheel shakes slightly");
                                            Console.WriteLine("");
                                            adaptpoints += 1;
                                        }
                                    }else if (mahoraga == 1)
                                    {
                                        Console.WriteLine("He blocks while you parry for a attack you lose 10 hp");
                                        playerhealth -= 10;
                                        playerhealth += adaptation;
                                        if (mahoraga == 1)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("The wheel shakes slightly");
                                            Console.WriteLine("");
                                            adaptpoints += 1;
                                        }
                                    }
                                }
                                else if (dealchooser == 3)
                                {
                                    Console.WriteLine("You both try parrying resulting in a loss of 5 hp for both");
                                    dealerhealth -= 5;
                                    playerhealth -= 5;
                                }
                                else if (dealchooser == 4)
                                {
                                    Console.WriteLine("Dealer tries to dodge when you parry resulting in nothing happening");
                                }

                            }
                            else
                            {
                                Console.WriteLine("Dealer was stunned while you parry air");
                                stungun -= 1;
                            }
                        }
                        else if (answer == "dodge" || answer == "d")
                        {
                            inventory += 1;
                            if (stungun <= 0)
                            {


                                Random deal = new Random();
                                int dealchooser = deal.Next(1, 5);
                                if (dealchooser == 1)
                                {
                                    Random dodge = new Random();
                                    int dodgechance = dodge.Next(1, 3);
                                    if (dodgechance == 1)
                                    {
                                        Console.WriteLine("Dealer tries to attack but you succsessfully dodge");

                                    }
                                    else if (dodgechance == 2)
                                    {
                                        Console.WriteLine("He attacks and you fail to dodge losing 10 hp");
                                        playerhealth -= 10;
                                        playerhealth += adaptation;
                                        if (mahoraga == 1)
                                        {
                                            Console.WriteLine("");
                                            Console.WriteLine("The wheel shakes slightly");
                                            Console.WriteLine("");
                                            adaptpoints += 1;
                                        }
                                    }
                                }
                                else if (dealchooser == 2)
                                {
                                    Console.WriteLine("He tries to block while you try dodging nothing happens");

                                }
                                else if (dealchooser == 3)
                                {
                                    Console.WriteLine("He tries parrying while you dodge resulting in nothing happening");
                                }
                                else if (dealchooser == 4)
                                {
                                    Console.WriteLine("You both try dodging resulting in you both looking like idiots!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Dealer is stunned while you dodge nothing happens!");
                                stungun -= 1;
                            }
                        }
                        else if (answer == "devmode")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("What would you like to do?");
                            Console.WriteLine("Kill Dealer = 1");
                            Console.WriteLine("Kill Player = 2");
                            Console.WriteLine("Set both bars to zero = 3");
                            Console.WriteLine("Give the Player jackpot = 4");
                            Console.WriteLine("Give the Player black flash = 5");
                            Console.WriteLine("Give the Player bandage = 6");
                            Console.WriteLine("Give the Player stun gun = 7");
                            Console.WriteLine("Give the Player Sukuna finger = 8");
                            Console.WriteLine("Give the Player WHEEL = 9");
                            Console.WriteLine("Change adaption level = 10");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            int svar2 = int.Parse(Console.ReadLine());
                            if (svar2 == 1)
                            {
                                dealerhealth = 0;
                                Console.WriteLine("{killed Dealer}");
                            }
                            else if (svar2 == 2)
                            {
                                playerhealth = 0;
                                Console.WriteLine("{Killed Player}");
                            }
                            else if (svar2 == 3)
                            {
                                playerhealth = 0;
                                dealerhealth = 0;
                                Console.WriteLine("{Killed Player}");
                                Console.WriteLine("{killed Dealer}");
                            }
                            else if (svar2 == 4)
                            {
                                immortality = 10;
                                Console.WriteLine("{Gave Player jackpot}");
                            }
                            else if (svar2 == 5)
                            {
                                inv3 = "BLACKFLASH";
                                Console.WriteLine("{Gave Player black flash}");
                                inventory = 5;
                            }
                            else if (svar2 == 6)
                            {
                                inv1 = "BANDAGE";
                                Console.WriteLine("{Gave Player bandage}");
                                inventory = 5;
                            }
                            else if (svar2 == 7)
                            {
                                inv2 = "STUNGUN";
                                Console.WriteLine("{Gave Player stun gun}");
                                inventory = 5;
                            }
                            else if (svar2 == 8)
                            {
                                inv5 = "a Sukuna finger";
                                Console.WriteLine("{Gave Player a Sukuna finger}");
                                inventory = 5;
                            }
                            else if (svar2 == 9)
                            {
                                inv4 = "WHEEL";
                                Console.WriteLine("{Gave Player WHEEL}");
                                inventory = 5;
                            }else if (svar2 == 10)
                            {
                                Console.WriteLine("What would you like to change it to?");
                                int achange = int.Parse(Console.ReadLine());
                                adaptation = achange;
                                Console.WriteLine("Adaptation changed to " + achange);
                            }
                        }
                        else if (answer == "spin" || answer == "s")
                        {
                            //No jackpot
                            if (stungun == 0)
                            {


                                Console.WriteLine("Dealer attacks you while you go to gamble for 10 hp");
                                playerhealth -= 10;
                                playerhealth += adaptation;
                                if (mahoraga == 1)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("The wheel shakes slightly");
                                    Console.WriteLine("");
                                    adaptpoints += 1;
                                }
                            }
                            Console.WriteLine("");
                            if (immortality == 0)
                            {


                                Random spin = new Random();
                                int spinroll = spin.Next(1, 9);
                                if (spinroll <= 3)
                                {
                                    Console.WriteLine("You got nothing");
                                    if (stungun <= 0)
                                    {


                                        Random deal = new Random();
                                        int dealchooser = deal.Next(1, 5);
                                        if (dealchooser == 1)
                                        {
                                            Console.WriteLine("Dealer took advantages of your monkiness and attacked you dealing 10 hp");
                                            playerhealth -= 10;
                                        }
                                        else if (dealchooser == 2)
                                        {
                                            Console.WriteLine("Dealer blocks while you gamble resulting in nothing happening");
                                        }
                                        else if (dealchooser == 3)
                                        {
                                            Console.WriteLine("Dealer tries parrying your losing gambling streak but nothing happens");
                                        }
                                        else if (dealchooser == 4)
                                        {
                                            Console.WriteLine("Dealer tries dodging the amount of Ls you take but nothing happens anyway");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Dealer was stunned while you gamble");
                                        stungun -= 1;
                                    }
                                }
                                else if (spinroll == 4)
                                {
                                    Console.WriteLine("You got a BANDAGE using it will heal you for 20 hp");
                                    inv1 = "BANDAGE";
                                    if (stungun <= 0)
                                    {


                                        Random deal = new Random();
                                        int dealchooser = deal.Next(1, 5);
                                        if (dealchooser == 1)
                                        {
                                            Console.WriteLine("Dealer took advantages of your monkiness and attacked you dealing 10 hp");
                                            playerhealth -= 10;
                                        }
                                        else if (dealchooser == 2)
                                        {
                                            Console.WriteLine("Dealer blocks while you gamble resulting in nothing happening");
                                        }
                                        else if (dealchooser == 3)
                                        {
                                            Console.WriteLine("Dealer tries parrying your losing gambling streak but nothing happens");
                                        }
                                        else if (dealchooser == 4)
                                        {
                                            Console.WriteLine("Dealer tries dodging the amount of Ls you take but nothing happens anyway");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Dealer was stunned while you gamble");
                                        stungun -= 1;
                                    }
                                }
                                else if (spinroll == 5)
                                {
                                    Console.WriteLine("You got a STUNGUN use it to stun the dealer for 3 turns");
                                    inv2 = "STUNGUN";
                                    if (stungun <= 0)
                                    {


                                        Random deal = new Random();
                                        int dealchooser = deal.Next(1, 5);
                                        if (dealchooser == 1)
                                        {
                                            Console.WriteLine("Dealer took advantages of your monkiness and attacked you dealing 10 hp");
                                            playerhealth -= 10;
                                        }
                                        else if (dealchooser == 2)
                                        {
                                            Console.WriteLine("Dealer blocks while you gamble resulting in nothing happening");
                                        }
                                        else if (dealchooser == 3)
                                        {
                                            Console.WriteLine("Dealer tries parrying your losing gambling streak but nothing happens");
                                        }
                                        else if (dealchooser == 4)
                                        {
                                            Console.WriteLine("Dealer tries dodging the amount of Ls you take but nothing happens anyway");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Dealer was stunned while you gamble");
                                        stungun -= 1;
                                    }
                                }
                                else if (spinroll == 6)
                                {
                                    Console.WriteLine("You got a BLACKFLASH");
                                    inv3 = "BLACKFLASH";
                                    if (stungun <= 0)
                                    {


                                        Random deal = new Random();
                                        int dealchooser = deal.Next(1, 5);
                                        if (dealchooser == 1)
                                        {
                                            Console.WriteLine("Dealer took advantages of your monkiness and attacked you dealing 10 hp");
                                            playerhealth -= 10;
                                            playerhealth += adaptation;
                                            if (mahoraga == 1)
                                            {
                                                Console.WriteLine("");
                                                Console.WriteLine("The wheel shakes slightly");
                                                Console.WriteLine("");
                                                adaptpoints += 1;
                                            }
                                        }
                                        else if (dealchooser == 2)
                                        {
                                            Console.WriteLine("Dealer blocks while you gamble resulting in nothing happening");
                                        }
                                        else if (dealchooser == 3)
                                        {
                                            Console.WriteLine("Dealer tries parrying your losing gambling streak but nothing happens");
                                        }
                                        else if (dealchooser == 4)
                                        {
                                            Console.WriteLine("Dealer tries dodging the amount of Ls you take but nothing happens anyway");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Dealer was stunned while you gamble");
                                        stungun -= 1;
                                    }
                                }
                                else if (spinroll == 7)
                                {
                                    Console.WriteLine("You are about to hit the jackpot!");
                                    Console.WriteLine("Say a number through 1 to 3!");
                                    Random jack = new Random();
                                    int jackpot = jack.Next(1, 4);
                                    string thing = "";
                                    if (jackpot == 1)
                                    {
                                        thing = "1";
                                    }else if (jackpot == 2)
                                    {
                                        thing = "2";
                                    }else if (jackpot == 3)
                                    {
                                        thing = "3";
                                    }
                                    string jackpotanswer = Console.ReadLine();
                                    if (jackpotanswer == thing)
                                    {
                                        Console.WriteLine("You hit the jackpot!");
                                        Console.WriteLine("");
                                        Console.WriteLine("For the next 10 rounds, Player is effectively immortal.");
                                        immortality = 10;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You didn't hit the jackpot!");
                                        Random deal = new Random();
                                        if (stungun <= 0)
                                        {


                                            int dealchooser = deal.Next(1, 5);
                                            if (dealchooser == 1)
                                            {
                                                Console.WriteLine("Dealer took advantages of your monkiness and attacked you dealing 10 hp");
                                                playerhealth -= 10;
                                                playerhealth += adaptation;
                                                if (mahoraga == 1)
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine("The wheel shakes slightly");
                                                    Console.WriteLine("");
                                                    adaptpoints += 1;
                                                }
                                            }
                                            else if (dealchooser == 2)
                                            {
                                                Console.WriteLine("Dealer blocks while you gamble resulting in nothing happening");
                                            }
                                            else if (dealchooser == 3)
                                            {
                                                Console.WriteLine("Dealer tries parrying your losing gambling streak but nothing happens");
                                            }
                                            else if (dealchooser == 4)
                                            {
                                                Console.WriteLine("Dealer tries dodging the amount of Ls you take but nothing happens anyway");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Dealer is stunned while you gamble");
                                            stungun -= 1;
                                        }
                                    }
                                }
                                else if (spinroll == 8)
                                {
                                    Random WC = new Random();
                                    int WheelChance = WC.Next(1, 3);
                                    if (WheelChance == 1)
                                    {
                                        Console.WriteLine("You got nothing");
                                    }
                                    else if (WheelChance == 2)
                                    {
                                        Console.WriteLine("[You can feel the WHEEL in your hand]");
                                        Console.WriteLine("");
                                        Console.WriteLine("--Using the WHEEL will allow you to adapt to anything and everything--");
                                        inv4 = "WHEEL";
                                    }
                                }
                            }
                            else
                            {
                                //if you have jackpot
                                Random JS = new Random();
                                int JPS = JS.Next(1, 3);
                                if (JPS == 1)
                                {


                                    Random spin = new Random();
                                    int spinroll = spin.Next(1, 7);
                                    if (spinroll <= 3)
                                    {
                                        Console.WriteLine("You got nothing");
                                        if (stungun <= 0)
                                        {


                                            Random deal = new Random();
                                            int dealchooser = deal.Next(1, 5);
                                            if (dealchooser == 1)
                                            {
                                                Console.WriteLine("Dealer took advantages of your monkiness and attacked you dealing 10 hp");
                                                playerhealth -= 10;
                                                playerhealth += adaptation;
                                                if (mahoraga == 1)
                                                {
                                                    Console.WriteLine("");
                                                    Console.WriteLine("The wheel shakes slightly");
                                                    Console.WriteLine("");
                                                    adaptpoints += 1;
                                                }
                                            }
                                            else if (dealchooser == 2)
                                            {
                                                Console.WriteLine("Dealer blocks while you gamble resulting in nothing happening");
                                            }
                                            else if (dealchooser == 3)
                                            {
                                                Console.WriteLine("Dealer tries parrying your losing gambling streak but nothing happens");
                                            }
                                            else if (dealchooser == 4)
                                            {
                                                Console.WriteLine("Dealer tries dodging the amount of Ls you take but nothing happens anyway");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Dealer was stunned while you gamble");
                                            stungun -= 1;
                                        }
                                    }
                                    else if (spinroll == 4)
                                    {
                                        Console.WriteLine("You got a BANDAGE using it will heal you for 20 hp");
                                        inv1 = "BANDAGE";
                                        if (stungun <= 0)
                                        {


                                            Random deal = new Random();
                                            int dealchooser = deal.Next(1, 5);
                                            if (dealchooser == 1)
                                            {
                                                Console.WriteLine("Dealer took advantages of your monkiness and attacked you dealing 10 hp");
                                                playerhealth -= 10;
                                            }
                                            else if (dealchooser == 2)
                                            {
                                                Console.WriteLine("Dealer blocks while you gamble resulting in nothing happening");
                                            }
                                            else if (dealchooser == 3)
                                            {
                                                Console.WriteLine("Dealer tries parrying your losing gambling streak but nothing happens");
                                            }
                                            else if (dealchooser == 4)
                                            {
                                                Console.WriteLine("Dealer tries dodging the amount of Ls you take but nothing happens anyway");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Dealer was stunned while you gamble");
                                            stungun -= 1;
                                        }
                                    }
                                    else if (spinroll == 5)
                                    {
                                        Console.WriteLine("You got a STUNGUN use it to stun the dealer for 3 turns");
                                        inv2 = "STUNGUN";
                                        if (stungun <= 0)
                                        {


                                            Random deal = new Random();
                                            int dealchooser = deal.Next(1, 5);
                                            if (dealchooser == 1)
                                            {
                                                Console.WriteLine("Dealer took advantages of your monkiness and attacked you dealing 10 hp");
                                                playerhealth -= 10;
                                            }
                                            else if (dealchooser == 2)
                                            {
                                                Console.WriteLine("Dealer blocks while you gamble resulting in nothing happening");
                                            }
                                            else if (dealchooser == 3)
                                            {
                                                Console.WriteLine("Dealer tries parrying your losing gambling streak but nothing happens");
                                            }
                                            else if (dealchooser == 4)
                                            {
                                                Console.WriteLine("Dealer tries dodging the amount of Ls you take but nothing happens anyway");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Dealer was stunned while you gamble");
                                            stungun -= 1;
                                        }
                                    }
                                    else if (spinroll == 6)
                                    {
                                        Console.WriteLine("You got a BLACKFLASH");
                                        inv3 = "BLACKFLASH";
                                        if (stungun <= 0)
                                        {


                                            Random deal = new Random();
                                            int dealchooser = deal.Next(1, 5);
                                            if (dealchooser == 1)
                                            {
                                                Console.WriteLine("Dealer took advantages of your monkiness and attacked you dealing 10 hp");
                                                playerhealth -= 10;
                                            }
                                            else if (dealchooser == 2)
                                            {
                                                Console.WriteLine("Dealer blocks while you gamble resulting in nothing happening");
                                            }
                                            else if (dealchooser == 3)
                                            {
                                                Console.WriteLine("Dealer tries parrying your losing gambling streak but nothing happens");
                                            }
                                            else if (dealchooser == 4)
                                            {
                                                Console.WriteLine("Dealer tries dodging the amount of Ls you take but nothing happens anyway");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Dealer was stunned while you gamble");
                                            stungun -= 1;
                                        }
                                    }
                                }
                                else if (JPS == 2)
                                {
                                    Console.WriteLine("You are about to hit the jackpot!");
                                    Console.WriteLine("Say a number through 1 to 3!");
                                    Random jack = new Random();
                                    int jackpot = jack.Next(1, 4);
                                    int jackpotanswer = int.Parse(Console.ReadLine());
                                    if (jackpotanswer == jackpot)
                                    {
                                        Console.WriteLine("You hit the jackpot!");
                                        Console.WriteLine("");
                                        Console.WriteLine("For the next 10 rounds, Player is effectively immortal.");
                                        immortality = 10;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You didn't hit the jackpot!");
                                        Random deal = new Random();
                                    }
                                }
                            }
                        }
                        else if (answer == "griddy" || answer == "g")
                        {
                            if (sukuna == 0)
                            {


                                Random G = new Random();
                                int griddychance = G.Next(1, 100);
                                if (griddychance > 1)
                                {


                                    Console.WriteLine("You hit the griddy to the confusion of the Dealer");
                                    Console.WriteLine("He attacks you for 15 hp");
                                    playerhealth -= 15;

                                }
                                else if (griddychance == 1)
                                {
                                    Console.WriteLine("You got a sukuna finger???");
                                    inv5 = "a Sukuna finger";
                                }
                            }
                            else if (sukuna != 0)
                            {
                                Console.WriteLine("You gain nothing by doing this!");
                            }
                        }
                        else if (answer == "dismantle")
                        {
                            if (sukuna == 0)
                            {
                                Console.WriteLine("You havent unlocked this ability yet!");
                            }
                            else if (sukuna == 1)
                            {
                                Random DR = new Random();
                                int Droll = DR.Next(1, 3);
                                if (Droll == 1)
                                {
                                    Console.WriteLine("Dealer tries to block your slash");
                                    Console.WriteLine("He blocks but still takes 15 hp");
                                    dealerhealth -= 15;
                                }
                                else if (Droll == 2)
                                {
                                    Random deal = new Random();
                                    int dealroll = deal.Next(1, 4);
                                    if (dealroll == 1)
                                    {
                                        Random attack = new Random();
                                        int attacker = attack.Next(1, 3);
                                        if (attacker == 1)
                                        {


                                            Console.WriteLine("Dealer tries to attack you but is stopped by your slashes");
                                            dealerhealth -= 30;
                                        }
                                        else if (attacker == 2)
                                        {
                                            Console.WriteLine("He manages to hit you for 10 hp before your slashes go off");
                                            playerhealth -= 10;
                                            if (mahoraga == 1)
                                            {
                                                adaptpoints += 1;
                                                Console.WriteLine("The wheel shakes slightly");
                                                playerhealth += adaptation;
                                            }
                                            

                                        }
                                    }
                                    else if (dealroll == 2)
                                    {
                                        Console.WriteLine("Dealer tries to block your slash");
                                        Console.WriteLine("He blocks but still takes 20 hp");
                                        dealerhealth -= 20;
                                    }
                                    else if (dealroll == 3)
                                    {
                                        Random P = new Random();
                                        int parry = P.Next(1, 4);
                                        if (parry != 1)
                                        {

                                            Console.WriteLine("Dealer tries to parry your slashes but gets cut");
                                            dealerhealth -= 30;
                                        }
                                        else if (parry == 1)
                                        {
                                            Console.WriteLine("He manages to parry your attack for 15 hp");
                                            playerhealth -= 10;
                                            if (mahoraga == 1)
                                            {
                                                adaptpoints += 1;
                                                Console.WriteLine("The wheel shakes slightly");
                                                playerhealth += adaptation;
                                            }
                                        }
                                    }
                                    else if (dealroll == 4)
                                    {
                                        Random D = new Random();
                                        int dodge = D.Next(1, 3);
                                        if (dodge == 1)
                                        {
                                            Console.WriteLine("He succsessfully dodges your attack");
                                        }
                                        else if (dodge == 2)
                                        {
                                            Console.WriteLine("He fails to dodge your attack and gets hit for 30 hp");
                                            dealerhealth -= 30;
                                        }

                                    }
                                }
                            }
                        }
                        else if (answer == "cleave")
                        {
                            if (sukuna == 0)
                            {
                                Console.WriteLine("You havent unlocked this ability yet!");
                            }
                            else if (sukuna == 1)
                            {
                                Random CL = new Random();
                                int close = CL.Next(1, 4);
                                if (close == 1)
                                {
                                    Console.WriteLine("You manage to make direct contact with the dealer");
                                    Console.WriteLine("How much curse energy will you use?");
                                    Random M = new Random();
                                    int max = M.Next(1, 30);
                                    Console.WriteLine("Your maximum is " + max);
                                    int maxanswer = int.Parse(Console.ReadLine());
                                    if (max >= maxanswer)
                                    {
                                        int damage = 10;
                                        int trudamage = damage + max;
                                        dealerhealth -= trudamage;
                                        Console.WriteLine("You damaged him for " + trudamage);
                                    }
                                    else if (max < maxanswer)
                                    {
                                        Console.WriteLine("You went above your max and damaged yourself!");
                                        playerhealth -= 15;
                                    }

                                }
                                else if (close > 1)
                                {
                                    Random DLd = new Random();
                                    int ddistance = DLd.Next(50, 100);
                                    Random PLd = new Random();
                                    int pdistance = PLd.Next(1, 50);
                                    Random S = new Random();
                                    int speed = S.Next(1, 5);
                                    Console.WriteLine("The dealer is at " + ddistance);
                                    Console.WriteLine("You are " + pdistance + " meters away");
                                    Console.WriteLine("You run at " + speed + " meters per seconds");
                                    Console.WriteLine("How many seconds does it take to run to him?");
                                    int traveldistance = ddistance - pdistance;
                                    int trutravel = traveldistance / speed;
                                    int Sanswer = int.Parse(Console.ReadLine());
                                    if (Sanswer == trutravel)
                                    {
                                        Console.WriteLine("You manage to make direct contact with the Dealer");
                                        Console.WriteLine("How much curse energy will you use?");
                                        Random M = new Random();
                                        int max = M.Next(10, 30);
                                        Console.WriteLine("Your maximum is " + max);
                                        int maxanswer = int.Parse(Console.ReadLine());
                                        if (max >= maxanswer)
                                        {
                                            int damage = 10;
                                            int trudamage = damage + max;
                                            dealerhealth -= trudamage;
                                            Console.WriteLine("You managed to damage him for " + trudamage);
                                        }
                                        else if (max < maxanswer)
                                        {
                                            Console.WriteLine("You went above your max and damaged yourself!");
                                            playerhealth -= 15;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("You didn't make it in time and he damaged you for 15 hp");
                                        playerhealth -= 15;
                                        if (mahoraga == 1)
                                        {
                                            adaptpoints += 1;
                                            Console.WriteLine("The wheel shakes slightly");
                                            playerhealth += adaptation;
                                        }
                                        
                                    }
                                }
                            }
                        }else if (answer == "unequip" || answer == "u" || answer == "Unequip")
                        {
                            Console.WriteLine("What would you like to unequip?");
                            string uanswer = Console.ReadLine();
                            if (uanswer == "wheel" || uanswer == "Wheel" || uanswer == "w" || uanswer == "WHEEL")
                            {
                                if (mahoraga == 1)
                                {
                                    mahoraga = 0;
                                    inv4 = "WHEEL";
                                    adaptation = 0;
                                    adaptpoints = 0;
                                    Console.WriteLine("[Unequipped WHEEL]");
                                }else if (mahoraga != 1)
                                {
                                    Console.WriteLine("You haven't used the WHEEL!");
                                }
                                
                            }
                            else if (uanswer == "BlackFlash" || uanswer == "BL" || uanswer == "bl" || uanswer == "blackflash" || uanswer == "BLACKFLASH")
                            {
                                if (blackflash == 1)
                                {
                                    blackflash = 0;
                                    inv3 = "BlackFlash";
                                    Console.WriteLine("[Unequipped BlackFlash]");
                                }else if (blackflash != 1)
                                {
                                    Console.WriteLine("You haven't used BlackFlash!");
                                }
                                
                            }
                            else if (uanswer == "STUNGUN" || uanswer == "stungun" || uanswer == "sg" || uanswer == "Stungun")
                            {
                                if (stungun != 0)
                                {
                                    stungun = 0;
                                    Console.WriteLine("[Unequipped STUNGUN]");
                                }else if (stungun == 0)
                                {
                                    Console.WriteLine("You haven't used the STUNGUN");
                                }
                                
                            }else
                            {
                                Console.WriteLine("That item does not exist!");
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
                if (LCV == 0)
                {


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
                }else if (LCV != 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("You lost!");
                    Console.WriteLine("");
                    g = 100;
                    Gameongoing = 1;
                }
            }
        }
    }
}