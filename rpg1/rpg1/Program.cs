using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
 


namespace rpg1
{

    

    internal class Program
    {
        
       
        struct player
        {
            public string chad;
            public float offense;
            public float defense;
            public float hp;
            public float gold;
            public int exp;
        }

        struct items
        {
            public string name;
            public int offense;
            public int defense;
            public string explanation;
            public int gold;
            public bool get;
            public bool mount;
        }

        

        static void Main(string[] args)
        {


            Random rand = new Random();


            float statoffense = 0;
            float statdefense = 0;
            player stat1;
            stat1.chad = "전사";
            stat1.offense = 10;
            stat1.defense = 5;
            stat1.hp = 100;
            stat1.gold = 1500;
            stat1.exp = 10;

            items 무쇠갑옷;
            무쇠갑옷.name = "무쇠갑옷";
            무쇠갑옷.offense = 0;
            무쇠갑옷.defense = 5;
            무쇠갑옷.explanation = "무쇠로 만들어져 튼튼한 갑옷입니다.";
            무쇠갑옷.gold = 1300;
            무쇠갑옷.get = false;
            무쇠갑옷.mount = false;

            items 스파르타의창;
            스파르타의창.name = "스파르타의 창";
            스파르타의창.offense = 7;
            스파르타의창.defense = 0;
            스파르타의창.explanation = "스파르타의 전사들이 사용했다는 전설의 창입니다.";
            스파르타의창.gold = 2000;
            스파르타의창.get = false;
            스파르타의창.mount = false;

            items 낡은검;
            낡은검.name = "낡은 검";
            낡은검.offense = 2;
            낡은검.defense = 0;
            낡은검.explanation = "쉽게 볼 수 있는 낡은 검 입니다.";
            낡은검.gold = 600;
            낡은검.get = false;
            낡은검.mount = false;

            items 수련자갑옷;
            수련자갑옷.name = "수련자 갑옷";
            수련자갑옷.offense = 0;
            수련자갑옷.defense = 5;
            수련자갑옷.explanation = "수련에 도움을 주는 갑옷입니다.";
            수련자갑옷.gold = 1000;
            수련자갑옷.get = false;
            수련자갑옷.mount = false;


            items 청동도끼;
            청동도끼.name = "청동 도끼";
            청동도끼.offense = 5;
            청동도끼.defense = 0;
            청동도끼.explanation = "어디선가 사용됐던거 같은 도끼입니다.";
            청동도끼.gold = 1500;
            청동도끼.get = false;
            청동도끼.mount = false;


            items 스파르타의갑옷;
            스파르타의갑옷.name = "스파르타의갑옷";
            스파르타의갑옷.offense = 0;
            스파르타의갑옷.defense = 15;
            스파르타의갑옷.explanation = "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.";
            스파르타의갑옷.gold = 3500;
            스파르타의갑옷.get = false;
            스파르타의갑옷.mount = false;

            items 우동의두꺼운지방;
            우동의두꺼운지방.name = "우동의두꺼운지방";
            우동의두꺼운지방.offense = 0;
            우동의두꺼운지방.defense = 30;
            우동의두꺼운지방.explanation = "우동이의 두꺼운 지방이 모든공격을 막는다.";
            우동의두꺼운지방.gold = 4500;
            우동의두꺼운지방.get = false;
            우동의두꺼운지방.mount = false;

            
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.\n이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
            


            enter();



            
            




            void enter()
            {
                Console.WriteLine("1.상태 보기 \n2.인벤토리 \n3.상점\n4.던전입장\n5.휴식하기");
                Console.WriteLine("원하는 행동을 입력해주세요.");
                string input1 = Console.ReadLine();
                if (input1 == "1")
                {
                    statinfo();
                }
                else if (input1 == "2")
                {
                    inventory();
                }
                else if (input1 == "3")
                {
                    shop();
                }
                else if (input1 == "4")
                {
                    dungeon();
                }
                else if (input1 == "5")
                {
                    rest();
                }


                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                    enter();
                }


            }


            void statinfo()
            {
                Console.WriteLine("chad : " + stat1.chad);
                Console.WriteLine("공격력 : " + stat1.offense + "(+" + statoffense + ")");
                Console.WriteLine("방어력 : " + stat1.defense + "(+" + statdefense + ")");
                Console.WriteLine("체력 : " + stat1.hp);
                Console.WriteLine("Gold : " + stat1.gold + "g");
                enter();
            }

