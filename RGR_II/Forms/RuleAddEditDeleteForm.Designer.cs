namespace RGR_II.Forms
{
    partial class RuleAddEditDeleteForm
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
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage1_label1 = new System.Windows.Forms.Label();
            this.tabPage1_textBox_Name = new System.Windows.Forms.TextBox();
            this.tabPage1_button_Cancel = new System.Windows.Forms.Button();
            this.tabPage1_button_Accept = new System.Windows.Forms.Button();
            this.tabPage1_progressBar = new System.Windows.Forms.ProgressBar();
            this.tabPage1_groupBox = new System.Windows.Forms.GroupBox();
            this.tabPage1_radioButtonDNM = new System.Windows.Forms.RadioButton();
            this.tabPage1_radioButtonDLike = new System.Windows.Forms.RadioButton();
            this.tabPage1_radioButtonLike = new System.Windows.Forms.RadioButton();
            this.tabPage1_button_Back = new System.Windows.Forms.Button();
            this.tabPage1_button_Next = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage1_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.tabPage1);
            this.tabPage.Controls.Add(this.tabPage2);
            this.tabPage.Controls.Add(this.tabPage3);
            this.tabPage.Location = new System.Drawing.Point(0, 2);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(478, 318);
            this.tabPage.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabPage1_label1);
            this.tabPage1.Controls.Add(this.tabPage1_textBox_Name);
            this.tabPage1.Controls.Add(this.tabPage1_button_Cancel);
            this.tabPage1.Controls.Add(this.tabPage1_button_Accept);
            this.tabPage1.Controls.Add(this.tabPage1_progressBar);
            this.tabPage1.Controls.Add(this.tabPage1_groupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(470, 292);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавить";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage1_label1
            // 
            this.tabPage1_label1.AutoSize = true;
            this.tabPage1_label1.Location = new System.Drawing.Point(16, 22);
            this.tabPage1_label1.Name = "tabPage1_label1";
            this.tabPage1_label1.Size = new System.Drawing.Size(35, 13);
            this.tabPage1_label1.TabIndex = 5;
            this.tabPage1_label1.Text = "label1";
            // 
            // tabPage1_textBox_Name
            // 
            this.tabPage1_textBox_Name.Location = new System.Drawing.Point(16, 41);
            this.tabPage1_textBox_Name.Name = "tabPage1_textBox_Name";
            this.tabPage1_textBox_Name.Size = new System.Drawing.Size(441, 20);
            this.tabPage1_textBox_Name.TabIndex = 4;
            // 
            // tabPage1_button_Cancel
            // 
            this.tabPage1_button_Cancel.Location = new System.Drawing.Point(260, 260);
            this.tabPage1_button_Cancel.Name = "tabPage1_button_Cancel";
            this.tabPage1_button_Cancel.Size = new System.Drawing.Size(100, 23);
            this.tabPage1_button_Cancel.TabIndex = 3;
            this.tabPage1_button_Cancel.Text = "Cancel";
            this.tabPage1_button_Cancel.UseVisualStyleBackColor = true;
            this.tabPage1_button_Cancel.Click += new System.EventHandler(this.tabPage1_button_Cancel_Click);
            // 
            // tabPage1_button_Accept
            // 
            this.tabPage1_button_Accept.Location = new System.Drawing.Point(366, 260);
            this.tabPage1_button_Accept.Name = "tabPage1_button_Accept";
            this.tabPage1_button_Accept.Size = new System.Drawing.Size(91, 23);
            this.tabPage1_button_Accept.TabIndex = 2;
            this.tabPage1_button_Accept.Text = "Accept";
            this.tabPage1_button_Accept.UseVisualStyleBackColor = true;
            this.tabPage1_button_Accept.Click += new System.EventHandler(this.tabPage1_button_Accept_Click);
            // 
            // tabPage1_progressBar
            // 
            this.tabPage1_progressBar.Location = new System.Drawing.Point(9, 232);
            this.tabPage1_progressBar.Name = "tabPage1_progressBar";
            this.tabPage1_progressBar.Size = new System.Drawing.Size(454, 23);
            this.tabPage1_progressBar.TabIndex = 1;
            // 
            // tabPage1_groupBox
            // 
            this.tabPage1_groupBox.Controls.Add(this.tabPage1_radioButtonDNM);
            this.tabPage1_groupBox.Controls.Add(this.tabPage1_radioButtonDLike);
            this.tabPage1_groupBox.Controls.Add(this.tabPage1_radioButtonLike);
            this.tabPage1_groupBox.Controls.Add(this.tabPage1_button_Back);
            this.tabPage1_groupBox.Controls.Add(this.tabPage1_button_Next);
            this.tabPage1_groupBox.Location = new System.Drawing.Point(9, 72);
            this.tabPage1_groupBox.Name = "tabPage1_groupBox";
            this.tabPage1_groupBox.Size = new System.Drawing.Size(455, 153);
            this.tabPage1_groupBox.TabIndex = 0;
            this.tabPage1_groupBox.TabStop = false;
            this.tabPage1_groupBox.Text = "groupBox1";
            // 
            // tabPage1_radioButtonDNM
            // 
            this.tabPage1_radioButtonDNM.AutoSize = true;
            this.tabPage1_radioButtonDNM.Checked = true;
            this.tabPage1_radioButtonDNM.Location = new System.Drawing.Point(7, 83);
            this.tabPage1_radioButtonDNM.Name = "tabPage1_radioButtonDNM";
            this.tabPage1_radioButtonDNM.Size = new System.Drawing.Size(100, 17);
            this.tabPage1_radioButtonDNM.TabIndex = 4;
            this.tabPage1_radioButtonDNM.TabStop = true;
            this.tabPage1_radioButtonDNM.Text = "Does not matter";
            this.tabPage1_radioButtonDNM.UseVisualStyleBackColor = true;
            // 
            // tabPage1_radioButtonDLike
            // 
            this.tabPage1_radioButtonDLike.AutoSize = true;
            this.tabPage1_radioButtonDLike.Location = new System.Drawing.Point(7, 59);
            this.tabPage1_radioButtonDLike.Name = "tabPage1_radioButtonDLike";
            this.tabPage1_radioButtonDLike.Size = new System.Drawing.Size(67, 17);
            this.tabPage1_radioButtonDLike.TabIndex = 3;
            this.tabPage1_radioButtonDLike.Text = "Dont like";
            this.tabPage1_radioButtonDLike.UseVisualStyleBackColor = true;
            // 
            // tabPage1_radioButtonLike
            // 
            this.tabPage1_radioButtonLike.AutoSize = true;
            this.tabPage1_radioButtonLike.Location = new System.Drawing.Point(7, 35);
            this.tabPage1_radioButtonLike.Name = "tabPage1_radioButtonLike";
            this.tabPage1_radioButtonLike.Size = new System.Drawing.Size(45, 17);
            this.tabPage1_radioButtonLike.TabIndex = 2;
            this.tabPage1_radioButtonLike.Text = "Like";
            this.tabPage1_radioButtonLike.UseVisualStyleBackColor = true;
            // 
            // tabPage1_button_Back
            // 
            this.tabPage1_button_Back.Location = new System.Drawing.Point(251, 114);
            this.tabPage1_button_Back.Name = "tabPage1_button_Back";
            this.tabPage1_button_Back.Size = new System.Drawing.Size(100, 22);
            this.tabPage1_button_Back.TabIndex = 1;
            this.tabPage1_button_Back.Text = "Back";
            this.tabPage1_button_Back.UseVisualStyleBackColor = true;
            this.tabPage1_button_Back.Click += new System.EventHandler(this.tabPage1_button_Back_Click);
            // 
            // tabPage1_button_Next
            // 
            this.tabPage1_button_Next.Location = new System.Drawing.Point(357, 114);
            this.tabPage1_button_Next.Name = "tabPage1_button_Next";
            this.tabPage1_button_Next.Size = new System.Drawing.Size(92, 23);
            this.tabPage1_button_Next.TabIndex = 0;
            this.tabPage1_button_Next.Text = "Next";
            this.tabPage1_button_Next.UseVisualStyleBackColor = true;
            this.tabPage1_button_Next.Click += new System.EventHandler(this.tabPage1_button_Next_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(470, 292);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Редактировать";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(470, 292);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Удалить";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // RuleAddEditDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 319);
            this.Controls.Add(this.tabPage);
            this.Name = "RuleAddEditDeleteForm";
            this.Text = "RuleAddEditDeleteForm";
            this.Load += new System.EventHandler(this.RuleAddEditDeleteForm_Load);
            this.tabPage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage1_groupBox.ResumeLayout(false);
            this.tabPage1_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label tabPage1_label1;
        private System.Windows.Forms.TextBox tabPage1_textBox_Name;
        private System.Windows.Forms.Button tabPage1_button_Cancel;
        private System.Windows.Forms.Button tabPage1_button_Accept;
        private System.Windows.Forms.ProgressBar tabPage1_progressBar;
        private System.Windows.Forms.GroupBox tabPage1_groupBox;
        private System.Windows.Forms.RadioButton tabPage1_radioButtonDNM;
        private System.Windows.Forms.RadioButton tabPage1_radioButtonDLike;
        private System.Windows.Forms.RadioButton tabPage1_radioButtonLike;
        private System.Windows.Forms.Button tabPage1_button_Back;
        private System.Windows.Forms.Button tabPage1_button_Next;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}