namespace marmore_com_arquivo;



internal class Program

{

    static string[] nome = new string[999];                                             // Variável usada para cadastrar o nome do bloco

    static int[] codigo = new int[999];                                                 // Variável usada para cadastrar o código do bloco

    static int[] numero = new int[999];                                                 // Variável usada para cadastrar o número do bloco

    static decimal[] medida = new decimal[999];                                         // Variável usada para cadastrar o medida do bloco

    static string[] descricao = new string[999];                                        // Variável usada para cadastrar o descrição do bloco

    static decimal[] valorcompra = new decimal[999];                                    // Variável usada para cadastrar o valor de compra do bloco

    static decimal[] valorvenda = new decimal[999];                                     // Variável usada para cadastrar o valor de venda do bloco

    static string[] origem = new string[999];                                           // Variável usada para cadastrar o pedreira que corresponde ao bloco

    static string[] tipo = new string[999];                                             // Variável usada para cadastrar o tipo do bloco

    static int i, resp;                                                                 // Variável "i" usada para fazer o loop do for, e variável "resp" usada para receber                                                                                     o valor de quantos blocos seram cadastrados

    static void Main(string[] args)

    {
        
            Console.WriteLine("Bem vindo a Max Rochas e Produtos Ornamentais!!\n");

            int op = 0;                                                                     // Variável usada para receber o valor da opção selecionada

            while (op != 5)                                                                 // Loop para o menu de opções repetir enquanto a opção selecionada não for "5"

            {

            try                                                                             // Confere se o código abaixo possui algum erro

            { 
                
                Console.WriteLine("|================================|");                    // Menu de Opções

                Console.WriteLine("|>>>>>>> Gestão de Blocos <<<<<<<|");

                Console.WriteLine("|1 - Cadastrar Blocos            |");

                Console.WriteLine("|2 - Listar Blocos               |");

                Console.WriteLine("|3 - Buscar Bloco por código     |");

                Console.WriteLine("|4 - Listar Blocos por pedreira  |");

                Console.WriteLine("|5 - Sair                        |");

                Console.WriteLine("|================================|");

                Console.Write("\nEscolha uma opção: ");

                op = int.Parse(Console.ReadLine()!);                                        // "op" recebe o valor digitado pelo usuário

                switch (op)                                                                 // Armazena o valor do "op"

                {

                    case 1:                                                                 // Caso escolha "1"



                        Cadastro();                                                         //Puxa a função do cadastro de blocos

                        break;



                    case 2:                                                                 // Caso escolha "2"



                        ListarBlocos();                                                     // Puxa a função da listagem de blocos

                        break;



                    case 3:                                                                 // Caso escolha "3"



                        BuscarPorCodigo();                                                  // Puxa a função de buscar por código do bloco

                        break;



                    case 4:                                                                 // Caso escolha "4"



                        ListarPorPedreira();                                                // Puxa a função de ordenar os blocos de acordo com a pedreira

                        break;



                    case 5:                                                                 // Caso escolha "5"



                        Sair();                                                             // Puxa a função de sair

                        break;



                    default:                                                                            // Caso a escolha for diferente de 1 ou 2 ou 3 ou 4 ou 5      



                        Console.Clear();                                                                // Limpa tudo escrito antes                                   

                        Console.WriteLine("Essa opção não existe.");

                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu de opções");

                        Console.ReadKey();                                                              // Comando para apertar qualquer tecla para continuar

                        Console.Clear();                                                                // Limpa tudo escrito antes

                        break;



                }



            }

            catch (Exception ex)                                                                // Verifica o código possui algum erro 

            {

                Console.Clear();                                                                // Limpa tudo escrito antes

                Console.WriteLine($"Ocorreu um erro: {ex.Message}");                            // Escreve qual erro ocorreu

                Console.WriteLine("Pressione qualquer tecla para voltar ao menu de opções");

                Console.ReadKey();                                                              // Comando para apertar qualquer tecla para continuar

                Console.Clear();

            }

        }

        
    }



    private static void Cadastro()                                                                       // Função de cadastrar blocos

