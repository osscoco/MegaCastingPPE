using MegastingV2.DBlib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingV2.AppV1
{
    class Program
    {
        /// <summary>
        /// Categories
        /// </summary>
        private static List<Category> _Categories = null;
        
        /// <summary>
        /// Bières
        /// </summary>
        private static List<Beer> _Beers = null;


        static void Main(string[] args)
        {
            #region Présentation LinQ

            #region Datas generation

            #region Categories

            _Categories = new List<Category>();
            _Categories.Add(new Category("Brune"));
            _Categories.Add(new Category("Blonde"));
            _Categories.Add(new Category("Ambrée"));

            #endregion

            #region Bières

            _Beers = new List<Beer>();

            Category blondCategory = _Categories
                .First(category => category.Name == "Blonde");
            _Beers.Add(new Beer("Leffe", 5, blondCategory));
            _Beers.Add(new Beer("Despe", 4.7, blondCategory));
            _Beers.Add(new Beer("Corona", 4.2, blondCategory));
            _Beers.Add(new Beer("Chouffe", 7.2, blondCategory));
            _Beers.Add(new Beer("La levrette", 3.5, blondCategory));
            _Beers.Add(new Beer("La mort subite", 6, blondCategory));
            _Beers.Add(new Beer("La lancelot", 4.2, blondCategory));
            _Beers.Add(new Beer("La morgane", 5.5, blondCategory));

            Category bitterCategory = _Categories
                .First(category => category.Name == "Brune");
            _Beers.Add(new Beer("Leffe rituelle", 12, bitterCategory));
            _Beers.Add(new Beer("Bavaria", 9, bitterCategory));
            _Beers.Add(new Beer("BrewDog IPA Punk", 5, bitterCategory));
            _Beers.Add(new Beer("Guinness", 5, bitterCategory));
            _Beers.Add(new Beer("Stephanus", 5, bitterCategory));


            Category amberCategory = _Categories
                .First(category => category.Name == "Ambrée");
            _Beers.Add(new Beer("Leffe ambrée", 9, amberCategory));
            _Beers.Add(new Beer("Kwak", 8, amberCategory));
            _Beers.Add(new Beer("Queue de charrue", 7.7, amberCategory));












            #endregion

            #endregion

            #region Exemple de requêtes linQ

            Console.WriteLine("bwahhh");
            Console.ReadKey(); // Attend la saisie d'une touche
            //Nombre de bière total
            Console.WriteLine("1 - Nombre de bières : " + _Beers.Count().ToString());

           //Afficher toutes les bières
            _Beers.ForEach(beer => Console.WriteLine(beer.Name));
            // La somme des degrées des bières brunes

            Console.WriteLine("2 - Degrés totaux : " 
                + _Beers
                .Where(beer => beer.Category.Name == "Brune")
                .Sum(beer => beer.Degrees)
                .ToString());

            // La liste des catégories en passant par les bières (faisable en deux fois si trop complexe pour vous)
            Console.WriteLine("3 - Listes des catégories : ");
            _Beers
                .Select(beer => beer.Category)
                .Distinct()
                .ToList()
                .ForEach(category => Console.WriteLine(category.Name));

            Console.ReadKey();

            // La liste des bières blondes
            _Beers.Where(beer => beer.Category.Name == "Blonde")
                .ToList()
                .ForEach(beer => Console.WriteLine(beer.Name));

            // La liste des bières à 6 degrés
            _Beers.Where(beer => beer.Degrees == 6)
                .ToList()
                .ForEach(beer => Console.WriteLine(beer.Name));

            // Les bières les plus fortes
            List<Beer> beers = _Beers.Where(beer => beer.Degrees >= _Beers
                            .Select(beerTemp => beerTemp.Degrees)
                            .Max()
                ).ToList();



            Console.WriteLine("Les bières les plus fortes (" + _Beers
                .Max(beer => beer.Degrees) + "°) :");
            beers.ForEach(beer => Console.WriteLine(beer.Name));

            Console.ReadKey();
            #endregion

            #endregion


            #region Présentation EF 

            MegaCastingEntities entities = new MegaCastingEntities();

            entities.Countries.Where(country => country.Name == "France");

            #endregion









        }
    }
}
