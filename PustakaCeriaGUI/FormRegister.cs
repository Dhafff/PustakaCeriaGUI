﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

namespace PustakaCeriaGUI
{
    public partial class FormRegister : Form
    {
        private readonly UserRegistrationFactory _userRegistrationFactory;

        public FormRegister(UserRegistrationFactory userRegistrationFactory)
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            _userRegistrationFactory = userRegistrationFactory;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDaftar_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            var userRegistration = _userRegistrationFactory.CreateUserRegistration();
            string validationMessage = userRegistration.ValidateRegistration(username, password);
            if (string.IsNullOrEmpty(validationMessage))
            {
                userRegistration.RegisterUser(username, password);
                MessageBox.Show("Registrasi berhasil!");
                this.Close();
            }
            else
            {
                MessageBox.Show(validationMessage);
            }
        }

        private void buttonMasuk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public interface UserRegistration
    {
        string ValidateRegistration(string username, string password);
        void RegisterUser(string username, string password);
    }

    public interface UserRegistrationFactory
    {
        UserRegistration CreateUserRegistration();
    }

    public class JsonUserRegistration : UserRegistration
    {
        public string ValidateRegistration(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return "Username dan password tidak boleh kosong.";
            if (username.Length < 6)
                return "Username tidak boleh kurang dari 6 karakter.";
            if (username.Contains("!") || username.Contains("@") || username.Contains("#") || username.Contains("$"))
                return "Username tidak boleh mengandung karakter !, @, #, dan $.";
            if (!IsAscii(username))
                return "Username harus menggunakan karakter ASCII.";
            if (password.Length < 6)
                return "Password tidak boleh kurang dari 6 karakter.";
            if (!Regex.IsMatch(password, @"\d"))
                return "Password harus mengandung setidaknya satu angka.";
            if (username == password)
                return "Password tidak boleh sama dengan username.";

            return null;
        }

        public void RegisterUser(string username, string password)
        {
            string hashedPassword = HashPassword(password);

            var newUser = new JObject
        {
            { "username", username },
            { "password", hashedPassword }
        };

            JArray users;
            if (File.Exists("users.json"))
            {
                var json = File.ReadAllText("users.json");
                users = JArray.Parse(json);
            }
            else
            {
                users = new JArray();
            }

            users.Add(newUser);
            File.WriteAllText("users.json", users.ToString());
        }

        private bool IsAscii(string value)
        {
            return Encoding.UTF8.GetByteCount(value) == value.Length;
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var passwordBytes = Encoding.UTF8.GetBytes(password);
                var passwordHash = sha256.ComputeHash(passwordBytes);
                return Convert.ToBase64String(passwordHash);
            }
        }
    }

    public class JsonUserRegistrationFactory : UserRegistrationFactory
    {
        public UserRegistration CreateUserRegistration()
        {
            return new JsonUserRegistration();
        }
    }
}
