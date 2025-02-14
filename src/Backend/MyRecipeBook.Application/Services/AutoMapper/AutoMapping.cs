using AutoMapper;
using MyRecipeBook.Communication.Requests;

namespace MyRecipeBook.Application.Services.AutoMapper;

public class AutoMapping : Profile
{
    public AutoMapping()
    {
        ResquestToDomain();
    }

    private void ResquestToDomain()
    {
        CreateMap<RequestRegisterUserJson, Domain.Entities.User>()
            .ForMember(dest => dest.Password, opt => opt.Ignore());
    }

}
