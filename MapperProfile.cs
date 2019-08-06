using AutoMapper;
using ScreenProject.Models;
using ScreenProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenProject
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {

            CreateMap<Event, EventViewModel>().ReverseMap();
            CreateMap<Employee, EmployeeViewModel>().ReverseMap();
            CreateMap<Template, TemplateViewModel>().ReverseMap();
            CreateMap<TemplateField, TemplateFieldViewModel>().ReverseMap();
            CreateMap<EventField, EventFieldViewModel>().ReverseMap();

            //CreateMap<Event, EventViewModel>().ForMember(c => c.BackGroundImg, map => map.MapFrom(c => c.MyTemplate.BackGroundImg))
            //    .ForMember(c => c.Name, map => map.MapFrom(c => c.MyTemplate.Name))
            //    //.ForMember(c => c.Value, map => map.MapFrom(c => c.EventFields.FirstOrDefault().Value))
            //    .ReverseMap();

            //CreateMap<EventField, EventFieldViewModel>().ForMember(c => c.TopPosition, map => map.MapFrom(c => c.MyTemplateField.TopPosition))
            //    .ForMember(c => c.LeftPosition, map => map.MapFrom(c => c.MyTemplateField.LeftPosition))
            //    .ForMember(c => c.FontSize, map => map.MapFrom(c => c.MyTemplateField.FontSize))
            //    .ForMember(c => c.FontColor, map => map.MapFrom(c => c.MyTemplateField.FontColor))
            //    .ForMember(c => c.FontFamily, map => map.MapFrom(c => c.MyTemplateField.FontFamily))
            //    .ForMember(c => c.FontWeight, map => map.MapFrom(c => c.MyTemplateField.FontWeight))
            //    .ForMember(c => c.FontStyle, map => map.MapFrom(c => c.MyTemplateField.FontStyle))
            //    .ForMember(c => c.Value, map => map.MapFrom(c => c.Value))
            //    .ReverseMap();

        }
    }
}
