namespace DesafioPOO.Models
{
    // Feito
    public class Nokia : Smartphone
    {

        public Nokia(string numero, string modelo, string imei, int memoria) : base (numero,modelo,imei,memoria)
        {
            Numero = numero;
            
        }

        // Feito
        public override void InstalarAplicativo(string nomeApp)
        {
          Console.WriteLine($"Aplicativo \"{nomeApp}\" instalado com sucesso no Nokia");
        }
    }
}