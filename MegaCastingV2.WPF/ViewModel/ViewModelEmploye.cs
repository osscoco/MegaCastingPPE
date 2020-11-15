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
    public class ViewModelEmploye : ViewModelBase
    {
        #region Attributes

        /// <summary>
        /// Collection d'Employés
        /// </summary>
        private ObservableCollection<Employe> _Employes;

        /// <summary>
        /// Employé sélectionné
        /// </summary>
        private Employe _SelectedEmploye;

        #endregion

        #region Properties


        /// <summary>
        /// Obtient ou défini la collection d'Employés
        /// </summary>
        public ObservableCollection<Employe> Employes
        {
            get { return _Employes; }
            set { _Employes = value; }
        }

        /// <summary>
        /// Obtient ou défini l'Employé sélectionné
        /// </summary>
        public Employe SelectedEmploye
        {
            get { return _SelectedEmploye; }
            set { _SelectedEmploye = value; }
        }


        #endregion
        /// <summary>
        /// Permet de lister les Employés dans la vue
        /// </summary>
        /// <param name="entities"></param>
        #region Constructor
        public ViewModelEmploye(MegaCastingEntities entities)
            : base(entities)
        {
            this.Entities.Employes.ToList();
            this.Employes = this.Entities.Employes.Local;
        }

        #endregion

        public void SaveChanges()
        {
            this.Entities.SaveChanges();
        }

        /// <summary>
        /// Supprime le contrat sélectionné
        /// </summary>
        public void DeleteProfil()
        {
            //Suppression de l'élément
            this.Employes.Remove(SelectedEmploye);
            this.SaveChanges();
        }
    }
}
