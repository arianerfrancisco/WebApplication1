using WebApplication1.Models;

namespace WebApplication1.Data.Repositories
 
{
    public interface ITarefasRepository
    {
        void Adicionar(Tarefa tarefa);

        void Atualizar( string id, Tarefa tarefaAtualizada);

        IEnumerable<Tarefa> Buscar();

        Tarefa Buscar(string Id);
    }
}
