using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingV2.DBlib
{
    public partial class Annonce
    {
        public string FullnameAnnonce => this.Id.ToString() + " - " + this.Nom;  //this.SelectedAnnonce.ToString(); ou this.SelectedAnnonce.FullnameAnnonce();

        public override string ToString()
        {
            return this.Nom.ToString();
        }
    }
}
