//mikhahim ba vared kardan saat kar be hoghogh
//khales, meghdar maliyat va hoghogh daryafti
//beresim(hoghogh be dollar ast)
try
{
    Console.Clear();
    Console.Write("saatekar: ");
    Console.ForegroundColor = ConsoleColor.Red;
    var saatekar = Convert.ToDouble(Console.ReadLine());
    var hoghoghkhales = saatekar * 3.5;
    var maliyat = hoghoghkhales * 5 / 100;
    var hoghoghdaryafti = hoghoghkhales - maliyat;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(@$"hoghog hkhales: {hoghoghkhales} dollar
    maliyat: {maliyat} dollar 
    hoghogh daryafti: {hoghoghdaryafti} dollar");
}
catch(FormatException)
{
    Console.WriteLine("lotfan adad vared kon");
}
catch(OverflowException)
{
    Console.WriteLine("in time kari kharej az tavane ye fard ast");
}
catch
{
    Console.WriteLine("😊not found😊");
}


