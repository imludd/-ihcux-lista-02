/*
Heuristicas aplicadas:
5. Prevencao de erros: acoes criticas como reiniciar servidor e formatar unidade pedem confirmacao extra.
6. Reconhecimento em vez de recordacao: o sistema mostra um menu de comandos rapidos e uma legenda de ajuda.
10. Ajuda e documentacao: os comandos "help" e "?" explicam as funcoes sem tirar o usuario da tela atual.
*/

bool encerrarPrograma = false;

while (!encerrarPrograma)
{
    MostrarCabecalho();
    MostrarMenuRapido();
    MostrarLegenda();

    Console.Write("Escolha um comando: ");
    string comando = Console.ReadLine() ?? "";
    comando = comando.Trim().ToLower();

    if (comando == "help" || comando == "?")
    {
        MostrarAjudaGeral();
        Pausar();
        continue;
    }

    if (comando == "1" || comando == "ping")
    {
        ExecutarPing();
    }
    else if (comando == "2" || comando == "status")
    {
        VerificarStatusServidor();
    }
    else if (comando == "3" || comando == "reiniciar")
    {
        ReiniciarServidor();
    }
    else if (comando == "4" || comando == "formatar")
    {
        FormatarUnidade();
    }
    else if (comando == "5" || comando == "sair")
    {
        EscreverCor("Encerrando o TerminalSuporte.ConsoleApp...", ConsoleColor.Green);
        encerrarPrograma = true;
    }
    else
    {
        EscreverCor("Comando nao reconhecido. Escolha uma opcao do menu ou digite help.", ConsoleColor.Red);
        Pausar();
    }
}

static void MostrarCabecalho()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("=== TerminalSuporte.ConsoleApp ===");
    Console.ResetColor();
    Console.WriteLine("Console de diagnostico de rede com foco em acessibilidade e prevencao de erros.");
    Console.WriteLine();
}

static void MostrarMenuRapido()
{
    Console.WriteLine("Menu de Comandos Rapidos");
    Console.WriteLine("1 - Pingar IP");
    Console.WriteLine("2 - Ver status do servidor");
    Console.WriteLine("3 - Reiniciar servidor");
    Console.WriteLine("4 - Formatar unidade");
    Console.WriteLine("5 - Sair");
    Console.WriteLine();
}

static void MostrarLegenda()
{
    Console.WriteLine("Legenda fixa: help | ? = ajuda   menu = voltar ao menu   sair = encerrar");
    Console.WriteLine();
}

static void MostrarAjudaGeral()
{
    Console.WriteLine();
    Console.WriteLine("Ajuda rapida do sistema:");
    Console.WriteLine("- 1 ou ping: simula o teste de conectividade com um IP.");
    Console.WriteLine("- 2 ou status: mostra o estado atual do servidor.");
    Console.WriteLine("- 3 ou reiniciar: acao critica com confirmacao extra.");
    Console.WriteLine("- 4 ou formatar: acao de alto risco com alerta em cor e confirmacao reforcada.");
    Console.WriteLine("- 5 ou sair: fecha o programa.");
    Console.WriteLine("- help ou ?: mostra esta ajuda sem sair da tela atual.");
    Console.WriteLine("- menu: volta para o menu principal quando usado dentro de uma funcao.");
    Console.WriteLine();
}

static void ExecutarPing()
{
    while (true)
    {
        MostrarCabecalho();
        Console.WriteLine("Funcao: Pingar IP");
        Console.WriteLine("Informe um IP no formato xxx.xxx.xxx.xxx");
        MostrarLegenda();

        Console.Write("Digite o IP desejado: ");
        string entrada = Console.ReadLine() ?? "";
        entrada = entrada.Trim();
        string entradaMinuscula = entrada.ToLower();

        if (entradaMinuscula == "help" || entradaMinuscula == "?")
        {
            Console.WriteLine();
            Console.WriteLine("Ajuda da funcao Pingar IP:");
            Console.WriteLine("- Digite um endereco IP com quatro blocos numericos.");
            Console.WriteLine("- Exemplo valido: 192.168.0.10");
            Console.WriteLine("- Digite menu para voltar sem executar o ping.");
            Console.WriteLine("- Digite sair para encerrar o programa pela tela principal.");
            Pausar();
            continue;
        }

        if (entradaMinuscula == "menu")
        {
            return;
        }

        if (entradaMinuscula == "sair")
        {
            Environment.Exit(0);
        }

        if (!IpValido(entrada))
        {
            EscreverCor("IP invalido. Use o formato correto: xxx.xxx.xxx.xxx", ConsoleColor.Red);
            Pausar();
            continue;
        }

        EscreverCor("Ping executado com sucesso. O servidor respondeu ao teste.", ConsoleColor.Green);
        Pausar();
        return;
    }
}

static void VerificarStatusServidor()
{
    while (true)
    {
        MostrarCabecalho();
        Console.WriteLine("Funcao: Ver status do servidor");
        MostrarLegenda();

        Console.Write("Digite consultar para verificar o status: ");
        string entrada = Console.ReadLine() ?? "";
        entrada = entrada.Trim().ToLower();

        if (entrada == "help" || entrada == "?")
        {
            Console.WriteLine();
            Console.WriteLine("Ajuda da funcao Status:");
            Console.WriteLine("- Digite consultar para exibir o estado atual do servidor.");
            Console.WriteLine("- Digite menu para voltar sem executar a consulta.");
            Pausar();
            continue;
        }

        if (entrada == "menu")
        {
            return;
        }

        if (entrada == "consultar")
        {
            EscreverCor("Servidor online. Latencia estimada: 12 ms. Nenhum alerta critico encontrado.", ConsoleColor.Green);
            Pausar();
            return;
        }

        EscreverCor("Comando invalido. Digite consultar, help ou menu.", ConsoleColor.Red);
        Pausar();
    }
}

