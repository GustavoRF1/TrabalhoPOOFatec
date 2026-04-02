namespace TrabalhoPOOFatec
{
    internal class Contrato : Documento, IImprimivel
    {
        public Contrato(string titulo) : base(titulo)
        {
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimindo Contrato");
        }

        public override void Processar()
        {
            Console.WriteLine("Processando Contrato");
        }
    }
}
