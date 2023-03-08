using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassCustomer : ClassNotify
    {
        private int _id;
        private string _name;
        private string _address;
        private string _city;
        private string _postalCode;
        private ClassCountry _country;
        private string _phone;
        private string _mailAdr;
        private bool _isActive;
        public ClassCustomer()
        {
			id = 0;
			name = "";
			address = "";
			city = "";
			postalCode = "";
			country = new ClassCountry();
			phone = "";
			mailAdr = "";
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

		public string name
		{
			get { return _name; }
			set
			{
				if (_name != value)
				{
					_name = value;
				}
				Notify("name");
			}
		}	

		public string address
		{
			get { return _address; }
			set
			{
				if (_address != value)
				{
					_address = value;
				}
				Notify("address");
			}
		}

		public string city
		{
			get { return _city; }
			set
			{
				if (_city != value)
				{
					_city = value;
				}
				Notify("city");
			}
		}	

		public string postalCode
		{
			get { return _postalCode; }
			set
			{
				if (_postalCode != value)
				{
					_postalCode = value;
				}
				Notify("postalCode");
			}
		}

		public ClassCountry country
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

		public string phone
		{
			get { return _phone; }
			set
			{
				if (_phone != value)
				{
					_phone = value;
				}
				Notify("phone");
			}
		}

		public string mailAdr
		{
			get { return _mailAdr; }
			set
			{
				if (_mailAdr != value)
				{
					_mailAdr = value;
				}
				Notify("mailAdr");
			}
		}
		

		public bool isActive
		{
			get { return _isActive; }
			set
			{
				if (_isActive != value)
				{
					_isActive = value;
				}
				Notify("isActive");
			}
		}


		public ClassCustomer(ClassCustomer inCustomer)
		{

		}
		

		
	}
}
