using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FECHA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Carga_Click(object sender, EventArgs e)
        {
            int Dia = 1;
            int dia = System.Convert.ToInt32(txtdia.Text);
            int Mes = 1;
            int mes = System.Convert.ToInt32(txtmes.Text);
            int Año = 1;
            int año = System.Convert.ToInt32(txtaño.Text);



            /* string ingresoDeDia = Console.ReadLine();
             dia = Int32.Parse(ingresoDeDia);
             string ingresoDeMes = Console.ReadLine();
             mes = Int32.Parse(ingresoDeMes);
             string ingresoDeAño = Console.ReadLine();
             año = Int32.Parse(ingresoDeAño);*/

            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                calculoFechaMes31Dias(dia, mes, año);
                return;
            }

            if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                calculoFechaMes30Dias(dia, mes, año);
                return;
            }

            if (dia == 1 && dia <= 28)
            {
                calculoFechaMes28Dias(dia, mes, año);
                if (mes == 2)
                {
                    if (AñoBiciesto(año))
                    {
                        if (dia == 1 || dia <= 29)
                        {
                            if (dia == 29)
                            {
                                mes = mes + 1;
                            }
                            else
                            {
                                dia = dia + 1;
                            }
                        }
                    }
                }
                return;
            }



        }

        private void calculoFechaMes31Dias(int dia, int mes, int año)
        {

            if (dia == 1 || dia <= 31)
            {
                if (dia == 31)
                {
                    dia = 1;
                    mes = mes + 1;
                }
                else
                {
                     dia = dia + 1;

                }

                switch (mes)
                {
                    case 1:
                        label1.Text = dia + " De Enero " + año;
                        break;

                    case 3:

                        label1.Text = dia + " De Marzo " + año;
                        break;

                    case 5:
                        label1.Text = dia + " De Mayo " + año;
                        break;

                    case 7:
                        label1.Text = dia + " De Julio " + año;
                        break;

                    case 8:
                        label1.Text = dia + " De Agosto " + año;
                        break;
                    case 10:
                        label1.Text = dia + " De Octubre " + año;
                        break;
                    case 12:
                        label1.Text = dia + " De Diciembre " + año;
                        break;

                }
            }
        }
        private void calculoFechaMes30Dias(int dia, int mes, int año)
        {

            if (dia == 1 && dia <= 31)
            {
                dia = dia + 1;
                
                if (dia == 31)
                {

                    dia = 1;
                    mes = mes + 1;
                }
                switch (mes)
                {
                    case 1:
                        label1.Text = dia + " De Marzo " + año;
                        break;

                    case 2:

                        label1.Text = dia + " De Abril " + año;
                        break;

                    case 4:
                        label1.Text = dia + " De Junio " + año;
                        break;
                    case 5:
                        label1.Text = dia + " De Septiembre " + año;
                        break;
                    case 6:
                        label1.Text = dia + " De Noviembre " + año;
                        break;
                }
            }
        }
        private void calculoFechaMes28Dias(int dia, int mes, int año)
        {
            if (dia == 28)
            {
                dia = dia + 1;
                //mes = mes + 1;
            }
            else
            {
                dia = dia + 1;
            }
            switch (mes)
            {
                case 1:
                    label1.Text = dia + " De Febrero " + año;

                    break;

            }
        }

        public bool AñoBiciesto(int ab)
        {
            bool dato = false;
            if (ab % 4 == 0 && (ab % 100 != 0 || ab % 400 == 0))
            {
                dato = true;
            }
            return dato;
        }

    }
}
