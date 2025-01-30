using System.Runtime.CompilerServices;

namespace MyRecipeBook.Domain.Repositories.User;

public interface IUserWriteOnlyRepository
{
    public Task Add(Entities.User user);
}
