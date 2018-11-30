using System;
using System.Threading.Tasks;

namespace TruSite.Api.Data.Abstractions
{
	public interface IBaseRepository
	{
		Task BeginTransactionAsync();
		void CommitTransaction();
		void RollbackTransaction();
	}
}
