using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
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
using MegaCastingV2.DBlib;
using MegaCastingV2.WPF.ViewModel;

namespace MegaCastingV2.WPF.View
{
    /// <summary>
    /// Logique d'interaction pour ViewMain.xaml
    /// </summary>
    public partial class ViewMain : UserControl
    {
        /// <summary>
        /// Initialise la vue principale
        /// </summary>
        public ViewMain()
        {
            InitializeComponent();
        }
    }
}