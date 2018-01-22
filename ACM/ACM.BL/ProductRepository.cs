using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            //code that revrieves the defined product

            Product product = new Product(productId);

            //temporary hard coded values to return a populated product
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Sizes";
                product.CurrentPrice = 15.96M;
            }
            return product;
        }

        public bool Save()
        {
            //saves the defined product
            return true;
        }
    }
}
