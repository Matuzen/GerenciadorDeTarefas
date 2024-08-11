using GerenciadorDeTarefas.Communication.Responses;
using System.Reflection.Metadata.Ecma335;

namespace GerenciadorDeTarefas.Application.UseCases.Tarefas.GetAll;

public class GetAllTarefasUseCase
{
    
    public ResponseAllTarefasJson Execute()
    {
        return new ResponseAllTarefasJson
        {
            Tarefas = new List<ResponseShortTarefasJson>
            {
               new ResponseShortTarefasJson
               {
                   
               }
            }
        };
    }
}
