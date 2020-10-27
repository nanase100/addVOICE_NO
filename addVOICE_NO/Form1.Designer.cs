namespace addVOICE_NO
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
            this.doButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textDirText = new System.Windows.Forms.TextBox();
            this.dirButton1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // doButton
            // 
            this.doButton.Location = new System.Drawing.Point(328, 159);
            this.doButton.Name = "doButton";
            this.doButton.Size = new System.Drawing.Size(151, 37);
            this.doButton.TabIndex = 2;
            this.doButton.Text = "実行";
            this.doButton.UseVisualStyleBackColor = true;
            this.doButton.Click += new System.EventHandler(this.doButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dirButton1);
            this.groupBox1.Controls.Add(this.textDirText);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 68);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ボイス番号を追加するテキストのフォルダ";
            // 
            // textDirText
            // 
            this.textDirText.Location = new System.Drawing.Point(6, 29);
            this.textDirText.Name = "textDirText";
            this.textDirText.Size = new System.Drawing.Size(432, 19);
            this.textDirText.TabIndex = 0;
            // 
            // dirButton1
            // 
            this.dirButton1.Location = new System.Drawing.Point(434, 29);
            this.dirButton1.Name = "dirButton1";
            this.dirButton1.Size = new System.Drawing.Size(27, 19);
            this.dirButton1.TabIndex = 1;
            this.dirButton1.Text = "...";
            this.dirButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 67);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "テイクチェックシートのあるフォルダ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 19);
            this.button1.TabIndex = 1;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(432, 19);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 208);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.doButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button doButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button dirButton1;
        private System.Windows.Forms.TextBox textDirText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

