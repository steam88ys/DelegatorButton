using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegatorButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Text = "버튼";
            button.Click += delegate (object s, EventArgs a)
            {
                MessageBox.Show("무명 델리게이터를 사용한 이벤트 연결");
            };
            EventHandler click = null;
            click = (e2, a2) =>
            {
                MessageBox.Show("람다를 사용한 이벤트 연결");
                button.Click -= click;
            };
            button.Click += click;
            Controls.Add(button);
        }
    }
}
