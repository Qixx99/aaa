namespace ШЕСТАЯ_ПОПЫТКА__1___
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b=0, c, d=0;
            {
                a = Convert.ToSingle(textBox1.Text);
            }
            if (radioButton1.Checked == true) 
           {
              b = a * 4;
            };

            ////  if (radioButton2.Checked == true)
              {
            c = a /5;
            }
            if (radioButton3.Checked == true)
            {
                d = a / 2;
            }
            MessageBox.Show(Convert.ToString(b));

            MessageBox.Show(Convert.ToString(d));
            label2.Text="Вы наговорили на:"+Convert.ToString(d);
          
            label2.Text = "Вы наговорили на:" + Convert.ToString(b);
            label2.Text = "Вы наговорили на:" + Convert.ToString(c);


        }
    }
}