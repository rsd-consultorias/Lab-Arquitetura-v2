using System;
using System.Runtime.Serialization;

namespace Core.Models
{
	public abstract class BaseModel
    {
		// Identify the entity
		public Guid Id { get; set; } = Guid.NewGuid();

		// Help handling errors and entity validations
		public virtual ICollection<string> Errors { get; private set; } = new List<string>();
		public virtual bool IsValid { get { return Errors.Count == 0; } }
		public virtual ICollection<Func<BaseModel, string?>> Validations { get; private set; }

		// Help handling data audit
		public virtual string CurrentUserId { get; set; }

		public BaseModel()
		{
            Validations = new List<Func<BaseModel, string?>>();
        }

		public bool Validate()
		{
			Errors.Clear();

			foreach (var validation in Validations)
			{
				string error = validation(this)!;
				if(!string.IsNullOrEmpty(error))
				{
					Errors.Add(error);
				}
			}

			return IsValid;
		}

		public void AddValidation(Func<BaseModel, string?> validation)
		{
			Validations.Add(validation);
		}
    }
}

