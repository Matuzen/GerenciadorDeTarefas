namespace GerenciadorDeTarefas.Communication.Responses;

public class ResponseAllTarefasJson
{
    public List<ResponseShortTarefasJson> Tarefas { get; set; } = [];
}
