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
    public partial class LoginForm : Form
    {
        /// <summary>
        /// \brief Конструктор для запуска экранной формы авторизации
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            this.passfield.AutoSize = false;
            this.passfield.Size = new Size(this.passfield.Width, 48);
            this.loginfield.Size = new Size(this.passfield.Width, 48);
        }

        /// <summary>
        /// \brief Метод для кнопки входа. Данный метод включает в себя проверку на вход для администратора и пользователя, а также когда пользователь не найден
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void login_button_Click(object sender, EventArgs e)
        {
            DataBase DB = new DataBase();

            switch (DB.AdminOrUser(loginfield.Text, passfield.Text))
            {
                case "Administrator":
                    SuperUser admin = new SuperUser();
                    admin.authorization(loginfield.Text, passfield.Text);
                    this.Hide();
                    AdminForm adminform = new AdminForm(admin);
                    adminform.Show();
                    break;
                case "User":
                    User user = new User();
                    user.authorization(loginfield.Text, passfield.Text);
                    this.Hide();
                    UserForm userform = new UserForm(user);
                    userform.Show();
                    break;
                case "User not found":
                    MessageBox.Show("Пользователь не зарегистрирован");
                    break;
                default:
                    MessageBox.Show("Ошибка");
                    break;
            }
        }
    }
}
