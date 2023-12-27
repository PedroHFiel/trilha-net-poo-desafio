using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

System.Console.WriteLine("Smatphone Nokia:");
Smartphone Nokia = new Nokia(numero: "123456", modelo: "Modelo X", imei: "11111111111", memoria: 64);
Nokia.Ligar();
Nokia.InstalarAplicativo("Telegram");

System.Console.WriteLine("\n");

System.Console.WriteLine("Smatphone Iphone:");
Smartphone Iphone = new Iphone(numero: "654321", modelo: "Modelo Y", imei: "22222222222", memoria: 128);
Iphone.Ligar();
Iphone.InstalarAplicativo("Whatsapp");