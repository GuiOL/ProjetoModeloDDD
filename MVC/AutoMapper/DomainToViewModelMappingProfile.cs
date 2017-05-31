using AutoMapper;
using Domain.Entities;
using MVC.ViewModels;

namespace MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ClientViewModel, Client>();
            CreateMap<ProductViewModel, Product>();
        }
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }


    }
}