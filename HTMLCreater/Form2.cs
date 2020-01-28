using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HTMLCreater
{
    public partial class Form2 : Form
    {
        int mouseX;//マウスカーソル左上のX
        int mouseY;//マウスカーソル左上のY
        int mouseX1;//マウスカーソル右下のX
        int mouseY1;//マウスカーソル右下のY
        Point DR;
        Image outputImg;
        Form1 mainWindow;
        Sniping b;
        bool mouseflag = false;
        string imgfilepath;

        // APIを呼び出すため、対象のＤＬＬをインポート
        [DllImport("USER32.DLL")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, UInt32 bRevert);
        [DllImport("USER32.DLL")]
        private static extern UInt32 RemoveMenu(IntPtr hMenu, UInt32 nPosition, UInt32 wFlags);
        // 定数定義
        private const UInt32 SC_CLOSE = 0x0000F060;
        private const UInt32 MF_BYCOMMAND = 0x00000000;

        public Form2(Form1 mainWindow)
        {
            InitializeComponent();

            // コントロールボックスの［閉じる］ボタンの無効化
            IntPtr hMenu = GetSystemMenu(this.Handle, 0); // システムメニュー（フォームの）ハンドル取得する
            RemoveMenu(hMenu, SC_CLOSE, MF_BYCOMMAND);    // [×]ボタンを無効化する。



            this.mainWindow = mainWindow;
            Console.WriteLine("Snip[]:" + mainWindow.Snip.Count);
            DR = new Point(this);
            ImageOutput();

        }
        public void ImageOutput()
        {
            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();
            //[ファイルの種類]に表示される選択肢を指定する
            ofd.Filter = "Image Files(*.BMP; *.JPG; *.PNG)| *.BMP; *.JPG; *.PNG; .png | All files(*.*) | *.*";
            //1番目の「Image Files」が選択されているようにする
            ofd.FilterIndex = 1;
            //タイトルを設定する
            ofd.Title = "開くファイルを選択してください";
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            ofd.RestoreDirectory = true;
            //存在しないファイルの名前が指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckFileExists = true;
            //存在しないパスが指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckPathExists = true;

            //画像ファイル以外が選択された時の処理を書かないといけない
            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、選択されたファイル名を表示する
                Console.WriteLine("Form2:" + ofd.FileName);
                mainWindow.selectedFileName.Text = ofd.FileName;

                this.Width = 1280;
                this.Height = 720;
                //this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                //画像を表示する
                //this.pictureBox1.Image = img;
                pictureBox1.Load(ofd.FileName);
                imgfilepath = ofd.FileName;
            }
            else
            {
                Application.Exit();
                
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            DR.origin();
            mouseflag = true;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
        }

        private void MousePointGet()
        {
            //フォーム上の座標でマウスポインタの位置を取得する
            //画面座標でマウスポインタの位置を取得する
            System.Drawing.Point sp = System.Windows.Forms.Cursor.Position;
            //画面座標をクライアント座標に変換する
            System.Drawing.Point cp = this.PointToClient(sp);
            //X座標を取得する
            mouseX = cp.X - panel1.AutoScrollPosition.X;
            //Y座標を取得する
            mouseY = cp.Y - panel1.AutoScrollPosition.Y;
            //Console.WriteLine("AutoScrollPosition.X:" + panel1.AutoScrollPosition.X + "\n AutoScrollPosition.Y:" + panel1.AutoScrollPosition.Y);
        }



        public class Point
        {
            public int OriginX,OriginY,X0, Y0, X1, Y1, Width, Height;
            Form2 Form;
            public void origin()
            {
                System.Drawing.Point sp = System.Windows.Forms.Cursor.Position;
                //画面座標をクライアント座標に変換する
                System.Drawing.Point cp = Form.PointToClient(sp);
                //X座標を取得する
                X0 = OriginX = cp.X - Form.panel1.AutoScrollPosition.X;
                //Y座標を取得する
                Y0 = OriginY = cp.Y - Form.panel1.AutoScrollPosition.Y-Form.menuStrip1.Height;
            }

            public void P2()
            {
                System.Drawing.Point sp = System.Windows.Forms.Cursor.Position;
                //画面座標をクライアント座標に変換する
                System.Drawing.Point cp = Form.PointToClient(sp);
                //X座標を取得する
                X1 = cp.X - Form.panel1.AutoScrollPosition.X;
                //Y座標を取得する
                Y1 = cp.Y - Form.panel1.AutoScrollPosition.Y-Form.menuStrip1.Height;

                Console.WriteLine(X0 + "  " + Y0 + "  "+ X1 + "  " + Y1 + "  ");
                if (OriginX > X1)
                {
                    X0 = X1;
                    X1 = OriginX;
                }
                if (OriginY > Y1)
                {
                    Y0 = Y1;
                    Y1 = OriginY;
                }
                Width = X1 - X0;
                Height = Y1 - Y0;
            }
            public Point(Form2 param)
            {
                Form = param;
            }
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseflag)
            {
                Console.WriteLine("uuu");
                DR.P2();

                pictureBox1.Load(imgfilepath);
                Graphics g = Graphics.FromImage(pictureBox1.Image);

                Console.WriteLine("draw:(" + DR.X0 +"," + DR.Y0 + "," + DR.X1 + "," + DR.Y1+")");
                g.DrawRectangle(Pens.Red, (float)DR.X0, (float)DR.Y0, (float)DR.Width, (float)DR.Height);

                //リソースを解放する
                g.Dispose();

                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_DragOver(object sender, DragEventArgs e)
        {
            

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            b = mainWindow.Snip[mainWindow.tabControl1.SelectedIndex];
            DR.P2();
            Console.WriteLine("2; X:" + mouseX + " Y:" + mouseY);
            if (!(DR.X0 == DR.X1 && DR.Y0 == DR.Y1)) //座標が同じなら動作しない
            {
                if (DR.X0 < 0 || DR.X1 < 0 || DR.Y0 < 0 || DR.Y1 < 0)
                {
                    MessageBox.Show("選択された値が範囲外です");
                    RectPaint((int)b.x0.Value, (int)b.y0.Value, (int)b.x1.Value, (int)b.y1.Value);
                }
                else
                {
                    b.x1.Value = DR.X1;
                    b.y1.Value = DR.Y1;
                    b.x0.Value = DR.X0;
                    b.y0.Value = DR.Y0;

                    mainWindow.Show();
                    Console.WriteLine("マウス左上X:" + b.x0.Value + " " + "Y:" + b.y0.Value);
                    Console.WriteLine("マウス右下X:" + b.x1.Value + " " + "Y:" + b.y1.Value);
                }
            }
            else
            {
                RectPaint((int)b.x0.Value, (int)b.y0.Value, (int)b.x1.Value, (int)b.y1.Value);
            }
            mouseflag = false;
        }

        public void RectPaint(int x0, int y0, int x1, int y1)
        {
            Console.WriteLine("RectPoint");
            pictureBox1.Load(imgfilepath);
            Graphics g = Graphics.FromImage(pictureBox1.Image);

            Console.WriteLine("draw:(" + x0 + "," + y0 + "," + x1 + "," + y1 + ")");
            g.DrawRectangle(Pens.Red, (float)x0, (float)y0, (float)x1-x0, (float)y1-y0);

            //リソースを解放する
            g.Dispose();

            pictureBox1.Refresh();
        }

        private void pxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("");
        }

        private void sc1280px_Click(object sender, EventArgs e)
        {

        }
    }
}