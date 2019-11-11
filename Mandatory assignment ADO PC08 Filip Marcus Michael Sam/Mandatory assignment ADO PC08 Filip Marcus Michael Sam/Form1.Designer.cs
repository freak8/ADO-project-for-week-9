namespace Mandatory_assignment_ADO_PC08_Filip_Marcus_Michael_Sam
{
    partial class Form1
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbCurrentStandingOfDebt = new System.Windows.Forms.ListBox();
            this.btnBuyARound = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRoundPrice = new System.Windows.Forms.TextBox();
            this.tbRoundBuyer = new System.Windows.Forms.TextBox();
            this.lbRoundInfo = new System.Windows.Forms.ListBox();
            this.btnMoveToListbox = new System.Windows.Forms.Button();
            this.btnMoveToRound = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveName = new System.Windows.Forms.Button();
            this.btnAddName = new System.Windows.Forms.Button();
            this.tbTeamMemberName = new System.Windows.Forms.TextBox();
            this.lbNameList = new System.Windows.Forms.ListBox();
            this.btnRemovePerson = new System.Windows.Forms.Button();
            this.btnAddDefaults = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lbCurrentStandingOfDebt);
            this.groupBox3.Controls.Add(this.btnBuyARound);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(512, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 388);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Balance Information";
            // 
            // lbCurrentStandingOfDebt
            // 
            this.lbCurrentStandingOfDebt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lbCurrentStandingOfDebt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbCurrentStandingOfDebt.ForeColor = System.Drawing.Color.White;
            this.lbCurrentStandingOfDebt.FormattingEnabled = true;
            this.lbCurrentStandingOfDebt.Location = new System.Drawing.Point(118, 33);
            this.lbCurrentStandingOfDebt.Name = "lbCurrentStandingOfDebt";
            this.lbCurrentStandingOfDebt.Size = new System.Drawing.Size(120, 208);
            this.lbCurrentStandingOfDebt.TabIndex = 1;
            // 
            // btnBuyARound
            // 
            this.btnBuyARound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnBuyARound.FlatAppearance.BorderSize = 0;
            this.btnBuyARound.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuyARound.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuyARound.Location = new System.Drawing.Point(6, 92);
            this.btnBuyARound.Name = "btnBuyARound";
            this.btnBuyARound.Size = new System.Drawing.Size(106, 93);
            this.btnBuyARound.TabIndex = 0;
            this.btnBuyARound.Text = "Buy a round";
            this.btnBuyARound.UseVisualStyleBackColor = false;
            this.btnBuyARound.Click += new System.EventHandler(this.btnBuyARoundArray_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbRoundPrice);
            this.groupBox2.Controls.Add(this.tbRoundBuyer);
            this.groupBox2.Controls.Add(this.lbRoundInfo);
            this.groupBox2.Controls.Add(this.btnMoveToListbox);
            this.groupBox2.Controls.Add(this.btnMoveToRound);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(262, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 388);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Round Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Round price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Round buyer";
            // 
            // tbRoundPrice
            // 
            this.tbRoundPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tbRoundPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRoundPrice.ForeColor = System.Drawing.Color.White;
            this.tbRoundPrice.Location = new System.Drawing.Point(87, 264);
            this.tbRoundPrice.Name = "tbRoundPrice";
            this.tbRoundPrice.Size = new System.Drawing.Size(151, 13);
            this.tbRoundPrice.TabIndex = 8;
            // 
            // tbRoundBuyer
            // 
            this.tbRoundBuyer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tbRoundBuyer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRoundBuyer.ForeColor = System.Drawing.Color.White;
            this.tbRoundBuyer.Location = new System.Drawing.Point(87, 238);
            this.tbRoundBuyer.Name = "tbRoundBuyer";
            this.tbRoundBuyer.Size = new System.Drawing.Size(151, 13);
            this.tbRoundBuyer.TabIndex = 7;
            // 
            // lbRoundInfo
            // 
            this.lbRoundInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lbRoundInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbRoundInfo.ForeColor = System.Drawing.Color.White;
            this.lbRoundInfo.FormattingEnabled = true;
            this.lbRoundInfo.Location = new System.Drawing.Point(87, 33);
            this.lbRoundInfo.Name = "lbRoundInfo";
            this.lbRoundInfo.Size = new System.Drawing.Size(151, 195);
            this.lbRoundInfo.TabIndex = 7;
            // 
            // btnMoveToListbox
            // 
            this.btnMoveToListbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnMoveToListbox.FlatAppearance.BorderSize = 0;
            this.btnMoveToListbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMoveToListbox.Location = new System.Drawing.Point(6, 112);
            this.btnMoveToListbox.Name = "btnMoveToListbox";
            this.btnMoveToListbox.Size = new System.Drawing.Size(75, 73);
            this.btnMoveToListbox.TabIndex = 1;
            this.btnMoveToListbox.Text = "<<";
            this.btnMoveToListbox.UseVisualStyleBackColor = false;
            this.btnMoveToListbox.Click += new System.EventHandler(this.btnMoveToListboxArray_Click);
            // 
            // btnMoveToRound
            // 
            this.btnMoveToRound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnMoveToRound.FlatAppearance.BorderSize = 0;
            this.btnMoveToRound.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMoveToRound.Location = new System.Drawing.Point(6, 33);
            this.btnMoveToRound.Name = "btnMoveToRound";
            this.btnMoveToRound.Size = new System.Drawing.Size(75, 73);
            this.btnMoveToRound.TabIndex = 0;
            this.btnMoveToRound.Text = ">>";
            this.btnMoveToRound.UseVisualStyleBackColor = false;
            this.btnMoveToRound.Click += new System.EventHandler(this.btnMoveToRoundArray_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnRemoveName);
            this.groupBox1.Controls.Add(this.btnAddName);
            this.groupBox1.Controls.Add(this.tbTeamMemberName);
            this.groupBox1.Controls.Add(this.lbNameList);
            this.groupBox1.Controls.Add(this.btnRemovePerson);
            this.groupBox1.Controls.Add(this.btnAddDefaults);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 388);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Team Members";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Team Member";
            // 
            // btnRemoveName
            // 
            this.btnRemoveName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnRemoveName.FlatAppearance.BorderSize = 0;
            this.btnRemoveName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveName.Location = new System.Drawing.Point(167, 359);
            this.btnRemoveName.Name = "btnRemoveName";
            this.btnRemoveName.Size = new System.Drawing.Size(71, 23);
            this.btnRemoveName.TabIndex = 5;
            this.btnRemoveName.Text = "Remove";
            this.btnRemoveName.UseVisualStyleBackColor = false;
            this.btnRemoveName.Click += new System.EventHandler(this.btnRemoveNameArray_Click);
            // 
            // btnAddName
            // 
            this.btnAddName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAddName.FlatAppearance.BorderSize = 0;
            this.btnAddName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddName.Location = new System.Drawing.Point(87, 359);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(74, 23);
            this.btnAddName.TabIndex = 4;
            this.btnAddName.Text = "Add";
            this.btnAddName.UseVisualStyleBackColor = false;
            this.btnAddName.Click += new System.EventHandler(this.btnAddNameArray_Click);
            // 
            // tbTeamMemberName
            // 
            this.tbTeamMemberName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tbTeamMemberName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTeamMemberName.ForeColor = System.Drawing.Color.White;
            this.tbTeamMemberName.Location = new System.Drawing.Point(87, 333);
            this.tbTeamMemberName.Name = "tbTeamMemberName";
            this.tbTeamMemberName.Size = new System.Drawing.Size(151, 13);
            this.tbTeamMemberName.TabIndex = 3;
            // 
            // lbNameList
            // 
            this.lbNameList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lbNameList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbNameList.ForeColor = System.Drawing.Color.White;
            this.lbNameList.FormattingEnabled = true;
            this.lbNameList.Location = new System.Drawing.Point(87, 33);
            this.lbNameList.Name = "lbNameList";
            this.lbNameList.Size = new System.Drawing.Size(151, 286);
            this.lbNameList.TabIndex = 2;
            // 
            // btnRemovePerson
            // 
            this.btnRemovePerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnRemovePerson.FlatAppearance.BorderSize = 0;
            this.btnRemovePerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemovePerson.Location = new System.Drawing.Point(6, 112);
            this.btnRemovePerson.Name = "btnRemovePerson";
            this.btnRemovePerson.Size = new System.Drawing.Size(75, 73);
            this.btnRemovePerson.TabIndex = 1;
            this.btnRemovePerson.Text = "Remove selected players";
            this.btnRemovePerson.UseVisualStyleBackColor = false;
            this.btnRemovePerson.Click += new System.EventHandler(this.btnRemovePersonArray_Click);
            // 
            // btnAddDefaults
            // 
            this.btnAddDefaults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAddDefaults.FlatAppearance.BorderSize = 0;
            this.btnAddDefaults.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddDefaults.Location = new System.Drawing.Point(6, 33);
            this.btnAddDefaults.Name = "btnAddDefaults";
            this.btnAddDefaults.Size = new System.Drawing.Size(75, 73);
            this.btnAddDefaults.TabIndex = 0;
            this.btnAddDefaults.Text = "Add defaults";
            this.btnAddDefaults.UseVisualStyleBackColor = false;
            this.btnAddDefaults.Click += new System.EventHandler(this.btnAddDefaultsArray_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(769, 411);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemovePerson;
        private System.Windows.Forms.Button btnAddDefaults;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.TextBox tbTeamMemberName;
        private System.Windows.Forms.ListBox lbNameList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveName;
        private System.Windows.Forms.Button btnMoveToListbox;
        private System.Windows.Forms.Button btnMoveToRound;
        private System.Windows.Forms.ListBox lbCurrentStandingOfDebt;
        private System.Windows.Forms.Button btnBuyARound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRoundPrice;
        private System.Windows.Forms.TextBox tbRoundBuyer;
        private System.Windows.Forms.ListBox lbRoundInfo;
        private System.Windows.Forms.Label label4;
    }
}

