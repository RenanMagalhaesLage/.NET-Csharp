namespace DesafioCelular.Models
{
    //IMPLEMENTADO

    public class Iphone : Smartphone
    {
        //IMPLEMENTADO

         public Iphone(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
            // Inicialização adicional específica do iPhone, se necessário
        }
        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no iPhone");
        }
    }
}