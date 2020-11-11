using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class SaleDAO
    {
        SaleDA sda = new SaleDA();

        public LinkedList<Sale> getSaleLink()
        {
            LinkedList<Sale> sales = new LinkedList<Sale>();
            DataTable dataSales = sda.selectSale();
            DataTableReader reader = dataSales.CreateDataReader();
            do
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Sale sale = new Sale(int.Parse(reader[0].ToString()), reader[1].ToString(), int.Parse(reader[2].ToString()),int.Parse(reader[3].ToString()),int.Parse(reader[4].ToString()),reader[5].ToString(),int.Parse(reader[6].ToString()),DateTime.Parse(reader[7].ToString()),int.Parse(reader[8].ToString()));
                        sales.AddLast(sale);
                    }
                }
            } while (reader.NextResult());
            return sales;
        }

        public DataTable getSaleDataTable()
        {
            return sda.selectSale();
        }

        public LinkedList<Sale> getSaleLinkPay()
        {
            LinkedList<Sale> sales = new LinkedList<Sale>();
            DataTable dataSales = sda.selectSalePayment();
            DataTableReader reader = dataSales.CreateDataReader();
            do
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Sale sale = new Sale(int.Parse(reader[0].ToString()), reader[1].ToString(), int.Parse(reader[2].ToString()), int.Parse(reader[3].ToString()), int.Parse(reader[4].ToString()), reader[5].ToString(), int.Parse(reader[6].ToString()), DateTime.Parse(reader[7].ToString()), int.Parse(reader[8].ToString()));
                        sales.AddLast(sale);
                    }
                }
            } while (reader.NextResult());
            return sales;
        }

        public DataTable getSaleDataTablePay()
        {
            return sda.selectSalePayment();
        }

        public void createSale(Sale sale) 
        {
            string value = "'" + sale.bill + "','" + sale.idUser + "','" + sale.idProduct + "','" + sale.quantity + "'" + ",'" + sale.type + "','" + sale.status +"','"+DateTime.Now+"','"+sale.delivery+"')";
            if (sale.type.Equals("Product"))
            {
                value += Environment.NewLine + "  UPDATE UTN.product SET quantity = quantity - '" + sale.quantity + "' WHERE id ="+ sale.idProduct + ";";
            }
            string SQL = "INSERT INTO[UTN].[sale]([bill],[idUser],[idProduct],[quantity],[type],[status],[dateSale],[delivery]) VALUES(" + value+"";
            Console.WriteLine(SQL);
            sda.audSale(SQL);
        }
    }
}
