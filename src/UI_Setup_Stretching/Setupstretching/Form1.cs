using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Setupstretching
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //Cuando se carga el programa:
        {
            try   // Todas las funciones se implementan en un try y catch para evitar que crashee el programa ante algun error.
            {
                disableComponents(); // Desactiva los componentes como botones y cajas numericas

                //comboBoxPuerto
                string[] ports = SerialPort.GetPortNames(); // Lee los puertos que hay disponibles
                comboBoxPuerto.DataSource = ports;

                //comboBoxBaud
                string[] rates = { "9600", "38400", "57600", "115200" }; // Las velocidades disponibles
                comboBoxBaud.DataSource = rates;
                //labelInfo.Text = "";

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message); // Si capta algún error lo meustra en una MessageBox
            }

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) // Cuando se cierra el programa:
        {
            try
            {
                if (serialPort1.IsOpen) //Si el puerto está abierto
                {
                    serialPort1.Close(); // Se cierra
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void disableComponents()
        {
            //Desactiva todos los accionables           
            buttonIzq.Enabled = false;
            buttonDer.Enabled = false;
            buttonEstirar.Enabled = false;
            numericUpDownDer.Enabled = false;
            numericUpDownIzq.Enabled = false;
            numericUpDownMmestirados.Enabled = false;
            numericUpDownVvelocidad.Enabled = false;
            numericUpDownNestiramientos.Enabled = false;

        }
        private void enablecomponents()
        {
            // Activa todos los accionables
            buttonIzq.Enabled = true;
            buttonDer.Enabled = true;
            buttonIzq.Enabled = true;
            buttonDer.Enabled = true;
            buttonEstirar.Enabled = true;
            numericUpDownDer.Enabled = true;
            numericUpDownIzq.Enabled = true;
            numericUpDownMmestirados.Enabled = true;
            numericUpDownVvelocidad.Enabled = true;
            numericUpDownNestiramientos.Enabled = true;


        }

        private void buttonConectar_Click(object sender, EventArgs e) // Cuando se hace click en conectar:
        {
            try
            {
                if(!serialPort1.IsOpen) // Si el puerto no está abierto ya
                {
                    serialPort1.BaudRate = Convert.ToInt32(comboBoxBaud.Text);
                    serialPort1.PortName = comboBoxPuerto.Text;
                    serialPort1.Open(); 

                    progressBarConexion.Value = 100;
                    buttonConectar.Text = "Desconectar";
                    buttonRefrescar.Enabled = false;
                    
                    enablecomponents();
                    // Se conecta al puerto, a la velocidad especificada, carga la barra al 100% y activa los componentes
                }
                else
                {
                    // Si el puerto ya está abierto se cierra y desactiva los componentes
                    progressBarConexion.Value = 0;
                    buttonConectar.Text = "Conectar";
                    buttonRefrescar.Enabled = true;
                    serialPort1.Close();
                    disableComponents();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
    }

        private void buttonRefrescar_Click(object sender, EventArgs e) //Al pulsar el boton de refrescar
        {
            string[] ports = SerialPort.GetPortNames(); // Se actualiza la lista de puertos
            comboBoxPuerto.DataSource = ports;
        }


        private void buttonIzq_Click(object sender, EventArgs e) // Si se pulsa el botón izquierdo
        {
            try
            {
                serialPort1.WriteLine($"$I{numericUpDownIzq.Value}"); // Manda por el puerto serie el comando $I seguido del valor de mm a estirar
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void buttonDer_Click(object sender, EventArgs e) // Si se pulsa el botón derecho
        {
            try
            {
                serialPort1.WriteLine($"$D{numericUpDownDer.Value}"); // Manda por el puerto serie el comando $D seguido del valor de mm a estirar
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void numericUpDownIzq_ValueChanged(object sender, EventArgs e) // Cada vez que se cambia el valor de la numericBox
        {
            try
            {
                labelvizq.Text = numericUpDownIzq.Value + " mm"; // Se cambia el valor mostrado en la etiqueta
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


        }

        private void numericUpDownDer_ValueChanged(object sender, EventArgs e) // Cada vez que se cambia el valor de la numericBox
        {
            try
            {
                labelvder.Text = numericUpDownDer.Value + " mm"; // Se cambia el valor mostrado en la etiqueta
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void groupBoxEstiramiento_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDownNestiramientos_ValueChanged(object sender, EventArgs e) // Cada vez que se cambia el valor de la numericBox
        {
            try
            {
                labelVnestiramientos.Text = numericUpDownNestiramientos.Value + ""; // Se cambia el valor mostrado en la etiqueta
                serialPort1.WriteLine($"$A{numericUpDownNestiramientos.Value}"); // Manda por el puerto serie el comando $A seguido del valor del numero de estiramientos
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void buttonEstirar_Click(object sender, EventArgs e) // Si se pulsa el botón de estirar
        {
            try
            {
                serialPort1.WriteLine("$E");  // Manda por el puerto serie el comando $E

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void numericUpDownMmestirados_ValueChanged(object sender, EventArgs e) // Cada vez que se cambia el valor de la numericBox
        {
            try
            {
                labelVmmestirado.Text = numericUpDownMmestirados.Value + ""; // Se cambia el valor mostrado en la etiqueta
                serialPort1.WriteLine($"$B{numericUpDownMmestirados.Value}"); // Manda por el puerto serie el comando $A seguido del valor de mm a estirar
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }
        
        private void numericUpDownVvelocidad_ValueChanged(object sender, EventArgs e) // Cada vez que se cambia el valor de la numericBox
        {
            try
            {
                labelVvelocidad.Text = numericUpDownVvelocidad.Value + ""; // Se cambia el valor mostrado en la etiqueta
                serialPort1.WriteLine($"$C{numericUpDownVvelocidad.Value}"); // Manda por el puerto serie el comando $C seguido del valor vel
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

    }


}




