﻿namespace Digital_Diary.Presentation_Layer
{
    partial class EventManagement
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
            this.loadEentListGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addEventButton = new System.Windows.Forms.Button();
            this.addEventImportanceComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addEventDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.addEventDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addEventTitleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchEventGridView = new System.Windows.Forms.DataGridView();
            this.SearchEventTitleTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loadEentListGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchEventGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // loadEentListGridView
            // 
            this.loadEentListGridView.AllowUserToAddRows = false;
            this.loadEentListGridView.AllowUserToDeleteRows = false;
            this.loadEentListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadEentListGridView.Location = new System.Drawing.Point(405, 49);
            this.loadEentListGridView.Name = "loadEentListGridView";
            this.loadEentListGridView.ReadOnly = true;
            this.loadEentListGridView.Size = new System.Drawing.Size(372, 171);
            this.loadEentListGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of Events";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addEventButton);
            this.groupBox1.Controls.Add(this.addEventImportanceComboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.addEventDateTimePicker);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.addEventDescriptionTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.addEventTitleTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 283);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Event";
            // 
            // addEventButton
            // 
            this.addEventButton.Location = new System.Drawing.Point(127, 241);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(193, 31);
            this.addEventButton.TabIndex = 11;
            this.addEventButton.Text = "Add Event";
            this.addEventButton.UseVisualStyleBackColor = true;
            this.addEventButton.Click += new System.EventHandler(this.addEventButton_Click);
            // 
            // addEventImportanceComboBox
            // 
            this.addEventImportanceComboBox.FormattingEnabled = true;
            this.addEventImportanceComboBox.Items.AddRange(new object[] {
            "High",
            "Moderate",
            "Less"});
            this.addEventImportanceComboBox.Location = new System.Drawing.Point(127, 195);
            this.addEventImportanceComboBox.Name = "addEventImportanceComboBox";
            this.addEventImportanceComboBox.Size = new System.Drawing.Size(193, 27);
            this.addEventImportanceComboBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Importance";
            // 
            // addEventDateTimePicker
            // 
            this.addEventDateTimePicker.Location = new System.Drawing.Point(127, 80);
            this.addEventDateTimePicker.Name = "addEventDateTimePicker";
            this.addEventDateTimePicker.Size = new System.Drawing.Size(193, 26);
            this.addEventDateTimePicker.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Event Description";
            // 
            // addEventDescriptionTextBox
            // 
            this.addEventDescriptionTextBox.Location = new System.Drawing.Point(127, 112);
            this.addEventDescriptionTextBox.Multiline = true;
            this.addEventDescriptionTextBox.Name = "addEventDescriptionTextBox";
            this.addEventDescriptionTextBox.Size = new System.Drawing.Size(193, 64);
            this.addEventDescriptionTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // addEventTitleTextBox
            // 
            this.addEventTitleTextBox.Location = new System.Drawing.Point(127, 40);
            this.addEventTitleTextBox.Name = "addEventTitleTextBox";
            this.addEventTitleTextBox.Size = new System.Drawing.Size(193, 26);
            this.addEventTitleTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Event Title";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchEventGridView);
            this.groupBox2.Controls.Add(this.SearchEventTitleTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(405, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 244);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Event Search";
            // 
            // searchEventGridView
            // 
            this.searchEventGridView.AllowUserToAddRows = false;
            this.searchEventGridView.AllowUserToDeleteRows = false;
            this.searchEventGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchEventGridView.Location = new System.Drawing.Point(38, 64);
            this.searchEventGridView.Name = "searchEventGridView";
            this.searchEventGridView.ReadOnly = true;
            this.searchEventGridView.Size = new System.Drawing.Size(323, 159);
            this.searchEventGridView.TabIndex = 14;
            // 
            // SearchEventTitleTextBox
            // 
            this.SearchEventTitleTextBox.Location = new System.Drawing.Point(140, 28);
            this.SearchEventTitleTextBox.Name = "SearchEventTitleTextBox";
            this.SearchEventTitleTextBox.Size = new System.Drawing.Size(193, 25);
            this.SearchEventTitleTextBox.TabIndex = 13;
            this.SearchEventTitleTextBox.TextChanged += new System.EventHandler(this.SearchEventTitleTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Event Title";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EventManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadEentListGridView);
            this.Name = "EventManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Event / Search by Title";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EventManagement_FormClosing);
            this.Load += new System.EventHandler(this.EventManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadEentListGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchEventGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView loadEentListGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.ComboBox addEventImportanceComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker addEventDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addEventDescriptionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addEventTitleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView searchEventGridView;
        private System.Windows.Forms.TextBox SearchEventTitleTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}