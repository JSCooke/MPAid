﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MPAid
{
    /// <summary>
    /// The login screen for the application.
    /// </summary>
    public partial class LoginWindow : Form
    {
    
        private IoController fileMapper;
        private UserManagement myUsers;

        public LoginWindow()
        {
            InitializeComponent();

            fileMapper = new IoController();
            myUsers = new UserManagement(fileMapper.GetAppDataDir());

            InitializeUI();
        }

        /// <summary>
        /// Sets up the user interface for the login window.
        /// </summary>
        private void InitializeUI()
        {
            buttonSignUp.ImageNormal = Properties.Resources.ButtonYellow_0;
            buttonSignUp.ImageHighlight = Properties.Resources.ButtonYellow_1;
            buttonSignUp.ImagePressed = Properties.Resources.ButtonYellow_2;

            buttonLogin.ImageNormal = Properties.Resources.ButtonGreen_0;
            buttonLogin.ImageHighlight = Properties.Resources.ButtonGreen_1;
            buttonLogin.ImagePressed = Properties.Resources.ButtonGreen_2;
            // Checks the "Remember Me"checkbox value
            bool autoLog = autoLogin.Checked = Properties.Settings.Default.autoLoginSetting;
            // If the user has been remembered, populate the username and password fields with their username and password.
            if (autoLog)
            {
                MPAiUser lastUser = myUsers.getCurrentUser();
                if (lastUser != null)
                    VisualizeUser(lastUser);
            }
        }
        /// <summary>
        /// Populates the username and password text boxes with the values of the input user.
        /// </summary>
        /// <param name="user">The user to remember, as an MPAiUser object.</param>
        private void VisualizeUser(MPAiUser user)
        {
            userNameBox.Text = user.getName();
            codeBox.Text = user.getCode();
        }
        /// <summary>
        /// Clears the username and password text boxes.
        /// </summary>
        public void ResetUserInput()
        {
            userNameBox.Clear();
            codeBox.Clear();
        }
        /// <summary>
        /// Authenticates the username and password entered in the text boxes, and shows the main window if the combination is valid.
        /// </summary>
        public void PerformLogin()
        {
            MPAiUser tUser = new MPAiUser(userNameBox.Text, codeBox.Text);
            if (myUsers.AuthenticateUser(tUser))
            {
                Hide();
                MainForm mainWindow = new MainForm(myUsers);
                //Deprecated: MainForm class now takes users as a parameter.
                //mainWindow.SetUserManagement(myUsers);
                mainWindow.SetHomeWindow(this);
                mainWindow.Show();
            }
            else
            {
                MessageBox.Show("User does not exist or password incorrect! ",
                    "Ooops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            PerformLogin();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            //Creates a NewUserWindow object to create a new user.
            NewUserWindow newUserWin = new NewUserWindow();
            newUserWin.SetAllUsers(myUsers);    //TODO: Put this in the NewUserWindow constructor.
            newUserWin.ShowDialog();

            MPAiUser candidate = newUserWin.getCandidate();
            // If the registration was valid, inform the user. 
            // TODO: Put this in the create new user window.
            if (newUserWin.validRegistration())
            {
                if (myUsers.CreateNewUser(candidate))
                {
                    MessageBox.Show("Registration successful! ",
                        "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    myUsers.WriteSettings();

                    VisualizeUser(candidate);
                }
                else
                {
                    MessageBox.Show("Sorry, unknown error occurred! Please try again~ ",
                        "Ooops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void LoginWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            myUsers.WriteSettings();
            Properties.Settings.Default.Save();
        }
    }
}
