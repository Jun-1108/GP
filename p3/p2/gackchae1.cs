using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p2
{
    public partial class gackchae1 : Form
    {
        public gackchae1()
        {
            InitializeComponent();
        }

        private void gackchae1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cb1.Checked)
            {
                MessageBox.Show("1번 자리를 예약하시겠습니까?");
            }
            if (cb2.Checked)
            {
                MessageBox.Show("2번 자리를 예약하시겠습니까?");
            }
            if (cb3.Checked)
            {
                MessageBox.Show("3번 자리를 예약하시겠습니까?");
            }
            if (cb4.Checked)
            {
                MessageBox.Show("4번 자리를 예약하시겠습니까?");
            }
            if (cb5.Checked)
            {
                MessageBox.Show("5번 자리를 예약하시겠습니까?");
            }
            if (cb6.Checked)
            {
                MessageBox.Show("6번 자리를 예약하시겠습니까?");
            }
            if (cb7.Checked)
            {
                MessageBox.Show("7번 자리를 예약하시겠습니까?");
            }
            if (cb8.Checked)
            {
                MessageBox.Show("8번 자리를 예약하시겠습니까?");
            }
            MessageBox.Show("예약이 완료되었습니다.");
            this.Dispose(); 
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
