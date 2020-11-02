using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace addVOICE_NO
{
    public partial class Form1 : Form
    {
        DataManager dataManager = new DataManager();

        /// <summary>
        /// 
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doButton_Click(object sender, EventArgs e)
        {
            string takechckPath = takecheckDirText.Text;
            string scenarioPath = textDirText.Text;
            string outputPath = "";

            if (outputSelectCheck.Checked == false)
            {
                outputPath = outputDirText.Text;
            }

            if ( System.IO.Directory.Exists(scenarioPath) == false)
            {
                MessageBox.Show("スクリプトファイルのフォルダが存在しません。。フォルダを確認してください。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ( System.IO.Directory.Exists(takechckPath) == false)
            {
                MessageBox.Show("テイクチェックシートのフォルダが存在しません。。フォルダを確認してください。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //test
            if (outputSelectCheck.Checked == true)
            {
                if (MessageBox.Show(this, "元からあるスクリプトファイルを上書きしますが、よろしいですか？", "確認", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                if( System.IO.Directory.Exists(outputPath) == false )
                {
                    MessageBox.Show("出力先のフォルダが存在しません。フォルダを確認してください。", "確認", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            var type = (DataManager.EngineType)comboBox1.SelectedIndex;

            dataManager.Proc(scenarioPath, takechckPath, type);

            dataManager.OutputText(outputPath);

            MessageBox.Show("ボイスの追加作業が完了しました。", "確認",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           outputDirText.Enabled = !((CheckBox)sender).Checked;
           outputDirButton.Enabled = !((CheckBox)sender).Checked;
        }

        private void textDirText_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            textDirText.Text = fileName[0];
        }

        private void takecheckDirText_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            takecheckDirText.Text = fileName[0];
        }

        private void outputDirText_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileName = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            outputDirText.Text = fileName[0];
        }

        private void textDirText_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))    e.Effect = DragDropEffects.Copy;
            else                                                e.Effect = DragDropEffects.None;
        }

        private void takecheckDirText_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
            else e.Effect = DragDropEffects.None;
        }

        private void outputDirText_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
            else e.Effect = DragDropEffects.None;
        }





        private string openDialog(string defaultPath, bool ForDswitch = false)
        {
            string ret = "";

            if (ForDswitch)
            {
                //FolderBrowserDialogクラスのインスタンスを作成
                OpenFileDialog ofd = new OpenFileDialog();

                //上部に表示する説明テキストを指定する
                ofd.DefaultExt = ".txt";

                ofd.Title = "フォルダを指定してください。";

                ofd.Filter = "TXTファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*";

                ofd.InitialDirectory = defaultPath;
                //ダイアログを表示する
                if (ofd.ShowDialog(this) == DialogResult.OK)
                {
                    //選択されたフォルダを表示する
                    ret = ofd.FileName;
                }
            }
            else
            {
                //FolderBrowserDialogクラスのインスタンスを作成
                FolderBrowserDialog fbd = new FolderBrowserDialog();

                //上部に表示する説明テキストを指定する
                fbd.Description = "フォルダを指定してください。";

                //ルートフォルダを指定する
                //デフォルトでDesktop
                fbd.RootFolder = Environment.SpecialFolder.Desktop;

                //最初に選択するフォルダを指定する
                //RootFolder以下にあるフォルダである必要がある
                fbd.SelectedPath = defaultPath;

                //ユーザーが新しいフォルダを作成できるようにする
                //デフォルトでTrue
                fbd.ShowNewFolderButton = true;

                //ダイアログを表示する
                if (fbd.ShowDialog(this) == DialogResult.OK)
                {
                    //選択されたフォルダを表示する
                    ret = fbd.SelectedPath;
                }
            }


            return ret;
        }

        private void textDirButton_Click(object sender, EventArgs e)
        {
            string newPath = openDialog(textDirText.Text);

            if (newPath == "") return;
            textDirText.Text = newPath;
        }

        private void takecheckDirButton_Click(object sender, EventArgs e)
        {
            string newPath = openDialog(takecheckDirText.Text);

            if (newPath == "") return;
            takecheckDirText.Text = newPath;
        }

        private void outputDirButton_Click(object sender, EventArgs e)
        {
            string newPath = openDialog(outputDirText.Text);

            if (newPath == "") return;
            outputDirText.Text = newPath;
        }

        private void outputDirText_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
