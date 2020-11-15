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
    /// Logique d'interaction pour ViewVille.xaml
    /// </summary>
    public partial class ViewVille : UserControl
    {
        public ViewVille()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Défini le comportement lors du clic sur le bouton d'ajout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _ButtonAddVille_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelVille)this.DataContext).AddVille();
        }
        // <summary>
        /// Défini le comportement lors du clic sur le bouton de sauvegarde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _ButtonSaveVille_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelVille)this.DataContext).SaveChanges();
        }
        // <summary>
        /// Défini le comportement lors du clic sur le bouton de suppression
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _ButtonDeleteVille_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelVille)this.DataContext).DeleteVille();
        }
    }
}