static void ReiniciarServidor()
{
    while (true)
    {
        MostrarCabecalho();
        EscreverCor("Atencao: reiniciar o servidor pode interromper usuarios conectados.", ConsoleColor.Yellow);
        MostrarLegenda();

        Console.Write("Digite REINICIAR para confirmar ou menu para voltar: ");
        string entrada = Console.ReadLine() ?? "";
        entrada = entrada.Trim();
        string entradaMinuscula = entrada.ToLower();

        if (entradaMinuscula == "help" || entradaMinuscula == "?")
        {
            Console.WriteLine();
            Console.WriteLine("Ajuda da funcao Reiniciar:");
            Console.WriteLine("- Esta e uma acao critica.");
            Console.WriteLine("- O sistema exige confirmacao extra para prevenir erros.");
            Console.WriteLine("- Digite REINICIAR para continuar ou menu para cancelar.");
            Pausar();
            continue;
        }

        if (entradaMinuscula == "menu")
        {
            return;
        }

        if (entrada == "REINICIAR")
        {
            EscreverCor("Servidor reiniciado com sucesso.", ConsoleColor.Green);
            Pausar();
            return;
        }

        EscreverCor("Confirmacao invalida. Para executar a acao, digite exatamente REINICIAR.", ConsoleColor.Red);
        Pausar();
    }
}

static void FormatarUnidade()
{
    while (true)
    {
        MostrarCabecalho();
        EscreverCor("PERIGO: formatar uma unidade pode apagar todos os dados.", ConsoleColor.Red);
        Console.WriteLine("Exemplos de unidade: C:  D:  E:");
        MostrarLegenda();

        Console.Write("Informe a unidade que deseja formatar: ");
        string unidade = Console.ReadLine() ?? "";
        unidade = unidade.Trim().ToUpper();

        if (unidade == "HELP" || unidade == "?")
        {
            Console.WriteLine();
            Console.WriteLine("Ajuda da funcao Formatar Unidade:");
            Console.WriteLine("- Informe a letra da unidade, como C: ou D:.");
            Console.WriteLine("- Depois disso, o sistema pedira uma confirmacao forte.");
            Console.WriteLine("- Digite menu para voltar sem continuar.");
            Pausar();
            continue;
        }

        if (unidade == "MENU")
        {
            return;
        }

        if (!UnidadeValida(unidade))
        {
            EscreverCor("Unidade invalida. Use o formato correto, por exemplo: C:", ConsoleColor.Red);
            Pausar();
            continue;
        }

        while (true)
        {
            MostrarCabecalho();
            EscreverCor("Modo de alerta ativo", ConsoleColor.Yellow);
            EscreverCor("Confirme com cuidado a formatacao da unidade " + unidade + ".", ConsoleColor.Red);
            MostrarLegenda();

            Console.Write("Digite FORMATAR para confirmar ou menu para cancelar: ");
            string confirmacao = Console.ReadLine() ?? "";
            confirmacao = confirmacao.Trim();
            string confirmacaoMinuscula = confirmacao.ToLower();

            if (confirmacaoMinuscula == "help" || confirmacaoMinuscula == "?")
            {
                Console.WriteLine();
                Console.WriteLine("Ajuda da confirmacao:");
                Console.WriteLine("- FORMATAR executa a acao critica.");
                Console.WriteLine("- menu cancela e volta ao menu principal.");
                Pausar();
                continue;
            }

            if (confirmacaoMinuscula == "menu")
            {
                return;
            }

            if (confirmacao == "FORMATAR")
            {
                EscreverCor("Formatacao simulada da unidade " + unidade + " concluida.", ConsoleColor.Green);
                Pausar();
                return;
            }

            EscreverCor("Confirmacao invalida. Digite exatamente FORMATAR para continuar.", ConsoleColor.Red);
            Pausar();
        }
    }
}

static bool IpValido(string ip)
{
    string[] partes = ip.Split('.');

    if (partes.Length != 4)
    {
        return false;
    }

    for (int i = 0; i < partes.Length; i++)
    {
        int numero;

        if (!int.TryParse(partes[i], out numero))
        {
            return false;
        }

        if (numero < 0 || numero > 255)
        {
            return false;
        }
    }

    return true;
}

static bool UnidadeValida(string unidade)
{
    if (unidade.Length != 2)
    {
        return false;
    }

    if (unidade[1] != ':')
    {
        return false;
    }

    return unidade[0] >= 'A' && unidade[0] <= 'Z';
}

static void EscreverCor(string mensagem, ConsoleColor cor)
{
    Console.ForegroundColor = cor;
    Console.WriteLine(mensagem);
    Console.ResetColor();
}

static void Pausar()
{
    Console.WriteLine();
    Console.Write("Pressione Enter para continuar...");
    Console.ReadLine();
}
