using GerenciadorDeTarefas.Communication.Responses;

namespace GerenciadorDeTarefas.Application.UseCases.Tarefas.GetById;

public class GetByIdUseCase
{
    public ResponseGetByIdTatefasJson Execute (int id)
    {
        return new ResponseGetByIdTatefasJson
        {
            Id = id
        };
    }
}
