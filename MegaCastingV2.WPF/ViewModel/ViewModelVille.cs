using MegaCastingV2.DBlib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms.VisualStyles;

namespace MegaCastingV2.WPF.ViewModel
{
    public class ViewModelVille : ViewModelBase
    {
        #region Attributes

        /// <summary>
        /// Collection de Ville
        /// </summary>
        private ObservableCollection<Ville> _Villes;

        /// <summary>
        /// Ville sélectionnée
        /// </summary>
        private Ville _SelectedVille;

        #endregion

        #region Properties


        /// <summary>
        /// Obtient ou défini la collection de villes
        /// </summary>
        public ObservableCollection<Ville> Villes
        {
            get { return _Villes; }
            set { _Villes = value; }
        }

        /// <summary>
        /// Obtient ou défini la ville sélectionné
        /// </summary>
        public Ville SelectedVille
        {
            get { return _SelectedVille; }
            set { _SelectedVille = value; }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Permet de lister les villes dans la vue
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelVille(MegaCastingEntities entities)
            : base(entities)
        {
            this.Entities.Villes.ToList();
            this.Villes = this.Entities.Villes.Local;
        }

        #endregion


        #region Methods

        /// <summary>
        /// Sauvegarde les modifications
        /// </summary>
        public void SaveChangesVerifySauvegarde()
        {
            //if(!this.Entities.Contrats
            //.Any(contrat => contrat.ID_Contrat == 0 && contrat.Libelle_Contrat == SelectedContrat.Libelle_Contrat && SelectedContrat.ID_Contrat != contrat.ID_Contrat)
            //)//Si un Id_Contrat est différent de 0 et un Libelle_Contrat est différent de Libelle_Selected et Si un Id Contrat est différent de Id Selected au moment (Au moment de modifier)
            //{
            this.Entities.SaveChanges();
            // }
            // else
            //{
            //MessageBox.Show("Vous avez déjà une ville de ce nom !");
            //}
        }

        public void SaveChanges()
        {
            this.Entities.SaveChanges();
        }



        /// <summary>
        /// Ajoute une nouvelle ville
        /// </summary>
        public void AddVille()
        {
            if (!this.Entities.Villes
                .Any(type => type.Libellée_VILLE == "Nouveau")//Si dans la liste de villes il n'existe pas d'élément "Nouveau"
                )
            {
                Ville ville = new Ville();
                ville.Libellée_VILLE = "Nouveau";
                this.Villes.Add(ville);
                this.SaveChanges();
            }
        }

        /// <summary>
        /// Supprime la ville sélectionnée
        /// </summary>
        public void DeleteVille()
        {
            //Suppression de l'élément
            this.Villes.Remove(SelectedVille);
            this.SaveChanges();
        }


        #endregion
    }
}
