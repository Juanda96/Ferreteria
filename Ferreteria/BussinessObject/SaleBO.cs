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

        public void createSale(string bill, int idUser, int idProduct, int quantity, string type, int status, int delivery) 
        {
            Sale sale = new Sale(bill,idUser,idProduct,quantity,type,status,delivery);
            sdao.createSale(sale);
        }

        public DataTable selectSale() 
        {
            return sdao.getSaleDataTable();
        }

        public LinkedList<Sale> selectSaleLink() 
        {
            return sdao.getSaleLink();
        }

        public DataTable selectSalePayment()
        {
            return sdao.getSaleDataTable();
        }

        public LinkedList<Sale> selectSaleLinkPayment()
        {
            return sdao.getSaleLink();
        }
    }
}
