using DesafioPOO.Models;

// Feito
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero:"123456",modelo:"Modelo 1",imei:"11111111", memoria: 128);
nokia.Ligar(); 
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("---------------------------------");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero:"24689",modelo:"Modelo 2",imei:"2222222", memoria: 64);
iphone.Ligar(); 
iphone.InstalarAplicativo("Uber");