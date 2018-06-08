using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture03
{
    public class WeatherData : EventArgs
    {
        public double Temperature;
        public double Pressure;
        public double Humidity;
        private static Random random;

        public bool Equals(WeatherData other)
        {
            return
                this.Temperature == other.Temperature &&
                this.Pressure == other.Pressure &&
                this.Humidity == other.Humidity;
        }

        public static WeatherData Generate()
        {
            if (random == null)
                random = new Random();
            WeatherData data = new WeatherData();
            data.Temperature = random.NextDouble(28, 32);
            data.Pressure = random.NextDouble(0.98, 1);
            data.Humidity = random.NextDouble(50, 90);
            return data;
        }
    }
}
