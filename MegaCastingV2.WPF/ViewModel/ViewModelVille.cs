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
    /// Modèle de Ville héritant du Modèle Base 
    /// </summary>
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
        public ViewModelVille(MegacastingEntities entities)
            : base(entities)
        {
            this.Entities.Ville.ToList();
            this.Villes = this.Entities.Ville.Local;
        }

        #endregion


        #region Methods
        /// <summary>
        /// Sauvegarder une ville existante
        /// </summary>
        public void SaveChanges()
        {
            this.Entities.SaveChanges();
            Entities.ChangeTracker.Entries().Where(type => type.State == System.Data.Entity.EntityState.Modified).ToList().ForEach(type => type.Reload());
            CollectionViewSource.GetDefaultView(Villes).Refresh();
        }



        /// <summary>
        /// Ajoute une nouvelle ville
        /// </summary>
        public void AddVille()
        {
            if (!this.Entities.Ville
                .Any(type => type.Nom == "Nouveau")//Si dans la liste de villes il n'existe pas d'élément "Nouveau"
                )
            {
                Ville ville = new Ville();
                ville.Nom = "Nouveau";
                this.Villes.Add(ville);
                this.SaveChanges();
            }
        }

        /// <summary>
        /// Supprime la ville sélectionnée
        /// </summary>
        public void DeleteVille()
        {
            if (!SelectedVille.Annonce.Any())
            {
                //Suppression de l'élément
                this.Villes.Remove(SelectedVille);
                this.SaveChanges();
            }else
            {
                MessageBox.Show("Cette ville ne peux pas être supprimé car il est déjà lié à une annonce !");
            }
        }


        #endregion
    }
}
