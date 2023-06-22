using AutoMapper;
using Microsoft.Extensions.ObjectPool;
using MnsGames.Data;
using MnsGames.Models;

namespace MnsGames.Configurations
{
    public class MapperConfiguration : Profile
    {
        public MapperConfiguration() 
        {
            CreateMap<Theme, ThemeVM>().ReverseMap();
        }
    }
}
