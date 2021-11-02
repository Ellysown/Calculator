using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "6";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button42_Click(object sender, EventArgs e)
        {

        }

        private void button41_Click(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void btndot_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text =txtboxDisplay.Text + ".";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "0";
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "MR";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "=";
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = String.Empty;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "4";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "8";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "7";
        }

        private void btnsin_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "sin";
        }

        private void btncos_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "cos";
        }

        private void btntan_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "tan";
        }

        private void btnsin1_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "sin-1";
        }

        private void btncos1_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "cos-1";
        }

        private void btntan1_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "tan-1";
        }

        private void btnpi_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "π";
        }

        private void btne_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "e";
        }

        private void btnxy_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "x^y";
        }

        private void btnx3_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "x^3";
        }

        private void btnx2_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "x^2";
        }

        private void btnex_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "ex";
        }

        private void btn10x_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "10x";
        }

        private void btnyx_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "y√x";
        }

        private void btn3x_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "3√x";
        }

        private void btbsqrx_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "√x";
        }

        private void btnln_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "ln";
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "log";
        }

        private void btnopenp_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "(";
        }

        private void btnclosep_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + ")";
        }

        private void btn1x_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "1√x";
        }

        private void btnprcnt_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "%";
        }

        private void btnnexc_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "n!";
        }

        private void btnRND_Click(object sender, EventArgs e)
        {
           
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "3";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "2";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtboxDisplay.Text = txtboxDisplay.Text + "1";
        }

        private void txtboxDisplay_TextChanged(object sender, EventArgs e)
        {
            txtboxDisplay.MaxLength = 32767;
        }
    }
}
