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
    public class ViewModelProfessionnel : ViewModelBase
    {
        #region Attributes

        /// <summary>
        /// Collection de Professionnels
        /// </summary>
        private ObservableCollection<Professionnel> _Professionnels;

        /// <summary>
        /// Professionnel sélectionné
        /// </summary>
        private Professionnel _SelectedProfessionnel;

        private String _SelectedNom_PRO;

        private String _SelectedPrenom_PRO;

        private String _SelectedMail_PRO;

        private String _SelectedPass_PRO;

        #endregion

        #region Properties


        /// <summary>
        /// Obtient ou défini la collection de Professionnel
        /// </summary>
        public ObservableCollection<Professionnel> Professionnels
        {
            get { return _Professionnels; }
            set { _Professionnels = value; }
        }

        /// <summary>
        /// Obtient ou défini le Professionnel sélectionné
        /// </summary>
        public Professionnel SelectedProfessionnel
        {
            get { return _SelectedProfessionnel; }
            set { _SelectedProfessionnel = value; }
        }

        #endregion

        #region Properties

        public String SelectedNom_PRO
        {
            get { return _SelectedNom_PRO; }
            set { _SelectedNom_PRO = value; }
        }

        public String SelectedPrenom_PRO
        {
            get { return _SelectedPrenom_PRO; }
            set { _SelectedPrenom_PRO = value; }
        }

        public String SelectedMail_PRO
        {
            get { return _SelectedMail_PRO; }
            set { _SelectedMail_PRO = value; }
        }

        public String SelectedPass_PRO
        {
            get { return _SelectedPass_PRO; }
            set { _SelectedPass_PRO = value; }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// Permet de lister les professionnels dans la vue
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelProfessionnel(MegaCastingEntities entities)
            : base(entities)
        {
            this.Entities.Contrats.ToList();
            this.Professionnels = this.Entities.Professionnels.Local;
        }

        #endregion
    }
}
