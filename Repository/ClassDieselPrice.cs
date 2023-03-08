using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ClassDieselPrice : ClassNotify
    {
        private int _id;
        private DateTime _date;
        private double _price;
        public ClassDieselPrice()
        {
			id= 0;
			date= DateTime.Now;
			price= 0D;

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

		public void ClassSupplier()
		{

		}

	}

}
