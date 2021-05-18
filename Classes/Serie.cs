using System;

namespace cadSeries

{
    public class Serie : EntidadeBase
    {
        // Atributos
        private int Genero {get; set;}
        
        private string Titulo {get; set;}

        private string Descricao {get; set;}
        
        private int Ano {get; set;}

        private bool Excluido {get; set;}

        //Metodos
        public Serie(int id, Genero genero, string titulo, string descricao,int ano)
        {
            this.Id = id;
            this.Genero = (int)genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno ="";
            retorno += "Genero:"+this.Genero + Environment.NewLine;
            retorno += "Titulo:"+this.Titulo + Environment.NewLine;
            retorno += "Descrição:"+this.Descricao + Environment.NewLine;
            retorno += "Ano de Inicio:"+this.Ano;
            retorno += "Excluido: "+this.Excluido;
            return retorno; 
        }
        //construtor
        public string retornaTitulo()
        {
            return this.Titulo;
        }
        public int retornaID()
        {
            return this.Id;
        }

        public void Excluir(){
            this.Excluido = true;
        }
    }
}