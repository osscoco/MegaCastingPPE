using MegaCastingV2.DBlib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Forms.VisualStyles;

namespace MegaCastingV2.WPF.ViewModel
{
    /// <summary>
    /// Modèle du Contrat héritant du Modèle Base
    /// </summary>
    public class ViewModelContrat : ViewModelBase
    {
        #region Attributes

        /// <summary>
        /// Collection de contrats
        /// </summary>
        private ObservableCollection<Contrat> _Contrats;

        /// <summary>
        /// Contrat sélectionné
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
        /// Obtient ou défini le contrat sélectionné
        /// </summary>
        public Contrat SelectedContrat
        {
            get { return _SelectedContrat; }
            set { _SelectedContrat = value; }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Permet de lister les contrats dans la vue
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelContrat(MegacastingEntities entities)
            :base(entities)
        {
            this.Entities.Contrat.ToList();
            this.Contrats = this.Entities.Contrat.Local;//Fullname et ToString
        }

        #endregion

        #region Methods
        /// <summary>
        /// Sauvegarde les modifications lors de l'ajout d'un nouveau contrat
        /// </summary>
        public void SaveChanges()
        {
            this.Entities.SaveChanges();
            Entities.ChangeTracker.Entries().Where(type => type.State == System.Data.Entity.EntityState.Modified).ToList().ForEach(type => type.Reload());
            CollectionViewSource.GetDefaultView(Contrats).Refresh();
        }



        /// <summary>
        /// Ajoute un nouveau contrat
        /// </summary>
        public void AddContrat()
        {
            if (!this.Entities.Contrat
                .Any(type => type.Nom == "Nouveau")//Si dans la liste de contrats il n'existe pas d'élément "Nouveau"
                )
            {
                Contrat contrat = new Contrat();
                contrat.Nom = "Nouveau";
                this.Contrats.Add(contrat);
                this.SaveChanges();
            }
        }

        /// <summary>
        /// Supprime le contrat sélectionné
        /// </summary>
        public void DeleteContrat()
        {
            if (!SelectedContrat.Annonce.Any())
            {
                //Suppression de l'élément
                this.Contrats.Remove(SelectedContrat);
                this.SaveChanges();
            }
            else
            {
                MessageBox.Show("Ce contrat ne peux pas être supprimé car il est déjà lié à une annonce !");
            }

        }
        #endregion

    }
}