using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.IO.Ports;
using System.IO;

namespace sw_Sof_Laboratorio
{
    public partial class sw_Sof_Laboratorio : ServiceBase
    {
        private StreamWriter twLog = File.AppendText("C:\\LogDatos.txt");

        public sw_Sof_Laboratorio()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            mtdEscuchaPuerto();
        }

        protected override void OnStop()
        {
            twLog.Write("\r\nStop Services.");
        }

        #region Métodos
        private static void mtdEscuchaPuerto()
        {
            SerialPort srlPort = new SerialPort("COM3");

            srlPort.BaudRate = 9600;
            srlPort.Parity = Parity.None;
            srlPort.StopBits = StopBits.One;
            srlPort.DataBits = 8;
            srlPort.Handshake = Handshake.None;
            srlPort.RtsEnable = true;

            srlPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            srlPort.Open();
            srlPort.Close();
        }

        private static void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            StreamWriter twLog = File.AppendText("C:\\LogDatos.txt");

            string indata = sp.ReadExisting();
            twLog.Write("\r\nInicio Datos: ");
            twLog.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                DateTime.Now.ToLongDateString());
            twLog.WriteLine(indata);
            twLog.WriteLine("-------------------------------");
        }
        #endregion

    }
}
