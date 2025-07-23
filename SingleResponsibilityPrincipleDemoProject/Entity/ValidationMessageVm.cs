using System;
namespace SingleResponsibilityPrincipleDemoProject.Entity
{
	public class ValidationMessageVm
	{
		public ValidationMessageVm()
		{
			Message = string.Empty;
			IsValid = true;
		}

		public bool IsValid { get; set; }

		public string Message { get; set; }

	}
}

