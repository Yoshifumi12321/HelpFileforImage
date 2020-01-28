namespace HTMLCreater
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageSelectBT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectedFileName = new System.Windows.Forms.Label();
            this.runBT = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.titlebox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addTabPage = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SnipOri = new HTMLCreater.Sniping();
            this.sniping1 = new HTMLCreater.Sniping();
            this.tabControl1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.addTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageSelectBT
            // 
            this.imageSelectBT.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.imageSelectBT.Location = new System.Drawing.Point(27, 27);
            this.imageSelectBT.Name = "imageSelectBT";
            this.imageSelectBT.Size = new System.Drawing.Size(75, 23);
            this.imageSelectBT.TabIndex = 1;
            this.imageSelectBT.Text = "画像を変更";
            this.imageSelectBT.UseVisualStyleBackColor = true;
            this.imageSelectBT.Click += new System.EventHandler(this.imageSelectBT_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(108, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "画像ファイル：";
            // 
            // selectedFileName
            // 
            this.selectedFileName.AutoSize = true;
            this.selectedFileName.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.selectedFileName.Location = new System.Drawing.Point(174, 32);
            this.selectedFileName.Name = "selectedFileName";
            this.selectedFileName.Size = new System.Drawing.Size(133, 15);
            this.selectedFileName.TabIndex = 3;
            this.selectedFileName.Text = "画像が選択されていません";
            // 
            // runBT
            // 
            this.runBT.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.runBT.Location = new System.Drawing.Point(262, 488);
            this.runBT.Name = "runBT";
            this.runBT.Size = new System.Drawing.Size(89, 24);
            this.runBT.TabIndex = 16;
            this.runBT.Text = "実行";
            this.runBT.UseVisualStyleBackColor = true;
            this.runBT.Click += new System.EventHandler(this.runBT_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(14, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "タイトル名：";
            // 
            // titlebox
            // 
            this.titlebox.Location = new System.Drawing.Point(16, 86);
            this.titlebox.Name = "titlebox";
            this.titlebox.Size = new System.Drawing.Size(584, 19);
            this.titlebox.TabIndex = 21;
            // 
            // tabControl1
            // 
            this.tabControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.addTabPage);
            this.tabControl1.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabControl1.Location = new System.Drawing.Point(12, 123);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(589, 342);
            this.tabControl1.TabIndex = 25;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(159, 22);
            this.toolStripMenuItem1.Text = "現在のタブを削除";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SnipOri);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(581, 314);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // addTabPage
            // 
            this.addTabPage.BackColor = System.Drawing.Color.White;
            this.addTabPage.Controls.Add(this.sniping1);
            this.addTabPage.Location = new System.Drawing.Point(4, 24);
            this.addTabPage.Name = "addTabPage";
            this.addTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.addTabPage.Size = new System.Drawing.Size(581, 314);
            this.addTabPage.TabIndex = 1;
            this.addTabPage.Text = "+";
            this.addTabPage.Click += new System.EventHandler(this.addTabPage_Click);
            this.addTabPage.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(500, 471);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 16);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "設定を保存する";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // SnipOri
            // 
            this.SnipOri.Location = new System.Drawing.Point(0, 0);
            this.SnipOri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SnipOri.Name = "SnipOri";
            this.SnipOri.Size = new System.Drawing.Size(579, 291);
            this.SnipOri.TabIndex = 0;
            // 
            // sniping1
            // 
            this.sniping1.Location = new System.Drawing.Point(6, 7);
            this.sniping1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sniping1.Name = "sniping1";
            this.sniping1.Size = new System.Drawing.Size(579, 291);
            this.sniping1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(613, 536);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.titlebox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.runBT);
            this.Controls.Add(this.selectedFileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageSelectBT);
            this.MaximumSize = new System.Drawing.Size(629, 575);
            this.MinimumSize = new System.Drawing.Size(629, 575);
            this.Name = "Form1";
            this.Text = "Main Pannel";
            this.Shown += new System.EventHandler(this.imageSelectBT_Click);
            this.tabControl1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.addTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button imageSelectBT;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label selectedFileName;
        private System.Windows.Forms.Button runBT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox titlebox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage addTabPage;
        private Sniping sniping1;
        private Sniping SnipOri;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

