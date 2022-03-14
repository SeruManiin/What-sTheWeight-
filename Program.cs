using System;
using System.Threading;
namespace PesoEmOutrosPlanetas
{
    class Program
    {
        public static bool firstTime = true;
        public static WeightTranslator WT = new WeightTranslator();
        public static string title = Title.title;
        static void Main(string[] args)
        {
            run();
        }
        static void run()
        {
            Console.Clear();
            LoadTitle(firstTime);
            firstTime = false;
            Console.Write("What's the mass in Kilograms?: ");
            float weight = 72;
            try
            {
                weight = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("It must be a rounded number");
                Thread.Sleep(1500);
                run();
            }
            showMenu();
            Calculate(AnswerForGravity(), weight);
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                run();
            }
            else if (Console.ReadKey().Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
        public static void showMenu()
        {
                Console.Write("[1] JUPITER\n[2] SATURN\n[3] MOON\n" +
                "[4] URANUS\n[5] MERCURY\n[6] NEPTUNE\n" +
                "[7] VENUS\n[8] EARTH\n[9] SUAMÃE\n" +
                "[10] PLUTO\n[11] SUN\n[12] MARS\n"
                );
        }
        public static float AnswerForGravity()
        {
            int answer = 9;
            Console.Write("Pick a planet or star: ");
            try {
                answer = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("It must be a rounded number");
                Thread.Sleep(1500);
                run();
            }
            float SelectedAnswer = answer;
            switch (answer)
            {
                case 1:
                    SelectedAnswer = GravityOf.Jupiter;
                    break;
                case 2:
                    SelectedAnswer = GravityOf.Saturn;
                    break;
                case 3:
                    SelectedAnswer = GravityOf.Moon;
                    break;
                case 4:
                    SelectedAnswer = GravityOf.Uranus;
                    break;
                case 5:
                    SelectedAnswer = GravityOf.Mercury;
                    break;
                case 6:
                    SelectedAnswer = GravityOf.Neptune;
                    break;
                case 7:
                    SelectedAnswer = GravityOf.Venus;
                    break;
                case 8:
                    SelectedAnswer = GravityOf.Earth;
                    break;
                case 9:
                    SelectedAnswer = GravityOf.SuaMãe;
                    break;
                case 10:
                    SelectedAnswer = GravityOf.Pluto;
                    break;
                case 11:
                    SelectedAnswer = GravityOf.Sun;
                    break;
                case 12:
                    SelectedAnswer = GravityOf.Mars;
                    break;
            }
            return SelectedAnswer;
        }
        public static void Calculate(float Gravity, float Weight)
        {
            WT.HowMuchIWeightAt(Gravity, Weight);
        }
        public static void LoadTitle(bool Delayed)
        {
            for (int i = 0; i < title.Length; i++)
            {
                char ch = title[i];
                Console.Write(ch);
                if (Delayed)
                {
                    Thread.Sleep(01);
                }
            }
            
        }
    }
}
