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
    public partial class FormAttendance : Form
    {
        public FormAttendance()
        {
            InitializeComponent();
        }

        private void FormAttendance_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "eJournalDBDataSet.Attendance". При необходимости она может быть перемещена или удалена.
            this.attendanceTableAdapter.Fill(this.eJournalDBDataSet.Attendance);

        }
    }
}
