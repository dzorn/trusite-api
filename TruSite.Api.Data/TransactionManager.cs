using System;
using System.Threading.Tasks;
using AutoMapper;
using TruSite.Api.Core.Abstractions.Data;

namespace TruSite.Api.Data
{
	public class TransactionManager : ITransactionManager
	{
		protected readonly TruSiteContext Context;
		protected readonly IMapper Mapper;

		protected TransactionManager(TruSiteContext context, IMapper mapper)
		{
			Context = context;
			Mapper = mapper;
		}

		public async Task BeginTransactionAsync()
		{
			await Context.Database.BeginTransactionAsync();
		}

		public void CommitTransaction()
		{
			Context.Database.CommitTransaction();
		}

		public void RollbackTransaction()
		{
			Context.Database.RollbackTransaction();
		}
	}
}
