using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace APICotacoes
{
    public class CotacoesDAO
    {
        private IConfiguration _configuracoes;

        public CotacoesDAO(IConfiguration config)
        {
            _configuracoes = config;
        }

        public Cotacao Obter(string idMoeda)
        {
            using (SqlConnection conexao = new SqlConnection(
                _configuracoes.GetConnectionString("BaseCotacoes")))
            {
                return conexao.QueryFirstOrDefault<Cotacao>(
                    "SELECT Sigla, NomeMoeda, UltimaCotacao, Valor " +
                    "FROM dbo.Cotacoes " +
                    "WHERE Sigla = @SiglaMoeda ",
                    new { SiglaMoeda = idMoeda }
                );
            }
        }
    }
}
