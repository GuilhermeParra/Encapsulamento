namespace Encapsulamento
{
    public class MasterCard : Cartao
    {
        public int parcelas {get; set;}
        public void ComprarComDescontoMasterCard(float desconto){
            // Ultilizando o encapsulamento com assinatura protegida //
            cvv  =  "564";
            System.Console . WriteLine ( $"Compra realizada com {parcelas} parcelas e R${desconto} de desconto." );}
         
    }
}