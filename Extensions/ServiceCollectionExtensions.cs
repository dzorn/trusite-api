using System;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using TruSite.Api.Domain.Configuration;

namespace TruSite.Api.Extensions
{
	public static class ServiceCollectionExtensions
	{
		public static void AddMapper(this IServiceCollection services)
		{
			services.AddSingleton<IMapper>(sp => new MapperConfiguration(cfg => cfg.AddProfile(new MappingProfile())).CreateMapper());
		}
	}
}
