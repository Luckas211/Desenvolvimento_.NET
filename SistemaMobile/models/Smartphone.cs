namespace SistemaMobile.models
{public abstract class Smartphone
    {
        public string Numero { get; set; }
        
        // Embora o diagrama liste como private, usamos "protected"
        // para que as classes filhas possam acessá-los, o que é comum.
        // Se tivessem que ser 'private', o construtor abaixo é a única forma de definí-los.
        private string Modelo;
        private string IMEI;
        private int Memoria;

        // Construtor que será chamado pelas classes filhas
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // Métodos comuns a todos os smartphones
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Este é o método abstrato que AS FILHAS DEVEM implementar
        // TODO: Este é o método que precisa ser abstrato
        public abstract void InstalarAplicativo(string nomeApp);
    }
}