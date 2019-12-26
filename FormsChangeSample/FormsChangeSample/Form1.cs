using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsChangeSample
{
    public partial class Form1 : Form
    {
        public static UserControl1 ctr1;
        public static UserControl2 ctr2;

        public Form1()
        {
            InitializeComponent();

            ctr1 = new UserControl1();
            ctr2 = new UserControl2();

            //パネルにコントロール追加
            panel1.Controls.Add(ctr1);
            panel1.Controls.Add(ctr2);

            //コントロール表示
            ctr1.Visible = true;
            ctr2.Visible = false;
        }
    }
}
