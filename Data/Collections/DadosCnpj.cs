using System;

namespace Api.Data.Collections
{
    public class DadosCnpj
    {

     public DadosCnpj(string situacaoCadastral, string cnpj, string cpfCnpj, string cep, string capitalSocial, string situacao, string nomeFantasia, string razaoSocial, string identificadorMatrizFilial, string identificadorDeSocio, string nomeSocio)
        {            
            this.Cnpj = cnpj;
            this.IdentificadorMatrizFilial = identificadorMatrizFilial;
            this.RazaoSocial = razaoSocial;
            this.NomeFantasia = nomeFantasia;
            this.CapitalSocial = capitalSocial;
            this.Situacao = situacao;
            this.SituacaoCadastral = situacaoCadastral;
            this.Cep = cep;
            this.IdentificadorDeSocio = identificadorDeSocio;
            this.NomeSocio = nomeSocio;
            this.CpfCnpj = cpfCnpj;                         
               
        }            
           
        
        public string Cnpj { get; set; }
        public string IdentificadorMatrizFilial { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CapitalSocial { get; set; }
        public string Situacao { get; set; }
        public string SituacaoCadastral { get; set; }
        public string Cep { get; set; }
        public string IdentificadorDeSocio { get; set; }
        public string NomeSocio { get; set; }
        public string CpfCnpj { get; set; }     
            
    }
}