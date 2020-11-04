using MegaCastingV2.DBlib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingV2.WPF.ViewModel
{
    public class ViewModelMainWindow : ViewModelBase
    {

        /// <summary>
        /// Constructeur du modèle-vue de la fenêtre principale
        /// </summary>
        /// <param name="entities">Contexte de l'application</param>
        public ViewModelMainWindow(MegaCastingEntities entities)
            :base(entities)
        {
        }

    }
}
