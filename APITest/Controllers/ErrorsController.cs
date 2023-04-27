using Microsoft.AspNetCore.Mvc;

namespace APITest.Controllers;

public class ErrorsController : ControllerBase
{
    //On Error, reexcutes request to the /error route, this defines error-handling logic. Uses Problem() from ControllerBase, returns HTTP 500 error page
    [Route("/error")]
    public IActionResult Error()
    {
        return Problem();
    }
}