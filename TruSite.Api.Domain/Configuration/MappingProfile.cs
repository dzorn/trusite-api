using System;
using AutoMapper;
using TruSite.Api.Domain.Entities;
using TruSite.Api.Domain.JoinModels;
using TruSite.Api.Domain.Models;

namespace TruSite.Api.Domain.Configuration
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<ItemJoinModel, ItemModel>()
				.ForMember(m => m.Id, o => o.MapFrom(j => j.ItemDetail.Id))
				.ForMember(m => m.ItemId, o => o.MapFrom(j => j.ItemDetail.ItemId))
				.ForMember(m => m.Active, o => o.MapFrom(j => j.Item.Active))
				.ForMember(m => m.Name, o => o.MapFrom(j => j.ItemDetail.Name))
				.ForMember(m => m.Description, o => o.MapFrom(j => j.ItemDetail.Description))
				.ForMember(m => m.CaseQuantity, o => o.MapFrom(j => j.ItemDetail.CaseQuantity))
				.ForMember(m => m.BeginDate, o => o.MapFrom(j => j.ItemDetail.BeginDate))
				.ForMember(m => m.EndDate, o => o.MapFrom(j => j.ItemDetail.EndDate));
			CreateMap<ItemModel, Item>()
				.ForMember(i => i.Id, o => o.MapFrom(m => m.ItemId))
				.ForMember(i => i.Active, o => o.MapFrom(m => m.Active));
			CreateMap<ItemModel, ItemDetail>();
		}
	}
}
