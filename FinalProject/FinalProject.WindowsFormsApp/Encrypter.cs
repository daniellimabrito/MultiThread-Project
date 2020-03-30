using System;
using System.Collections.Generic;
using System.Text;
// NEW
using System.IO;
// NEW DELEGATE
using System.Windows.Forms;
// NEW DATAGRID
using System.ComponentModel;
using FinalProject.WindowsFormsApp;

namespace MarsEncrypter
{
    public class Encrypter
    {
        // The complete input file name (including the path)
        private string prsInputFileName;
        // The complete output (encrypted) file name (including the path)
        private string prsOutputFileName;
        // The list of strings to be encrypted
        private List<string> pasTextToEncrypt;
        // NEW DATAGRID
        private FileToEncryptProgress proFileToEncryptProgress;
        public FileToEncryptProgress poFileToEncryptProgress
        {
            set
            {
                proFileToEncryptProgress = value;
            }
            get
            {
                return proFileToEncryptProgress;
            }
        }
        // END NEW DATAGRID

        // NEW DELEGATE
        private FormMain proForm;
        public FormMain poForm
        {
            set
            {
                proForm = value;
            }
            get
            {
                return proForm;
            }
        }

        public string psInputFileName
        {
            set
            {
                prsInputFileName = value;
            }
            get
            {
                return prsInputFileName;
            }
        }

        public string psOutputFileName
        {
            set
            {
                prsOutputFileName = value;
            }
            get
            {
                return prsOutputFileName;
            }
        }
        
        public void EncryptFile()
        {
            LoadTextToEncrypt();
            EncryptText();
            SaveEncryptedText();
            // Update the UI
            // NEW DELEGATE
            // Call the form's method to update the UI using a safe delegate
            proForm.AddToListBox(prsInputFileName);
        }

        private void LoadTextToEncrypt()
        {
            pasTextToEncrypt = new List<string>();

            try
            {
                // Create an instance of StreamReader to read from the input file
                // the using statement closes the StreamReader
                using (StreamReader loInputStream = new StreamReader(prsInputFileName))
                {
                    String lsLine;
                    // Read and add lines to lasTextToEncrypt from the file until its end is reached
                    while ((lsLine = loInputStream.ReadLine()) != null)
                    {
                        pasTextToEncrypt.Add(lsLine);
                        //Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                // Something went wrong
                System.Diagnostics.Debug.Print("The file could not be read:");
                System.Diagnostics.Debug.Print(e.Message);
            }
        }

        private void EncryptText()
        {
            int liProgress;
            int liOldProgress = 0;

            for (int i = 0; i < pasTextToEncrypt.Count; i++)
            {
                pasTextToEncrypt[i] = Encrypt(pasTextToEncrypt[i]);
                // NEW DATAGRID
                liProgress = (i * 100 / pasTextToEncrypt.Count);
                if (liProgress > liOldProgress)
                {
                    liOldProgress = liProgress;
                    proFileToEncryptProgress.piProgress = liProgress;
                    // Update the UI
                    // Call the form's method to update the UI using a safe delegate
                    proForm.UpdateProgress();
                }
            }
            // All the strings were encrypted
            // Thus, 100% must be shown
            proFileToEncryptProgress.piProgress = 100;
            proForm.UpdateProgress();
        }

        private void SaveEncryptedText()
        {
            try
            {
                // Create an instance of StreamWriter to write to the output file
                // the using statement closes the StreamWriter
                using (StreamWriter loOutputStream = new StreamWriter(prsOutputFileName, false, Encoding.Unicode))
                {
                    foreach (string lsLine in pasTextToEncrypt)
                    {
                        loOutputStream.Write(lsLine);
                    }
                }
            }
            catch (Exception e)
            {
                // Something went wrong
                System.Diagnostics.Debug.Print("The file could not be written:");
                System.Diagnostics.Debug.Print(e.Message);
            }
        }

        private string Encrypt(string psText)
        {
            string lsEncryptedText;
            string lsEncryptedTextWithFinalXOR;
            // A Random number generator
            Random loRandom = new Random();

            // The char position being encrypted
            int i;
            char loRandomChar;

            //////// REMOVE
            // Debug
            // Show the original text in the Immediate Window
            //System.Diagnostics.Debug.Print("Original text:" + psText);
            //////// REMOVE

            lsEncryptedText = "";
            for (i = 0; i <= (psText.Length - 1); i++)
            {
                loRandomChar = (char)(loRandom.Next(65535));
                // Current char XOR random generated char

                //////// REMOVE
                // Debug
                // Show the random char code (in numbers) generated in the Immediate Window
                //System.Diagnostics.Debug.Print("Random char generated:" + ((int)loRandomChar).ToString());
                //////// REMOVE

                lsEncryptedText += ((char)(psText[i] ^ loRandomChar)).ToString();
                // Random generated char XOR 65535 - i
                // It is saved because we need it later for the decryption process
                lsEncryptedText += ((char)(loRandomChar ^ (65535 - i))).ToString();
                // Another random generated char but just to add garbage to confuss the hackers
                loRandomChar = (char)(loRandom.Next(65535));
                lsEncryptedText += loRandomChar.ToString();

                //////// REMOVE
                // Debug
                // Show how the encrypted text is being generated in the Immediate Window
                //System.Diagnostics.Debug.Print("Partial encryption result char number: " + i.ToString() + ": " + lsEncryptedText);
                //////// REMOVE

            }

            lsEncryptedTextWithFinalXOR = "";
            
            for (i = 0; i <= (lsEncryptedText.Length - 1); i++)
            {
                lsEncryptedTextWithFinalXOR += ((char)(lsEncryptedText[i] ^ 125)).ToString();
            }

            //////// REMOVE
            // Debug
            // Show how the encrypted text is being generated in the Immediate Window
            //System.Diagnostics.Debug.Print("Final encryption result with XOR: " + lsEncryptedTextWithFinalXOR);
            //////// REMOVE

            return lsEncryptedTextWithFinalXOR;
        }
    }


    // NEW DATAGRID

    // This class implements a simple customer type 
    // that implements the INotifyPropertyChanged interface. 
    public class FileToEncryptProgress : INotifyPropertyChanged
    {
        private string prsInputFileName = String.Empty;
        private int priProgress = 0;

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        //// The constructor is private to enforce the factory pattern.
        //private FileToEncryptProgress()
        //{
        //}
        
        public FileToEncryptProgress(string parsInputFileName, int pariProgress)
        {
            prsInputFileName = parsInputFileName;
            priProgress = pariProgress;
        }

        //// This is the public factory method. 
        //public static FileToEncryptProgress CreateFileToEncryptProgress()
        //{
        //    return new FileToEncryptProgress();
        //}

        public string psInputFileName
        {
            set
            {
                if (value != prsInputFileName)
                {
                    // The value changed
                    prsInputFileName = value;
                    NotifyPropertyChanged("psInputFileName");
                }
            }
            get
            {
                return prsInputFileName;
            }
        }

        public int piProgress
        {
            set
            {
                if (value != priProgress)
                {
                    // The value changed
                    priProgress = value;
                    NotifyPropertyChanged("piProgress");
                }
            }
            get
            {
                return priProgress;
            }
        }
    }
}
