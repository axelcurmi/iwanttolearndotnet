using AutoMapper;
using CharacterAPI.Models;
using CharacterAPI.DTOs;

namespace CharacterAPI
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AddCharacterDTO, Character>();
        }
    }
}
