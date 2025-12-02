using System;
using System.Globalization;
using System.Text.Json.Serialization.Metadata;
using System.Linq;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO.Compression;

namespace SistemaBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mangas = {"Berserk", "Terra das Gemas", "Boa Noite Punpun", "Monster", "One Piece"};
            string[] estado_manga = {"Disponivel", "Disponivel", "Emprestado", "Disponivel", "Emprestado"};
            int[] opcao_emprestado = {0, 0 ,0 , 0, 0};
            double manga_disponivel = 0;
            double manga_emprestado = 0;
            bool erro = false;
            int opcao, opcao_emprestimo, opcao_devolver, numero_opcao = 0;
            int contador = 0;
            string pesquisa;

            do
            {
                manga_disponivel = 0;
                manga_emprestado = 0;

                Console.WriteLine("1 - Listar mangás.");
                Console.WriteLine("2 - Emprestar um mangá.");
                Console.WriteLine("3 - Devolver um mangá.");
                Console.WriteLine("4 - Buscar mangá pelo nome.");
                Console.WriteLine("5 - Ver estatísticas");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Digite um número das opções: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("###Lista de Mangás###");
                        for (int i = 0, j = 0; i < mangas.Length && j < mangas.Length; i++, j++)
                        {
                            Console.WriteLine($"Nome: {mangas[i]} || Estado: {estado_manga[i]}");
                        }
                        break;
                    case 2:
                        for (int i = 0; i < mangas.Length; i++)
                        {
                            if (estado_manga[i] == "Disponivel")
                            {
                                manga_disponivel++;
                            }
                            else if (estado_manga[i] == "Emprestado")
                            {
                                manga_emprestado++;
                            }
                            else
                            {
                                Console.WriteLine("Erro!!!!");
                                erro = true;
                                break;
                            }
                        }

                        if (erro == true)
                        {
                            Console.WriteLine("O programa sera encerrado!!!!");
                            Environment.Exit(0);
                        }
                        else
                        {
                            if (manga_disponivel <= 0)
                            {
                                Console.WriteLine("Não temos mangás disponiveis, volte mais tarde.");
                            } 
                            else
                            {
                                do{
                                    for (int i = 0; i < mangas.Length; i++)
                                    {
                                        Console.WriteLine($"{i + 1} - {mangas[i]} || {estado_manga[i]}");
                                    }
                                    Console.WriteLine("0 - Voltar.");
                                    
                                    Console.WriteLine("Digite o número do mangá que você quer pegar emprestado: ");
                                    opcao_emprestimo = int.Parse(Console.ReadLine());

                                    switch (opcao_emprestimo)
                                    {
                                        case 1:
                                            if (estado_manga[opcao_emprestimo - 1] == "Disponivel")
                                            {
                                                Console.WriteLine($"Você pegou {mangas[opcao_emprestimo - 1]} emprestado.");
                                                estado_manga[opcao_emprestimo - 1] = "Emprestado";
                                                manga_emprestado++;
                                                manga_disponivel--;
                                            } 
                                            else if (estado_manga[opcao_emprestimo - 1] == "Emprestado")
                                            {
                                                Console.WriteLine("Esse mangá não esta disponivel para emprestimo no momento");
                                            } 
                                            else
                                            {
                                                Console.WriteLine("ERRO!!!! O Programa será fechado!!!!!!");
                                                Environment.Exit(0);
                                            }
                                            break;
                                        case 2:
                                            if (estado_manga[opcao_emprestimo - 1] == "Disponivel")
                                            {
                                                Console.WriteLine($"Você pegou {mangas[opcao_emprestimo - 1]} emprestado.");
                                                estado_manga[opcao_emprestimo - 1] = "Emprestado";
                                                manga_emprestado++;
                                                manga_disponivel--;
                                            } 
                                            else if (estado_manga[opcao_emprestimo - 1] == "Emprestado")
                                            {
                                                Console.WriteLine("Esse mangá não esta disponivel para emprestimo no momento");
                                            } 
                                            else
                                            {
                                                Console.WriteLine("ERRO!!!! O Programa será fechado!!!!!!");
                                                Environment.Exit(0);
                                            }
                                            break;
                                        case 3:
                                            if (estado_manga[opcao_emprestimo - 1] == "Disponivel")
                                            {
                                                Console.WriteLine($"Você pegou {mangas[opcao_emprestimo - 1]} emprestado.");
                                                estado_manga[opcao_emprestimo - 1] = "Emprestado";
                                                manga_emprestado++;
                                                manga_disponivel--;
                                            } 
                                            else if (estado_manga[opcao_emprestimo - 1] == "Emprestado")
                                            {
                                                Console.WriteLine("Esse mangá não esta disponivel para emprestimo no momento");
                                            } 
                                            else
                                            {
                                                Console.WriteLine("ERRO!!!! O Programa será fechado!!!!!!");
                                                Environment.Exit(0);
                                            }
                                            break;
                                        case 4:
                                            if (estado_manga[opcao_emprestimo - 1] == "Disponivel")
                                            {
                                                Console.WriteLine($"Você pegou {mangas[opcao_emprestimo - 1]} emprestado.");
                                                estado_manga[opcao_emprestimo - 1] = "Emprestado";
                                                manga_emprestado++;
                                                manga_disponivel--;
                                            } 
                                            else if (estado_manga[opcao_emprestimo - 1] == "Emprestado")
                                            {
                                                Console.WriteLine("Esse mangá não esta disponivel para emprestimo no momento");
                                            } 
                                            else
                                            {
                                                Console.WriteLine("ERRO!!!! O Programa será fechado!!!!!!");
                                                Environment.Exit(0);
                                            }
                                            break;
                                        case 5:
                                            if (estado_manga[opcao_emprestimo - 1] == "Disponivel")
                                            {
                                                Console.WriteLine($"Você pegou {mangas[opcao_emprestimo - 1]} emprestado.");
                                                estado_manga[opcao_emprestimo - 1] = "Emprestado";
                                                manga_emprestado++;
                                                manga_disponivel--;
                                            } 
                                            else if (estado_manga[opcao_emprestimo - 1] == "Emprestado")
                                            {
                                                Console.WriteLine("Esse mangá não esta disponivel para emprestimo no momento");
                                            } 
                                            else
                                            {
                                                Console.WriteLine("ERRO!!!! O Programa será fechado!!!!!!");
                                                Environment.Exit(0);
                                            }
                                            break;
                                        case 0:
                                            break;
                                        default:
                                            Console.WriteLine("Opção incorreta!!!!");
                                            break;
                                    }

                                    if (manga_disponivel == 0)
                                    {
                                        Console.WriteLine("Não temos mangás disponiveis, volte mais tarde.");
                                        break;
                                    }
                                } while(opcao_emprestimo != 0);
                            }
                        }
                        
                        break;
                    case 3:
                        for (int i = 0; i < mangas.Length; i++)
                        {
                            if (estado_manga[i] == "Disponivel")
                            {
                                manga_disponivel++;
                            }
                            else if (estado_manga[i] == "Emprestado")
                            {
                                manga_emprestado++;
                            }
                            else
                            {
                                Console.WriteLine("Erro!!!!");
                                erro = true;
                                break;
                            }
                        }

                        if (erro == true)
                        {
                            Console.WriteLine("O programa sera encerrado!!!!");
                            Environment.Exit(0);
                        }
                        else
                        {
                            if (manga_emprestado <= 0)
                            {
                                Console.WriteLine("Você não pegou nenhum mangá emprestado");
                            }
                            else
                            {
                                do{  
                                    for (int i = 0; i < mangas.Length; i++)
                                    {
                                        if (estado_manga[i] == "Emprestado")
                                        {
                                            numero_opcao++;

                                            Console.WriteLine($"{numero_opcao} - {mangas[i]}");

                                            opcao_emprestado[i]++;
                                        }
                                    }

                                    Console.WriteLine("0 - Sair.");

                                    Console.WriteLine("Qual mangá você quer devolver?: ");
                                    opcao_devolver = int.Parse(Console.ReadLine());

                                    if (numero_opcao >= opcao_devolver && opcao_devolver != 0)
                                    {
                                        for (int i = 0; i < mangas.Length; i++)
                                        {
                                            if (estado_manga[i] == "Emprestado")
                                            {
                                                contador++;
                                                if (contador == opcao_devolver)
                                                {
                                                    Console.WriteLine($"{mangas[i]} foi devolvido");
                                                    estado_manga[i] = "Disponivel";
                                                }
                                            }
                                        }
                                    } 
                                    else if (opcao_devolver == 0)
                                    {
                                        // não faz nada alem de ir para while.
                                    }
                                    else
                                    {
                                        Console.WriteLine("Tente Novamente");
                                    }

                                    numero_opcao = 0;
                                    contador = 0;
                                    
                                } while (opcao_devolver != 0);
                            }
                        }
                        break;
                    case 4:
                        do{
                            Console.WriteLine("Area de pesquisa(Aperte 0 para sair): ");
                            pesquisa = Console.ReadLine();
                            
                            if (pesquisa != ""){
                                for (int i = 0; i < mangas.Length; i++)
                                {
                                    if (mangas[i].ToLower().Contains(pesquisa))
                                    {
                                        Console.WriteLine($"Nome: {mangas[i]} || Estado: {estado_manga[i]}");
                                        contador++;
                                    } 
                                }

                                if (contador <= 0)
                                {
                                    Console.WriteLine("Nenhum Resultado Encontrado");
                                }

                                contador = 0;
                            } 
                            else
                            {
                                Console.WriteLine("Digite Alguma Coisa");
                            }
                        } while (pesquisa != "0");
                        break;
                    case 5:
                        for (int i = 0; i < mangas.Length; i++)
                        {
                            if (estado_manga[i] == "Disponivel")
                            {
                                manga_disponivel++;
                            }
                            else if (estado_manga[i] == "Emprestado")
                            {
                                manga_emprestado++;
                            }
                            else
                            {
                                Console.WriteLine("Erro!!!!");
                                erro = true;
                                break;
                            }
                        }

                        if (erro == true)
                        {
                            Console.WriteLine("O programa sera encerrado!!!!");
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine($"Mangás disponiveis: {(manga_disponivel / mangas.Length) * 100} % || Mangas emprestados: {(manga_emprestado / mangas.Length) * 100} %");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Volte Sempre.");
                        break;
                    default:
                        Console.WriteLine("Opção Invalida!!!!!");
                        break;
                }
            }while (opcao != 0);
        }
    }
}