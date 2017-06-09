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
    public partial class Gantt2 : Form
    {
        public Gantt2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Color[] c = new Color[] { Color.FromArgb(255,246,162), Color.FromArgb(17,203,215), Color.FromArgb(159,238,209), 
                Color.FromArgb(255,178,112), Color.FromArgb(97,93,236)};
            SolidBrush[] sbs = new SolidBrush[c.Length];
            for (int i = 0; i < c.Length; i++)
            {
                sbs[i] = new SolidBrush(c[i]);
            }
            SolidBrush sb = new SolidBrush(Color.Black);
            SolidBrush sb1 = new SolidBrush(Color.LightGray);
            Pen pen = new Pen(sb, 1);
            Font font = new Font("Arial", 9, FontStyle.Regular);
            g.DrawString("设备名称", font, Brushes.Black, 9, 25);

            int kedu_width = 24;//绘制刻度尺每小格宽
            String[] date = { "2017-06-06 星期二", "2017-06-07 星期三", "2017-06-08 星期四", "2017-06-09 星期五", "2017-06-10 星期六", "2017-06-11 星期日" };
            String[] time = { "00", "02", "04", "06", "08", "10", "12", "14", "16", "18", "20", "22" };


            string sql = "select distinct equip_name from lps order by equip_name";
            DataAccess DA = new DataAccess();
            if (DA.IsRead(sql) == true)
            {

                DataTable dt = new DataTable();
                dt = DA.ExeSQLdt(sql);
                String[] equipment = new String[(int)dt.Rows.Count];
                int y = 70; int m = 0;
                for (int i = 0; i < (int)dt.Rows.Count; i++)//每个设备的循环
                {
                    equipment[i] = dt.Rows[i]["equip_name"].ToString(); //将设备名称存入字符串数组中

                    g.DrawString(equipment[i].ToString(), font, Brushes.Black, 18, y);//绘制字符串设备名称
                    y += 30;

                    g.DrawLine(pen, 0, 90 + i * 30, 1920, 90 + i * 30);//绘制横着的线


                    string sql1 = "select * from lps where equip_name= " + "'" + dt.Rows[i]["equip_name"].ToString() + "'" + " order by start_time;";
                    DataAccess DA1 = new DataAccess();
                    if (DA1.IsRead(sql1) == true)
                    {
                        DataTable dt1 = new DataTable();
                        dt1 = DA.ExeSQLdt(sql1);

                        for (int j = 0; j < dt1.Rows.Count; j++)
                        {
                            double stime = (double)dt1.Rows[j]["start_time"];//数据库里的float对应vs里的double
                            double etime = (double)dt1.Rows[j]["end_time"];
                            float width = (float)(etime - stime);
                            int output = (int)dt1.Rows[j]["output"];
                            int due_output = (int)dt1.Rows[j]["due_output"];
                            g.FillRectangle(sb1, 80 + (float)stime * kedu_width / 2, 66 + 30 * i, width* kedu_width / 2, 18);
                            g.FillRectangle(sbs[m % sbs.Length], 80 + (float)stime * kedu_width / 2, 66 + 30 * i, (int)((float)output/due_output* width * kedu_width / 2), 18);
                            g.DrawRectangle(pen, 80 + (float)stime * kedu_width / 2, 66 + 30 * i, width* kedu_width / 2, 18);
                            m++;
                        }
                    }
                }

                //绘制最左边的线
                g.DrawLine(pen, 0, 0, 0, 60 + 30 * dt.Rows.Count);
                //绘制最左二的线
                g.DrawLine(pen, 80, 0, 80, 60 + 30 * dt.Rows.Count);
            }

            g.DrawLine(pen, 0, 0, 1920, 0);//绘制最顶上的线
            g.DrawLine(pen, 80, 30, 1920, 30);//绘制日期与时刻的分割线
            g.DrawLine(pen, 0, 60, 1920, 60);//绘制设备名称上的第一条线

            //绘制时间横轴的刻度
            for (int i = 0; i < 150; i++)
            {
                if (i % 12 == 0)
                    g.DrawLine(pen, 80 + i * kedu_width, 0, 80 + i * kedu_width, 60);
                else
                    g.DrawLine(pen, 80 + i * kedu_width, 56, 80 + i * kedu_width, 60);
            }

            //绘制字符串日期
            int x = 80;
            for (int i = 0; i < 6; i++)
            {

                g.DrawString(date[i].ToString(), font, Brushes.Black, x, 10);
                x += 12 * kedu_width;

            }

            //绘制字符串时刻
            x = 95;
            for (int i = 1; i < 255; i++)
            {

                g.DrawString(time[i % 12].ToString(), font, Brushes.Black, x, 40);
                x += kedu_width;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
