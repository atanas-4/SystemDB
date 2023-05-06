using SystemDB.CoreBusiness;
using SystemDB.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemDB.UseCases
{
    public class ViewProductByIdUseCase : IViewProductByIdUseCase
    {
        private readonly IProductRepository productRepository;

        public ViewProductByIdUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<Product> ExecuteAsync(int productId)
        {
            return await this.productRepository.GetProductByIdAsync(productId);
        }
    }
}
