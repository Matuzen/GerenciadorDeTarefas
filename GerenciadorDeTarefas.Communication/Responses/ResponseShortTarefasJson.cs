using GerenciadorDeTarefas.Communication.Enums;

namespace GerenciadorDeTarefas.Communication.Responses;

public class ResponseShortTarefasJson
{
    // Resposta Simplificada
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public ETarefasPrioridadeType Prioridade { get; set; }
    public string Description { get; set; } = string.Empty;
}
