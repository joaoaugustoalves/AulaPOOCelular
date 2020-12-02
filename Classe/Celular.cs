using System;
namespace AulaPOOCelular.Classe
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public int tamanho;
        public bool ligado;
       

       public void ligar(bool ligado) {
            if(ligado == true){
                Console.WriteLine("O celular está ligado.");
            }else{
                Console.WriteLine("O celular está desligado.");
            }   
        }
        
        
        public void desligar(bool desligado){
            if(ligado == true){
                Console.WriteLine("O celular está ligado.");
            }else{
                Console.WriteLine("O celular está desligado.");
            }       
        }
        
        
        
        public void fazerLigacao(string fazendoLigacao){
            Console.WriteLine($"O celular está:{fazendoLigacao}");

            if(this.ligado == true){
                Console.WriteLine("O celular está ligado.");
            }else{
                Console.WriteLine("O celular está desligado.");
            }
        
        }
        
        
         public void enviarMensagem(string enviandoMensagem){
            Console.WriteLine($"O celular está:{enviandoMensagem}");
        
            if(this.ligado == true){
                Console.WriteLine("O celular está ligado.");
            }else{
                Console.WriteLine("O celular está desligado.");
            }
        
        }
    }
}