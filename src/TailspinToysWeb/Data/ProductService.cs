using System;
using System.Linq;
using System.Threading.Tasks;

namespace TailspinToysWeb.Data
{
    public class ProductService
    {
        public Task<Product[]> GetProductsAsync()
        {
            Product[] products = new Product[4]
            {
                new Product(1, "Outtop Foam Throwing Glider", "Foam throwing glider airplane", 10),
                new Product(2, "Fascinations Metal Earth 3D Laser Cut Model", "Wright Brothers airplane made of 3D laser cut metal", 20),
                new Product(3, "Vintage Model USMC Corsair Model Airplane", "Complete kit with realistic marking scheme", 30),
                new Product(4, "Delta Diecast Model Airplane", "Delta Single Plane Replica", 40)
            };

            return Task.FromResult(products);
        }
    }
}
