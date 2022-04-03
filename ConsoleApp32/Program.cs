using System;

namespace ConsoleApp32
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rand = new Random();
            int n;
            Jeden Artur = new Jeden();
            // Artur.Wiek = 300;
            // Artur.Wiek = 1;
            // Console.WriteLine(Artur.Wiek);
            /*Console.WriteLine("Podaj n: ");
            n = Convert.ToInt32(Console.ReadLine());
            
            Artur.ChrismassTree();
            int a = Artur.Fibonacci(n);
            Console.WriteLine(a);
            Artur.PrimeNumbers();
            Artur.RPS();
            */
            //Artur.RString();
            //Artur.Alarm();
            //Artur.WCT();
            //ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
            //string fruit = "apple,orange,banana";
            // Console.WriteLine("Found orange in position: " + fruit.IndexOf("orange"));
            //Console.WriteLine("Found lemon in position: " + fruit.IndexOf("lemon"));
            //Artur.Fa();
            //Artur.Delta();
            //Artur.BMI();
            /* int[] a = new int[100];
             for (int i = 0; i < a.Length; i++) {
                 a[i] = rand.Next(1, 1000);
                 if (Artur.Xd(a[i]) == true) {
                     Console.WriteLine(a[i]);
                 }
             }*/
            /*int[] b = { 1,2,3,4,5,6,7,8,9,0};
            int[] c = new int[10];
            for (int i = 0; i < c.Length - 1; i++) {
                c[i] = b[i + 1];
                c[c.Length-1] = 0;
            }
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }*/
            /*int[,] a = { { 1, 2, 3, 4, 5 }, {2,3,4,5,6 }, {3,4,5,6,7 }, {4,5,6,7,8 }, {5,6,7,8,9 } };
            for (int i = 0; i < a.GetLength(0); i++) {
                Console.WriteLine(a[i,i]);
            }*/
            /*int[,] a = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            int[,] b = { { 7, 8 }, { 9, 0 }, { 10, 11 } };
            int[,] c = new int[3,2];
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }
            for (int z = 0; z < c.GetLength(0); z++)
            {
                for (int x = 0; x < c.GetLength(1); x++)
                {
                    Console.Write("{0,3}", c[z, x]);
                }
            }
            */
            /* string[,] dniTygodnia;
             dniTygodnia = new string[7, 3]; // pamiętaj o zmianie rozmiaru tablicy
             dniTygodnia[0, 0] = "poniedzialek";
             dniTygodnia[1, 0] = "wtorek";
             dniTygodnia[2, 0] = "sroda";
             dniTygodnia[3, 0] = "czwartek";
             dniTygodnia[4, 0] = "piatek";
             dniTygodnia[5, 0] = "sobota";
             dniTygodnia[6, 0] = "niedziela";
             dniTygodnia[0, 1] = "monday";
             dniTygodnia[1, 1] = "tuesday";
             dniTygodnia[2, 1] = "Asroda";
             dniTygodnia[3, 1] = "Aczwartek";
             dniTygodnia[4, 1] = "Apiatek";
             dniTygodnia[5, 1] = "Asobota";
             dniTygodnia[6, 1] = "Aniedziela";
             dniTygodnia[0, 2] = "montag";
             dniTygodnia[1, 2] = "dienstag";
             dniTygodnia[2, 2] = "3dienstag";
             dniTygodnia[3, 2] = "4dienstag";
             dniTygodnia[4, 2] = "5dienstag";
             dniTygodnia[5, 2] = "6dienstag";
             dniTygodnia[6, 2] = "7dienstag";

             for (int i = 0; i < dniTygodnia.GetLength(0); i++) {
                 Console.Write(" " + dniTygodnia[i,0]);
             }
             Console.WriteLine();
             for (int i = 0; i < dniTygodnia.GetLength(0); i++)
             {
                 Console.Write(" " + dniTygodnia[i, 1]);
             }
             Console.WriteLine();
             for (int i = 0; i < dniTygodnia.GetLength(0); i++)
             {
                 Console.Write(" " + dniTygodnia[i, 2]);
             }
             */
            /* Console.WriteLine("Napisz coś: ");
             string a = Console.ReadLine();
             int b = 1;
             if (string.IsNullOrEmpty(a)) Console.WriteLine("0");
             else
             {
                 foreach (char x in a)
                 {
                     if (x == ' ') b++;
                 }

                 Console.WriteLine(b);
             }
             */
            string tekst = "być albo nie być";
            int pozycja, start = 0;
            Console.WriteLine("0123456789012345"); // pomocniczo, aby numerować znaki
            Console.WriteLine(tekst);
            Console.WriteLine("szukany tekst \"być\" jest na pozycjach:");
          
 while ((pozycja = tekst.IndexOf("być", start)) >= 0)
            {
                Console.Write("{0}, ", pozycja);
                start = pozycja + 3; // dalsze szukanie 3 znaki dalej (bo "być" ma 3 znaki)
            }
            Console.ReadKey();
        }

        class Jeden
        {
            private int _wiek;
            private String _imie;

            public int Wiek
            {
                get
                {
                    return _wiek;
                }
                set
                {
                    if (value > 0) { _wiek = value; }
                }

            }
            public void ChrismassTree()
            {
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write(" ");
                    }
                    {
                        for (int l = 10; l >= i; l--)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine(" ");
                    }
                }
            }
            public int Fibonacci(int n)
            {
                if (n == 0) return 0;
                else if (n == 1) return 1;
                else
                {
                    int x = Fibonacci(n - 1) + Fibonacci(n - 2);
                    return x;
                }
            }
            public void PrimeNumbers()
            {
                int x = 100;
                Console.WriteLine("Liczby pierwsze do 100");
                for (int a = 2; a <= x; a++)
                {
                    bool isPrime = true;
                    for (int j = 2; j < a; j++)
                    {
                        if ((a % j) == 0)
                        {
                            isPrime = false;
                        }
                    }
                    if (isPrime == true)
                    {
                        Console.WriteLine(a);
                    }
                }
            }
            public void RPS()
            {
                Random rnd = new Random();
                Console.WriteLine("Rock(1), paper(2) or scissors(3)?");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = rnd.Next(1, 4);
                /* 1 - Rock
                  2 - Paper
                  3 - Scissors
                 */
                Console.WriteLine("You took: " + a);
                Console.WriteLine("Computer took: " + b);
                if (a == b) Console.WriteLine("A TIE!");
                else if (a == 1 && b == 2 || a == 2 && b == 3 || a == 3 && b == 1) Console.WriteLine("You lost! :(");
                else if (a == 1 && b == 3 || a == 2 && b == 1 || a == 3 && b == 2) Console.WriteLine("You won! :D");
            }
            public void RString()
            {
                Console.WriteLine("Give String to reverse: ");
                string a = Console.ReadLine();
                char[] arr;
                arr = a.ToCharArray();
                Array.Reverse(arr);
                string b = string.Join("", arr);
                Console.WriteLine(b);
            }
            public void Alarm()
            {
                DateTime thisDay = DateTime.Now;
                Console.Write(thisDay);
                Console.WriteLine("Podaj czas Alarmu w formacie(DD.MM.YYYY HH:MM): ");
                DateTime a = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine(a);
                if (a == thisDay) { Console.WriteLine("Alarm!"); }
                else Console.WriteLine("Gówno");
            }
            public void WCT()
            {
                Console.WriteLine("Podaj liczbę wraz z znakiem: ");
                string a = Console.ReadLine();
                bool b = a.Contains("$");
                bool e = a.Contains("€");
                if (b)
                {

                    string c = a.Trim(new char[] { '$', ' ' });
                    int d = Convert.ToInt32(c);
                    Console.WriteLine("Zamiana na PLN(4,05):  " + d * 4.05);
                    Console.WriteLine("Zamiana na EURO(): " + d * 0.88);
                }
                if (e)
                {
                    string c = a.Trim(new char[] { '€', ' ' });
                    int d = Convert.ToInt32(c);
                    Console.WriteLine("Zamiana na PLN(4,05):  " + d * 4.58);
                    Console.WriteLine("Zamiana na EURO(): " + d * 1.88);
                }
            }
            public void Fa()
            {

                Console.WriteLine("Podaj temperaturę w stopniach Celsjusza");
                double a = Convert.ToDouble(Console.ReadLine());
                double f = ((9.00 / 5.00) * a) + 32;
                Console.WriteLine("Farenheit: " + f);
            }
            public void Delta()
            {
                Console.WriteLine("Podaj A : ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj B : ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj C : ");
                double c = Convert.ToDouble(Console.ReadLine());
                double d = Math.Pow(b, 2) - (4 * a * c);
                Console.WriteLine("Delta: " + d);
            }
            public void BMI()
            {
                Console.WriteLine("Podaj wzrost w metrach: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj wagę w kilogramach: ");
                double b = Convert.ToDouble(Console.ReadLine());
                double BMI = (b / Math.Pow(a, 2));
                Console.WriteLine(BMI);
            }
            public bool Xd(int a)
            {
                if (a < 2)
                    return true;
                else
                {
                    for (int i = 2; i * i <= a; i++)
                    {
                        if (a % i == 0)
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
        }

    }
}

