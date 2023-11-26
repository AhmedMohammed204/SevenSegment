using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SevenSegment
{
    public partial class frmSevenSegment : Form
    {
        public frmSevenSegment()
        {
            InitializeComponent();
        }

        void ResetSevSegButtons()
        {
            btnSevSeg1.BackColor = Color.White;
            btnSevSeg2.BackColor = Color.White;
            btnSevSeg3.BackColor = Color.White;
            btnSevSeg4.BackColor = Color.White;
            btnSevSeg5.BackColor = Color.White;
            btnSevSeg6.BackColor = Color.White;
            btnSevSeg7.BackColor = Color.White;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ResetSevSegButtons();
            btnSevSeg2.BackColor = Color.GreenYellow;
            btnSevSeg4.BackColor = Color.GreenYellow;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ResetSevSegButtons();
            btnSevSeg1.BackColor = Color.GreenYellow;
            btnSevSeg2.BackColor = Color.GreenYellow;
            btnSevSeg3.BackColor = Color.GreenYellow;
            btnSevSeg5.BackColor = Color.GreenYellow;
            btnSevSeg6.BackColor = Color.GreenYellow;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ResetSevSegButtons();
            btnSevSeg1.BackColor = Color.GreenYellow;
            btnSevSeg2.BackColor = Color.GreenYellow;
            btnSevSeg3.BackColor = Color.GreenYellow;
            btnSevSeg5.BackColor = Color.GreenYellow;
            btnSevSeg4.BackColor = Color.GreenYellow;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ResetSevSegButtons();
            btnSevSeg2.BackColor = Color.GreenYellow;
            btnSevSeg3.BackColor = Color.GreenYellow;
            btnSevSeg4.BackColor = Color.GreenYellow;
            btnSevSeg7.BackColor = Color.GreenYellow;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ResetSevSegButtons();
            btnSevSeg1.BackColor = Color.GreenYellow;
            btnSevSeg7.BackColor = Color.GreenYellow;
            btnSevSeg3.BackColor = Color.GreenYellow;
            btnSevSeg4.BackColor = Color.GreenYellow;
            btnSevSeg5.BackColor = Color.GreenYellow;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ResetSevSegButtons();
            btnSevSeg1.BackColor = Color.GreenYellow;
            btnSevSeg7.BackColor = Color.GreenYellow;
            btnSevSeg3.BackColor = Color.GreenYellow;
            btnSevSeg5.BackColor = Color.GreenYellow;
            btnSevSeg4.BackColor = Color.GreenYellow;
            btnSevSeg6.BackColor = Color.GreenYellow;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ResetSevSegButtons();
            btnSevSeg1.BackColor = Color.GreenYellow;
            btnSevSeg2.BackColor = Color.GreenYellow;
            btnSevSeg4.BackColor = Color.GreenYellow;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ResetSevSegButtons();
            btnSevSeg1.BackColor = Color.GreenYellow;
            btnSevSeg2.BackColor = Color.GreenYellow;
            btnSevSeg3.BackColor = Color.GreenYellow;
            btnSevSeg4.BackColor = Color.GreenYellow;
            btnSevSeg5.BackColor = Color.GreenYellow;
            btnSevSeg6.BackColor = Color.GreenYellow;
            btnSevSeg7.BackColor = Color.GreenYellow;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ResetSevSegButtons();
            btnSevSeg1.BackColor = Color.GreenYellow;
            btnSevSeg2.BackColor = Color.GreenYellow;
            btnSevSeg3.BackColor = Color.GreenYellow;
            btnSevSeg4.BackColor = Color.GreenYellow;
            btnSevSeg5.BackColor = Color.GreenYellow;
            btnSevSeg7.BackColor = Color.GreenYellow;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            ResetSevSegButtons();
            btnSevSeg1.BackColor = Color.GreenYellow;
            btnSevSeg2.BackColor = Color.GreenYellow;
            btnSevSeg4.BackColor = Color.GreenYellow;
            btnSevSeg5.BackColor = Color.GreenYellow;
            btnSevSeg6.BackColor = Color.GreenYellow;
            btnSevSeg7.BackColor = Color.GreenYellow;
        }
    }
}
