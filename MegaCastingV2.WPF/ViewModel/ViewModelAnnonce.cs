using MegaCastingV2.DBlib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaCastingV2.WPF.ViewModel
{
    public class ViewModelAnnonce : ViewModelBase
    {
        #region Attributes

        /// <summary>
        /// Collection d'annonces, contrats, professionnels, employes, métiers et de villes
        /// </summary>
        private ObservableCollection<Annonce> _Annonces;

        private ObservableCollection<Contrat> _Contrats;

        private ObservableCollection<Professionnel> _Professionnels;

        private ObservableCollection<Employe> _Employes;

        private ObservableCollection<Ville> _Villes;

        private ObservableCollection<Metier> _Metiers;

        /// <summary>
        /// Annonce sélectionnée
        /// </summary>
        private Annonce _SelectedAnnonce;

        /// <summary>
        /// Contrat sélectionné
        /// </summary>
        private String _SelectedContrat;

        /// <summary>
        /// Professionnel sélectionné
        /// </summary>
        private String _SelectedProfessionnel;

        /// <summary>
        /// Employé sélectionné
        /// </summary>
        private String _SelectedEmploye;

        /// <summary>
        /// Ville sélectionnée
        /// </summary>
        private String _SelectedVille;

        /// <summary>
        /// Métier sélectionné
        /// </summary>
        private String _SelectedMetier;

        #endregion

        #region Properties

        /// <summary>
        /// Obtient ou défini la collection d'annonces, contrats, professionnels, employes, métiers et de villes
        /// </summary>
        public ObservableCollection<Annonce> Annonces
        {
            get { return _Annonces; }
            set { _Annonces = value; }
        }

        public ObservableCollection<Contrat> Contrats
        {
            get { return _Contrats; }
            set { _Contrats = value; }
        }

        public ObservableCollection<Professionnel> Professionnels
        {
            get { return _Professionnels; }
            set { _Professionnels = value; }
        }

        public ObservableCollection<Employe> Employes
        {
            get { return _Employes; }
            set { _Employes = value; }
        }

        public ObservableCollection<Metier> Metiers
        {
            get { return _Metiers; }
            set { _Metiers = value; }
        }

        public ObservableCollection<Ville> Villes
        {
            get { return _Villes; }
            set { _Villes = value; }
        }

        /// <summary>
        /// Obtient ou défini l'annonce sélectionnée, le contrat sélectionné, le professionnel sélectionnée, l'employé sélectionné, le métier sélectionné et la ville sélectionnée
        /// </summary>
        public Annonce SelectedAnnonce
        {
            get { return _SelectedAnnonce; }
            set { _SelectedAnnonce = value; }
        }


        public String SelectedContrat
        {
            get { return _SelectedContrat; }
            set { _SelectedContrat = value; }
        }

        public String SelectedProfessionnel
        {
            get { return _SelectedProfessionnel; }
            set { _SelectedProfessionnel = value; }
        }

        public String SelectedEmploye
        {
            get { return _SelectedEmploye; }
            set { _SelectedEmploye = value; }
        }

        public String SelectedMetier
        {
            get { return _SelectedMetier; }
            set { _SelectedMetier = value; }
        }

        public String SelectedVille
        {
            get { return _SelectedVille; }
            set { _SelectedVille = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Permet de lister les annonces, les contrats les professionnels, les employés, les métiers et les villes dans la vue
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelAnnonce(MegaCastingEntities entities)
            : base(entities)
        {
            this.Entities.Annonces.ToList();
            this.Annonces = this.Entities.Annonces.Local;
            this.Entities.Contrats.ToList();
            this.Contrats = this.Entities.Contrats.Local;
            this.Entities.Professionnels.ToList();
            this.Professionnels = this.Entities.Professionnels.Local;
            this.Entities.Employes.ToList();
            this.Employes = this.Entities.Employes.Local;
            this.Entities.Villes.ToList();
            this.Villes = this.Entities.Villes.Local;
            this.Entities.Metiers.ToList();
            this.Metiers = this.Entities.Metiers.Local;
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

        public void Save(string Libelle)
        {
            if (!this.Entities.Annonces.Any(type => type.Intitulée_ANN == Libelle))
            {
                this.Entities.SaveChanges();
            }
            else
            {
                Entities.ChangeTracker.Entries().Where(type => type.State == System.Data.Entity.EntityState.Modified).ToList().ForEach(type => type.Reload());
                MessageBox.Show("Save annulé");
            }
            
        }

            /// <summary>
            /// Ajoute une nouvelle annonce
            /// </summary>
            public void AddAnnonce()
        {
            if (!this.Entities.Annonces
                .Any(type => type.Intitulée_ANN == "Nouveau")//Si l'intitulée de l'annonce n'est pas égale à "Nouveau"
                //Si l'intitulée est différent de l'un de la liste
                )
            {

                    Annonce annonce = new Annonce();
                    annonce.Intitulée_ANN = "Nouveau";
                    annonce.Date_Pub_ANN = DateTime.Now;
                    annonce.Date_Deb_ANN = DateTime.Now;
                    annonce.Date_Fin_ANN = DateTime.Now;
                    annonce.Contrat = this.Entities.Contrats.FirstOrDefault();
                    annonce.IdPro = 1;
                    annonce.IdEmp = 1;
                    annonce.IdVille = 1;
                    annonce.IdMetier = 1;


                    this.Annonces.Add(annonce);
                    this.SaveChanges();
 
            }
            else
            {
                MessageBox.Show("Libellé déjà existant");
            }
        }

        /// <summary>
        /// Supprime l'annonce sélectionné
        /// </summary>
        public void DeleteAnnonce()
        {
            //Suppression de l'élément
            this.Annonces.Remove(SelectedAnnonce);
            this.SaveChanges();
        }


        #endregion

    }
}
