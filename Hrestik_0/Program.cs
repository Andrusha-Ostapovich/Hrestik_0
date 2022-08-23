using System;

namespace Hrestik_0
{
    class Program
    {
        public void Sex()
        {
            XorZero();
            StartByXPlalayer();


        }

        private void XorZero()
        {
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {

            Console.WriteLine("Виберiть чим ви хочете грати X(напиши 1) чи 0(напиши 0)");
            var a = Convert.ToInt32(Console.ReadLine());

            SelectXorZero(a);
        }

        static void SelectXorZero(int selectedValue)
        {
            if (selectedValue == 0)
            {
                Console.WriteLine("Виберiть на якiй позицiї поставити 0 ");
                Console.WriteLine(@$"|1|2|3|
|4|5|6|
|7|8|9|");
            }
            else if (selectedValue == 1)
            {
                Console.WriteLine("Виберiть на якiй позицiї поставити Х ");
                Console.Write("|_|_|_|"); Console.WriteLine("      |1|2|3|");
                Console.Write("|_|_|_|"); Console.WriteLine("      |4|5|6|");
                Console.Write("|_|_|_|"); Console.WriteLine("      |7|8|9|");
                StartByXPlalayer();
            }
            else Console.WriteLine("Ви натиснули не правильно");
        }
        static void StartByXPlalayer()
        {

            // init
            char a1 = '_', a2 = '_', a3 = '_', b1 = '_', b2 = '_', b3 = '_', c1 = '_', c2 = '_', c3 = '_';
            int currentValue;

            bool youWin = false, enemyWin = false;

            // start
            for (int i = 0; i < 100; i++)
            {
                
                Random rnd = new Random();
                int random = rnd.Next(1, 9);

                if (i % 2 == 0)
                {
                    currentValue = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    currentValue = random;
                }
                
                Condition(ref a1, currentValue);
                Condition(ref a2, currentValue);
                Condition(ref a3, currentValue);
                Condition(ref b1, currentValue);
                Condition(ref b2, currentValue);
                Condition(ref b3, currentValue);
                Condition(ref c1, currentValue);
                Condition(ref c2, currentValue);
                Condition(ref c3, currentValue);

                check(a1, a2, a3, b1, b2, b3, c1, c2, c3, youWin, enemyWin);

                if (youWin == true)
                {
                    Console.WriteLine("Ти перемiг(Україна також переможе)");
                    break;
                }
                if (enemyWin == true)
                {
                    Console.WriteLine("Ти проєбав рашцi тож пiзда");
                    break;
                }

                if (i != 1 && i % 2 != 0)
                {
                    Console.Write($"|{a1}|{a2}|{a3}|"); Console.WriteLine("         |1|2|3|");
                    Console.Write($"|{b1}|{b2}|{b3}|"); Console.WriteLine("         |4|5|6|");
                    Console.Write($"|{c1}|{c2}|{c3}|"); Console.WriteLine("         |7|8|9|");
                }

                static void check(char a1, char a2, char a3, char b1, char b2, char b3, char c1, char c2, char c3,  bool youWin, bool enemyWin)
                {
                    if (a1 == a2 && a2 == a3)
                    {
                        if (a1 == 'O')
                            enemyWin = true;
                        else if (a1 == 'X')
                            youWin = true;
                    }
                    else if (b1 == b2 && b2 == b3)
                    {
                        if (b1 == 'O')
                            enemyWin = true;
                        else if (b1 == 'X')
                            youWin = true;
                    }
                    else if (c1 == c2 && c2 == c3)
                    {
                        if (c1 == 'O')
                            enemyWin = true;
                        else if (c1 == 'X')
                            youWin = true;
                    }
                    else if (a1 == b2 && b2 == c3)
                    {
                        if (a1 == 'O')
                            enemyWin = true;
                        else if (a1 == 'X')
                            youWin = true;
                    }
                    else if (a3 == b2 && b2 == c1)
                    {
                        if (a3 == 'O')
                            enemyWin = true;
                        else if (a3 == 'X')
                            youWin = true;
                    }
                    else if (a1 == b1 && b1 == c1)
                    {
                        if (a1 == 'O')
                            enemyWin = true;
                        else if (a1 == 'X')
                            youWin = true;
                    }
                    else if (a2 == b2 && b2 == c2)
                    {
                        if (a2 == 'O')
                            enemyWin = true;
                        else if (a2 == 'X')
                            youWin = true;
                    }
                    else if (a3 == b3 && b3 == c3)
                    {

                        if (a3 == 'O')
                            enemyWin = true;
                        else if (a3 == 'X')
                            youWin = true;
                    }
                    if (youWin != true && youWin != false)
                        Console.WriteLine("Нiчия");


                }
            }
            Console.ReadKey();
        }

        static void Condition(ref char XorO, int currentValue)
        { 
            Random rnd = new Random();
            int random = rnd.Next(1, 9);
            int i = 0;
            if (i % 2 == 0)
            {
                currentValue = random;
            }

                if (currentValue == random)
                {
                if (XorO == 'X')
                {
                    random = rnd.Next(1, 9);
                    currentValue = random;
                }
                else XorO = 'O';
                
            }

            else if (XorO == 'O')
            {
                Console.WriteLine("Ти що кацап? не мухлюй сучка!");
                Console.WriteLine("Продовжуй, зробиш ще таку хуйню получиш пиздюлiн вiд ЗСУ");
            }
            else XorO = 'X';

            if (currentValue > 10)

            {
                Console.WriteLine("Ти ввiв не правильну цифру");
            }
        }
    }
}










// старт