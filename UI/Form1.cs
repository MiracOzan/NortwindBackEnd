using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Concrete.Manager;
using Core.CrossCuttingConcerns.Log4Net.Loggers;
using DataAccess.Concrete.EntityFramework;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            EmployessManager _employessManager = new EmployessManager(new EfEmployeesDal());
            var result = _employessManager.GetList().Data.ToList();
            dataGridView1.DataSource = result.ToList();
        }
    }
}
