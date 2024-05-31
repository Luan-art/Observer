using Observer;

int op = 0;
Netfliz netfliz = new Netfliz();

do
{
    Console.Clear();
    Console.WriteLine("1-Adcionar novo Assinante");
    Console.WriteLine("2-Cancelar Assinatura");
    Console.WriteLine("3-Adcionar novo Filme");
    Console.WriteLine("0- Sair");
    Console.WriteLine();
    try
    {
        op = int.Parse(Console.ReadLine());
   
    }catch(Exception e)
    {
        Console.WriteLine("Digite um numero");
        op = -1;
    }

    switch (op)
    {
        case 0:
            Console.WriteLine("Volte sempre");
            break;
        case 1:
            AdcionarNovoAssiantente();
            break;
        case 2:
            CancelarAssinatura();
            break;
        case 3:
            AdcionarNovoFilme();
            break;
        default:
            Console.WriteLine("Invalido");
            break;

    }

} while (op != 0);

void CancelarAssinatura()
{
    Console.WriteLine("Digite o nome do assinante a cancelar:");
    string nome = Console.ReadLine();
    netfliz.RemoverObservador(nome);
    Console.ReadKey();

}

void AdcionarNovoFilme()
{
    Console.WriteLine("Digite o tiulo:");
    string tiulo = Console.ReadLine();

    Console.WriteLine("Digite o tipo de conteúdo (filme ou série):");
    string tipoConteudo = Console.ReadLine();
    Filme filme = new Filme(tiulo, tipoConteudo);

    Console.WriteLine();

    netfliz.NotificarObservadores($"{filme}");
    Console.ReadKey();
}

void AdcionarNovoAssiantente()
{
    Console.WriteLine();

    Console.WriteLine("Digite o nome do novo assinante:");
    string nome = Console.ReadLine();
    Assinante novoAssinante = new Assinante(nome);
    netfliz.AdicionarObservador(novoAssinante);
    Console.WriteLine($"Assinante {nome} adicionado.");

    Console.ReadKey();

}

