using ECommerce.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetAllProductAsync();
        Task<ProductDTO?> GetProductByIdAsync(int id);
        Task<ProductDTO> AddProductAsync(CreateProductDTO productDto);

    }
}
