// See https://aka.ms/new-console-template for more information
using SingleResponsibilityPrincipleDemoProject;
IPersonService personService = new PersonService();
BusinessService business = new();



business.GetTheInfo("نام", out string firstName);
business.GetTheInfo("نام خانوادگی", out string lastName);


var result = personService.AddCorrectPerson(firstName, lastName);
if (!result.IsValid) Console.WriteLine(result.Message);
else Console.WriteLine("اطلاعات با موفقیت ذخیره شد.");

