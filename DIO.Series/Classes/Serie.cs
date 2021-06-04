using System;

namespace DIO.Series
{
    public class Serie :EntidadeBase
    {
        public Serie(Genero genero, string titulo, string descricao, int ano, bool excluido)
        {
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }

        private Genero  Genero { get; set; }     
        private string Titulo { get; set; }  
        private string Descricao { get; set; }   
        private int Ano { get; set; }
        private bool Excluido { get; set; }


        public override string ToString()
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
			return retorno;
		}
        public String retornarTitulo()
        {
            return this.Titulo;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }


        public void excluir()
        {
            this.Excluido = true;
        }

    }

    
}