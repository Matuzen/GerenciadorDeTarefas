using GerenciadorDeTarefas.Communication.Requests;
using GerenciadorDeTarefas.Communication.Responses;

namespace GerenciadorDeTarefas.Application.UseCases.Tarefas.Register;

public class RegisterTarefasUseCase
{
    // Quem vai utilizar essa função é a API 

    public ResponseRegisterTarefasJson Execute(RequestTarefasJson request) 
    {
        return new ResponseRegisterTarefasJson
        {
            Id = 1,
            Nome = request.Nome
        };
    }

}
