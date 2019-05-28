using Lesson.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lesson.Controller;
namespace Lesson.View
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(FormLoad);
        }

        private void FormLoad(object sender, EventArgs e)
        {
            userTypeSelect.Items.Add(UserType.Admin);
            userTypeSelect.Items.Add(UserType.Editor);
            userTypeSelect.Items.Add(UserType.User);
            addUserBtn.Click += new EventHandler(CreateUser);
        }

        private void CreateUser(object sender, EventArgs e)
        {
            if (passwordBox.Text == passwordConfirmBox.Text)
            {
                var _user = new User(usernameBox.Text, passwordBox.Text, emailBox.Text);
                _user.UserType = userTypeSelect.SelectedItem.ToString();
                _user.RegisterDate = DateTime.Now;
                Database.UsersDatabase.users.Add(_user);
            }
        }

        
    }
}
