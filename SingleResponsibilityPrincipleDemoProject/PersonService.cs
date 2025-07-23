using System;
using SingleResponsibilityPrincipleDemoProject.Entity;

namespace SingleResponsibilityPrincipleDemoProject
{
    public class PersonService : IPersonService
    {
        public ValidationMessageVm AddCorrectPerson(string? firstName, string? lastName)
        {
            var checkNameResult = CheckNotEmptyName(firstName, "نام");

            if (!checkNameResult.IsValid)
            {
                return checkNameResult;
            }

            var checkFamilyNameResult = CheckNotEmptyName(lastName, "نام خانوادگی");

            if (!checkFamilyNameResult.IsValid)
            {
                return checkFamilyNameResult;
            }

            var addResult = AddPerson(firstName, lastName);
            return addResult;
        }

        private ValidationMessageVm CheckNotEmptyName(string? name, string businessName = "")
        {
            var result = new ValidationMessageVm();
            if (string.IsNullOrWhiteSpace(name))
            {
                result.IsValid = false;
                result.Message = $"{businessName} را وارد نکرده اید";
            }
            return result;
        }

        private ValidationMessageVm AddPerson(string name, string lastName)
        {
            var result = new ValidationMessageVm();
            var person = new Person()
            {
                FirstName = name,
                LastName = lastName
            };
            return result;
        }

    }
}

