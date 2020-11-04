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
        private MegaCastingEntities _Entities;

        /// <summary>
        /// Vue Modèle de la fenêtre principale
        /// </summary>
        private ViewModelMainWindow _ViewModel;

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

            this.Entities = new MegaCastingEntities();

        }

        #endregion

        /// <summary>
        /// Défini le dockPanel comme affichant le type d'annonce
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
        /// Défini le dockPanel comme affichant le type de contrat
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

    }
}
