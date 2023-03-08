using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IO;
using Repository;

namespace BIZ
{
    public class ClassBIZ : ClassNotify
    {
       ClassLuxYachtDieselDB classDB = new ClassLuxYachtDieselDB();
		ClassCallWebApi classAPI = new ClassCallWebApi();
		//Feilds
        private ClassCurrency _currency;
        private ClassCustomer _selectedCustomer;
        private ClassSupplier _selectedSupplier;
        private ClassCustomer _fallbackCustomer;
        private ClassSupplier _fallbackSupplier;
        private List<ClassCountry> _listCountry;
        private List<ClassCustomer> _listCustomers;
        private List<ClassSupplier> _listSuppliers;
        private ClassDieselPrice _dieselPrice;
        private ClassOrder _order;
        public ClassBIZ()
        {            
			currency = new ClassCurrency();
			selectedCustomer = new ClassCustomer();
			selectedSupplier = new ClassSupplier();
			fallbackCustomer = new ClassCustomer();
			fallbackSupplier = new ClassSupplier();
			listCountry = new List<ClassCountry>();
			listCustomers = new List<ClassCustomer>();
			listSuppliers = new List<ClassSupplier>();
			dieselPrice = new ClassDieselPrice();
			order = new ClassOrder();
        }	

		public ClassCurrency currency
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

		public ClassCustomer selectedCustomer
		{
			get { return _selectedCustomer; }
			set
			{
				if (_selectedCustomer != value)
				{
					_selectedCustomer = value;
				}
				Notify("selectedCustomer");
			}
		}	

		public ClassSupplier selectedSupplier
		{
			get { return _selectedSupplier; }
			set
			{
				if (_selectedSupplier != value)
				{
					_selectedSupplier = value;
				}
				Notify("selectedSupplier");
			}
		}		

		public ClassCustomer fallbackCustomer
		{
			get { return _fallbackCustomer; }
			set
			{
				if (_fallbackCustomer != value)
				{
					_fallbackCustomer = value;
				}
				Notify("fallbackCustomer");
			}
		}	

		public ClassSupplier fallbackSupplier
		{
			get { return _fallbackSupplier; }
			set
			{
				if (_fallbackSupplier != value)
				{
					_fallbackSupplier = value;
				}
				Notify("fallbackSupplier");
			}
		}	
		
		public List<ClassCountry> listCountry
		{
			get { return _listCountry; }
			set
			{
				if (_listCountry != value)
				{
					_listCountry = value;
				}
				Notify("listCountry");
			}
		}	

		public List<ClassCustomer> listCustomers
		{
			get { return _listCustomers; }
			set
			{
				if (_listCustomers != value)
				{
					_listCustomers = value;
				}
				Notify("listCustomer");
			}
		}		

		public List<ClassSupplier> listSuppliers
		{
			get { return _listSuppliers; }
			set
			{
				if (_listSuppliers != value)
				{
					_listSuppliers = value;
				}
				Notify("listSuppliers");
			}
		}	

		public ClassDieselPrice dieselPrice
		{
			get { return _dieselPrice; }
			set
			{
				if (_dieselPrice != value)
				{
					_dieselPrice = value;
				}
				Notify("dieselPrice");
			}
		}	

		public ClassOrder order
		{
			get { return _order; }
			set
			{
				if (_order != value)
				{
					_order = value;
				}
				Notify("order");
			}
		}

		public ClassCurrency GetAllCurrencysWebAPI()
		{
			
		}
		
		public void GetAllCustomersForListFromDB()
		{

		}

		public List<ClassSupplier> GetAllSuppliersForListFromDB()
		{

		}

		public ClassDieselPrice GetDieselPPriceFromDB()
		{

		}

		public void UpdateOrInsertCustomerInDB()
		{

		}

		public void UpdateOrInsertSupplierInDB()
		{

		}

		public void InsertDieselPriceInDB()
		{

		}

		public void InsertOrderInDB()
		{

		}

		public void RegretUpdateOrNewCustomerForDB()
		{

		}

		public void RegretUpdateOrNewSupplierForDB()
		{

		}

		public void RegretNewDieselPriceForDB()
		{

		}

		public void RegretNewOrderForDB()
		{

		}

		public void CalculateAllValuesForOrder()
		{

		}
        public int UpdateCustomerDB()
        {
            return classDB.UpdateCustomerDataInDB(fallbackCustomer);
        }
    }
}
