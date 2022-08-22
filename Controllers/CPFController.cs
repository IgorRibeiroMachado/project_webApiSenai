using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("cpf/")]
public class CpfController : ControllerBase
{
    [HttpGet("validate/{cpf}")]
    public object Validate(
        [FromServices]CpfService cpfService,
        string cpf)
    {
        return new {
            status = "Success",
            message =  cpf
        };
    }

    [HttpGet("generate")]
    public object Generate(
        [FromServices]CpfService cpfService
    )
    {
        return new {
            status = "Success",
            cpf = cpfService.Generate()
        };
    }
}