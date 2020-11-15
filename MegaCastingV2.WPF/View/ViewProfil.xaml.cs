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
    /// Logique d'interaction pour ViewProfil.xaml
    /// </summary>
    public partial class ViewProfil : UserControl
    {
        public ViewProfil()
        {
            InitializeComponent();
        }

        // <summary>
        /// Défini le comportement lors du clic sur le bouton de sauvegarde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _ButtonSaveProfil_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelEmploye)this.DataContext).SaveChanges();
        }
        // <summary>
        /// Défini le comportement lors du clic sur le bouton de suppression
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _ButtonDeleteProfil_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelEmploye)this.DataContext).DeleteProfil();
        }
    }
}
