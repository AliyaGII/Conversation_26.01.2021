using System;

namespace Conversation_26._01._2021
{
    class Converter
    {
        private double usd;
        private double eur;
        private double rub;
        public string val, value;
        public double a;

        public Converter(double usd, double eur, double rub)
        {

            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
        public double SomUsd()
        {
            return Math.Round (a * usd, 3);
        }
        public double SomEur()
        {
            return Math.Round (a * eur, 3);
        }
        public double SomRub ()
        {
            return Math.Round (a * rub, 3);
        }
        public double UsdSom()
        {
            return Math.Round(a / usd, 3);
        }
        public double EurSom()
        {
            return Math.Round(a / eur, 3);
        }
        public double RubSom()
        {
            return Math.Round(a / rub, 3);
        }
        public void Exchange()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Exchange Rates: \ndollar: {usd} \neuro: {eur} \nruble: {rub}");
        }
        public void GetInfo()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (value == "usd")
            {
                Console.WriteLine($"Your amount(Dollar): {a}");
                Console.WriteLine($"Your amount in somoni: {UsdSom()}");
            }
            if (value == "eur")
            {
                Console.WriteLine($"Your amount(Euro): {a}");
                Console.WriteLine($"Your amount in somoni: {EurSom()}");
            }
            if (value == "rub")
            {
                Console.WriteLine($"Your amount(Ruble): {a}");
                Console.WriteLine($"Your amount in somoni: {RubSom()}");
            }
            if (value == "som")
            {
                Console.WriteLine($"Your amount: {a}");

                switch (val)
                {
                    case "usd":
                        Console.WriteLine($"Your amount in dollar: {SomUsd()}");
                        break;
                    case "eur":
                        Console.WriteLine($"Your amount in Euro: {SomEur()}");
                        break;
                    case "rub":
                        Console.WriteLine($"Your amount in ruble: {SomRub()}");
                        break;
                    default:
                        Console.WriteLine("You have entered incorrect text for the currency");
                        break;
                }
            }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your amount: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Converter money = new Converter(0.088, 0.072, 6.88);
            Console.Write("Choose your currency\n( usd, eur, rub, som): ");
            string value = Console.ReadLine();
            money.Exchange();
            if (value == "som")
            {
                Console.Write("Choose which currency you want to transfer:\n(для доллара usd, для евро eur, для рубля rub): ");
                string val = Console.ReadLine();
                money.val = val;
            }
            money.value = value;
            money.a = a; 

            money.GetInfo();
        }
    }
}
