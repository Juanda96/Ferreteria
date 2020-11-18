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
    public class ProductBO
    {
        ProductDAO pdao = new ProductDAO();

        /*
         * GET PRODUCT IN LINKEDLIST
         */
        public LinkedList<Product> getLinkedProduct()
        {
            return pdao.getProductLink();
        }
        /*
         * GET PRODUCT IN DATATABLE
         */
        public DataTable getProductDataTable()
        {
            return pdao.getProductDataTable();
        }
        /*
         * GET PRODUCT SOLD IN LINKEDLIST 
         */
        public LinkedList<Product> getLinkedProductSales()
        {
            return pdao.getProductLinkSales();
        }

        /*
         * GET PRODUCT SOLD IN DATATABLE 
         */
        public DataTable getProductDataTableSales()
        {
            return pdao.getProductDataTableSales();
        }

       /* It allows creating a new product with the necessary attributes.
       */

        public void createProduct( string name, string category, string description, int price,int quantity)
        {
            Product newProduct = new Product(name, category, description, price,quantity);
            pdao.addProduct(newProduct);
        }

        /*
         * Method to update an already registered or created product
         */

        public void updateProduct(string name, string category, string description, int price,int quantity, int oldId)
        {
            Product newProduct = new Product(name, category, description, price,quantity);
            pdao.updateProduct(newProduct, oldId);
        }

        /*
         * Method to remove the product selected by id
         */
        public void deleteProduct(int id)
        {
            pdao.deleteProduct(id);
        }
    }
}
