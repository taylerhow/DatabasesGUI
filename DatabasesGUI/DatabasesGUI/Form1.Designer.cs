namespace DatabasesGUI
{
    partial class MainPage
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.storedProcedureParameterTextBox = new System.Windows.Forms.TextBox();
            this.storedProcedureComboBox = new System.Windows.Forms.ComboBox();
            this.runStoredProcedureButton = new System.Windows.Forms.Button();
            this.viewDataTabControl = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.horsesTableView = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.jockeysTableView = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.racesTableView = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tracksTableView = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.ridesTableView = new System.Windows.Forms.DataGridView();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.gamblersTableView = new System.Windows.Forms.DataGridView();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.betsTableView = new System.Windows.Forms.DataGridView();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.storedProcedureResultsTableView = new System.Windows.Forms.DataGridView();
            this.refreshDataButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.horseRacingDataSet = new DatabasesGUI.HorseRacingDataSet();
            this.horseRacingDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.viewDataTabControl.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horsesTableView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jockeysTableView)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racesTableView)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tracksTableView)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ridesTableView)).BeginInit();
            this.tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamblersTableView)).BeginInit();
            this.tabPage9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betsTableView)).BeginInit();
            this.tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storedProcedureResultsTableView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseRacingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseRacingDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage11);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(917, 520);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.storedProcedureParameterTextBox);
            this.tabPage1.Controls.Add(this.storedProcedureComboBox);
            this.tabPage1.Controls.Add(this.runStoredProcedureButton);
            this.tabPage1.Controls.Add(this.viewDataTabControl);
            this.tabPage1.Controls.Add(this.refreshDataButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(909, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // storedProcedureParameterTextBox
            // 
            this.storedProcedureParameterTextBox.Location = new System.Drawing.Point(382, 23);
            this.storedProcedureParameterTextBox.Name = "storedProcedureParameterTextBox";
            this.storedProcedureParameterTextBox.Size = new System.Drawing.Size(228, 22);
            this.storedProcedureParameterTextBox.TabIndex = 9;
            // 
            // storedProcedureComboBox
            // 
            this.storedProcedureComboBox.FormattingEnabled = true;
            this.storedProcedureComboBox.Location = new System.Drawing.Point(151, 23);
            this.storedProcedureComboBox.Name = "storedProcedureComboBox";
            this.storedProcedureComboBox.Size = new System.Drawing.Size(210, 24);
            this.storedProcedureComboBox.TabIndex = 8;
            this.storedProcedureComboBox.SelectedIndexChanged += new System.EventHandler(this.storedProcedureComboBox_SelectedIndexChanged);
            // 
            // runStoredProcedureButton
            // 
            this.runStoredProcedureButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.runStoredProcedureButton.Location = new System.Drawing.Point(625, 6);
            this.runStoredProcedureButton.Name = "runStoredProcedureButton";
            this.runStoredProcedureButton.Size = new System.Drawing.Size(161, 56);
            this.runStoredProcedureButton.TabIndex = 7;
            this.runStoredProcedureButton.Text = "Run Stored Procedure";
            this.runStoredProcedureButton.UseVisualStyleBackColor = true;
            this.runStoredProcedureButton.Click += new System.EventHandler(this.runStoredProcedureButton_Click);
            // 
            // viewDataTabControl
            // 
            this.viewDataTabControl.Controls.Add(this.tabPage3);
            this.viewDataTabControl.Controls.Add(this.tabPage4);
            this.viewDataTabControl.Controls.Add(this.tabPage5);
            this.viewDataTabControl.Controls.Add(this.tabPage6);
            this.viewDataTabControl.Controls.Add(this.tabPage7);
            this.viewDataTabControl.Controls.Add(this.tabPage8);
            this.viewDataTabControl.Controls.Add(this.tabPage9);
            this.viewDataTabControl.Controls.Add(this.tabPage10);
            this.viewDataTabControl.Location = new System.Drawing.Point(7, 69);
            this.viewDataTabControl.Name = "viewDataTabControl";
            this.viewDataTabControl.SelectedIndex = 0;
            this.viewDataTabControl.Size = new System.Drawing.Size(875, 384);
            this.viewDataTabControl.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.horsesTableView);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(867, 355);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Horses";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // horsesTableView
            // 
            this.horsesTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.horsesTableView.Location = new System.Drawing.Point(0, 0);
            this.horsesTableView.Name = "horsesTableView";
            this.horsesTableView.RowTemplate.Height = 24;
            this.horsesTableView.Size = new System.Drawing.Size(867, 359);
            this.horsesTableView.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.jockeysTableView);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(867, 355);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Jockeys";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // jockeysTableView
            // 
            this.jockeysTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jockeysTableView.Location = new System.Drawing.Point(0, 0);
            this.jockeysTableView.Name = "jockeysTableView";
            this.jockeysTableView.RowTemplate.Height = 24;
            this.jockeysTableView.Size = new System.Drawing.Size(867, 355);
            this.jockeysTableView.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.racesTableView);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(867, 355);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Races";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // racesTableView
            // 
            this.racesTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.racesTableView.Location = new System.Drawing.Point(0, 0);
            this.racesTableView.Name = "racesTableView";
            this.racesTableView.RowTemplate.Height = 24;
            this.racesTableView.Size = new System.Drawing.Size(871, 359);
            this.racesTableView.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.tracksTableView);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(867, 355);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Tracks";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tracksTableView
            // 
            this.tracksTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tracksTableView.Location = new System.Drawing.Point(0, 0);
            this.tracksTableView.Name = "tracksTableView";
            this.tracksTableView.RowTemplate.Height = 24;
            this.tracksTableView.Size = new System.Drawing.Size(871, 355);
            this.tracksTableView.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.ridesTableView);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(867, 355);
            this.tabPage7.TabIndex = 3;
            this.tabPage7.Text = "Rides";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // ridesTableView
            // 
            this.ridesTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ridesTableView.Location = new System.Drawing.Point(-4, 0);
            this.ridesTableView.Name = "ridesTableView";
            this.ridesTableView.RowTemplate.Height = 24;
            this.ridesTableView.Size = new System.Drawing.Size(875, 359);
            this.ridesTableView.TabIndex = 0;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.gamblersTableView);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(867, 355);
            this.tabPage8.TabIndex = 4;
            this.tabPage8.Text = "Gamblers";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // gamblersTableView
            // 
            this.gamblersTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gamblersTableView.Location = new System.Drawing.Point(0, 3);
            this.gamblersTableView.Name = "gamblersTableView";
            this.gamblersTableView.RowTemplate.Height = 24;
            this.gamblersTableView.Size = new System.Drawing.Size(871, 356);
            this.gamblersTableView.TabIndex = 0;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.betsTableView);
            this.tabPage9.Location = new System.Drawing.Point(4, 25);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(867, 355);
            this.tabPage9.TabIndex = 5;
            this.tabPage9.Text = "Bets";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // betsTableView
            // 
            this.betsTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.betsTableView.Location = new System.Drawing.Point(0, 0);
            this.betsTableView.Name = "betsTableView";
            this.betsTableView.RowTemplate.Height = 24;
            this.betsTableView.Size = new System.Drawing.Size(871, 359);
            this.betsTableView.TabIndex = 0;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.storedProcedureResultsTableView);
            this.tabPage10.Location = new System.Drawing.Point(4, 25);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(867, 355);
            this.tabPage10.TabIndex = 6;
            this.tabPage10.Text = "Sproc Results";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // storedProcedureResultsTableView
            // 
            this.storedProcedureResultsTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storedProcedureResultsTableView.Location = new System.Drawing.Point(0, 0);
            this.storedProcedureResultsTableView.Name = "storedProcedureResultsTableView";
            this.storedProcedureResultsTableView.RowTemplate.Height = 24;
            this.storedProcedureResultsTableView.Size = new System.Drawing.Size(867, 359);
            this.storedProcedureResultsTableView.TabIndex = 0;
            // 
            // refreshDataButton
            // 
            this.refreshDataButton.Location = new System.Drawing.Point(7, 7);
            this.refreshDataButton.Name = "refreshDataButton";
            this.refreshDataButton.Size = new System.Drawing.Size(137, 56);
            this.refreshDataButton.TabIndex = 5;
            this.refreshDataButton.Text = "Refresh Data";
            this.refreshDataButton.UseVisualStyleBackColor = true;
            this.refreshDataButton.Click += new System.EventHandler(this.refreshDataButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(909, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Insert Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage11
            // 
            this.tabPage11.Location = new System.Drawing.Point(4, 25);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(909, 491);
            this.tabPage11.TabIndex = 2;
            this.tabPage11.Text = "Update Data";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // horseRacingDataSet
            // 
            this.horseRacingDataSet.DataSetName = "HorseRacingDataSet";
            this.horseRacingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // horseRacingDataSetBindingSource
            // 
            this.horseRacingDataSetBindingSource.DataSource = this.horseRacingDataSet;
            this.horseRacingDataSetBindingSource.Position = 0;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 516);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainPage";
            this.Text = "Horse Racing Databse";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.viewDataTabControl.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.horsesTableView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.jockeysTableView)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.racesTableView)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tracksTableView)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ridesTableView)).EndInit();
            this.tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gamblersTableView)).EndInit();
            this.tabPage9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.betsTableView)).EndInit();
            this.tabPage10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.storedProcedureResultsTableView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseRacingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseRacingDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource horseRacingDataSetBindingSource;
        private HorseRacingDataSet horseRacingDataSet;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox storedProcedureParameterTextBox;
        private System.Windows.Forms.ComboBox storedProcedureComboBox;
        private System.Windows.Forms.Button runStoredProcedureButton;
        private System.Windows.Forms.TabControl viewDataTabControl;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView horsesTableView;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView jockeysTableView;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView racesTableView;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView tracksTableView;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView ridesTableView;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.DataGridView gamblersTableView;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.DataGridView betsTableView;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.DataGridView storedProcedureResultsTableView;
        private System.Windows.Forms.Button refreshDataButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage11;
    }
}

