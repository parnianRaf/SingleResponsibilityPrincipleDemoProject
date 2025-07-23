using SingleResponsibilityPrincipleDemoProject.Entity;

namespace SingleResponsibilityPrincipleDemoProject
{
    public interface IPersonService
    {
        ValidationMessageVm AddCorrectPerson(string? firstName, string? lastName);
    }
}