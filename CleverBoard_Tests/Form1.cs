using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleverBoard_Tests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KeyDown(object sender, KeyEventArgs e)
        {
            textBox1.Text = string.Format(
                " KeyDown \r\n\r\n" +
                "\tAlt : {0} \r\n" +
                "\tControl : {1} \r\n" +
                "\tShift : {2} \r\n"+
                "\tKeycode : {3} \r\n" +
                "\tKeydata : {4}\r\n" +
                "\tKeyvalue : {5}\r\n " +
                "\tModifiers : {6}\r\n"


                , e.Alt, e.Control, e.Shift, e.KeyCode, e.KeyData, e.KeyValue, e.Modifiers);
        }

        private void KeyUp(object sender, KeyEventArgs e)
        {
                    textBox2.Text = string.Format(
                " Keyup \r\n\r\n" +
                "\tAlt : {0} \r\n" +
                "\tControl : {1} \r\n" +
                "\tShift : {2} \r\n" +
                "\tKeycode : {3} \r\n" +
                "\tKeydata : {4}\r\n" +
                "\tKeyvalue : {5}\r\n " +
                "\tModifiers : {6}\r\n"


            , e.Alt, e.Control, e.Shift, e.KeyCode, e.KeyData, e.KeyValue, e.Modifiers);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