    {

        Console.Clear();                                                                                // Limpa tudo escrito antes

        if (i == 0)                                                                                     // Se o usuário ainda não cadastrou os blocos

        {

            try                                                                                         // Confere se o código abaixo possui algum erro

            {

                Console.WriteLine(">>>>> Cadastro <<<<<");

                Console.Write("\nQuantos blocos deseja cadastrar ? ");

                resp = int.Parse(Console.ReadLine()!);                                           // Armazena o valor que corresponde a quantos blocos deseja cadastrar

                Console.WriteLine("");

                for (i = 0; i < resp; i++)                                                                  // Estrutura de repetição para o cadastro dos blocos

                {

                    Console.Write($"Digite o tipo (mármore ou granito) do {i + 1}° bloco: ");               // Pergunta qual o tipo de bloco deseja cadastrar

                    tipo[i] = Console.ReadLine()!;                                                          // Armazena o valor do tipo do bloco

                    Console.Write($"Digite o nome do {tipo[i]}: ");                                         // Pergunta o nome do bloco

                    nome[i] = Console.ReadLine()!;                                                          // Armazena o nome do bloco

                    Console.Write($"Digite o número do {nome[i]}: ");                                       // Pergunta o número do bloco

                    numero[i] = int.Parse(Console.ReadLine()!);                                             // Armazena o número do bloco

                    Console.Write($"Digite o código do {nome[i]}: ");                                       // Pergunta o código do bloco

                    codigo[i] = int.Parse(Console.ReadLine()!);                                             // Armazena o código do bloco

                    Console.Write($"Digite a medida (em m³, ex: 0,00) do {nome[i]}: ");                     // Pergunta a medida do bloco

                    medida[i] = decimal.Parse(Console.ReadLine()!);                                         // Armazena a medida do bloco

                    Console.Write($"Digite o valor de compra (ex: 0,00) do {nome[i]}: ");                   // Pergunta o valor de compra do bloco

                    valorcompra[i] = decimal.Parse(Console.ReadLine()!);                                    // Armazena o valor de compra do bloco

                    Console.Write($"Digite o valor de venda (ex: 0,00) do {nome[i]}: ");                    // Pergunta o valor de venda do bloco

                    valorvenda[i] = decimal.Parse(Console.ReadLine()!);                                     // Armazena o valor de compra do bloco

                    Console.Write($"Digite a pedreira que corresponde ao {nome[i]}: ");                     // Pergunta a pedreira do bloco

                    origem[i] = Console.ReadLine()!;                                                        // Armazena a pedreira do bloco

                    Console.Write($"Digite a descrição do {nome[i]}: ");                                    // Pergunta a descrição do bloco

                    descricao[i] = Console.ReadLine()!;                                                     // Armazena a descrição do bloco

                    Console.WriteLine("====================================================================");

                    Console.WriteLine("");

                }

                Console.WriteLine("Cadastro Concluido.");

            }

            catch (Exception ex)                                                                        // Verifica o código possui algum erro 

            {

                Console.WriteLine($"\nOcorreu um erro: {ex.Message}");                                 // Escreve qual erro ocorreu

                Console.WriteLine("Faça o cadastro novamente.");

                i = 0;                                                                           // Caso tenha cadastrado algum produto sem falha, ele volta para sem                                                                                       cadastro para o usuário cadastrar desde o inicio todos os produtos

            }


        }



        else if (i!=0)                                                                            // Se o usuário já cadastrou os blocos

        {

            Console.WriteLine("O cadastro já foi feito.");

        }

        Console.WriteLine("Pressione qualquer tecla para voltar ao menu de opções.");

        Console.ReadKey();                                                              // Comando para apertar qualquer tecla para continuar

        Console.Clear();                                                                // Limpa tudo escrito antes

        try                                                                         // Confere se o código abaixo possui algum erro

        {

            string marmore = @"c:\Empresa de Mármore";                              // Criando uma variavel que recebe o nome de uma pasta chamada Pets



            if (!Directory.Exists(marmore))                                 // Confere se a pasta existe no computador do usuário, se não existir, então ele executa

            {

                Directory.CreateDirectory(marmore);                                 // Cria uma pasta no computador do usuário chamada "Empresa de Mármore"

            }

            StreamWriter sw;                                                        // Variável utilizada para escrever no arquivo de texto

            if (File.Exists(@"c:\Empresa de Mármore\Listagem de Blocos.txt"))       // Confere se o arquivo de texto existe no computador, se ele existir ele executa

            {

                File.Delete(@"c:\Empresa de Mármore\Listagem de Blocos.txt");       // Deleta o arquivo de texto do computador

            }

            sw = new StreamWriter(@"c:\Empresa de Mármore\Listagem de Blocos.txt"); // Cria o arquivo de texto do computador dentro da pasta criada acima

            //Obs: Fiz esses comandos acima para não repitir a listagem de blocos no arquivo e no cmd do programa toda vez q executar o programa, assim fazendo com que aparece os blocos apenas uma toda vez que executar o programa

            sw.WriteLine(">>>>>> Lista de Blocos <<<<<<\n");

            for (int i2 = 0; i2 < resp; i2++)                                                  // Estrutura de repetição para listar os blocos

            {

                sw.WriteLine("=========================================================");

                sw.WriteLine($"Tipo - {tipo[i2]}");                                             // Lista o tipo do bloco no arquivo de texto

                sw.WriteLine($"Nome - {nome[i2]}");                                             // Lista o nome do bloco no arquivo de texto

                sw.WriteLine($"Número - {numero[i2]}");                                         // Lista o número do bloco no arquivo de texto

                sw.WriteLine($"Código - {codigo[i2]}");                                         // Lista o código do bloco no arquivo de texto

                sw.WriteLine($"Medida - {medida[i2]}m³");                                       // Lista a medida do bloco no arquivo de texto

                sw.WriteLine($"Valor de compra - R${valorcompra[i2]}");                         // Lista o valor de compra do bloco no arquivo de texto

                sw.WriteLine($"Valor de venda - R${valorvenda[i2]}");                           // Lista o valor de venda do bloco no arquivo de texto

                sw.WriteLine($"Pedreira - {origem[i2]}");                                       // Lista a pedreira do bloco no arquivo de texto   

                sw.WriteLine($"Descrição - {descricao[i2]}");                                   // Lista a descrição do bloco no arquivo de texto

                sw.WriteLine("=========================================================");

            }

            sw.Close();                                                                         //Fecha o arquivo de texto

        }

        catch

        {



        }

    }



