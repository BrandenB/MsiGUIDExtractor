namespace MsiGUIDExtractor
{
    partial class MsiGUIDExtractor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fromFileGroupBox = new GroupBox();
            extractFromFileBtn = new Button();
            msiFileLocationLabel = new Label();
            msiFileLocationTextBox = new TextBox();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            fromRegistryGroupBox = new GroupBox();
            label9 = new Label();
            findBtn = new Button();
            dataGrid = new DataGridView();
            Name = new DataGridViewTextBoxColumn();
            Type = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            appNameLabel = new Label();
            label3 = new Label();
            applicatioNameTextBox = new TextBox();
            msiGUIDLabel = new Label();
            msiGUIDTextBox = new TextBox();
            msiInstallerStrLabel = new Label();
            msiInstallerStrTextBox = new TextBox();
            msiInstallerStrSlLabel = new Label();
            msiInstallerStrSlTextBox = new TextBox();
            msiUnInSlLabel = new Label();
            msiUnInstallerStrSlTextBox = new TextBox();
            msiUnStrLabel = new Label();
            msiUnInstallerStrTextBox = new TextBox();
            infoGroupBox = new GroupBox();
            fileDiag = new OpenFileDialog();
            fromFileGroupBox.SuspendLayout();
            menuStrip.SuspendLayout();
            fromRegistryGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            infoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // fromFileGroupBox
            // 
            fromFileGroupBox.Controls.Add(extractFromFileBtn);
            fromFileGroupBox.Controls.Add(msiFileLocationLabel);
            fromFileGroupBox.Controls.Add(msiFileLocationTextBox);
            fromFileGroupBox.Location = new Point(12, 36);
            fromFileGroupBox.Name = "fromFileGroupBox";
            fromFileGroupBox.Size = new Size(382, 165);
            fromFileGroupBox.TabIndex = 0;
            fromFileGroupBox.TabStop = false;
            fromFileGroupBox.Text = "Extract From File";
            // 
            // extractFromFileBtn
            // 
            extractFromFileBtn.Location = new Point(207, 82);
            extractFromFileBtn.Name = "extractFromFileBtn";
            extractFromFileBtn.Size = new Size(169, 37);
            extractFromFileBtn.TabIndex = 13;
            extractFromFileBtn.Text = "Extract";
            extractFromFileBtn.UseVisualStyleBackColor = true;
            extractFromFileBtn.Click += extractFromFileBtn_Click;
            // 
            // msiFileLocationLabel
            // 
            msiFileLocationLabel.AutoSize = true;
            msiFileLocationLabel.Location = new Point(6, 35);
            msiFileLocationLabel.Name = "msiFileLocationLabel";
            msiFileLocationLabel.Size = new Size(102, 15);
            msiFileLocationLabel.TabIndex = 1;
            msiFileLocationLabel.Text = "MSI File Location*";
            // 
            // msiFileLocationTextBox
            // 
            msiFileLocationTextBox.BorderStyle = BorderStyle.FixedSingle;
            msiFileLocationTextBox.Location = new Point(6, 53);
            msiFileLocationTextBox.Name = "msiFileLocationTextBox";
            msiFileLocationTextBox.Size = new Size(370, 23);
            msiFileLocationTextBox.TabIndex = 0;
            msiFileLocationTextBox.Enter += msiFileLocationTextBox_Enter;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1227, 24);
            menuStrip.TabIndex = 1;
            menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(103, 22);
            closeToolStripMenuItem.Text = "Close";
            // 
            // fromRegistryGroupBox
            // 
            fromRegistryGroupBox.Controls.Add(label9);
            fromRegistryGroupBox.Controls.Add(findBtn);
            fromRegistryGroupBox.Controls.Add(dataGrid);
            fromRegistryGroupBox.Controls.Add(appNameLabel);
            fromRegistryGroupBox.Controls.Add(label3);
            fromRegistryGroupBox.Controls.Add(applicatioNameTextBox);
            fromRegistryGroupBox.Location = new Point(400, 36);
            fromRegistryGroupBox.Name = "fromRegistryGroupBox";
            fromRegistryGroupBox.Size = new Size(814, 654);
            fromRegistryGroupBox.TabIndex = 1;
            fromRegistryGroupBox.TabStop = false;
            fromRegistryGroupBox.Text = "Extract From Registry";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 150);
            label9.Name = "label9";
            label9.Size = new Size(115, 15);
            label9.TabIndex = 17;
            label9.Text = "Registry Information";
            // 
            // findBtn
            // 
            findBtn.Location = new Point(658, 82);
            findBtn.Name = "findBtn";
            findBtn.Size = new Size(150, 34);
            findBtn.TabIndex = 14;
            findBtn.Text = "Find";
            findBtn.UseVisualStyleBackColor = true;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { Name, Type, Data });
            dataGrid.Location = new Point(6, 168);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowTemplate.Height = 25;
            dataGrid.Size = new Size(802, 480);
            dataGrid.TabIndex = 16;
            // 
            // Name
            // 
            Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Name.HeaderText = "Name";
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // Type
            // 
            Type.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Type.HeaderText = "Type";
            Type.Name = "Type";
            Type.ReadOnly = true;
            // 
            // Data
            // 
            Data.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Data.HeaderText = "Data";
            Data.Name = "Data";
            Data.ReadOnly = true;
            // 
            // appNameLabel
            // 
            appNameLabel.AutoSize = true;
            appNameLabel.Location = new Point(6, 35);
            appNameLabel.Name = "appNameLabel";
            appNameLabel.Size = new Size(111, 15);
            appNameLabel.TabIndex = 15;
            appNameLabel.Text = "Application Name *";
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(6, 128);
            label3.Name = "label3";
            label3.Size = new Size(803, 2);
            label3.TabIndex = 4;
            // 
            // applicatioNameTextBox
            // 
            applicatioNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            applicatioNameTextBox.Location = new Point(6, 53);
            applicatioNameTextBox.Name = "applicatioNameTextBox";
            applicatioNameTextBox.Size = new Size(802, 23);
            applicatioNameTextBox.TabIndex = 14;
            // 
            // msiGUIDLabel
            // 
            msiGUIDLabel.AutoSize = true;
            msiGUIDLabel.Location = new Point(6, 30);
            msiGUIDLabel.Name = "msiGUIDLabel";
            msiGUIDLabel.Size = new Size(57, 15);
            msiGUIDLabel.TabIndex = 3;
            msiGUIDLabel.Text = "MSI GUID";
            // 
            // msiGUIDTextBox
            // 
            msiGUIDTextBox.BorderStyle = BorderStyle.FixedSingle;
            msiGUIDTextBox.Location = new Point(6, 48);
            msiGUIDTextBox.Name = "msiGUIDTextBox";
            msiGUIDTextBox.ReadOnly = true;
            msiGUIDTextBox.Size = new Size(370, 23);
            msiGUIDTextBox.TabIndex = 2;
            // 
            // msiInstallerStrLabel
            // 
            msiInstallerStrLabel.AutoSize = true;
            msiInstallerStrLabel.Location = new Point(6, 86);
            msiInstallerStrLabel.Name = "msiInstallerStrLabel";
            msiInstallerStrLabel.Size = new Size(131, 15);
            msiInstallerStrLabel.TabIndex = 6;
            msiInstallerStrLabel.Text = "MsiExec Installer  String";
            // 
            // msiInstallerStrTextBox
            // 
            msiInstallerStrTextBox.BorderStyle = BorderStyle.FixedSingle;
            msiInstallerStrTextBox.Location = new Point(6, 104);
            msiInstallerStrTextBox.Name = "msiInstallerStrTextBox";
            msiInstallerStrTextBox.ReadOnly = true;
            msiInstallerStrTextBox.Size = new Size(370, 23);
            msiInstallerStrTextBox.TabIndex = 5;
            // 
            // msiInstallerStrSlLabel
            // 
            msiInstallerStrSlLabel.AutoSize = true;
            msiInstallerStrSlLabel.Location = new Point(6, 143);
            msiInstallerStrSlLabel.Name = "msiInstallerStrSlLabel";
            msiInstallerStrSlLabel.Size = new Size(168, 15);
            msiInstallerStrSlLabel.TabIndex = 8;
            msiInstallerStrSlLabel.Text = "MsiExec Installer String (Silent)";
            // 
            // msiInstallerStrSlTextBox
            // 
            msiInstallerStrSlTextBox.BorderStyle = BorderStyle.FixedSingle;
            msiInstallerStrSlTextBox.Location = new Point(6, 161);
            msiInstallerStrSlTextBox.Name = "msiInstallerStrSlTextBox";
            msiInstallerStrSlTextBox.ReadOnly = true;
            msiInstallerStrSlTextBox.Size = new Size(370, 23);
            msiInstallerStrSlTextBox.TabIndex = 7;
            // 
            // msiUnInSlLabel
            // 
            msiUnInSlLabel.AutoSize = true;
            msiUnInSlLabel.Location = new Point(6, 254);
            msiUnInSlLabel.Name = "msiUnInSlLabel";
            msiUnInSlLabel.Size = new Size(183, 15);
            msiUnInSlLabel.TabIndex = 12;
            msiUnInSlLabel.Text = "MsiExec Uninstaller String (Silent)";
            // 
            // msiUnInstallerStrSlTextBox
            // 
            msiUnInstallerStrSlTextBox.BorderStyle = BorderStyle.FixedSingle;
            msiUnInstallerStrSlTextBox.Location = new Point(6, 272);
            msiUnInstallerStrSlTextBox.Name = "msiUnInstallerStrSlTextBox";
            msiUnInstallerStrSlTextBox.ReadOnly = true;
            msiUnInstallerStrSlTextBox.Size = new Size(370, 23);
            msiUnInstallerStrSlTextBox.TabIndex = 11;
            // 
            // msiUnStrLabel
            // 
            msiUnStrLabel.AutoSize = true;
            msiUnStrLabel.Location = new Point(6, 197);
            msiUnStrLabel.Name = "msiUnStrLabel";
            msiUnStrLabel.Size = new Size(143, 15);
            msiUnStrLabel.TabIndex = 10;
            msiUnStrLabel.Text = "MsiExec Uninstaller String";
            // 
            // msiUnInstallerStrTextBox
            // 
            msiUnInstallerStrTextBox.BorderStyle = BorderStyle.FixedSingle;
            msiUnInstallerStrTextBox.Location = new Point(6, 215);
            msiUnInstallerStrTextBox.Name = "msiUnInstallerStrTextBox";
            msiUnInstallerStrTextBox.ReadOnly = true;
            msiUnInstallerStrTextBox.Size = new Size(370, 23);
            msiUnInstallerStrTextBox.TabIndex = 9;
            // 
            // infoGroupBox
            // 
            infoGroupBox.Controls.Add(msiGUIDLabel);
            infoGroupBox.Controls.Add(msiInstallerStrSlTextBox);
            infoGroupBox.Controls.Add(msiUnInSlLabel);
            infoGroupBox.Controls.Add(msiInstallerStrLabel);
            infoGroupBox.Controls.Add(msiInstallerStrSlLabel);
            infoGroupBox.Controls.Add(msiUnInstallerStrSlTextBox);
            infoGroupBox.Controls.Add(msiInstallerStrTextBox);
            infoGroupBox.Controls.Add(msiUnInstallerStrTextBox);
            infoGroupBox.Controls.Add(msiUnStrLabel);
            infoGroupBox.Controls.Add(msiGUIDTextBox);
            infoGroupBox.Location = new Point(12, 207);
            infoGroupBox.Name = "infoGroupBox";
            infoGroupBox.Size = new Size(382, 323);
            infoGroupBox.TabIndex = 14;
            infoGroupBox.TabStop = false;
            infoGroupBox.Text = "MSI Information";
            // 
            // fileDiag
            // 
            fileDiag.FileName = "fileDiag";
            // 
            // MsiGUIDExtractor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 702);
            Controls.Add(infoGroupBox);
            Controls.Add(fromRegistryGroupBox);
            Controls.Add(fromFileGroupBox);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            MaximumSize = new Size(1243, 741);
            MinimumSize = new Size(1243, 741);
            Name = "MsiGUIDExtractor";
            Text = "MsiGUIDExtractor";
            Load += MsiGUIDExtractor_Load;
            fromFileGroupBox.ResumeLayout(false);
            fromFileGroupBox.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            fromRegistryGroupBox.ResumeLayout(false);
            fromRegistryGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            infoGroupBox.ResumeLayout(false);
            infoGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox fromFileGroupBox;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private GroupBox fromRegistryGroupBox;
        private Label label3;
        private Label msiGUIDLabel;
        private TextBox msiGUIDTextBox;
        private Label msiFileLocationLabel;
        private TextBox msiFileLocationTextBox;
        private Label msiInstallerStrSlLabel;
        private TextBox msiInstallerStrSlTextBox;
        private Label msiInstallerStrLabel;
        private TextBox msiInstallerStrTextBox;
        private Label msiUnInSlLabel;
        private TextBox msiUnInstallerStrSlTextBox;
        private Label msiUnStrLabel;
        private TextBox msiUnInstallerStrTextBox;
        private Button extractFromFileBtn;
        private Label appNameLabel;
        private TextBox applicatioNameTextBox;
        private GroupBox infoGroupBox;
        private DataGridView dataGrid;
        private Label label9;
        private Button findBtn;
        private OpenFileDialog fileDiag;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Data;
    }
}