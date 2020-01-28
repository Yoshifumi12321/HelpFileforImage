namespace HTMLCreater
{
    partial class Sniping
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.x0 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.y0 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.x1 = new System.Windows.Forms.NumericUpDown();
            this.y1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.hyperlinkBT = new System.Windows.Forms.RadioButton();
            this.CommentText = new System.Windows.Forms.RichTextBox();
            this.commentBT = new System.Windows.Forms.RadioButton();
            this.linkText = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.x0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.hyperlinkBT);
            this.panel2.Controls.Add(this.CommentText);
            this.panel2.Controls.Add(this.commentBT);
            this.panel2.Controls.Add(this.linkText);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 285);
            this.panel2.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.x0);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.y0);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.x1);
            this.panel1.Controls.Add(this.y1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(3, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 77);
            this.panel1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(7, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "画像座標";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(24, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "左上　X:";
            // 
            // x0
            // 
            this.x0.Location = new System.Drawing.Point(78, 22);
            this.x0.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.x0.Name = "x0";
            this.x0.Size = new System.Drawing.Size(38, 19);
            this.x0.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(129, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Y:";
            // 
            // y0
            // 
            this.y0.Location = new System.Drawing.Point(149, 22);
            this.y0.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.y0.Name = "y0";
            this.y0.Size = new System.Drawing.Size(38, 19);
            this.y0.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(24, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "右下　X:";
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(78, 46);
            this.x1.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(38, 19);
            this.x1.TabIndex = 10;
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(149, 46);
            this.y1.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(38, 19);
            this.y1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(129, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Y:";
            // 
            // hyperlinkBT
            // 
            this.hyperlinkBT.AutoSize = true;
            this.hyperlinkBT.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.hyperlinkBT.Location = new System.Drawing.Point(13, 12);
            this.hyperlinkBT.Name = "hyperlinkBT";
            this.hyperlinkBT.Size = new System.Drawing.Size(157, 19);
            this.hyperlinkBT.TabIndex = 17;
            this.hyperlinkBT.TabStop = true;
            this.hyperlinkBT.Text = "ハイパーリンクを埋め込む ：";
            this.hyperlinkBT.UseVisualStyleBackColor = true;
            // 
            // CommentText
            // 
            this.CommentText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommentText.Location = new System.Drawing.Point(11, 59);
            this.CommentText.Name = "CommentText";
            this.CommentText.Size = new System.Drawing.Size(547, 137);
            this.CommentText.TabIndex = 15;
            this.CommentText.Text = "";
            // 
            // commentBT
            // 
            this.commentBT.AutoSize = true;
            this.commentBT.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.commentBT.Location = new System.Drawing.Point(13, 37);
            this.commentBT.Name = "commentBT";
            this.commentBT.Size = new System.Drawing.Size(113, 19);
            this.commentBT.TabIndex = 17;
            this.commentBT.TabStop = true;
            this.commentBT.Text = "コメントを埋め込む";
            this.commentBT.UseVisualStyleBackColor = true;
            // 
            // linkText
            // 
            this.linkText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkText.Location = new System.Drawing.Point(176, 12);
            this.linkText.Name = "linkText";
            this.linkText.Size = new System.Drawing.Size(376, 19);
            this.linkText.TabIndex = 18;
            // 
            // Sniping
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel2);
            this.Name = "Sniping";
            this.Size = new System.Drawing.Size(579, 291);
            this.Load += new System.EventHandler(this.Sniping_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.x0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.NumericUpDown x0;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown y0;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown x1;
        public System.Windows.Forms.NumericUpDown y1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.RichTextBox CommentText;
        public System.Windows.Forms.RadioButton hyperlinkBT;
        public System.Windows.Forms.RadioButton commentBT;
        public System.Windows.Forms.TextBox linkText;
    }
}
