using CursoCSharp.Guia;
using CursoCSharp.Exercicios;
using CursoCSharp.Paradigmas;
using CursoCSharp;

using System.Text.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic;



namespace GerenciamentoAeroporto
{
    class Program
    {
        static List<Passageiro> passageiros = new List<Passageiro>();
        static Aeroporto aeroporto = new Aeroporto();
        static string DateAndTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        static Dictionary<int, List<int>> passageirosPorVoo = new Dictionary<int, List<int>>();
        static string arquivoPassageiros = @"C:\Users\Aluno Noite\Documents\GitHub\Curso-CSharp-VS2022\JSON\passageiros.json";
        static string arquivoVoos = @"C:\Users\Aluno Noite\Documents\GitHub\Curso-CSharp-VS2022\JSON\voos.json";
        static string arquivoPassageirosPorVoo = @"C:\Users\Aluno Noite\Documents\GitHub\Curso-CSharp-VS2022\JSON\passageirosPorVoo.json";
        static int proximoIdPassageiro = 1;
        static int proximoIdVoo = 1;

        static void Main(string[] args)
        {
            CarregarDados();

            int opcao = 0;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                           GERENCIAMENTO DE AEROPORTO                        ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine($"║ Autor: Arthur ============= {DateAndTime} ║");
                Console.WriteLine("╠═════════════════════════════════════════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Gerenciar Voos                                                           ║");
                Console.WriteLine("║ 2. Gerenciar Passageiros                                                    ║");
                Console.WriteLine("║ 3. Gerar Relatorio                                                          ║");
                Console.WriteLine("║ 0. Sair                                                                     ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════╝");

                Console.Write("Escolha uma opção: ");
                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            MenuVoos();
                            break;
                        case 2:
                            MenuPassageiros();
                            break;
                        case 3:
                            GerenciarRelatorio();
                            break;
                        case 0:
                            SalvarDados();
                            Console.WriteLine("\nSaindo do programa...");
                            break;
                        default:
                            Console.WriteLine("\nOpção inválida, tente novamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nOpção inválida, tente novamente.");
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        static void MenuVoos()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                           GERENCIAMENTO DE VOOS                             ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine($"║ Autor: Arthur ========================================= {DateAndTime} ║");
                Console.WriteLine("╠═════════════════════════════════════════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Adicionar Voo                                                            ║");
                Console.WriteLine("║ 2. Listar Voos                                                              ║");
                Console.WriteLine("║ 3. Atualizar Voo                                                            ║");
                Console.WriteLine("║ 4. Adicionar Passageiro a Voo                                               ║");
                Console.WriteLine("║ 5. Listar Passageiros de um Voo                                             ║");
                Console.WriteLine("║ 6. Remover Passageiros de um Voo                                            ║");
                Console.WriteLine("║ 7. Excluir Voo                                                              ║");
                Console.WriteLine("║ 0. Voltar                                                                   ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════╝");

                Console.Write("Escolha uma opção: ");
                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            AdicionarVoo();
                            break;
                        case 2:
                            ListarVoos();
                            break;
                        case 3:
                            AtualizarVoo();
                            break;
                        case 4:
                            AdicionarPassageiroAVoo();
                            break;
                        case 5:
                            ListarPassageirosDeVoo();
                            break;
                        case 6:
                            RemoverVooDePassageiro();
                            break;
                        case 7:
                            ExcluirVoo();
                            break;
                        case 0:
                            Console.WriteLine("\nVoltando ao menu principal...");
                            break;
                        default:
                            Console.WriteLine("\nOpção inválida, tente novamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nOpção inválida, tente novamente.");
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
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("║                         GERENCIAMENTO DE PASSAGEIROS                          ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine($"║ Autor: Arthur ============= {DateAndTime} ║");
                Console.WriteLine("╠═════════════════════════════════════════════════════════════════════════════╣");
                Console.WriteLine("║ 1. Adicionar Passageiro                                                    ║");
                Console.WriteLine("║ 2. Listar Passageiros                                                      ║");
                Console.WriteLine("║ 3. Atualizar Passageiro                                                    ║");
                Console.WriteLine("║ 4. Excluir Passageiro                                                      ║");
                Console.WriteLine("║ 0. Voltar                                                                  ║");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════╝");

                Console.Write("Escolha uma opção: ");
                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            AdicionarPassageiro();
                            break;
                        case 2:
                            ListarPassageiros();
                            break;
                        case 3:
                            AtualizarPassageiro();
                            break;
                        case 4:
                            ExcluirPassageiro();
                            break;
                        case 0:
                            Console.WriteLine("\nVoltando ao menu principal...");
                            break;
                        default:
                            Console.WriteLine("\nOpção inválida, tente novamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nOpção inválida, tente novamente.");
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }


        static void AdicionarPassageiro()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                         ADICIONAR NOVO PASSAGEIRO                              ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine($"║ Data e Hora: {DateTime.Now:dd/MM/yyyy HH:mm}                               ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            string nome;
            string cpf;

            do
            {
                Console.Write("Digite o nome do passageiro: ");
                nome = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(nome) || nome.Length > 50);

            do
            {
                Console.Write("Digite o CPF do passageiro (formato XXX.XXX.XXX-XX): ");
                cpf = Console.ReadLine();
            } while (!IsValidCPF(cpf));

            Passageiro novoPassageiro = new Passageiro(proximoIdPassageiro++, nome, cpf);
            passageiros.Add(novoPassageiro);
            Console.WriteLine("\nPassageiro adicionado com sucesso!");
            SalvarPassageiros();
        }

        static bool IsValidCPF(string cpf)
        {
            // Simples validação do formato do CPF. Deve ser ajustada conforme a necessidade
            return System.Text.RegularExpressions.Regex.IsMatch(cpf, @"^\d{3}\.\d{3}\.\d{3}-\d{2}$");
        }


        static void ListarPassageiros()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                           LISTA DE PASSAGEIROS                              ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine($"║ Data e Hora: {DateTime.Now:dd/MM/yyyy HH:mm}                               ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            if (passageiros.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nNenhum passageiro cadastrado.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                // Cabeçalhos da tabela
                Console.WriteLine("╔═════╦════════════════════════════════════╦══════════════════╗");
                Console.WriteLine("║ ID  ║ Nome                               ║ CPF              ║");
                Console.WriteLine("╠═════╬════════════════════════════════════╬══════════════════╣");

                foreach (var passageiro in passageiros)
                {
                    string nome = passageiro.Nome.Length > 30 ? passageiro.Nome.Substring(0, 30) : passageiro.Nome.PadRight(35);
                    Console.WriteLine($"║ {passageiro.Id,-3} ║ {nome} ║ {passageiro.CPF.PadRight(14)} ║");
                }

                // Linha de rodapé
                Console.WriteLine("╚═════╩════════════════════════════════════╩══════════════════╝");
                Console.ResetColor();
            }

            Console.WriteLine("\nPressione Enter para voltar ao menu...");
            Console.ReadKey();
        }

