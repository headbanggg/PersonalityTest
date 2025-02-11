using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using Application.Profiles;
using Application.Questions.DTOs;
using Application.Tests.DTOs;
using AutoMapper;
using Domain;

namespace Application.Core
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
         
            CreateMap<Question, Question> ();
            CreateMap<TestResult, TestResultDto> ();
            CreateMap<AppUser, UserProfile> ()
            .ForMember(d => d.DisplayName, o => o.MapFrom(s => s.DisplayName))
            .ForMember(d => d.ImageUrl, o => o.MapFrom(s => s.ImageUrl))
            .ForMember(d => d.Id, o => o.MapFrom(s => s.Id));
            
            CreateMap<Test, TestDto> ();
            CreateMap<Question, QuestionProfile> ()
            .ForMember(d => d.Content, o => o.MapFrom(s => s.Content))
            .ForMember(d => d.Index, o => o.MapFrom(s => s.Index))
            .ForMember(d => d.Id, o => o.MapFrom(s => s.Id));

            CreateMap<Question, QuestionDto> ()
            .ForMember(d => d.Content, o => o.MapFrom(s => s.Content))
            .ForMember(d => d.Id, o => o.MapFrom(s => s.Id))
            .ForMember(d => d.Index, o => o.MapFrom(s => s.Index))
            .ForMember(d => d.AnswerOptionsCount, o => o.MapFrom(s => s.Test.AnswerOptionsCount))
            .ForMember(d => d.TestId, o => o.MapFrom(s => s.Test.Id))
            .ForMember(d => d.TestName, o => o.MapFrom(s => s.Test.TestName));
        }
    }
}