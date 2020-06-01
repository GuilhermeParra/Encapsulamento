using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartao Cartao = new Cartao();
            Cartao.AprovarCompra();

            MasterCard master = new MasterCard();

            master.parcelas = 4;
            master.ComprarComDescontoMasterCard(35f);
        }
    }
}
