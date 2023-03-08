using Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public class ClassLuxYachtDieselDB : ClassDbCon
    {
        public ClassLuxYachtDieselDB()
        {
            SetCon(@"Server=(localdb)\MSSQLLocalDB;DataBase=LuxYachtDieselDB;Trusted_Connection=True");
        }

        public List<ClassCountry> GetAllCountriesFromDB()
        {//liste til alle lande i databasen
            List<ClassCountry> listRes = new List<ClassCountry>();
            //try catch til at gøre koden mere rubust, den trier coden, catcher hvor ser om der er fejl, hvis der er smider den det væk og catcher hvorfra det sisdt virkede
            try
            {//Hvor den skal henta data fra. via Sql udtryk
                string sqlQuery = "SELECT * FROM CountryCurrency";
                using (DataTable dataTable = DbReturnDataTable(sqlQuery))
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        ClassCountry cc = new ClassCountry();
                        cc.id = Convert.ToInt32(row["id"]);
                        cc.country = row["country"].ToString();
                        cc.countryCode = row["code"].ToString();
                        cc.currency = row["currency"].ToString();
                        cc.currencyCode = row["currencyCode"].ToString();
                        listRes.Add(cc);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //retunere svar på listRes
            return listRes;
        }

       

       

        public List<ClassCustomer> GetAllCustomersFromDB(DataRow row)
        {
            List<ClassCustomer> listRes = new List<ClassCustomer>();
            try
            {//Sql databasen fra datatable
                string sqlQuery = "SELECT Customer.id, Customer.name, Customer.address, Customer.city, Customer.postalCode, Customer.country, Customer.phone, Customer.mailAdr, Country.id AS countryId, Country.code, Country.country, Country.currency, Customer.isActive FROM Customer LEFT OUTER JOIN Country ON Customer.id = Country.id WHERE (Customer.isActive = 1)";
                using (DataTable dataTable = DbReturnDataTable(sqlQuery))
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        ClassCustomer cc = new ClassCustomer();
                        cc.id = Convert.ToInt32(row["id"]);
                        cc.name = row["name"].ToString();
                        cc.address = row["address"].ToString();
                        cc.city = row["city"].ToString();
                        cc.postalCode = row["postalCode"].ToString();
                        cc.country = row["country"].ToString();
                        cc.phone = row["phone"].ToString();
                        ClassCountry cco = new ClassCountry();
                        cco.id = Convert.ToInt32(row["countryId"]);
                        cco.countryCode = row["code"].ToString();
                        cco.country = row["country"].ToString();
                        cco.currency = row["currency"].ToString();
                        cco.currencyCode = row["currencyCode"].ToString();
                        cc.isActive = Convert.ToBoolean(row["isActive"]);

                        listRes.Add(cc);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listRes;
        }
        public int InsertCustomerInDB(ClassCustomer inCustomer)
        {
            int res = 0;
            string sqlQuery = "INSERT INTO Customer " +
                "(name, address, city, postalCode, country, phone, mailAdr, isActive) " +
                "VALUES (@name, @address, @city, @postalCode, @country, @phone, @mailAdr, @isActive) " +
                "SELECT SCOPE_IDENTITY()";

            try
            {
                using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                {
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = inCustomer.name;
                    cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = inCustomer.address;
                    cmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = inCustomer.city;
                    cmd.Parameters.Add("@postalCode", SqlDbType.NVarChar).Value = inCustomer.postalCode;
                    cmd.Parameters.Add("@country", SqlDbType.NVarChar).Value = inCustomer.country;
                    cmd.Parameters.Add("@phone", SqlDbType.NVarChar).Value = inCustomer.phone;
                    cmd.Parameters.Add("@mailAdr", SqlDbType.Money).Value = inCustomer.mailAdr;                
                    cmd.Parameters.Add("@isActive", SqlDbType.Bit).Value = inCustomer.isActive;

                    res = ExecuteScalarInDB(cmd);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return res;
        }
        public int UpdateCustomerDataInDB(ClassCustomer inCustomer)
        {
            int res = 0;
            string sqlQuery = "UPDATE Customer " +
                "SET " +
                "name = @name, " +
                "address = @address, " +
                "city = @city, " +
                "postalCode = @postalCode, " +
                "country = @country, " +
                "phone = @phone, " +
                "mailAdr = @mailAdr, " +              
                "isActive = @isActive " +
                "WHERE id = @id";
            try
            {
                using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                {
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = inCustomer.name;
                    cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = inCustomer.address;
                    cmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = inCustomer.city;
                    cmd.Parameters.Add("@postalCode", SqlDbType.NVarChar).Value = inCustomer.postalCode;
                    cmd.Parameters.Add("@country", SqlDbType.NVarChar).Value = inCustomer.country;
                    cmd.Parameters.Add("@phone", SqlDbType.NVarChar).Value = inCustomer.phone;
                    cmd.Parameters.Add("@mailAdr", SqlDbType.Money).Value = inCustomer.mailAdr;                   
                    cmd.Parameters.Add("@isActive", SqlDbType.Bit).Value = inCustomer.isActive;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = inCustomer.id;

                    res = ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return res;
        }



    }
}