            void inventory()
            {
                Console.WriteLine("[인벤토리]");
                if (수련자갑옷.get == true)
                {
                    if (수련자갑옷.mount == true)
                    {
                        Console.WriteLine("[E]" + 수련자갑옷.name + "| 방어력 : " + 수련자갑옷.defense + " | " + 수련자갑옷.explanation);
                    }
                    else
                    {
                        Console.WriteLine(수련자갑옷.name + "| 방어력 : " + 수련자갑옷.defense + " | " + 수련자갑옷.explanation);
                    }
                }
                if (무쇠갑옷.get == true)
                {
                    if (무쇠갑옷.mount == true)
                    {
                        Console.WriteLine("[E]" + 무쇠갑옷.name + "| 방어력 : " + 무쇠갑옷.defense + " | " + 무쇠갑옷.explanation);
                    }
                    else
                    {
                        Console.WriteLine(무쇠갑옷.name + "| 방어력 : " + 무쇠갑옷.defense + " | " + 무쇠갑옷.explanation);
                    }
                }
                if (스파르타의갑옷.get == true)
                {
                    if (스파르타의갑옷.mount == true)
                    {
                        Console.WriteLine("[E]" + 스파르타의갑옷.name + "| 방어력 : " + 스파르타의갑옷.defense + " | " + 스파르타의갑옷.explanation);
                    }
                    else
                    {
                        Console.WriteLine(스파르타의갑옷.name + "| 방어력 : " + 스파르타의갑옷.defense + " | " + 스파르타의갑옷.explanation);
                    }
                }
                if (낡은검.get == true)
                {
                    if (낡은검.mount == true)
                    {
                        Console.WriteLine("[E]" + 낡은검.name + "| 공격력 : " + 낡은검.offense + " | " + 낡은검.explanation);
                    }
                    else
                    {
                        Console.WriteLine(낡은검.name + "| 공격력 : " + 낡은검.offense + " | " + 낡은검.explanation);
                    }
                }
                if (청동도끼.get == true)
                {
                    if (청동도끼.mount == true)
                    {
                        Console.WriteLine("[E]" + 청동도끼.name + "| 공격력 : " + 청동도끼.offense + " | " + 청동도끼.explanation);
                    }
                    else
                    {
                        Console.WriteLine(청동도끼.name + "| 공격력 : " + 청동도끼.offense + " | " + 청동도끼.explanation);
                    }
                }
                if (스파르타의창.get == true)
                {
                    if (스파르타의창.mount == true)
                    {
                        Console.WriteLine("[E]" + 스파르타의창.name + "| 공격력 : " + 스파르타의창.offense + " | " + 스파르타의창.explanation);
                    }
                    else
                    {
                        Console.WriteLine(스파르타의창.name + "| 공격력 : " + 스파르타의창.offense + " | " + 스파르타의창.explanation);
                    }
                }
                if (우동의두꺼운지방.get == true)
                {
                    if (우동의두꺼운지방.mount == true)
                    {
                        Console.WriteLine("[E]" + 우동의두꺼운지방.name + "| 방어력 : " + 우동의두꺼운지방.defense + " | " + 우동의두꺼운지방.explanation);
                    }
                    else
                    {
                        Console.WriteLine(우동의두꺼운지방.name + "| 방어력 : " + 우동의두꺼운지방.defense + " | " + 우동의두꺼운지방.explanation);
                    }
                }
                Console.WriteLine("1.장착 관리\n0.나가기");
                string input2 = Console.ReadLine();
                if (input2 == "1")
                {
                    mountManage();
                }
                else if (input2 == "0")
                {
                    enter();
                }
                else
                {
                    inventory();
                }
            }

            void mountManage()
            {
                Console.WriteLine("0. 나가기");
                if (수련자갑옷.get == true)
                {
                    if (수련자갑옷.mount == true)
                    {
                        Console.WriteLine("-1[E]" + 수련자갑옷.name + "| 방어력 : " + 수련자갑옷.defense + " | " + 수련자갑옷.explanation);
                    }
                    else
                    {
                        Console.WriteLine("-1" + 수련자갑옷.name + "| 방어력 : " + 수련자갑옷.defense + " | " + 수련자갑옷.explanation);
                    }
                }
                if (무쇠갑옷.get == true)
                {
                    if (무쇠갑옷.mount == true)
                    {
                        Console.WriteLine("-2[E]" + 무쇠갑옷.name + "| 방어력 : " + 무쇠갑옷.defense + " | " + 무쇠갑옷.explanation);
                    }
                    else
                    {
                        Console.WriteLine("-2" + 무쇠갑옷.name + "| 방어력 : " + 무쇠갑옷.defense + " | " + 무쇠갑옷.explanation);
                    }
                }
                if (스파르타의갑옷.get == true)
                {
                    if (스파르타의갑옷.mount == true)
                    {
                        Console.WriteLine("-3[E]" + 스파르타의갑옷.name + "| 방어력 : " + 스파르타의갑옷.defense + " | " + 스파르타의갑옷.explanation);
                    }
                    else
                    {
                        Console.WriteLine("-3" + 스파르타의갑옷.name + "| 방어력 : " + 스파르타의갑옷.defense + " | " + 스파르타의갑옷.explanation);
                    }
                }
                if (낡은검.get == true)
                {
                    if (낡은검.mount == true)
                    {
                        Console.WriteLine("-4[E]" + 낡은검.name + "| 공격력 : " + 낡은검.offense + " | " + 낡은검.explanation);
                    }
                    else
                    {
                        Console.WriteLine("-4" + 낡은검.name + "| 공격력 : " + 낡은검.offense + " | " + 낡은검.explanation);
                    }
                }
                if (청동도끼.get == true)
                {
                    if (청동도끼.mount == true)
                    {
                        Console.WriteLine("-5[E]" + 청동도끼.name + "| 공격력 : " + 청동도끼.offense + " | " + 청동도끼.explanation);
                    }
                    else
                    {
                        Console.WriteLine("-5" + 청동도끼.name + "| 공격력 : " + 청동도끼.offense + " | " + 청동도끼.explanation);
                    }
                }
                if (스파르타의창.get == true)
                {
                    if (스파르타의창.mount == true)
                    {
                        Console.WriteLine("-6[E]" + 스파르타의창.name + "| 공격력 : " + 스파르타의창.offense + " | " + 스파르타의창.explanation);
                    }
                    else
                    {
                        Console.WriteLine("-6" + 스파르타의창.name + "| 공격력 : " + 스파르타의창.offense + " | " + 스파르타의창.explanation);
                    }
                }
                if (우동의두꺼운지방.get == true)
                {
                    if (우동의두꺼운지방.mount == true)
                    {
                        Console.WriteLine("-7[E]" + 우동의두꺼운지방.name + "| 방어력 : " + 우동의두꺼운지방.defense + " | " + 우동의두꺼운지방.explanation);
                    }
                    else
                    {
                        Console.WriteLine("-7" + 우동의두꺼운지방.name + "| 방어력 : " + 우동의두꺼운지방.defense + " | " + 우동의두꺼운지방.explanation);
                    }
                }
                string input5 = Console.ReadLine();
                if (input5 == "1")
                {
                    무쇠갑옷.mount = false;
                    스파르타의갑옷.mount = false;
                    우동의두꺼운지방.mount = false;
                    if (수련자갑옷.mount == false)
                    {

                        수련자갑옷.mount = true;

                    }
                    else
                    {
                        수련자갑옷.mount = false;

                    }
                }
                if (input5 == "2")
                {
                    수련자갑옷.mount = false;
                    스파르타의갑옷.mount = false;
                    우동의두꺼운지방.mount = false;
                    if (무쇠갑옷.mount == false)
                    {
                        무쇠갑옷.mount = true;

                    }
                    else
                    {
                        무쇠갑옷.mount = false;

                    }
                }
                if (input5 == "3")
                {
                    무쇠갑옷.mount = false;
                    수련자갑옷.mount = false;
                    우동의두꺼운지방.mount = false;
                    if (스파르타의갑옷.mount == false)
                    {
                        스파르타의갑옷.mount = true;

                    }
                    else
                    {
                        스파르타의갑옷.mount = false;

                    }
                }
                if (input5 == "4")
                {
                    청동도끼.mount = false;
                    스파르타의창.mount = false;
                    if (낡은검.mount == false)
                    {
                        낡은검.mount = true;

                    }
                    else
                    {
                        낡은검.mount = false;

                    }
                }
                if (input5 == "5")
                {
                    낡은검.mount = false;
                    스파르타의창.mount = false;
                    if (청동도끼.mount == false)
                    {
                        청동도끼.mount = true;

                    }
                    else
                    {
                        청동도끼.mount = false;

                    }
                }
                if (input5 == "6")
                {

                    청동도끼.mount = false;
                    낡은검.mount = false;
                    if (스파르타의창.mount == false)
                    {
                        스파르타의창.mount = true;

                    }
                    else
                    {
                        스파르타의창.mount = false;

                    }
                }
                if (input5 == "7")
                {
                    무쇠갑옷.mount = false;
                    스파르타의갑옷.mount = false;
                    수련자갑옷.mount = false;
                    if (우동의두꺼운지방.mount == false)
                    {
                        우동의두꺼운지방.mount = true;

                    }
                    else
                    {
                        우동의두꺼운지방.mount = false;

                    }
                }
                if (input5 == "0")
                {
                    statoffense = 0;
                    statdefense = 0;
                    if (수련자갑옷.mount == true)
                    {
                        statdefense += 수련자갑옷.defense;
                    }
                    if (무쇠갑옷.mount == true)
                    {
                        statdefense += 무쇠갑옷.defense;
                    }
                    if (스파르타의갑옷.mount == true)
                    {
                        statdefense += 스파르타의갑옷.defense;
                    }
                    if (우동의두꺼운지방.mount == true)
                    {
                        statdefense += 우동의두꺼운지방.defense;
                    }
                    if (낡은검.mount == true)
                    {
                        statoffense += 낡은검.offense;
                    }
                    if (청동도끼.mount == true)
                    {
                        statoffense += 청동도끼.offense;
                    }
                    if (스파르타의창.mount == true)
                    {
                        statoffense += 스파르타의창.offense;
                    }


                    inventory();
                }
                else
                {

                    mountManage();
                }
                inventory();

            }