        static void AtualizarPassageiro()
        {
            ListarPassageiros();

            Console.Write("\nDigite o ID do passageiro a ser atualizado: ");
            if (int.TryParse(Console.ReadLine(), out int idPassageiro))
            {
                var passageiro = passageiros.FirstOrDefault(p => p.Id == idPassageiro);
                if (passageiro != null)
                {
                    string novoNome;
                    string novoCPF;

                    do
                    {
                        Console.Write("Digite o novo nome do passageiro: ");
                        novoNome = Console.ReadLine();
                    } while (string.IsNullOrWhiteSpace(novoNome) || novoNome.Length > 50);

                    do
                    {
                        Console.Write("Digite o novo CPF do passageiro (formato XXX.XXX.XXX-XX): ");
                        novoCPF = Console.ReadLine();
                    } while (!IsValidCPF(novoCPF));

                    passageiro.Nome = novoNome;
                    passageiro.CPF = novoCPF;

                    Console.WriteLine("\nPassageiro atualizado com sucesso.");
                    SalvarPassageiros();
                }
                else
                {
                    Console.WriteLine("\nPassageiro com o ID informado não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\nID inválido.");
            }
        }


        static void ExcluirPassageiro()
        {
            ListarPassageiros();

            Console.Write("\nDigite o ID do passageiro a ser excluído: ");
            if (int.TryParse(Console.ReadLine(), out int idPassageiro))
            {
                var passageiro = passageiros.FirstOrDefault(p => p.Id == idPassageiro);
                if (passageiro != null)
                {
                    // Remover todos os voos associados ao passageiro
                    foreach (var voo in passageiro.ObterVoos())
                    {
                        aeroporto.RemoverVoo(voo.Id);  // Remover o voo do aeroporto
                        passageirosPorVoo = passageirosPorVoo
                            .Where(p => p.Value.Contains(voo.Id))
                            .ToDictionary(p => p.Key, p => p.Value.Where(v => v != voo.Id).ToList());
                    }

                    passageiros.Remove(passageiro);
                    Console.WriteLine("\nPassageiro removido com sucesso.");
                    SalvarPassageiros();
                    SalvarVoos();
                    SalvarPassageirosPorVoo();
                }
                else
                {
                    Console.WriteLine("\nPassageiro com o ID informado não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\nID inválido.");
            }
        }

        static void AdicionarVoo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                            ADICIONAR NOVO VOO                                 ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine($"║ Data e Hora: {DateTime.Now:dd/MM/yyyy HH:mm}                               ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            string numero;
            string origem;
            string destino;

            do
            {
                Console.Write("Digite o número do voo: ");
                numero = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(numero) || numero.Length > 10);

            do
            {
                Console.Write("Digite a origem do voo: ");
                origem = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(origem) || origem.Length > 20);

            do
            {
                Console.Write("Digite o destino do voo: ");
                destino = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(destino) || destino.Length > 20);

            Voo novoVoo = new Voo(proximoIdVoo++, numero, origem, destino);
            aeroporto.AdicionarVoo(novoVoo);
            Console.WriteLine("\nVoo adicionado com sucesso!");
            SalvarVoos();
        }


        static void ListarVoos()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                              LISTA DE VOOS                                  ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine($"║ Data e Hora: {DateTime.Now:dd/MM/yyyy HH:mm}                                               ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            var voos = aeroporto.ObterVoos();
            if (voos.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nNenhum voo cadastrado.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                // Cabeçalhos da tabela
                Console.WriteLine("╔═════╦════════════════╦════════════════╦════════════════╗");
                Console.WriteLine("║ ID  ║ Número         ║ Origem         ║ Destino        ║");
                Console.WriteLine("╠═════╬════════════════╬════════════════╬════════════════╣");

                foreach (var voo in voos)
                {
                    string numero = voo.Numero.Length > 15 ? voo.Numero.Substring(0, 15) : voo.Numero.PadRight(15);
                    string origem = voo.Origem.Length > 15 ? voo.Origem.Substring(0, 15) : voo.Origem.PadRight(15);
                    string destino = voo.Destino.Length > 15 ? voo.Destino.Substring(0, 15) : voo.Destino.PadRight(15);

                    Console.WriteLine($"║ {voo.Id,-3} ║ {numero} ║ {origem} ║ {destino} ║");
                }

                // Linha de rodapé
                Console.WriteLine("╚═════╩════════════════╩════════════════╩════════════════╝");
                Console.ResetColor();
            }

            Console.WriteLine("\nPressione Enter para voltar ao menu...");
            Console.ReadKey();
        }

        static void AtualizarVoo()
        {
            ListarVoos();

            Console.Write("\nDigite o ID do voo a ser atualizado: ");
            if (int.TryParse(Console.ReadLine(), out int idVoo))
            {
                var voo = aeroporto.BuscarVooPorId(idVoo);
                if (voo != null)
                {
                    string novoNumero;
                    string novaOrigem;
                    string novoDestino;

                    do
                    {
                        Console.Write("Digite o novo número do voo: ");
                        novoNumero = Console.ReadLine();
                    } while (string.IsNullOrWhiteSpace(novoNumero) || novoNumero.Length > 10);

                    do
                    {
                        Console.Write("Digite a nova origem do voo: ");
                        novaOrigem = Console.ReadLine();
                    } while (string.IsNullOrWhiteSpace(novaOrigem) || novaOrigem.Length > 20);

                    do
                    {
                        Console.Write("Digite o novo destino do voo: ");
                        novoDestino = Console.ReadLine();
                    } while (string.IsNullOrWhiteSpace(novoDestino) || novoDestino.Length > 20);

                    voo.Numero = novoNumero;
                    voo.Origem = novaOrigem;
                    voo.Destino = novoDestino;

                    Console.WriteLine("\nVoo atualizado com sucesso.");
                    SalvarVoos();
                }
                else
                {
                    Console.WriteLine("\nVoo com o ID informado não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\nID inválido.");
            }
        }

        static void ExcluirVoo()
        {
            ListarVoos();

            Console.Write("\nDigite o ID do voo a ser excluído: ");
            if (int.TryParse(Console.ReadLine(), out int idVoo))
            {
                var voo = aeroporto.BuscarVooPorId(idVoo);
                if (voo != null)
                {
                    aeroporto.RemoverVoo(idVoo);
                    passageirosPorVoo = passageirosPorVoo
                        .Where(p => p.Value.Contains(idVoo))
                        .ToDictionary(p => p.Key, p => p.Value.Where(v => v != idVoo).ToList());

                    Console.WriteLine("\nVoo removido com sucesso.");
                    SalvarVoos();
                    SalvarPassageirosPorVoo();
                }
                else
                {
                    Console.WriteLine("\nVoo com o ID informado não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\nID inválido.");
            }
        }

        static void AdicionarPassageiroAVoo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                      ADICIONAR PASSAGEIRO A VOO                               ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine($"║ Data e Hora: {DateTime.Now:dd/MM/yyyy HH:mm}                               ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            ListarPassageiros();
            Console.Write("\nDigite o ID do passageiro: ");
            if (int.TryParse(Console.ReadLine(), out int passageiroId))
            {
                var passageiro = passageiros.FirstOrDefault(p => p.Id == passageiroId);
                if (passageiro != null)
                {
                    ListarVoos();
                    Console.Write("\nDigite o ID do voo: ");
                    if (int.TryParse(Console.ReadLine(), out int vooId))
                    {
                        Voo voo = aeroporto.BuscarVooPorId(vooId);
                        if (voo != null)
                        {
                            passageiro.AdicionarVoo(voo, aeroporto); // Adiciona o voo ao passageiro

                            if (!passageirosPorVoo.ContainsKey(passageiroId))
                            {
                                passageirosPorVoo[passageiroId] = new List<int>();
                            }

                            if (!passageirosPorVoo[passageiroId].Contains(vooId))
                            {
                                passageirosPorVoo[passageiroId].Add(vooId);
                            }

                            SalvarPassageirosPorVoo();
                            Console.WriteLine("\nPassageiro adicionado ao voo com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("\nVoo com o ID informado não encontrado.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nID do voo inválido.");
                    }
                }
                else
                {
                    Console.WriteLine("\nPassageiro com o ID informado não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\nID do passageiro inválido.");
            }
        }

        static void ListarPassageirosDeVoo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                     LISTA DE PASSAGEIROS POR VOO                               ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine($"║ Data e Hora: {DateTime.Now:dd/MM/yyyy HH:mm}                               ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            Console.Write("Digite o ID do voo: ");
            if (int.TryParse(Console.ReadLine(), out int vooId))
            {
                Voo voo = aeroporto.BuscarVooPorId(vooId);
                if (voo != null)
                {
                    var passageirosVoo = passageiros.Where(p => p.ObterVoos().Any(v => v.Id == vooId)).ToList();
                    Console.WriteLine($"Passageiros do voo {vooId}:");
                    if (passageirosVoo.Count > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;

                        // Cabeçalhos da tabela
                        Console.WriteLine("╔═════╦════════════════════════════════════════╦══════════════════╗");
                        Console.WriteLine("║ ID  ║ Nome                               ║ CPF              ║");
                        Console.WriteLine("╠═════╬════════════════════════════════════╬══════════════════╣");

                        foreach (var passageiro in passageirosVoo)
                        {
                            string nome = passageiro.Nome.Length > 30 ? passageiro.Nome.Substring(0, 30) : passageiro.Nome.PadRight(35);
                            Console.WriteLine($"║ {passageiro.Id,-3} ║ {nome} ║ {passageiro.CPF.PadRight(14)} ║");
                        }

                        // Linha de rodapé
                        Console.WriteLine("╚═════╩════════════════════════════════════╩══════════════════╝");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Nenhum passageiro encontrado para o voo {vooId}.");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.WriteLine("Voo não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\nID do voo inválido.");
            }

            Console.WriteLine("\nPressione Enter para voltar ao menu...");
            Console.ReadKey();
        }

        static void RemoverVooDePassageiro()
        {
            ListarPassageiros();

            Console.Write("\nDigite o ID do passageiro: ");
            if (int.TryParse(Console.ReadLine(), out int idPassageiro))
            {
                var passageiro = passageiros.FirstOrDefault(p => p.Id == idPassageiro);
                if (passageiro != null)
                {
                    ListarVoos();

                    Console.Write("\nDigite o ID do voo a ser removido do passageiro: ");
                    if (int.TryParse(Console.ReadLine(), out int idVoo))
                    {
                        // Remove o voo da lista do passageiro
                        passageiro.RemoverVoo(idVoo);

                        // Atualize o dicionário de passageirosPorVoo
                        if (passageirosPorVoo.ContainsKey(idPassageiro))
                        {
                            passageirosPorVoo[idPassageiro].Remove(idVoo);
                        }

                        SalvarPassageiros();
                        SalvarPassageirosPorVoo();
                        Console.WriteLine("\nVoo removido do passageiro com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("\nID do voo inválido.");
                    }
                }
                else
                {
                    Console.WriteLine("\nPassageiro não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\nID do passageiro inválido.");
            }
        }

        static void GerenciarRelatorio()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                      RELATÓRIO DE VOOS E PASSAGEIROS                         ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();

            // Itera sobre todos os voos
            foreach (var voo in aeroporto.ObterVoos())
            {
                // Obtém a lista de passageiros para o voo atual
                var passageirosNoVoo = passageirosPorVoo
                    .Where(p => p.Value.Contains(voo.Id))
                    .Select(p => passageiros.FirstOrDefault(pass => pass.Id == p.Key))
                    .Where(p => p != null)
                    .ToList();

                // Exibe informações do voo
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine($"║ Voo ID: {voo.Id.ToString().PadRight(35)}                                 ║");
                Console.WriteLine($"║ Número: {voo.Numero.PadRight(30)}                                      ║");
                Console.WriteLine($"║ Origem: {voo.Origem.PadRight(30)}                                      ║");
                Console.WriteLine($"║ Destino: {voo.Destino.PadRight(30)}                                     ║");
                Console.WriteLine("╠═════════════════════════════════════════════════════════════════════════════╣");
                Console.WriteLine("║ Passageiros:                                                                ║");
                Console.WriteLine("╠═════════════════════════════════════════════════════════════════════════════╣");

                if (passageirosNoVoo.Any())
                {
                    foreach (var passageiro in passageirosNoVoo)
                    {
                        Console.WriteLine($"║ ID - {passageiro.Id.ToString()}.   {passageiro.Nome.PadRight(32)}                                  ║");
                    }
                }
                else
                {
                    Console.WriteLine("║ Nenhum passageiro para este voo.                                            ║");
                }

                // Linha de rodapé para cada voo
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine();
            }

            Console.ResetColor();
            Console.WriteLine("Pressione Enter para voltar ao menu...");
            Console.ReadKey();
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
                passageiros = JsonSerializer.Deserialize<List<Passageiro>>(json) ?? new List<Passageiro>();

                if (passageiros.Count > 0)
                {
                    proximoIdPassageiro = passageiros.Max(p => p.Id) + 1;
                }
            }
        }

        static void CarregarVoos()
        {
            if (File.Exists(arquivoVoos))
            {
                string json = File.ReadAllText(arquivoVoos);
                var voos = JsonSerializer.Deserialize<List<Voo>>(json) ?? new List<Voo>();
                foreach (var voo in voos)
                {
                    aeroporto.AdicionarVoo(voo);
                }

                if (voos.Count > 0)
                {
                    proximoIdVoo = voos.Max(v => v.Id) + 1;
                }
            }
        }

        static void CarregarPassageirosPorVoo()
        {
            if (File.Exists(arquivoPassageirosPorVoo))
            {
                string json = File.ReadAllText(arquivoPassageirosPorVoo);
                if (!string.IsNullOrWhiteSpace(json))
                {
                    try
                    {
                        passageirosPorVoo = JsonSerializer.Deserialize<Dictionary<int, List<int>>>(json) ?? new Dictionary<int, List<int>>();

                        foreach (var entry in passageirosPorVoo)
                        {
                            Passageiro passageiro = passageiros.FirstOrDefault(p => p.Id == entry.Key);
                            foreach (var vooId in entry.Value)
                            {
                                Voo voo = aeroporto.BuscarVooPorId(vooId);
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
        }

        static void SalvarPassageiros()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(passageiros, options);
            File.WriteAllText(arquivoPassageiros, json);
        }

        static void SalvarVoos()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(aeroporto.ObterVoos(), options);
            File.WriteAllText(arquivoVoos, json);
        }

        static void SalvarPassageirosPorVoo()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(passageirosPorVoo, options);
            File.WriteAllText(arquivoPassageirosPorVoo, json);
        }

        static void SalvarDados()
        {
            SalvarPassageiros();
            SalvarVoos();
            SalvarPassageirosPorVoo();
        }
    }
}



/*namespace GerenciamentoAeroporto
{
    class Program
    {
        static List<Passageiro> passageiros = new List<Passageiro>();
        static Aeroporto aeroporto = new Aeroporto();
        static string DateAndTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        static Dictionary<int, List<int>> passageirosPorVoo = new Dictionary<int, List<int>>();
        static string arquivoPassageiros = @"C:\Users\Aluno Noite\Documents\GitHub\Curso-CSharp-VS2022\JSON\passageiros.json";
        static string arquivoVoos = @"C:\Users\Aluno Noite\Documents\GitHub\Curso-CSharp-VS2022\JSON\voos.json";
        static string arquivoPassageirosPorVoo = @"C:\Users\Aluno Noite\Documents\GitHub\Curso-CSharp-VS2022\JSON\passageirosPorVoo.json";
        static int proximoIdPassageiro = 1;
        static int proximoIdVoo = 1;

        static void Main(string[] args)
        {
            CarregarDados();

            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("==============================================");
                Console.WriteLine("======= GERENCIAMENTO DE AEROPORTO ===========");
                Console.WriteLine("==============================================");
                Console.WriteLine("Autor: Arthur =============" + DateAndTime + "\n");
                Console.WriteLine("1. Gerenciar Voos");
                Console.WriteLine("2. Gerenciar Passageiros");
                Console.WriteLine("0. Sair");
                Console.WriteLine("\n==============================================");

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
                Console.WriteLine("======= GERENCIAMENTO DE AEROPORTO ===========");
                Console.WriteLine("==============================================");
                Console.WriteLine("Autor: Arthur =============" + DateAndTime + "\n");
                Console.WriteLine("1. Adicionar Voo");
                Console.WriteLine("2. Listar Voos");
                Console.WriteLine("3. Atualizar Voo");
                Console.WriteLine("4. Adicionar Passageiro a Voo");
                Console.WriteLine("5. Listar Passageiros de um Voo");
                Console.WriteLine("6. Excluir Voo");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("\n==============================================");

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
                        AtualizarVoo();
                        break;
                    case 4:
                        AdicionarPassageiroAVoo();
                        break;
                    case 5:
                        ListarPassageirosDeVoo();
                        break;
                    case 6:
                        ExcluirVoo();
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
                Console.WriteLine("======= GERENCIAMENTO DE AEROPORTO ===========");
                Console.WriteLine("==============================================");
                Console.WriteLine("Autor: Arthur =============" + DateAndTime + "\n");
                Console.WriteLine("1. Adicionar Passageiro");
                Console.WriteLine("2. Listar Passageiros");
                Console.WriteLine("3. Atualizar Passageiro");
                Console.WriteLine("4. Excluir Passageiro");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("\n==============================================");

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
                    case 3:
                        AtualizarPassageiro();
                        break;
                    case 4:
                        ExcluirPassageiro();
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
            Console.WriteLine("======= GERENCIAMENTO DE AEROPORTO ===========");
            Console.WriteLine("==============================================");
            Console.WriteLine("Autor: Arthur =============" + DateAndTime + "\n");
            Console.WriteLine("==============================================");
            Console.WriteLine("======== ADICIONAR NOVO PASSAGEIRO ==========");
            Console.WriteLine("==============================================");
            Console.Write("Digite o nome do passageiro: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o CPF do passageiro: ");
            string cpf = Console.ReadLine();

            Passageiro novoPassageiro = new Passageiro(proximoIdPassageiro++, nome, cpf);
            passageiros.Add(novoPassageiro);
            Console.WriteLine("\nPassageiro adicionado com sucesso!");
            SalvarPassageiros();
        }

        static void ListarPassageiros()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("======= GERENCIAMENTO DE AEROPORTO ===========");
            Console.WriteLine("==============================================");
            Console.WriteLine("Autor: Arthur =============" + DateAndTime + "\n");
            Console.WriteLine("==============================================");
            Console.WriteLine("======= LISTA DE PASSAGEIROS ================");
            Console.WriteLine("==============================================");

            if (passageiros.Count == 0)
            {
                Console.WriteLine("\nNenhum passageiro cadastrado.");
            }
            else
            {
                foreach (var passageiro in passageiros)
                {
                    Console.WriteLine($"ID: {passageiro.Id} - Nome: {passageiro.Nome} - CPF: {passageiro.CPF}");
                }
            }
        }

        static void AtualizarPassageiro()
        {
            ListarPassageiros();

            Console.Write("\nDigite o ID do passageiro a ser atualizado: ");
            if (int.TryParse(Console.ReadLine(), out int idPassageiro))
            {
                var passageiro = passageiros.FirstOrDefault(p => p.Id == idPassageiro);
                if (passageiro != null)
                {
                    Console.Write("Digite o novo nome do passageiro: ");
                    passageiro.Nome = Console.ReadLine();
                    Console.Write("Digite o novo CPF do passageiro: ");
                    passageiro.CPF = Console.ReadLine();

                    Console.WriteLine("\nPassageiro atualizado com sucesso.");
                    SalvarPassageiros();
                }
                else
                {
                    Console.WriteLine("\nPassageiro com o ID informado não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\nID inválido.");
            }
        }

        static void ExcluirPassageiro()
        {
            ListarPassageiros();

            Console.Write("\nDigite o ID do passageiro a ser excluído: ");
            if (int.TryParse(Console.ReadLine(), out int idPassageiro))
            {
                var passageiro = passageiros.FirstOrDefault(p => p.Id == idPassageiro);
                if (passageiro != null)
                {
                    passageiros.Remove(passageiro);
                    Console.WriteLine("\nPassageiro removido com sucesso.");
                    SalvarPassageiros();
                }
                else
                {
                    Console.WriteLine("\nPassageiro com o ID informado não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\nID inválido.");
            }
        }

        static void AdicionarVoo()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("======= GERENCIAMENTO DE AEROPORTO ===========");
            Console.WriteLine("==============================================");
            Console.WriteLine("Autor: Arthur =============" + DateAndTime + "\n");
            Console.WriteLine("==============================================");
            Console.WriteLine("======== ADICIONAR NOVO VOO ================");
            Console.WriteLine("==============================================");
            Console.Write("Digite o número do voo: ");
            string numero = Console.ReadLine();
            Console.Write("Digite a origem do voo: ");
            string origem = Console.ReadLine();
            Console.Write("Digite o destino do voo: ");
            string destino = Console.ReadLine();

            Voo novoVoo = new Voo(proximoIdVoo++, numero, origem, destino);
            aeroporto.AdicionarVoo(novoVoo);
            Console.WriteLine("\nVoo adicionado com sucesso!");
            SalvarVoos();
        }

        static void ListarVoos()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("======= GERENCIAMENTO DE AEROPORTO ===========");
            Console.WriteLine("==============================================");
            Console.WriteLine("Autor: Arthur =============" + DateAndTime + "\n");
            Console.WriteLine("==============================================");
            Console.WriteLine("=========== LISTA DE VOOS ==================");
            Console.WriteLine("==============================================");

            var voos = aeroporto.ObterVoos();
            if (voos.Count == 0)
            {
                Console.WriteLine("\nNenhum voo cadastrado.");
            }
            else
            {
                foreach (var voo in voos)
                {
                    voo.ExibirDetalhes();
                }
            }
        }

        static void AtualizarVoo()
        {
            ListarVoos();

            Console.Write("\nDigite o ID do voo a ser atualizado: ");
            if (int.TryParse(Console.ReadLine(), out int idVoo))
            {
                var voo = aeroporto.BuscarVooPorId(idVoo);
                if (voo != null)
                {
                    Console.Write("Digite o novo número do voo: ");
                    voo.Numero = Console.ReadLine();
                    Console.Write("Digite a nova origem do voo: ");
                    voo.Origem = Console.ReadLine();
                    Console.Write("Digite o novo destino do voo: ");
                    voo.Destino = Console.ReadLine();

                    Console.WriteLine("\nVoo atualizado com sucesso.");
                    SalvarVoos();
                }
                else
                {
                    Console.WriteLine("\nVoo com o ID informado não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\nID inválido.");
            }
        }

        static void ExcluirVoo()
        {
            ListarVoos();

            Console.Write("\nDigite o ID do voo a ser excluído: ");
            if (int.TryParse(Console.ReadLine(), out int idVoo))
            {
                var voo = aeroporto.BuscarVooPorId(idVoo);
                if (voo != null)
                {
                    aeroporto.RemoverVoo(idVoo);
                    passageirosPorVoo = passageirosPorVoo
                        .Where(p => p.Value.Contains(idVoo))
                        .ToDictionary(p => p.Key, p => p.Value.Where(v => v != idVoo).ToList());

                    Console.WriteLine("\nVoo removido com sucesso.");
                    SalvarVoos();
                    SalvarPassageirosPorVoo();
                }
                else
                {
                    Console.WriteLine("\nVoo com o ID informado não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\nID inválido.");
            }
        }

        static void AdicionarPassageiroAVoo()
        {
            Console.Clear();
            Console.WriteLine("==============================================");
            Console.WriteLine("======= GERENCIAMENTO DE AEROPORTO ===========");
            Console.WriteLine("==============================================");
            Console.WriteLine("Autor: Arthur =============" + DateAndTime + "\n");
            Console.WriteLine("==============================================");
            Console.WriteLine("==== ADICIONAR PASSAGEIRO A VOO ==============");
            Console.WriteLine("==============================================");

            ListarPassageiros();
            Console.Write("\nDigite o ID do passageiro: ");
            if (int.TryParse(Console.ReadLine(), out int passageiroId))
            {
                var passageiro = passageiros.FirstOrDefault(p => p.Id == passageiroId);
                if (passageiro != null)
                {
                    ListarVoos();
                    Console.Write("\nDigite o ID do voo: ");
                    if (int.TryParse(Console.ReadLine(), out int vooId))
                    {
                        Voo voo = aeroporto.BuscarVooPorId(vooId);
                        if (voo != null)
                        {
                            passageiro.AdicionarVoo(voo, aeroporto);

                            if (!passageirosPorVoo.ContainsKey(passageiroId))
                            {
                                passageirosPorVoo[passageiroId] = new List<int>();
                            }

                            if (!passageirosPorVoo[passageiroId].Contains(vooId))
                            {
                                passageirosPorVoo[passageiroId].Add(vooId);
                            }

                            SalvarPassageirosPorVoo();
                            Console.WriteLine("\nPassageiro adicionado ao voo com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("\nVoo não encontrado.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nID do voo inválido.");
                    }
                }
                else
                {
                    Console.WriteLine("\nPassageiro não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\nID do passageiro inválido.");
            }
        }

        static void ListarPassageirosDeVoo()
        {
            Console.Clear();
            Console.Write("Digite o ID do voo: ");
            if (int.TryParse(Console.ReadLine(), out int vooId))
            {
                Voo voo = aeroporto.BuscarVooPorId(vooId);
                if (voo != null)
                {
                    var passageirosVoo = passageiros.Where(p => p.ObterVoos().Any(v => v.Id == vooId)).ToList();
                    Console.WriteLine($"Passageiros do voo {vooId}:");
                    if (passageirosVoo.Count > 0)
                    {
                        foreach (var passageiro in passageirosVoo)
                        {
                            Console.WriteLine($"Nome: {passageiro.Nome} - CPF: {passageiro.CPF}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Nenhum passageiro encontrado para o voo {vooId}.");
                    }
                }
                else
                {
                    Console.WriteLine("Voo não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\nID do voo inválido.");
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
                passageiros = JsonSerializer.Deserialize<List<Passageiro>>(json) ?? new List<Passageiro>();

                if (passageiros.Count > 0)
                {
                    proximoIdPassageiro = passageiros.Max(p => p.Id) + 1;
                }
            }
        }

        static void CarregarVoos()
        {
            if (File.Exists(arquivoVoos))
            {
                string json = File.ReadAllText(arquivoVoos);
                var voos = JsonSerializer.Deserialize<List<Voo>>(json) ?? new List<Voo>();
                foreach (var voo in voos)
                {
                    aeroporto.AdicionarVoo(voo);
                }

                if (voos.Count > 0)
                {
                    proximoIdVoo = voos.Max(v => v.Id) + 1;
                }
            }
        }

        static void CarregarPassageirosPorVoo()
        {
            if (File.Exists(arquivoPassageirosPorVoo))
            {
                string json = File.ReadAllText(arquivoPassageirosPorVoo);
                if (!string.IsNullOrWhiteSpace(json))
                {
                    try
                    {
                        passageirosPorVoo = JsonSerializer.Deserialize<Dictionary<int, List<int>>>(json) ?? new Dictionary<int, List<int>>();

                        foreach (var entry in passageirosPorVoo)
                        {
                            Passageiro passageiro = passageiros.FirstOrDefault(p => p.Id == entry.Key);
                            foreach (var vooId in entry.Value)
                            {
                                Voo voo = aeroporto.BuscarVooPorId(vooId);
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
        }

        static void SalvarPassageiros()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(passageiros, options);
            File.WriteAllText(arquivoPassageiros, json);
        }

        static void SalvarVoos()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(aeroporto.ObterVoos(), options);
            File.WriteAllText(arquivoVoos, json);
        }

        static void SalvarPassageirosPorVoo()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(passageirosPorVoo, options);
            File.WriteAllText(arquivoPassageirosPorVoo, json);
        }

        static void SalvarDados()
        {
            SalvarPassageiros();
            SalvarVoos();
            SalvarPassageirosPorVoo();
        }
    }
}*/


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

