using System.Reflection.Metadata;
using System.ComponentModel;
using System;
using System.Xml;
using Api.Data.Collections;
using Api.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;


namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class DadosCnpjController : ControllerBase
    {
        Data.MongoDB _mongoDB;
        IMongoCollection<DadosCnpj> _DadosCnpjCollection;

        public DadosCnpjController(Data.MongoDB mongoDB)
        {
            _mongoDB = mongoDB;
            _DadosCnpjCollection = _mongoDB.DB.GetCollection<DadosCnpj>(typeof(DadosCnpj).Name.ToLower());
        }

        [HttpPost]
        public ActionResult SalvarDadosCnpj([FromBody] DadosCnpjDto dto)
        {
            var DadosCnpj = new DadosCnpj (dto.SituacaoCadastral, dto.Cnpj, dto.CpfCnpj, dto.Cep, dto.CapitalSocial, dto.Situacao, dto.NomeFantasia, dto.RazaoSocial, dto.IdentificadorMatrizFilial, dto.IdentificadorDeSocio, dto.NomeSocio);
            
            _DadosCnpjCollection.InsertOne(DadosCnpj);
            
            return StatusCode(201, "DadosCnpj adicionado com sucesso");
        }

        [HttpGet]
        public ActionResult ObterDadosCnpj()
        {
           
            var DadosCnpj = _DadosCnpjCollection.Find(Builders<DadosCnpj>.Filter.Empty).ToList();
            
            return Ok(DadosCnpj);
            
        }

        
        [HttpGet("{cnpj}")]
        public ActionResult<string> Get(string cnpj)
        
        {
           var filter = Builders<DadosCnpj>.Filter.Eq(x => x.Cnpj, cnpj);

           var DadosCnpj = _DadosCnpjCollection.Find(filter).ToList();
             
           return Ok(DadosCnpj);  

        }   
                                         
                 

    }
   
}
       