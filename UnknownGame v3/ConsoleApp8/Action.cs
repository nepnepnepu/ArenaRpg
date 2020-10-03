using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp8
{
    class Action
    {

        static void Main(string[] args)
        {
            Console.WriteLine("================================================================================");
            Thread.Sleep(1000);
            Console.WriteLine("                                ||||||||||||||||||                              ");
            Console.WriteLine("                                ||UNKNOWN|||GAME||  (DEMO)                      ");
            Console.WriteLine("                                ||||||||||||||||||                              ");
            Thread.Sleep(1000);
            Console.WriteLine("================================================================================");
            Thread.Sleep(1000);
            Console.WriteLine("");
            Console.WriteLine("====================================| Обучение |================================");
            Console.WriteLine("По ходу игры вам будут предлагаться варианты различных ситуаций и их действия,  ");
            Console.WriteLine("Для выбора действия, используйте нумерные клавиши 1, 2, 3 и 4 в вверхней части  ");
            Console.WriteLine("Клавиатуры. ВНИМАНИЕ! Нажатие любой другой клавиши не из вышеперечисленных,     ");
            Console.WriteLine("приведет в любом случае к ПЕРВОМУ варианту!");
            Console.WriteLine("================================================================================");
            Thread.Sleep(1000);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Нажмите любую клавишу для продолжения . . .");
            
            Console.ReadKey();
            Console.Clear();

            Console.Beep(600, 100);
            Console.Beep(400, 80);
            Console.Beep(200, 70);
            Console.Beep(100, 50);


            Start();

            FirstBattle();

            BattleEnd();



        }



        static void Start()
        {
            // список диалогов
            List<Textes> ch1 = new List<Textes>()
            {
               new Textes() { id = 0, text = "Вы приходите в сознание в неизвестной вам пещере, вокруг темно и ничего не видно. Только свет от маленьких странных кристаллов позволяет что-то разглядеть."},

               new Textes() { id = 1, text = "Вы увидели, что перед вами находится два прохода."},
               new Textes() { id = 2, text = "Крик ничего не дал."},
               new Textes() { id = 3, text = "Прошло около часа, но ничего так и не произошло."},


               new Textes() {id = 4, text = "Вы повернули в левый проход и идете по протяжному туннелю, в конце которого тупик."},
               new Textes() {id = 5, text = "Вы повернули в левый проход и идете по протяжному туннелю, в конце которого лежит ключик."},
               new Textes() {id = 6, text = "Вы повернули в правый проход, пройдя некоторое расстояние вы нашли запертую железную дверь."},

            };
            // список ответов
            List<Answer> aw1 = new List<Answer>()
            {
               new Answer() { id = 01, text = "1) Осмотреться "},
               new Answer() { id = 02, text = "2) Позвать на помощь"},
               new Answer() { id = 03, text = "3) Сидеть и ждать "},


               new Answer() {id = 11, text = "1) Пойти в левый проход"},
               new Answer() {id = 12, text = "2) Пойти в правый проход"},

               new Answer() {id = 51, text = "1) Взять ключ"},
               new Answer() {id = 41, text = "2) Вернуться обратно"},

               new Answer() {id = 61, text = "1) Отпереть дверь с помощью ключа"},


            };


            byte go1;


            // старт (1 этап)
            do
            {
               
                Console.WriteLine(ch1.Find(X => X.id == 0).text);
                //
                Console.WriteLine("");
                Console.WriteLine(aw1.Find(X => X.id == 01).text);
                Console.WriteLine(aw1.Find(X => X.id == 02).text);
                Console.WriteLine(aw1.Find(X => X.id == 03).text);

                ConsoleKeyInfo key;
                key = Console.ReadKey();

                switch (key.KeyChar)
                {
                    case '1':
                        Console.Beep(100, 50);
                        Console.Clear();
                        //Console.WriteLine((ch1.Find(X => X.id == 1).text));
                        go1 = 1;
                        break;
                    case '2':
                        Console.Beep(100, 50);
                        Console.Clear();
                        Console.WriteLine((ch1.Find(X => X.id == 2).text));
                        Thread.Sleep(2000);
                        Console.WriteLine("");
                        go1 = 0;
                        break;
                    case '3':
                        Console.Beep(100, 50);
                        Console.Clear();
                        Console.WriteLine((ch1.Find(X => X.id == 3).text));
                        Thread.Sleep(2000);
                        Console.WriteLine("");
                        go1 = 0;
                        
                        
                        break;
                    default:
                        Console.Beep(20, 100);
                        Console.WriteLine(" <-- Была нажата неназначенная клавиша, переход к первому варианту. . .");
                        Thread.Sleep(3000);

                        goto case '1';

                }
            }
            while (go1 == 0);

            byte go2 = 0;

            bool quest_key1 = false;
            // туннели и дверь (2 этап)
            do
            {
                Console.WriteLine(ch1.Find(X => X.id == 1).text);
                Console.WriteLine("");
                Console.WriteLine(aw1.Find(X => X.id == 11).text);
                Console.WriteLine(aw1.Find(X => X.id == 12).text);

                //ConsoleKeyInfo key;
                //key = Console.ReadKey();

                if (quest_key1 == false)
                {
                    ConsoleKeyInfo key;
                    key = Console.ReadKey();
                    switch (key.KeyChar)
                    {
                        case '1':
                            Console.Clear();
                            Console.WriteLine(ch1.Find(X => X.id == 5).text);
                            Console.WriteLine("");
                            Console.WriteLine(aw1.Find(X => X.id == 51).text);
                            ConsoleKeyInfo scriptkey;
                            scriptkey = Console.ReadKey();

                            switch (scriptkey.KeyChar)
                            {
                                case '1':
                                    Console.Beep(100, 50);
                                    Console.Clear();
                                    Console.WriteLine("Вы взяли ключ!");
                                    quest_key1 = true;
                                    Thread.Sleep(3000);
                                    go2 = 0;
                                    break;

                                default:
                                    Console.Beep(50, 70);
                                    Console.WriteLine(" <-- Была нажата неназначенная клавиша, переход к первому варианту. . .");
                                    Thread.Sleep(3000);

                                    goto case '1';

                            }
                            break;
                        case '2':
                            Console.Clear();
                            Console.WriteLine(ch1.Find(X => X.id == 6).text);
                            Console.WriteLine("");
                            Console.WriteLine(aw1.Find(X => X.id == 41).text);

                            ConsoleKeyInfo scriptkey1;
                            scriptkey1 = Console.ReadKey();

                            switch (scriptkey1.KeyChar)
                            {
                                case '2':
                                    Console.Clear();
                                    Console.WriteLine("Вы возвращаетесь назад . . .");
                                    Thread.Sleep(3000);
                                    go2 = 0;
                                    break;

                                default:
                                    Console.WriteLine(" <-- Была нажата неназначенная клавиша, переход к единственному варианту. . .");
                                    Thread.Sleep(3000);

                                    goto case '2';

                            }
                            break;
                    }
                }
                else
                {

                    ConsoleKeyInfo scriptkey2;
                    scriptkey2 = Console.ReadKey();

                    switch (scriptkey2.KeyChar)
                    {
                        case '1':
                            Console.Beep(100, 50);
                            Console.Clear();
                            Console.WriteLine(ch1.Find(X => X.id == 4).text);
                            Console.WriteLine("");
                            Console.WriteLine(aw1.Find(X => X.id == 41).text);

                            ConsoleKeyInfo scriptkey1;
                            scriptkey1 = Console.ReadKey();

                            switch (scriptkey1.KeyChar)
                            {
                                case '2':
                                    Console.Beep(100, 50);
                                    Console.Clear();
                                    Console.WriteLine("Вы возвращаетесь назад . . .");
                                    Thread.Sleep(3000);
                                    go2 = 0;
                                    break;

                                default:
                                    Console.WriteLine(" <-- Была нажата неназначенная клавиша, переход к единственному варианту. . .");
                                    Thread.Sleep(3000);

                                    goto case '2';

                            }
                            go2 = 0;
                            break;


                        case '2':
                            Console.Beep(100, 50);
                            Console.Clear();
                            Console.WriteLine(ch1.Find(X => X.id == 6).text);
                            Console.WriteLine("");
                            Console.WriteLine(aw1.Find(X => X.id == 61).text);

                            ConsoleKeyInfo doorkey;
                            doorkey = Console.ReadKey();

                            switch (doorkey.KeyChar)
                            {
                                case '1':
                                    Console.Beep(100, 50);
                                    Console.Clear();
                                    Console.WriteLine("Вы открыли запертую дверь");
                                    go2 = 1;
                                    break;
                                default:
                                    Console.Beep(50, 70);
                                    Console.WriteLine(" <-- Была нажата неназначенная клавиша, переход к первому варианту. . .");
                                    Thread.Sleep(3000);

                                    goto case '1';
                            }
                            break;



                    }


                }

            }
            while (go2 == 0);

            Console.Clear();
            Console.WriteLine("Вы вошли в дверь и вдруг резко она захлопнулась прямо за вами.");

        }

        static void FirstBattle()
        {
            // список диалогов
            List<Textes> ch2 = new List<Textes>()
            {
               new Textes() { id = 0, text = "Вы вышли на большое замкнутое пространство, которое явно было для чего-то создано. Перед вами на полу лежит человеческий скелет."},

                new Textes() { id = 1, text = "Вы осмотрели скелет и нашли заржавевший меч и две стеклянные колбы с зеленой жидкостью внутри."},

                new Textes() { id = 2, text = "Вдруг земля под ногами затряслась и перед вами будто из ниоткуда материализовался монстр, своим появлением он освятил местность вокруг и вы осознали, что находитесь на некой древней арене."},

                new Textes() { id = 3, text = "Монстр вас немедленно атаковал!" }






            };
            // список ответов
            List<Answer> aw2 = new List<Answer>()
            {
               new Answer() { id = 01, text = "1) Осмотреть скелет"},
               new Answer() { id = 02, text = "2) Пройти дальше "},

               new Answer() { id = 31, text = "1) Увернуться "},
               new Answer() { id = 32, text = "2) Контр-атаковать "},
               new Answer() { id = 33, text = "3) Стоять на месте "},

            };


            Stats stat = new Stats(); // Экземпляр статов.
            

            Console.WriteLine(ch2.Find(X => X.id == 0).text);
            Console.WriteLine("");
            Console.WriteLine(aw2.Find(X => X.id == 01).text);
            Console.WriteLine(aw2.Find(X => X.id == 02).text);

            ConsoleKeyInfo key;
            key = Console.ReadKey();

            switch (key.KeyChar)
            {
                case '1':
                    Console.Beep(100, 50);
                    Console.Clear();
                    Console.WriteLine(ch2.Find(X => X.id == 1).text);
                    Console.Clear();
                    Console.WriteLine("Вы нашли: Заржавевший Меч!");
                    Console.Beep(500, 200);
                    stat.playeratk = 20;
                    Thread.Sleep(1000);
                    Console.WriteLine("Вы нашли: Лечебная колба (2)");
                    Console.Beep(500, 200);
                    stat.flaski = 2;
                    Thread.Sleep(1000);
                    stat.loot = true;

                    goto case '2';


                case '2':
                    Console.Beep(100, 50);
                    Console.Clear();
                    Console.WriteLine(ch2.Find(X => X.id == 2).text);
                    break;

                default:
                    Console.Beep(50, 70);
                    Console.WriteLine(" <-- Была нажата неназначенная клавиша, переход к первому варианту. . .");
                    Thread.Sleep(3000);

                    goto case '1';

            }

            int firstdmg = stat.playeratk;
            
            int firstenatk = stat.enemyatk;


            if (stat.loot == true)
            {
                Console.WriteLine(ch2.Find(X => X.id == 3).text);
                Console.WriteLine("");
                Console.WriteLine(aw2.Find(X => X.id == 31).text);
                Console.WriteLine(aw2.Find(X => X.id == 32).text);
                Console.WriteLine(aw2.Find(X => X.id == 33).text);


                ConsoleKeyInfo key1;
                key1 = Console.ReadKey();

                switch (key1.KeyChar)
                {
                    case '1':
                        Console.Beep(100, 50);
                        Console.Clear();
                        Console.WriteLine("Вы отпрыгнули в сторону от вражеской атаки и успешно миновали ее!");
                        break;
                    case '2':
                        Console.Beep(100, 50);
                        Console.Clear();
                        Console.WriteLine("Вы выставили ваш меч по направлению атаки врага, блокировали её, после чего замахнулись и ударили по врагу, что стало неожиданным для него!");
                        int counter = (stat.playeratk * 3);
                        stat.enemyhealth = stat.enemyhealth - counter;
                        Thread.Sleep(1000);
                        Console.WriteLine("");
                        Console.WriteLine("Вы нанесли сильный урон врагу!");
                        Thread.Sleep(1000);
                        Console.WriteLine("Здоровье врага:");
                        Thread.Sleep(1000);
                        Console.WriteLine(stat.enemyhealth);
                        Console.WriteLine("");
                        break;
                    case '3':
                        Console.Beep(100, 50);
                        Console.Clear();
                        Console.WriteLine("Враг нанес вам урон несопоставимый с жизнью");
                        Thread.Sleep(2000);
                        Console.WriteLine("YOU DIED");
                        Thread.Sleep(3000);
                        Environment.Exit(0);
                        break;

                }
                

            }
            else
            {
                Console.WriteLine(ch2.Find(X => X.id == 3).text);
                Console.WriteLine("");
                Console.WriteLine(aw2.Find(X => X.id == 31).text);
                Console.WriteLine(aw2.Find(X => X.id == 32).text);
                Console.WriteLine(aw2.Find(X => X.id == 33).text);


                ConsoleKeyInfo key1;
                key1 = Console.ReadKey();

                switch (key1.KeyChar)
                {
                    case '1':
                        Console.Beep(100, 50);
                        Console.Clear();
                        Console.WriteLine("Вы почти вовремя отпрыгнули, но враг задел вас, и вы получили легкий урон!");
                        int a = stat.health - (stat.enemyatk / 2);
                        Thread.Sleep(1000);
                        Console.WriteLine("Ваше здоровье:");
                        Thread.Sleep(1000);
                        Console.WriteLine(a);
                        break;

                    case '2':
                        Console.Beep(100, 50);
                        Console.Clear();
                        Console.WriteLine("Вы закрыли лицо от атаки лица, но это конечно же не помогло.");
                        int b = stat.health - stat.enemyatk;
                        Thread.Sleep(1000);
                        Console.WriteLine("Ваше здоровье:");
                        Thread.Sleep(1000);
                        Console.WriteLine(b);
                        break;


                    case '3':
                        Console.Beep(100, 50);
                        Console.Clear();
                        Console.WriteLine("Враг нанес вам урон несопоставимый с жизнью");
                        Thread.Sleep(2000);
                        Console.WriteLine("YOU DIED");
                        Thread.Sleep(3000);
                        Environment.Exit(0);
                        break;
                }
               

            }
            do
            {
                Console.Clear();
                Console.WriteLine("Вы видите перед собой Монстра");
                Console.WriteLine("");
                Console.WriteLine("Ваше здоровье: ");
                Console.WriteLine(stat.health);
                Console.WriteLine("Здоровье врага ");
                
                Console.WriteLine(stat.enemyhealth);
                Console.WriteLine("");
                Thread.Sleep(1000);

                if (stat.playerturn == true)
                {

                    Console.WriteLine("");
                    Console.WriteLine("Ваш ход!");
                    Thread.Sleep(2000);
                    Console.WriteLine("Выберите место атаки врага:");
                    Console.WriteLine("");
                    Console.WriteLine("1) -  ГОЛОВА  - ");
                    Console.WriteLine("2) - ТУЛОВИЩЕ - ");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Предметы: ");
                    if (stat.flaski >= 1)
                    {
                        Console.WriteLine("5) Лечебная колба (кол-во): ");
                        Console.WriteLine(stat.flaski);
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Отсутствуют");
                        Console.WriteLine("");
                    }


                    ConsoleKeyInfo keyatk;
                    keyatk = Console.ReadKey();
                    switch (keyatk.KeyChar)
                    {

                        case '1':

                            int krit = stat.playeratk * 3;
                            Console.WriteLine("");
                            Console.WriteLine("Вы замахнулись по голове противника!");
                            int luck;
                            Random rand = new Random();
                            luck = rand.Next(1, 5);


                            if (luck == 1)
                            {
                                Console.WriteLine("=====================");
                                stat.enemyhealth = stat.enemyhealth - krit;
                                Console.WriteLine("Вы успешно попали по голове! Нанесено урона: ");
                                Console.WriteLine(krit);
                                Console.WriteLine("Здоровье врага: ");
                                Console.WriteLine(stat.enemyhealth);
                                Console.WriteLine("=====================");
                                stat.playeratk += 3;
                                firstenatk -= 2;
                                Console.Beep(310, 500);
                                Thread.Sleep(3000);
                                Console.Clear();

                                stat.enemyturn = true;
                                stat.playerturn = false;
                            }
                            else
                            {
                                Console.WriteLine("=====================");
                                Console.WriteLine("Вы промахнулись!!!");
                                Console.WriteLine("Здоровье врага: ");
                                Console.WriteLine(stat.enemyhealth);
                                Console.WriteLine("=====================");
                                Console.Beep(100, 500);
                                Thread.Sleep(3000);
                                Console.Clear();

                                stat.enemyturn = true;
                                stat.playerturn = false;
                                //break;
                            }
                            break;

                        case '2':

                            Console.WriteLine("");
                            Console.WriteLine("Вы замахнулись в туловище противника!");
                            int luck2;
                            Random rand2 = new Random();
                            luck2 = rand2.Next(1, 3);



                            if (luck2 == 1)
                            {
                                Console.WriteLine("=====================");
                                Console.WriteLine("Вы успешно попали в туловище! Нанесено урона: ");
                                Console.WriteLine(stat.playeratk);
                                stat.enemyhealth = stat.enemyhealth - stat.playeratk;
                                Console.WriteLine("Здоровье врага: ");
                                Console.WriteLine(stat.enemyhealth);
                                Console.WriteLine("=====================");
                                
                                Console.Beep(250, 500);
                                Thread.Sleep(3000);
                                Console.Clear();

                                stat.enemyturn = true;
                                stat.playerturn = false;
                            }
                            else
                            {
                                Console.WriteLine("=====================");
                                Console.WriteLine("Вы промахнулись!!!");
                                Console.WriteLine("Здоровье врага: ");
                                Console.WriteLine(stat.enemyhealth);
                                Console.WriteLine("=====================");
                                stat.playeratk += 1;
                                Console.Beep(100, 500);
                                Thread.Sleep(3000);
                                Console.Clear();

                                stat.enemyturn = true;
                                stat.playerturn = false;
                            }
                            break;

                        case '5':

                            if (stat.flaski >= 1)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("=====================");
                                Console.WriteLine("Вы использовали Лечебную Колбу!");
                                Console.WriteLine("Осталось: ");
                                Console.WriteLine(stat.flaski - 1);



                                stat.health = stat.health + stat.flaskhp;
                                Console.WriteLine("Ваше здоровье: ");
                                Console.WriteLine(stat.health);

                                Thread.Sleep(3000);
                                stat.enemyturn = true;
                                stat.playerturn = false;

                                stat.flaski -= 1;


                            }
                            else
                            {
                                Console.WriteLine("Нет предметов для использования!");
                                Thread.Sleep(3000);
                            }
                            break;



                        default:
                            Console.WriteLine(" <-- Была нажата неназначенная клавиша, авто-атака в туловище. . .");
                            Thread.Sleep(3000);

                            goto case '2';




                    }
                }
                else if (stat.enemyturn == true)
                {

                    Console.WriteLine("Враг атакует!");
                    int luck3;
                    Random rand3 = new Random();
                    luck3 = rand3.Next(1, 3);

                    if (luck3 == 2)
                    {

                        stat.health = stat.health - firstenatk;

                        Console.WriteLine("=====================");
                        Console.WriteLine("Враг атаковал вас! Ваше здоровье: ");
                        Console.WriteLine(stat.health);
                        Console.WriteLine("=====================");
                        Console.Beep(100, 500);

                        stat.playerturn = true;
                        stat.enemyturn = false;
                        Thread.Sleep(3000);
                        Console.Clear();

                    }
                    else
                    {
                        Console.WriteLine("=====================");
                        Console.WriteLine("Враг промахнулся!");
                        Console.WriteLine("=====================");
                        firstenatk += 1;
                        Console.Beep(100, 500);
                        stat.playerturn = true;
                        stat.enemyturn = false;
                        Thread.Sleep(3000);
                        Console.Clear();
                    }
                }


                //if (enemyhealth >= 0)
                //{
                //    break;
                //}
                //else
                //{

                //}
            }
            while (stat.enemyhealth >= 1 ^ stat.health <=0);

            Console.Clear();

            if (stat.health <= 0)
            {
                Console.WriteLine("YOU DIED");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }
            else if (stat.enemyhealth <= 0)
            {
                Console.WriteLine("Противник уничтожен!");

            }





            Console.WriteLine("");
            Console.WriteLine("-------------");
            Console.WriteLine("Здоровье противника:");
            Console.WriteLine(stat.enemyhealth);
            Console.WriteLine("-------------");
            Console.WriteLine("Ваше здоровье: ");
            Console.WriteLine(stat.health);

            if (firstdmg < stat.playeratk)
            {
                Console.WriteLine("За время боя ваши навыки владения мечом улучшились на: ");
                int a = stat.playeratk - firstdmg;
                Console.WriteLine(a);
                Console.WriteLine("Теперь ваше оружие наносит:");
                Console.WriteLine(stat.playeratk);
                Console.WriteLine("Урона!");
                
            }
            else
            {

            }

            Console.Beep(130, 100);
            Console.Beep(262, 100);
            Console.Beep(330, 100);
            Console.Beep(392, 100);
            Console.Beep(523, 100);
            Console.Beep(660, 100);
            Console.Beep(784, 300);
            Console.Beep(660, 300);
            Console.Beep(146, 100);
            Console.Beep(262, 100);
            Console.Beep(311, 100);
            Console.Beep(415, 100);
            Console.Beep(523, 100);
            Console.Beep(622, 100);
            Console.Beep(831, 300);
            Console.Beep(622, 300);
            Console.Beep(155, 100);
            Console.Beep(294, 100);
            Console.Beep(349, 100);
            Console.Beep(466, 100);
            Console.Beep(588, 100);
            Console.Beep(699, 100);
            Console.Beep(933, 300);
            Console.Beep(933, 100);
            Console.Beep(933, 100);
            Console.Beep(933, 100);
            Console.Beep(1047, 400);

            Console.WriteLine("Нажмите любую клавишу для продолжения . . .");

            Console.ReadKey();
            Console.Clear();

        }

        static void BattleEnd()
        {
            byte go;
            do
            {
                Console.Clear();
                Console.WriteLine("Монстр рухнул на землю, от содрогания земли вы еле сдержали равновесие. Израненная туша существа начала испепелятся, спустя некоторое время от нее осталось лишь маленькая кучка пепла");
                
                Console.WriteLine("1) Осмотреть кучку ");
                Console.WriteLine("2) Подождать ");
                Console.WriteLine("3) Найти выход ");

                ConsoleKeyInfo key;
                key = Console.ReadKey();

                switch (key.KeyChar)
                {
                    case '1':
                        Console.Clear();
                        Console.Beep(100, 50);
                        Console.WriteLine("Вы осмотрели кучу и ничего в ней не нашли");
                        Thread.Sleep(2000);
                        go = 0;
                        break;
                    case '2':
                        Console.Clear();
                        Console.Beep(100, 50);
                        Console.WriteLine("Вы подождали но ничего не произошло");
                        Thread.Sleep(2000);
                        go = 0;
                        break;
                    case '3':
                        Console.Clear();
                        Console.Beep(100, 50);
                        Console.WriteLine("Вы осмотрели местность вокруг и нашли рычаг на одной из стен");
                        Thread.Sleep(2000);
                        go = 1;
                        break;

                    default:
                        Console.Beep(50, 70);
                        Console.WriteLine(" <-- Была нажата неназначенная клавиша, переход к первому варианту. . .");
                        Thread.Sleep(3000);

                        goto case '1';
                }
            }
            while (go == 0);



            int go1 = 0;

            do
            {

                Console.Clear();
                Console.WriteLine("Вы осмотрели местность вокруг и нашли рычаг на одной из стен");
                Console.WriteLine("1) Потянуть за рычаг ");


                ConsoleKeyInfo key;
                key = Console.ReadKey();

                switch (key.KeyChar)
                {

                    case '1':
                        Console.Clear();
                        Console.Beep(100, 50);
                        Console.WriteLine("Вы потянули за рычаг и ничего не произошло...");
                        Thread.Sleep(1500);
                        go1 = go1 + 1;
                        break;

                    default:
                        Console.Beep(50, 70);
                        Console.WriteLine(" <-- Была нажата неназначенная клавиша, переход к первому варианту. . .");
                        Thread.Sleep(3000);

                        goto case '1';
                }



            }
            while (go1 <= 3);

            Console.Clear();
            Console.WriteLine("Хотя. . .");
            Thread.Sleep(1500);

            Console.WriteLine("Дверь все-таки открылась. . . ");
            Thread.Sleep(1500);

            Console.Clear();
            Console.WriteLine("Вы вошли в дверь и увидели солнечный свет в далеке пещеры и сразу же ринулись к нему, так как эта пещера вам успела уже изрядно надоесть");
            Thread.Sleep(3000);

            Console.WriteLine("");

            Console.WriteLine("Вы выбежали из пещеры и увидели перед собой степь в далеке виднелся небольшой населенный пункт");
            Thread.Sleep(3000);

            Console.WriteLine("Продолжение следует . . .");
            Console.WriteLine("");
            Thread.Sleep(1000);

            Console.WriteLine("Нажмите любую клавишу для продолжения . . .");

            Console.ReadKey();
            Console.Clear();
            Environment.Exit(0);







        }
    }
}