using AutoMapper;
using Microsoft.Extensions.ObjectPool;
using MnsGames.Data;
using MnsGames.Models;

namespace MnsGames.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig() 
        {
            CreateMap<Theme, ThemeVM>().ReverseMap();
        }
    }
}
