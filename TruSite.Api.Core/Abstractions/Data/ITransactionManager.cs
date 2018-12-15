using System;
using System.Threading.Tasks;

namespace TruSite.Api.Core.Abstractions.Data
{
	public interface ITransactionManager
	{
		Task BeginTransactionAsync();
		void CommitTransaction();
		void RollbackTransaction();
	}
}
