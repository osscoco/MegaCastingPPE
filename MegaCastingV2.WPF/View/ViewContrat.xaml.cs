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
    /// Logique d'interaction pour ViewContrat.xaml
    /// </summary>
    public partial class ViewContrat : UserControl
    {
        public ViewContrat()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Défini le comportement lors du clic sur le bouton d'ajout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _ButtonAddContrat_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelContrat)this.DataContext).AddContrat();
        }

        private void _ButtonSaveContrat_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelContrat)this.DataContext).SaveChangesVerifySauvegarde();
        }

        private void _ButtonDeleteContrat_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelContrat)this.DataContext).DeleteContrat();
        }
    }
}
