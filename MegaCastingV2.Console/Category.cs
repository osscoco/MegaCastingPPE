using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingV2.AppV1
{
    class Category
    {

        #region Attributes

        /// <summary>
        /// Nom de la catégorie
        /// </summary>
        private string _Name;

        #endregion

        #region Properties

        /// <summary>
        /// Obtient ou défini le nom de la catégorie
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        #endregion

        #region Constructors

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Category()
        {

        }

        /// <summary>
        /// constructeur prenant en compte le nom de la catégorie
        /// </summary>
        /// <param name="name">nom de la catégorie</param>
        public Category(string name)
        {
            this.Name = name;
        }

        #endregion

    }
}