            void shop()
            {
                Console.WriteLine("보유골드");
                Console.WriteLine(stat1.gold + "g");
                Console.WriteLine("[아이템 목록]");
                if (수련자갑옷.get == false)
                {
                    Console.WriteLine("-" + 수련자갑옷.name + "| 방어력 : " + 수련자갑옷.defense + " | " + 수련자갑옷.explanation + " | " + 수련자갑옷.gold);
                }
                else
                {
                    Console.WriteLine("-" + 수련자갑옷.name + "| 방어력 : " + 수련자갑옷.defense + " | " + 수련자갑옷.explanation + " | " + "구매완료");
                }
                if (무쇠갑옷.get == false)
                {
                    Console.WriteLine("-" + 무쇠갑옷.name + "| 방어력 : " + 무쇠갑옷.defense + " | " + 무쇠갑옷.explanation + " | " + 무쇠갑옷.gold);
                }
                else
                {
                    Console.WriteLine("-" + 무쇠갑옷.name + "| 방어력 : " + 무쇠갑옷.defense + " | " + 무쇠갑옷.explanation + " | " + "구매완료");
                }
                if (스파르타의갑옷.get == false)
                {
                    Console.WriteLine("-" + 스파르타의갑옷.name + "| 방어력 : " + 스파르타의갑옷.defense + " | " + 스파르타의갑옷.explanation + " | " + 스파르타의갑옷.gold);
                }
                else
                {
                    Console.WriteLine("-" + 스파르타의갑옷.name + "| 방어력 : " + 스파르타의갑옷.defense + " | " + 스파르타의갑옷.explanation + " | " + "구매완료");
                }
                if (낡은검.get == false)
                {
                    Console.WriteLine("-" + 낡은검.name + "| 공격력 : " + 낡은검.offense + " | " + 낡은검.explanation + " | " + 낡은검.gold);
                }
                else
                {
                    Console.WriteLine("-" + 낡은검.name + "| 공격력 : " + 낡은검.offense + " | " + 낡은검.explanation + " | " + "구매완료");
                }
                if (청동도끼.get == false)
                {
                    Console.WriteLine("-" + 청동도끼.name + "| 공격력 : " + 청동도끼.offense + " | " + 청동도끼.explanation + " | " + 청동도끼.gold);
                }
                else
                {
                    Console.WriteLine("-" + 청동도끼.name + "| 공격력 : " + 청동도끼.offense + " | " + 청동도끼.explanation + " | " + "구매완료");
                }
                if (스파르타의창.get == false)
                {
                    Console.WriteLine("-" + 스파르타의창.name + "| 공격력 : " + 스파르타의창.offense + " | " + 스파르타의창.explanation + " | " + 스파르타의창.gold);
                }
                else
                {
                    Console.WriteLine("-" + 스파르타의창.name + "| 공격력 : " + 스파르타의창.offense + " | " + 스파르타의창.explanation + " | " + "구매완료");
                }
                if (우동의두꺼운지방.get == false)
                {
                    Console.WriteLine("-" + 우동의두꺼운지방.name + "| 방어력 : " + 우동의두꺼운지방.defense + " | " + 우동의두꺼운지방.explanation + " | " + 우동의두꺼운지방.gold);
                }
                else
                {
                    Console.WriteLine("-" + 우동의두꺼운지방.name + "| 방어력 : " + 우동의두꺼운지방.defense + " | " + 우동의두꺼운지방.explanation + " | " + "구매완료");
                }


                Console.WriteLine("1.아이템 구매\n2.아이템 판매\n0.나가기");
                string input3 = Console.ReadLine();
                if (input3 == "1")
                {
                    shopbuy();
                }
                else if (input3 == "2")
                {
                    shopsell();
                }
                else if (input3 == "0")
                {
                    enter();
                }

                else
                {
                    Console.WriteLine("잘못입력하셨습니다.");
                    shop();
                }

            }

