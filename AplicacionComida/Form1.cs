using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionComida
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void img_arrow1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    //Hover mouse y cosas asi del panel izquierdo
       
        private void lbl_inicio_MouseEnter(object sender, EventArgs e)
        {
            img_arrow1.Visible = true;
            lbl_inicio.BackColor = System.Drawing.Color.DarkGray;
        }
        private void lbl_inicio_MouseLeave(object sender, EventArgs e)
        {
            img_arrow1.Visible = false;
            lbl_inicio.BackColor = System.Drawing.Color.Silver;
        }

        private void lbl_food1_MouseEnter(object sender, EventArgs e)
        {
            img_arrow2.Visible = true;
            lbl_food1.BackColor = System.Drawing.Color.DarkGray;
        }

        private void lbl_food1_MouseLeave(object sender, EventArgs e)
        {
            img_arrow2.Visible = false;
            lbl_food1.BackColor = System.Drawing.Color.Silver;
        }

        private void lbl_food2_MouseEnter(object sender, EventArgs e)
        {
            img_arrow3.Visible = true;
            lbl_food2.BackColor = System.Drawing.Color.DarkGray;
        }

        private void lbl_food2_MouseLeave(object sender, EventArgs e)
        {
            img_arrow3.Visible = false;
            lbl_food2.BackColor = System.Drawing.Color.Silver;
        }

        private void lbl_food3_MouseEnter(object sender, EventArgs e)
        {
            img_arrow4.Visible = true;
            lbl_food3.BackColor = System.Drawing.Color.DarkGray;
        }

        private void lbl_food3_MouseLeave(object sender, EventArgs e)
        {
            img_arrow4.Visible = false;
            lbl_food3.BackColor = System.Drawing.Color.Silver;
        }

        private void lbl_food2_Click(object sender, EventArgs e)
        {
            inicioScene1.Visible = false;
            sangucheScene1.Visible = false;
            sopaScene1.Visible = false;
            anvorgesaview.Visible = true;
        }

        private void lbl_food1_MouseClick(object sender, MouseEventArgs e)
        {
            inicioScene1.Visible = false;
            anvorgesaview.Visible = false;
            sangucheScene1.Visible = false;
            sopaScene1.Visible = true;
        }

        private void lbl_food3_MouseClick(object sender, MouseEventArgs e)
        {
            inicioScene1.Visible = false;
            anvorgesaview.Visible = false;
            sopaScene1.Visible = false;
            sangucheScene1.Visible = true;
        }

        private void lbl_inicio_Click(object sender, EventArgs e)
        {
            anvorgesaview.Visible = false;
            sopaScene1.Visible = false;
            sangucheScene1.Visible = false;
            inicioScene1.Visible = true;
        }
    }
}
