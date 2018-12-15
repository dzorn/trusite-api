using System;
using TruSite.Api.Domain.Entities;

namespace TruSite.Api.Domain.JoinModels
{
	public class ItemJoinModel
	{
		public Item Item { get; set; }
		public ItemDetail ItemDetail { get; set; }
	}
}
