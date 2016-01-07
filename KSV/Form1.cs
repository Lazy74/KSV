using System;
using System.Drawing;
using System.Windows.Forms;

namespace KSV
{
    public partial class Form1 : Form
    {
        private int SizeMonitorHeight = 0;      //Вертикаль X
        private int SizeMonitorWidth = 0;       //Горизонталь Y

        public Form1()
        {
            InitializeComponent();
            //timer1.Start();       //Таймер для смены цвета фона
            timer2.Start();
            this.TopMost = true;
            this.ShowInTaskbar = false;     //Убираем значек из панели задач
            this.FormBorderStyle = FormBorderStyle.None;        //форма без стиля
            SizeMonitorHeight = SystemInformation.PrimaryMonitorSize.Height;
            SizeMonitorWidth = SystemInformation.PrimaryMonitorSize.Width;

            this.Size = new Size(250, 250);
            //MessageBox.Show(Convert.ToString(SystemInformation.PrimaryMonitorSize));        //Получение размеров экрана
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point((int)SizeMonitorHeight / 100 * 5, (int)SizeMonitorWidth / 100 * 5);       //Установка положения формы на экране
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
