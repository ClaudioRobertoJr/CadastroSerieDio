namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        //Atributos
        private Genero Genero {get; set;}

        private string Titulo {get; set;}

        private string Descricao {get; set;}

        private int Ano {get; set;}

        private bool Excluido{get; set;} 

        //Metodos

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + System.Environment.NewLine;//Environment pega de acordo com o SO uma nova linha pra nao precisar saber 
            retorno += "Titulo: " + this.Titulo + System.Environment.NewLine;// se é /n ou /p
            retorno += "Descrição: " + this.Descricao + System.Environment.NewLine;
            retorno += "Ano de Inicio: "+ this.Ano + System.Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;

            return retorno;

        }
        public string RetornaTitulo(){
            return this.Titulo;
        }
        public int RetornaId(){
            return this.Id;
        }
         public bool RetornaExcluido(){
            return this.Excluido;
        }

        public void Excluir(){
            this.Excluido = true;

        }

    }
}