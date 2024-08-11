using GerenciadorDeTarefas.Application.UseCases.Tarefas.Delete;
using GerenciadorDeTarefas.Application.UseCases.Tarefas.GetAll;
using GerenciadorDeTarefas.Application.UseCases.Tarefas.GetById;
using GerenciadorDeTarefas.Application.UseCases.Tarefas.Register;
using GerenciadorDeTarefas.Application.UseCases.Tarefas.Update;
using GerenciadorDeTarefas.Communication.Requests;
using GerenciadorDeTarefas.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeTarefas.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TarefasController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterTarefasJson), StatusCodes.Status201Created)]
    public IActionResult Register([FromBody] RequestTarefasJson request)
    {
        // Regras de negócio
        var response = new RegisterTarefasUseCase().Execute(request);



        // Devolve uma resposta no Created()
        
        return Created(string.Empty, response);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]

    public IActionResult Update([FromRoute] int id, [FromBody] RequestTarefasJson request)
    {
        var useCase = new UpdateTarefasUseCase();
        useCase.Execute(id, request);

        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<ResponseAllTarefasJson>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]

    public IActionResult GetAll()
    {
        var useCase = new GetAllTarefasUseCase();
        var response = useCase.Execute();

        if(response.Tarefas.Any())
        {
            return Ok(response);
        }

        return Ok();
    }

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(ResponseGetByIdTatefasJson), StatusCodes.Status200OK)]
    public IActionResult Get(int id)
    {
        var useCase = new GetByIdUseCase();
        var response = useCase.Execute(id);
        return Ok(response);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(typeof(List<ResponseAllTarefasJson>), StatusCodes.Status200OK)]
    public IActionResult Delete(int id)
    {
        var useCase = new DeleteTarefasByIdUseCase();
        useCase.Execute(id);
        return Ok(); 
    }

}
