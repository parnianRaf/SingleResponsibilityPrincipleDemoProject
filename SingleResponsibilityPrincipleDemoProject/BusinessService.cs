using System;
namespace SingleResponsibilityPrincipleDemoProject
{
	public class BusinessService
	{
		public void GetTheInfo(string name , out string firstName)
		{
			Console.WriteLine($"لطفا {name} خود را وارد نمایید.");
			firstName = Console.ReadLine() ?? "";
		}

	}
}

