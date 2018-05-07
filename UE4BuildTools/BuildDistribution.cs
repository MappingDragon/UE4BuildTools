using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Security.AccessControl;

namespace UE4BuildTools
{
    public partial class BuildDistribution : Form
    {
        // Variables to Hold onto
        Projects LoadedProjects = new Projects();
        CustomFileCopier FileCopier = new CustomFileCopier("", "");
        string NewReleaseVersion;

        public BuildDistribution()
        {
            InitializeComponent();
            BuildFolders();
            LoadXMLData();
            PopulateForm();
        }

        #region Tool Functions
        // Builds folders necessary if they do not exist
        public void BuildFolders()
        {
            if (!Directory.Exists("Resources"))
                System.IO.Directory.CreateDirectory("Resources");
            if (!Directory.Exists("Bats"))
                System.IO.Directory.CreateDirectory("Bats");
        }

        // Deserializes the data to the object
        private void LoadXMLData()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Projects));
            using (StreamReader reader = new StreamReader("Resources\\Config.xml"))
            {
                LoadedProjects = (Projects)serializer.Deserialize(reader);
            }

            // Sort the Data
            LoadedProjects.Project = LoadedProjects.Project.OrderBy(x => x.Name).ToList();
            
        }

        // Serializes the data to the XML
        private void SaveXMLData()
        {
            // Sort the Data
            LoadedProjects.Project = LoadedProjects.Project.OrderBy(x => x.Name).ToList();

            XmlSerializer serializer = new XmlSerializer(typeof(Projects));
            Stream fs = new FileStream("Resources\\Config.xml", FileMode.Create);
            using (XmlTextWriter writer = new XmlTextWriter(fs, Encoding.Unicode))
            {
                writer.Formatting = Formatting.Indented;
                writer.Indentation = 4;
                serializer.Serialize(writer, LoadedProjects);
            }
        }

        // Populates the Form
        private void PopulateForm()
        {
            if(LoadedProjects != null)
            {
                if(LoadedProjects.Project != null)
                {
                    foreach (Project item in LoadedProjects.Project)
                    {
                        cb_ProjectList.Items.Add(item.Name);
                        cb_ProjectList.SelectedIndex = 0;
                    }
                }
            }
        }

        // Toggles the form to prevent editing of fields
        private void ToggleForm(bool bln_Enable)
        {
            btn_Exit.Enabled = bln_Enable;
            btn_Process.Enabled = bln_Enable;
            btn_AddProject.Enabled = bln_Enable;
            btn_RemoveProject.Enabled = bln_Enable;
            btn_Source.Enabled = bln_Enable;
            btn_Destination.Enabled = bln_Enable;
            cb_ProjectList.Enabled = bln_Enable;
            tb_ProjectName.Enabled = bln_Enable;
            tb_ProjectVersion_Release.Enabled = bln_Enable;
            tb_ProjectVersion_Major.Enabled = bln_Enable;
            tb_ProjectVersion_Minor.Enabled = bln_Enable;
            tb_SourcePath.Enabled = bln_Enable;
            tb_DestinationPath.Enabled = bln_Enable;
            cb_IncrementVersion.Enabled = bln_Enable;
            pb_Process.Visible = !bln_Enable;
        }

        // Recursive function to copy entire directories
        private static void DirectoryCopy(string sourceDirName, string destDirName, BackgroundWorker worker)
        {
            if (worker.CancellationPending) return;

            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();
            FileInfo[] files = dir.GetFiles();
            int percentage;
            int fileIndex = 0;
            int fileCount = dir.GetFiles("*.*", SearchOption.AllDirectories).Length;

            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destDirName, file.Name);
                file.CopyTo(tempPath, true);
                fileIndex += 1;
                percentage = (fileIndex) * 100 / fileCount;
                worker.ReportProgress(percentage);
            }

            foreach (DirectoryInfo subDir in dirs)
            {
                string tempPath = Path.Combine(destDirName, subDir.Name);
                DirectoryCopy(subDir.FullName, tempPath, worker);
            }
        }
        #endregion

        #region Background Worker Functions
        // Functions that handle file copy in a new thread and reports progress to main form
        private void myBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            ToggleForm(false);
            BackgroundWorker worker = sender as BackgroundWorker;
            if (File.Exists(tb_SourcePath.Text) && worker != null)
            {
                string newDestPath = System.IO.Path.Combine(tb_DestinationPath.Text, tb_ProjectName.Text + "_" + tb_ProjectVersion_Release.Text);
                string newSourcePath = Path.GetDirectoryName(tb_SourcePath.Text);

                pb_Process.Minimum = 0;
                pb_Process.Maximum = 100;

                DirectoryCopy(newSourcePath, newDestPath, worker);

            }
        }

        void myBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pb_Process.Value = e.ProgressPercentage;
        }

        void myBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ToggleForm(true);
            MessageBox.Show("Done");
        }
        #endregion

        #region Form Button Functionality
        // Begin the process of deploying the build
        private void btn_Process_Click(object sender, EventArgs e)
        {
            //Ensure we have the path's needed.
            if(tb_DestinationPath.TextLength <= 0 || tb_SourcePath.TextLength <= 0)
            {
                System.Windows.Forms.MessageBox.Show("Please ensure both Destination and Source folders have been selected.");
                return;
            }

            ToggleForm(false);

            //Save State
            SaveXMLData();

            // Make new folder with appropiate naming convention
            string newDestPath = System.IO.Path.Combine(tb_DestinationPath.Text, tb_ProjectName.Text + "_" + tb_ProjectVersion_Release.Text);
            string newSourcePath = Path.GetDirectoryName(tb_SourcePath.Text);
            if (!Directory.Exists(newDestPath))
            {
                DirectorySecurity securityRules = new DirectorySecurity();
                securityRules.AddAccessRule(new FileSystemAccessRule("Users", FileSystemRights.FullControl, AccessControlType.Allow));
                System.IO.Directory.CreateDirectory(newDestPath, securityRules);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Destination Folder already exists!");
            }

            // Copy necessary files
            if (System.IO.File.Exists(tb_SourcePath.Text))
            {
                //Copy over Game Files
                //DirectoryCopy(newSourcePath, newDestPath);
                myBackgroundWorker.RunWorkerAsync();

                // Move the other dependent files
                if (File.Exists("Resources\\CustomButtonEvents.json"))
                    File.Copy("Resources\\CustomButtonEvents.json", newDestPath + "\\CustomButtonEvents.json", true);
                else
                    System.Windows.Forms.MessageBox.Show("Couldn't find CustomButtonEvents.json in Resources Folder. Did not Copy.");

                if (File.Exists("Bats\\" + tb_ProjectName.Text + ".bat"))
                    File.Copy("Bats\\" + tb_ProjectName.Text + ".bat", newDestPath + "\\" + tb_ProjectName.Text + ".bat", true);
                else
                    System.Windows.Forms.MessageBox.Show("Couldn't find " + tb_ProjectName.Text + ".bat in Bats Folder. Did not Copy.");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Source file doesn't exist!");
                return;
            }

        }

        // Set the source file
        private void btn_Source_Click(object sender, EventArgs e)
        {
            //Show the folder dialog box
            DialogResult result = openFileDialog.ShowDialog();
            if(result == DialogResult.OK)
                tb_SourcePath.Text = openFileDialog.FileName;
        }

        // Set the destination file
        private void btn_Destination_Click(object sender, EventArgs e)
        {
            //Show the folder dialog box
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
                tb_DestinationPath.Text = folderBrowserDialog.SelectedPath;
        }

        // Add new project to list
        private void btn_AddProject_Click(object sender, EventArgs e)
        {
            if(LoadedProjects != null)
            {
                Project temp = new Project();
                temp.Name = tb_ProjectName.Text;
                temp.Version = tb_ProjectVersion_Release.Text + '.' + tb_ProjectVersion_Major.Text + '.' + tb_ProjectVersion_Minor.Text;
                temp.Source = tb_SourcePath.Text;
                temp.Destination = tb_DestinationPath.Text;
                bool bln_Found = false;

                // Check to see if project already exists, if so, update
                if(cb_ProjectList.Items.Count > 0)
                {
                    foreach (var item in cb_ProjectList.Items)
                    {
                        if (String.Compare(temp.Name, cb_ProjectList.SelectedItem.ToString()) == 0)
                        {
                            foreach (Project project in LoadedProjects.Project)
                            {
                                if (string.Compare(temp.Name, project.Name) == 0)
                                {
                                    LoadedProjects.Project.Remove(project);
                                    LoadedProjects.Project.Add(temp);
                                    cb_ProjectList.Items.Add(temp.Name);
                                    cb_ProjectList.SelectedIndex = cb_ProjectList.Items.Count - 1;
                                    bln_Found = true;
                                    MessageBox.Show("Project Updated Successfully");
                                    return;
                                }
                            }
                        }
                    }
                }

                // Project doesn't exist already, add it
                if(!bln_Found)
                {
                    LoadedProjects.Project.Add(temp);
                    cb_ProjectList.Items.Add(temp.Name);
                    cb_ProjectList.SelectedIndex = cb_ProjectList.Items.Count - 1;
                    MessageBox.Show("Project Added Successfully");
                }
            }
        }

        // Remove currently selected project
        private void btn_RemoveProject_Click(object sender, EventArgs e)
        {
            if(cb_ProjectList.Items != null)
            {
                if (cb_ProjectList.SelectedIndex >= 0)
                {
                    foreach (Project project in LoadedProjects.Project)
                    {
                        if (String.Compare(cb_ProjectList.SelectedItem.ToString(), project.Name) == 0)
                        {
                            LoadedProjects.Project.Remove(project);
                            cb_ProjectList.Items.RemoveAt(cb_ProjectList.SelectedIndex);
                            cb_ProjectList.SelectedIndex = 0;
                            MessageBox.Show("Project Removed Successfully");
                            return;
                        }
                    }
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            //Gracefully Quit with a save.
            SaveXMLData();
            this.Close();
        }

        private void btn_SaveCurrentProject_Click(object sender, EventArgs e)
        {
            SaveXMLData();
            MessageBox.Show("Project Saved");
        }
        #endregion

        #region Form Index Changed Events
        private void cb_IncrementVersion_CheckedChanged(object sender, EventArgs e)
        {
            // Increment Version Number
            if (cb_IncrementVersion.Checked)
            {
                // Increment the minor version number
                if(tb_ProjectVersion_Release.Text.Length > 0)
                {
                    tb_ProjectVersion_Minor.Enabled = false;
                    int MinorVersion = Int16.Parse(tb_ProjectVersion_Minor.Text);
                    MinorVersion += 1;

                    if (MinorVersion < 10)
                        tb_ProjectVersion_Minor.Text += "0" + MinorVersion.ToString();
                    else
                        tb_ProjectVersion_Minor.Text += MinorVersion.ToString();
                }
            }

            // Reset Version Number to Previous
            if (!cb_IncrementVersion.Checked)
            {
                tb_ProjectVersion_Release.Enabled = true;
                if (cb_ProjectList.Items != null)
                    if (cb_ProjectList.SelectedIndex >= 0)
                        foreach (Project project in LoadedProjects.Project)
                            if (String.Compare(cb_ProjectList.SelectedItem.ToString(), project.Name) == 0)
                            {
                                string[] versions = project.Version.Split('.');
                                if(versions != null)
                                {
                                    for (int i = 0; i < versions.Length; i++)
                                    {
                                        switch (i)
                                        {
                                            case 0:
                                                tb_ProjectVersion_Release.Text = versions[i];
                                                break;
                                            case 1:
                                                tb_ProjectVersion_Major.Text = versions[i];
                                                break;
                                            case 2:
                                                tb_ProjectVersion_Minor.Text = versions[i];
                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                }
                                return;
                            }
            }
        }

        // Populate the form properly based on user selection.
        private void cb_ProjectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_ProjectList.Items != null)
            {
                if (cb_ProjectList.Items != null)
                    if (cb_ProjectList.SelectedIndex >= 0)
                        foreach (Project project in LoadedProjects.Project)
                            if (String.Compare(cb_ProjectList.SelectedItem.ToString(), project.Name) == 0)
                            {
                                string[] versions = project.Version.Split('.');
                                if (versions != null)
                                {
                                    for (int i = 0; i < versions.Length; i++)
                                    {
                                        switch (i)
                                        {
                                            case 0:
                                                tb_ProjectVersion_Release.Text = versions[i];
                                                break;
                                            case 1:
                                                tb_ProjectVersion_Major.Text = versions[i];
                                                break;
                                            case 2:
                                                tb_ProjectVersion_Minor.Text = versions[i];
                                                break;
                                            default:
                                                break;
                                        }
                                    }
                                }
                                tb_ProjectName.Text = project.Name;
                                tb_ProjectName.Text = project.Name;
                                tb_SourcePath.Text = project.Source;
                                tb_DestinationPath.Text = project.Destination;
                                return;
                            }
            }
        }
        #endregion
    }
}
