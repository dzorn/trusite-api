﻿using System;
using TruSite.Api.Domain.Entities.Abstractions;

namespace TruSite.Api.Domain.Entities
{
	public class ItemPrice : IEntity
	{
		public Guid Id { get; set; }
		public decimal Price { get; set; }
		public decimal SalePrice { get; set; }
		public decimal CasePrice { get; set; }
		public DateTime BeginDate { get; set; }
		public DateTime EndDate { get; set; }
		public Guid ItemId { get; set; }
	}
}