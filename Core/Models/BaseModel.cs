using System;
namespace Core.Models
{
	public abstract class BaseModel
    {
		public Guid Id { get; set; } = Guid.NewGuid();

		public virtual ICollection<string> Errors { get; private set; } = new List<string>();
		public virtual bool IsValid { get { return Errors.Count == 0; } }
		public virtual ICollection<Func<BaseModel, string?>> Validations { get; private set; }

		public BaseModel()
		{
            Validations = new List<Func<BaseModel, string?>>();
        }

		public void Validate()
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
		}

		public void AddValidation(Func<BaseModel, string?> validation)
		{
			Validations.Add(validation);
		}
	}
}

