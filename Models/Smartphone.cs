namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get;}
        public string IMEI { get; }    
        public int Memoria { get; }    

        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        // Implementado
        public Smartphone(string numero, string modelo, string imei, int memoria )
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;            
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine($"Ligando de {Modelo}...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"{Modelo} Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}   