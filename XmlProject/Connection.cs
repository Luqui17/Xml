using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace XmlProject
{
    class Connection
    {
        public const string NOME_DA_BASE = "Notas_Fiscais";
       

        public const string STRING_DE_CONEXAO = "mongodb://localhost:27017";

        private static readonly IMongoClient _cliente;
        private static readonly IMongoDatabase _BaseDeDados;
        
        static Connection()
        {
            _cliente = new MongoClient(STRING_DE_CONEXAO);
            _BaseDeDados = _cliente.GetDatabase(NOME_DA_BASE);
        }
        public IMongoClient Client
        {
            get { return _cliente; }
        }
        public IMongoCollection<ModelXml> Nf_e
        {
            get { return _BaseDeDados.GetCollection<ModelXml>("Nf_e"); }
        }
        public IMongoCollection<ModelXml> Ct_e
        {
            get { return _BaseDeDados.GetCollection<ModelXml>("Ct_e"); }
        }
        public IMongoCollection<ModelXml> Nfc_E
        {
            get { return _BaseDeDados.GetCollection<ModelXml>("Nfc_e"); }
        }
        public IMongoCollection<ModelXml> SAT
        {
            get { return _BaseDeDados.GetCollection<ModelXml>("SAT"); }
        }
    }
}
