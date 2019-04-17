using Fair.DataLayer;
using Fair.Entities;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using Application = Fair.Entities.Application;

namespace Fair.FormsUI
{
    public partial class StandApplicationForm : Form
    {
        public StandApplicationForm()
        {
            InitializeComponent();
            _application = new Application();
            _fairRepository = new FairRepository();
        }

        private Application _application;
        private FairRepository _fairRepository;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var gender = (Gender)Enum.Parse(typeof(Gender), comboGender.Text);

            var employee = new Employee
            {
                Name = txtName.Text,
                Gender = gender,
                Age = (int)numericUpDown1.Value
            };

            _application.Employees.Add(employee);

            var list = new BindingList<Employee>(_application.Employees);
            listEmployees.DataSource = list;
        }

        private void StandApplicationForm_Load(object sender, EventArgs e)
        {
            var presentationTopics = _fairRepository.GetPresentationTopics();

            comboKonu.DataSource = presentationTopics;

            comboAlan.DataSource = Enum.GetValues(typeof(SizeOfStand));
            comboGender.DataSource = Enum.GetValues(typeof(Gender));
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var addApplication = _fairRepository.AddApplication(_application);
            if (addApplication)
            {
                MessageBox.Show("All is good");
            }
            else
            {
                MessageBox.Show("There is something wrong");
            }
        }

        //private FairRepository _fairRepository;

        //public FairRepository FairRepository
        //{
        //    get
        //    {
        //        if (_fairRepository == null)
        //        {
        //            _fairRepository = new FairRepository();
        //        }

        //        return _fairRepository;
        //    }
        //}
    }
}