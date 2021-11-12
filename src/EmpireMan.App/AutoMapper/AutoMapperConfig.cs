using AutoMapper;
using EmpireMan.App.ViewModels;
using EmpireMan.Business.Models;

namespace EmpireMan.App.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Categoria, CategoriaViewModel>().ReverseMap();
            CreateMap<ClienteEndereco, ClienteEnderecoViewModel>().ReverseMap();
            CreateMap<Cliente, ClienteEnderecoViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
        }
    }
}
