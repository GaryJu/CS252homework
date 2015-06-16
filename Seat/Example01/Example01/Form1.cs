using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
    public partial class Form1 : Form
    {
        private int[] status;  //宣告在外面成為欄位，使得大家都認識這個變數

        public Form1()
        {
            InitializeComponent();
            InitializeSeats();  //初始化座位
        }

        private void InitializeSeats()  //初始化座位的方法
        {
            Random random = new Random();
            status = new int[36];  //使用陣列將亂數存起來
            for (int index = 0; index < 36; index++)
            {
                status[index] = random.Next(0, 2);

                SetSeatImages(status);
            }
        }

        private void SetSeatImages(int[] status)  //將陣列亂數status套到裡面
        {
            this.pictureBox1.Image = GetSeatImage(status[0]);
            this.pictureBox2.Image = GetSeatImage(status[1]);
            this.pictureBox3.Image = GetSeatImage(status[2]);
            this.pictureBox4.Image = GetSeatImage(status[3]);
            this.pictureBox5.Image = GetSeatImage(status[4]);
            this.pictureBox6.Image = GetSeatImage(status[5]);
            this.pictureBox7.Image = GetSeatImage(status[6]);
            this.pictureBox8.Image = GetSeatImage(status[7]);
            this.pictureBox9.Image = GetSeatImage(status[8]);
            this.pictureBox10.Image = GetSeatImage(status[9]);
            this.pictureBox11.Image = GetSeatImage(status[10]);
            this.pictureBox12.Image = GetSeatImage(status[11]);
            this.pictureBox13.Image = GetSeatImage(status[12]);
            this.pictureBox14.Image = GetSeatImage(status[13]);
            this.pictureBox15.Image = GetSeatImage(status[14]);
            this.pictureBox16.Image = GetSeatImage(status[15]);
            this.pictureBox17.Image = GetSeatImage(status[16]);
            this.pictureBox18.Image = GetSeatImage(status[17]);
            this.pictureBox19.Image = GetSeatImage(status[18]);
            this.pictureBox20.Image = GetSeatImage(status[19]);
            this.pictureBox21.Image = GetSeatImage(status[20]);
            this.pictureBox22.Image = GetSeatImage(status[21]);
            this.pictureBox23.Image = GetSeatImage(status[22]);
            this.pictureBox24.Image = GetSeatImage(status[23]);
            this.pictureBox25.Image = GetSeatImage(status[24]);
            this.pictureBox26.Image = GetSeatImage(status[25]);
            this.pictureBox27.Image = GetSeatImage(status[26]);
            this.pictureBox28.Image = GetSeatImage(status[27]);
            this.pictureBox29.Image = GetSeatImage(status[28]);
            this.pictureBox30.Image = GetSeatImage(status[29]);
            this.pictureBox31.Image = GetSeatImage(status[30]);
            this.pictureBox32.Image = GetSeatImage(status[31]);
            this.pictureBox33.Image = GetSeatImage(status[32]);
            this.pictureBox34.Image = GetSeatImage(status[33]);
            this.pictureBox35.Image = GetSeatImage(status[34]);
            this.pictureBox36.Image = GetSeatImage(status[35]);
        }

        private Image GetSeatImage(int status)  //設定位子狀態的方法
        {
            if (status == 0)
            {
                return global::Example01.Properties.Resources.seat_unavail;
            }
            else if (status == 1)
            {
                return global::Example01.Properties.Resources.seat_avail;
            }
            else
            {
                return global::Example01.Properties.Resources.seat_select;
            }
        }

        private void ChooseSeat()
        {
            for (int seatNumber = 0; seatNumber <= status.Length - 3; seatNumber++)
            {
                if (status[seatNumber] == 1 && status[seatNumber + 1] == 1 && status[seatNumber + 2] == 1)
                {
                    status[seatNumber] = 2;
                    status[seatNumber + 1] = 2;
                    status[seatNumber + 2] = 2;

                    SetSeatImages(status);  //更新座位圖
                    break;  //不再找座位
                }
            }
        }

        private void chooseSeatButton_Click(object sender, EventArgs e)
        {
            ChooseSeat();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            InitializeSeats();
        }
    }
}