using System;
using System.Collections.Generic;
using System.Threading;

namespace Fighting_but_no_Visuals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floor = 1;
            bool Nextround = true;
            int Hero_Money = 0;
            Skills HeroPots = new Skills();
            HeroPots.HP_Pots = 0;
            HeroPots.ST_Pots = 0;
            HeroPots.Gold = 0;
            while (Nextround)
            {
                //HERO BASE ATTRIBUTES
                Skills HeroSkills = new Skills();
                HeroSkills.Stamina = 50;
                HeroSkills.Stamina_regen = 10;
                HeroSkills.HP = 100;
                HeroSkills.Basic = 10;
                HeroSkills.FirstSkill = 15;
                HeroSkills.SecondSkill = 20;
                HeroSkills.ThirdSkill = 45;
                HeroSkills.Divine_Damage = 25;

                //MONSTER BASE ATTRIBUTES
                Skills MonsterSkills = new Skills();
                MonsterSkills.Basic = 5;
                MonsterSkills.FirstSkill = 10;
                MonsterSkills.SecondSkill = 15;
                MonsterSkills.ThirdSkill = 20;
                MonsterSkills.HP = 75;

                while (true)
                {
                    Console.WriteLine($"\n\tFLOOR {floor}");
                    Console.WriteLine($"\n\tHERO\n\t{HeroSkills.HP} HP \n\t{HeroSkills.Stamina} ST\n");
                    Console.WriteLine($"\n\tBLACK NIGGANSTER\n\t{MonsterSkills.HP}HP");
                    Console.WriteLine("\nYour turn to attack");
                    Console.WriteLine($"\nCHOOSE AN ATTACK: " +
                        $"\n[1]Divine Sunderer[20 ST] " +
                        $"\n[2]Blade Surge[30 ST] " +
                        $"\n[3]Ultimate Slash[45 ST]" +
                        $"\n[B]Basic Attack[10 ST]" +
                        $"\n\n[P] Skip Turn(+20 ST)" +
                        $"\n[Z]HP POTION[{HeroPots.HP_Pots}]" +
                        $"\n[X]STAMINA POTION[{HeroPots.ST_Pots}]");
                    string HeroTurn = Console.ReadLine();
                    if (HeroSkills.Stamina > 10)
                    {
                        switch (HeroTurn.ToUpper())
                        {
                            case "1":
                                Console.WriteLine("Hero uses Divine Sunderer");
                                MonsterSkills.HP -= HeroSkills.FirstSkill;
                                HeroSkills.Stamina -= 20;
                                break;
                            case "2":
                                Console.WriteLine("Hero uses Blade Surge");
                                MonsterSkills.HP -= HeroSkills.SecondSkill;
                                HeroSkills.Stamina -= 30;
                                break;
                            case "3":
                                Console.WriteLine("Hero uses Ultimate Slash");
                                MonsterSkills.HP -= HeroSkills.ThirdSkill;
                                HeroSkills.Stamina -= 45;
                                break;
                            case "B":
                                if (HeroSkills.Divine_User == true)
                                {
                                    Console.WriteLine("Hero uses Divine Attack");
                                    MonsterSkills.HP -= HeroSkills.Divine_Damage;
                                    HeroSkills.Stamina -= 10;
                                }
                                else
                                {
                                    Console.WriteLine("Hero uses Basic Attack");
                                    MonsterSkills.HP -= HeroSkills.Basic;
                                    HeroSkills.Stamina -= 10;
                                }
                                break;
                            case "P":
                                Console.WriteLine("Hero skips turn");
                                HeroSkills.Stamina += 10;
                                break;
                            //HP POTS
                            case "Z":
                                if (HeroPots.HP_Pots <= 0)
                                {
                                    Console.WriteLine("You dont have enough Health Potion!");
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    continue;

                                }
                                else
                                {
                                    HeroSkills.HP += 20;
                                    Console.WriteLine($"You healed 20 HP, Total HP: {HeroSkills.HP}");
                                }
                                break;
                            //STAMINA POTS
                            case "X":
                                if (HeroPots.ST_Pots <= 0)
                                {
                                    Console.WriteLine("You dont have enough Health Potion!");
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    continue;
                                }
                                else
                                {
                                    HeroSkills.Stamina += 20;
                                    Console.WriteLine($"You gained 20 ST, Total ST: {HeroSkills.Stamina}");
                                }
                                break;
                            default:
                                Console.WriteLine("You missed!, Choose between [4] Attacks");
                                HeroSkills.Stamina -= 5;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You ran out of stamina, you cant attack this turn");
                    }
                    //REGEN HERO STAMINA EACH TURN
                    HeroSkills.Stamina += HeroSkills.Stamina_regen;


                    Thread.Sleep(1000);
                    Random random = new Random();
                    switch (random.Next(1, 5))
                    {
                        case 1:
                            Console.WriteLine("Monster uses Bite");
                            HeroSkills.HP -= MonsterSkills.FirstSkill;
                            break;
                        case 2:
                            Console.WriteLine("Monster uses Dark Slash");
                            HeroSkills.HP -= MonsterSkills.SecondSkill;
                            break;
                        case 3:
                            Console.WriteLine("Monster uses Hydro Blast");
                            HeroSkills.HP -= MonsterSkills.ThirdSkill;
                            break;
                        case 4:
                            Console.WriteLine("Monster uses Tackle");
                            HeroSkills.HP -= MonsterSkills.Basic;
                            break;
                    }
                    Thread.Sleep(500);
                    Console.Clear();
                    //HERO WINS
                    if (MonsterSkills.HP <= 0)
                    {
                        Console.WriteLine("Hero Wins!");
                        floor++;
                        Hero_Money += 25;
                        Console.WriteLine($"You earned 25 Gold, Your total Gold is {Hero_Money}");

                        //RESETS HERO ATTRIBUTES EVERY WIN
                        HeroSkills.HP = 100;
                        HeroSkills.Stamina = 50;

                        //ADDS ATTRIBUTES EVERY FLOOR TO THE MONSTER
                        MonsterSkills.Basic = 5 + (floor * 1);
                        MonsterSkills.FirstSkill = 10 + (floor * 2);
                        MonsterSkills.SecondSkill = 15 + (floor * 3);
                        MonsterSkills.ThirdSkill = 20 + (floor * 4);
                        MonsterSkills.HP = 75 + (floor * 10);

                        //SHOP OR NEXT FLOOR
                        Console.WriteLine("[N]Next Floor\n[S]Shop");
                        string win = Console.ReadLine();
                        Thread.Sleep(1000);
                        Console.Clear();
                        if (win == "N".ToLower())
                        {
                               continue;                   
                        }
                        else if (win == "S".ToLower())
                        {
                            Console.WriteLine("WELCOME TO SHOP\n\t[1]Health Potion : 15 Gold\n\t[2]Stamina Potion : 15 Gold \n\t[3]Divine Sword : 150 Gold\n\t[X]Exit");
                            string hp_st = Console.ReadLine();
                            int HP_Price = 15;
                            int ST_Price = 15;
                            int Divine_Sword = 150;

                            if (hp_st == "1" || hp_st == "2")
                            {
                                Console.WriteLine($"How many pots you want to buy? :");
                                int amount = int.Parse(Console.ReadLine());
                                int totalPrice = (hp_st == "1") ? HP_Price * amount : ST_Price * amount;
                                if (Hero_Money >= totalPrice)
                                {
                                    Hero_Money -= totalPrice;
                                    if (hp_st == "1")
                                    {
                                        HeroPots.HP_Pots += amount;
                                        Console.WriteLine($"You bought [{amount}] HP Potion(s)");
                                    }
                                    else
                                    {
                                        HeroPots.ST_Pots += amount;
                                        Console.WriteLine($"You bought [{amount}] Stamina Potion(s)");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You don't have enough gold");
                                    Thread.Sleep(500);
                                    Console.Clear();
                                    continue;
                                }
                            }
                            else if(hp_st == "3")
                            {
                                if (Hero_Money >= 150)
                                {
                                    Console.WriteLine("Divine Sword chose a worthy champion");
                                    HeroSkills.Divine_User = true;
                                }
                                else if( Hero_Money <= 149)
                                {
                                    Console.WriteLine("You don't have enough gold");
                                    Thread.Sleep(500);
                                    Console.Clear();
                                    continue;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Choose between the options!");
                                continue;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Choose between the options!");
                            continue;
                        }
                        if (HeroSkills.HP <= 0)
                        {
                            Console.WriteLine("Hero Defeated!");
                            break;
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                   


                }
            }
        }

    }
    class Skills
    {
        public double Basic { get; set; }
        public double FirstSkill { get; set; }
        public double SecondSkill { get; set; }
        public double ThirdSkill { get; set; }
        public double HP { get; set; }
        public double Stamina { get; set; }
        public double Stamina_regen { get; set; }
        public int HP_Pots { get; set; }
        public int ST_Pots { get; set; }
        public int Gold { get; set; }
        public int Divine_Damage { get; set; }
        public bool Divine_User { get; set; }
    }
}

