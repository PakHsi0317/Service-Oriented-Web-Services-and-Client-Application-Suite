using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        //make the buttone listener to Converting Celsius to Fahrenheit
        protected void btnc2f_Click(object sender, EventArgs e)
        {
            int number;
            ServiceReference4.Service1Client client = new ServiceReference4.Service1Client();
            //read and update the textbox
            if (int.TryParse(TextBox1.Text, out number))
            {
                // Conversion successful, use 'number' variable here.
                double num2 = client.c2f(number);
                TextBox1.Text = num2.ToString();
            }
        }
        //make the buttone listener to Converting Fahrenheit to Celsius
        protected void btnf2c_Click(object sender, EventArgs e)
        {
            int number;
            ServiceReference4.Service1Client service = new ServiceReference4.Service1Client();  
            //read and update the textbox
            if (int.TryParse(TextBox2.Text, out number))
            {
                // Conversion successful, use 'number' variable here.
                double num2 = service.f2c(number);
                TextBox2.Text = num2.ToString();
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //make the buttone listener to sort the input
        protected void btnCvert_Click(object sender, EventArgs e)
        {
            //initialize the service and sort the stuff in textbox
            ServiceReference4.Service1Client client1 = new ServiceReference4.Service1Client();
            TextBox3.Text = client1.sort(TextBox3.Text);
        }
    }
}