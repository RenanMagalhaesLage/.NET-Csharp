using DesafioCelular.Models;

//IMPLEMENTADO
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia1 = new Nokia(numero:"1234",modelo:"Modelo 45", imei:"111111111",memoria: 64);
nokia1.Ligar();
nokia1.InstalarAplicativo("WhatsApp");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone1 = new Iphone(numero:"5678",modelo:"iPhone 12 S", imei:"25363636",memoria: 128);
iphone1.Ligar();
iphone1.InstalarAplicativo("Instagram");
iphone1.InstalarAplicativo("Facebook");
iphone1.ReceberLigacao();

