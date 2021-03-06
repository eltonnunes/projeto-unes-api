using System.Collections.Generic;

namespace ApiUnes.Models.Object
{
    public class Retorno
    {
        private List<dynamic> registros;

        public List<dynamic> Registros
        {
            get { return registros; }
            set { registros = value; }
        }

        private int totalDeRegistros;

        public int TotalDeRegistros
        {
            get { return totalDeRegistros; }
            set { totalDeRegistros = value; }
        }

        private int itensPorPagina;

        public int ItensPorPagina
        {
            get { return itensPorPagina; }
            set { itensPorPagina = value; }
        }

        private int paginaAtual;

        public int PaginaAtual
        {
            get { return paginaAtual; }
            set { paginaAtual = value; }
        }

        private Dictionary<string, object> totais;

        public Dictionary<string, object> Totais
        {
            get { return totais; }
            set { totais = value; }
        }


        private bool token;

        public bool Token
        {
            get { return token; }
            set { token = value; }
        }
    }
}