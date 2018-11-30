using System;
using System.Threading.Tasks;
using TruSite.Api.Data.Abstractions;

namespace TruSite.Api.Data
{
	public class BaseRepository : IBaseRepository
	{
		protected readonly TruSiteContext _context;

		public BaseRepository(TruSiteContext context)
		{
			_context = context;
		}

		public async Task BeginTransactionAsync()
		{
			await _context.Database.BeginTransactionAsync();
		}

		public void CommitTransaction()
		{
			_context.Database.CommitTransaction();
		}

		public void RollbackTransaction()
		{
			_context.Database.RollbackTransaction();
		}
	}
}
