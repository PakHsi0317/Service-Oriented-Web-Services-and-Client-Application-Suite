using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //not for this project, just exercise
      //  private void btnClick_Click(object sender, EventArgs e)
     //   {
      //      PiService.Service1Client piService = new PiService.Service1Client();
      //      double piValue = piService.PiValue();
      //      piValueLabel2.Text = piValue.ToString();
     //   }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void piLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBoxc2f_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxf2c_TextChanged(object sender, EventArgs e)
        {

        }

        //make the buttone listener to Converting Celsius to Fahrenheit
        private void btnc2f_Click(object sender, EventArgs e)
        {
            int number;
            ServiceReference4.Service1Client client = new ServiceReference4.Service1Client();
            //read and update the textbox
            if (int.TryParse(textBoxc2f.Text, out number))
            {
                // Conversion successful, use 'number' variable here.
                double num2 = client.c2f(number);
                textBoxc2f.Text = num2.ToString();
            }
        }

        //make the buttone listener to Converting Fahrenheit to Celsius
        private void btnf2c_Click(object sender, EventArgs e)
        {
            int number;
            ServiceReference4.Service1Client service = new ServiceReference4.Service1Client();
            //read and update the textbox
            if (int.TryParse(textBoxf2c.Text, out number))
            {
                // Conversion successful, use 'number' variable here.
                double num2 = service.f2c(number);
                textBoxf2c.Text = num2.ToString();
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //make the buttone listener to sort the input
        private void btnCvertString_Click(object sender, EventArgs e)
        {
            //initialize the service and sort the stuff in textbox
            ServiceReference4.Service1Client client1 = new ServiceReference4.Service1Client();
            textBox2.Text = client1.sort(textBox2.Text);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        //make a web browser and take any URL to display the content
        private void btngo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(webBox.Text);
        }

        private void calTB2_TextChanged(object sender, EventArgs e)
        {

        }

        private void calTB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //make the add operation in calculator
        private void addBtn_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(calTB1.Text);
            double num2 = Convert.ToDouble(calTB2.Text);
            double result = num1 + num2;
            label2.Text = "+";
            label3.Text = result.ToString();
        }
        //make the substract operation in calculator
        private void subBtn_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(calTB1.Text);
            double num2 = Convert.ToDouble(calTB2.Text);
            double result = num1 - num2;
            label2.Text = "-";
            label3.Text = result.ToString();
        }
        //make the multiply operation in calculator
        private void multiBtn_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(calTB1.Text);
            double num2 = Convert.ToDouble(calTB2.Text);
            double result = num1 * num2;
            label2.Text = "*";
            label3.Text = result.ToString();
        }
        //make the divided operation in calculator
        private void divBtn_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(calTB1.Text);
            double num2 = Convert.ToDouble(calTB2.Text);
            double result = num1 / num2;
            label2.Text = "/";
            label3.Text = result.ToString();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //do the encyption and decryption into text user input
        private void button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServiceClient serviceClient = new ServiceReference1.ServiceClient();
            try { lblEn.Text = serviceClient.Encrypt(textBox1.Text); }
            catch (Exception ec) { lblEn.Text = ec.Message.ToString(); }
            try { lblDe.Text = serviceClient.Decrypt(lblEn.Text); }
            catch (Exception dc) { lblDe.Text = dc.Message.ToString(); }
        }

        private void lblEncrypted_Click(object sender, EventArgs e)
        {

        }

        private void lblDe_Click(object sender, EventArgs e)
        {

        }

        private void lblEn_Click(object sender, EventArgs e)
        {

        }
    }
}