            void shopbuy()
            {
                Console.WriteLine("[보유골드]");
                Console.WriteLine(stat1.gold + "g");
                Console.WriteLine("아이템  구매");
                Console.WriteLine("0.나가기");
                Console.WriteLine("[아이템 목록]");
                if (수련자갑옷.get == false)
                {
                    Console.WriteLine("-1" + 수련자갑옷.name + "| 방어력 : " + 수련자갑옷.defense + " | " + 수련자갑옷.explanation + " | " + 수련자갑옷.gold);
                }
                else
                {
                    Console.WriteLine("-1" + 수련자갑옷.name + "| 방어력 : " + 수련자갑옷.defense + " | " + 수련자갑옷.explanation + " | " + "구매완료");
                }
                if (무쇠갑옷.get == false)
                {
                    Console.WriteLine("-2" + 무쇠갑옷.name + "| 방어력 : " + 무쇠갑옷.defense + " | " + 무쇠갑옷.explanation + " | " + 무쇠갑옷.gold);
                }
                else
                {
                    Console.WriteLine("-2" + 무쇠갑옷.name + "| 방어력 : " + 무쇠갑옷.defense + " | " + 무쇠갑옷.explanation + " | " + "구매완료");
                }
                if (스파르타의갑옷.get == false)
                {
                    Console.WriteLine("-3" + 스파르타의갑옷.name + "| 방어력 : " + 스파르타의갑옷.defense + " | " + 스파르타의갑옷.explanation + " | " + 스파르타의갑옷.gold);
                }
                else
                {
                    Console.WriteLine("-3" + 스파르타의갑옷.name + "| 방어력 : " + 스파르타의갑옷.defense + " | " + 스파르타의갑옷.explanation + " | " + "구매완료");
                }
                if (낡은검.get == false)
                {
                    Console.WriteLine("-4" + 낡은검.name + "| 공격력 : " + 낡은검.offense + " | " + 낡은검.explanation + " | " + 낡은검.gold);
                }
                else
                {
                    Console.WriteLine("-4" + 낡은검.name + "| 공격력 : " + 낡은검.offense + " | " + 낡은검.explanation + " | " + "구매완료");
                }
                if (청동도끼.get == false)
                {
                    Console.WriteLine("-5" + 청동도끼.name + "| 공격력 : " + 청동도끼.offense + " | " + 청동도끼.explanation + " | " + 청동도끼.gold);
                }
                else
                {
                    Console.WriteLine("-5" + 청동도끼.name + "| 공격력 : " + 청동도끼.offense + " | " + 청동도끼.explanation + " | " + "구매완료");
                }
                if (스파르타의창.get == false)
                {
                    Console.WriteLine("-6" + 스파르타의창.name + "| 공격력 : " + 스파르타의창.offense + " | " + 스파르타의창.explanation + " | " + 스파르타의창.gold);
                }
                else
                {
                    Console.WriteLine("-6" + 스파르타의창.name + "| 공격력 : " + 스파르타의창.offense + " | " + 스파르타의창.explanation + " | " + "구매완료");
                }
                if (우동의두꺼운지방.get == false)
                {
                    Console.WriteLine("-7" + 우동의두꺼운지방.name + "| 방어력 : " + 우동의두꺼운지방.defense + " | " + 우동의두꺼운지방.explanation + " | " + 우동의두꺼운지방.gold);
                }
                else
                {
                    Console.WriteLine("-7" + 우동의두꺼운지방.name + "| 방어력 : " + 우동의두꺼운지방.defense + " | " + 우동의두꺼운지방.explanation + " | " + "구매완료");
                }



                string input4 = Console.ReadLine();
                if (input4 == "1")
                {
                    if (수련자갑옷.get == false)

                    {
                        if (stat1.gold >= 수련자갑옷.gold)
                        {


                            수련자갑옷.get = true;
                            stat1.gold -= 수련자갑옷.gold;
                            Console.WriteLine("구매를 완료했습니다.");

                            shopbuy();
                        }
                        else
                        {
                            Console.WriteLine("돈이 부족합니다.");
                            shopbuy();
                        }
                    }
                    else
                    {
                        Console.WriteLine("이미있습니다.");

                        shopbuy();
                    }

                }
                if (input4 == "2")
                {

                    if (무쇠갑옷.get == false)
                    {
                        if (stat1.gold >= 무쇠갑옷.gold)
                        {
                            무쇠갑옷.get = true;
                            stat1.gold -= 무쇠갑옷.gold;
                            Console.WriteLine("구매를 완료했습니다.");
                            shopbuy();
                        }
                        else
                        {
                            Console.WriteLine("돈이 부족합니다.");
                            shopbuy();
                        }
                    }

                    else
                    {
                        Console.WriteLine("이미있습니다.");

                        shopbuy();
                    }
                }
                if (input4 == "3")
                {
                    if (스파르타의갑옷.get == false)

                    {
                        if (stat1.gold >= 스파르타의갑옷.gold)
                        {
                            스파르타의갑옷.get = true;
                            stat1.gold -= 스파르타의갑옷.gold;
                            Console.WriteLine("구매를 완료했습니다.");
                            shopbuy();
                        }
                        else
                        {
                            Console.WriteLine("돈이 부족합니다.");
                            shopbuy();
                        }
                    }
                    else
                    {
                        Console.WriteLine("이미있습니다.");

                        shopbuy();
                    }
                }
                if (input4 == "4")
                {
                    if (낡은검.get == false)

                    {
                        if (stat1.gold >= 낡은검.gold)
                        {
                            낡은검.get = true;
                            stat1.gold -= 낡은검.gold;
                            Console.WriteLine("구매를 완료했습니다.");
                            shopbuy();
                        }
                        else
                        {
                            Console.WriteLine("돈이 부족합니다.");
                            shopbuy();
                        }
                    }
                    else
                    {
                        Console.WriteLine("이미있습니다.");

                        shopbuy();
                    }
                }
                if (input4 == "5")
                {
                    if (청동도끼.get == false)

                    {
                        if (stat1.gold >= 청동도끼.gold)
                        {


                            청동도끼.get = true;
                            stat1.gold -= 청동도끼.gold;
                            Console.WriteLine("구매를 완료했습니다.");
                            shopbuy();

                        }
                        else
                        {
                            Console.WriteLine("돈이 부족합니다.");
                            shopbuy();
                        }
                    }

                    else
                    {
                        Console.WriteLine("이미있습니다.");
                        shopbuy();
                    }
                }
                if (input4 == "6")
                {
                    if (스파르타의창.get == false)

                    {
                        if (stat1.gold >= 스파르타의창.gold)
                        {
                            스파르타의창.get = true;
                            stat1.gold -= 스파르타의창.gold;
                            Console.WriteLine("구매를 완료했습니다.");
                            shopbuy();
                        }
                        else
                        {
                            Console.WriteLine("돈이 부족합니다.");
                            shopbuy();
                        }
                    }
                    else
                    {
                        Console.WriteLine("이미있습니다");

                        shopbuy();
                    }
                }
                if (input4 == "7")
                {
                    if (우동의두꺼운지방.get == false)

                    {
                        if (stat1.gold >= 우동의두꺼운지방.gold)
                        {
                            우동의두꺼운지방.get = true;
                            stat1.gold -= 우동의두꺼운지방.gold;
                            Console.WriteLine("구매를 완료했습니다.");
                            shopbuy();
                        }
                        else
                        {
                            Console.WriteLine("돈이 부족합니다.");
                            shopbuy();
                        }
                    }
                    else
                    {
                        Console.WriteLine("이미있습니다.");

                        shopbuy();
                    }
                }
                if (input4 == "0")
                {
                    shop();
                }
                else
                {
                    Console.WriteLine("잘못입력하셨습니다");
                    shopbuy();
                }
            }

