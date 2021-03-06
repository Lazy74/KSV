﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace KSV
{
    public partial class Form1 : Form
    {
        private int SizeMonitorHeight = 0;      //Вертикаль X
        private int SizeMonitorWidth = 0;       //Горизонталь Y
        string[] MsText = new string[20];
        string[] Url = new string[20];
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();

            Url[0] = "http://home.passion.ru/tsvetovodstvo/sekrety-uspekha/kak-pravilno-polivat-komnatnye-rasteniya.htm";
            Url[1] = "http://www.gardena.com/ru/garden-life/garden-magazine/20394/";
            Url[2] = "http://orhide.ru/?p=2578";
            Url[3] = "http://iplants.ru/vrezim.htm";
            Url[4] = "http://www.flowersweb.info/care/watering.php";
            Url[5] = "http://tolko-poleznoe.ru/pochemu-vyanut-domashnie-cvety.html";
            Url[6] = "http://www.wild-mistress.ru/wm/wm.nsf/publicall/1631522_komnatnye_rasteniya_zimoy";
            Url[7] = "http://thewom.ru/dom-semya/uxod-za-komnatnymi-cvetami/";
            Url[8] = "http://ivona.bigmir.net/house/houseplants/335758-15-oshibok-uhoda-za-komnatnymi-rastenijami";
            Url[9] = "http://arc4life.ru/%D0%BE%D1%82%D1%87%D0%B5%D0%B3%D0%BE-%D0%B2%D1%8F%D0%BD%D1%83%D1%82-%D1%86%D0%B2%D0%B5%D1%82%D1%8B-%D0%B2-%D0%B4%D0%BE%D0%BC%D0%B5/";
            Url[10] = "http://floristics.info/ru/stati/1382-komnatnyj-balzamin.html";

            MsText[0] = "Ту-ру-ту-тут-ту-ру! Ксения, мне кажется, настало время поливки цветов!";
            MsText[1] = "Цветы сами не польются!\rСрочно бросай все и полей цветы";
            MsText[2] = "Если польешь все цветочки, то будет тебе счастье";
            MsText[3] = "Нельзя не полить цветочки! Они могут погибнуть и приходить тебе в страшных снах";
            MsText[4] = "Вчера ты отдыхала, сегодня настало время полить цветы";
            MsText[5] = "Великие дела подождут, а пока полей цветочки";
            MsText[6] = "Дисциплина — это решение делать то, чего очень не хочется делать, например полить цветы5";
            MsText[7] = "В жизни каждого человека есть два самых важных дня: первый — это когда он родился, а второй — когда нужно полить цветы";
            MsText[8] = "Одержать сто побед в ста битвах - это не подвиг! подвиг - встать и полить цветы";
            MsText[9] = "ильный человек - это не тот, у которого все хорошо, а тот кто встал и полил цветы";
            MsText[11] = "Тут Будет очень важный текст после которого ты точно встанешь и пойдешь поливать цветочки";

            //Form1
            this.ShowInTaskbar = false;     //Убираем значек из панели задач
            this.FormBorderStyle = FormBorderStyle.None;        //форма без стиля
            SizeMonitorHeight = SystemInformation.PrimaryMonitorSize.Height - 250;
            SizeMonitorWidth = SystemInformation.PrimaryMonitorSize.Width - 250;
            this.Size = new Size(270, 200);
            this.StartPosition = FormStartPosition.CenterScreen;        //Начальное положение формы на экране

            //Устанавливаем интервалы таймеров
            timer1.Interval = 130;
            timerClosing.Interval = 5000;
            timerTextColor.Interval = 250;
            timerPosition.Interval = 20000;

            //label1
            label1.Font = new Font(label1.Font.Name, 12, FontStyle.Bold);   //Стиль текста
            label1.MaximumSize = new Size(270, 180);     //Размер Label для переноса строк
            label1.Text = "L1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Width = this.Width;
            //label1.BackColor = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();             //Таймер для смены цвета фона
            timerClosing.Start();       //Таймер закрытия окна
            timerTextColor.Start();     //Таймер для смены цвета текста
            timerPosition.Start();      //Таймер для смены положения
            //this.Opacity = .100;
            System.Diagnostics.Process.Start(Url[rnd.Next(0,10)]);     //Переход по ссылке
            //label1.Text = MsText[rnd.Next(0, 9)];
            label1.Text = MsText[11];
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

        private void timerPosition_Tick(object sender, EventArgs e)
        {
            //Положение формы по истечению таймера
            this.Location = new Point((int)SizeMonitorWidth / 100 * 90, (int)SizeMonitorHeight / 100 * 5);       //Установка положения формы на экране (X,Y)
            //изменение времени таймера цвета фона
            timer1.Interval = 230;
            //Изменение прозрачности фона
            this.Opacity = .97;
        }
    }
}
