using System;

namespace cadSeries
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario - ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (OpcaoUsuario)
                {
                    case "1":
                        ListaSeries();
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
                        VisualizarSerie();
                    break;
                    case "C":
                        Console.Clear();
                    break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }            
        }

        private static void  ListaSeries(){
            Console.WriteLine("Listar series");
            var lista = SerieRepositorio.Lista();

            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma Serie cadastrada");
                return;
            }

            foreach (var serie in lista)
            {
                Console.WriteLine("#ID {0}: - {1}", serie.retornaID() , serie.retornaTitulo());
            }
        }

        private static void InserirSerie(){
            Console.WriteLine("Inserir nova serie");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero),i));
            }
            Console.Write("Digite o genero das opçoes acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o titulo da Serie: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("ano da Serie: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Digite a Descricao da Serie: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
            repositorio.Insere(novaSerie);        
        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Series a Seu dispor");
            Console.WriteLine("informe a opção desejada");

            Console.WriteLine("1-Lista Series");
            Console.WriteLine("2-Insere nova Serie");
            Console.WriteLine("3-Atualizar Serie");
            Console.WriteLine("4-Excluir Serie");
            Console.WriteLine("5-Visualizar Serie");
            Console.WriteLine("C-Limpar");
            Console.WriteLine("X-Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