            void shopsell()
            {
                Console.WriteLine("[보유골드]");
                Console.WriteLine(stat1.gold + "g");
                Console.WriteLine("아이템  판매");
                Console.WriteLine("0.나가기");
                Console.WriteLine("[보유 아이템 목록]");
                if (수련자갑옷.get == true)
                {
                    if (수련자갑옷.mount == true)
                    {
                        Console.WriteLine("-1[E]" + 수련자갑옷.name + "| 방어력 : " + 수련자갑옷.defense + " | " + 수련자갑옷.explanation + "|" + 수련자갑옷.gold / 100 * 85);
                    }
                    else
                    {
                        Console.WriteLine("-1" + 수련자갑옷.name + "| 방어력 : " + 수련자갑옷.defense + " | " + 수련자갑옷.explanation + "|" + 수련자갑옷.gold / 100 * 85);
                    }
                }
                if (무쇠갑옷.get == true)
                {
                    if (무쇠갑옷.mount == true)
                    {
                        Console.WriteLine("-2[E]" + 무쇠갑옷.name + "| 방어력 : " + 무쇠갑옷.defense + " | " + 무쇠갑옷.explanation + "|" + 무쇠갑옷.gold / 100 * 85);
                    }
                    else
                    {
                        Console.WriteLine("-2" + 무쇠갑옷.name + "| 방어력 : " + 무쇠갑옷.defense + " | " + 무쇠갑옷.explanation + "|" + 무쇠갑옷.gold / 100 * 85);
                    }
                }
                if (스파르타의갑옷.get == true)
                {
                    if (스파르타의갑옷.mount == true)
                    {
                        Console.WriteLine("-3[E]" + 스파르타의갑옷.name + "| 방어력 : " + 스파르타의갑옷.defense + " | " + 스파르타의갑옷.explanation + "|" + 스파르타의갑옷.gold / 100 * 85);
                    }
                    else
                    {
                        Console.WriteLine("-3" + 스파르타의갑옷.name + "| 방어력 : " + 스파르타의갑옷.defense + " | " + 스파르타의갑옷.explanation + "|" + 스파르타의갑옷.gold / 100 * 85);
                    }
                }
                if (낡은검.get == true)
                {
                    if (낡은검.mount == true)
                    {
                        Console.WriteLine("-4[E]" + 낡은검.name + "| 공격력 : " + 낡은검.offense + " | " + 낡은검.explanation + "|" + 낡은검.gold / 100 * 85);
                    }
                    else
                    {
                        Console.WriteLine("-4" + 낡은검.name + "| 공격력 : " + 낡은검.offense + " | " + 낡은검.explanation + "|" + 낡은검.gold / 100 * 85);
                    }
                }
                if (청동도끼.get == true)
                {
                    if (청동도끼.mount == true)
                    {
                        Console.WriteLine("-5[E]" + 청동도끼.name + "| 공격력 : " + 청동도끼.offense + " | " + 청동도끼.explanation + "|" + 청동도끼.gold / 100 * 85);
                    }
                    else
                    {
                        Console.WriteLine("-5" + 청동도끼.name + "| 공격력 : " + 청동도끼.offense + " | " + 청동도끼.explanation + "|" + 청동도끼.gold / 100 * 85);
                    }
                }
                if (스파르타의창.get == true)
                {
                    if (스파르타의창.mount == true)
                    {
                        Console.WriteLine("-6[E]" + 스파르타의창.name + "| 공격력 : " + 스파르타의창.offense + " | " + 스파르타의창.explanation + "|" + 스파르타의창.gold / 100 * 85);
                    }
                    else
                    {
                        Console.WriteLine("-6" + 스파르타의창.name + "| 공격력 : " + 스파르타의창.offense + " | " + 스파르타의창.explanation + "|" + 스파르타의창.gold / 100 * 85);
                    }
                }
                if (우동의두꺼운지방.get == true)
                {
                    if (우동의두꺼운지방.mount == true)
                    {
                        Console.WriteLine("-7[E]" + 우동의두꺼운지방.name + "| 방어력 : " + 우동의두꺼운지방.defense + " | " + 우동의두꺼운지방.explanation + "|" + 우동의두꺼운지방.gold / 100 * 85);
                    }
                    else
                    {
                        Console.WriteLine("-7" + 우동의두꺼운지방.name + "| 방어력 : " + 우동의두꺼운지방.defense + " | " + 우동의두꺼운지방.explanation + "|" + 우동의두꺼운지방.gold / 100 * 85);
                    }
                }
                string input6 = Console.ReadLine();

                if (input6 == "1")
                {
                    if (수련자갑옷.get = true)
                    {
                        if (수련자갑옷.mount = true)
                        {
                            Console.WriteLine("판매되었습니다.");
                            수련자갑옷.mount = false;
                            수련자갑옷.get = false;
                            statdefense -= 수련자갑옷.defense;
                            stat1.gold += 수련자갑옷.gold / 100 * 85;
                            shopsell();
                        }
                        else
                        {
                            Console.WriteLine("판매되었습니다.");
                            수련자갑옷.get = false;
                            statdefense -= 수련자갑옷.defense;
                            stat1.gold += 수련자갑옷.gold / 100 * 85;
                            shopsell();
                        }
                    }
                }
                if (input6 == "2")
                {
                    if (무쇠갑옷.get = true)
                    {
                        if (무쇠갑옷.mount = true)
                        {
                            Console.WriteLine("판매되었습니다.");
                            무쇠갑옷.mount = false;
                            무쇠갑옷.get = false;
                            statdefense -= 무쇠갑옷.defense;
                            stat1.gold += 무쇠갑옷.gold / 100 * 85;
                            shopsell();
                        }
                        else
                        {
                            Console.WriteLine("판매되었습니다.");
                            수련자갑옷.get = false;
                            statdefense -= 수련자갑옷.defense;
                            stat1.gold += 무쇠갑옷.gold / 100 * 85;
                            shopsell();
                        }
                    }
                }
                if (input6 == "3")
                {
                    if (스파르타의갑옷.get = true)
                    {
                        if (스파르타의갑옷.mount = true)
                        {
                            Console.WriteLine("판매되었습니다.");
                            스파르타의갑옷.mount = false;
                            스파르타의갑옷.get = false;
                            statdefense -= 스파르타의갑옷.defense;
                            stat1.gold += 스파르타의갑옷.gold / 100 * 85;
                            shopsell();
                        }
                        else
                        {
                            Console.WriteLine("판매되었습니다.");
                            스파르타의갑옷.get = false;
                            statdefense -= 스파르타의갑옷.defense;
                            stat1.gold += 스파르타의갑옷.gold / 100 * 85;
                            shopsell();
                        }
                    }
                }
                if (input6 == "4")
                {
                    if (낡은검.get = true)
                    {
                        if (낡은검.mount = true)
                        {
                            Console.WriteLine("판매되었습니다.");
                            낡은검.mount = false;
                            낡은검.get = false;
                            statoffense -= 낡은검.offense;
                            stat1.gold += 낡은검.gold / 100 * 85;
                            shopsell();
                        }
                        else
                        {
                            Console.WriteLine("판매되었습니다.");
                            낡은검.get = false;
                            statoffense -= 낡은검.offense;
                            stat1.gold += 낡은검.gold / 100 * 85;
                            shopsell();
                        }
                    }
                }
                if (input6 == "5")
                {
                    if (청동도끼.get = true)
                    {
                        if (청동도끼.mount = true)
                        {
                            Console.WriteLine("판매되었습니다.");
                            청동도끼.mount = false;
                            청동도끼.get = false;
                            statoffense -= 청동도끼.offense;
                            stat1.gold += 청동도끼.gold / 100 * 85;
                            shopsell();
                        }
                        else
                        {
                            Console.WriteLine("판매되었습니다.");
                            청동도끼.get = false;
                            statoffense -= 청동도끼.offense;
                            stat1.gold += 청동도끼.gold / 100 * 85;
                            shopsell();
                        }
                    }
                }
                if (input6 == "6")
                {
                    if (스파르타의창.get = true)
                    {
                        if (스파르타의창.mount = true)
                        {
                            Console.WriteLine("판매되었습니다.");
                            스파르타의창.mount = false;
                            스파르타의창.get = false;
                            statoffense -= 스파르타의창.offense;
                            stat1.gold += 스파르타의창.gold / 100 * 85;
                            shopsell();
                        }
                        else
                        {
                            Console.WriteLine("판매되었습니다.");
                            스파르타의창.get = false;
                            statoffense -= 스파르타의창.offense;
                            stat1.gold += 스파르타의창.gold / 100 * 85;
                            shopsell();
                        }
                    }
                }
                if (input6 == "7")
                {
                    if (우동의두꺼운지방.get = true)
                    {
                        if (우동의두꺼운지방.mount = true)
                        {
                            Console.WriteLine("판매되었습니다.");
                            우동의두꺼운지방.mount = false;
                            우동의두꺼운지방.get = false;
                            statdefense -= 우동의두꺼운지방.defense;
                            stat1.gold += 우동의두꺼운지방.gold / 100 * 85;
                            shopsell();
                        }
                        else
                        {
                            Console.WriteLine("판매되었습니다.");
                            우동의두꺼운지방.get = false;
                            statdefense -= 우동의두꺼운지방.defense;
                            stat1.gold += 우동의두꺼운지방.gold / 100 * 85;
                            shopsell();
                        }
                    }
                }
                if (input6 == "0")
                {
                    shop();
                }
                else
                {
                    Console.WriteLine("잘못입력하셨습니다");
                    shopsell();
                }

            }


