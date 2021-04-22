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
    /// Modèle du Professionnel héritant du Modèle Base
    /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
        public String SelectedNom_PRO
        {
            get { return _SelectedNom_PRO; }
            set { _SelectedNom_PRO = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public String SelectedPrenom_PRO
        {
            get { return _SelectedPrenom_PRO; }
            set { _SelectedPrenom_PRO = value; }
        }
        
        /// <summary>
        /// 
        /// </summary>
        public String SelectedMail_PRO
        {
            get { return _SelectedMail_PRO; }
            set { _SelectedMail_PRO = value; }
        }

        /// <summary>
        /// 
        /// </summary>
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
        public ViewModelProfessionnel(MegacastingEntities entities)
            : base(entities)
        {
            this.Entities.Professionnel.ToList();
            this.Professionnels = this.Entities.Professionnel.Local;
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
            CollectionViewSource.GetDefaultView(Professionnels).Refresh();
        }



        /// <summary>
        /// Ajoute une nouveau métier
        /// </summary>
        public void AddPro()
        {
            if (!this.Entities.Professionnel
                .Any(type => type.Nom == "Nouveau")//Si dans la liste de métiers il n'existe pas d'élément "Nouveau"
                )
            {
                Professionnel pro = new Professionnel();
                pro.Nom = "Nouveau nom";
                pro.Prenom = "Nouveau prénom";
                pro.Mail = "Nouveau mail";
                pro.Password = "Nouveau mot de passe";
                this.Professionnels.Add(pro);
                this.SaveChanges();
            }
        }

        /// <summary>
        /// Supprime le métier sélectionné
        /// </summary>
        public void DeletePro()
        {
            if (!SelectedProfessionnel.Annonce.Any())
            {
                //Suppression de l'élément
                this.Professionnels.Remove(SelectedProfessionnel);
                this.SaveChanges();
            }else
            {
                MessageBox.Show("Ce professionnel ne peux pas être supprimé car il est déjà lié à une annonce !");
            }
        }


        #endregion
    }
}
