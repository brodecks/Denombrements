using System;

namespace Denombrements
{
    class Program
    {
        static void Main(string[] args)
        {
            //decla
            int choix = 1;
            while (choix != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = int.Parse(Console.ReadLine());

                if (choix == 0) { Environment.Exit(0); }

                //choix de la permutation
                if (choix == 1)
                {
                    // saisie du nombre d'éléments à gérer
                    Console.Write("nombre total d'éléments à gérer = "); 
                    int nombre = int.Parse(Console.ReadLine());
                    // calcul de la permutation
                    long permut = 1;
                    for (int k = 1; k <= nombre; k++)
                        permut *= k;
                    //affichage du resultat
                    Console.WriteLine(nombre + "! = " + permut);
                }
                else
                {
                    //choix de l'arrangement
                    if (choix == 2)
                    {
                        // saisie du nombre d'éléments à gérer
                        Console.Write("nombre total d'éléments à gérer = ");
                        int nombre = int.Parse(Console.ReadLine());
                        // saisie du nombre de sous ensemble
                        Console.Write("nombre d'éléments dans le sous ensemble = "); 
                        int sousEnsemble = int.Parse(Console.ReadLine()); 

                        // calcul de l'arrangement
                        long arrangement = 1;
                        for (int k = (nombre - sousEnsemble + 1); k <= nombre; k++)
                            arrangement *= k;
                        //affichage du resultat
                        Console.WriteLine("A(" + nombre + "/" + sousEnsemble + ") = " + arrangement);
                    }
                    else
                    {
                        //choix de la combinaison
                        // saisie du nombre d'éléments à gérer
                        Console.Write("nombre total d'éléments à gérer = "); 
                        int nombre = int.Parse(Console.ReadLine());
                        // saisie du nombre de sous ensemble
                        Console.Write("nombre d'éléments dans le sous ensemble = "); 
                        int SousEnsemble = int.Parse(Console.ReadLine());
                        
                        // calcul de la combinaison
                        long r1 = 1;
                        for (int k = (nombre - SousEnsemble + 1); k <= nombre; k++)
                            r1 *= k;

                        // calcul de la permutation
                        long r2 = 1;
                        for (int k = 1; k <= SousEnsemble; k++)
                            r2 *= k;
                        
                        //affichage du resultat
                        Console.WriteLine("C(" + nombre + "/" + SousEnsemble + ") = " + (r1 / r2));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
