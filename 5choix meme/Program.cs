using System;

namespace Labo3Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable et fonction(si necessaires)


            int[] tabRes = new int[300];
            int varcompargrand = 0;
            int varcomparpetit = 10001;
            int moyenne = 0;


            int genererNombre()

            {
                Random nombre = new Random();
                int nombrealea = nombre.Next(1, 10001);
                return nombrealea;
            }
            for (int i = 0; i < tabRes.Length; i++)
            {
                tabRes[i] = genererNombre();

                if (varcompargrand < tabRes[i])
                {
                    varcompargrand = tabRes[i];
                }
                if (varcomparpetit > tabRes[i])
                {
                    varcomparpetit = tabRes[i];
                }
                moyenne += tabRes[i] / tabRes.Length;
            }
            bool fin = true;
            while (fin == true)
            {
                int compteur = 0;
                bool find = false;
                Console.WriteLine("Bonjour");

                Console.WriteLine("Appuyer sur 1 pour trouver le plus grand nombre du tableau.");

                Console.WriteLine("Appuyer sur 2 pour trouver le plus petit nombre du tableau.");

                Console.WriteLine("Appuyer sur 3 pour entrer un nombre et v/rifier s'il existe dans le tableau.");

                Console.WriteLine("Appuyer sur 4 pour trouver la moyenne des nombres du tableau.");

                Console.WriteLine("Appuyer sur 5 pour quitter.");
                int choix1 = 0;
                choix1 = Convert.ToInt32(Console.ReadLine());

                switch (choix1)
                {
                    case 1:
                        Console.WriteLine("Le nombre le plus grand est : " + varcompargrand);
                        break;
                    case 2:
                        Console.WriteLine("Le nombre le plus petit est : " + varcomparpetit);
                        break;
                    case 3:
                        Console.WriteLine("Entrer le nombre a trouver");
                        int choix2 = 0;
                        choix2 = Convert.ToInt32(Console.ReadLine());
                        while (find == false && compteur < tabRes.Length)
                        {
                            if (choix2 == tabRes[compteur])
                            {
                                find = true;
                            }
                            else
                            {
                                compteur++;
                            }
                        }
                        if (find == true)
                        {
                            Console.WriteLine("Le chiffre existe!");
                        }
                        else
                        {
                            Console.WriteLine("Le chiffre n'existe pas!");
                        }
                        break;

                    case 4:
                        Console.WriteLine("La moyenne est de : " + moyenne);

                        break;
                    case 5:
                        fin = false;

                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }

        }

    }
}
