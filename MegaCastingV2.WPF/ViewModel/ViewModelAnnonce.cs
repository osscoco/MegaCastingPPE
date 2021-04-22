using MegaCastingV2.DBlib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Forms;

namespace MegaCastingV2.WPF.ViewModel
{
    /// <summary>
    /// Modèle d'Annonce héritant du Modèle Base
    /// </summary>
    public class ViewModelAnnonce : ViewModelBase
    {
        #region Attributes

        /// <summary>
        /// Collection d'annonces, contrats, professionnels, employés, métiers et de villes
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
        /// Obtient ou défini la collection d'Annonces
        /// </summary>
        public ObservableCollection<Annonce> Annonces
        {
            get { return _Annonces; }
            set { _Annonces = value; }
        }

        /// <summary>
        /// Obtient ou défini la collection de Contrats
        /// </summary>
        public ObservableCollection<Contrat> Contrats
        {
            get { return _Contrats; }
            set { _Contrats = value; }
        }

        /// <summary>
        /// Obtient ou défini la collection de Professionnel
        /// </summary>
        public ObservableCollection<Professionnel> Professionnels
        {
            get { return _Professionnels; }
            set { _Professionnels = value; }
        }

        /// <summary>
        /// Obtient ou défini la collection d'Employés
        /// </summary>
        public ObservableCollection<Employe> Employes
        {
            get { return _Employes; }
            set { _Employes = value; }
        }

        /// <summary>
        /// Obtient ou défini la collection de Métiers
        /// </summary>
        public ObservableCollection<Metier> Metiers
        {
            get { return _Metiers; }
            set { _Metiers = value; }
        }

        /// <summary>
        /// Obtient ou défini la collection de Villes
        /// </summary>
        public ObservableCollection<Ville> Villes
        {
            get { return _Villes; }
            set { _Villes = value; }
        }

        /// <summary>
        /// Obtient ou défini l'annonce sélectionnée
        /// </summary>
        public Annonce SelectedAnnonce
        {
            get { return _SelectedAnnonce; }
            set { _SelectedAnnonce = value; }
        }

        /// <summary>
        /// Obtient ou défini le contrat sélectionné
        /// </summary>
        public String SelectedContrat
        {
            get { return _SelectedContrat; }
            set { _SelectedContrat = value; }
        }

        /// <summary>
        /// Obtient ou défini le professionnel sélectionnée
        /// </summary>
        public String SelectedProfessionnel
        {
            get { return _SelectedProfessionnel; }
            set { _SelectedProfessionnel = value; }
        }

        /// <summary>
        /// Obtient ou défini l'employé sélectionné
        /// </summary>
        public String SelectedEmploye
        {
            get { return _SelectedEmploye; }
            set { _SelectedEmploye = value; }
        }

        /// <summary>
        /// Obtient ou défini le métier sélectionné
        /// </summary>
        public String SelectedMetier
        {
            get { return _SelectedMetier; }
            set { _SelectedMetier = value; }
        }

        /// <summary>
        /// Obtient ou défini la ville sélectionnée
        /// </summary>
        public String SelectedVille
        {
            get { return _SelectedVille; }
            set { _SelectedVille = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Permet de lister les annonces, les contrats, les professionnels, les employés, les métiers et les villes dans la vue
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelAnnonce(MegacastingEntities entities)
            : base(entities)
        {
            this.Entities.Annonce.ToList();
            this.Annonces = this.Entities.Annonce.Local;
            this.Entities.Contrat.ToList();
            this.Contrats = this.Entities.Contrat.Local;
            this.Entities.Professionnel.ToList();
            this.Professionnels = this.Entities.Professionnel.Local;
            this.Entities.Employe.ToList();
            this.Employes = this.Entities.Employe.Local;
            this.Entities.Ville.ToList();
            this.Villes = this.Entities.Ville.Local;
            this.Entities.Metier.ToList();
            this.Metiers = this.Entities.Metier.Local;
        }

        #endregion

        #region Methods
        /// <summary>
        /// Sauvegarde les modifications lors de l'ajout d'une nouvelle annonce
        /// </summary>
        public void SaveChanges()
        {          
            this.Entities.SaveChanges();
            Entities.ChangeTracker.Entries().Where(type => type.State == System.Data.Entity.EntityState.Modified).ToList().ForEach(type => type.Reload());
            CollectionViewSource.GetDefaultView(Annonces).Refresh();
        }

         /// <summary>
         /// Ajoute une nouvelle annonce
         /// </summary>
        public void AddAnnonce()
        {
            if (!this.Entities.Annonce
                .Any(type => type.Nom == "Nouveau")//Si l'intitulée de l'annonce n'est pas égale à "Nouveau"
                                                             //Si l'intitulée est différent de l'un de la liste
                )
            {

                Annonce annonce = new Annonce();
                annonce.Nom = "Nouveau";
                annonce.Date_Publication = DateTime.Now;
                annonce.Date_Debut = DateTime.Now;
                annonce.Date_Fin = DateTime.Now;

                    annonce.Contrat = this.Entities.Contrat.FirstOrDefault();
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
            this.Annonces.Remove(SelectedAnnonce);
            this.SaveChanges();
        }


        #endregion

    }
}
