namespace TrabalhoPOOFatec
{
    public class Relatorio : Documento, IImprimivel
    {
        public Relatorio(string titulo) : base(titulo)
        {
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimindo relatório");
        }

        public override void Processar()
        {
            Console.WriteLine("Processando relatório");
        }
    }
}
