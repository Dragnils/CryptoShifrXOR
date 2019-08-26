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

namespace CryptoShifrXOR
{
    public partial class Form1 : Form
    {
        BackgroundWorker worker = new BackgroundWorker();
        OpenFileDialog ofd = new OpenFileDialog();
        static string source = "";
        static FileStream fsIn =  new FileStream(source, FileMode.Open);
        string text = @"C:\Users\Anuarbek\Desktop\Ануар\test.txt";//fsIn.ToString();// считывает текст с пути

        public Form1()
        {
            InitializeComponent();
            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
            worker.ProgressChanged += Worker_ProgressChanged;
            
    }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                progressBar1.Visible = false;
                MessageBox.Show("Шифрование отменено", "Отменено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                progressBar1.Visible = false;
                MessageBox.Show("Шифрование завершено", "Завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (rdbEncrypt.Checked)
            {                
                int key;
                key = Convert.ToInt32(txtPassword.Text);
                byte[] arr = Encoding.Unicode.GetBytes(text);

                string strCrypt = Encrypt(arr, key);
                TextInfo = strCrypt;
                MessageBox.Show(strCrypt.ToString());
            }

            if (rdbDecrypt.Checked)
            {
                int key;
                key = Convert.ToInt32(txtPassword.Text);
                string ss = Decrypt(TextInfo, key);
                MessageBox.Show(ss);
            }
        }

        public static string Encrypt(byte[] arr, int key)// шифрование
        {
            
            
            byte[] mass = new byte[arr.Length];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = (byte)(arr[i] ^ key);
            }
            return Encoding.Unicode.GetString(mass);
           
        }

        public static string Decrypt(string encrypt, int key)// дешифрование
        {
            
        byte[] arr = Encoding.Unicode.GetBytes(encrypt);
            return Encrypt(arr, key);
        }


        string inputFile = null;
        private void btnFileOpen_Click(object sender, EventArgs e)// кнопка файл...
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                inputFile = ofd.FileName;
                txtSource.Text = inputFile;
            }
        }

        public string TextInfo
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
            }
        }        

        private void btnPusk_Click(object sender, EventArgs e)
        {
            if(worker.IsBusy)
            {
                
                MessageBox.Show("Невозможно зашивровать");
            }
            else
            {
                progressBar1.Visible = true;
                worker.RunWorkerAsync();
            }

            
        }
    }
}
