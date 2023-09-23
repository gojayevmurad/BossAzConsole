using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BossAzConsole
{
    enum MyEnum
    {
        Murad =1,
        Anvar, 
        Rasul
    }

    public class WeatherForecast
    {
        public DateTimeOffset Date { get; set; }
        public int TemperatureCelsius { get; set; }
        public string? Summary { get; set; }
        public string? SummaryField;
        public IList<DateTimeOffset>? DatesAvailable { get; set; }
        public Dictionary<string, HighLowTemps>? TemperatureRanges { get; set; }
        public string[]? SummaryWords { get; set; }

        public override string ToString()
        {
            return $"{Date} {TemperatureCelsius} {Summary} {SummaryField} {SummaryWords?[0]}";
        }

    }

    public class HighLowTemps
    {
        public int High { get; set; }
        public int Low { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Email.SendMail("muradqocayevi20@gmail.com", "Hello");

            //Enum[] enums = { MyEnum.Murad, MyEnum.Anvar, MyEnum.Rasul };
            //Enum answer = Display.ShowWithvariants(enums);
            //App.Start();

            var weatherForecast = new WeatherForecast
            {
                Date = DateTime.Parse("2019-08-01"),
                TemperatureCelsius = 25,
                Summary = "Hot",
                SummaryField = "Hot",
                DatesAvailable = new List<DateTimeOffset>()
                    { DateTime.Parse("2019-08-01"), DateTime.Parse("2019-08-02") },
                TemperatureRanges = new Dictionary<string, HighLowTemps>
                {
                    ["Cold"] = new HighLowTemps { High = 20, Low = -10 },
                    ["Hot"] = new HighLowTemps { High = 60, Low = 20 }
                },
                SummaryWords = new[] { "Cool", "Windy", "Humid" }
            };

            


        }
    }
}