using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture03
{
    public partial class WeatherStation : Form, IObservable, IObserver
    {

        WeatherData currentData;
        List<IObserver> observers;

        public WeatherStation()
        {
            InitializeComponent();
            observers = new List<IObserver>();
            currentData = WeatherData.Generate();
            Register(this);
            Render(this, this.currentData);
        }

        public void Notify()
        {
            foreach (var o in observers)
                o.Render(this, this.currentData);
        }

        public void Register(IObserver o)
        {
            observers.Add(o);
        }

        public void Remove(IObserver o)
        {
            observers.Remove(o);
        }

        public void Render(object sender, EventArgs e)
        {
            this.temperatureLabel.Text = this.currentData.Temperature.ToString();
        }

        private void dataGenerator_Tick(object sender, EventArgs e)
        {
            WeatherData data = WeatherData.Generate();
            if (!data.Equals(currentData))
            {
                this.currentData = data;
                Notify();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            dataGenerator.Enabled = !dataGenerator.Enabled;
        }
    }
}
