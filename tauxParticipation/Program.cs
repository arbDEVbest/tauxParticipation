using NPoco.Expressions;
using System;

namespace tauxParticipation
{
    class Program
    {
        private static string Question()
        {
            //Déclaration de la variable reponse 
            string Reponse;
            Console.WriteLine("Voulez vous calculé votre taux de participation? o pour Oui et n pour Non");
            Reponse = Console.ReadLine().ToLower();
            // Si le salarié veut calculer son taux de participation
            
            if (Reponse == "o") 
            {
                return Reponse;
            }
            // Si le salarié ne veut pas calculer son taux de participation
            else
            {

                while (Reponse != "o" ) 
                
                {
                    if (Reponse == "n")
                    {
                        break;
                    }
                    Console.WriteLine("Voulez vous calculé votre taux de participation? o pour Oui et n pour Non");
                    Reponse = Console.ReadLine().ToLower();
                    
                }
                return Reponse;
            }
         
        }
        private static string Situation( string SituationFamiliale)
        {
        
        // C pour célibataire
        string C;
        // M pour marié(e)
        string M;
        // V pour veuf
        string V;
        // A pour autre
        string A;
        
       
            
        return SituationFamiliale;

           
        }
        private static bool Salaire(int rep)
        {
            if (rep < 1800)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       private int plafondTaux(int plafTaux)
        {
            if(plafTaux < 50)
            {

            }
        }
        private static void CalculeTaux()
        {
            // Connaitre la situation familiale du salarié(e)
            Console.WriteLine("Quelle est votre situation familiale?" + "\n" + "Pour Célibataire tapez C" + "\n" + "Pour Mariés(e) tapez M" +
            "\n" + "Pour veuf(ve) tapez V" + "\n" + "Toute autre situation tapez A");
            string SitFamiliale = Console.ReadLine().ToUpper();
            Console.WriteLine("Combien votre salaire? ");
            int rep = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nombre d'enfant à charge: ");
            int nb = Convert.ToInt32(Console.ReadLine());
            int taux;
            // Si l'employé(e) est célibataire et son salaire est inférieur à 1800€
           if (Situation(SitFamiliale) == "C" && Salaire(rep) == true)
            {
                string S = (Situation(SitFamiliale));
                Console.WriteLine(S);
                taux = (nb * 15) + 20 + 10;
            }
            else
            {
                // Si l'employé(e) est célibataire et son salaire est supérieur à 1800€ 
                if (Situation(SitFamiliale) == "C" && Salaire(rep) == false)
                {
                    taux = (nb * 15) + 20;
                }
                // Si l'employé(e) n'est pas célibataire 
                else
                {
                    //"son salaire est inférieur à 1800€"
                    if ( Salaire(rep) == false)
                    {
                        taux = (nb * 15) + 25 + 10;
                    }
                    // son salaire est supérieur à 1800€
                    else
                    {
                        taux = (nb * 15) + 25 ;
                    }
                    
                }
            }
            Console.WriteLine(" Le taux de participation de l'employeur est de: " + taux + "%\n\n");
        }
       private  static object TableauEmploye()
        {
            object [,] Tableau_Employe = new object[50,5];
            Tableau_Employe[0, 0] = "Id";
            Tableau_Employe[0, 1] = "Situation du salarié(e)";
            Tableau_Employe[0, 2] = "salaire";
            Tableau_Employe[0, 3] = "Nombre Enfant";
            Tableau_Employe[0, 4] = "Taux";

            return Tableau_Employe;
        }

        static void Main(string[] args)
        {
            int cptr = 0;
            int Compteur = 50;
            do
            {
                if (Question() == "o")
                {

                    CalculeTaux();
                    cptr++;
                }

                Compteur--;
                Console.WriteLine($"Nombre de salarié(e)s qui ont calculé le taux de participation est de: " + (50 - Compteur) + " salariés.\n");
                Console.WriteLine("Appuyez sur la touche entrer pour fermer la fenêtre");

            } while (Console.ReadKey().Key != ConsoleKey.Enter);


        }
    }
}
