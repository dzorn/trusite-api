using TruSite.Api.Core.Abstractions.Data;

namespace TruSite.Api.Data
{
    public class ItemDetailRepository :  IItemDetailRepository
    {
		private readonly TruSiteContext context;

		public ItemDetailRepository(TruSiteContext context)
		{
			this.context = context;
		}
    }
}