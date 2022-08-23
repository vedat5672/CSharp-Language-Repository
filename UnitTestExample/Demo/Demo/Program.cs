// See https://aka.ms/new-console-template for more information
using Demo;

var measurement=Bemeasurements(50);
Grouper grouper = new Grouper(5);
var group= grouper.Group(measurement);
foreach (var item in group)
{
    Console.WriteLine(item.Capacity);
    foreach (var x in item)
    {
        Console.Write(x.lowest);
        Console.WriteLine(x.highest);
    }
}





List<Measurement> Bemeasurements(int piece)
{
    var measurements = new List<Measurement>();
    for (int i = 0; i < piece; i++)
    {
        measurements.Add(new Measurement
        {
            highest = 10,
            lowest = 0
        });
    }
    return measurements;
}