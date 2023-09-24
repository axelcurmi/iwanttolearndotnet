using AutoMapper;
using CharacterAPI.Models;
using CharacterAPI.Models.DTO;

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
