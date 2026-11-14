//ye adad chahar raghami vared konid
//ta argham az akhar be aval moratab shavand
Console.Clear();
Console.Write("adad chahar raghami: ");
var adadchaharraghami=Convert.ToInt32(Console.ReadLine());
var x=adadchaharraghami%10;
var y=(adadchaharraghami/10)%10;
var z=(adadchaharraghami/100)%10;
var m=adadchaharraghami/1000;
var baraks=(x*1000)+(y*100)+(z*10)+m;
Console.WriteLine($"baraks: {baraks}");
