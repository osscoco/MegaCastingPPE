using MegaCastingV2.DBlib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingV2.WPF.ViewModel
{

    /// <summary>
    /// Base des modèle-vues. Contient tous les élements que l'on retrouve systématiquement dans les vues
    /// </summary>
    public abstract class ViewModelBase
    {


        private Employe _CurrentEmployee;

        public Employe CurrentEmployee
        {
            get { return _CurrentEmployee; }
            set { _CurrentEmployee = value; }
        }
        #region Attributes

        /// <summary>
        /// Contexte de l'application
        /// </summary>
        private MegaCastingEntities _Entities;

        #endregion

        #region Properties

        /// <summary>
        /// Obtient ou défini le contexte de l'application
        /// </summary>
        public MegaCastingEntities Entities
        {
            get { return _Entities; }
            set { _Entities = value; }
        }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructeur du modèle-vue de la fenêtre principale
        /// </summary>
        /// <param name="entities">Contexte de l'application</param>
        public ViewModelBase(MegaCastingEntities entities)
        {
            this.Entities = entities;
        }

        #endregion

    }
}
