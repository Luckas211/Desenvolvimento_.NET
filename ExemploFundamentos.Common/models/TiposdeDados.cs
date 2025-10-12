using System;

namespace ExemploFundamentos.Common.models
{
    /// <summary>
    /// Classe que demonstra os principais tipos de dados em C#.
    /// Esta classe serve como um manual de estudo para entender os diferentes tipos primitivos e de referência disponíveis na linguagem.
    /// </summary>
    public class TiposdeDados
    {
        /// <summary>
        /// Tipo de referência para representar texto. Pode conter qualquer sequência de caracteres.
        /// Exemplo: "Lucas"
        /// </summary>
        public string? Nome { get; set; } //Representado por texto. Ex: Lucas

        /// <summary>
        /// Tipo inteiro com sinal de 32 bits. Representa números inteiros de -2.147.483.648 a 2.147.483.647.
        /// Exemplo: 27
        /// </summary>
        public int Idade { get; set; } //Representado por números inteiros sem casas decimais. Ex: 27

        /// <summary>
        /// Tipo de ponto flutuante de precisão simples (32 bits). Representa números reais com casas decimais.
        /// Faixa: ±1.5 × 10^-45 a ±3.4 × 10^38. Precisão: cerca de 7 dígitos.
        /// Exemplo: 80.5f
        /// </summary>
        public float Peso { get; set; } //Representado por números reais com casas decimais. Ex: 80.5

        /// <summary>
        /// Tipo que representa um único caractere Unicode (16 bits).
        /// Exemplo: 'M' ou 'F'
        /// </summary>
        public char Sexo { get; set; } // Representado por um caractere. Ex: M ou F

        /// <summary>
        /// Tipo de ponto flutuante de precisão dupla (64 bits). Representa números reais com casas decimais.
        /// Faixa: ±5.0 × 10^-324 a ±1.7 × 10^308. Precisão: cerca de 15-16 dígitos.
        /// Exemplo: 1.80
        /// </summary>
        public double Altura { get; set; } //Representado por números reais com casas decimais. Ex: 1.80

        /// <summary>
        /// Tipo booleano que representa valores verdadeiro ou falso.
        /// Exemplo: true ou false
        /// </summary>
        public bool Casado { get; set; } //Representado por True ou False. Ex: True

        /// <summary>
        /// Tipo de referência base que pode armazenar qualquer tipo de objeto.
        /// Pode ser usado para boxing de tipos valor.
        /// Exemplo: qualquer objeto
        /// </summary>
        public object? Objeto { get; set; } // Pode armazenar qualquer tipo de objeto.

        /// <summary>
        /// Tipo inteiro sem sinal de 8 bits. Representa valores de 0 a 255.
        /// Exemplo: 255
        /// </summary>
        public byte Byte { get; set; } // Representado por um byte sem sinal (0 a 255).

        /// <summary>
        /// Tipo decimal de alta precisão (128 bits). Ideal para cálculos financeiros.
        /// Faixa: ±1.0 × 10^-28 a ±7.9 × 10^28. Precisão: 28-29 dígitos significativos.
        /// Exemplo: 123.4567890123456789012345678m
        /// </summary>
        public decimal Decimal { get; set; } // Tipo decimal para alta precisão, usado em cálculos financeiros.

        /// <summary>
        /// Tipo inteiro com sinal de 64 bits. Representa números inteiros de -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807.
        /// Exemplo: 9223372036854775807
        /// </summary>
        public long Long { get; set; } // Tipo inteiro longo com sinal.

        /// <summary>
        /// Tipo inteiro com sinal de 16 bits. Representa números inteiros de -32.768 a 32.767.
        /// Exemplo: 32767
        /// </summary>
        public short Short { get; set; } // Tipo inteiro curto com sinal.

        /// <summary>
        /// Tipo inteiro sem sinal de 32 bits. Representa números inteiros de 0 a 4.294.967.295.
        /// Exemplo: 4294967295
        /// </summary>
        public uint UnsignedInt { get; set; } // Tipo inteiro sem sinal de 32 bits.

        /// <summary>
        /// Tipo inteiro sem sinal de 64 bits. Representa números inteiros de 0 a 18.446.744.073.709.551.615.
        /// Exemplo: 18446744073709551615
        /// </summary>
        public ulong UnsignedLong { get; set; } // Tipo inteiro longo sem sinal.

        /// <summary>
        /// Tipo inteiro sem sinal de 16 bits. Representa números inteiros de 0 a 65.535.
        /// Exemplo: 65535
        /// </summary>
        public ushort UnsignedShort { get; set; } // Tipo inteiro curto sem sinal.


        public void Chamada()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Peso: {Peso}");
            Console.WriteLine($"Sexo: {Sexo}");
            Console.WriteLine($"Altura: {Altura}");
            Console.WriteLine($"Casado: {Casado}");
            Console.WriteLine($"Objeto: {Objeto}");
            Console.WriteLine($"Byte: {Byte}");
            Console.WriteLine($"Decimal: {Decimal}");
            Console.WriteLine($"Long: {Long}");
            Console.WriteLine($"Short: {Short}");
            Console.WriteLine($"UnsignedInt: {UnsignedInt}");
            Console.WriteLine($"UnsignedLong: {UnsignedLong}");
            Console.WriteLine($"UnsignedShort: {UnsignedShort}");
        }
    }
}
