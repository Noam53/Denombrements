using System;

namespace Denombrements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool correct;
            int choix = 1;

            while (choix != 0)
            {
                correct = false;
                while (!correct)
                    try
                    {
                        Console.WriteLine("Permutation ...................... 1");
                        Console.WriteLine("Arrangement ...................... 2");
                        Console.WriteLine("Combinaison ...................... 3");
                        Console.WriteLine("Quitter .......................... 0");
                        Console.Write("Choix :                            ");
                        choix = int.Parse(Console.ReadLine());
                        if (!(choix == 0 || choix == 1 || choix == 2 || choix == 3))
                            {
                                Console.WriteLine("Erreur de saisie : Choisissez parmis les 4 possibilités !");
                            }
                        else
                        {
                            correct = true;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Erreur de saisie");
                    }

                
                if (choix == 0) { Environment.Exit(0); }

                if (choix == 1)
                {
                    correct = false;
                    while (!correct)
                    {
                        try
                        {
                            Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                            int n = int.Parse(Console.ReadLine()); // saisir le nombre
                                                                   // calcul de r
                            long r = 1;
                            for (int k = 1; k <= n; k++)
                                r *= k;
                            Console.WriteLine(n + "! = " + r);
                            correct = true;
                        }
                        catch
                        {
                            Console.WriteLine("Erreur de Saisie : Veuillez saisir un nombre entier!");
                        }
                    }
                
                }
                else if (choix == 2)
                {
                    correct = false;
                    while (!correct)
                    {
                        try
                        {
                            Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                            int t = int.Parse(Console.ReadLine()); // saisir le nombre
                            Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                            int n = int.Parse(Console.ReadLine()); // saisir le nombre
                                                                   // calcul de r
                            long r = 1;
                            for (int k = (t - n + 1); k <= t; k++)
                                r *= k;
                            //Console.WriteLine("résultat = " + (r1 / r2));
                            Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                            correct = true;
                        }
                        catch
                        {
                            Console.WriteLine("Erreur de Saisie : Veuillez saisir un nombre entier!");
                        }
                    }
                    
                }
                else
                {
                    correct = false;
                    while (!correct)
                    {
                        try
                        {
                            Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                            int t = int.Parse(Console.ReadLine()); // saisir le nombre
                            Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                            int n = int.Parse(Console.ReadLine()); // saisir le nombre
                                                                   // calcul de r1
                            long r1 = 1;
                            for (int k = (t - n + 1); k <= t; k++)
                                r1 *= k;
                            // calcul de r2
                            long r2 = 1;
                            for (int k = 1; k <= n; k++)
                                r2 *= k;
                            // calcul de r3
                            //Console.WriteLine("résultat = " + (r1 / r2));
                            Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                            correct = true;
                        }
                        catch
                        {
                            Console.WriteLine("Erreur de Saisie : Veuillez saisir un nombre entier!");
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
