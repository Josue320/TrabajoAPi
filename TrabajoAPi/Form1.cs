using AppCore.Iservices;
using Domain.Interfaces;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoAPi
{
    public partial class Form1 : Form
    {

        private IService service;
        public Form1(IService service)

        {
            this.service = service;
            InitializeComponent();
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            try
            {
                var infoClima = service.GetWeather(txtCiudad.Text);

                //pictureBox1.ImageLocation = "https://openweathermap.org/img/w/" + infoClima.weather[0].icon + ".png";
                //lblCondicion.Text = infoClima.weathers[0].main.ToString();
                lblCondicion.Text = infoClima.weathers[0].main.ToString();
                lblDetalles.Text = infoClima.weathers[0].description.ToString();
                lblAtardecer.Text = service.convertToDateTime(infoClima.sys.sunset).ToString();
                lblAmanecer.Text = service.convertToDateTime(infoClima.sys.sunrise).ToString();
                lblVelocidadViento.Text = infoClima.wind.speed.ToString();
                lblPresion.Text = infoClima.main.pressure.ToString();
                pictureBox1.ImageLocation = service.GetImageLocation(infoClima.weathers[0]);
            }
            catch(Exception)
            {
                throw;
            }

        }
    }
}
