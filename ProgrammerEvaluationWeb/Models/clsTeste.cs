namespace ProgrammerEvaluationWeb.Models
{
    public class clsTeste
    {
        public int Codigo { get; set; }

        public DateTime Descricao { get; set;}

        public clsTeste(int codigo, DateTime descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }
    }
}
