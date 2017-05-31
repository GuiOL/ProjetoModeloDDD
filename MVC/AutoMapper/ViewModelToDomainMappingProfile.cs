using AutoMapper;
using Domain.Entities;
using MVC.ViewModels;

namespace MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<Client, ClientViewModel>();
            CreateMap<Product, ProductViewModel>();
        }
        public override string ProfileName
        {
            get { return "DomainToViewModelMappins"; }
        }
    }
}