    private static void ListarBlocos()                                                  // Função de listar blocos

    {

        Console.Clear();                                                                // Limpa tudo escrito antes

        if (i == 0)                                                                     // Se o usuário ainda não cadastrou os blocos 

        {

            Console.WriteLine("O cadastro dos blocos ainda não foi feito.");

            Console.WriteLine("Volte depois de cadastrar algum bloco.");

        }

        else                                                                            // Se o usuário já cadastrou os blocos

        {



            StreamReader sr = new StreamReader(@"c:\Empresa de Mármore\Listagem de Blocos.txt");    // Variável usada para ler o que está dentro do arquivo txt

            while (!sr.EndOfStream)

            {

                Console.WriteLine(sr.ReadLine());           // Escreve tudo que está no arquivo de texto criado antes no cmd do programa 

            }

        }

        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu de opções.");

        Console.ReadKey();                                                              // Comando para apertar qualquer tecla para continuar

        Console.Clear();                                                                // Limpa tudo escrito antes

    }



    private static void BuscarPorCodigo()

    {

        Console.Clear();                                                                // Limpa tudo escrito antes

        if (i == 0)                                                                     // Se o usuário ainda não cadastrou os blocos 

        {

            Console.WriteLine("O cadastro dos blocos ainda não foi feito.");

            Console.WriteLine("Volte depois de cadastrar algum bloco.");



        }







        else                                                                            // Se o usuário já cadastrou os blocos

        {

            try                                                                             // Confere se o código abaixo possui algum erro

            {

                Console.Write("Digite o código que deseja buscar: ");

                int buscar = int.Parse(Console.ReadLine()!);                                // Váriavel que recebe o código que o usuário deseja bsucar

                Console.Clear();                                                            // Limpa tudo escrito antes



                bool sem_codigo = false;   // Variavel booleana para gerenciamento de busca quando não achar o código

                bool com_codigo = false;  // Variavel booleana para gerenciamento de busca quando achar o código



                for (i = 0; i < resp; i++)                               // Estrutura de repetição para listar o bloco correspondente ao código digitado pelo usuário

                {





                    if (buscar.Equals(codigo[i])) // Se o código digitado for igual a algum código irá executar

                    {

                        Console.WriteLine($"O bloco que corresponde ao código {buscar} é: \n");

                        Console.WriteLine("=========================================================");

                        Console.WriteLine($"Tipo - {tipo[i]}");                                                 // Lista o tipo do bloco que corresponde ao código digitado pelo usuário

                        Console.WriteLine($"Nome - {nome[i]}");                                                 // Lista o nome do bloco que corresponde ao código digitado pelo usuário

                        Console.WriteLine($"Número - {numero[i]}");                                             // Lista o número do bloco que corresponde ao código digitado pelo usuário

                        Console.WriteLine($"Medida - {medida[i]}m³");                                           // Lista a medida do bloco que corresponde ao código digitado pelo usuário

                        Console.WriteLine($"Valor de compra - R${valorcompra[i]}");                             // Lista o valor de compra do bloco que corresponde ao código digitado pelo usuário

                        Console.WriteLine($"Valor de venda - R${valorvenda[i]}");                               // Lista o valor de venda do bloco que corresponde ao código digitado pelo usuário

                        Console.WriteLine($"Pedreira - {origem[i]}");                                           // Lista a pedreira do bloco que corresponde ao código digitado pelo usuário

                        Console.WriteLine($"Descrição - {descricao[i]}");                                       // Lista a descrição do bloco que corresponde ao código digitado pelo usuário

                        Console.WriteLine("=========================================================\n");

                        com_codigo = true;  // Atribuido valor verdadeiro 

                    }

                    else if (!buscar.Equals(codigo[i]))  // Se não tiver o código irá executar

                    {

                        sem_codigo = true; // Atribuido valor verdadeiro

                    }



                }



                if (sem_codigo == true && com_codigo == true) // Se achar algum código entre os blocos e também achar nenhum código irá executar

                {


                }

                else if (sem_codigo == true && com_codigo == false) // Se não achar algum código entre os blocos irá executar

                {

                    Console.WriteLine("Código de bloco não encontrado.\n");

                }

                else if (sem_codigo == false && com_codigo == true) // Se todos os blocos tiverem o mesmo código irá executar

                {



                }





            }

            catch (Exception ex)                                                                        // Verifica o código possui algum erro 

            {

                Console.WriteLine($"\nOcorreu um erro: {ex.Message}");                                  // Escreve qual erro ocorreu

            }

        }

        Console.WriteLine("Pressione qualquer tecla para voltar ao menu de opções.");

        Console.ReadKey();                                                              // Comando para apertar qualquer tecla para continuar

        Console.Clear();                                                                // Limpa tudo escrito antes

    }



