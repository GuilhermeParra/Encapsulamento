using System;

namespace Encapsulamento
{
    public class Cartao
    {
         // propriedades = "prop"//
        public string numero {get; set;} //get -> conjunto de leitura -> escrita da variável//
        public string bandeira {get; set;}
        public string token {get;set;}
         //variável protegida, podendo manipular nos métodos//
        protected string cvv {get; set;}

        // token de login - acesso ao login e expira conforme o tempo //
        // private para não ter alterações //
        public void AprovarCompra(){
            //numero = numero+4343423;//
            Console.WriteLine("Compra aprovada");
        }
        private bool ValidarToken(){
            if(token != null){
                return true;
            }
            return false;
        }
        protected bool ValidarCompra(){
            return true;
        }

    }
}