using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassCountry : ClassNotify
    {
        private int _id;
        private string _country;
        private string _countryCode;
        private string _currency;
        private string _currencyCode;
        public ClassCountry()
        {
			id = 0;
			country = "";
			countryCode = "";
			currency = "";
			currencyCode = "";
        }	

		public int id
		{
			get { return _id; }
			set
			{
				if (_id != value)
				{
					_id = value;
				}
				Notify("id");
			}
		}

		public string country
		{
			get { return _country; }
			set
			{
				if (_country != value)
				{
					_country = value;
				}
				Notify("country");
			}
		}	

		public string countryCode
		{
			get { return _countryCode; }
			set
			{
				if (_countryCode != value)
				{
					_countryCode = value;
				}
				Notify("countryCode");
			}
		}	

		public string currency
		{
			get { return _currency; }
			set
			{
				if (_currency != value)
				{
					_currency = value;
				}
				Notify("currency");
			}
		}

		public string currencyCode
		{
			get { return _currencyCode; }
			set
			{
				if (_currencyCode != value)
				{
					_currencyCode = value;
				}
				Notify("currencyCode");
			}
		}



	}
}
