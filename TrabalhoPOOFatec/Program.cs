using TrabalhoPOOFatec;

var relatorio = new Relatorio("Relatorio");

var contrato = new Contrato("Contrato");

void Processo(Documento documento)
{
    Console.WriteLine(documento.ExibitTitulo());

    documento.Processar();
}

Processo(relatorio);
relatorio.Imprimir();
Console.WriteLine();

Processo(contrato);
contrato.Imprimir();