using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pid
{
    public partial class Diseño : Form
    {
        int[] datos = new int[4];
        int SetPointReal = 35;
        double KiReal = 0.20;
        double KdReal = 5;
        double KpReal = 5;
        byte[] Enviar = new byte[1];
        bool Bandera = false;
        double integral = 0;
        //double t=152;
        double tReal = 1;
        double tempNueva;
        int indice;
        double derivada = 0;
        double Error=0;
        double errorant = 0;
        public Diseño()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtVelocidad_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PuertoSerie.PortName = txtSerie.Text;
            PuertoSerie.BaudRate = Convert.ToInt32(txtVelocidad.Text);
            PuertoSerie.Open();
            btnAbrir.Enabled = false;
            Verifica.Enabled = true;
            txtError.Enabled = true;
            MuestraDatos.Enabled = true;
            btnActivar.Enabled = true;
            Ki.Enabled = true;
            Kd.Enabled = true;
            Kp.Enabled = true;
            SetPoint.Enabled = true;
            Fre.Enabled = true;
            txtIntegral.Enabled = true;
            txtDerivada.Enabled = true;
            //7 button1.Enabled = true;
            // DatoEnviar.Enabled = true;
            txtPotencia.Enabled = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //PuertoSerie.PortName = txtSerie.Text;
            PuertoSerie.Close();
            btnAbrir.Enabled = true;
            Verifica.Enabled = false;
            txtError.Enabled = false;
            MuestraDatos.Enabled = false;
            btnActivar.Enabled = false;
            Ki.Enabled = false;
            Kp.Enabled = false;
            Kd.Enabled = false; 
            SetPoint.Enabled = false;
            //button1.Enabled = false;
            //DatoEnviar.Enabled = false;
            txtPotencia.Enabled = false;
            Fre.Enabled = false;
            txtIntegral.Enabled = false;
            txtDerivada.Enabled = false;
        }

        private void SetPoint_ValueChanged(object sender, EventArgs e)
        {
            SetPointReal = Convert.ToInt32(SetPoint.Value);
        }

        private void Ki_ValueChanged(object sender, EventArgs e)
        {
            KiReal = Convert.ToDouble(Ki.Value);
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            switch (Bandera)
            {
                case true:
                    Bandera = false;
                    btnActivar.Text = "Activar";
                    MuestraDatos.Enabled = true;
                    txtIntegral.Text = "00000000";



                    break;
                case false:
                    Bandera = true;
                    btnActivar.Text = "Desactivar";
                    txtIntegral.Text = "000000000";
                    break;
            }
        }

        private void Fre_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = Fre.SelectedIndex;

            switch (indice)
            {
                case 0:
                    Enviar[0] = 150;
                    tReal = 4;
                    break;
                case 1:
                    Enviar[0] = 151;
                    tReal = 2;
                    break;
                case 2:
                    Enviar[0] = 152;
                    tReal = 1;
                    break;
                case 3:
                    Enviar[0] = 153;
                    tReal = 0.2;
                    break;
                case 4:
                    Enviar[0] = 154;
                    tReal = 0.1;
                    break;
            }
            PuertoSerie.Write(Enviar, 0, 1);
        }

        private void Verifica_Tick(object sender, EventArgs e)
        {
            double temperatura;
            //double Error;
            byte[] Control = new byte[1];
            int control;
            double potencia=0;
            double MaxIntegral=100/KiReal;
            double MinIntegral=-MaxIntegral;
            double VariableControl;
           
           
           //int periodo = 2;
            
            // double Set; 

            while (PuertoSerie.BytesToRead > 0)//while
            {
                datos[0] = PuertoSerie.ReadByte();

                if (datos[3] == 255 && datos[2] == 255)
                {
                    //double Setfinal = Convert.ToDouble(SetPointReal);
                    temperatura = (datos[0] * 256) + datos[1];
                    temperatura = temperatura / 10;

                    //  if (temperatura>100)
                   // {
                    //  temperatura = tempNueva;
                    //}
                    //tempNueva = temperatura;
                    if (temperatura<110)
                    {
                   errorant = Error;
                   MuestraDatos.Text = temperatura.ToString() + "°C";
                   Error = SetPointReal - temperatura;
                   txtError.Text = Error.ToString();

                         if (Bandera == true)
                         {
                        //  control = Convert.ToInt32(KiReal * Error);
                        // VariableControl = temperatura;
                        // Error = SetPointReal - temperatura;

                       // Error = errorant;
                        integral = (tReal * Error) + integral;

                        if (integral > MaxIntegral)
                        {
                            integral = MaxIntegral;

                        }
                        if (integral < MinIntegral)
                        {
                            integral = MinIntegral;

                        }





                        derivada = (Error - errorant) / tReal;
                        if (derivada > (100 / KdReal))
                        {
                            derivada = 100 / KdReal;
                        }
                        if (derivada < (-100 / KdReal))
                        {
                            derivada = -100 / KdReal;
                        }
                       
                        control = Convert.ToInt32(KpReal*Error+KiReal*integral+KdReal*derivada);
                        if (control > 100)
                        {
                            
                            control = 100;
                            
                        }
                        if (control < 0)
                        {
                            control = 0;
                           
                        }
                        errorant = Error;

                    }

                    else
                    {
                        control = 0;

                    }
                 //   txtError.Text = Error.ToString();
                    txtIntegral.Text = integral.ToString();
                    txtPotencia.Text = control.ToString();
                    txtDerivada.Text = derivada.ToString();
                    Enviar[0] = Convert.ToByte(control);
                    PuertoSerie.Write(Enviar, 0, 1);
                  
                    }
                  


                   


                }

                datos[3] = datos[2];
                datos[2] = datos[1];
                datos[1] = datos[0];





            }
        }

        private void Kd_ValueChanged(object sender, EventArgs e)
        {
            KdReal = Convert.ToDouble(Kd.Value);
        }

        private void Kp_ValueChanged(object sender, EventArgs e)
        {
            KpReal = Convert.ToDouble(Kp.Value);
        }

        private void txtIntegral_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSerie_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MuestraDatos_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtError_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtPotencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtVelocidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtDerivada_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
