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

            this.ShowInTaskbar = false;     //Убираем значек из панели задач
            this.FormBorderStyle = FormBorderStyle.None;        //форма без стиля
            SizeMonitorHeight = SystemInformation.PrimaryMonitorSize.Height - 250;
            SizeMonitorWidth = SystemInformation.PrimaryMonitorSize.Width - 250;

            //Устанавливаем интервалы таймеров
            timer1.Interval = 230;
            timerClosing.Interval = 5000;
            timerTextColor.Interval = 250;

            label1.Font = new Font(label1.Font.Name, 15, FontStyle.Bold);   //Стиль текста
            label1.MaximumSize = new Size(200,200);     //Размер Label для переноса строк
            label1.Text = "Какой-то очень важный текст!";

            this.Size = new Size(250, 250);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point((int)SizeMonitorWidth / 100 * 90, (int)SizeMonitorHeight / 100 * 5);       //Установка положения формы на экране (X,Y)
            timer1.Start();             //Таймер для смены цвета фона
            timerClosing.Start();       //Таймер закрытия окна
            timerTextColor.Start();     //Таймер для смены цвета текста
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.BackColor == System.Drawing.Color.AliceBlue)
            {
                this.BackColor = Color.Khaki;
            }
            else
            {
                this.BackColor = System.Drawing.Color.AliceBlue;
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void timerTextColor_Tick(object sender, EventArgs e)
        {
            if (label1.ForeColor == Color.DarkBlue)
            {
                label1.ForeColor = Color.DarkRed;
            }
            else
            {
                label1.ForeColor = Color.DarkBlue;
            }
        }

        private void timerClosing_Tick(object sender, EventArgs e)
        {
            //Закрытие приложения
            Application.Exit();
        }
    }
}
