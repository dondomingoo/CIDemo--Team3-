namespace konsolprojekt
{
    internal class Program
    {
        static void Main()
        {
            ICalculator calculator = new Calculator();

            while (true)
            {
                Console.WriteLine("\nVælg en operation:");
                Console.WriteLine("1. Plus");
                Console.WriteLine("2. Minus");
                Console.WriteLine("3. Gange");
                Console.WriteLine("4. Dividere");
                Console.WriteLine("5. Potens");
                Console.WriteLine("6. Kvadratrod");
                Console.WriteLine("0. Afslut");
                Console.Write("Valg: ");

                string input = Console.ReadLine();
                if (input == "0") break;

                try
                {
                    switch (input)
                    {
                        case "1":
                            Console.Write("Indtast første tal: ");
                            Console.Write("Indtast første tal: ");
                            if (!int.TryParse(Console.ReadLine(), out int a1))
                            {
                                Console.WriteLine("Ugyldigt input. Prøv igen.");
                                break;
                            }
                            Console.Write("Indtast andet tal: ");
                            if (!int.TryParse(Console.ReadLine(), out int b1))
                            {
                                Console.WriteLine("Ugyldigt input. Prøv igen.");
                                break;
                            }
                            Console.WriteLine("Resultat: " + calculator.Add(a1, b1));
                            break;
                        case "2":
                            Console.Write("Indtast første tal: ");
                            Console.Write("Indtast første tal: ");
                            if (!int.TryParse(Console.ReadLine(), out int a2))
                            {
                                Console.WriteLine("Ugyldigt input. Prøv igen.");
                                break;
                            }
                            Console.Write("Indtast andet tal: ");
                            if (!int.TryParse(Console.ReadLine(), out int b2))
                            {
                                Console.WriteLine("Ugyldigt input. Prøv igen.");
                                break;
                            }
                            Console.WriteLine("Resultat: " + calculator.Subtract(a2, b2));
                            break;
                        case "3":
                            Console.Write("Indtast første tal: ");
                            Console.Write("Indtast første tal: ");
                            if (!int.TryParse(Console.ReadLine(), out int a3))
                            {
                                Console.WriteLine("Ugyldigt input. Prøv igen.");
                                break;
                            }
                            Console.Write("Indtast andet tal: ");
                            if (!int.TryParse(Console.ReadLine(), out int b3))
                            {
                                Console.WriteLine("Ugyldigt input. Prøv igen.");
                                break;
                            }
                            Console.WriteLine("Resultat: " + calculator.Multiply(a3, b3));
                            break;
                        case "4":
                            Console.Write("Indtast første tal: ");
                            Console.Write("Indtast første tal: ");
                            if (!int.TryParse(Console.ReadLine(), out int a4))
                            {
                                Console.WriteLine("Ugyldigt input. Prøv igen.");
                                break;
                            }
                            Console.Write("Indtast andet tal: ");
                            if (!int.TryParse(Console.ReadLine(), out int b4))
                            {
                                Console.WriteLine("Ugyldigt input. Prøv igen.");
                                break;
                            }
                            Console.WriteLine("Resultat: " + calculator.Divide(a4, b4));
                            break;
                        case "5":
                            Console.Write("Indtast tal: ");
                            Console.Write("Indtast tal: ");
                            if (!double.TryParse(Console.ReadLine(), out double baseNum))
                            {
                                Console.WriteLine("Ugyldigt input. Prøv igen.");
                                break;
                            }
                            Console.Write("Indtast eksponent: ");
                            if (!double.TryParse(Console.ReadLine(), out double exponent))
                            {
                                Console.WriteLine("Ugyldigt input. Prøv igen.");
                                break;
                            }
                            Console.WriteLine("Resultat: " + calculator.Power(baseNum, exponent));
                            break;
                        case "6":
                            Console.Write("Indtast tal: ");
                            Console.Write("Indtast tal: ");
                            if (!double.TryParse(Console.ReadLine(), out double sqr))
                            {
                                Console.WriteLine("Ugyldigt input. Prøv igen.");
                                break;
                            }
                            Console.WriteLine("Resultat: " + calculator.SquareRoot(sqr));
                            break;
                        default:
                            Console.WriteLine("Ugyldigt valg.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Fejl: " + ex.Message);
                }
            }

            Console.WriteLine("Farvel!");
        }
    }
}
