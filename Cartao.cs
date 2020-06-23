using System;
namespace ListaDesejos
{
    public class Cartao
    {
        public string Titular { get; set; }
        public int Numero { get; set; }
        public string Bandeira { get; set; }
        public DateTime DataVencimento { get; set; }
        public int CVV { get; set; }
        public Cartao(){

        }

        public Cartao(string _titular, int _numero, string _bandeira, DateTime _dataVencimento, int _cvv){
            this.Titular = _titular;
            this.Numero = _numero;
            this.Bandeira = _bandeira;
            this.DataVencimento = _dataVencimento;
            this.CVV = _cvv;
        }
    }
}