    private static void ListarPorPedreira()

    {

        Console.Clear();                                                                // Limpa tudo escrito antes

        if (i == 0)                                                                     // Se o usuário ainda não cadastrou os blocos

        {

            Console.WriteLine("O cadastro dos blocos ainda não foi feito.");

            Console.WriteLine("Volte depois de cadastrar algum bloco.");



        }

        else                                                                            // Se o usuário já cadastrou os blocos

        {

            Ordem();                                                                    // Puxa a função de ordenar o blocos por pedreira

            Console.Clear();

            Ordem();



        }

        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu de opções.");

        Console.ReadKey();                                                              // Comando para apertar qualquer tecla para continuar

        Console.Clear();                                                                // Limpa tudo escrito antes

    }



    private static void Ordem()                                                         // Função de ordenar o blocos por pedreira

    {

        string aux, aux1, aux2, aux3;                                                   // Variáveis usadas para organizar os blocos

        int aux4, aux5;

        decimal aux6, aux7, aux8;







        for (i = 0; i < resp; i++)                                                      // Estrutura de repetição para verificar e organizar os blocos por pedreira

        {

            if (origem[i] != origem[i + 1])                                             // Se a pedreira atual for diferente a da próxima pedreira do array

            {



                aux = origem[i + 1];                                                    // "aux" vira o valor da próxima pedreira do array

                aux1 = descricao[i + 1];                                                // "aux1" vira o valor da próxima descrição do array

                aux2 = nome[i + 1];                                                     // "aux2" vira o valor do próximo nome do array

                aux3 = tipo[i + 1];                                                     // "aux3" vira o valor do próximo tipo do array

                aux4 = codigo[i + 1];                                                   // "aux4" vira o valor do próximo código do array

                aux5 = numero[i + 1];                                                   // "aux5" vira o valor do próximo número do array

                aux6 = medida[i + 1];                                                   // "aux6" vira o valor da próxima medida do array

                aux7 = valorcompra[i + 1];                                              // "aux7" vira o valor do próximo valor de compra do array

                aux8 = valorvenda[i + 1];                                               // "aux8" vira o valor do próximo valor de venda do array



                origem[i + 1] = origem[i];                                              // A pedreira atual vira o valor da próxima pedreira do array

                descricao[i + 1] = descricao[i];                                        // A descrição atual vira o valor da próxima descrição do array

                nome[i + 1] = nome[i];                                                  // O nome atual vira o valor do próximo nome do array

                tipo[i + 1] = tipo[i];                                                  // O tipo atual vira o valor do próximo tipo do array

                codigo[i + 1] = codigo[i];                                              // O código atual vira o valor do próximo código do array

                numero[i + 1] = numero[i];                                              // O número atual vira o valor do próximo número do array

                medida[i + 1] = medida[i];                                              // A medida atual vira o valor da próxima medida do array

                valorcompra[i + 1] = valorcompra[i];                                    // O valor de compra atual vira o valor do próximo valor de compra do array

                valorvenda[i + 1] = valorvenda[i];                                      // O valor de venda vira o valor do próximo valor de venda do array



                origem[i] = aux;                                                        // A origem atual do array vira o valor do "aux"

                descricao[i] = aux1;                                                    // A descrição atual do array vira o valor do "aux1"

                nome[i] = aux2;                                                         // O nome atual do array vira o valor do "aux2"

                tipo[i] = aux3;                                                         // O tipo atual do array vira o valor do "aux3"

                codigo[i] = aux4;                                                       // O código atual do array vira o valor do "aux4"

                numero[i] = aux5;                                                       // O número atual do array vira o valor do "aux5"

                medida[i] = aux6;                                                       // A medida atual do array vira o valor do "aux6"

                valorcompra[i] = aux7;                                                  // O valor de compra atual do array vira o valor do "aux7"

                valorvenda[i] = aux8;                                                   // O valor de venda do array vira o valor do "aux8"







            }



            else if (origem[i] == origem[i + 1])                                        // Se a pedreira atual for igual a da próxima pedreira do array                                                      

            {



                for (i = 0; i < resp; i++)                                              // Estrutura de repetição para listar os blocos

                {

                    Console.WriteLine("=========================================================");

                    Console.WriteLine($">>>>>>> Pedreira: {origem[i]} <<<<<<<\n");                      // Lista a pedreira do bloco

                    Console.WriteLine($"Tipo - {tipo[i]}");                                             // Lista o tipo do bloco

                    Console.WriteLine($"Nome - {nome[i]}");                                             // Lista o nome do bloco

                    Console.WriteLine($"Número - {numero[i]}");                                         // Lista o número do bloco

                    Console.WriteLine($"Medida - {medida[i]}m³");                                       // Lista a medida do bloco

                    Console.WriteLine($"Valor de compra - R${valorcompra[i]}");                         // Lista o valor de compra do bloco

                    Console.WriteLine($"Valor de venda - R${valorvenda[i]}");                           // Lista o valor de venda do bloco

                    Console.WriteLine($"Descrição - {descricao[i]}");                                   // Lista a descrição do bloco

                    Console.WriteLine("=========================================================");

                }

            }

        }





    }



    private static void Sair()                                                                                  // Função de sair

    {

        Console.Clear();                                                                                        // Limpa tudo escrito antes

        Console.WriteLine("Encerrando sistema...");

        Console.WriteLine("Pressione qualquer tecla para encerrar.");

        Console.ReadKey();                                                                                      // Comando para apertar qualquer tecla para continuar

        Console.Clear();                                                                                        // Limpa tudo escrito antes

        Console.WriteLine("Obrigado por entrar na Max Rochas e Produtos Ornamentais.\nVolte sempre :D\n\n");

    }

}





