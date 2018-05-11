namespace UE4BuildTools
{
    partial class BuildDistribution
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Process = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_AddProject = new System.Windows.Forms.Button();
            this.btn_Source = new System.Windows.Forms.Button();
            this.btn_Destination = new System.Windows.Forms.Button();
            this.tb_SourcePath = new System.Windows.Forms.TextBox();
            this.tb_DestinationPath = new System.Windows.Forms.TextBox();
            this.cb_ProjectList = new System.Windows.Forms.ComboBox();
            this.tb_ProjectVersion_Release = new System.Windows.Forms.TextBox();
            this.lbl_ProjectVersion = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.lbl_ProjectName = new System.Windows.Forms.Label();
            this.tb_ProjectName = new System.Windows.Forms.TextBox();
            this.cb_IncrementVersion = new System.Windows.Forms.CheckBox();
            this.btn_RemoveProject = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.myBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.pb_Process = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ProjectVersion_Major = new System.Windows.Forms.TextBox();
            this.tb_ProjectVersion_Minor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_SaveCurrentProject = new System.Windows.Forms.Button();
            this.tb_ProjectSource = new System.Windows.Forms.TextBox();
            this.btn_Project = new System.Windows.Forms.Button();
            this.cb_ShippingBuild = new System.Windows.Forms.CheckBox();
            this.cb_DifferingName = new System.Windows.Forms.CheckBox();
            this.tb_DifferingName = new System.Windows.Forms.TextBox();
            this.lc_WorkingCircle = new MRG.Controls.UI.LoadingCircle();
            this.SuspendLayout();
            // 
            // btn_Process
            // 
            this.btn_Process.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Process.Location = new System.Drawing.Point(497, 191);
            this.btn_Process.Name = "btn_Process";
            this.btn_Process.Size = new System.Drawing.Size(90, 39);
            this.btn_Process.TabIndex = 0;
            this.btn_Process.Text = "Process";
            this.btn_Process.UseVisualStyleBackColor = true;
            this.btn_Process.Click += new System.EventHandler(this.btn_Process_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Exit.Location = new System.Drawing.Point(20, 191);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(90, 39);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_AddProject
            // 
            this.btn_AddProject.Location = new System.Drawing.Point(453, 10);
            this.btn_AddProject.Name = "btn_AddProject";
            this.btn_AddProject.Size = new System.Drawing.Size(134, 23);
            this.btn_AddProject.TabIndex = 2;
            this.btn_AddProject.Text = "Add New Project";
            this.btn_AddProject.UseVisualStyleBackColor = true;
            this.btn_AddProject.Click += new System.EventHandler(this.btn_AddProject_Click);
            // 
            // btn_Source
            // 
            this.btn_Source.Location = new System.Drawing.Point(512, 137);
            this.btn_Source.Name = "btn_Source";
            this.btn_Source.Size = new System.Drawing.Size(75, 23);
            this.btn_Source.TabIndex = 3;
            this.btn_Source.Text = "Source";
            this.btn_Source.UseVisualStyleBackColor = true;
            this.btn_Source.Click += new System.EventHandler(this.btn_Source_Click);
            // 
            // btn_Destination
            // 
            this.btn_Destination.Location = new System.Drawing.Point(512, 163);
            this.btn_Destination.Name = "btn_Destination";
            this.btn_Destination.Size = new System.Drawing.Size(75, 23);
            this.btn_Destination.TabIndex = 4;
            this.btn_Destination.Text = "Destination";
            this.btn_Destination.UseVisualStyleBackColor = true;
            this.btn_Destination.Click += new System.EventHandler(this.btn_Destination_Click);
            // 
            // tb_SourcePath
            // 
            this.tb_SourcePath.Location = new System.Drawing.Point(20, 139);
            this.tb_SourcePath.Name = "tb_SourcePath";
            this.tb_SourcePath.Size = new System.Drawing.Size(486, 20);
            this.tb_SourcePath.TabIndex = 5;
            // 
            // tb_DestinationPath
            // 
            this.tb_DestinationPath.Location = new System.Drawing.Point(20, 165);
            this.tb_DestinationPath.Name = "tb_DestinationPath";
            this.tb_DestinationPath.Size = new System.Drawing.Size(486, 20);
            this.tb_DestinationPath.TabIndex = 6;
            // 
            // cb_ProjectList
            // 
            this.cb_ProjectList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ProjectList.FormattingEnabled = true;
            this.cb_ProjectList.Location = new System.Drawing.Point(23, 10);
            this.cb_ProjectList.Name = "cb_ProjectList";
            this.cb_ProjectList.Size = new System.Drawing.Size(230, 21);
            this.cb_ProjectList.TabIndex = 7;
            this.cb_ProjectList.SelectedIndexChanged += new System.EventHandler(this.cb_ProjectList_SelectedIndexChanged);
            // 
            // tb_ProjectVersion_Release
            // 
            this.tb_ProjectVersion_Release.Location = new System.Drawing.Point(108, 37);
            this.tb_ProjectVersion_Release.Name = "tb_ProjectVersion_Release";
            this.tb_ProjectVersion_Release.Size = new System.Drawing.Size(28, 20);
            this.tb_ProjectVersion_Release.TabIndex = 8;
            this.tb_ProjectVersion_Release.Text = "0";
            this.tb_ProjectVersion_Release.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_ProjectVersion
            // 
            this.lbl_ProjectVersion.AutoSize = true;
            this.lbl_ProjectVersion.Location = new System.Drawing.Point(24, 40);
            this.lbl_ProjectVersion.Name = "lbl_ProjectVersion";
            this.lbl_ProjectVersion.Size = new System.Drawing.Size(78, 13);
            this.lbl_ProjectVersion.TabIndex = 9;
            this.lbl_ProjectVersion.Text = "Project Version";
            // 
            // lbl_ProjectName
            // 
            this.lbl_ProjectName.AutoSize = true;
            this.lbl_ProjectName.Location = new System.Drawing.Point(24, 66);
            this.lbl_ProjectName.Name = "lbl_ProjectName";
            this.lbl_ProjectName.Size = new System.Drawing.Size(71, 13);
            this.lbl_ProjectName.TabIndex = 10;
            this.lbl_ProjectName.Text = "Project Name";
            // 
            // tb_ProjectName
            // 
            this.tb_ProjectName.Location = new System.Drawing.Point(108, 62);
            this.tb_ProjectName.Name = "tb_ProjectName";
            this.tb_ProjectName.Size = new System.Drawing.Size(149, 20);
            this.tb_ProjectName.TabIndex = 11;
            // 
            // cb_IncrementVersion
            // 
            this.cb_IncrementVersion.AutoSize = true;
            this.cb_IncrementVersion.Location = new System.Drawing.Point(261, 40);
            this.cb_IncrementVersion.Name = "cb_IncrementVersion";
            this.cb_IncrementVersion.Size = new System.Drawing.Size(111, 17);
            this.cb_IncrementVersion.TabIndex = 12;
            this.cb_IncrementVersion.Text = "Increment Version";
            this.cb_IncrementVersion.UseVisualStyleBackColor = true;
            this.cb_IncrementVersion.CheckedChanged += new System.EventHandler(this.cb_IncrementVersion_CheckedChanged);
            // 
            // btn_RemoveProject
            // 
            this.btn_RemoveProject.Location = new System.Drawing.Point(453, 35);
            this.btn_RemoveProject.Name = "btn_RemoveProject";
            this.btn_RemoveProject.Size = new System.Drawing.Size(134, 23);
            this.btn_RemoveProject.TabIndex = 13;
            this.btn_RemoveProject.Text = "Remove Current Project";
            this.btn_RemoveProject.UseVisualStyleBackColor = true;
            this.btn_RemoveProject.Click += new System.EventHandler(this.btn_RemoveProject_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // myBackgroundWorker
            // 
            this.myBackgroundWorker.WorkerReportsProgress = true;
            this.myBackgroundWorker.WorkerSupportsCancellation = true;
            this.myBackgroundWorker.DoWork += myBackgroundWorker_DoWork;
            this.myBackgroundWorker.ProgressChanged += myBackgroundWorker_ProgressChanged;
            this.myBackgroundWorker.RunWorkerCompleted += myBackgroundWorker_RunWorkerCompleted;
            // 
            // pb_Process
            // 
            this.pb_Process.Location = new System.Drawing.Point(116, 191);
            this.pb_Process.Name = "pb_Process";
            this.pb_Process.Size = new System.Drawing.Size(375, 23);
            this.pb_Process.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pb_Process.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = ".";
            // 
            // tb_ProjectVersion_Major
            // 
            this.tb_ProjectVersion_Major.Location = new System.Drawing.Point(154, 37);
            this.tb_ProjectVersion_Major.Name = "tb_ProjectVersion_Major";
            this.tb_ProjectVersion_Major.Size = new System.Drawing.Size(28, 20);
            this.tb_ProjectVersion_Major.TabIndex = 16;
            this.tb_ProjectVersion_Major.Text = "0";
            this.tb_ProjectVersion_Major.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_ProjectVersion_Minor
            // 
            this.tb_ProjectVersion_Minor.Location = new System.Drawing.Point(200, 37);
            this.tb_ProjectVersion_Minor.Name = "tb_ProjectVersion_Minor";
            this.tb_ProjectVersion_Minor.Size = new System.Drawing.Size(28, 20);
            this.tb_ProjectVersion_Minor.TabIndex = 18;
            this.tb_ProjectVersion_Minor.Text = "0";
            this.tb_ProjectVersion_Minor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = ".";
            // 
            // btn_SaveCurrentProject
            // 
            this.btn_SaveCurrentProject.Location = new System.Drawing.Point(453, 60);
            this.btn_SaveCurrentProject.Name = "btn_SaveCurrentProject";
            this.btn_SaveCurrentProject.Size = new System.Drawing.Size(134, 23);
            this.btn_SaveCurrentProject.TabIndex = 19;
            this.btn_SaveCurrentProject.Text = "Save Current Project";
            this.btn_SaveCurrentProject.UseVisualStyleBackColor = true;
            this.btn_SaveCurrentProject.Click += new System.EventHandler(this.btn_SaveCurrentProject_Click);
            // 
            // tb_ProjectSource
            // 
            this.tb_ProjectSource.Location = new System.Drawing.Point(20, 113);
            this.tb_ProjectSource.Name = "tb_ProjectSource";
            this.tb_ProjectSource.Size = new System.Drawing.Size(486, 20);
            this.tb_ProjectSource.TabIndex = 21;
            this.tb_ProjectSource.Text = "D:\\Git\\";
            // 
            // btn_Project
            // 
            this.btn_Project.Location = new System.Drawing.Point(512, 111);
            this.btn_Project.Name = "btn_Project";
            this.btn_Project.Size = new System.Drawing.Size(75, 23);
            this.btn_Project.TabIndex = 20;
            this.btn_Project.Text = "Project";
            this.btn_Project.UseVisualStyleBackColor = true;
            this.btn_Project.Click += new System.EventHandler(this.btn_Project_Click);
            // 
            // cb_ShippingBuild
            // 
            this.cb_ShippingBuild.AutoSize = true;
            this.cb_ShippingBuild.Location = new System.Drawing.Point(261, 12);
            this.cb_ShippingBuild.Name = "cb_ShippingBuild";
            this.cb_ShippingBuild.Size = new System.Drawing.Size(93, 17);
            this.cb_ShippingBuild.TabIndex = 22;
            this.cb_ShippingBuild.Text = "Shipping Build";
            this.cb_ShippingBuild.UseVisualStyleBackColor = true;
            // 
            // cb_DifferingName
            // 
            this.cb_DifferingName.AutoSize = true;
            this.cb_DifferingName.Location = new System.Drawing.Point(6, 90);
            this.cb_DifferingName.Name = "cb_DifferingName";
            this.cb_DifferingName.Size = new System.Drawing.Size(96, 17);
            this.cb_DifferingName.TabIndex = 23;
            this.cb_DifferingName.Text = "Differing Name";
            this.cb_DifferingName.UseVisualStyleBackColor = true;
            this.cb_DifferingName.CheckedChanged += new System.EventHandler(this.cb_DifferingName_CheckedChanged);
            // 
            // tb_DifferingName
            // 
            this.tb_DifferingName.Enabled = false;
            this.tb_DifferingName.Location = new System.Drawing.Point(108, 88);
            this.tb_DifferingName.Name = "tb_DifferingName";
            this.tb_DifferingName.Size = new System.Drawing.Size(149, 20);
            this.tb_DifferingName.TabIndex = 24;
            // 
            // lc_WorkingCircle
            // 
            this.lc_WorkingCircle.Active = true;
            this.lc_WorkingCircle.Color = System.Drawing.Color.RoyalBlue;
            this.lc_WorkingCircle.InnerCircleRadius = 5;
            this.lc_WorkingCircle.Location = new System.Drawing.Point(263, 60);
            this.lc_WorkingCircle.Name = "lc_WorkingCircle";
            this.lc_WorkingCircle.NumberSpoke = 12;
            this.lc_WorkingCircle.OuterCircleRadius = 11;
            this.lc_WorkingCircle.RotationSpeed = 100;
            this.lc_WorkingCircle.Size = new System.Drawing.Size(75, 52);
            this.lc_WorkingCircle.SpokeThickness = 2;
            this.lc_WorkingCircle.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.MacOSX;
            this.lc_WorkingCircle.TabIndex = 25;
            this.lc_WorkingCircle.Text = "WorkingCircle";
            this.lc_WorkingCircle.Visible = false;
            // 
            // BuildDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 235);
            this.Controls.Add(this.lc_WorkingCircle);
            this.Controls.Add(this.tb_DifferingName);
            this.Controls.Add(this.cb_DifferingName);
            this.Controls.Add(this.cb_ShippingBuild);
            this.Controls.Add(this.tb_ProjectSource);
            this.Controls.Add(this.btn_Project);
            this.Controls.Add(this.btn_SaveCurrentProject);
            this.Controls.Add(this.tb_ProjectVersion_Minor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ProjectVersion_Major);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_Process);
            this.Controls.Add(this.btn_RemoveProject);
            this.Controls.Add(this.cb_IncrementVersion);
            this.Controls.Add(this.tb_ProjectName);
            this.Controls.Add(this.lbl_ProjectName);
            this.Controls.Add(this.lbl_ProjectVersion);
            this.Controls.Add(this.tb_ProjectVersion_Release);
            this.Controls.Add(this.cb_ProjectList);
            this.Controls.Add(this.tb_DestinationPath);
            this.Controls.Add(this.tb_SourcePath);
            this.Controls.Add(this.btn_Destination);
            this.Controls.Add(this.btn_Source);
            this.Controls.Add(this.btn_AddProject);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Process);
            this.Name = "BuildDistribution";
            this.Text = "UE4 Build File Drop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Process;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_AddProject;
        private System.Windows.Forms.Button btn_Source;
        private System.Windows.Forms.Button btn_Destination;
        private System.Windows.Forms.TextBox tb_SourcePath;
        private System.Windows.Forms.TextBox tb_DestinationPath;
        private System.Windows.Forms.ComboBox cb_ProjectList;
        private System.Windows.Forms.TextBox tb_ProjectVersion_Release;
        private System.Windows.Forms.Label lbl_ProjectVersion;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label lbl_ProjectName;
        private System.Windows.Forms.TextBox tb_ProjectName;
        private System.Windows.Forms.CheckBox cb_IncrementVersion;
        private System.Windows.Forms.Button btn_RemoveProject;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.ComponentModel.BackgroundWorker myBackgroundWorker;
        private System.Windows.Forms.ProgressBar pb_Process;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ProjectVersion_Major;
        private System.Windows.Forms.TextBox tb_ProjectVersion_Minor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_SaveCurrentProject;
        private System.Windows.Forms.TextBox tb_ProjectSource;
        private System.Windows.Forms.Button btn_Project;
        private System.Windows.Forms.CheckBox cb_ShippingBuild;
        private System.Windows.Forms.CheckBox cb_DifferingName;
        private System.Windows.Forms.TextBox tb_DifferingName;
        private MRG.Controls.UI.LoadingCircle lc_WorkingCircle;
    }
}

