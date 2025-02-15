using AutoMapper;
using Infrastructure.Models;
using WebAPI.DTOs;

namespace WebAPI.Mapping
{
    public class ProductoProfile : Profile
    {
        public ProductoProfile()
        {
            CreateMap<Producto, ProductoDTO>()
                .ReverseMap();
        }
    }
}
