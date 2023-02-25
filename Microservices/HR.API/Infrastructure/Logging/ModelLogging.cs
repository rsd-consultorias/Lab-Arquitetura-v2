using Logging;
using Core.Models;
using HR.Domain.Models;

namespace HR.API.Infrastructure.Logging
{
    public class ModelLogging : IModelLogging
    {
        public ModelLogging()
        {
            
        }

        public void LogCreated(BaseModel createdModel)
        {
            Console.WriteLine($"User: {createdModel.CurrentUserId}");
        }

        public void LogChanged(BaseModel changedModel, BaseModel oldModel)
        {
            Console.WriteLine($"User: {changedModel.CurrentUserId}");
        }

        public void LogDeleted(BaseModel deletedModel)
        {
            Console.WriteLine($"User: {deletedModel.CurrentUserId}");
        }
    }
}