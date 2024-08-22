using AutoMapper;
using Demo.DAL.Entities;
using Demo.PL.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace Demo.PL.Mappers
{
	public class UserProfile : Profile
	{
		public UserProfile() 
		{
			CreateMap<ApplicationUser , RegisterViewModel>().ReverseMap();
		}
	}
}
