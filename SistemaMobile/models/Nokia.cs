namespace SistemaMobile.models
{
    // Nokia "é um" Smartphone
    public class Nokia : Smartphone
    {
        // TODO: Implementar o construtor que passa os dados para a classe PAI (Smartphone)
        public Nokia(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
            // O construtor da classe base (Smartphone) é chamado aqui
        }

        // TODO: Sobrescrever o método abstrato "InstalarAplicativo"
        // A palavra "override" é obrigatória
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando '{nomeApp}' na Loja Nokia...");
        }
    }
}