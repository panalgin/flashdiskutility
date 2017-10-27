using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashDiskUtility
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EventSink.Error += EventSink_Error;
            EventSink.Written += EventSink_Written;

            DetectDriveInfos();
        }

        private void EventSink_Written(FileInfo info)
        {
            UpdateOutput(string.Format("Başarılı: [{0} - gizlendi]", info.Name));
        }

        private void EventSink_Error(string message)
        {
            UpdateOutput(string.Format("Hata - {0}", message));
        }

        private void UpdateOutput(string v)
        {
            this.Output_Box.BeginInvoke((MethodInvoker)delegate ()
            {
                this.Output_Box.Text = v + Environment.NewLine + this.Output_Box.Text;

                if (this.Output_Box.Text.Length > 1024)
                    this.Output_Box.Text = this.Output_Box.Text.Substring(0, 1023);   
            });
        }

        private void DetectDriveInfos()
        {
            this.AvailableDrives_Combo.Items.Clear();
            
            DriveInfo[] drives = DriveInfo.GetDrives();

            drives.All(delegate (DriveInfo info)
            {
                AppendToComboBox(info);

                return true;
            });

            if (this.AvailableDrives_Combo.Items.Count > 0)
                this.AvailableDrives_Combo.SelectedIndex = 0;
        }

        private void AppendToComboBox(DriveInfo info)
        {
            try
            {
                if (info.IsReady && (info.DriveFormat == "FAT32" || info.DriveFormat == "FAT"))
                {
                    if (!this.AvailableDrives_Combo.Items.Contains(info))
                    {
                        string value = string.Format("{0} - {1} - {2}", info.Name, info.DriveType, info.VolumeLabel);
                        this.AvailableDrives_Combo.Items.Add(value);
                    }
                }
            }
            catch (Exception ex)
            {
                EventSink.InvokeError(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetectDriveInfos();
        }

        private void Browse_Button_Click(object sender, EventArgs e)
        {
            if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.SourcePath_Box.Text = FolderBrowserDialog.SelectedPath;
            }
        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            if (this.AvailableDrives_Combo.SelectedItem != null)
            {
                string sourcePath = this.SourcePath_Box.Text;
                string destinationPath = this.AvailableDrives_Combo.SelectedItem.ToString().Split('-')[0].Replace(" ", "");

                if (ValidatePaths(sourcePath, destinationPath))
                {
                    var files = Directory.EnumerateFiles(sourcePath, "*.*", SearchOption.TopDirectoryOnly).Where(q => q.EndsWith(".mp3"));

                    if (files.Count() == 0)
                        EventSink.InvokeError("Kaynak klasörde uygun mp3 dosyası bulunamadı.");
                    else
                    {
                        FormatDrive(destinationPath);

                        files.All(delegate (string file)
                        {
                            var handle = new FileInfo(file);
                            var savePath = Path.Combine(destinationPath, handle.Name);
                            handle = handle.CopyTo(savePath, true);

                            File.SetAttributes(handle.FullName, FileAttributes.System | FileAttributes.ReadOnly | FileAttributes.Hidden);

                            EventSink.InvokeWritten(handle);

                            return true;
                        });
                    }
                }
            }
        }

        private void FormatDrive(string destinationPath)
        {
            /*var drive = DriveInfo.GetDrives().Where(q => q.Name == destinationPath).FirstOrDefault();

            if (drive != null)
            */
        }

        bool ValidatePaths(string sourcePath, string destinationPath)
        {
            bool result = true;

            if (string.IsNullOrEmpty(sourcePath))
            {
                EventSink.InvokeError("Kaynak klasörü seçmediniz.");
                result = false;
            }

            if (string.IsNullOrEmpty(destinationPath))
            {
                EventSink.InvokeError("Hedef flash diski seçmediniz.");
                result = false;
            }

            if (!Directory.Exists(sourcePath))
            {
                EventSink.InvokeError("Kaynak klasör mevcut değil.");
                result = false;
            }

            if (!Directory.Exists(destinationPath))
            {
                EventSink.InvokeError("Hedef flash disk yolu mevcut değil.");
                result = false;
            }

            return result;
        }
    }
}
