using AutoMapper;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles
{
    public class FilmeProfile : Profile
    {

        public FilmeProfile()
        {
            CreateMap<CreateEnderecoDto, Filme>();
            CreateMap<Filme, ReadEnderecoDto>();
            CreateMap<UpdateFilmeDto, Filme>();
        }
    }
}
