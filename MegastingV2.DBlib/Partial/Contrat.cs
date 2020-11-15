using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingV2.DBlib
{
    public partial class Contrat
    {
        public string FullnameContrat => this.ID_Contrat.ToString() + " - " + this.Libelle_Contrat; //this.SelectedContrat.ToString(); ou this.SelectedContrat.Fullname();
        public override string ToString()
        {
            return this.Libelle_Contrat.ToString();
        }
    }
}
