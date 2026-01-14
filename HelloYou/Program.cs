using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloYou
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Récupération de la date et heure actuelles
            DateTime Time = DateTime.Now;
            string formatJour = "dddd d MMMM"; //dddd affiche le jour de la semaine en entier, d affiche le jour en chiffre et MMMM affiche le mois en entier
            string formatHeures = "HH:mm";

            Console.WriteLine("Quel est ton prénom ?");
            string prenom = Console.ReadLine();

            Console.WriteLine($"Salut {prenom}, bienvenue dans le monde du C# !\nNous sommes le {Time.ToString (formatJour)} et il est actuellement {Time.ToString (formatHeures)}"); //Time.ToString convertit la valeur des strings en date, sinon apparaîtrait comme "dddd d MMMM"

        }
    }
}
