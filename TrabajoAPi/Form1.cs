using AppCore.Iservices;
using Domain.Interfaces;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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



        private void btnObtener_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtCiudad.Text))
                {
                    MessageBox.Show("El campo no puede estar vacio");
                }
                else
                {
                    var infoClima = service.GetWeather(txtCiudad.Text);

                //pictureBox1.ImageLocation = "https://openweathermap.org/img/w/" + infoClima.weather[0].icon + ".png";
                label4.Text = infoClima.weather[0].main.ToString();
                lblCondicion.Text = infoClima.weather[0].main;
                lblDetalles.Text = infoClima.weather[0].description.ToString();
                label2.Text = infoClima.sys.country.ToString();
                label3.Text = infoClima.main.humidity.ToString();
                label9.Text = service.convertToDateTime(infoClima.sys.sunset).ToString();
                label1.Text = service.convertToDateTime(infoClima.sys.sunrise).ToString();
                label10.Text = infoClima.wind.speed.ToString();
                label8.Text = infoClima.main.pressure.ToString();
                lblTemMa.Text = infoClima.main.temp_max.ToString();
                LblTempMi.Text = infoClima.main.temp_min.ToString();
                lblTemperatura.Text = infoClima.main.temp.ToString();
                label3.Text = infoClima.main.humidity.ToString();
                label6.Text = txtCiudad.Text;
                pictureBox1.ImageLocation = service.GetImageLocation(infoClima.weather[0]);
                }
            }
            catch (WebException)
            {

                MessageBox.Show("La ciudad no existe");
            }

              

            

            
            //catch (WebException)
            //{
            //    Form2 obj = new Form2();

            //    obj.Show();

            //}
            txtCiudad.Text = null;
        }
    }
}
