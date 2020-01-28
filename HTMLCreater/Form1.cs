using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTMLCreater
{
    public partial class Form1 : Form
    {
        String ImgURL;
        public List<Sniping> Snip = new List<Sniping>();
        public Form1()
        {
            InitializeComponent();
            Snip.Add(SnipOri);
        }

        private void addFiger_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void imageSelectBT_Click(object sender, EventArgs e)
        {
            Form2 ImageWindow = new Form2(this);
            ImageWindow.Show(this);
            ImgURL = ImageWindow.pictureBox1.ImageLocation;
            Console.WriteLine("aaaa " +ImageWindow.pictureBox1.ImageLocation);
            Console.WriteLine("ImgURL:"+ ImgURL);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void runBT_Click(object sender, EventArgs e)
        {
            int i = 0;
            //HTMLへの書き込み処理
            string html;
            html = "<!DOCTYPE html> \n" +
                        "<html lang = \"JP\"> \n" +
                        "<head> \n" +
                        "<meta charset = \"utf-8\"> \n" +
                        "<title>" + titlebox.Text + "</title> \n" +
                        "<link rel = \"stylesheet\" href =stylesheet.css> \n" +
                        "</head> \n" +
                        "<body> \n" +
                        "<h3 class=\"captionTitle\">" + titlebox.Text + "</h3> \n" +
                        "<img id=\"target\" src=\" " + ImgURL + " \" alt=\"" + ImgURL + "\" usemap=\"#main\"> \n" +
                            " <map name = \"main\"> \n";

            foreach (Sniping item in Snip)
            {
                string onClieckedText = "";
                //画像の範囲内がクリックされた時の処理
                if (item.hyperlinkBT.Checked)
                {
                    onClieckedText = "<area shape = \"rect\" coords = \" " + item.x0.Value + "," + item.y0.Value + "," + item.x1.Value + "," + item.y1.Value + " \" href = \" " + item.linkText.Text + " \" alt = \"" + item.linkText.Text + "\" > \n";
                }
                if (item.commentBT.Checked)
                {
                    onClieckedText = "<area id = \"range"+i+"\" class=\"image\" shape=\"rect\" coords=\" " + item.x0.Value + "," + item.y0.Value + "," + item.x1.Value + "," + item.y1.Value + " \" alt=\"image\"> \n"+
                        "<p id = \"range"+i+"ex\" class=\"imageset\">" + item.CommentText.Text + "</p> \n";
                }
                else　//チェックされていなかったら中断
                {
                    MessageBox.Show("選択してください。");
                    return;
                }
                //HTML形式の書き込み
                html += onClieckedText;

                MessageBox.Show("画像ファイル:" + ImgURL + "\n" + " マウス左上X:" + item.x0.Value + " " + "Y:" + item.y0.Value + "\n" +
                           "マウス右下X:" + item.x1.Value + " " + "Y:" + item.y1.Value + "\n" +
                           "Comment:" + item.CommentText.Text);

                i++;
            }
            html +=  "</map> \n" +
                            "<!--jQuery property--> \n" +
                            "<script src = \"jquery-3.3.1.min.js\"></script> \n" +
                            "<script src = \"jQuery.js\"></script> \n" +
                        "<!----> \n" +
                        "</body>\n" +
                        "</html> \n";
            output(html);
        }
        private void output(string text)
        {
            //HTMLファイルの出力
            //MessageBox.Show(html);
            System.IO.StreamWriter sw = new System.IO.StreamWriter(
                @"C:\Users\YOSHIFUMI\Desktop\HTML\text.html", false, System.Text.Encoding.GetEncoding("utf-8"));
            //TextBox1.Textの内容を書き込む
            sw.WriteLine(text);
            //閉じる
            sw.Close();
        }

        private void CommentText_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkText_TextChanged(object sender, EventArgs e)
        {

        }


        private void linkText_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addBT_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            TabPage tp = new TabPage(tabControl1.TabPages.Count.ToString());
            tp.BackColor = Color.White;
            Sniping a = new Sniping();
            tp.Controls.Add(a);
            Console.WriteLine("a");
            tabControl1.TabPages.Insert(tabControl1.TabPages.Count - 1, tp);
            Console.WriteLine(tabControl1.TabPages.Count - 1);
            tabControl1.SelectedIndex--;
            Snip.Add(a);
            //tabControl1.
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addTabPage_Click(object sender, EventArgs e)
        {

        }

        public void XYPOS(int x0,int x1,int y0,int y1)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening_1(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int tabIndex = tabControl1.SelectedIndex;
            tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
            tabControl1.SelectedIndex = tabIndex-1;
        }
    }
}
