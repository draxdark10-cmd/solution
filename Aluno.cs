namespace ObjetoTransferencia
{
    public class Aluno
    {
        public int ID { get;set; }
        public string Nome { get;set; } = string.Empty;
        public Aluno() { }
        public Aluno(int id, string nome)
        {
            ID = id;
            Nome = nome;
        }
    }
    public class  AlunoColecao : List<Aluno>
    {
        
    }
}
