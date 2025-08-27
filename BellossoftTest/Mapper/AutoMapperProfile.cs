using AutoMapper;
using BellosoftTest.DTOs;
using BellosoftTest.Models;


namespace BellosoftTest.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<ClienteDTO, Cliente>().ReverseMap();
            CreateMap<ContatoDTO, Contato>().ReverseMap();
            CreateMap<EnderecoDTO, Endereco>().ReverseMap();
            CreateMap<ClienteResponseDTO, Cliente>().ReverseMap();
            CreateMap<EnderecoResponseDTO, Endereco>().ReverseMap();
        }
    }
}
