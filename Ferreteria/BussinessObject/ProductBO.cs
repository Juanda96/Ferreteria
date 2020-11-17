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
        public LinkedList<Product> getLinkedProduct()
        {
            return pdao.getProductLink();
        }

        public DataTable getProductDataTable()
        {
            return pdao.getProductDataTable();
        }

        public LinkedList<Product> getLinkedProductSales()
        {
            return pdao.getProductLinkSales();
        }

        public DataTable getProductDataTableSales()
        {
            return pdao.getProductDataTableSales();
        }

        /*Permite crear un nuevo producto con los atributos necesario.
         */

        public void createProduct( string name, string category, string description, int price,int quantity)
        {
            Product newProduct = new Product(name, category, description, price,quantity);
            pdao.addProduct(newProduct);
        }

        /*Método para actualizar un producto ya registrado o cerado
         */

        public void updateProduct(string name, string category, string description, int price,int quantity, int oldId)
        {
            Product newProduct = new Product(name, category, description, price,quantity);
            pdao.updateProduct(newProduct, oldId);
        }

        /*
         * Método para eliminar el producto seleccionado por id
         */
        public void deleteProduct(int id)
        {
            pdao.deleteProduct(id);
        }
    }
}
