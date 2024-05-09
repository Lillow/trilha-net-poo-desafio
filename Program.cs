using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia =new Nokia(numero: "123456", modelo: "Modelo 1", imei: "1312312312", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine();

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "1524234", modelo: "Modelo 12", imei: "12313123122", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");