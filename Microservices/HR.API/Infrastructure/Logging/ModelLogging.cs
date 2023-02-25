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
            Console.WriteLine($"User: {createdModel.CurrentUserId} criou {createdModel.GetType().Name} com id: {createdModel.Id}");
        }

        public void LogChanged(BaseModel changedModel, BaseModel oldModel)
        {
            Console.WriteLine($"User: {changedModel.CurrentUserId} alterou {changedModel.GetType().Name} com id: {changedModel.Id}");
        }

        public void LogDeleted(BaseModel deletedModel)
        {
            Console.WriteLine($"User: {deletedModel.CurrentUserId} excluiu {deletedModel.GetType().Name} com id: {deletedModel.Id}");
        }
    }
}