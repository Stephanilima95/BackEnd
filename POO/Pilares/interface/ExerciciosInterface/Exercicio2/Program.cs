using System.Runtime.CompilerServices;
using Exercicio2;
Console.Clear();

List<Fatura> listaFatura = new List<Fatura>();
List<Contrato> listaContrato = new List<Contrato>();
List<Relatorio> listaRelatorio = new List<Relatorio>();

int opcao;
do
{
    Console.WriteLine($"Menu de Opções");
    Console.WriteLine($@"
1) Cadastrar Fatura
2) Cadastrar Relatório
3) Cadastrar Contrato
4) Listar Faturas
5) Listar Relatórios
6) Listar Contratos
0) Sair
Escolha a opção:");
    opcao = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite <Enter> para continuar ...");
    Console.ReadLine();

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Cadastrar Fatura");
            break;
        case 2:
            Console.WriteLine($"Cadastrar Relatório");
            break;
        case 3:
            Console.WriteLine($"Cadastrar Contrato");
            break;
        case 4:
            Console.WriteLine("Listar Faturas");
            break;
        case 5:
         Console.WriteLine($"Listar Relatórios");
         break;
         case 6:
         Console.WriteLine($"Listar Contratos");
         break;
         case 0:
         break;
         default:
         Console.WriteLine($"ERRO, opção não existente.");
         break;

         
    }

    Console.WriteLine($"Digite <Enter> para continuar ...");
    Console.WriteLine();

} while (opcao != 0);


void CadastrarFatura()
{
    Console.Write($"Digite o nome do devedor");
    string dev = Console.ReadLine();
    Console.Write($"Digite o nome do credor");
    string cred = Console.ReadLine();
    Console.Write($"Digite o nome da fatura");
    float Valor = float.Parse(Console.ReadLine());
    Console.Write($"Quantos dias a fatura está em atraso? ");
    int diasAtraso = int.Parse(Console.ReadLine());

    Fatura f = new Fatura(dev, cred, Valor, diasAtraso);
    listaFatura.Add(f);
}

void CadastrarContrato()
{
    Console.Write($"Digite o nome do contratante");
    string con = Console.ReadLine();
    Console.Write($"Digite o nome do Prestador Servico");
    string ps = Console.ReadLine();
    Console.Write($"Digite o nome do Texto Clausulas");
    string tc = Console.ReadLine();
    

    Contrato c = new Contrato(con, ps, tc);
    listaContrato.Add(c);
}
void CadastrarRelatorio()
{
    Console.Write($"Digite o nome");
    string n = Console.ReadLine();
    Console.Write($"Digite o  Texto Relatorio");
    string tr = Console.ReadLine();
    
    
    Relatorio r = new Relatorio(n, tr);
    listaRelatorio.Add(r);
}

void ListarRelatorio()
{
    // Iterate over the *collection* of reports, not the function name
    foreach (var item in listaRelatorio)
    {
        item.Imprimir();
    }
}

void ListarContrato()
{
    
    foreach (var item in listaContrato)
    {
        item.Imprimir();
    }
}

void ListarFatura()
{
    // Iterate over the *collection* of invoices
    foreach (var item in listaFatura)
    {
        item.Imprimir();
    }
}







// Relatorio relFontes = new Relatorio("Felipe Fontes","Relatório insano do Fontes");
// Relatorio relGoncalves = new Relatorio("Felipe Gonçalves", "Relatório de Felipe Gonçalves");

// Contrato contEloysa = new Contrato("Bruno Rodrigues", "Eloysa Marques", "Sla, num sei oq escrever");
// Contrato contNathan = new Contrato("Felipe Fontes","Nathan Policarpo", "Não sei oq escrever aq");

// Fatura fatDavi = new Fatura("Davi Muniz","Carrefour",100,2);
// Fatura fatStephani = new Fatura("Stephani Dandara","Shopee",200,3);


// documentos.Add(fatDavi);
// documentos.Add(fatStephani);
// documentos.Add(contEloysa);
// documentos.Add(contNathan);
// documentos.Add(relFontes);
// documentos.Add(relGoncalves);

// foreach (var  item in documentos)
// {
//     item.Imprimir();
// }
// Console.WriteLine($"------------------------------------------------------------------");
// Relatorio r1 = new Relatorio();
// r1.Imprimir();
// Contrato c1 = new Contrato();
// c1.Imprimir();
// Fatura f1 = new Fatura();
// f1.Imprimir();
