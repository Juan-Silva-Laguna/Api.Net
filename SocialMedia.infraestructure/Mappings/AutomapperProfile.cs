using AutoMapper;
using Socialmedia.core.DTOs;
using Socialmedia.Core.Entities;
using SocialMedia.core.Entities;
using SocialMedia.Core.DTOs;

namespace SocialMedia.infraestructure.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Post, PostDto>();
            CreateMap<PostDto, Post>();

            CreateMap<Security, SecurityDto>().ReverseMap();
        }

    }
}
