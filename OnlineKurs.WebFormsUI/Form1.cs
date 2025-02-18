using OnlineKurs.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineKurs.Business.Abstract;
using OnlineKurs.Business.DependencyResolves;
using OnlineKurs.Entities.Concrete;

namespace OnlineKurs.WebFormsUI
{
    public partial class Form1: Form
    {
        private IStudentService _studentService;
        public Form1()
        {
            InitializeComponent();
            _studentService = InstanceFactory.GetInstance<IStudentService>();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            dgwStudents.DataSource = _studentService.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _studentService.Add(new Student
            {
                FirstName = tbxName.Text,
                LastName = tbxLastname.Text,
                Email = tbxMail.Text

            });
            MessageBox.Show("öğrenci eklendi");
            LoadStudents();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _studentService.Update(new Student
            {
                StudentId = Convert.ToInt16(tbxId.Text),
                FirstName = tbxName.Text,
                LastName = tbxLastname.Text,
                Email = tbxMail.Text
            });
            MessageBox.Show("öğrenci bilgileri güncellendi");
            LoadStudents();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _studentService.Delete(new Student
            {
                StudentId = Convert.ToInt16(tbxId.Text),
            });
            MessageBox.Show("öğrenci kaydı silindi");
            LoadStudents();
        }
    }
}
