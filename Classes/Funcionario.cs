using System;
using System.Collections.Generic;

namespace FazendaUrbanaDesktop.Classes
{
    public class Funcionario
    {
        public Funcionario(int _id, string _nome, string _documento, string _telefone, string _endereco, string _dataAdm, string _dataNasc)
        {
            ID = _id;
            Nome = _nome;
            Documento = _documento;
            Telefone = _telefone;
            Endereco = _endereco;
            DataAdm = _dataAdm;
            DataNasc = _dataNasc;
        }

        public int ID { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public List<OS> OS { get; set; }
        public string DataAdm { get; set; }
        public string DataNasc { get; set; }

    }
}