            void dungeon()
            {
                
                Console.WriteLine("[던전입장]");
                Console.WriteLine("1.쉬운 던전 | 방어력 5 이상 권장 \n2.일반 던전 | 방어력 11 이상 권장 \n3.어려운 던전 | 방어력 17이상 권장\n0.나가기");
                Console.WriteLine("원하시는 행동을 입력해 주세요");
                string input7 = Console.ReadLine();
                if (input7 == "1")
                {
                    easy();
                }
                if (input7 == "2")
                {
                    middle();
                }
                if (input7 == "3")
                {
                    hard();
                }
                if (input7 == "0")
                {
                    enter();
                }
                else
                {
                    Console.WriteLine("잘못입력하셨습니다.");
                    dungeon();
                }

            }



            void easy()
            {
                int dungeondif = rand.Next(0, 10);
                float dungeonhp = rand.Next(20, 35);
                float dogeonreward = rand.Next(1, 3);
                if (stat1.defense + statdefense < 5)
                {
                    
                    if (dungeondif < 3)
                    {
                        Console.WriteLine("클리어 실패");
                        Console.WriteLine("[탐험 결과]");

                        Console.WriteLine("체력" + stat1.hp + " ->" + stat1.hp / 2);
                        stat1.hp /= 2;
                        dungeon();

                    }
                    if (dungeondif >= 3)
                    {
                        Console.WriteLine("클리어 성공");
                        Console.WriteLine("");
                        Console.Write("체력" + stat1.hp);
                        Console.Write("->");
                        stat1.hp -= dungeonhp + stat1.defense - 5;
                        Console.WriteLine( stat1.hp);
                        Console.WriteLine("");
                        Console.Write("골드" + stat1.gold);
                        Console.Write("->");
                        stat1.gold += 1000 + ((stat1.offense + statoffense) * dogeonreward);
                        Console.WriteLine(stat1.gold);
                        Console.WriteLine("");
                        stat1.exp -= 1;
                        if (stat1.exp == 10)
                        {
                            stat1.defense = 5;
                            stat1.offense = 10;
                        }
                        if (stat1.exp <= 9)
                        {
                            stat1.defense = 6;
                            stat1.offense = 10.5f;
                        }
                        if (stat1.exp <= 7)
                        {
                            stat1.defense = 7;
                            stat1.offense = 11;
                        }

                        if (stat1.exp <= 4)
                        {
                            stat1.defense = 8;
                            stat1.offense = 11.5f;
                        }

                        if (stat1.exp <= 1)
                        {
                            stat1.defense = 9;
                            stat1.offense = 12;
                        }



                        dungeon();
                    }
                }
                else
                {
                    Console.WriteLine("클리어 성공");
                    Console.WriteLine("");
                    Console.Write("체력" + stat1.hp);
                    Console.Write("->");
                    stat1.hp -= dungeonhp + stat1.defense - 5;
                    Console.WriteLine( stat1.hp);
                    Console.WriteLine("");
                    Console.Write("골드" + stat1.gold);
                    Console.Write("->");
                    stat1.gold += 1000 + ((stat1.offense + statoffense) * dogeonreward);
                    Console.WriteLine(stat1.gold);
                    Console.WriteLine("");
                    stat1.exp -= 1;
                    if (stat1.exp == 10)
                    {
                        stat1.defense = 5;
                        stat1.offense = 10;
                    }
                    if (stat1.exp <= 9)
                    {
                        stat1.defense = 6;
                        stat1.offense = 10.5f;
                    }
                    if (stat1.exp <= 7)
                    {
                        stat1.defense = 7;
                        stat1.offense = 11;
                    }

                    if (stat1.exp <= 4)
                    {
                        stat1.defense = 8;
                        stat1.offense = 11.5f;
                    }

                    if (stat1.exp <= 1)
                    {
                        stat1.defense = 9;
                        stat1.offense = 12;
                    }
                    dungeon();
                }
            }

