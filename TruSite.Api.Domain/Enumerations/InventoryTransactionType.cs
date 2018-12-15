using System;

namespace TruSite.Api.Domain.Enumerations
{
	public enum InventoryTransactionType
	{
		Sale = 0,
		Purchase,
		Return,
		Damage,
		Loss,
		Adjustment
	}
}
