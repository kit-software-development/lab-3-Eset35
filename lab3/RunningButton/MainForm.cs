using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunningButton
{
    public partial class MainForm : Form
    {
        Point pos;//старая позиция курсора
        Point delta;//на сколько увеличилась позиция курсора(скорость изменения)

        public MainForm()
        {
            InitializeComponent();
        }

        //Если есть движение мышки по форме, то вызывается процедура изменения положения кнопки
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            ChangedButtonPos();
        }

        //подсчет скорости изменения позиции курсора
        private void CalcDelta(Point new_pos)
        {
                delta.X = pos.X - new_pos.X;
                delta.Y = pos.Y - new_pos.Y;
                pos = new_pos;
        }

        //изменение положения кнопки
        //если при калькуляции кнопка выходит за пределы формы, то ее перебрасывает на другую сторону формы
        private void ChangedButtonPos()
        {
            Point new_pos;
            new_pos = MousePosition;
            CalcDelta(new_pos);
            if (button1.Location.X-delta.X<5)
            {
                button1.Location = new Point(MainForm.ActiveForm.Width - button1.Width - 20, button1.Location.Y);
            }
            else if(button1.Location.X - delta.X > MainForm.ActiveForm.Width - button1.Width - 20)
            {
                button1.Location = new Point(5, button1.Location.Y);
            }
            else if(button1.Location.Y - delta.Y < 5)
            {
                button1.Location = new Point(button1.Location.X, MainForm.ActiveForm.Height - button1.Height - 35);
            }
            else if(button1.Location.Y - delta.Y > MainForm.ActiveForm.Height - button1.Height - 35)
            {
                button1.Location = new Point(button1.Location.X, 5);
            }
            else
            {
                button1.Location = new Point(button1.Location.X - delta.X, button1.Location.Y - delta.Y);
            }
        }

        //границы кнопки немного шире, чем видимая часть, 
        //поэтому при задевании кнопки она также должна изменять свое положение
        //в противном случае, кнопка застывает на месте
        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            ChangedButtonPos();
        }

        //если удалось кликнуть по кнопке, то победа => завершение игры, выход из программы
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем! Вы смогли нажать на кнопку!");
            Close();
        }

        //если размеры окна изменяются, то нужно высчитать новое положение кнопки.
        //если кнопка выходит за границы, то просто приклеиваем ее к ближайшему краю
        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            if (button1.Location.X < 5)
            {
                button1.Location = new Point(5, button1.Location.Y);
            }

            if (button1.Location.X > MainForm.ActiveForm.Width - button1.Width - 20)
            {
                button1.Location = new Point(MainForm.ActiveForm.Width - button1.Width - 20, button1.Location.Y);
            }

            if (button1.Location.Y < 5)
            {
                button1.Location = new Point(button1.Location.X, 5);
            }

            if (button1.Location.Y > MainForm.ActiveForm.Height - button1.Height - 35)
            {
                button1.Location = new Point(button1.Location.X, MainForm.ActiveForm.Height - button1.Height - 35);
            }
        }
    }
}
