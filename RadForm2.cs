using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Primitives;

//Nombre de todos los botones que tiene este cuadro:
// Fine222 Es el boton del final, piuenso que debo hacer que desaparezca
// Dude2 Hay que hacer que desaparezca
//

namespace PruebaDecomprobaciones
{
    public partial class RadForm2 : Telerik.WinControls.UI.RadForm
    {
        public RadForm2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1111_Click(object sender, EventArgs e)
        {
            Button1111.Visible = false;
            Dude1.Visible = false;
            Dude2.Visible = true;
            //Rose1.Visible = true;
            //Rose2.Visible = true;
            //Rose3.Visible = true;
            //Rose4.Visible = true;
            Fine222.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Button1111.Visible = true;
            Dude1.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Button1111.Visible = true;
            Dude1.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
     

        private void Rose1_Click(object sender, EventArgs e)
        {

        }

        private void Fine222_Click_1(object sender, EventArgs e)
        {
            Dude2.Visible = false;
            PanelFinal.Visible = false; 
            Fine222.Visible = false;
            Rose2.Visible = true;
            Heardsss.Visible = true;
            MSGLOVE.Visible = true;
            TexImporant.Visible = true;
        }

        private void Dude2_Click(object sender, EventArgs e)
        {

        }

        private void Rose3_Click(object sender, EventArgs e)
        {

        }

        private void Rose2_Click(object sender, EventArgs e)
        {

        }

        private void Question1_Click(object sender, EventArgs e)
        {

        }
    }
}
