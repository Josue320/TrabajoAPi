using AppCore.Iservices;
using AppCore.Service;
using Autofac;
using Domain.Interfaces;
using Infraestructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoAPi
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var builder = new ContainerBuilder();
            builder.RegisterType<JsonConsultaRepository>().As<IConsulta>();
            builder.RegisterType<ConsultaService>().As<IService>();
            var container = builder.Build();
           
          
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(container.Resolve<IService>()));
         
        }
    }
}
