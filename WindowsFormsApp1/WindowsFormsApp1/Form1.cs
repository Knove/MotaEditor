using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private  int[,] a;

       
        public Form1()
        {
          
            a = new int[11, 11];
            for(int j = 0; j < 11; j++) { 
            for (int i = 0; i < 11; i++)
            {
                Button b = new Button();
                b.Location = new Point(50+41 * i, 56+38*j);
                b.Size = new Size(43,40);
                b.Name = "btn" + i.ToString()+j.ToString();
                b.Click += new EventHandler(b_Click);
                b.Image = WindowsFormsApp1.Properties.Resources.diban;
                    b.FlatStyle = FlatStyle.Flat;
                    b.FlatAppearance.BorderSize =0;
                   
                this.Controls.Add(b);
            }
            }
            InitializeComponent();
        }
        void b_Click( object sender, EventArgs e)
        {
            string btnName = (sender as Button).Name;
            switch (btnName)
            {
                case "btn00": De_JG(sender as Button, 0,0); break;
                case "btn01": De_JG(sender as Button, 0, 1); break;
                case "btn02": De_JG(sender as Button, 0, 2); break;
                case "btn03": De_JG(sender as Button, 0, 3); break;
                case "btn04": De_JG(sender as Button, 0, 4); break;
                case "btn05": De_JG(sender as Button, 0, 5); break;
                case "btn06": De_JG(sender as Button, 0, 6); break;
                case "btn07": De_JG(sender as Button, 0, 7); break;
                case "btn08": De_JG(sender as Button, 0, 8); break;
                case "btn09": De_JG(sender as Button, 0, 9); break;
                case "btn010": De_JG(sender as Button, 0, 10); break;
                

                case "btn10": De_JG(sender as Button, 1, 0); break;
                case "btn11": De_JG(sender as Button, 1, 1); break;
                case "btn12": De_JG(sender as Button, 1, 2); break;
                case "btn13": De_JG(sender as Button, 1, 3); break;
                case "btn14": De_JG(sender as Button, 1, 4); break;
                case "btn15": De_JG(sender as Button, 1, 5); break;
                case "btn16": De_JG(sender as Button, 1, 6); break;
                case "btn17": De_JG(sender as Button, 1, 7); break;
                case "btn18": De_JG(sender as Button, 1, 8); break;
                case "btn19": De_JG(sender as Button, 1, 9); break;
                case "btn110": De_JG(sender as Button, 1, 10); break;
                

                case "btn20": De_JG(sender as Button, 2, 0); break;
                case "btn21": De_JG(sender as Button, 2, 1); break;
                case "btn22": De_JG(sender as Button, 2, 2); break;
                case "btn23": De_JG(sender as Button, 2, 3); break;
                case "btn24": De_JG(sender as Button, 2, 4); break;
                case "btn25": De_JG(sender as Button, 2, 5); break;
                case "btn26": De_JG(sender as Button, 2, 6); break;
                case "btn27": De_JG(sender as Button, 2, 7); break;
                case "btn28": De_JG(sender as Button, 2, 8); break;
                case "btn29": De_JG(sender as Button, 2, 9); break;
                case "btn210": De_JG(sender as Button, 2, 10); break;

                case "btn30": De_JG(sender as Button, 3, 0); break;
                case "btn31": De_JG(sender as Button, 3, 1); break;
                case "btn32": De_JG(sender as Button, 3, 2); break;
                case "btn33": De_JG(sender as Button, 3, 3); break;
                case "btn34": De_JG(sender as Button, 3, 4); break;
                case "btn35": De_JG(sender as Button, 3, 5); break;
                case "btn36": De_JG(sender as Button, 3, 6); break;
                case "btn37": De_JG(sender as Button, 3, 7); break;
                case "btn38": De_JG(sender as Button, 3, 8); break;
                case "btn39": De_JG(sender as Button, 3, 9); break;
                case "btn310": De_JG(sender as Button, 3, 10); break;

                case "btn40": De_JG(sender as Button, 4, 0); break;
                case "btn41": De_JG(sender as Button, 4, 1); break;
                case "btn42": De_JG(sender as Button, 4, 2); break;
                case "btn43": De_JG(sender as Button, 4, 3); break;
                case "btn44": De_JG(sender as Button, 4, 4); break;
                case "btn45": De_JG(sender as Button, 4, 5); break;
                case "btn46": De_JG(sender as Button, 4, 6); break;
                case "btn47": De_JG(sender as Button, 4, 7); break;
                case "btn48": De_JG(sender as Button, 4, 8); break;
                case "btn49": De_JG(sender as Button, 4, 9); break;
                case "btn410": De_JG(sender as Button, 4, 10); break;

                case "btn50": De_JG(sender as Button, 5, 0); break;
                case "btn51": De_JG(sender as Button, 5, 1); break;
                case "btn52": De_JG(sender as Button, 5, 2); break;
                case "btn53": De_JG(sender as Button, 5, 3); break;
                case "btn54": De_JG(sender as Button, 5, 4); break;
                case "btn55": De_JG(sender as Button, 5, 5); break;
                case "btn56": De_JG(sender as Button, 5, 6); break;
                case "btn57": De_JG(sender as Button, 5, 7); break;
                case "btn58": De_JG(sender as Button, 5, 8); break;
                case "btn59": De_JG(sender as Button, 5, 9); break;
                case "btn510": De_JG(sender as Button, 5, 10); break;

                case "btn60": De_JG(sender as Button, 6, 0); break;
                case "btn61": De_JG(sender as Button, 6, 1); break;
                case "btn62": De_JG(sender as Button, 6, 2); break;
                case "btn63": De_JG(sender as Button, 6, 3); break;
                case "btn64": De_JG(sender as Button, 6, 4); break;
                case "btn65": De_JG(sender as Button, 6, 5); break;
                case "btn66": De_JG(sender as Button, 6, 6); break;
                case "btn67": De_JG(sender as Button, 6, 7); break;
                case "btn68": De_JG(sender as Button, 6, 8); break;
                case "btn69": De_JG(sender as Button, 6, 9); break;
                case "btn610": De_JG(sender as Button, 6, 10); break;

                case "btn70": De_JG(sender as Button, 7, 0); break;
                case "btn71": De_JG(sender as Button, 7, 1); break;
                case "btn72": De_JG(sender as Button, 7, 2); break;
                case "btn73": De_JG(sender as Button, 7, 3); break;
                case "btn74": De_JG(sender as Button, 7, 4); break;
                case "btn75": De_JG(sender as Button, 7, 5); break;
                case "btn76": De_JG(sender as Button, 7, 6); break;
                case "btn77": De_JG(sender as Button, 7, 7); break;
                case "btn78": De_JG(sender as Button, 7, 8); break;
                case "btn79": De_JG(sender as Button, 7, 9); break;
                case "btn710": De_JG(sender as Button, 7, 10); break;

                case "btn80": De_JG(sender as Button, 8, 0); break;
                case "btn81": De_JG(sender as Button, 8, 1); break;
                case "btn82": De_JG(sender as Button, 8, 2); break;
                case "btn83": De_JG(sender as Button, 8, 3); break;
                case "btn84": De_JG(sender as Button, 8, 4); break;
                case "btn85": De_JG(sender as Button, 8, 5); break;
                case "btn86": De_JG(sender as Button, 8, 6); break;
                case "btn87": De_JG(sender as Button, 8, 7); break;
                case "btn88": De_JG(sender as Button, 8, 8); break;
                case "btn89": De_JG(sender as Button, 8, 9); break;
                case "btn810": De_JG(sender as Button, 8, 10); break;

                case "btn90": De_JG(sender as Button, 9, 0); break;
                case "btn91": De_JG(sender as Button, 9, 1); break;
                case "btn92": De_JG(sender as Button, 9, 2); break;
                case "btn93": De_JG(sender as Button, 9, 3); break;
                case "btn94": De_JG(sender as Button, 9, 4); break;
                case "btn95": De_JG(sender as Button, 9, 5); break;
                case "btn96": De_JG(sender as Button, 9, 6); break;
                case "btn97": De_JG(sender as Button, 9, 7); break;
                case "btn98": De_JG(sender as Button, 9, 8); break;
                case "btn99": De_JG(sender as Button, 9, 9); break;
                case "btn910": De_JG(sender as Button, 9, 10); break;

                case "btn100": De_JG(sender as Button, 10, 0); break;
                case "btn101": De_JG(sender as Button, 10, 1); break;
                case "btn102": De_JG(sender as Button, 10, 2); break;
                case "btn103": De_JG(sender as Button, 10, 3); break;
                case "btn104": De_JG(sender as Button, 10, 4); break;
                case "btn105": De_JG(sender as Button, 10, 5); break;
                case "btn106": De_JG(sender as Button, 10, 6); break;
                case "btn107": De_JG(sender as Button, 10, 7); break;
                case "btn108": De_JG(sender as Button, 10, 8); break;
                case "btn109": De_JG(sender as Button, 10, 9); break;
                case "btn1010": De_JG(sender as Button, 10, 10); break;


                default: break;
            }
        }


        private void 导出数组ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile1 = new SaveFileDialog();
            saveFile1.Filter = "文本文件(.txt)|*.txt";
            saveFile1.FilterIndex = 1;
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK && saveFile1.FileName.Length > 0)
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile1.FileName, false);
                try
                {
                    sw.WriteLine(de.Text); 
                }
                catch
                {
                    throw;
                }
                finally
                {
                    sw.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

         
           
        }
        void De_JG(Button b,int SZ_x,int SZ_y)
        {
            if (radioButton2.Checked==true) //
            {
                a[SZ_x, SZ_y] = 1;
                de.Text += "a["+ SZ_x + ", "+ SZ_y+ "] = 1;\n";
                b.Image = WindowsFormsApp1.Properties.Resources.qiang;
            }
            else if(radioButton1.Checked == true)
            {
                a[SZ_x, SZ_y] = 0;
                de.Text += "a["+ SZ_x + ", "+ SZ_y+ "] = 0;\n";
                b.Image = WindowsFormsApp1.Properties.Resources.diban;
            }
            else if (radioButton4.Checked == true)
            {
                a[SZ_x, SZ_y] = 0;
                de.Text += "a[" + SZ_x + ", " + SZ_y + "] = 2;\n";
                b.Image = WindowsFormsApp1.Properties.Resources.down;
            }
            else if (radioButton5.Checked == true)
            {
                a[SZ_x, SZ_y] = 0;
                de.Text += "a[" + SZ_x + ", " + SZ_y + "] = 3;\n";
                b.Image = WindowsFormsApp1.Properties.Resources.up;
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void 关于魔塔地图编辑器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请点击左上角【文件】-【导出数组】得到的txt文件发送到308346293@qq.com 。欢迎来一起参与制作！");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();//同时关闭以前的页面
            Form1 f = new Form1();
            f.ShowDialog();
            

        }
  
        protected override void OnClosing(CancelEventArgs e)//关闭全部
        {
            e.Cancel = true;
            this.the();
        }
        private void the()
        {
            Application.Exit();
        }

    
    }
}
