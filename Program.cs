using ControleAcesso;

Console.WriteLine("=== TERMINAL DE ACESSO SMART ===");

IValidavel usuarioTentandoEntrar;

Console.WriteLine("Quem está tentando entrar? (1) Gerente | (2) Operador");
string escolha = Console.ReadLine();

Console.Write("Informe seu nome: ");
string nome = Console.ReadLine();

switch (escolha)
{
    case "1" :
    Gerente g= new Gerente(nome);
    g.BoasVindas();
    usuarioTentandoEntrar = g;
    break;

    case "2" : 
    Operador o= new Operador(nome);
    usuarioTentandoEntrar = o;
    o.BoasVindas();
    break;
    
    default:
    Console.WriteLine("Opção Inválida! O Sistema será encerrado.");
    return;
}

if (usuarioTentandoEntrar.Validar())
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("\n[Sucesso] Acesso Liberado. Bem-Vindo!");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\n[ERRO] Acesso Negado. Credenciais inválidas");
}

Console.ResetColor();
Console.WriteLine("\nPressione qualquer tecla para sair...");
Console.ReadKey();