using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite o texto para traduzir em baleiês:");
        string texto = Console.ReadLine();

        string textoTraduzido = TraduzirParaBaleies(texto);

        Console.WriteLine("Texto traduzido em baleiês: " + textoTraduzido);
    }

    static string TraduzirParaBaleies(string texto) {
        string textoTraduzido = "";

        for (int i = 0; i < texto.Length; i++) {
            char letra = texto[i];

            if (IsVogal(letra)) {
                textoTraduzido += letra.ToString() + letra.ToString() + letra.ToString();
            } else {
                textoTraduzido += letra;
            }
        }

        return textoTraduzido;
    }

    static bool IsVogal(char letra) {
        string vogais = "aeiouAEIOU";
        return vogais.Contains(letra);
    }
}
