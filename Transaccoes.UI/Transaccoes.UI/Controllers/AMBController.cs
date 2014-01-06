using System.Linq;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using Breeze.ContextProvider;
using Breeze.WebApi2;
using PDT.DataAccess;
using PDT.Data.Models;
using System.Collections.Generic;
using System.Collections;
using PDT.Data;

namespace CC.Web.Controllers
{
    [BreezeController]
    public class AMBController : ApiController
    {
        // Todo: inject via an interface rather than "new" the concrete class
        readonly AmbimedRepository _repository = new AmbimedRepository();

        [HttpGet]
        public string Metadata()
        {
            return _repository.Metadata;
        }

        [HttpPost]
        public SaveResult SaveChanges(JObject saveBundle)
        {
            return _repository.SaveChanges(saveBundle);
        }

        [HttpGet]
        public IQueryable<CabecalhoTransacco> CabecalhoTransaccoes()
        {
            return _repository.CabecalhoTransaccoes;
        }

        [HttpGet]
        public IQueryable CabecalhoBrief()
        {
            return _repository.CabecalhoBrief;
        }
    }
}