using System;

namespace Input
{
    public partial class Form1 : Form
    {
        string[] mShape = new string[3];
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;

            mShape[0] = "　　　　\r\n" +
                        "　■■　\r\n" +
                        "　■■　\r\n" +
                        "　　　　";
            mShape[1] = "　　　　\r\n" +
                        "■■■■\r\n" +
                        "　　　　\r\n" +
                        "　　　　";
            mShape[2] = "　　　　\r\n" +
                        "　■■　\r\n" +
                        "　　■■\r\n" +
                        "　　　　";
         }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            Console.WriteLine(c);
            switch(c)
            {
                case '0':
                    labelInput.Text = "0";
                    textBoxShape.Text = mShape[0];
                    break;
                case '1':
                    labelInput.Text = "1";
                    textBoxShape.Text = mShape[1];
                    break;
                case '2':
                    labelInput.Text = "2";
                    textBoxShape.Text = mShape[2];
                    break;
                default:
                    labelInput.Text = "0,1,2を入力してください";
                    break;
            }
            e.Handled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxShape_TextChanged(object sender, EventArgs e)
        {

        }
    }
}