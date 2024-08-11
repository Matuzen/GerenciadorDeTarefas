using GerenciadorDeTarefas.Communication.Enums;

namespace GerenciadorDeTarefas.Communication.Requests;

public class RequestTarefasJson
{
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public DateTime DataLimite { get; set; }
    public ETarefasPrioridadeType Prioridade { get; set; }
    public ETarefasStatusType Status { get; set; }

}
