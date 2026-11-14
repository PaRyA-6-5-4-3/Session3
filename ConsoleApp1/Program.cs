//mikhahim ba vared kardan saat kar be hoghogh
//khales, meghdar maliyat va hoghogh daryafti
//beresim(hoghogh be dolar ast)
Console.Clear();
Console.Write("saatekar: ");
var saatekar=Convert.ToDouble(Console.ReadLine());
var hoghoghkhales=saatekar*3.5;
var maliyat=hoghoghkhales*5/100;
var hoghoghdaryafti=hoghoghkhales-maliyat;
Console.WriteLine(@$"hoghog hkhales: {hoghoghkhales},
maliyat: {maliyat}
and 
hoghogh daryafti: {hoghoghdaryafti}");




