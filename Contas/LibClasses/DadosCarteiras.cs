namespace Contas.LibClasses
{
    public class DadosCarteiras
    {
        public List<Carteira> ListaDados = new List<Carteira>();
        public DateTime DataDoSistema { get; set; } = DateTime.Now;
        public int MesAtual { get; set; } = DateTime.Now.Month;

    }
}
