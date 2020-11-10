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
            string value = "'" + sale.bill + "','" + sale.idUser + "','" + sale.idProduct + "','" + sale.quantity + "'" + ",'" + sale.type + "','" + sale.status + "'";
            string SQL = "INSERT INTO[UTN].[sale]([bill],[idUser],[idProduct],[quantity],[type],[status]) VALUES("+ value+")" + Environment.NewLine + "  UPDATE UTN.product SET quantity = quantity - '"+sale.quantity+"';";
            Console.WriteLine(SQL);
            sda.audSale(SQL);
        }
    }
}
