﻿using MPAi.DatabaseModel;
using MPAi.Forms.Popups;
using MPAi.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MPAi.Components;

namespace MPAi.Forms
{
    public partial class LoginScreen : Form
    {
        // Strings kept here for changability.
        private string defaultUsernameText = "Username...";
        private string defaultPasswordText = "Password...";

        /// <summary>
        /// Default constructor.
        /// </summary>
        public LoginScreen()
        {
            // Show the splash screen for intensive initialisation tasks.
            SplashScreen splashScreen = new SplashScreen();
            splashScreen.Show();

            // NOTE: Put any time-consuming tasks that only need to be done once on startup (such as file I/O) here.
            // They will be done while the splash screen is up.

            InitializeDB();

            /*
            Set the default folders to where the application is currently running. 
            The program depends on having a full path, but the dynamic settings can't be added by default.
            Also create the directories if they don't already exist.
            */
            Directory.CreateDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Audio"));
            Properties.Settings.Default.AudioFolder = MPAi.Cores.DirectoryManagement.AudioFolder;
            Directory.CreateDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Video"));
            Properties.Settings.Default.VideoFolder = MPAi.Cores.DirectoryManagement.VideoFolder;
            Directory.CreateDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Recording"));
            Properties.Settings.Default.RecordingFolder = MPAi.Cores.DirectoryManagement.RecordingFolder;
            Directory.CreateDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Report"));
            Properties.Settings.Default.ReportFolder = MPAi.Cores.DirectoryManagement.ScoreboardReportFolder;
            Directory.CreateDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "HTK"));
            Properties.Settings.Default.HTKFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "HTK");
            Directory.CreateDirectory(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Formant"));
            Properties.Settings.Default.FormantFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Formant");

            // Kill any erroneous processes that may be running.
            int currentPID = Process.GetCurrentProcess().Id;
            foreach (Process p in Process.GetProcessesByName("MPAi"))
            {
                if (!(p.Id == currentPID))
                {
                    
                    p.Kill();
                    p.WaitForExit();
                    p.Dispose();
                  
                }
            }

            // Initialise the LoginScreen.
            InitializeComponent();

            // Change this property to set what is pressed when the user presses enter. Currently it's set to Speak.
            AcceptButton = speakLaunchButton;
            
            // Checks the "Remember Me"checkbox value
            bool autoLog = rememberCheckBox.Checked = Properties.Settings.Default.autoLoginSetting;
            // If the user has been remembered, populate the username and password fields with their username and password.
            if (autoLog)
            { 
                VisualizeUser(UserManagement.CurrentUser);
            }

            splashScreen.Close();
        }

        public LoginScreen(string command) {
            if (command.Trim().ToLower() == "initdb") {
                SplashScreen splashScreen = new SplashScreen();
                splashScreen.Show();
                InitializeDB();
                splashScreen.Close();
                Close();
            }
        }

  

        /// <summary>
        /// Connects this program to the maintained database, and loads all relevant files.
        /// </summary>
        private void InitializeDB()
        {
            try
            {
                MPAiModel DBModel = new MPAiModel();
                DBModel.Database.Initialize(false);
                DBModel.Recording.Load();
                DBModel.Speaker.Load();
                DBModel.Category.Load();
                DBModel.Word.Load();
                DBModel.SingleFile.Load();
            }
            catch (Exception exp)
            {
                MPAiMessageBoxFactory.Show(exp.StackTrace, "Database linking error!");
                Console.WriteLine(exp.StackTrace);
            }
        }

        /// <summary>
        /// When the user clicks on the text box, remove the watermark, if it's present.
        /// </summary>
        /// <param name="sender">Automaitcally generated by Visual Studio.</param>
        /// <param name="e">Automaitcally generated by Visual Studio.</param>
        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Equals(defaultUsernameText) && usernameTextBox.ForeColor.Equals(SystemColors.InactiveCaption))
            {
                watermarkUsername(true);
            }
        }

        /// <summary>
        /// When the user loses focus on the text box, add the watermark if they've left it blank.
        /// </summary>
        /// <param name="sender">Automaitcally generated by Visual Studio.</param>
        /// <param name="e">Automaitcally generated by Visual Studio.</param>
        private void usernameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usernameTextBox.Text))
            {
                watermarkUsername(false);
            }
        }

        /// <summary>
        /// Handles turning on or off the watermark for the username text box.
        /// </summary>
        /// <param name="text">True if the watermark is being turned on, false if it is being turned off.</param>
        private void watermarkUsername(bool text)
        {
            usernameTextBox.ForeColor = text ? SystemColors.ControlText : SystemColors.InactiveCaption;
            usernameTextBox.Text = text ? string.Empty : defaultUsernameText;
        }

        /// <summary>
        /// When the user clicks on the text box, remove the watermark, if it's present.
        /// </summary>
        /// <param name="sender">Automaitcally generated by Visual Studio.</param>
        /// <param name="e">Automaitcally generated by Visual Studio.</param>
        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text.Equals(defaultPasswordText) && passwordTextBox.ForeColor.Equals(SystemColors.InactiveCaption))
            {
                watermarkPassword(true);
            }
        }

        /// <summary>
        /// When the user loses focus on the text box, add the watermark if they've left it blank.
        /// </summary>
        /// <param name="sender">Automaitcally generated by Visual Studio.</param>
        /// <param name="e">Automaitcally generated by Visual Studio.</param>
        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                watermarkPassword(false);
            }
        }

        /// <summary>
        /// Handles turning on or off the watermark for the password text box.
        /// </summary>
        /// <param name="text">True if there is text in the box, false otherwise.</param>
        private void watermarkPassword(bool text)
        {
            passwordTextBox.ForeColor = text ? SystemColors.ControlText : SystemColors.InactiveCaption;
            passwordTextBox.Text = text ? string.Empty : defaultPasswordText;
            passwordTextBox.UseSystemPasswordChar = text;
        }

        /// <summary>
        /// Automatically enters a username and password into the correct text boxes.
        /// </summary>
        /// <param name="Username">The username to enter, as a string.</param>
        /// <param name="Password">The password to enter, as a string.</param>
        public void VisualizeUser(MPAiUser user)
        {
            if (!(user == null))
            {
                watermarkUsername(true);
                usernameTextBox.Text = user.getName();

                watermarkPassword(true);
                passwordTextBox.Text = user.getCode();
            }
        }

        /// <summary>
        /// Authenticates the user and handles user errors.
        /// Also handles informing the user if they have entered an incorrect username or password.
        /// </summary>
        /// <returns>True if the user has logged in successfully, false otherwise.</returns>
        private bool login()
        {
            MPAiUser tUser = new MPAiUser(usernameTextBox.Text, passwordTextBox.Text);
            if (UserManagement.AuthenticateUser(ref tUser))
            {
                return true;
            }
            else
            {
                if (UserManagement.ContainsUser(tUser))
                {
                    MPAiMessageBoxFactory.Show("Password is incorrect!",
                    "Oops", MPAiMessageBoxButtons.OK);
                    passwordTextBox.Clear();
                    watermarkPassword(true);
                }
                else
                {
                    MPAiMessageBoxFactory.Show("User does not exist!",
                    "Oops", MPAiMessageBoxButtons.OK);
                    usernameTextBox.Clear();
                    watermarkUsername(false);
                    passwordTextBox.Clear();
                    watermarkPassword(false);
                }
                return false;
            }
        }

        /// <summary>
        /// Launches the signup window.
        /// </summary>
        /// <param name="sender">Automatically generated by Visual Studio.</param>
        /// <param name="e">Automatically generated by Visual Studio.</param>
        private void signupButton_Click(object sender, EventArgs e)
        {
            new UserCreationScreen().ShowDialog(this);
        }

        /// <summary>
        /// Updates the "Remember Me" setting when the checkbox is changed.
        /// </summary>
        /// <param name="sender">Automatically generated by Visual Studio.</param>
        /// <param name="e">Automatically generated by Visual Studio.</param>
        private void rememberCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.autoLoginSetting = rememberCheckBox.Checked;
        }

        private void speakLaunchButton_Click(object sender, EventArgs e)
        {
            if (login())
            {
                //new MPAi.Forms.Popups.AdministratorConsole().Show();
                new MPAiSpeakMainMenu().Show();
                Hide(); // As this is the first form that gets loaded, it becomes the main form for the program. If it is closed, the program terminates.
            }
        }


        private void soundLaunchButton_Click(object sender, EventArgs e)
        {
            if (login())
            {
                new MPAiSoundMainMenu().Show();
                Hide(); // As this is the first form that gets loaded, it becomes the main form for the program. If it is closed, the program terminates.
            }
        }

        /// <summary>
        /// Saves any changes made when the form is closed.
        /// </summary>
        /// <param name="sender">Automatically generated by Visual Studio.</param>
        /// <param name="e">Automatically generated by Visual Studio.</param>
        private void LoginScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(PlotController.getCurrentPlotProcess() == null))
            {
                //Kills any persistent Processes.
                try
                {
                    //PlotController.getCurrentPlotProcess().Kill();
                    //PlotController.getCurrentPlotProcess().WaitForExit();
                    //PlotController.getCurrentPlotProcess().Dispose();
                    
                }
                catch (Exception exp) {
                    Console.WriteLine(exp.StackTrace);
                }
            }

            foreach (var process in Process.GetProcessesByName("MPAiVowelRunner"))
            {
                process.Kill();
                process.WaitForExit();
                process.Dispose();
            }
            foreach (var process in Process.GetProcessesByName("MPAiPlotRunner"))
            {

                process.Kill();
                process.WaitForExit();
                process.Dispose();
            }

            UserManagement.WriteSettings();
            Properties.Settings.Default.Save();
        }
    }                                                    
}                                                        
                                                         