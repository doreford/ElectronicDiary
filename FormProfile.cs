using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicDiary
{
    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            InitializeComponent();
        }

        private void buttonSendReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Отчет отправлен!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSendQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вопрос отправлен!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
}
