using MegaCastingV2.DBlib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingV2.WPF.ViewModel
{
    public class ViewModelMetier : ViewModelBase
    {
        #region Attributes

        /// <summary>
        /// Collection de Ville
        /// </summary>
        private ObservableCollection<Metier> _Metiers;

        /// <summary>
        /// Ville sélectionnée
        /// </summary>
        private Metier _SelectedMetier;

        #endregion

        #region Properties


        /// <summary>
        /// Obtient ou défini la collection de villes
        /// </summary>
        public ObservableCollection<Metier> Metiers
        {
            get { return _Metiers; }
            set { _Metiers = value; }
        }

        /// <summary>
        /// Obtient ou défini la ville sélectionné
        /// </summary>
        public Metier SelectedMetier
        {
            get { return _SelectedMetier; }
            set { _SelectedMetier = value; }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Permet de lister les villes dans la vue
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelMetier(MegaCastingEntities entities)
            : base(entities)
        {
            this.Entities.Metiers.ToList();
            this.Metiers = this.Entities.Metiers.Local;
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
        public void AddMetier()
        {
            if (!this.Entities.Metiers
                .Any(type => type.Libellée_Metier == "Nouveau")//Si dans la liste de villes il n'existe pas d'élément "Nouveau"
                )
            {
                Metier metier = new Metier();
                metier.Libellée_Metier = "Nouveau";
                this.Metiers.Add(metier);
                this.SaveChanges();
            }
        }

        /// <summary>
        /// Supprime la ville sélectionnée
        /// </summary>
        public void DeleteMetier()
        {
            //Suppression de l'élément
            this.Metiers.Remove(SelectedMetier);
            this.SaveChanges();
        }


        #endregion
    }
}
