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
    public partial class Form1 : Form, IObserver
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Render(object sender, EventArgs e)
        {
            this.temperatureLabel.Text = ((WeatherData)e).Temperature.ToString();

        }
    }
}
