using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManager_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Click += Button1_Click;
        }

        // Обработчик события нажатия на кнопку
        private void Button1_Click(object sender, EventArgs e)
        {
            // При нажатии выведется сообщение 'Hello, World'
            MessageBox.Show("Hello, World!");
        }
    }
}
