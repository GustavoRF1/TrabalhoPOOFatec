namespace TrabalhoPOOFatec
{
    public abstract class Documento
    {
        public string Titulo {get; private set; }

        protected Documento(string titulo)
        {
            Titulo = titulo;
        }

        public string ExibitTitulo()
        {
            return Titulo;
        }

        public abstract void Processar();
    }
}
