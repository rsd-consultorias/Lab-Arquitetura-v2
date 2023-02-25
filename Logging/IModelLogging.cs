using System;
using Core.Models;

namespace Logging
{
	public interface IModelLogging
    {
		void LogCreated(BaseModel createdModel);
        void LogChanged(BaseModel changedModel, BaseModel oldModel);
        void LogDeleted(BaseModel deletedModel);
    }
}

