using CursoCSharp.Guia;
using CursoCSharp.Exercicios;
using CursoCSharp.Paradigmas;
using CursoCSharp;

using System.Text.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace GerenciamentoAeroporto
{
    class Program
    {
        static List<Passageiro> passageiros = new List<Passageiro>();
        static Aeroporto aeroporto = new Aeroporto();
        static string arquivoPassageiros = @"C:\Users\Aluno Noite\Documents\GitHub\Curso-CSharp-VS2022\JSON\passageiros.json";
        static string arquivoVoos = @"C:\Users\Aluno Noite\Documents\GitHub\Curso-CSharp-VS2022\JSON\voos.json";
        static string arquivoPassageirosPorVoo = @"C:\Users\Aluno Noite\Documents\GitHub\Curso-CSharp-VS2022\JSON\passageirosPorVoo.json";

        static void Main(string[] args)
        {
            CarregarDados();

            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   SISTEMA DE GERENCIAMENTO   ======");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Gerenciar Voos");
                Console.WriteLine("2. Gerenciar Passageiros");
                Console.WriteLine("0. Sair");

                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        MenuVoos();
                        break;
                    case 2:
                        MenuPassageiros();
                        break;
                    case 0:
                        SalvarDados();
                        Console.WriteLine("\nSaindo do programa...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
            } while (opcao != 0);
        }

        static void MenuVoos()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   GERENCIAR VOOS   ============");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Voo");
                Console.WriteLine("2. Listar Voos");
                Console.WriteLine("3. Adicionar Passageiro a Voo");
                Console.WriteLine("4. Listar Passageiros de um Voo");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarVoo();
                        break;
                    case 2:
                        ListarVoos();
                        break;
                    case 3:
                        AdicionarPassageiroAVoo();
                        break;
                    case 4:
                        ListarPassageirosDeVoo();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        static void MenuPassageiros()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   GERENCIAR PASSAGEIROS   ============");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Passageiro");
                Console.WriteLine("2. Listar Passageiros");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarPassageiro();
                        break;
                    case 2:
                        ListarPassageiros();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        static void AdicionarPassageiro()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO PASSAGEIRO   =========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o nome do passageiro: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o CPF do passageiro: ");
            string cpf = Console.ReadLine();

            if (passageiros.Any(p => p.Cpf == cpf))
            {
                Console.WriteLine("\nPassageiro com este CPF já existe.");
                return;
            }

            Passageiro passageiro = new Passageiro(nome, cpf);
            passageiros.Add(passageiro);
            Console.WriteLine("\nPassageiro adicionado com sucesso!");
            SalvarPassageiros();
        }

        static void ListarPassageiros()
        {
            if (passageiros.Count == 0)
            {
                Console.WriteLine("\nNenhum passageiro cadastrado.");
            }
            else
            {
                Console.WriteLine("==============================================");
                Console.WriteLine("=========   LISTA DE PASSAGEIROS   =========");
                Console.WriteLine("==============================================");

                for (int i = 0; i < passageiros.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {passageiros[i].Nome} - CPF: {passageiros[i].Cpf}");
                }
            }
        }

        static void AdicionarVoo()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO VOO   ===========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o número do voo: ");
            string numero = Console.ReadLine();
            Console.Write("Digite o destino: ");
            string destino = Console.ReadLine();
            Console.Write("Digite a data do voo (dd/mm/yyyy): ");
            DateTime data = DateTime.Parse(Console.ReadLine());

            Voo voo = new Voo(numero, destino, data);
            aeroporto.AdicionarVoo(voo);
            Console.WriteLine("\nVoo adicionado com sucesso!");
            SalvarVoos();
        }

        static void ListarVoos()
        {
            var voos = aeroporto.ObterVoos();
            if (voos.Count == 0)
            {
                Console.WriteLine("\nNenhum voo cadastrado.");
            }
            else
            {
                Console.WriteLine("==============================================");
                Console.WriteLine("=========   LISTA DE VOOS   ============");
                Console.WriteLine("==============================================");

                foreach (var voo in voos)
                {
                    voo.ExibirDetalhes();
                }
            }
        }

        static void AdicionarPassageiroAVoo()
        {
            ListarPassageiros();
            Console.Write("\nDigite o número do passageiro a ser adicionado ao voo: ");
            int passageiroIndice = int.Parse(Console.ReadLine()) - 1;

            if (passageiroIndice >= 0 && passageiroIndice < passageiros.Count)
            {
                Passageiro passageiro = passageiros[passageiroIndice];
                Console.Write("Digite o número do voo: ");
                string numeroVoo = Console.ReadLine();
                Voo voo = aeroporto.BuscarVooPorNumero(numeroVoo);

                if (voo != null)
                {
                    passageiro.AdicionarVoo(voo, aeroporto);
                    SalvarPassageiroPorVoo();
                }
                else
                {
                    Console.WriteLine("\nVoo não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\nNúmero de passageiro inválido.");
            }
        }

        static void ListarPassageirosDeVoo()
        {
            Console.Write("Digite o número do voo: ");
            string numeroVoo = Console.ReadLine();
            Voo voo = aeroporto.BuscarVooPorNumero(numeroVoo);

            if (voo != null)
            {
                var passageirosVoo = passageiros.Where(p => p.ObterVoos().Any(v => v.Numero == numeroVoo)).ToList();
                if (passageirosVoo.Count > 0)
                {
                    Console.WriteLine($"Passageiros do voo {numeroVoo}:");
                    foreach (var passageiro in passageirosVoo)
                    {
                        Console.WriteLine($"{passageiro.Nome} - CPF: {passageiro.Cpf}");
                    }
                }
                else
                {
                    Console.WriteLine($"Nenhum passageiro encontrado para o voo {numeroVoo}.");
                }
            }
            else
            {
                Console.WriteLine("Voo não encontrado.");
            }
        }

        static void CarregarDados()
        {
            CarregarPassageiros();
            CarregarVoos();
            CarregarPassageirosPorVoo();
        }

        static void CarregarPassageiros()
        {
            if (File.Exists(arquivoPassageiros))
            {
                string json = File.ReadAllText(arquivoPassageiros);
                if (string.IsNullOrWhiteSpace(json))
                {
                    Console.WriteLine("O arquivo JSON de passageiros está vazio.");
                    passageiros = new List<Passageiro>();
                }
                else
                {
                    try
                    {
                        passageiros = JsonSerializer.Deserialize<List<Passageiro>>(json) ?? new List<Passageiro>();
                    }
                    catch (JsonException ex)
                    {
                        Console.WriteLine($"Erro ao desserializar o JSON dos passageiros: {ex.Message}");
                        passageiros = new List<Passageiro>();
                    }
                }
            }
            else
            {
                Console.WriteLine("Arquivo JSON de passageiros não encontrado.");
                passageiros = new List<Passageiro>();
            }
        }


        static void CarregarVoos()
        {
            if (File.Exists(arquivoVoos))
            {
                string json = File.ReadAllText(arquivoVoos);
                if (string.IsNullOrWhiteSpace(json))
                {
                    Console.WriteLine("O arquivo JSON de voos está vazio.");
                }
                else
                {
                    try
                    {
                        var voos = JsonSerializer.Deserialize<List<Voo>>(json) ?? new List<Voo>();
                        voos.ForEach(voo => aeroporto.AdicionarVoo(voo));
                    }
                    catch (JsonException ex)
                    {
                        Console.WriteLine($"Erro ao desserializar o JSON dos voos: {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Arquivo JSON de voos não encontrado.");
            }
        }


        static void CarregarPassageirosPorVoo()
        {
            if (File.Exists(arquivoPassageirosPorVoo))
            {
                string json = File.ReadAllText(arquivoPassageirosPorVoo);
                if (string.IsNullOrWhiteSpace(json))
                {
                    Console.WriteLine("O arquivo JSON de passageiros por voo está vazio.");
                }
                else
                {
                    try
                    {
                        var passageirosPorVoo = JsonSerializer.Deserialize<Dictionary<string, List<string>>>(json) ?? new Dictionary<string, List<string>>();

                        foreach (var entry in passageirosPorVoo)
                        {
                            Passageiro passageiro = passageiros.FirstOrDefault(p => p.Cpf == entry.Key);
                            foreach (var numeroVoo in entry.Value)
                            {
                                Voo voo = aeroporto.BuscarVooPorNumero(numeroVoo);
                                if (passageiro != null && voo != null)
                                {
                                    passageiro.AdicionarVoo(voo, aeroporto);
                                }
                            }
                        }
                    }
                    catch (JsonException ex)
                    {
                        Console.WriteLine($"Erro ao desserializar o JSON dos passageiros por voo: {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Arquivo JSON de passageiros por voo não encontrado.");
            }
        }


        static void SalvarPassageiros()
        {
            string json = JsonSerializer.Serialize(passageiros);
            File.WriteAllText(arquivoPassageiros, json);
        }

        static void SalvarVoos()
        {
            string json = JsonSerializer.Serialize(aeroporto.ObterVoos());
            File.WriteAllText(arquivoVoos, json);
        }

        static void SalvarPassageiroPorVoo()
        {
            var passageirosPorVoo = new Dictionary<string, List<string>>();

            foreach (var passageiro in passageiros)
            {
                passageirosPorVoo[passageiro.Cpf] = passageiro.ObterVoos().Select(v => v.Numero).ToList();
            }

            string json = JsonSerializer.Serialize(passageirosPorVoo);
            File.WriteAllText(arquivoPassageirosPorVoo, json);
        }

        static void SalvarDados()
        {
            SalvarPassageiros();
            SalvarVoos();
            SalvarPassageiroPorVoo();
        }
    }
}















/*namespace BibliotecaVeiculos
{
    class Program
    {
        static List<Usuario> usuarios = new List<Usuario>();
        static Biblioteca biblioteca = new Biblioteca();

        static void Main(string[] args)
        {
            CarregarDados();

            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   SISTEMA DE GERENCIAMENTO   ======");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Biblioteca de Livros");
                Console.WriteLine("2. Gerenciar Usuários");
                Console.WriteLine("0. Sair");

                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        MenuBiblioteca();
                        break;
                    case 2:
                        MenuUsuarios();
                        break;
                    case 0:
                        SalvarDados(); // Salva dados antes de sair
                        Console.WriteLine("\nSaindo do programa...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
            } while (opcao != 0);
        }

        static void MenuBiblioteca()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   BIBLIOTECA DE LIVROS   ==========");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Livro");
                Console.WriteLine("2. Listar Livros");
                Console.WriteLine("3. Emprestar Livro");
                Console.WriteLine("4. Devolver Livro");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarLivro();
                        break;
                    case 2:
                        biblioteca.ObterLivros().ForEach(livro => livro.ExibirDetalhes());
                        break;
                    case 3:
                        EmprestarLivro();
                        break;
                    case 4:
                        DevolverLivro();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey(); // Pausa para permitir que o usuário veja a mensagem antes de continuar
            } while (opcao != 0);
        }

        static void MenuUsuarios()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("==========   GERENCIAR USUÁRIOS   ============");
                Console.WriteLine("==============================================\n");
                Console.WriteLine("1. Adicionar Usuário");
                Console.WriteLine("2. Listar Usuários");
                Console.WriteLine("3. Remover Usuário");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("==============================================");
                Console.Write("Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarUsuario();
                        break;
                    case 2:
                        ListarUsuarios();
                        break;
                    case 3:
                        RemoverUsuario();
                        break;
                    case 0:
                        Console.WriteLine("\nVoltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida, tente novamente.");
                        break;
                }
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        static void AdicionarUsuario()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO USUÁRIO   =========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o nome do usuário: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o CPF do usuário: ");
            string cpf = Console.ReadLine();

            // Verificar se o CPF já existe
            if (usuarios.Any(u => u.Cpf == cpf))
            {
                Console.WriteLine("\nUsuário com este CPF já existe.");
                return;
            }

            Usuario usuario = new Usuario(nome, cpf);
            usuarios.Add(usuario);
            Console.WriteLine("\nUsuário adicionado com sucesso!");

            // Atualizar o arquivo JSON
            SalvarUsuarios();
        }

        static void ListarUsuarios()
        {
            string caminhoArquivo = @"C:\Users\Aluno Noite\Documents\GitHub\Curso-CSharp-VS2022\usuarios.json";
            if (File.Exists(caminhoArquivo))
            {
                try
                {
                    string json = File.ReadAllText(caminhoArquivo);
                    var dados = JsonSerializer.Deserialize<Dados>(json);

                    if (dados != null && dados.Usuarios != null)
                    {
                        Console.WriteLine("==============================================");
                        Console.WriteLine("=========   LISTA DE USUÁRIOS CADASTRADOS   =========");
                        Console.WriteLine("==============================================");

                        if (dados.Usuarios.Count == 0)
                        {
                            Console.WriteLine("\nNenhum usuário cadastrado.");
                        }
                        else
                        {
                            for (int i = 0; i < dados.Usuarios.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {dados.Usuarios[i].Nome} - CPF: {dados.Usuarios[i].Cpf}");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Dados carregados são nulos ou a lista de usuários está vazia.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao carregar ou desserializar o JSON: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Arquivo JSON não encontrado.");
            }
        }

        static void RemoverUsuario()
        {
            ListarUsuarios();
            Console.Write("\nDigite o número do usuário a ser removido: ");
            int indice = int.Parse(Console.ReadLine()) - 1;

            if (indice >= 0 && indice < usuarios.Count)
            {
                usuarios.RemoveAt(indice);
                Console.WriteLine("\nUsuário removido com sucesso!");
                SalvarUsuarios(); // Atualiza o arquivo após remoção
            }
            else
            {
                Console.WriteLine("\nNúmero inválido.");
            }
        }

        static void AdicionarLivro()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("=========   ADICIONAR NOVO LIVRO   ===========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o título do livro: ");
            string titulo = Console.ReadLine();
            Console.Write("Digite o autor do livro: ");
            string autor = Console.ReadLine();
            Console.Write("Digite o ano de publicação: ");
            int ano = int.Parse(Console.ReadLine());
            Console.Write("Digite o número de páginas: ");
            int paginas = int.Parse(Console.ReadLine());

            Livro livro = new Livro(titulo, autor, ano, paginas);
            biblioteca.AdicionarLivro(livro);
            Console.WriteLine("\nLivro adicionado com sucesso!");
            SalvarLivros(); // Atualiza o arquivo após adicionar livro
        }

        static void EmprestarLivro()
        {
            ListarUsuarios();
            Console.Write("\nDigite o número do usuário que irá emprestar o livro: ");
            int usuarioIndice = int.Parse(Console.ReadLine()) - 1;

            if (usuarioIndice >= 0 && usuarioIndice < usuarios.Count)
            {
                Usuario usuario = usuarios[usuarioIndice];
                Console.Write("Digite o título do livro: ");
                string titulo = Console.ReadLine();
                Livro livro = biblioteca.BuscarLivroPorTitulo(titulo);

                if (livro != null)
                {
                    usuario.EmprestarLivro(livro, biblioteca);
                    SalvarEmprestimos(); // Atualiza o arquivo de empréstimos após emprestar livro
                }
                else
                {
                    Console.WriteLine("\nLivro não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\nNúmero de usuário inválido.");
            }
        }

        static void DevolverLivro()
        {
            ListarUsuarios();
            Console.Write("\nDigite o número do usuário que irá devolver o livro: ");
            int usuarioIndice = int.Parse(Console.ReadLine()) - 1;

            if (usuarioIndice >= 0 && usuarioIndice < usuarios.Count)
            {
                Usuario usuario = usuarios[usuarioIndice];
                Console.Write("Digite o título do livro: ");
                string titulo = Console.ReadLine();
                Livro livro = biblioteca.BuscarLivroPorTitulo(titulo);

                if (livro != null)
                {
                    usuario.DevolverLivro(livro, biblioteca);
                    SalvarEmprestimos(); // Atualiza o arquivo de empréstimos após devolver livro
                }
                else
                {
                    Console.WriteLine("\nLivro não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\nNúmero de usuário inválido.");
            }
        }

        static void CarregarDados()
        {
            // Carregar usuários
            string caminhoUsuarios = @"C:\Users\Aluno Noite\Documents\GitHub\Curso-CSharp-VS2022\usuarios.json";
            if (File.Exists(caminhoUsuarios))
            {
                string json = File.ReadAllText(caminhoUsuarios);
                try
                {
                    var dados = JsonSerializer.Deserialize<Dados>(json);
                    if (dados != null)
                    {
                        usuarios = dados.Usuarios;
                        Console.WriteLine("Usuários carregados com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Dados carregados são nulos.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao desserializar o JSON dos usuários: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Arquivo JSON de usuários não encontrado.");
            }

            // Carregar livros
            string caminhoLivros = @"C:\Users\Aluno Noite\Documents\GitHub\Curso-CSharp-VS2022\livros.json";
            if (File.Exists(caminhoLivros))
            {
                string json = File.ReadAllText(caminhoLivros);
                try
                {
                    var dados = JsonSerializer.Deserialize<Dados>(json);
                    if (dados != null)
                    {
                        biblioteca = new Biblioteca();
                        foreach (var livro in dados.Livros)
                        {
                            biblioteca.AdicionarLivro(livro);
                        }
                        Console.WriteLine("Livros carregados com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Dados carregados são nulos.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao desserializar o JSON dos livros: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Arquivo JSON de livros não encontrado.");
            }

            // Carregar empréstimos (se necessário para inicializar estado)
            string caminhoEmprestimos = @"C:\Users\Aluno Noite\Documents\GitHub\Curso-CSharp-VS2022\emprestimos.json";
            if (File.Exists(caminhoEmprestimos))
            {
                string json = File.ReadAllText(caminhoEmprestimos);
                try
                {
                    var dados = JsonSerializer.Deserialize<Dados>(json);
                    if (dados != null && dados.Emprestimos != null)
                    {
                        foreach (var emprestimo in dados.Emprestimos)
                        {
                            // Aqui você pode adicionar lógica para processar empréstimos carregados
                        }
                        Console.WriteLine("Empréstimos carregados com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine("Dados carregados são nulos.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao desserializar o JSON dos empréstimos: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Arquivo JSON de empréstimos não encontrado.");
            }
        }

        static void SalvarUsuarios()
        {
            string caminhoArquivo = @"C:\Users\Aluno Noite\Documents\GitHub\Curso-CSharp-VS2022\usuarios.json";

            try
            {
                var dados = new Dados
                {
                    Usuarios = usuarios,
                    Livros = new List<Livro>(), // Lista vazia
                    Emprestimos = new List<Emprestimo>() // Lista vazia
                };

                string json = JsonSerializer.Serialize(dados, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(caminhoArquivo, json);

                Console.WriteLine("Usuários salvos com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar usuários: {ex.Message}");
            }
        }

        static void SalvarLivros()
        {
            string caminhoArquivo = @"C:\Users\Aluno Noite\Documents\GitHub\Curso-CSharp-VS2022\livros.json";

            try
            {
                var dados = new Dados
                {
                    Usuarios = new List<Usuario>(), // Lista vazia
                    Livros = biblioteca.ObterLivros(),
                    Emprestimos = new List<Emprestimo>() // Lista vazia
                };

                string json = JsonSerializer.Serialize(dados, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(caminhoArquivo, json);

                Console.WriteLine("Livros salvos com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar livros: {ex.Message}");
            }
        }

        static void SalvarEmprestimos()
        {
            string caminhoArquivo = @"C:\Users\Aluno Noite\Documents\GitHub\Curso-CSharp-VS2022\emprestimos.json";

            try
            {
                var dados = new Dados
                {
                    Usuarios = new List<Usuario>(), // Lista vazia
                    Livros = new List<Livro>(), // Lista vazia
                    Emprestimos = usuarios.SelectMany(u => u.LivrosEmprestados.Select(l => new Emprestimo
                    {
                        UsuarioCpf = u.Cpf,
                        LivroTitulo = l.Titulo,
                        DataEmprestimo = DateTime.Now // Aqui seria ideal colocar a data real do empréstimo
                    })).ToList()
                };

                string json = JsonSerializer.Serialize(dados, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(caminhoArquivo, json);

                Console.WriteLine("Empréstimos salvos com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar empréstimos: {ex.Message}");
            }
        }

        static void SalvarDados()
        {
            SalvarUsuarios();
            SalvarEmprestimos();
            SalvarLivros();
        }
    }

    public class Dados
    {
        public List<Usuario> Usuarios { get; set; }
        public List<Livro> Livros { get; set; }
        public List<Emprestimo> Emprestimos { get; set; }
    }
}*/

/*// Instância de Cachorro
Cachorro cachorro = new Cachorro("Rex");
cachorro.ExibirInformacoes();
cachorro.FazerSom();
cachorro.ExplicarHeranca();*/

/*// Instância de Gato
Gato gato = new Gato("Mimi");
gato.ExibirInformacoes();
gato.FazerSom();
gato.ExplicarHeranca();*/

/*//Agregação
// Criando um objeto Endereco que pode existir independentemente
Endereco endereco = new Endereco("Rua Principal", "Cidade Exemplo");

// Criando um objeto Pessoa que contém um Endereco (agregação)
PessoaAgrecacao pessoa = new PessoaAgrecacao("João", endereco);

// Exibir as informações da pessoa e seu endereço
pessoa.ExibirInformacoes();

// Explicando o conceito de agregação
pessoa.ExplicarAgregacao();*/

/*//Associação
// Criando um objeto Departamento
Departamento departamento = new Departamento("Recursos Humanos");

// Criando um objeto Funcionario que está associado a um Departamento
Funcionario funcionarioComDepartamento = new Funcionario("Ana", departamento);

// Criando um objeto Funcionario sem associação a nenhum Departamento
Funcionario funcionarioSemDepartamento = new Funcionario("Carlos");

// Exibir as informações dos funcionários
funcionarioComDepartamento.ExibirInformacoes();
funcionarioSemDepartamento.ExibirInformacoes();

// Explicando o conceito de associação
funcionarioComDepartamento.ExplicarAssociacao();*/

/*//Composição
// Criando um objeto Carro, que inclui a criação de um Motor
CarroComposicao carro = new CarroComposicao("Fusca", "Motor 1600");

// Exibindo informações sobre o carro e seu motor
carro.ExibirInformacoes();

// Explicando o conceito de composição
carro.ExplicarComposicao();*/

/*//Multiplicidade
// Criando funcionários
FuncionarioMulti funcionario1 = new FuncionarioMulti("Ana");
FuncionarioMulti funcionario2 = new FuncionarioMulti("Carlos");

// Criando um projeto
Projeto projeto = new Projeto("Desenvolvimento de Software");

// Adicionando funcionários ao projeto
projeto.AdicionarFuncionario(funcionario1);
projeto.AdicionarFuncionario(funcionario2);

// Exibindo informações sobre o projeto e seus funcionários
projeto.ExibirInformacoes();

// Explicando o conceito de multiplicidade
projeto.ExplicarMultiplicidade();*/

/*//Classe Abstrata
AnimalAbs cachorro = new CachorroAbs("Rex");
AnimalAbs gato = new GatoAbs("Mimi");

// Exibindo informações e fazendo som dos animais
cachorro.ExibirInformacoes();
cachorro.FazerSom();

gato.ExibirInformacoes();
gato.FazerSom();

// Explicando o conceito de classe abstrata
cachorro.ExplicarClasseAbstrata();*/

/*//Interface
// Criando instâncias de classes que implementam a interface
IAnimal cachorro = new CachorroInter("Rex");
IAnimal gato = new GatoInter("Mimi");

// Exibindo informações e sons dos animais
cachorro.ExibirInformacoes();
cachorro.FazerSom();

gato.ExibirInformacoes();
gato.FazerSom();

// Explicando o conceito de interface
ExplicadorDeInterface explicador = new ExplicadorDeInterface();
explicador.ExplicarInterface();*/

/*//Polimorfismo
var exp = new ExplicadoraDePolimorfismo();
AnimalPoli[] animais = new AnimalPoli[3];
animais[0] = new CachorroPoli("Rex");
animais[1] = new GatoPoli("Mimi");
animais[2] = new AnimalPoli("Dinossauro");

foreach (AnimalPoli animal in animais)
{
    animal.FazerSom(); // Comportamento polimórfico
}
exp.ExplicarPolimorfismo();*/

