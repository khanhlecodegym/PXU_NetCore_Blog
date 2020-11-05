using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.ViewModels.TagsViewModel;

namespace WebApplication1.Helpers
{
    public class Helper : Profile
    {
        public Helper()
        {
            CreateMap<Tag, TagViewModel>();
            CreateMap<CreateTagViewModel, Tag>();
        }
        
    }
}
