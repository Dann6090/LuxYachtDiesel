using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassOrder : ClassNotify
    {
        private DateTime _date;
        private double _price;
        private double _customerPrice;
        private double _supplierRate;
        private double _ownProfit;
        private int _volume;
        private ClassCustomer _customer;
        private ClassSupplier _supplier;
        public ClassOrder()
        {
			_date = DateTime.Now;
			price = 0D;
			




        }	

		public DateTime date
		{
			get { return _date; }
			set
			{
				if (_date != value)
				{
					_date = value;
				}
				Notify("date");
			}
		}	

		public double price
		{
			get { return _price; }
			set
			{
				if (_price != value)
				{
					_price = value;
				}
				Notify("price");
			}
		}

		public double customerPrice
		{
			get { return _customerPrice; }
			set
			{
				if (_customerPrice != value)
				{
					_customerPrice = value;
				}
				Notify("customerPrice");
			}
		}	

		public double supplierRate
		{
			get { return _supplierRate; }
			set
			{
				if (_supplierRate != value)
				{
					_supplierRate = value;
				}
				Notify("supplierRate");
			}
		}	

		public double ownProfit
		{
			get { return _ownProfit; }
			set
			{
				if (_ownProfit != value)
				{
					_ownProfit = value;
				}
				Notify("ownProfit");
			}
		}	

		public int volume
		{
			get { return _volume; }
			set
			{
				if (_volume != value)
				{
					_volume = value;
				}
				Notify("volume");
			}
		}	

		public ClassCustomer customer
		{
			get { return _customer; }
			set
			{
				if (_customer != value)
				{
					_customer = value;
				}
				Notify("customer");
			}
		}		

		public ClassSupplier supplier
		{
			get { return _supplier; }
			set
			{
				if (_supplier != value)
				{
					_supplier = value;
				}
				Notify("supplier");
			}
		}
	}
}
