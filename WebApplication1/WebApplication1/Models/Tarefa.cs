namespace WebApplication1.Models
{
    public class Tarefa
    {
        public string Id { get; private set; }

        public string Nome { get; private set; }

        public string Detalhes { get; private set; }

        public bool Concluido { get; private set; }

        public  DateTime DataCadastro { get; private set; }
        
        public  DateTime? DataConclusao { get; private set; }
    }
}
