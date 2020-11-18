using DataAccessObject;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObject
{
    public class SaleBO
    {
        SaleDAO sdao = new SaleDAO();

        //GENERATE A RANDOM CODE TO MAKE A BILL
        public string generateCode()
        {
            int length = 4;

            StringBuilder str_build = new StringBuilder();
            Random random = new Random();

            char letter;

            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            Random _random = new Random();
            return str_build.ToString()+_random.Next(1000, 9999);
        }



        /*
         * It allows to generate a new sale with the necessary parameters.
         */
        public void createSale(string bill, int idUser, int idProduct, int quantity, string type, int status, int delivery) 
        {
            Sale sale = new Sale(bill,idUser,idProduct,quantity,type,status,delivery);
            sdao.createSale(sale);
        }
        /*
        * GET ALL PRODUCT SOLD
        */
        public LinkedList<string> selectSalesReportCatProduct()
        {
            return sdao.selectSalesReportCatProduct();
        }
        /*
         * GET ALL SERVICE SOLD
         */
        public LinkedList<string> selectSalesReportCatService()
        {
            return sdao.selectSalesReportCatService();
        }
        /*
         * GET ALL SALES DATATABLE
         */
        public DataTable selectSale() 
        {
            return sdao.getSaleDataTable();
        }
        /*
         * GET ALL SALES LINKEDLIST
         */
        public LinkedList<Sale> selectSaleLink() 
        {
            return sdao.getSaleLink();
        }

        /*
         * GET ALL SALES WITH PAY STATUS = TRUE
         */
        public DataTable selectSalePayment()
        {
            return sdao.getSaleDataTable();
        }
        /*
         * GET PRODUCT || SERVICE SALES WITH PAY STATUS = TRUE 
         */
        public LinkedList<Sale> selectSalesReport()
        {
            return sdao.selectSalesReport();
        }
        /*
         * GET ALL CLIENTS IDS WITH PAY STATUS = FALSE DATATABLE
         */
        public DataTable selectSaleClientPayment()
        {
            return sdao.getSaleClientDataTable();
        }
        /*
         * GET ALL CLIENTS IDS WITH PAY STATUS = FALSE LINKEDLIST
         */
        public LinkedList<int> selectSaleClientLink()
        {
            return sdao.getSaleClientLink();
        }
        /*
         * GET ALL CLIENTS IDS WITH PAY STATUS = FALSE LINKEDLIST
         */
        public LinkedList<Sale> selectSaleLinkPayment()
        {
            return sdao.getSaleLink();
        }
        /*
         * GET ESPECIFIC CLIENTS SALES WITH PAY STATUS = FALSE LINKEDLIST
        */
        public DataTable selectSaleEspecificClientBuys(int id)
        {
            return sdao.getSpecificBuys(id);
        }
        /*
         * CHANGE STATUS PAY 
        */
        public void changeStatus(int id) 
        {
            sdao.changeStatus(id);
        }
        /*
         * GET ESPECIFIC CLIENTS SALES WITH PAY STATUS = TRUE AND STATUS DELIVERY = FALSE DATATABLE
        */
        public DataTable clientReadyTransport()
        {
            return sdao.clientReadyTransport();
        }
        /*
         * GET ESPECIFIC CLIENTS SALES WITH PAY STATUS = TRUE AND STATUS DELIVERY = FALSE LINKEDLIST
        */
        public LinkedList<int> clientReadyTransportLink()
        {
            return sdao.clientReadyTransportLink();
        }

        public DataTable productReadyTransport(int idUser)
        {
            return sdao.productReadyTransport(idUser);
        }

        /*
         * CHANGE STATUS DELIVERY 
        */
        public void changeDelivery(int id)
        {
            sdao.changeDelivery(id);
        }
    }
}
