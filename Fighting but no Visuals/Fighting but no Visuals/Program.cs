using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace Fighting_but_no_Visuals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floor = 1;
            bool Nextround = true;
            double Hero_Money = 0;
            Skills HeroPots = new Skills();
            HeroPots.HP_Pots = 0;
            HeroPots.ST_Pots = 0;
            HeroPots.Gold = 0;
            HeroPots.Cheat = 1000000;
            HeroPots.InfinityEdge_Buff = 1.3;
            HeroPots.BloodThirst_Lifesteal = 5;
            while (Nextround)
            {
                //BERSERKER HERO BASE ATTRIBUTES
                Skills HeroSkills = new Skills();
                HeroSkills.Stamina = 60;
                HeroSkills.Stamina_regen = 12;
                HeroSkills.HP = 120;
                HeroSkills.Basic = 15;
                HeroSkills.FirstSkill = 25;
                HeroSkills.SecondSkill = 30;
                HeroSkills.ThirdSkill = 55;
                HeroSkills.Divine_Damage = 30;
                //ASSASIN HERO BASE ATTRIBUTES
                Skills HeroSkills2 = new Skills();
                HeroSkills2.Stamina = 50;
                HeroSkills2.Stamina_regen = 18;
                HeroSkills2.HP = 90;
                HeroSkills2.Basic = 18;
                HeroSkills2.FirstSkill = 20;
                HeroSkills2.SecondSkill = 35;
                HeroSkills2.ThirdSkill = 50;
                HeroSkills2.Bloodlust_Damage = 36;
                //MAGE HERO BASE ATTRIBUTES
                Skills HeroSkills3 = new Skills();
                HeroSkills3.Stamina = 55;
                HeroSkills3.Stamina_regen = 15;
                HeroSkills3.HP = 80;
                HeroSkills3.Basic = 12;
                HeroSkills3.FirstSkill = 35;
                HeroSkills3.SecondSkill = 45;
                HeroSkills3.ThirdSkill = 60;
                HeroSkills3.Arcane_Damage = 25;

                //MONSTER BASE ATTRIBUTES
                Skills MonsterSkills = new Skills();
                MonsterSkills.Basic = 5;
                MonsterSkills.FirstSkill = 8;
                MonsterSkills.SecondSkill = 10;
                MonsterSkills.ThirdSkill = 10;
                MonsterSkills.HP = 75;

                //
                Console.WriteLine("   ╔══════════════════════╗");
                Console.WriteLine($"   ║ What's your name?:   ║");
                Console.WriteLine("   ╚══════════════════════╝\n");
                string user_name = Console.ReadLine();
                Console.WriteLine($"Welcome to this Turn-based game {user_name.ToUpper()}");
                Thread.Sleep(2000);
                Console.Clear();

                //CHOOSE CLASS
                Console.WriteLine("   ╔══════════════════════════╗");
                Console.WriteLine("   ║ CHOOSE YOUR CLASS        ║");
                Console.WriteLine("   ║ [1] BERSERKER            ║");
                Console.WriteLine($"   ║   HP: {HeroSkills.HP}                ║");
                Console.WriteLine($"   ║   BASE DAMAGE: {HeroSkills.Basic}        ║");
                Console.WriteLine($"   ║   ULTIMATE: {HeroSkills.ThirdSkill}           ║");
                Console.WriteLine("   ║ [2] ASSASSIN             ║");
                Console.WriteLine($"   ║   HP: {HeroSkills2.HP}                 ║");
                Console.WriteLine($"   ║   BASE DAMAGE: {HeroSkills2.Basic}        ║");
                Console.WriteLine($"   ║   ULTIMATE: {HeroSkills2.ThirdSkill}           ║");
                Console.WriteLine("   ║ [3] MAGE                 ║");
                Console.WriteLine($"   ║   HP: {HeroSkills3.HP}                 ║");
                Console.WriteLine($"   ║   BASE DAMAGE: {HeroSkills3.Basic}        ║");
                Console.WriteLine($"   ║   ULTIMATE: {HeroSkills3.ThirdSkill}           ║");
                Console.WriteLine("   ╚══════════════════════════╝");

                //WHILE LOOP CHOOSE CLASS
                string User_Class = "";
                User_Class = Console.ReadLine();
                while (User_Class != "1" && User_Class != "2" && User_Class != "3")
                {
                    Console.WriteLine("CHOOSE CLASS [1-3]");
                    User_Class = Console.ReadLine();                }
                switch (User_Class)
                {
                    case "1":
                        Console.WriteLine($"You are now a BERSERKER, {user_name.ToUpper()}");
                        break;
                    case "2":
                        Console.WriteLine($"So you are an ASSASIN, {user_name.ToUpper()}");
                        break;
                    case "3":
                        Console.WriteLine($"You became a MAGE, {user_name.ToUpper()}");
                        break;
                    default:
                        Console.WriteLine("Invalid Output");
                        continue;
                }
                Thread.Sleep(2000);
                Console.Clear();

              
                while (true)
                {
                    Console.WriteLine("   ╔══════════════╗");
                    Console.WriteLine($"   ║ FLOOR : {floor}    ║");
                    Console.WriteLine("   ╚══════════════╝\n");
                    //IF CLASS = BERSERKER
                    if (User_Class == "1")
                    {
                        Console.WriteLine($"    {user_name.ToUpper()} | BERSERKER  ");
                        Console.WriteLine("   ╔══════════════╗");
                        Console.WriteLine($"   ║ HP: {HeroSkills.HP}      ║");
                        Console.WriteLine($"   ║ ST: {HeroSkills.Stamina}       ║");
                        Console.WriteLine("   ╚══════════════╝\n");
                        Console.WriteLine("   BLACK NIGGANSTER  ");
                        Console.WriteLine("   ╔══════════════╗");
                        Console.WriteLine($"   ║ HP: {MonsterSkills.HP}       ║");
                        Console.WriteLine("   ╚══════════════╝");
                        Console.WriteLine("\nYour turn to attack");
                        Console.WriteLine($"\nCHOOSE AN ATTACK: " +
                            $"\n[1]Divine Sunderer[20 ST] " +
                            $"\n[2]Blade Surge[30 ST] " +
                            $"\n[3]Ultimate Slash[45 ST]" +
                            $"\n[B]Basic Attack[10 ST]\n" +
                            $"\nMISCELANOUS" +
                            $"\n[P]Skip Turn(+20 ST)" +
                            $"\n[Z]HP POTION[{HeroPots.HP_Pots}]" +
                            $"\n[X]STAMINA POTION[{HeroPots.ST_Pots}]");
                    }
                    //IF CLASS = ASSASIN
                    else if (User_Class == "2")
                    {
                        Console.WriteLine($"    {user_name.ToUpper()} | ASSASIN  ");
                        Console.WriteLine("   ╔══════════════╗");
                        Console.WriteLine($"   ║ HP: {HeroSkills2.HP}       ║");
                        Console.WriteLine($"   ║ ST: {HeroSkills2.Stamina}       ║");
                        Console.WriteLine("   ╚══════════════╝\n");
                        Console.WriteLine("   BLACK NIGGANSTER  ");
                        Console.WriteLine("   ╔══════════════╗");
                        Console.WriteLine($"   ║ HP: {MonsterSkills.HP}       ║");
                        Console.WriteLine("   ╚══════════════╝");
                        Console.WriteLine("\nYour turn to attack");
                        Console.WriteLine($"\nCHOOSE AN ATTACK: " +
                            $"\n[1]Deadly Lounge[25 ST] " +
                            $"\n[2]Shadow Strike[32 ST] " +
                            $"\n[3]Ultimate Lethal Poison[35 ST]" +
                            $"\n[B]Basic Attack[15 ST]\n" +
                            $"\nMISCELANOUS" +
                            $"\n[P]Skip Turn(+20 ST)" +
                            $"\n[Z]HP POTION[{HeroPots.HP_Pots}]" +
                            $"\n[X]STAMINA POTION[{HeroPots.ST_Pots}]");
                    }
                    //IF CLASS = MAGE
                    else if (User_Class == "3")
                    {
                        Console.WriteLine($"    {user_name.ToUpper()} | MAGE  ");
                        Console.WriteLine("   ╔══════════════╗");
                        Console.WriteLine($"   ║ HP: {HeroSkills3.HP}       ║");
                        Console.WriteLine($"   ║ ST: {HeroSkills3.Stamina}       ║");
                        Console.WriteLine("   ╚══════════════╝\n");
                        Console.WriteLine("   BLACK NIGGANSTER  ");
                        Console.WriteLine("   ╔══════════════╗");
                        Console.WriteLine($"   ║ HP: {MonsterSkills.HP}       ║");
                        Console.WriteLine("   ╚══════════════╝");
                        Console.WriteLine("\nYour turn to attack");
                        Console.WriteLine($"\nCHOOSE AN ATTACK: " +
                            $"\n[1]Fire Magic : FireBall[30 ST] " +
                            $"\n[2]Ice Magic : Ice Nova[35 ST] " +
                            $"\n[3]Ultimate : Arcane Magic[45 ST]" +
                            $"\n[B]Basic Attack[10 ST]\n" +
                            $"\nMISCELANOUS" +
                            $"\n[P]Skip Turn(+20 ST)" +
                            $"\n[Z]HP POTION[{HeroPots.HP_Pots}]" +
                            $"\n[X]STAMINA POTION[{HeroPots.ST_Pots}]");
                    }
                    Console.WriteLine($"\nGold : {Hero_Money}");
                    string HeroTurn = Console.ReadLine();
                    if (HeroSkills.Stamina > 10)
                    {
                        switch (HeroTurn.ToUpper())
                        {
                            //SKILL1
                            case "1":
                                //BERSERKER S1
                                if (User_Class == "1")
                                {
                                    
                                    if (HeroSkills.Stamina >= 20)
                                    {
                                        if (HeroPots.BloodThirst_User == true)
                                        {
                                            HeroSkills.HP += (0.1 * MonsterSkills.HP);                                       
                                            MonsterSkills.HP -= HeroSkills.FirstSkill;
                                            Console.WriteLine($"You dealt [{HeroSkills.FirstSkill}] Damage to BLACK NIGGANSTER");
                                            Console.WriteLine($"{user_name.ToUpper()} uses Divine Sunderer");
                                            Thread.Sleep(500);
                                            Console.WriteLine($"You healed: " + (0.1 * MonsterSkills.HP));
                                            HeroSkills.Stamina -= 20;
                                        }
                                        else
                                        {
                                            Console.WriteLine($"{user_name.ToUpper()} uses Divine Sunderer");
                                            MonsterSkills.HP -= HeroSkills.FirstSkill;
                                            Thread.Sleep(500);
                                            Console.WriteLine($"You dealt [{HeroSkills.FirstSkill}] Damage to BLACK NIGGANSTER");
                                            HeroSkills.Stamina -= 20;
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("Not Enough Stamina");
                                        Thread.Sleep(500);
                                        Console.Clear();
                                        continue;
                                    }
                                }
                                //ASSASIN S1
                                else if (User_Class == "2")
                                {
                                    if (HeroSkills2.Stamina >= 25)
                                    {
                                        if (HeroPots.BloodThirst_User == true)
                                        {
                                            HeroSkills2.HP += (0.1 * MonsterSkills.HP);
                                            MonsterSkills.HP -= HeroSkills2.FirstSkill;
                                            Console.WriteLine($"{user_name.ToUpper()} uses Deadly Lounge");
                                            Console.WriteLine($"You dealt [{HeroSkills2.FirstSkill}] Damage to BLACK NIGGANSTER");
                                            Thread.Sleep(500);
                                            Console.WriteLine($"You healed: " + (0.1 * MonsterSkills.HP));
                                            HeroSkills2.Stamina -= 25;
                                        }
                                        else
                                        {
                                            Console.WriteLine($"{user_name.ToUpper()} uses Deadly Lounge");
                                            MonsterSkills.HP -= HeroSkills2.FirstSkill;
                                            Thread.Sleep(500);
                                            Console.WriteLine($"You dealt [{HeroSkills2.FirstSkill}] Damage to BLACK NIGGANSTER");
                                            HeroSkills2.Stamina -= 25;
                                        }                                     
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not Enough Stamina");
                                        Thread.Sleep(500);
                                        Console.Clear();
                                        continue;
                                    }
                                }
                                //MAGE S1
                                else if (User_Class == "3")
                                {
                                    if (HeroSkills2.Stamina >= 25)
                                    {
                                        if (HeroPots.BloodThirst_User == true)
                                        {
                                            HeroSkills3.HP += (0.1 * MonsterSkills.HP);
                                            MonsterSkills.HP -= HeroSkills3.FirstSkill;
                                            Console.WriteLine($"{user_name.ToUpper()} uses Fire Magic: Fireball");
                                            Console.WriteLine($"You dealt [{HeroSkills3.FirstSkill}] Damage to BLACK NIGGANSTER");
                                            Thread.Sleep(500);
                                            Console.WriteLine($"You healed: " + (0.1 * MonsterSkills.HP));
                                            HeroSkills3.Stamina -= 30;
                                        }
                                        else
                                        {
                                            Console.WriteLine($"{user_name.ToUpper()} uses Fire Magic: Fireball");
                                            MonsterSkills.HP -= HeroSkills2.FirstSkill;
                                            Thread.Sleep(500);
                                            Console.WriteLine($"You dealt [{HeroSkills3.FirstSkill}] Damage to BLACK NIGGANSTER");
                                            HeroSkills3.Stamina -= 30;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not Enough Stamina");
                                        Thread.Sleep(500);
                                        Console.Clear();
                                        continue;
                                    }
                                }
                                break;
                                //SKILL 2
                            case "2":
                                //BERSERKER S2
                                if (User_Class == "1")
                                {
                                    if (HeroSkills.Stamina >= 30)
                                    {
                                        if (HeroPots.BloodThirst_User == true)
                                        {
                                            HeroSkills.HP += (0.1 * MonsterSkills.HP);
                                            MonsterSkills.HP -= HeroSkills.FirstSkill;
                                            Console.WriteLine($"{user_name.ToUpper()} uses Divine Sunderer");
                                            Console.WriteLine($"You dealt [{HeroSkills.SecondSkill}] Damage to BLACK NIGGANSTER");
                                            Thread.Sleep(500);
                                            Console.WriteLine($"You healed: " + (0.1 * MonsterSkills.HP));
                                            HeroSkills.Stamina -= 30;
                                        }
                                        else
                                        {
                                            Console.WriteLine($"{user_name.ToUpper()} uses Divine Sunderer");
                                            MonsterSkills.HP -= HeroSkills.SecondSkill;
                                            Thread.Sleep(500);
                                            Console.WriteLine($"You dealt [{HeroSkills.SecondSkill}] Damage to BLACK NIGGANSTER");
                                            HeroSkills.Stamina -= 30;
                                        }
                                
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not Enough Stamina");
                                        Thread.Sleep(500);
                                        Console.Clear();
                                        continue;
                                    }
                                }
                                //ASSASIN S2
                                else if (User_Class == "2")
                                {
                                    if (HeroSkills2.Stamina >= 32)
                                    {
                                        if (HeroPots.BloodThirst_User == true)
                                        {
                                            HeroSkills2.HP += (0.1 * MonsterSkills.HP);
                                            MonsterSkills.HP -= HeroSkills2.FirstSkill;
                                            Console.WriteLine($"{user_name.ToUpper()} uses Shadow Strike");
                                            Console.WriteLine($"You dealt [{HeroSkills2.SecondSkill}] Damage to BLACK NIGGANSTER");
                                            Thread.Sleep(500);
                                            Console.WriteLine($"You healed: " + (0.1 * MonsterSkills.HP));
                                            HeroSkills2.Stamina -= 32;
                                        }
                                        else
                                        {
                                            Console.WriteLine($"{user_name.ToUpper()} uses Shadow Strike");
                                            MonsterSkills.HP -= HeroSkills2.SecondSkill;
                                            Thread.Sleep(500);
                                            Console.WriteLine($"You dealt [{HeroSkills2.SecondSkill}] Damage to BLACK NIGGANSTER");
                                            HeroSkills2.Stamina -= 32;
                                        }
                                       
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not Enough Stamina");
                                        Thread.Sleep(500);
                                        Console.Clear();
                                        continue;
                                    }
                                }
                                //MAGE S2
                                else if (User_Class == "3")
                                {
                                    if (HeroSkills2.Stamina >= 35)
                                    {
                                        if (HeroPots.BloodThirst_User == true)
                                        {
                                            HeroSkills3.HP += (0.1 * MonsterSkills.HP);
                                            MonsterSkills.HP -= HeroSkills3.FirstSkill;
                                            Console.WriteLine($"{user_name.ToUpper()} uses Ice Magic: Ice Nova");
                                            Console.WriteLine($"You dealt [{HeroSkills3.SecondSkill}] Damage to BLACK NIGGANSTER");
                                            Thread.Sleep(500);
                                            Console.WriteLine($"You healed: " + (0.1 * MonsterSkills.HP));
                                            HeroSkills3.Stamina -= 35;
                                        }
                                        else
                                        {
                                            Console.WriteLine($"{user_name.ToUpper()} uses Ice Magic: Ice Nova");
                                            MonsterSkills.HP -= HeroSkills2.SecondSkill; 
                                            Console.WriteLine($"You dealt [{HeroSkills3.SecondSkill}] Damage to BLACK NIGGANSTER");
                                            Thread.Sleep(500);
                                            HeroSkills3.Stamina -= 35;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not Enough Stamina");
                                        Thread.Sleep(500);
                                        Console.Clear();
                                        continue;
                                    }
                                }
                                break;
                            //SKILL3
                            case "3":
                                //BERSERKER S3
                                if (User_Class == "1")
                                {
                                    if (HeroSkills.Stamina >= 45)
                                    {
                                        if (HeroPots.BloodThirst_User == true)
                                        {
                                            HeroSkills.HP += (0.1 * MonsterSkills.HP);
                                            MonsterSkills.HP -= HeroSkills.FirstSkill;
                                            Console.WriteLine($"{user_name.ToUpper()} uses Ultimate Slash");
                                            Console.WriteLine($"You dealt [{HeroSkills.ThirdSkill}] Damage to BLACK NIGGANSTER");
                                            Thread.Sleep(500);
                                            Console.WriteLine($"You healed: " + (0.1 * MonsterSkills.HP));
                                            HeroSkills.Stamina -= 45;
                                        }
                                        else
                                        {
                                            Console.WriteLine($"{user_name.ToUpper()} uses Ultimate Slash");
                                            MonsterSkills.HP -= HeroSkills.ThirdSkill;
                                            Thread.Sleep(500);
                                            Console.WriteLine($"You dealt [{HeroSkills.ThirdSkill}] Damage to BLACK NIGGANSTER");
                                            HeroSkills.Stamina -= 45;
                                        }
                                        
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not Enough Stamina");
                                        Thread.Sleep(500);
                                        Console.Clear();
                                        continue;
                                    }
                                }
                                //ASSASIN S3
                                else if (User_Class == "2")
                                {
                                    if (HeroSkills2.Stamina >= 35)
                                    {
                                        if (HeroPots.BloodThirst_User == true)
                                        {
                                            HeroSkills2.HP += (0.1 * MonsterSkills.HP);
                                            MonsterSkills.HP -= HeroSkills2.FirstSkill;
                                            Console.WriteLine($"{user_name.ToUpper()} uses Ultimate Lethal Poison");
                                            Console.WriteLine($"You dealt [{HeroSkills2.ThirdSkill}] Damage to BLACK NIGGANSTER");
                                            Thread.Sleep(500);
                                            Console.WriteLine($"You healed: " + (0.1 * MonsterSkills.HP));
                                            HeroSkills2.Stamina -= 35;
                                        }
                                        else
                                        {
                                            Console.WriteLine($"{user_name.ToUpper()} uses Ultimate Lethal Poison");
                                            MonsterSkills.HP -= HeroSkills2.ThirdSkill;
                                            Console.WriteLine($"You dealt [{HeroSkills2.ThirdSkill}] Damage to BLACK NIGGANSTER");
                                            HeroSkills2.Stamina -= 35;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not Enough Stamina");
                                        Thread.Sleep(500);
                                        Console.Clear();
                                        continue;
                                    }
                                }
                                //MAGE S3
                                else if (User_Class == "3")
                                {
                                    if (HeroSkills2.Stamina >= 45)
                                    {
                                        if (HeroPots.BloodThirst_User == true)
                                        {
                                            HeroSkills3.HP += (0.1 * MonsterSkills.HP);
                                            MonsterSkills.HP -= HeroSkills3.FirstSkill;
                                            Console.WriteLine($"{user_name.ToUpper()} uses Ultimate: Arcane Magic");
                                            Console.WriteLine($"You dealt [{HeroSkills3.ThirdSkill}] Damage to BLACK NIGGANSTER");
                                            Thread.Sleep(500);
                                            Console.WriteLine($"You healed: " + (0.1 * MonsterSkills.HP));
                                            HeroSkills3.Stamina -= 45;
                                        }
                                        else
                                        {
                                            Console.WriteLine($"{user_name.ToUpper()} uses Ultimate: Arcane Magic");
                                            MonsterSkills.HP -= HeroSkills2.ThirdSkill;
                                            Thread.Sleep(500);
                                            Console.WriteLine($"You dealt [{HeroSkills3.ThirdSkill}] Damage to BLACK NIGGANSTER");
                                            HeroSkills3.Stamina -= 45;
                                        }
                                     
                                    }
                                    else
                                    {
                                        Console.WriteLine("Not Enough Stamina");
                                        Thread.Sleep(500);
                                        Console.Clear();
                                        continue;
                                    }
                                }
                                break;
                            case "B":
                                if (HeroSkills.Stamina >= 10)
                                {
                                    if (User_Class == "1")
                                    {
                                        if (HeroSkills.Divine_User == true)
                                        {
                                            if (HeroPots.BloodThirst_User == true)
                                            {
                                                HeroSkills.HP += (0.1 * MonsterSkills.HP);
                                                MonsterSkills.HP -= HeroSkills.FirstSkill;
                                                Console.WriteLine($"{user_name.ToUpper()} uses Divine Attack");
                                                Thread.Sleep(1000);
                                                Console.WriteLine($"You dealt [{HeroSkills.Divine_Damage}]Damage to BLACK NIGGANSTER");
                                                HeroSkills.Stamina -= 10;
                                            }
                                            else
                                            {
                                                Console.WriteLine($"{user_name.ToUpper()} uses Divine Attack");
                                                MonsterSkills.HP -= HeroSkills.Divine_Damage;
                                                Console.WriteLine($"You dealt [{HeroSkills.Divine_Damage}]Damage to BLACK NIGGANSTER");
                                                Thread.Sleep(500);
                                                Console.WriteLine($"You healed: " + (0.1 * MonsterSkills.HP));
                                                HeroSkills.Stamina -= 10;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine($"{user_name.ToUpper()} uses Basic Attack");
                                            MonsterSkills.HP -= HeroSkills.Basic;
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"You dealt [{HeroSkills.Basic}]]Damage to BLACK NIGGANSTER");
                                            HeroSkills.Stamina -= 10;
                                        }
                                    }           
                                    else if (User_Class == "2")
                                    {
                                        if (HeroSkills.Bloodlust_User == true)
                                        {
                                            if (HeroPots.BloodThirst_User == true)
                                            {
                                                HeroSkills.HP += (0.1 * MonsterSkills.HP);
                                                MonsterSkills.HP -= HeroSkills.FirstSkill;
                                                Console.WriteLine($"{user_name.ToUpper()} uses Bloodlust Pierce");
                                                Console.WriteLine($"You dealt [{HeroSkills2.Bloodlust_Damage}]Damage to BLACK NIGGANSTER");
                                                Thread.Sleep(500);
                                                Console.WriteLine($"You healed: " + (0.1 * MonsterSkills.HP));
                                                HeroSkills.Stamina -= 10;
                                            }
                                            else
                                            {
                                                Console.WriteLine($"{user_name.ToUpper()} uses Bloodlust Pierce");
                                                MonsterSkills.HP -= HeroSkills2.Bloodlust_Damage;
                                                Thread.Sleep(1000);
                                                Console.WriteLine($"You dealt [{HeroSkills2.Bloodlust_Damage}]Damage to BLACK NIGGANSTER");
                                                HeroSkills.Stamina -= 10;
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine($"{user_name.ToUpper()} uses Basic Attack");
                                            MonsterSkills.HP -= HeroSkills2.Basic;
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"You dealt [{HeroSkills2.Basic}]]Damage to BLACK NIGGANSTER");
                                            HeroSkills.Stamina -= 15;
                                        }
                                    }
                                    else if (User_Class == "3")
                                    {
                                        if (HeroSkills.Arcane_User == true)
                                        {
                                            if (HeroPots.BloodThirst_User == true)
                                            {
                                                Console.WriteLine($"{user_name.ToUpper()} uses Arcane Burst Magic");
                                                MonsterSkills.HP -= HeroSkills3.Arcane_Damage;
                                                Console.WriteLine($"You dealt [{HeroSkills3.Arcane_Damage}]Damage to BLACK NIGGANSTER");
                                                Thread.Sleep(1000);
                                                Console.WriteLine($"You healed: " + (0.1 * MonsterSkills.HP));
                                                HeroSkills.Stamina -= 10;
                                            }
                                            else
                                            {
                                                HeroSkills.HP += (0.1 * MonsterSkills.HP);
                                                MonsterSkills.HP -= HeroSkills.FirstSkill;
                                                Console.WriteLine($"{user_name.ToUpper()} uses Arcane Burst Magic");
                                                MonsterSkills.HP -= HeroSkills3.Arcane_Damage;
                                                Thread.Sleep(1000);
                                                Console.WriteLine($"You dealt [{HeroSkills3.Arcane_Damage}]Damage to BLACK NIGGANSTER");
                                                HeroSkills.Stamina -= 10;
                                            }
                                          
                                        }
                                        else
                                        {
                                            Console.WriteLine($"{user_name.ToUpper()} uses Basic Attack");
                                            MonsterSkills.HP -= HeroSkills3.Basic;
                                            Thread.Sleep(1000);
                                            Console.WriteLine($"You dealt [{HeroSkills3.Basic}]]Damage to BLACK NIGGANSTER");
                                            HeroSkills.Stamina -= 10;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Not Enough Stamina");
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    continue;
                                }
                                    break;
                            case "P":
                                Console.WriteLine($"{user_name.ToUpper()} skips turn");
                                HeroSkills.Stamina += 10;
                                HeroSkills2.Stamina += 10;
                                HeroSkills3.Stamina += 10;
                                break;
                            //CHEAT CODE
                            case "1314":
                                Console.WriteLine("You unlocked hidden cheatcode!");
                                MonsterSkills.HP -= MonsterSkills.HP;
                                Thread.Sleep(1000);
                                Console.WriteLine($"You dealt [-{HeroPots.Cheat}] Insane damage to BLACK NIGGANSTER");
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
                                    HeroSkills2.HP += 20;
                                    HeroSkills2.HP += 20;
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
                                    HeroSkills2.Stamina += 20;
                                    HeroSkills3.Stamina += 20;
                                    Console.WriteLine($"You gained 20 ST, Total ST: {HeroSkills.Stamina}");
                                }
                                break;
                            default:
                                Console.WriteLine("You missed!, Choose between [4] Attacks");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You ran out of stamina, you cant attack this turn");
                    }
                    //REGEN HERO STAMINA EACH TURN
                    HeroSkills.Stamina += HeroSkills.Stamina_regen;
                    HeroSkills2.Stamina += HeroSkills2.Stamina_regen;
                    HeroSkills3.Stamina += HeroSkills3.Stamina_regen;

                    Thread.Sleep(1000);
                    Random random = new Random();
                    switch (random.Next(1, 5))
                    {
                        case 1:
                            Console.WriteLine("Monster uses Bite");
                            HeroSkills.HP -= MonsterSkills.FirstSkill;
                            HeroSkills2.HP -= MonsterSkills.FirstSkill;
                            HeroSkills3.HP -= MonsterSkills.FirstSkill;
                            Thread.Sleep(500);
                            Console.WriteLine($"Bite dealt [{MonsterSkills.FirstSkill}] Damage");
                            break;
                        case 2:
                            Console.WriteLine("Monster uses Dark Slash");
                            HeroSkills.HP -= MonsterSkills.SecondSkill;
                            HeroSkills2.HP -= MonsterSkills.FirstSkill;
                            HeroSkills3.HP -= MonsterSkills.FirstSkill;
                            Thread.Sleep(500);
                            Console.WriteLine($"Dark Slash  dealt [{MonsterSkills.SecondSkill}] Damage");
                            break;
                        case 3:
                            Console.WriteLine("Monster uses Hydro Blast");
                            HeroSkills.HP -= MonsterSkills.ThirdSkill;
                            HeroSkills2.HP -= MonsterSkills.FirstSkill;
                            HeroSkills3.HP -= MonsterSkills.FirstSkill;
                            Thread.Sleep(500);
                            Console.WriteLine($"Hydro Blast dealt [{MonsterSkills.ThirdSkill}] ] Damage");
                            break;
                        case 4:
                            Console.WriteLine("Monster uses Tackle");
                            HeroSkills.HP -= MonsterSkills.Basic;
                            HeroSkills2.HP -= MonsterSkills.FirstSkill;
                            HeroSkills3.HP -= MonsterSkills.FirstSkill;
                            Thread.Sleep(500);
                            Console.WriteLine($"Tackle dealt [{MonsterSkills.ThirdSkill}] ] Damage");
                            break;
                    }
                    Thread.Sleep(500);
                    Console.Clear();
                    //HERO LOSES
                    if (HeroSkills.HP <= 0)
                    {
                        Console.WriteLine("Hero Defeated!");
                        Console.Clear();
                        Console.WriteLine("Would you like to try again? : Y or N");
                        //RESETS HERO && MONSTER ATTRIBUTES WHEN LOSE
                        HeroSkills.HP = 100;
                        MonsterSkills.HP = 75;
                        HeroSkills.Stamina = 50;
                        string try_again = Console.ReadLine();
                        if (try_again == "Y".ToLower())
                        {

                        }
                        else
                        {
                            Console.WriteLine("Thanks for playing!");
                            Thread.Sleep(2000);
                            break;
                        }
                    }
                    if (MonsterSkills.HP <= 0)
                    {
                        Console.WriteLine("Hero Wins!");
                        floor++;
                        if (floor % 5 == 0)
                        {
                            Console.WriteLine("You reached a Boss Stage! Careful");
                        }
                        Hero_Money += 2500;
                        Console.WriteLine($"You earned 25 Gold, Your total Gold is {Hero_Money}");

                        if (HeroPots.InfinityEdge_User == true)
                        {
                            double InfinityEdge_Multiplier = 1.3;
                            //ADD BERSERKER STATS PER WIN
                            HeroSkills.Stamina = 60 + (floor * 0.4 * InfinityEdge_Multiplier);
                            HeroSkills.Stamina_regen = 12 + (floor * 0.4 * InfinityEdge_Multiplier);
                            HeroSkills.HP = 120 + (floor * 0.4 * InfinityEdge_Multiplier);
                            HeroSkills.Basic = 15 + (floor * 0.4 * InfinityEdge_Multiplier);
                            HeroSkills.FirstSkill = 25 + (floor * 0.4 * InfinityEdge_Multiplier);
                            HeroSkills.SecondSkill = 30 + (floor * 0.4 * InfinityEdge_Multiplier);
                            HeroSkills.ThirdSkill = 55 + (floor * 0.4) * InfinityEdge_Multiplier;
                            HeroSkills.Divine_Damage = 30 + (floor * 0.4 * InfinityEdge_Multiplier);
                            //ADD ASSASIN STATS PER WIN
                            HeroSkills2.Stamina = 50 + (floor * 0.4 * InfinityEdge_Multiplier);
                            HeroSkills2.Stamina_regen = 18 + (floor * 0.4 * InfinityEdge_Multiplier);
                            HeroSkills2.HP = 90 + (floor * 0.4 * InfinityEdge_Multiplier);
                            HeroSkills2.Basic = 18 + (floor * 0.4 * InfinityEdge_Multiplier);
                            HeroSkills2.FirstSkill = 20 + (floor * 0.4 * InfinityEdge_Multiplier);
                            HeroSkills2.SecondSkill = 35 + (floor * 0.4 * InfinityEdge_Multiplier);
                            HeroSkills2.ThirdSkill = 50 + (floor * 0.4 * InfinityEdge_Multiplier);
                            HeroSkills2.Bloodlust_Damage = 36 + (floor * 0.4 * InfinityEdge_Multiplier);
                            //ADD MAGE STATS PER WIN
                            HeroSkills3.Stamina = 55 + (floor * 0.4 * InfinityEdge_Multiplier);
                            HeroSkills3.Stamina_regen = 15 + (floor * 0.4 * InfinityEdge_Multiplier);
                            HeroSkills3.HP = 80 + (floor * 0.4 * InfinityEdge_Multiplier);
                            HeroSkills3.Basic = 12 + (floor * 0.4 * InfinityEdge_Multiplier);
                            HeroSkills3.FirstSkill = 35 + (floor * 0.4 * InfinityEdge_Multiplier);
                            HeroSkills3.SecondSkill = 45 + (floor * 0.4 * InfinityEdge_Multiplier);
                            HeroSkills3.ThirdSkill = 60 + (floor * 0.4 * InfinityEdge_Multiplier);
                            HeroSkills3.Arcane_Damage = 25 + (floor * 0.4 * InfinityEdge_Multiplier);
                        }
                        else
                        {
                            //ADD BERSERKER STATS PER WIN
                            HeroSkills.Stamina = 60 + (floor * 0.4);
                            HeroSkills.Stamina_regen = 12 + (floor * 0.4);
                            HeroSkills.HP = 120 + (floor * 0.4);
                            HeroSkills.Basic = 15 + (floor * 0.4);
                            HeroSkills.FirstSkill = 25 + (floor * 0.4);
                            HeroSkills.SecondSkill = 30 + (floor * 0.4);
                            HeroSkills.ThirdSkill = 55 + (floor * 0.4);
                            HeroSkills.Divine_Damage = 30 + (floor * 0.4);
                            //ADD ASSASIN STATS PER WIN
                            HeroSkills2.Stamina = 50 + (floor * 0.4);
                            HeroSkills2.Stamina_regen = 18 + (floor * 0.4);
                            HeroSkills2.HP = 90 + (floor * 0.4);
                            HeroSkills2.Basic = 18 + (floor * 0.4);
                            HeroSkills2.FirstSkill = 20 + (floor * 0.4);
                            HeroSkills2.SecondSkill = 35 + (floor * 0.4);
                            HeroSkills2.ThirdSkill = 50 + (floor * 0.4);
                            HeroSkills2.Bloodlust_Damage = 36 + (floor * 0.4);
                            //ADD MAGE STATS PER WIN
                            HeroSkills3.Stamina = 55 + (floor * 0.4);
                            HeroSkills3.Stamina_regen = 15 + (floor * 0.4);
                            HeroSkills3.HP = 80 + (floor * 0.4);
                            HeroSkills3.Basic = 12 + (floor * 0.4);
                            HeroSkills3.FirstSkill = 35 + (floor * 0.4);
                            HeroSkills3.SecondSkill = 45 + (floor * 0.4);
                            HeroSkills3.ThirdSkill = 60 + (floor * 0.4);
                            HeroSkills3.Arcane_Damage = 25 + (floor * 0.4);
                        }                   


                        //ADDS ATTRIBUTES EVERY FLOOR TO THE MONSTER
                        MonsterSkills.Basic = 5 + (floor * 0.3);
                        MonsterSkills.FirstSkill = 10 + (floor * 0.3);
                        MonsterSkills.SecondSkill = 15 + (floor * 0.3);
                        MonsterSkills.ThirdSkill = 10 + (floor * 0.3);
                        MonsterSkills.HP = 75 + (floor * 5);
                        if (floor % 5 == 0)
                        {
                            Console.WriteLine("BOSS STAGE!");
                            MonsterSkills.Basic = 5 + (floor * 1.5);
                            MonsterSkills.FirstSkill = 10 + (floor * 1.5);
                            MonsterSkills.SecondSkill = 15 + (floor * 1.5);
                            MonsterSkills.ThirdSkill = 10 + (floor * 1.5);
                            MonsterSkills.HP = 75 + (floor * 10);
                        }

                        //SHOP OR NEXT FLOOR
                        Console.WriteLine("[N]Next Floor\n[S]Shop");
                        string win = Console.ReadLine();
                        Thread.Sleep(500);
                        Console.Clear();
                        if (win == "N".ToLower())
                        {
                            continue;
                        }
                        else if (win == "S".ToLower())
                        {
                            Console.WriteLine("WELCOME TO SHOP\n\t" +
                                "[1]Health Potion : 15 Gold\n\t" +
                                "[2]Stamina Potion : 15 Gold \n\t" +
                                "[3]Divine Sword : 150 Gold\n\t" +
                                "[4]Arcane Staff : 150 Gold\n\t" +
                                "[5]Bloodlust Dagger : 150 Gold\n\t" +
                                "[6]Infinity Edge : 500 Gold\n\t" +
                                "[7]Bloodthirster : 650 Gold\n\t" +
                                "[X]Exit"); ;
                            string hp_st = Console.ReadLine();
                            int HP_Price = 15;
                            int ST_Price = 15;
                            int Divine_Sword = 150;
                            int Arcane_Staff = 150;
                            int Bloodlust_Dagger = 150;
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
                            else if (hp_st == "X".ToLower())
                            {
                                Thread.Sleep(500);
                                Console.Clear();
                            }
                            else if (hp_st == "3")
                            {
                                if (User_Class == "1")
                                {
                                    if (Hero_Money >= 150)
                                    {
                                        Console.WriteLine("Purchased Divine Sword");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("Divine Sword chose a worthy champion");
                                        Thread.Sleep(1500);
                                        Console.WriteLine("Your basic sword transformed into Divine Sword!");
                                        HeroSkills.Divine_User = true;
                                        Hero_Money -= 150;
                                        Thread.Sleep(1500);
                                        Console.Clear();
                                    }
                                    else if (Hero_Money <= 149)
                                    {
                                        Console.WriteLine("You don't have enough gold");
                                        Thread.Sleep(500);
                                        Console.Clear();
                                        continue;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Exclusive for [BERSERKER] Class Only!");
                                    Console.WriteLine("GO AWAY!");
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    continue;
                                }
                            }
                            else if (hp_st == "4")
                            {
                                if (User_Class == "3")
                                {
                                    if (Hero_Money >= 150)
                                    {
                                        Console.WriteLine("Purchased Arcane Staff");
                                        Thread.Sleep(1000);
                                        Console.WriteLine("A mysterious fills the air as you stumbled upon hidden magic.");
                                        Thread.Sleep(1500);
                                        Console.WriteLine("Your wooden staff transformed into Arcane Staff!");
                                        HeroSkills.Arcane_User = true;
                                        Hero_Money -= 150;
                                        Thread.Sleep(1500);
                                        Console.Clear();
                                    }
                                    else if (Hero_Money <= 149)
                                    {
                                        Console.WriteLine("You don't have enough gold");
                                        Thread.Sleep(500);
                                        Console.Clear();
                                        continue;
                                    }                              
                                }
                                else
                                {
                                    Console.WriteLine("Exclusive for [MAGE] Class Only!");
                                    Console.WriteLine("GO AWAY!");
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    continue;
                                }
                            }                          
                            else if (hp_st == "5")
                            {
                                if (Hero_Money >= 150)
                                {
                                    Console.WriteLine("Purchased Bloodlust Dagger");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("This cursed blade seems to hunger for blood");
                                    Thread.Sleep(1500);
                                    Console.WriteLine("Your iron dagger transformed into Bloodlust Dagger!");
                                    HeroSkills.Bloodlust_User = true;
                                    Hero_Money -= 150;
                                    Thread.Sleep(1500);
                                    Console.Clear(); 
                                }
                                else if (Hero_Money <= 149)
                                {
                                    Console.WriteLine("You don't have enough gold");
                                    Thread.Sleep(500);
                                    Console.Clear();
                                    continue;
                                }
                                else
                                {
                                    Console.WriteLine("Exclusive for [ASSASIN] Class Only!");
                                    Console.WriteLine("GO AWAY!");
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    continue;
                                }
                            }           
                            else if (hp_st == "6")
                            {
                                if (Hero_Money >= 500)
                                {
                                    HeroPots.InfinityEdge_User = true;
                                    Console.WriteLine("You purchased INFINITY EDGE");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("You gained 1.3x Universal Damage!");
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                }
                                else if (Hero_Money <= 499)
                                {
                                    Console.WriteLine("You don't have enough gold");
                                    Thread.Sleep(500);
                                    Console.Clear();
                                    continue;
                                }

                            }
                            else if (hp_st == "7")
                            {
                                if (Hero_Money >= 650)
                                {
                                    HeroPots.BloodThirst_User = true;
                                    Console.WriteLine("You purchased BLOODTHIRSTER");
                                    Thread.Sleep(1000);
                                    Console.WriteLine("You 10% LifeSteal to enemies!");
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                }
                                else if (Hero_Money <= 649)
                                {
                                    Console.WriteLine("You don't have enough gold");
                                    Thread.Sleep(500);
                                    Console.Clear();
                                    continue;
                                }

                            }
                        }

                        else
                        {
                            Console.WriteLine("Choose between the options!");
                            continue;
                        }
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
        public double Divine_Damage { get; set; }
        public bool Divine_User { get; set; }
        public double Arcane_Damage { get; set; }
        public bool Arcane_User { get; set; }
        public double Bloodlust_Damage { get; set; }
        public bool Bloodlust_User { get; set; }
        public int Cheat { get; set; }
        public double InfinityEdge_Buff { get; set; }
        public bool InfinityEdge_User { get; set; }
        public bool BloodThirst_User { get; set; }
        public double  BloodThirst_Lifesteal { get; set; }
    }
}

