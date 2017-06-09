using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bishe
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "系统时间：" + DateTime.Now.ToString() + "   " + DateTime.Now.ToString("dddd", new System.Globalization.CultureInfo("zh-cn")); 
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Login login =new bishe.Login();
            timer1.Start();
            this.toolStripStatusLabel2.Text = "当前用户："+login.userName.ToString();
        }

        private void 功能11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.splitContainer1.Panel1.Controls.Clear();
            BasicInfo_order1 b1 = new BasicInfo_order1 { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.splitContainer1.Panel1.Controls.Add(b1);
            b1.Show();
            this.splitContainer1.Panel2.Controls.Clear();
            BasicInfo_order2 b2 = new BasicInfo_order2 { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.splitContainer1.Panel2.Controls.Add(b2);
            b2.Show();
        }

        private void 设备甘特图ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.splitContainer1.Panel1.Controls.Clear();
            Gantt1 g1 = new Gantt1 { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.splitContainer1.Panel1.Controls.Add(g1);
            g1.Show();
            this.splitContainer1.Panel2.Controls.Clear();
            Gantt2 g2=new Gantt2 { TopLevel = false, FormBorderStyle = FormBorderStyle.None };
            this.splitContainer1.Panel2.Controls.Add(g2);
            g2.Show();
        }
    }
}
