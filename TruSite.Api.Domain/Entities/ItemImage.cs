using System;
using TruSite.Api.Domain.Entities.Abstractions;

namespace TruSite.Api.Domain.Entities
{
	public class ItemImage : IEntity
	{
		public Guid Id { get; set; }
		public byte[] Image { get; set; }
		public int Ordinal { get; set; }
		public Guid ItemDetailId { get; set; }
		public DateTime BeginDate { get; set; }
		public DateTime EndDate { get; set; }
	}
}