// Localização: /Program.cs

// Importa o namespace onde nossas classes estão
using SistemaMobile.models;

Console.WriteLine("===== Teste Smartphone Nokia =====");

// Criamos uma variável do tipo Smartphone, mas instanciamos um Nokia
// Isso é polimorfismo!
Smartphone nokia = new Nokia(numero: "91234-5678", modelo: "Nokia G11", imei: "111111111", memoria: 64);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");


Console.WriteLine("\n===== Teste Smartphone iPhone =====");

// Criamos uma variável do tipo Smartphone, mas instanciamos um Iphone
Smartphone iphone = new Iphone(numero: "98765-4321", modelo: "iPhone 15", imei: "222222222", memoria: 128);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

// A linha abaixo daria um ERRO, provando que a Regra 1 funciona:
// "Não é possível criar uma instância da classe ou interface abstrata 'Smartphone'"
// Smartphone s = new Smartphone();