            void middle()
            {
                int dungeondif = rand.Next(0, 10);
                int dungeonhp = rand.Next(20, 35);
                int dogeonreward = rand.Next(1, 3);
                if (stat1.defense + statdefense < 11)
                {
                    if (dungeondif < 3)
                    {
                        
                        Console.WriteLine("클리어 실패");
                        Console.WriteLine("[탐험 결과]");

                        Console.WriteLine("체력" + stat1.hp + " ->" + stat1.hp / 2);
                        stat1.hp /= 2;
                        dungeon();

                    }
                    if (dungeondif >= 3)
                    {
                        Console.WriteLine("클리어 성공");
                        Console.WriteLine("");
                        Console.Write("체력" + stat1.hp);
                        Console.Write("->");
                        stat1.hp -= dungeonhp + stat1.defense - 5;
                        Console.WriteLine(stat1.hp);
                        Console.WriteLine("");
                        Console.Write("골드" + stat1.gold);
                        Console.Write("->");
                        stat1.gold += 1700 + ((stat1.offense + statoffense) * dogeonreward);
                        Console.WriteLine(stat1.gold);
                        Console.WriteLine("");
                        stat1.exp -= 1;
                        if (stat1.exp == 10)
                        {
                            stat1.defense = 5;
                            stat1.offense = 10;
                        }
                        if (stat1.exp <= 9)
                        {
                            stat1.defense = 6;
                            stat1.offense = 10.5f;
                        }
                        if (stat1.exp <= 7)
                        {
                            stat1.defense = 7;
                            stat1.offense = 11;
                        }

                        if (stat1.exp <= 4)
                        {
                            stat1.defense = 8;
                            stat1.offense = 11.5f;
                        }

                        if (stat1.exp <= 1)
                        {
                            stat1.defense = 9;
                            stat1.offense = 12;
                        }
                        dungeon();
                    }
                }
                else
                {
                    Console.WriteLine("클리어 성공");
                    Console.WriteLine("");
                    Console.Write("체력" + stat1.hp);
                    Console.Write("->");
                    stat1.hp -= dungeonhp + stat1.defense - 5;
                    Console.WriteLine(stat1.hp);
                    Console.WriteLine("");
                    Console.Write("골드" + stat1.gold);
                    Console.Write("->");
                    stat1.gold += 1700 + ((stat1.offense + statoffense) * dogeonreward);
                    Console.WriteLine(stat1.gold);
                    Console.WriteLine("");
                    stat1.exp -= 1;
                    if (stat1.exp == 10)
                    {
                        stat1.defense = 5;
                        stat1.offense = 10;
                    }
                    if (stat1.exp <= 9)
                    {
                        stat1.defense = 6;
                        stat1.offense = 10.5f;
                    }
                    if (stat1.exp <= 7)
                    {
                        stat1.defense = 7;
                        stat1.offense = 11;
                    }

                    if (stat1.exp <= 4)
                    {
                        stat1.defense = 8;
                        stat1.offense = 11.5f;
                    }

                    if (stat1.exp <= 1)
                    {
                        stat1.defense = 9;
                        stat1.offense = 12;
                    }
                    dungeon();
                }
            }

