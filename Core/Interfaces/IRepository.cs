using System;
using Core.Models;

namespace Core.Interfaces
{
	public interface IRepository<TModel> where TModel : BaseModel
    {
		string? LastError { get; set; }

		IEnumerable<TModel> FindMany(Func<TModel, bool> filter);
		TModel FindById(Guid id);

		bool Create(TModel model);
		bool Update(TModel model);
		bool DeleteById(Guid id);

		bool DeleteMany(Func<TModel> filter);
	}
}

