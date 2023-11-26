using DesafioPOO.Models;




Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia(numero: "11914034669", imei: "23332333999", modelo: "g21", memoria: "8gb");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");


Console.WriteLine("\n");


Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone(numero: "11914034559", imei: "23301933999", modelo: "se", memoria: "128gb");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Notion");