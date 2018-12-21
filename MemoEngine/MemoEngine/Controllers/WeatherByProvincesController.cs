using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MemoEngine.Controllers
{
    public class WeatherByProvincesController : ApiController
    {
        [HttpGet]
        public IEnumerable<Weather> Get(string locationName)
        {
            List<Weather> weathers = new List<Weather>();

            weathers.Add(new Weather { Num = 1, Location = "서울", Cloud = 1234 });
            weathers.Add(new Weather { Num = 2, Location = "서울", Cloud = 2345 });
            weathers.Add(new Weather { Num = 3, Location = "서울", Cloud = 3456 });
            weathers.Add(new Weather { Num = 1, Location = "부산", Cloud = 3456 });
            weathers.Add(new Weather { Num = 2, Location = "부산", Cloud = 4567 });

            return weathers.Where(w => w.Location == locationName).ToList(); 
        }
    }

    public class Weather
    {
        public int Num { get; set; }
        public string Location { get; set; }
        public float Cloud { get; set; }
    }
}
