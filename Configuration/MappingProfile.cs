using System;
using AutoMapper;
using TruSite.Api.Entities;
using TruSite.Api.Models;

namespace TruSite.Api.Configuration
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<ItemModel, Item>();
			CreateMap<Item, ItemModel>();
			CreateMap<NoteModel, Note>();
			CreateMap<Note, NoteModel>();
		}
	}
}
