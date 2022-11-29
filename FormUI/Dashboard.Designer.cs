namespace FormUI
{
    partial class Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.allPeopleDropdown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yearsExperiencePicker = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.filteredPeopleList = new System.Windows.Forms.ListBox();
            this.updatePersonButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yearsExperiencePicker)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Linq 101 Demo";
            // 
            // allPeopleDropdown
            // 
            this.allPeopleDropdown.FormattingEnabled = true;
            this.allPeopleDropdown.Location = new System.Drawing.Point(121, 209);
            this.allPeopleDropdown.Name = "allPeopleDropdown";
            this.allPeopleDropdown.Size = new System.Drawing.Size(121, 23);
            this.allPeopleDropdown.TabIndex = 1;
            this.allPeopleDropdown.SelectedIndexChanged += new System.EventHandler(this.allPeopleDropdown_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "All People";
            // 
            // yearsExperiencePicker
            // 
            this.yearsExperiencePicker.Location = new System.Drawing.Point(121, 305);
            this.yearsExperiencePicker.Name = "yearsExperiencePicker";
            this.yearsExperiencePicker.Size = new System.Drawing.Size(120, 23);
            this.yearsExperiencePicker.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Years Experience";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Filtered List";
            // 
            // filteredPeopleList
            // 
            this.filteredPeopleList.FormattingEnabled = true;
            this.filteredPeopleList.ItemHeight = 15;
            this.filteredPeopleList.Location = new System.Drawing.Point(341, 209);
            this.filteredPeopleList.Name = "filteredPeopleList";
            this.filteredPeopleList.Size = new System.Drawing.Size(180, 244);
            this.filteredPeopleList.TabIndex = 6;
            // 
            // updatePersonButton
            // 
            this.updatePersonButton.Location = new System.Drawing.Point(121, 385);
            this.updatePersonButton.Name = "updatePersonButton";
            this.updatePersonButton.Size = new System.Drawing.Size(75, 23);
            this.updatePersonButton.TabIndex = 7;
            this.updatePersonButton.Text = "Update";
            this.updatePersonButton.UseVisualStyleBackColor = true;
            this.updatePersonButton.Click += new System.EventHandler(this.updatePersonButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 614);
            this.Controls.Add(this.updatePersonButton);
            this.Controls.Add(this.filteredPeopleList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.yearsExperiencePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.allPeopleDropdown);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.yearsExperiencePicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown yearsExperiencePicker;
        private System.Windows.Forms.Button updatePersonButton;
        private System.Windows.Forms.ComboBox allPeopleDropdown;
        private System.Windows.Forms.ListBox filteredPeopleList;
    }
}