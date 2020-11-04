using MegaCastingV2.WPF.ViewModel;
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

namespace MegaCastingV2.WPF.View
{
    /// <summary>
    /// Logique d'interaction pour ViewAnnonce.xaml
    /// </summary>
    public partial class ViewAnnonce : UserControl
    {
        public ViewAnnonce()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Défini le comportement lors du clic sur le bouton d'ajout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _ButtonAddAnnonce_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelAnnonce)this.DataContext).AddAnnonce();
        }

        private void _ButtonSaveAnnonce_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelAnnonce)this.DataContext).SaveChanges();
        }

        private void _ButtonDeleteAnnonce_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelAnnonce)this.DataContext).DeleteAnnonce();
        }
    }
}
