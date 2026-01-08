using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Smartphone iphone = new Iphone(
            numero: "49999999999",
            modelo: "iPhone 14",
            imei: "123456789",
            memoria: 128
        );

        Smartphone nokia = new Nokia(
            numero: "49888888888",
            modelo: "Nokia 1",
            imei: "987654321",
            memoria: 32
        );

        iphone.Ligar();
        iphone.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Snake");
    }
}