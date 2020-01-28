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
    public partial class Form2 : Form
    {
        int mouseX;//マウスカーソル左上のX
        int mouseY;//マウスカーソル左上のY
        int mouseX1;//マウスカーソル右下のX
        int mouseY1;//マウスカーソル右下のY
        Image outputImg;
        Form1 mainWindow;
        public Form2(Form1 mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
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
                Console.WriteLine("Form2:"+ofd.FileName);
                mainWindow.selectedFileName.Text = ofd.FileName;

                this.Width = 1280;
                this.Height = 720;
                //this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                //画像を表示する
                //this.pictureBox1.Image = img;
                pictureBox1.Load(ofd.FileName);
                //pictureBox1.ImageLocation = ofd.FileName;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            MousePointGet();
            Console.WriteLine("1; X:" + mouseX + " Y:" + mouseY);
            mouseX1 = mouseX;
            mouseY1 = mouseY;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MousePointGet();
            Console.WriteLine("2; X:" + mouseX + " Y:" + mouseY);

            Sniping b = mainWindow.Snip[mainWindow.tabControl1.SelectedIndex];
            b.x0.Value = mouseX;
            b.y0.Value = mouseY;
            b.x1.Value = mouseX1;
            b.y1.Value = mouseY1;
            if (mouseX > mouseX1)
            {
                b.x0.Value = mouseX1;
                b.x1.Value = mouseX;
            }
            if (mouseY > mouseY1)
            {
                b.y0.Value = mouseY1;
                b.y1.Value = mouseY;
            }
            mainWindow.Show();
            Console.WriteLine("マウス左上X:" + b.x0.Value + " " + "Y:" + b.y0.Value);
            Console.WriteLine("マウス右下X:" + b.x1.Value + " " + "Y:" + b.y1.Value);
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
            mouseX = cp.X;
            //Y座標を取得する
            mouseY = cp.Y + pictureBox1.AutoScrollOffset.Y;

            //Console.WriteLine(pictureBox1.Size.Width);
            //Console.WriteLine(pictureBox1.Image.Width);
            //Console.WriteLine(pictureBox1.Image.PhysicalDimension.Width);
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            
        }
    }
}
