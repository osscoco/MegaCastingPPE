using MegaCastingV2.DBlib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace MegaCastingV2.WPF.ViewModel
{
    /// <summary>
    /// Modèle du Métier héritant du Modèle Base
    /// </summary>
    public class ViewModelMetier : ViewModelBase
    {
        #region Attributes

        /// <summary>
        /// Collection de Métiers
        /// </summary>
        private ObservableCollection<Metier> _Metiers;

        /// <summary>
        /// Metier sélectionné
        /// </summary>
        private Metier _SelectedMetier;

        #endregion

        #region Properties


        /// <summary>
        /// Obtient ou défini la collection de métiers
        /// </summary>
        public ObservableCollection<Metier> Metiers
        {
            get { return _Metiers; }
            set { _Metiers = value; }
        }

        /// <summary>
        /// Obtient ou défini le métier sélectionné
        /// </summary>
        public Metier SelectedMetier
        {
            get { return _SelectedMetier; }
            set { _SelectedMetier = value; }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Permet de lister les métiers dans la vue
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelMetier(MegacastingEntities entities)
            : base(entities)
        {
            this.Entities.Metier.ToList();
            this.Metiers = this.Entities.Metier.Local;
        }

        #endregion


        #region Methods
        /// <summary>
        /// Sauvegarde les modifications lors de l'ajout d'un nouveau métier
        /// </summary>
        public void SaveChanges()
        {
            this.Entities.SaveChanges();
            Entities.ChangeTracker.Entries().Where(type => type.State == System.Data.Entity.EntityState.Modified).ToList().ForEach(type => type.Reload());
            CollectionViewSource.GetDefaultView(Metiers).Refresh();
        }



        /// <summary>
        /// Ajoute une nouveau métier
        /// </summary>
        public void AddMetier()
        {
            if (!this.Entities.Metier
                .Any(type => type.Nom == "Nouveau")//Si dans la liste de métiers il n'existe pas d'élément "Nouveau"
                )
            {
                Metier metier = new Metier();
                metier.Nom = "Nouveau";
                this.Metiers.Add(metier);
                this.SaveChanges();
            }
        }

        /// <summary>
        /// Supprime le métier sélectionné
        /// </summary>
        public void DeleteMetier()
        {
            if (!SelectedMetier.Annonce.Any())
            {
                //Suppression de l'élément
                this.Metiers.Remove(SelectedMetier);
                this.SaveChanges();
            }else
            {
                MessageBox.Show("Ce métier ne peux pas être supprimé car il est déjà lié à une annonce !");
            }
        }


        #endregion
    }
}
