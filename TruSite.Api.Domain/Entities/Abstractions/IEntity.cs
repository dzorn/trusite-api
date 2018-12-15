using System;

namespace TruSite.Api.Domain.Entities.Abstractions
{
	public interface IEntity
	{
		Guid Id { get; set; }
	}
}
