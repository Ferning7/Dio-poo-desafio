using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "12345", modelo: "tijolo 2", iMEI: "1211212", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "12325", modelo: "6 cameras", iMEI: "12323212", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");