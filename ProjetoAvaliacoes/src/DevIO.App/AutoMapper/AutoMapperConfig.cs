using AutoMapper;
using DevIO.App.ViewModels;
using DevIO.Business.Models;

namespace DevIO.App.AutoMapper
{
    public class AutoMapperConfig : Profile
    {

        //configurando a relação do Model com o ViewModels
        public AutoMapperConfig()
        {
            CreateMap<Entity, EntityViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
            CreateMap<Usuario, UsuarioViewModel>().ReverseMap();
            CreateMap<Avaliacao, AvaliacaoViewModel>().ReverseMap();

        }


    }
}
