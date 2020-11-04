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
    public class ViewModelContrat : ViewModelBase
    {
        #region Attributes

        /// <summary>
        /// Collection de contrats
        /// </summary>
        private ObservableCollection<Contrat> _Contrats;

        /// <summary>
        /// Type de contrat sélectionné
        /// </summary>
        private Contrat _SelectedContrat;

        #endregion

        #region Properties


        /// <summary>
        /// Obtient ou défini la collection de contrats
        /// </summary>
        public ObservableCollection<Contrat> Contrats
        {
            get { return _Contrats; }
            set { _Contrats = value; }
        }

        /// <summary>
        /// Obtient ou défini le type de contrat sélectionné
        /// </summary>
        public Contrat SelectedContrat
        {
            get { return _SelectedContrat; }
            set { _SelectedContrat = value; }
        }

        #endregion

        #region Constructor

        public ViewModelContrat(MegaCastingEntities entities)
            :base(entities)
        {
            this.Entities.Contrats.ToList();
            this.Contrats = this.Entities.Contrats.Local;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Sauvegarde les modifications
        /// </summary>
        public void SaveChangesVerifySauvegarde()
        {
            if(!this.Entities.Contrats
                .Any(contrat => contrat.ID_Contrat == 0 && contrat.Libelle_Contrat == SelectedContrat.Libelle_Contrat && SelectedContrat.ID_Contrat != contrat.ID_Contrat)
                )//Si un Id_Contrat est différent de 0 et un Libelle_Contrat est différent de Libelle_Selected et Si un Id Contrat est différent de Id Selected au moment (Au moment de modifier)
            {
                this.Entities.SaveChanges();
              }
              else
              {
                MessageBox.Show("Vous avez déjà un contrat de ce nom !");
              }
        }

        public void SaveChanges()
        {
            this.Entities.SaveChanges();
        }



        /// <summary>
        /// Ajoute un nouveau type de contrat
        /// </summary>
        public void AddContrat()
        {
            if (!this.Entities.Contrats
                .Any(type => type.Libelle_Contrat == "Nouveau")//Si dans la liste de contrats il n'existe pas d'élément "Nouveau"
                )
            {
                Contrat contrat = new Contrat();
                contrat.Libelle_Contrat = "Nouveau";
                this.Contrats.Add(contrat);
                this.SaveChanges();
                this._SelectedContrat = contrat;
            }
        }
        
        /// <summary>
        /// Supprime le contrat sélectionné
        /// </summary>
        public void DeleteContrat()
        {
            // Vérification si on a le droit de supprimer

            //Suppression de l'élément
            this.Contrats.Remove(SelectedContrat);
            this.SaveChanges();
        }


        #endregion

    }
}