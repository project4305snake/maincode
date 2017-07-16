using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snake_game
{
    public partial class Form1 : Form
    {
        int score = 0;
        Random randFood = new Random();
        food food;
        Graphics paper;
        snake snake = new snake();

        public Form1()
        {
            InitializeComponent();
            food = new food(randFood);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
         toolStripLabel1.Text = score.ToString();
            if (down == true) { snake.moveDown(); }
            if (up == true) { snake.moveUp(); }
            if (left == true) { snake.moveLeft(); }
            if (right == true) { snake.moveRight(); }
            for (int i = 0; i < snake.SnakeRec.Length; i++)
            {
                if (snake.SnakeRec[i].IntersectsWith(food.foodRec))
                {
                    Random rd = new Random();
                    score += rd.Next(5, 30);
                    snake.growSnake();
                    food.foodLocation(randFood);
                }
            }
            collision();
            this.Invalidate();
        }
        void Restart()
        {
            timer2.Enabled = true;
            label1.Text = "Bấm Phím Cách Để Bắt Đầu Chơi";
           toolStripLabel1.Text = "0";
            score = 0;
            MessageBox.Show("Game Over!!!");
            snake = new snake();
        }
        public void collision()
        {
            for (int i = 1; i < snake.SnakeRec.Length; i++)
            {
                if (snake.SnakeRec[0].IntersectsWith(snake.SnakeRec[i]))
                {
                    timer2.Enabled = false;
                    MessageBox.Show("Bạn đã tự cắn đuôi");

                    label1.Text = "Bấm Phím Cách Để Bắt Đầu Chơi";
                   toolStripLabel1.Text = "0";
                    score = 0;
                    MessageBox.Show("Game Over!!!");
                    snake = new snake();
                    Restart();
                }
                if (snake.SnakeRec[0].Y < 0 || snake.SnakeRec[0].Y > 290)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("Bạn đã cắn vào tường ");

                    label1.Text = "Bấm Phím Cách Để Bắt Đầu Chơi";
                    toolStripLabel1.Text = "0";
                    score = 0;
                    MessageBox.Show("Game Over!!!");
                    snake = new snake();
                    Restart();
                }
                if (snake.SnakeRec[0].X < 0 || snake.SnakeRec[0].X > 500)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("Bạn đã cắn vào tường");
                    label1.Text = "Bấm Phím Cách Để Bắt Đầu Chơi";
                    toolStripLabel1.Text = "0";
                    score = 0;
                    MessageBox.Show("Game Over!!!");
                    snake = new snake();
                    Restart();
                }
            }
        }
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
        Boolean left = false, right = false, up = false, down = false;

        private void label2_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            MessageBox.Show("Phần mềm được phát triển bởi:\r" +
                "Nhóm dhcn1a\r" +
                "--------------------------\r" +
                "HƯỚNG DẪN CÁCH CHƠI:\r" +
                "Bạn nhấn phím cách (Space) để bắt đầu chơi.\r"
                + "Sau đó hãy nhấn các phím trái phải lên xuống\r" +
                "để định hướng cho chú rắn của bạn chạy.\r" +
                "Có 5 mức độ cho bạn chọn:\r" +
                "Ấn phím số 1 để chọn chế độ dể.\r"
                + "Ấn phím số 2 để chọn chế độ bình thường.\r" +
                "Ấn phím số 3 để chọn chế độ khó.\r" +
                "Ấn phím số 4 để chọn chế độ siêu khó.\r" +
                "Ấn phím số 5 để chọn chế độ thánh thức thần thánh", "Hướng Dẫn");
            label1.Text = "Ấn Phím Cách Để Tiếp Tục . . .";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            paper = e.Graphics;
            food.drawFood(paper);
            snake.drawSnake(paper);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.D1)
            {
                timer2.Interval = 500;
            }
            if (e.KeyData == Keys.D2)
            {
                timer2.Interval = 300;
            }
            if (e.KeyData == Keys.D3)
            {
                timer2.Interval = 100;
            }
            if (e.KeyData == Keys.D4)
            {
                timer2.Interval = 50;
            }
            if (e.KeyData == Keys.D5)
            {
                timer2.Interval = 10;
            }
            if (e.KeyData == Keys.Space)
            {
                timer2.Enabled = true;
                left = false; right = false; up = false; down = false;
                label1.Text = "";
            }
            if (e.KeyData == Keys.Up && down == false)
            {
                up = true;
                down = false;
                left = false;
                right = false;
            }
            if (e.KeyData == Keys.Down && up == false)
            {
                up = false;
                down = true;
                left = false;
                right = false;
            }
            if (e.KeyData == Keys.Left && right == false)
            {
                up = false;
                down = false;
                left = true;
                right = false;
            }
            if (e.KeyData == Keys.Right && left == false)
            {
                up = false;
                down = false;
                left = false;
                right = true;
            }
        }
    }
}
