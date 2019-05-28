using Lesson.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
            this.Text = "User System";
            
            
        }

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
            registerBtn.Click += new EventHandler(openRegisterForm);
            loginBtn.Click += new EventHandler(openResultsForm);
        }

        private void openResultsForm(object sender, EventArgs e)
        {
            var label = new Label();
            label.Text = userTypeList.SelectedItem.ToString();
            var resultsForm = new ResultsForm();
            resultsForm.Controls.Add(label);
            resultsForm.Show();
            
        }

        private void openRegisterForm(object sender, EventArgs e)
        {
            var registerForm = new RegistrationForm();
            registerForm.Show();
        }

       
    }
}
