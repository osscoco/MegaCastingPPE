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
        public string FullnameContrat => this.Id.ToString() + " - " + this.Nom; //this.SelectedContrat.ToString(); ou this.SelectedContrat.Fullname();
        public override string ToString()
        {
            return this.Nom.ToString();
        }
    }
}