            void hard()
            {
                int dungeondif = rand.Next(0, 10);
                int dungeonhp = rand.Next(20, 35);
                int dogeonreward = rand.Next(1, 3);
                if (stat1.defense + statdefense < 17)
                {
                    if (dungeondif < 3)
                    {
                        Console.WriteLine("클리어 실패");
                        Console.WriteLine("[탐험 결과]");

                        Console.WriteLine("체력" + stat1.hp + " ->" + stat1.hp / 2);
                        stat1.hp /= 2;
                        dungeon();

                    }
                    if (dungeondif >= 3)
                    {
                        Console.WriteLine("클리어 성공");
                        Console.WriteLine("");
                        Console.Write("체력" + stat1.hp);
                        Console.Write("->");
                        stat1.hp -= dungeonhp + stat1.defense - 5;
                        Console.WriteLine(stat1.hp);
                        Console.WriteLine("");
                        Console.Write("골드" + stat1.gold);
                        Console.Write("->");
                        stat1.gold += 2500 + ((stat1.offense + statoffense) * dogeonreward);
                        Console.WriteLine(stat1.gold);
                        Console.WriteLine("");
                        stat1.exp -= 1;
                        if (stat1.exp == 10)
                        {
                            stat1.defense = 5;
                            stat1.offense = 10;
                        }
                        if (stat1.exp <= 9)
                        {
                            stat1.defense = 6;
                            stat1.offense = 10.5f;
                        }
                        if (stat1.exp <= 7)
                        {
                            stat1.defense = 7;
                            stat1.offense = 11;
                        }

                        if (stat1.exp <= 4)
                        {
                            stat1.defense = 8;
                            stat1.offense = 11.5f;
                        }

                        if (stat1.exp <= 1)
                        {
                            stat1.defense = 9;
                            stat1.offense = 12;
                        }
                        dungeon();
                    }
                }
                else
                {
                    Console.WriteLine("클리어 성공");
                    Console.WriteLine("");
                    Console.Write("체력" + stat1.hp);
                    Console.Write("->");
                    stat1.hp -= dungeonhp + stat1.defense - 5;
                    Console.WriteLine(stat1.hp);
                    Console.WriteLine("");
                    Console.Write("골드" + stat1.gold);
                    Console.Write("->");
                    stat1.gold += 2500 + ((stat1.offense + statoffense) * dogeonreward);
                    Console.WriteLine(stat1.gold);
                    Console.WriteLine("");
                    stat1.exp -= 1;
                    if (stat1.exp == 10)
                    {
                        stat1.defense = 5;
                        stat1.offense = 10;
                    }
                    if (stat1.exp <= 9)
                    {
                        stat1.defense = 6;
                        stat1.offense = 10.5f;
                    }
                    if (stat1.exp <= 7)
                    {
                        stat1.defense = 7;
                        stat1.offense = 11;
                    }

                    if (stat1.exp <= 4)
                    {
                        stat1.defense = 8;
                        stat1.offense = 11.5f;
                    }

                    if (stat1.exp <= 1)
                    {
                        stat1.defense = 9;
                        stat1.offense = 12;
                    }
                    dungeon();
                }
            }


            void rest()
            {
                Console.WriteLine("휴식하기");
                Console.WriteLine("500G 를 내면 체력을 회복할 수 있습니다. (보유골드 : " + stat1.gold + "G)");
                Console.WriteLine("1.휴식하기\n0.나가기");
                string input8 = Console.ReadLine();
                if (input8 == "1")
                {
                    if (stat1.gold > 500)
                    {
                        stat1.hp = 100;
                        stat1.gold -= 500;
                        Console.WriteLine("휴식이 끝났습니다.");
                        rest();
                    }
                    else
                    {
                        Console.WriteLine("골드가 부족합니다.");
                        rest();
                    }

                }
                if (input8 == "0")
                {
                    enter();
                }
            }


            
        }





























    }


}        
    


