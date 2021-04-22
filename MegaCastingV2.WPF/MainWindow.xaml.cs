using MegaCastingV2.WPF.View;
using MegaCastingV2.WPF.ViewModel;
using MegaCastingV2.DBlib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MegaCastingV2.WPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Attributes

        /// <summary>
        /// Contexte de l'application
        /// </summary>
        private MegacastingEntities _Entities;

        /// <summary>
        /// Vue Modèle de la fenêtre principale
        /// </summary>
        private ViewModelMainWindow _ViewModel;

        #endregion

        #region Properties

        /// <summary>
        /// Obtient ou défini le contexte de l'application
        /// </summary>
        public MegacastingEntities Entities
        {
            get { return _Entities; }
            set { _Entities = value; }
        }

        /// <summary>
        /// Obtient ou défini le vue modèle de la fenêtre principal        
        /// </summary>
        public ViewModelMainWindow ViewModel
        {
            get { return _ViewModel; }
            set { _ViewModel = value; }
        }


        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            this.Entities = new MegacastingEntities();
            this.ViewModel = new ViewModelMainWindow(this.Entities);

#if DEBUG
            _GridAuthentication.Visibility = Visibility.Collapsed;
            ViewModel.CurrentEmployee = this.Entities.Employes.FirstOrDefault();
#endif


        }

        #endregion

        /// <summary>
        /// Défini le dockPanel comme affichant les annonces
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageAnnonce_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanelView.Children.Clear();

            ViewModelAnnonce viewModel = new ViewModelAnnonce(Entities);
            
            ViewAnnonce view = new ViewAnnonce();
            view.DataContext = viewModel;
            
            this.DockPanelView.Children.Add(view);

        }

       
        /// <summary>
        /// Défini le dockPanel comme affichant les contrats
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageContrat_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanelView.Children.Clear();

            ViewModelContrat viewModel = new ViewModelContrat(Entities);

            ViewContrat view = new ViewContrat();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        
        }

        /// <summary>
        /// Défini le dockPanel comme affichant les villes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageVille_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanelView.Children.Clear();

            ViewModelVille viewModel = new ViewModelVille(Entities);

            ViewVille view = new ViewVille();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);

        }

        /// <summary>
        /// Défini le dockPanel comme affichant les métiers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageMetier_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanelView.Children.Clear();

            ViewModelMetier viewModel = new ViewModelMetier(Entities);

            ViewMetier view = new ViewMetier();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);

        }

        /// <summary>
        /// Défini le dockPanel comme affichant le profil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageProfil_Click(object sender, RoutedEventArgs e)
        {
            this.DockPanelView.Children.Clear();

            ViewModelProfessionnel viewModel = new ViewModelProfessionnel(Entities);
            ViewProfil view = new ViewProfil();
            view.DataContext = viewModel;

            this.DockPanelView.Children.Add(view);
        }

        /// <summary>
        /// Défini le dockPanel comme connexion de l'employé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _ButtonConnect_Click(object sender, RoutedEventArgs e)
        {
            this.ViewModel.CurrentEmployee = this.Entities.Employe
                .FirstOrDefault(employee => employee.Mail == _TextBoxId.Text && employee.Password == _TextBoxPassWord.Password);

            if (this.ViewModel.CurrentEmployee == null)
            {
                _TextBoxId.Text = "";
                _TextBoxPassWord.Password = "";
                _LabelErrorMessage.Visibility = Visibility.Visible;
             
            }
            else
            {
                _GridAuthentication.Visibility = Visibility.Collapsed;
               
            }

        }

        /// <summary>
        /// Défini le dockPanel comme déconnexion de l'employé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonManageQuit_Click(object sender, RoutedEventArgs e)
        {
            _TextBoxId.Text = "";
            _TextBoxPassWord.Password = "";
            _GridAuthentication.Visibility = Visibility.Visible;
            _LabelErrorMessage.Visibility = Visibility.Hidden;
        }

    }
}
