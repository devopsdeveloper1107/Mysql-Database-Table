using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Devopsdeveloper
{
    #region Tbl_country
    public class Tbl_country
    {
        #region Member Variables
        protected int _country_id;
        protected string _sortname;
        protected string _country_name;
        #endregion
        #region Constructors
        public Tbl_country() { }
        public Tbl_country(string sortname, string country_name)
        {
            this._sortname=sortname;
            this._country_name=country_name;
        }
        #endregion
        #region Public Properties
        public virtual int Country_id
        {
            get {return _country_id;}
            set {_country_id=value;}
        }
        public virtual string Sortname
        {
            get {return _sortname;}
            set {_sortname=value;}
        }
        public virtual string Country_name
        {
            get {return _country_name;}
            set {_country_name=value;}
        }
        #endregion
    }
    #endregion
}