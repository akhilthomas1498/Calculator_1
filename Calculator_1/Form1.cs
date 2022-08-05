using System;
using Assemb_Pro;
namespace Calculator_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Calculate cal = new Calculate();
                txtResult.Text = cal.add(Convert.ToInt32(txt1.Text), Convert.ToInt32(txt2.Text)).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                Calculate cal = new Calculate();
                txtResult.Text = cal.sub(Convert.ToInt32(txt1.Text), Convert.ToInt32(txt2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}