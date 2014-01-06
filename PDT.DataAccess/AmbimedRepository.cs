using Breeze.ContextProvider;
using Breeze.ContextProvider.EF6;
using Newtonsoft.Json.Linq;
using PDT.Data;
using PDT.Data.Models;
using PDT.DataAccess.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDT.DataAccess
{
    public class AmbimedRepository
    {
        private readonly EFContextProvider<AmbimedContext>
           _contextProvider = new EFContextProvider<AmbimedContext>();

        private AmbimedContext Context { get { return _contextProvider.Context; } }

        public string Metadata
        {
            get { return _contextProvider.Metadata(); }
        }

        public SaveResult SaveChanges(JObject saveBundle)
        {
            return _contextProvider.SaveChanges(saveBundle);
        }

        public IQueryable<CabecalhoTransacco> CabecalhoTransaccoes
        {
            get { return Context.CabecalhoTransaccoes; }
        }

        public IQueryable CabecalhoBrief
        {
            get
            {

                return Context.CabecalhoTransaccoes.Include("Conta").Include("DetalheTransaccoes")
                    .Include("DetalheTransaccoes.Produto").Select(x => new
                    {
                        CtTipoTran = x.CtTipoTran,
                        CtGuiaID = x.CtGuiaID,
                        DCom = x.Conta.CDesgn_Com,
                        CtDataFim = x.CtDataFim,
                        CtClienteID = x.CtClienteID,
                        CtOrigem = x.CtOrigem,
                        Servicos = x.DetalheTransaccoes.Select(y=> new { Servico = y.Produto.PrdServico }).Distinct(),
                        Produtos = x.DetalheTransaccoes.Select(y=> new { Prd = y.Produto.PrdNome }).Distinct()
                    });
            }
        }
    }
}
