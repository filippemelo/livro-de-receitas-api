<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Mvc;
using MyRecipeBook.Application.UseCases.User.Register;
=======
﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
>>>>>>> 79e7c90b2f7c448dd0feb64b5d6bbb526ff9b1ab
using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;

namespace MyRecipeBook.Api.Controllers;

[Route("[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterUserJson), StatusCodes.Status201Created)]
<<<<<<< HEAD
    public async Task<IActionResult> Register(
        [FromServices] IRegisterUserUseCase useCase,
        [FromBody] RequestRegisterUserJson request)
    {
        var result = await useCase.Execute(request);

        return Created(string.Empty, result);
=======
    public IActionResult Register(RequestRegisterUserJson request)
    {
        return Created();
>>>>>>> 79e7c90b2f7c448dd0feb64b5d6bbb526ff9b1ab
    }
}
