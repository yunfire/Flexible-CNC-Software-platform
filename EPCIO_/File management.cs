using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EPCIO
{
    public partial class File_management : UserControl
    {
        public File_management()
        {
            InitializeComponent();
            DealInf();

        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            AddFile();
        }
        private void Btn_DeleteGcode_Click(object sender, EventArgs e)
        {
            DeleteFile();
        }
        public void Btn_Choose_Click(object sender, EventArgs e)
        {
         
        }
        private void AddFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            //讀取TXT
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string folderName = System.Windows.Forms.Application.StartupPath + @"\ProductGcode\";
                string filePath = openFileDialog.FileName;
                string fileName =folderName + Path.GetFileName(filePath);
                File.Copy(filePath, fileName);
                MessageBox.Show("添加成功");
            }
            DealInf();
        }
        private void DealInf()   //更新Gcode清單
        {
            ProductList.Items.Clear();
            string folderName = System.Windows.Forms.Application.StartupPath + @"\ProductGcode\"; //資料夾路徑
            string fileName; //資料夾名稱
            foreach (string fname in System.IO.Directory.GetFiles(folderName))// 取得資料夾內所有檔案
            {
                fileName = Path.GetFileNameWithoutExtension(fname);
                ProductList.Items.Add(fileName);
            }
        }

        private void DeleteFile()
        {
            try
            {
            string folderName = System.Windows.Forms.Application.StartupPath + @"\ProductGcode\";
            string fileName = ProductList.SelectedItem.ToString();
            string file = folderName + fileName+".txt";
            
                File.Delete(file);
                DealInf();
                MessageBox.Show(fileName + "刪除成功");
            }
            catch
            {
                MessageBox.Show("刪除失敗");
            }
        }

        private void Btn_ChooseRough_Click(object sender, EventArgs e)
        {
            try
            {
                Lb_Roughing.Text = ProductList.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("請先選取檔案");
            }
         }

        private void Btn_ChooseSmooth_Click(object sender, EventArgs e)
        {
            try
            {
                Lb_Smoothing.Text = ProductList.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("請先選取檔案");
            }
            
        }

        private void Rb_Coaster_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_Coaster.Checked)
            {
                Lb_Product.Text = "杯墊";
                Lb_Grouping.Text = "2(A=>B=>D)";
            }
            else
            {
                Lb_Product.Text = "筆記本";
                Lb_Grouping.Text = "1(A=>B=>C)";
            }
        }

        private void Rb_Notebook_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_Coaster.Checked)
            {
                Lb_Product.Text = "杯墊";
                Lb_Grouping.Text = "2(A=>B=>D)";
            }
            else
            {
                Lb_Product.Text = "筆記本";
                Lb_Grouping.Text = "1(A=>B=>C)";
            }
        }
    }
}
