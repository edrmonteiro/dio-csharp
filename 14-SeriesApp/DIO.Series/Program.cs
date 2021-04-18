using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorioSerie = new SerieRepositorio();
        static FilmeRepositorio repositorioFilme = new FilmeRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "x")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        VisualizarSeries();
                        break;

                    case "6":
                        ListarFilmes();
                        break;
                    case "7":
                        InserirFilme();
                        break;
                    case "8":
                        AtualizarFilme();
                        break;
                    case "9":
                        ExcluirFilme();
                        break;
                    case "10":
                        VisualizarFilmes();
                        break;

                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utulizar nossos serviços");
            Console.ReadLine();
        }

        private static void VisualizarSeries()
        {
            Console.WriteLine("Visualizar Série:");
            Console.Write("Digite o ID da Série que será visualizada:");
            int entradaId = int.Parse(Console.ReadLine());
            var serie = repositorioSerie.RetornaPorId(entradaId);
            Console.WriteLine(serie);
        }

        private static void ExcluirSerie()
        {
            Console.WriteLine("Excluir Série:");
            Console.Write("Digite o ID da Série que será removida:");
            int entradaId = int.Parse(Console.ReadLine());
            repositorioSerie.Excluir(entradaId);
        }

        private static void AtualizarSerie()
        {
            Console.WriteLine("Atualizar Série:");
            Console.Write("Digite o ID da Série que será atualizada:");
            int entradaId = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima ou Enter para manter:");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o ano de lançamento:");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite o Titulo da Série:");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite a Descrição da Série:");
            string entradaDescricao = Console.ReadLine();

            var serie = new Serie(id: repositorioSerie.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao
                                    );
            repositorioSerie.Atualiza(entradaId, serie);


        }
        private static void InserirSerie()
        {
            Console.WriteLine("Inserir Nova Série");
            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima:");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o ano de lançamento:");
            int entradaAno= int.Parse(Console.ReadLine());

            Console.Write("Digite o Titulo da Série:");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite a Descrição da Série:");
            string entradaDescricao = Console.ReadLine();

            var novaSerie = new Serie(  id: repositorioSerie.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao
                                    );
            repositorioSerie.Insere(novaSerie);
        }
        private static void ListarSeries()
        {
            Console.WriteLine("Listar séries");
            var lista = repositorioSerie.Lista();
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }
            foreach(var serie in lista)
            {
                var excluido = serie.retornaExcluido();
                Console.WriteLine("#ID {0} - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido? "- Excluido" : ""));
            }
        }






        private static void VisualizarFilmes()
        {
            Console.WriteLine("Visualizar Filme:");
            Console.Write("Digite o ID da Filme que será visualizada:");
            int entradaId = int.Parse(Console.ReadLine());
            var serie = repositorioFilme.RetornaPorId(entradaId);
            Console.WriteLine(serie);
        }

        private static void ExcluirFilme()
        {
            Console.WriteLine("Excluir Filme:");
            Console.Write("Digite o ID da Filme que será removida:");
            int entradaId = int.Parse(Console.ReadLine());
            repositorioFilme.Excluir(entradaId);
        }

        private static void AtualizarFilme()
        {
            Console.WriteLine("Atualizar Filme:");
            Console.Write("Digite o ID da Filme que será atualizada:");
            int entradaId = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima ou Enter para manter:");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o ano de lançamento:");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite o Titulo da Filme:");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite a Descrição da Filme:");
            string entradaDescricao = Console.ReadLine();

            var serie = new Filme(id: repositorioFilme.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao
                                    );
            repositorioFilme.Atualiza(entradaId, serie);

        }
        private static void InserirFilme()
        {
            Console.WriteLine("Inserir Nova Filme");
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.Write("Digite o gênero entre as opções acima:");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.Write("Digite o ano de lançamento:");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite o Titulo da Filme:");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite a Descrição da Filme:");
            string entradaDescricao = Console.ReadLine();

            var novoFilme = new Filme(id: repositorioFilme.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao
                                    );
            repositorioFilme.Insere(novoFilme);
        }
        private static void ListarFilmes()
        {
            Console.WriteLine("Listar filmes");
            var lista = repositorioFilme.Lista();
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum filme cadastrado.");
                return;
            }
            foreach (var filme in lista)
            {
                var excluido = filme.retornaExcluido();
                Console.WriteLine("#ID {0} - {1} {2}", filme.retornaId(), filme.retornaTitulo(), (excluido ? "- Excluido" : ""));
            }
        }





        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Series e Filmes a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Listas séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("6 - Listas filmes");
            Console.WriteLine("7 - Inserir novo filme");
            Console.WriteLine("8 - Atualizar filme");
            Console.WriteLine("9 - Excluir filme");
            Console.WriteLine("10 - Visualizar filme"); 
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine("");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
