using Bogus;
using MyRecipeBook.Communication.Requests;

namespace CommonTestUtilities.Resquests;

public class RequestRegisterUserJsonBuilder
{
    public static RequestRegisterUserJson Build(int passwordLength = 10)
    {
        return new Faker<RequestRegisterUserJson>()
            .RuleFor(u => u.Name, (f) => f.Person.FirstName)
            .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.Name))
            .RuleFor(u => u.Password, (f) => f.Internet.Password(passwordLength));
    }
}
