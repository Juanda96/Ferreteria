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
            int status = 0;
            int delivery = 0;
            do
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (bool.Parse(reader[6].ToString()))
                        {
                            status = 1;
                        }
                        if (bool.Parse(reader[8].ToString()))
                        {
                            delivery = 1;
                        }
                        Sale sale = new Sale(int.Parse(reader[0].ToString()), reader[1].ToString(), int.Parse(reader[2].ToString()),int.Parse(reader[3].ToString()),int.Parse(reader[4].ToString()),reader[5].ToString(), status, DateTime.Parse(reader[7].ToString()),delivery);
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

        public DataTable getSaleClientDataTable()
        {
            return sda.selectSaleClients();
        }

        public LinkedList<Sale> selectSalesReport()
        {
            LinkedList<Sale> sales = new LinkedList<Sale>();
            DataTable dataSales = sda.selectSalesReport();
            DataTableReader reader = dataSales.CreateDataReader();
            int status = 0;
            int delivery = 0;
            do
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (bool.Parse(reader[6].ToString()))
                        {
                            status = 1;
                        }
                        if (bool.Parse(reader[8].ToString()))
                        {
                            delivery = 1;
                        }
                        Sale sale = new Sale(int.Parse(reader[0].ToString()), reader[1].ToString(), int.Parse(reader[2].ToString()), int.Parse(reader[3].ToString()), int.Parse(reader[4].ToString()), reader[5].ToString(),status , DateTime.Parse(reader[7].ToString()), delivery);
                        sales.AddLast(sale);
                    }
                }
            } while (reader.NextResult());
            return sales;
            
        }
        public LinkedList<string> selectSalesReportCatProduct()
        {
            LinkedList<string> sales = new LinkedList<string>();
            DataTable dataSales = sda.selectSalesReportCatProduct();
            DataTableReader reader = dataSales.CreateDataReader();
            do
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string obj = reader[1].ToString();
                        sales.AddLast(obj);
                    }
                }
            } while (reader.NextResult());
            return sales;
        }

        public LinkedList<string> selectSalesReportCatService()
        {
            LinkedList<string> sales = new LinkedList<string>();
            DataTable dataSales = sda.selectSalesReportCatService();
            DataTableReader reader = dataSales.CreateDataReader();
            do
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string obj = reader[1].ToString();
                        sales.AddLast(obj);
                    }
                }
            } while (reader.NextResult());
            return sales;
        }

        public LinkedList<int> getSaleClientLink()
        {
            LinkedList<int> sales = new LinkedList<int>();
            DataTable dataSales = sda.selectSaleClients();
            DataTableReader reader = dataSales.CreateDataReader();
            do
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        sales.AddLast(int.Parse(reader[0].ToString()));
                    }
                }
            } while (reader.NextResult());
            return sales;
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
            string value = "'" + sale.bill + "','" + sale.idUser + "','" + sale.idProduct + "','" + sale.quantity + "'" + ",'" + sale.type + "','" + sale.status +"','"+  DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") +"','"+sale.delivery+"')";
            if (sale.type.Equals("Product"))
            {
                value += Environment.NewLine + "  UPDATE UTN.product SET quantity = quantity - '" + sale.quantity + "' WHERE id ="+ sale.idProduct + ";";
            }
            string SQL = "INSERT INTO[UTN].[sale]([bill],[idUser],[idProduct],[quantity],[type],[status],[dateSale],[delivery]) VALUES(" + value+"";
            Console.WriteLine(SQL);
            sda.audSale(SQL);
        }


        public DataTable getSpecificBuys(int id) 
        {
            return sda.selectEspecificSale(id);
        }

        public DataTable clientReadyTransport()
        {
            return sda.clientReadyTransport();
        }

        public LinkedList<int> clientReadyTransportLink()
        {
            LinkedList<int> sales = new LinkedList<int>();
            DataTable dataSales = sda.clientReadyTransport();
            DataTableReader reader = dataSales.CreateDataReader();
            do
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        sales.AddLast(int.Parse(reader[0].ToString()));
                    }
                }
            } while (reader.NextResult());
            return sales;
        }

        public DataTable productReadyTransport(int id)
        {
            return sda.productReadyTransport(id);
        }

        

        public void changeDelivery(int id)
        {
            string SQL = "UPDATE UTN.sale SET delivery = 1 WHERE ID = " + id;
            sda.audSale(SQL);
        }

        
        public void changeStatus(int id) 
        {
            string SQL = "UPDATE UTN.sale SET status = 1 WHERE ID = "+ id;
            sda.audSale(SQL);
        }
    }
}
