using System;
using TruSite.Api.Entities.Abstractions;

namespace TruSite.Api.Entities
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