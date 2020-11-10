using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class SaleDAO
    {
        SaleDA sda = new SaleDA();



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
