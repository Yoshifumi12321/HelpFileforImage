using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HTMLCreater
{
    public partial class Form1 : Form
    {
        string ImgURL;
        string filename;
        string docPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
        string savePath;
        string backTxt;
        string[] data;
        string[] pdata;
        public List<Sniping> Snip = new List<Sniping>();
        string backup;
        Form2 ImageWindow;
        
        public Form1()
        {
            InitializeComponent();
            savePath =@"HTML\Image_Data";
            Snip.Add(SnipOri);
        }


        private void imageSelectBT_Click(object sender, EventArgs e)
        {
            if (ImageWindow!=null)
            {
                ImageWindow.Close();
            }
            ImageWindow = new Form2(this);
            ImageWindow.Show(this);

            if (ImageWindow.Owner != null)
            {
                ImageWindow.Owner.RemoveOwnedForm(ImageWindow);
            }
           
            ImgURL = ImageWindow.pictureBox1.ImageLocation;
            Console.WriteLine("aaaa " +ImageWindow.pictureBox1.ImageLocation);
            Console.WriteLine("ImgURL:"+ ImgURL);
            filename = System.IO.Path.GetFileNameWithoutExtension(ImgURL);
            backTxt = savePath + @"\" + filename + ".txt";

            Console.WriteLine("backTxt Exists:" + System.IO.File.Exists(backTxt));
            Console.WriteLine("backTxt Value:" +backTxt);


            if (System.IO.File.Exists(backTxt)&& !(backTxt == savePath + @"\" + ".txt"))
            {
                //メッセージボックスを表示する
                DialogResult result = MessageBox.Show("過去に作成済みです。復元しますか？",
                    "質問",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2);

                //何が選択されたか調べる
                if (result == DialogResult.Yes)
                {
                    Console.WriteLine("「はい」が選択されました");
                    contenueMode();
                }
                else if (result == DialogResult.No){
                    Console.WriteLine("「いいえ」が選択されました");
                    resetTab();
                }
                else if (result == DialogResult.Cancel){Console.WriteLine("「キャンセル」が選択されました");}
            }
            else
            {
                resetTab();
            }
        }
        private void contenueMode()
        {
            int commentNum = 5;
            int linkNum = 4;
            int checkNum = 3;
            int pointNum = 2;

            try
            {
                Console.WriteLine("backTxt:"+backTxt);
                // ファイルを読み取り形式で開く
                StreamReader file = new StreamReader(backTxt, Encoding.UTF8);
                string line = null;
                int i = 0;
                
                while ((line = file.ReadLine()) != null)    // 1行ずつ読み込む
                {
                    data = line.Split(',');       // カンマで区切って配列に格納
                    foreach (string d in data)
                    {
                        Console.WriteLine("["+i+"]:"+d);
                        i++;
                    }
                }
                file.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);       // エラーメッセージを表示
            }
            // 前回のデータの挿入部

            try
            {
                Console.WriteLine("data.length:" + (data.Length - 2) / 3);
            }
            catch
            {
                MessageBox.Show("データが破損しているため復元できませんでした");
                return;
            }
            

            //for (int i = 1; i < (data.Length - 2) / 4; i++)
            //{

            //    int tabIndex = tabControl1.SelectedIndex;
            //    if (tabIndex>=0)
            //    {
            //        Console.WriteLine("tabindex::::::::::::::::" + (tabIndex - 1));
            //        Snip.RemoveAt(tabIndex);
            //        tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
            //        tabControl1.SelectedIndex = tabIndex - 1;
            //    }
            //}
            resetTab();
            for (int i = 1; i < (data.Length - 2) / 4; i++)
            {
                addtabpage();
            }
            tabControl1.SelectedIndex = 0;

            titlebox.Text = data[1];

            commentNum = 5;
            linkNum = 4;
            checkNum = 3;
            pointNum = 2;
            Console.WriteLine("SnipCount:" + Snip.Count);
            Console.WriteLine("checknum-------:" + checkNum);
            foreach (Sniping item in Snip)
            {
                Console.WriteLine("checknum:" + data[checkNum]);
                if (data[checkNum] == "0")
                {
                    item.hyperlinkBT.Checked = true;
                }
                else
                {
                    item.commentBT.Checked = true;
                }
                item.linkText.Text = data[linkNum];
                item.CommentText.Text = data[commentNum].Replace("<br>", "\n");

                Console.WriteLine("pointNum:"+pointNum);
                pdata = data[pointNum].Split('\'');
                item.x0.Value = int.Parse(pdata[0]);
                item.y0.Value = int.Parse(pdata[1]);
                item.x1.Value = int.Parse(pdata[2]);
                item.y1.Value = int.Parse(pdata[3]);
                commentNum += 4;
                linkNum += 4;
                checkNum += 4;
                pointNum += 4;
            }

            ImageWindow.RectPaint((int)Snip[0].x0.Value, (int)Snip[0].y0.Value, (int)Snip[0].x1.Value, (int)Snip[0].y1.Value);
        }

        private void resetTab()
        {
            tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
            while (tabControl1.TabPages.Count > 0)
            {
                int tabIndex = tabControl1.SelectedIndex;
                if (tabIndex >= 0)
                {
                    Console.WriteLine("tabindex::::::::::::::::" + (tabIndex - 1));
                    Snip.RemoveAt(tabIndex);
                    tabControl1.TabPages.RemoveAt(tabIndex);
                    tabControl1.SelectedIndex = tabIndex - 1;
                }
                else
                {
                    break;
                }
            }
            tabControl1.SelectedIndex = 0;
        }

        private void runBT_Click(object sender, EventArgs e)
        {
            int checkNum = -1;
            string comment;
            int i = 0;
            filename = System.IO.Path.GetFileNameWithoutExtension(ImgURL);
            string filePath = savePath + @"\" + filename + ".txt";
            string imagePath =savePath + @"\" + filename + ".png";
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
                        "<img id=\"target\" src=\" " + Path.GetFullPath(imagePath) + " \" alt=\"" + Path.GetFullPath(imagePath) + "\" usemap=\"#main\"> \n" +
                            " <map name = \"main\"> \n";
            Console.WriteLine("imagePath:"+imagePath);
            foreach (Sniping item in Snip)
            {
                string onClieckedText = "";
                comment = item.CommentText.Text.Replace("\n", "<br>");
                //画像の範囲内がクリックされた時の処理
                if (item.hyperlinkBT.Checked)
                {
                    checkNum = 0;
                    //comment = item.linkText.Text;
                    onClieckedText = "<area shape = \"rect\" coords = \" " + item.x0.Value + "," + item.y0.Value + "," + item.x1.Value + "," + item.y1.Value + " \" href = \" " + item.linkText.Text + " \" alt = \"" + item.linkText.Text + "\" > \n";
                }
                else if (item.commentBT.Checked)
                {
                    checkNum = 1;
                    

                    onClieckedText = "<area id = \"range"+i+"\" class=\"image\" shape=\"rect\" coords=\" " + item.x0.Value + "," + item.y0.Value + "," + item.x1.Value + "," + item.y1.Value + " \" alt=\"image\"> \n"+
                        "<p id = \"range"+i+"ex\" class=\"imageset\">" + comment + "</p> \n";
                }
                else　//チェックされていなかったら中断
                {
                    MessageBox.Show("選択してください。");
                    return;
                }
                backup += "," + item.x0.Value + "\'" + item.y0.Value + "\'" + item.x1.Value + "\'" + item.y1.Value + ","+checkNum+"," +item.linkText.Text+ ","+comment;
                //HTML形式の書き込み
                html += onClieckedText;

                MessageBox.Show("画像ファイル:" + savePath+@"\data\"+filename+".png" + "\n" + " マウス左上X:" + item.x0.Value + " " + "Y:" + item.y0.Value + "\n" +
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
            
            if (checkBox1.Checked == true)
            {
                if (System.IO.Directory.Exists(savePath) == false)
                {
                    System.IO.Directory.CreateDirectory(savePath);
                    Console.WriteLine("savepath==========="+System.IO.File.Exists(savePath));
                }
                if (!(System.IO.File.Exists(savePath+@"\" + filename + ".txt")))
                {
                    
                    System.IO.StreamWriter newtext = System.IO.File.CreateText(filePath);
                    
                    newtext.Close();
                }
                System.IO.FileInfo fi = new System.IO.FileInfo(filePath);
                fi.IsReadOnly = false; //読み取り専用属性を解除
                fi.Attributes &= ~System.IO.FileAttributes.Hidden; //隠しファイル属性を解除

                System.IO.StreamWriter sw = new System.IO.StreamWriter(filePath, false, System.Text.Encoding.GetEncoding("utf-8"));
                fi.IsReadOnly = true; //読み取り専用属性を追加
                fi.Attributes |= System.IO.FileAttributes.Hidden; //隠しファイル属性を追加

                sw.WriteLine(filename+","+titlebox.Text+backup);
                sw.Close();
            }

            imageSave();

            backup = "";
            checkNum = -1;
        }
        private void output(string text)
        {
            //HTMLファイルの出力
            //MessageBox.Show(html);
            Console.WriteLine("ファイル出力先："+ @"HTML\"+filename+".html");
            System.IO.StreamWriter sw = new System.IO.StreamWriter(@"HTML\"+filename+".html", false, System.Text.Encoding.GetEncoding("utf-8"));
            //TextBox1.Textの内容を書き込む
            sw.WriteLine(text);
            //閉じる
            sw.Close();
        }

        private void imageSave()
        {
            Sniping sni = Snip[tabControl1.SelectedIndex];
            int x0 = (int)(sni.x0.Value);
            int y0 = (int)(sni.y0.Value);
            int x1 = (int)(sni.x1.Value);
            int y1 = (int)(sni.y1.Value);

            ImageWindow.RectPaint(0,0,0,0);
            ImageWindow.pictureBox1.Image.Save(savePath +@"\"+ filename+".png");
            ImageWindow.RectPaint(x0,y0,x1,y1);
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            addtabpage();
        }

        private void addtabpage()
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
            Console.WriteLine("SnipCount"+Snip.Count);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int tabIndex = tabControl1.SelectedIndex;
            Snip.RemoveAt(tabIndex);
            tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
            if (tabIndex !=0)
            {
                tabControl1.SelectedIndex = tabIndex - 1;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("tabcontrol::"+(tabControl1.SelectedIndex));
            if (tabControl1.SelectedIndex >= 0)
            {
                try
                {
                    Sniping SnipTab = Snip[tabControl1.SelectedIndex];
                    ImageWindow.RectPaint((int)SnipTab.x0.Value, (int)SnipTab.y0.Value, (int)SnipTab.x1.Value, (int)SnipTab.y1.Value);
                }
                catch
                {

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.TopMost = false;
        }

        private void addTabPage_Click(object sender, EventArgs e)
        {

        }
    }
}