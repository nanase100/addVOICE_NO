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
            this.textDirButton = new System.Windows.Forms.Button();
            this.textDirText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.takecheckDirButton = new System.Windows.Forms.Button();
            this.takecheckDirText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.outputDirButton = new System.Windows.Forms.Button();
            this.outputSelectCheck = new System.Windows.Forms.CheckBox();
            this.outputDirText = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // doButton
            // 
            this.doButton.Location = new System.Drawing.Point(171, 247);
            this.doButton.Name = "doButton";
            this.doButton.Size = new System.Drawing.Size(151, 44);
            this.doButton.TabIndex = 2;
            this.doButton.Text = "実行";
            this.doButton.UseVisualStyleBackColor = true;
            this.doButton.Click += new System.EventHandler(this.doButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textDirButton);
            this.groupBox1.Controls.Add(this.textDirText);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 68);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ボイス番号を追加するスクリプトののフォルダ";
            // 
            // textDirButton
            // 
            this.textDirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textDirButton.Location = new System.Drawing.Point(277, 29);
            this.textDirButton.Name = "textDirButton";
            this.textDirButton.Size = new System.Drawing.Size(27, 19);
            this.textDirButton.TabIndex = 1;
            this.textDirButton.Text = "...";
            this.textDirButton.UseVisualStyleBackColor = true;
            this.textDirButton.Click += new System.EventHandler(this.textDirButton_Click);
            // 
            // textDirText
            // 
            this.textDirText.AllowDrop = true;
            this.textDirText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textDirText.Location = new System.Drawing.Point(6, 29);
            this.textDirText.Name = "textDirText";
            this.textDirText.Size = new System.Drawing.Size(275, 19);
            this.textDirText.TabIndex = 0;
            this.textDirText.DragDrop += new System.Windows.Forms.DragEventHandler(this.textDirText_DragDrop);
            this.textDirText.DragEnter += new System.Windows.Forms.DragEventHandler(this.textDirText_DragEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.takecheckDirButton);
            this.groupBox2.Controls.Add(this.takecheckDirText);
            this.groupBox2.Location = new System.Drawing.Point(12, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 67);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "テイクチェックシートのあるフォルダ";
            // 
            // takecheckDirButton
            // 
            this.takecheckDirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.takecheckDirButton.Location = new System.Drawing.Point(277, 29);
            this.takecheckDirButton.Name = "takecheckDirButton";
            this.takecheckDirButton.Size = new System.Drawing.Size(27, 19);
            this.takecheckDirButton.TabIndex = 1;
            this.takecheckDirButton.Text = "...";
            this.takecheckDirButton.UseVisualStyleBackColor = true;
            this.takecheckDirButton.Click += new System.EventHandler(this.takecheckDirButton_Click);
            // 
            // takecheckDirText
            // 
            this.takecheckDirText.AllowDrop = true;
            this.takecheckDirText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.takecheckDirText.Location = new System.Drawing.Point(6, 29);
            this.takecheckDirText.Name = "takecheckDirText";
            this.takecheckDirText.Size = new System.Drawing.Size(275, 19);
            this.takecheckDirText.TabIndex = 0;
            this.takecheckDirText.DragDrop += new System.Windows.Forms.DragEventHandler(this.takecheckDirText_DragDrop);
            this.takecheckDirText.DragEnter += new System.Windows.Forms.DragEventHandler(this.takecheckDirText_DragEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.outputDirButton);
            this.groupBox3.Controls.Add(this.outputSelectCheck);
            this.groupBox3.Controls.Add(this.outputDirText);
            this.groupBox3.Location = new System.Drawing.Point(12, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 82);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "出力先";
            // 
            // outputDirButton
            // 
            this.outputDirButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outputDirButton.Location = new System.Drawing.Point(277, 29);
            this.outputDirButton.Name = "outputDirButton";
            this.outputDirButton.Size = new System.Drawing.Size(27, 19);
            this.outputDirButton.TabIndex = 1;
            this.outputDirButton.Text = "...";
            this.outputDirButton.UseVisualStyleBackColor = true;
            this.outputDirButton.Click += new System.EventHandler(this.outputDirButton_Click);
            // 
            // outputSelectCheck
            // 
            this.outputSelectCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outputSelectCheck.AutoSize = true;
            this.outputSelectCheck.Location = new System.Drawing.Point(163, 60);
            this.outputSelectCheck.Name = "outputSelectCheck";
            this.outputSelectCheck.Size = new System.Drawing.Size(141, 16);
            this.outputSelectCheck.TabIndex = 7;
            this.outputSelectCheck.Text = "元のファイルに上書きする";
            this.outputSelectCheck.UseVisualStyleBackColor = true;
            this.outputSelectCheck.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // outputDirText
            // 
            this.outputDirText.AllowDrop = true;
            this.outputDirText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputDirText.Location = new System.Drawing.Point(6, 29);
            this.outputDirText.Name = "outputDirText";
            this.outputDirText.Size = new System.Drawing.Size(275, 19);
            this.outputDirText.TabIndex = 0;
            this.outputDirText.TextChanged += new System.EventHandler(this.outputDirText_TextChanged);
            this.outputDirText.DragDrop += new System.Windows.Forms.DragEventHandler(this.outputDirText_DragDrop);
            this.outputDirText.DragEnter += new System.Windows.Forms.DragEventHandler(this.outputDirText_DragEnter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Location = new System.Drawing.Point(18, 247);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(147, 44);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ゲームエンジン";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CatSystem2",
            "yu-ris"});
            this.comboBox1.Location = new System.Drawing.Point(3, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 20);
            this.comboBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.doButton);
            this.MaximumSize = new System.Drawing.Size(9999, 350);
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "Form1";
            this.Text = "ボイス未設定のスクリプトにテイクチェックシートからボイス番号を割り当てるツール";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button doButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button textDirButton;
        private System.Windows.Forms.TextBox textDirText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button takecheckDirButton;
        private System.Windows.Forms.TextBox takecheckDirText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button outputDirButton;
        private System.Windows.Forms.TextBox outputDirText;
        private System.Windows.Forms.CheckBox outputSelectCheck;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

