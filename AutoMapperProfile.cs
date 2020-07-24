using AutoMapper;
using dotnet_game.Dtos.Character;
using dotnet_game.Models;

namespace dotnet_game
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}