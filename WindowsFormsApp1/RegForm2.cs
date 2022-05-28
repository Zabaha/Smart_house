using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class RegForm2 : Form
    {
        public User newUser = new User();
        public SuperUser admin = new SuperUser();

        /// <summary>
        /// \brief Конструктор для второй экранной формы регистрации
        /// </summary>
        /// <param name="newUser"></param>
        /// <param name="admin"></param>
        public RegForm2(User newUser, SuperUser admin)
        {
            InitializeComponent();
            Ffield.Text = "Введите фамилию";
            Ffield.ForeColor = Color.Gray;
            Nfield.Text = "Введите имя";
            Nfield.ForeColor = Color.Gray;
            Ofield.Text = "Введите отчество";
            Ofield.ForeColor = Color.Gray;
            rolefield.Text = "Введите роль";
            rolefield.ForeColor = Color.Gray;
            this.newUser = newUser;
            this.admin = admin;
        }

        private void Ffield_Enter(object sender, EventArgs e)
        {
            if (Ffield.Text == "Введите фамилию")
            {
                Ffield.Text = "";
                Ffield.ForeColor = Color.Black;
            }
        }

        private void Ffield_Leave(object sender, EventArgs e)
        {
            if (Ffield.Text == "")
            {
                Ffield.Text = "Введите фамилию";
                Ffield.ForeColor = Color.Gray;
            }
        }

        private void Nfield_Enter(object sender, EventArgs e)
        {
            if (Nfield.Text == "Введите имя")
            {
                Nfield.Text = "";
                Nfield.ForeColor = Color.Black;
            }
        }

        private void Nfield_Leave(object sender, EventArgs e)
        {
            if (Nfield.Text == "")
            {
                Nfield.Text = "Введите имя";
                Nfield.ForeColor = Color.Gray;
            }
        }

        private void Ofield_Enter(object sender, EventArgs e)
        {
            if (Ofield.Text == "Введите отчество")
            {
                Ofield.Text = "";
                Ofield.ForeColor = Color.Black;
            }
        }

        private void Ofield_Leave(object sender, EventArgs e)
        {
            if (Ofield.Text == "")
            {
                Ofield.Text = "Введите отчество";
                Ofield.ForeColor = Color.Gray;
            }
        }

        private void rolefield_Enter(object sender, EventArgs e)
        {
            if (rolefield.Text == "Введите роль")
            {
                rolefield.Text = "";
                rolefield.ForeColor = Color.Black;
            }
        }

        private void rolefield_Leave(object sender, EventArgs e)
        {
            if (rolefield.Text == "")
            {
                rolefield.Text = "Введите роль";
                rolefield.ForeColor = Color.Gray;
            }
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (Ffield.Text == "Введите фамилию")
            {
                MessageBox.Show("Логин не может быть пустым");
                return;
            }

            if (Nfield.Text == "Введите имя")
            {
                MessageBox.Show("Пароль не может быть пустым");
                return;
            }

            if (rolefield.Text == "Введите роль члена семьи")
            {
                MessageBox.Show("Роль не может быть пустой");
                return;
            }

            newUser.setRegFormInfo2(Nfield.Text, Ffield.Text, Ofield.Text, rolefield.Text);

            if (admin.RegistrationForm2(newUser))
            {
                if (admin.GetRole() == "Administrator")
                {
                    this.Hide();
                    AdminForm adminform = new AdminForm(admin);
                    adminform.Show();
                }
                else
                {
                    this.Hide();
                    LoginForm logform = new LoginForm();
                    logform.Show();
                }
            }
            else
                MessageBox.Show("Аккаунт не был создан");
        }
    }
}
