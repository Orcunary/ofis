using SQLite;
namespace ofis.Data;
public class WeatherForecast
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    public string Unvan { get; set; }
    public bool Bordro { get; set; }
    public bool Kdv { get; set; }
    public bool Muhtasar { get; set; }
    public bool Odemeler { get; set; }
    public bool Gecici { get; set; }
    public bool Yillik { get; set; }
   
}