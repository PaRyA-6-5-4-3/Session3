//ye adad chahar raghami vared konid
//ta bar ax on adado bebinid
try
{
    Console.Clear();
    Console.Write("adad chahar raghami: ");
    var adadchaharraghami = Convert.ToInt32(Console.ReadLine());
    var x = adadchaharraghami % 10;
    var y = (adadchaharraghami / 10) % 10;
    var z = (adadchaharraghami / 100) % 10;
    var m = adadchaharraghami / 1000;
    var makous = (x * 1000) + (y * 100) + (z * 10) + m;
    Console.WriteLine($"makous: {makous}");
}
catch(FormatException)
{
    Console.WriteLine("mamnon misham adad shoma 4 raghami bashe!");
}
catch(OverflowException)
{
    Console.WriteLine("in adad kheili tolanie behtare 4 ragham bashe");
}
catch
{
    Console.WriteLine("behtare bikhial shi");
}