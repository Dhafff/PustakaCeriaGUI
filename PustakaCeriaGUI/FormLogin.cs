using Newtonsoft.Json.Linq;
using System.Security.Cryptography;
using System.Text;

namespace PustakaCeriaGUI
{
    public partial class FormLogin : Form
    {
        private readonly UserValidatorFactory _userValidatorFactory;
        private readonly IBookFactory bookFactory;
        public FormLogin(UserValidatorFactory userValidatorFactory, IBookFactory bookFactory)
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            _userValidatorFactory = userValidatorFactory;
            this.bookFactory = bookFactory;
        }

        private void buttonMasuk_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            var userValidator = _userValidatorFactory.CreateUserValidator();

            if (userValidator.Validate(username, password))
            {
                MessageBox.Show("Berhasil Masuk!");
                this.Hide();
                MainForm homePage = new MainForm(_userValidatorFactory, bookFactory);
                homePage.Show();
            }
            else
            {
                MessageBox.Show("Nama pengguna atau kata sandi salah!");
            }
        }

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            UserRegistrationFactory userRegistrationFactory = new JsonUserRegistrationFactory();
            FormRegister register = new FormRegister(userRegistrationFactory);
            this.Hide();
            register.ShowDialog();
            this.Show();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public interface UserValidator
    {
        bool Validate(string username, string password);
    }

    public interface UserValidatorFactory
    {
        UserValidator CreateUserValidator();
    }

    public class JsonUserValidator : UserValidator
    {
        public bool Validate(string username, string password)
        {
            if (File.Exists("users.json"))
            {
                var json = File.ReadAllText("users.json");
                var users = JArray.Parse(json);

                foreach (var user in users)
                {
                    if (user["username"].ToString() == username && VerifyPassword(password, user["password"].ToString()))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool VerifyPassword(string enteredPassword, string storedHashedPassword)
        {
            using (var sha256 = SHA256.Create())
            {
                var enteredPasswordBytes = Encoding.UTF8.GetBytes(enteredPassword);
                var enteredPasswordHash = sha256.ComputeHash(enteredPasswordBytes);
                var enteredPasswordHashString = Convert.ToBase64String(enteredPasswordHash);

                return enteredPasswordHashString == storedHashedPassword;
            }
        }
    }

    public class JsonUserValidatorFactory : UserValidatorFactory
    {
        public UserValidator CreateUserValidator()
        {
            return new JsonUserValidator();
        }
    }
}
