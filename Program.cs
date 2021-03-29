using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Guessing_Game
{
    class Program
    {
        static int round_numbers;
        static int point_p1 = 0;
        static int point_p2 = 0;
        static string name_p1;
        static string name_p2;
        static string entered_word;
        public static void main()
        {
            Console.WriteLine("***Welcome To The Guessing Game***");
            Console.Write("Press 'S' to start the game or 'E' to exit:");
            string answer = Console.ReadLine();
            if (answer == "s" || answer == "S")
            {
                start();
            }
            else if (answer == "e" || answer == "E")
            {
                exist();
            }
            else
            {
                Console.Clear();
                main();
            }
        }
        public static void start()
        {
            Console.WriteLine("================");
            Console.WriteLine("*start the game*");
            Console.WriteLine("================");
            Console.Write("player1, Enter your name: ");
            name_p1 = Console.ReadLine();
            Console.Write("player2, Enter your name: ");
            name_p2 = Console.ReadLine();
            Console.Write("How many rounds would you like to play?:");
            round_numbers = int.Parse(Console.ReadLine());
            Console.WriteLine("Hello " + "'" + name_p1 + " and " + "'" + name_p2 + "'");
            Console.WriteLine("Welcome to the game");
            Console.WriteLine("___________________________________________________________________");
            for (int i = 1; i <= round_numbers; i++)
            {
                Console.WriteLine("------------");
                Console.WriteLine("Round - " + i);
                Console.WriteLine("------------");
                play();
            }
            Console.WriteLine("---------------------------");
            if (point_p1 > point_p2)
            {
                Console.WriteLine("The result:" + "*" + name_p1 + " is winner*");
            }
            else if (point_p2 > point_p1)
            {
                Console.WriteLine("The result:" + "*" + name_p2 + " is winner*");
            }
            else
            {
                Console.WriteLine("The result:" + "*Equal*");
            }
            Console.WriteLine(name_p1 + ": " + point_p1);
            Console.WriteLine(name_p2 + ": " + point_p2);
            Console.WriteLine("---------------------------");
        }
        public static void play()
        {
            Console.Write("player1, Enter the word:");
            entered_word = Console.ReadLine();
            Console.Clear();
            random_sorting();
            string TheGuessing;
            Console.Write("player2, Enter the word:");
            TheGuessing = Console.ReadLine();
            if (TheGuessing == entered_word)
            {
                Console.WriteLine("Currect!");
                point_p2 += 1;
                Console.WriteLine(name_p2 + ": " + point_p2);
                Console.WriteLine(name_p1 + ": " + point_p1);
            }
            else
            {
                Console.WriteLine("Wrong!");
                Console.WriteLine("The currect order is: " + entered_word);
                point_p1 += 1;
                Console.WriteLine(name_p1 + ": " + point_p1);
                Console.WriteLine(name_p2 + ": " + point_p2);
            }
        }
        public static void exist()
        {
            Console.WriteLine("exit from the game");
        }

        public static void random_sorting()
        {
            char[] entered_word_array = entered_word.ToCharArray();
            string even_word = "";
            string odd_word = "";
            string total_word = "";
            foreach (char item in entered_word_array)
            {
                int index = Array.IndexOf(entered_word_array, item);
                if (index % 2 == 0)
                {
                    even_word = even_word + item;
                }
                else
                {
                    odd_word = odd_word + item;
                }
            }
            total_word = even_word + odd_word;
            Console.WriteLine("The word after sorting: " + total_word);
        }
        static void Main(string[] args)
        {
            Program.main();
        }
    }
}
