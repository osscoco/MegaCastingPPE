using MegaCastingV2.DBlib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingV2.WPF.ViewModel
{
    public class ViewModelAnnonce : ViewModelBase
    {
        #region Attributes

        /// <summary>
        /// Collection d'annonces
        /// </summary>
        private ObservableCollection<Annonce> _Annonces;

        /// <summary>
        /// Annonces sélectionnées
        /// </summary>
        private Annonce _SelectedAnnonce;

        /// <summary>
        /// Annonces sélectionnées
        /// </summary>
        private DateTime _SelectedDatePub;

        /// <summary>
        /// Annonces sélectionnées
        /// </summary>
        private DateTime _SelectedDateDeb;

        /// <summary>
        /// Annonces sélectionnées
        /// </summary>
        private DateTime _SelectedDateFin;

        /// <summary>
        /// Annonces sélectionnées
        /// </summary>
        private String _SelectedContrat;

        #endregion

        #region Properties


        /// <summary>
        /// Obtient ou défini la collection d'annonce
        /// </summary>
        public ObservableCollection<Annonce> Annonces
        {
            get { return _Annonces; }
            set { _Annonces = value; }
        }

        /// <summary>
        /// Obtient ou défini le type d'annonces sélectionnées
        /// </summary>
        public Annonce SelectedAnnonce
        {
            get { return _SelectedAnnonce; }
            set { _SelectedAnnonce = value; }
        }

        public DateTime SelectedDatePub
        {
            get { return _SelectedDatePub; }
            set { _SelectedDatePub = value; }
        }

        public DateTime SelectedDateDeb
        {
            get { return _SelectedDateDeb; }
            set { _SelectedDateDeb = value; }
        }

        public DateTime SelectedDateFin
        {
            get { return _SelectedDateFin; }
            set { _SelectedDateFin = value; }
        }

        public String SelectedContrat
        {
            get { return _SelectedContrat; }
            set { _SelectedContrat = value; }
        }
        #endregion

        #region Constructor

        public ViewModelAnnonce(MegaCastingEntities entities)
            : base(entities)
        {
            this.Entities.Annonces.ToList();
            this.Annonces = this.Entities.Annonces.Local;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Sauvegarde les modifications
        /// </summary>
        public void SaveChanges()
        {
            this.Entities.SaveChanges();
        }


        /// <summary>
        /// Ajoute une nouvelle annonce
        /// </summary>
        public void AddAnnonce()
        {
            if (!this.Entities.Annonces
                .Any(type => type.Intitulée_ANN == SelectedAnnonce.Intitulée_ANN)
                )
            {
                Annonce annonce = new Annonce();
                annonce.Intitulée_ANN = SelectedAnnonce.Intitulée_ANN;
                annonce.Date_Pub_ANN = SelectedAnnonce.Date_Pub_ANN;
                annonce.Date_Deb_ANN = SelectedAnnonce.Date_Deb_ANN;
                annonce.Date_Fin_ANN = SelectedAnnonce.Date_Fin_ANN;
                annonce.IdContrat = SelectedAnnonce.IdContrat;
                annonce.IdPro = SelectedAnnonce.IdPro;
                annonce.IdEmp = SelectedAnnonce.IdEmp;
                annonce.IdVille = SelectedAnnonce.IdVille;
                
                
                this.Annonces.Add(annonce);
                this.SaveChanges();
                this._SelectedAnnonce = annonce;
            }
        }

        /// <summary>
        /// Supprime le contrat sélectionné
        /// </summary>
        public void DeleteAnnonce()
        {
            // Vérification si on a le droit de supprimer

            //Suppression de l'élément
            this.Annonces.Remove(SelectedAnnonce);
            this.SaveChanges();
        }


        #endregion

    }
}
