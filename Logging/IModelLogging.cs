using System;
using Core.Models;

namespace Logging
{
	public interface IModelLogging<TModel> where TModel : BaseModel
    {
		void LogCreated(TModel createdModel);
        void LogChanged(TModel changedModel, TModel oldModel);
        void LogDeleted(TModel deletedModel);
    }
}

