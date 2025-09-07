using DVLD_Buisness;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Global_Classes
{
    internal static class clsGlobal
    {
        public static clsUser CurrentUser;
        public static bool SaveUserNameAndPasswordToRegistry(string UserName, string Password)
        {
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLDProject_Data";

            string KeyUserName = "UserName";
            string KeyUserData = UserName;

            string KeyPassword = "Password";
            string KeyPasswordData = Password;

            if(KeyUserData == "")
            {
                RemoveStoredCredential(KeyPath, KeyUserName);
                RemoveStoredCredential(KeyPath, KeyPassword);
            }

            try
            {
                Registry.SetValue(KeyPath, KeyUserName, KeyUserData, RegistryValueKind.String);
                Registry.SetValue(KeyPath, KeyPassword, KeyPasswordData, RegistryValueKind.String);

                return true;
            }
            catch(Exception Ex)
            {
                MessageBox.Show($"An error occured: {Ex.Message}");
                return false;
            }


        }

        public static bool GetStoredCredential(ref string UserName, ref string Password)
        {
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLDProject_Data";

            string KeyUserName = "UserName";
            string KeyPassword = "Password";

            try
            {
                UserName = Registry.GetValue(KeyPath, KeyUserName, null) as string;
                Password = Registry.GetValue(KeyPath, KeyPassword, null) as string; 

                if(UserName == null || Password == null) 
                {
                    UserName = "";
                    Password = "";

                    return false;
                }

                return true;
            }
            catch(Exception Ex)
            {
                MessageBox.Show($"An error occured: {Ex.Message}");
                return false;
            }
        }
        public static bool RemoveStoredCredential(string KeyPath, string KeyValueName)
        {
            try
            {
                // Open the registry key in read/write mode with explicit registry view
                using (RegistryKey BaseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    using (RegistryKey Key = BaseKey.OpenSubKey(KeyPath, true))
                    {
                        if (Key != null)
                        {
                            // Delete the specified value
                            Key.DeleteValue(KeyValueName);
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("UnauthorizedAccessException: Run the program with" +
                                    " administrative privileges.", "Access Denied",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"An error occured: {Ex.Message}");
                return false;
            }
        }

        //the below code for interact with files
        /*
        public static bool RememberUserNameAndPassword(string UserName, string Password)
        {
            try
            {
                //this will get the current project directory folder.
                string CurrenetDirectory = System.IO.Directory.GetCurrentDirectory();

                // Define the path to the text file where you want to save the data
                string FilePath = CurrenetDirectory + "\\data.txt";

                //incase the username is empty, delete the file
                if (UserName == "" && File.Exists(FilePath))
                {
                    File.Delete(FilePath);
                    return true;
                }

                // concatonate username and passwrod withe seperator.
                string LineData = UserName + "#//#" + Password;

                // Create a StreamWriter to write to the file
                using (StreamWriter Writer = new StreamWriter(FilePath))
                {
                    // Write the data to the file
                    Writer.WriteLine(LineData);
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}");
                return false;
            }
        }

        public static bool GetStoredCredential(ref string UserName, ref string Password)
        {
            //this will get the stored username and password and will return true if found and false if not found.
            try
            {
                //gets the current project's directory
                string CurrentDirectory = System.IO.Directory.GetCurrentDirectory();

                // Path for the file that contains the credential.
                string FilePath = CurrentDirectory + "\\data.txt";

                // Check if the file exists before attempting to read it
                if (!File.Exists(FilePath))
                {
                    return false;
                }

                // Create a StreamReader to read from the file
                using (StreamReader Reader = new StreamReader(FilePath))
                {
                    // Read data line by line until the end of the file
                    string LineData;

                    while ((LineData = Reader.ReadLine()) != null)
                    {
                        Console.WriteLine(LineData); // Output each line of data to the console
                        string[] Result = LineData.Split(new string [] { "#//#"}, StringSplitOptions.None );
                        UserName = Result[0];
                        Password = Result[1];
                    }

                    return true;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"An error occured: {ex.Message}");
                return false;
            }
        }*/
    }
}
