using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();
            
            while (opcaoUsuario.ToUpper() != "X" )
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        AtualizaSerie();
                        break;
                    case "4":
                        ExcluiSerie();
                        break;
                    case "5":
                        VisualizarSerie();
                        break;    
                    case "6":
                        VisualizarSerieExcluido();
                        break;                     
                    case "C":
                        Console.Clear();
                        break;
                        
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
                
            }
            Console.WriteLine("Obrigado");
            Console.ReadLine();
        }
        private static void ListarSeries(){

            Console.WriteLine("Listar series");

            var lista = repositorio.Lista();

            if(lista.Count == 0){
                Console.WriteLine("Nenhuma serie cadastrada");
                return;
            }
            foreach( var serie in lista){
                if(serie.RetornaExcluido() == false){
                Console.WriteLine("#ID {0}: - {1}", serie.RetornaId(), serie.RetornaTitulo());
                }
            }
        }
        private static void InserirSerie(){
            Console.WriteLine("Inserir uma nova Serie");


            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero),i));
            }
            Console.Write("Digite o genero entre as opcao acima:");
            int entradaGenero = int.Parse(Console.ReadLine());
            Console.Write("Digite o Titulo da Serie: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digite o Ano de Inicio da Serie: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.Write("Diite a Descricao da Serie: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
            repositorio.Insere(novaSerie);

        }
        private static void AtualizaSerie(){
            Console.WriteLine("Digite o id da serie");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero),i));
            }
            Console.WriteLine("Digite o Genero entre as opções acima");
            int entradaGenero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Titulo da Serie");
            string entradaTitulo = Console.ReadLine();

            
            Console.WriteLine("Digite o Ano de Inicio da Serie");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Descricao da Serie");
            string entradaDescricao = Console.ReadLine();

            Serie atualizaSerie = new Serie(id: indiceSerie,
                                            genero: (Genero)entradaGenero,
                                            titulo: entradaTitulo,
                                            ano: entradaAno,
                                            descricao: entradaDescricao);

            repositorio.Atualiza(indiceSerie, atualizaSerie);

        }
        public static void ExcluiSerie(){

            Console.WriteLine("Digite o id da serie a ser excluida:");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceSerie);
            Console.WriteLine(serie);

            Console.WriteLine(" Deseja Excluir a Serie acima 1-Confirmar 2-Cancelar ");
            int n = int.Parse(Console.ReadLine());

            if(n == 1){
                repositorio.Exclui(indiceSerie);
            }
        }

        private static void VisualizarSerie(){
            Console.WriteLine("Digite o id da serie que deseja vizualizar");
            int indiceSerie = int.Parse(Console.ReadLine());

            var serie = repositorio.RetornaPorId(indiceSerie);

            Console.WriteLine(serie);

        }
        private static void VisualizarSerieExcluido(){
            Console.WriteLine("Series Excluidas: ");
            
            var lista = repositorio.Lista();

            if(lista.Count == 0){
                Console.WriteLine("Nenhuma serie excluida");
                return;
            }
            foreach( var serie in lista){
                if(serie.RetornaExcluido() == true){
                Console.WriteLine("#ID {0}: - {1}", serie.RetornaId(), serie.RetornaTitulo());
                }
            }

        }
        public static string ObterOpcaoUsuario(){

           Console.WriteLine();
           Console.WriteLine("DIO Series a seu dispor");
           Console.WriteLine("Informe a opcao desejada: ");

           Console.WriteLine("1- Listar series");
           Console.WriteLine("2- Inserir nova serie");
           Console.WriteLine("3- Atualizar Serie");
           Console.WriteLine("4- Excluir serie");
           Console.WriteLine("5- Visualizar serie");
           Console.WriteLine("6- Limpar tela");
           Console.WriteLine("7- Sair");
           Console.WriteLine();

           string   opcaoUsuario = Console.ReadLine().ToUpper();
           Console.WriteLine();
           return opcaoUsuario;
        }
    }
}
