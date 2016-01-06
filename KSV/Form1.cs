using System;
using System.Drawing;
using System.Windows.Forms;

namespace KSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
            this.TopMost = true;

            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(2000, 2000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.BackColor == System.Drawing.Color.BlueViolet)
            {
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = System.Drawing.Color.BlueViolet;
            }
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //Закрытие приложения
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }
    }
}
