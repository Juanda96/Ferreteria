﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SaleDA
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionJuan"].ConnectionString);

        public DataTable selectSale()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM[Ferreteria].[UTN].[sale]", connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable sales = new DataTable();
            data.Fill(sales);

            return sales;
        }

        public DataTable selectSalePayment()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM[Ferreteria].[UTN].[sale] WHERE status = 0", connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable sales = new DataTable();
            data.Fill(sales);

            return sales;
        }

        public DataTable selectSalesReport()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM[Ferreteria].[UTN].[sale] WHERE status = 1", connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable sales = new DataTable();
            data.Fill(sales);

            return sales;
        }

        public DataTable selectSalesReportCatProduct()
        {
            SqlCommand command = new SqlCommand("SELECT UTN.sale.idProduct, UTN.product.category FROM UTN.sale INNER JOIN UTN.product ON UTN.sale.idProduct = UTN.product.id WHERE utn.sale.status = 1 AND utn.sale.type = 'Product'", connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable sales = new DataTable();
            data.Fill(sales);

            return sales;
        }

        public DataTable selectSalesReportCatService()
        {
            SqlCommand command = new SqlCommand("SELECT UTN.sale.idProduct, UTN.serv.cate FROM UTN.serv INNER JOIN UTN.sale ON UTN.sale.idProduct = UTN.serv.id WHERE utn.sale.status = 1 AND utn.sale.type = 'Service'", connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable sales = new DataTable();
            data.Fill(sales);

            return sales;
        }

        public DataTable selectSaleClients()
        {
            SqlCommand command = new SqlCommand("SELECT UTN.users.dni FROM UTN.users INNER JOIN UTN.sale ON  UTN.users.dni = UTN.sale.idUser WHERE UTN.sale.status = 0 GROUP BY UTN.users.dni", connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable sales = new DataTable();
            data.Fill(sales);

            return sales;
        }

        public DataTable selectEspecificSale(int id)
        {
            SqlCommand command = new SqlCommand("SELECT UTN.sale.id, UTN.sale.idProduct, UTN.sale.quantity, UTN.sale.type, UTN.product.price FROM UTN.sale INNER JOIN UTN.product ON UTN.sale.idProduct = UTN.product.id WHERE utn.sale.idUser ="+id, connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable sales = new DataTable();
            data.Fill(sales);

            return sales;
        }

        public DataTable clientReadyTransport()
        {
            SqlCommand command = new SqlCommand("SELECT UTN.users.dni FROM UTN.users INNER JOIN UTN.sale ON  UTN.users.dni = UTN.sale.idUser WHERE UTN.sale.status = 1 AND UTN.sale.delivery = 0 GROUP BY UTN.users.dni", connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable sales = new DataTable();
            data.Fill(sales);

            return sales;
        }

        public DataTable productReadyTransport(int id)
        {
            SqlCommand command = new SqlCommand("SELECT UTN.sale.id, UTN.sale.idProduct,UTN.product.name, UTN.sale.quantity, UTN.sale.type, UTN.product.price FROM UTN.sale INNER JOIN UTN.product ON UTN.sale.idProduct = UTN.product.id WHERE UTN.sale.delivery = 0 AND UTN.sale.status =1 AND UTN.sale.idUser =" + id, connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter data = new SqlDataAdapter(command);
            DataTable sales = new DataTable();
            data.Fill(sales);
            return sales;
        }


        public void audSale(string SQL)
        {
            SqlCommand command = new SqlCommand(SQL, connection);
            try
            {
                Console.WriteLine(SQL);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }




    }
}
