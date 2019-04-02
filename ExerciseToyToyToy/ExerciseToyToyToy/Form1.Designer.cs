namespace ExerciseToyToyToy
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
            this.listAvailableToys = new System.Windows.Forms.ListBox();
            this.listToys = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupSpeed = new System.Windows.Forms.GroupBox();
            this.buttonDownSpeed = new System.Windows.Forms.Button();
            this.buttonUpSpeed = new System.Windows.Forms.Button();
            this.textSpeed = new System.Windows.Forms.TextBox();
            this.groupAltitute = new System.Windows.Forms.GroupBox();
            this.buttonDownAltitute = new System.Windows.Forms.Button();
            this.textAltitute = new System.Windows.Forms.TextBox();
            this.buttonUpAltitute = new System.Windows.Forms.Button();
            this.groupDepth = new System.Windows.Forms.GroupBox();
            this.buttonDownDepth = new System.Windows.Forms.Button();
            this.textDepth = new System.Windows.Forms.TextBox();
            this.buttonUpDepth = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.upgradeButton = new System.Windows.Forms.Button();
            this.groupSpeed.SuspendLayout();
            this.groupAltitute.SuspendLayout();
            this.groupDepth.SuspendLayout();
            this.SuspendLayout();
            // 
            // listAvailableToys
            // 
            this.listAvailableToys.FormattingEnabled = true;
            this.listAvailableToys.Items.AddRange(new object[] {
            "Car",
            "Plane",
            "Submarine",
            "Computer"});
            this.listAvailableToys.Location = new System.Drawing.Point(12, 3);
            this.listAvailableToys.Name = "listAvailableToys";
            this.listAvailableToys.Size = new System.Drawing.Size(168, 173);
            this.listAvailableToys.TabIndex = 0;
            // 
            // listToys
            // 
            this.listToys.FormattingEnabled = true;
            this.listToys.Location = new System.Drawing.Point(329, 3);
            this.listToys.Name = "listToys";
            this.listToys.Size = new System.Drawing.Size(168, 303);
            this.listToys.TabIndex = 0;
            this.listToys.SelectedIndexChanged += new System.EventHandler(this.listToys_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(208, 130);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupSpeed
            // 
            this.groupSpeed.Controls.Add(this.buttonDownSpeed);
            this.groupSpeed.Controls.Add(this.buttonUpSpeed);
            this.groupSpeed.Controls.Add(this.textSpeed);
            this.groupSpeed.Location = new System.Drawing.Point(522, 28);
            this.groupSpeed.Name = "groupSpeed";
            this.groupSpeed.Size = new System.Drawing.Size(349, 72);
            this.groupSpeed.TabIndex = 2;
            this.groupSpeed.TabStop = false;
            this.groupSpeed.Text = "Speed";
            // 
            // buttonDownSpeed
            // 
            this.buttonDownSpeed.Location = new System.Drawing.Point(241, 32);
            this.buttonDownSpeed.Name = "buttonDownSpeed";
            this.buttonDownSpeed.Size = new System.Drawing.Size(75, 20);
            this.buttonDownSpeed.TabIndex = 1;
            this.buttonDownSpeed.Text = "-";
            this.buttonDownSpeed.UseVisualStyleBackColor = true;
            this.buttonDownSpeed.Click += new System.EventHandler(this.buttonDownSpeed_Click);
            // 
            // buttonUpSpeed
            // 
            this.buttonUpSpeed.Location = new System.Drawing.Point(136, 32);
            this.buttonUpSpeed.Name = "buttonUpSpeed";
            this.buttonUpSpeed.Size = new System.Drawing.Size(75, 20);
            this.buttonUpSpeed.TabIndex = 1;
            this.buttonUpSpeed.Text = "+";
            this.buttonUpSpeed.UseVisualStyleBackColor = true;
            this.buttonUpSpeed.Click += new System.EventHandler(this.buttonUpSpeed_Click);
            // 
            // textSpeed
            // 
            this.textSpeed.Location = new System.Drawing.Point(19, 32);
            this.textSpeed.Name = "textSpeed";
            this.textSpeed.Size = new System.Drawing.Size(88, 20);
            this.textSpeed.TabIndex = 0;
            this.textSpeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSpeed_KeyPress);
            // 
            // groupAltitute
            // 
            this.groupAltitute.Controls.Add(this.buttonDownAltitute);
            this.groupAltitute.Controls.Add(this.textAltitute);
            this.groupAltitute.Controls.Add(this.buttonUpAltitute);
            this.groupAltitute.Location = new System.Drawing.Point(522, 130);
            this.groupAltitute.Name = "groupAltitute";
            this.groupAltitute.Size = new System.Drawing.Size(349, 72);
            this.groupAltitute.TabIndex = 3;
            this.groupAltitute.TabStop = false;
            this.groupAltitute.Text = "Altitute";
            // 
            // buttonDownAltitute
            // 
            this.buttonDownAltitute.Location = new System.Drawing.Point(241, 30);
            this.buttonDownAltitute.Name = "buttonDownAltitute";
            this.buttonDownAltitute.Size = new System.Drawing.Size(75, 20);
            this.buttonDownAltitute.TabIndex = 1;
            this.buttonDownAltitute.Text = "-";
            this.buttonDownAltitute.UseVisualStyleBackColor = true;
            this.buttonDownAltitute.Click += new System.EventHandler(this.buttonDownAltitute_Click);
            // 
            // textAltitute
            // 
            this.textAltitute.Location = new System.Drawing.Point(19, 31);
            this.textAltitute.Name = "textAltitute";
            this.textAltitute.Size = new System.Drawing.Size(88, 20);
            this.textAltitute.TabIndex = 0;
            this.textAltitute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAltitute_KeyPress);
            // 
            // buttonUpAltitute
            // 
            this.buttonUpAltitute.Location = new System.Drawing.Point(136, 30);
            this.buttonUpAltitute.Name = "buttonUpAltitute";
            this.buttonUpAltitute.Size = new System.Drawing.Size(75, 20);
            this.buttonUpAltitute.TabIndex = 1;
            this.buttonUpAltitute.Text = "+";
            this.buttonUpAltitute.UseVisualStyleBackColor = true;
            this.buttonUpAltitute.Click += new System.EventHandler(this.buttonUpAltitute_Click);
            // 
            // groupDepth
            // 
            this.groupDepth.Controls.Add(this.buttonDownDepth);
            this.groupDepth.Controls.Add(this.textDepth);
            this.groupDepth.Controls.Add(this.buttonUpDepth);
            this.groupDepth.Location = new System.Drawing.Point(522, 232);
            this.groupDepth.Name = "groupDepth";
            this.groupDepth.Size = new System.Drawing.Size(349, 72);
            this.groupDepth.TabIndex = 4;
            this.groupDepth.TabStop = false;
            this.groupDepth.Text = "Depth";
            // 
            // buttonDownDepth
            // 
            this.buttonDownDepth.Location = new System.Drawing.Point(241, 29);
            this.buttonDownDepth.Name = "buttonDownDepth";
            this.buttonDownDepth.Size = new System.Drawing.Size(75, 20);
            this.buttonDownDepth.TabIndex = 1;
            this.buttonDownDepth.Text = "-";
            this.buttonDownDepth.UseVisualStyleBackColor = true;
            this.buttonDownDepth.Click += new System.EventHandler(this.buttonDownDepth_Click);
            // 
            // textDepth
            // 
            this.textDepth.Location = new System.Drawing.Point(19, 29);
            this.textDepth.Name = "textDepth";
            this.textDepth.Size = new System.Drawing.Size(88, 20);
            this.textDepth.TabIndex = 0;
            this.textDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDepth_KeyPress);
            // 
            // buttonUpDepth
            // 
            this.buttonUpDepth.Location = new System.Drawing.Point(136, 28);
            this.buttonUpDepth.Name = "buttonUpDepth";
            this.buttonUpDepth.Size = new System.Drawing.Size(75, 20);
            this.buttonUpDepth.TabIndex = 1;
            this.buttonUpDepth.Text = "+";
            this.buttonUpDepth.UseVisualStyleBackColor = true;
            this.buttonUpDepth.Click += new System.EventHandler(this.buttonUpDepth_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(208, 193);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // upgradeButton
            // 
            this.upgradeButton.Location = new System.Drawing.Point(643, 331);
            this.upgradeButton.Name = "upgradeButton";
            this.upgradeButton.Size = new System.Drawing.Size(75, 23);
            this.upgradeButton.TabIndex = 5;
            this.upgradeButton.Text = "Update";
            this.upgradeButton.UseVisualStyleBackColor = true;
            this.upgradeButton.Click += new System.EventHandler(this.upgradeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 396);
            this.Controls.Add(this.upgradeButton);
            this.Controls.Add(this.groupDepth);
            this.Controls.Add(this.groupAltitute);
            this.Controls.Add(this.groupSpeed);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listToys);
            this.Controls.Add(this.listAvailableToys);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupSpeed.ResumeLayout(false);
            this.groupSpeed.PerformLayout();
            this.groupAltitute.ResumeLayout(false);
            this.groupAltitute.PerformLayout();
            this.groupDepth.ResumeLayout(false);
            this.groupDepth.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listAvailableToys;
        private System.Windows.Forms.ListBox listToys;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupSpeed;
        private System.Windows.Forms.Button buttonDownSpeed;
        private System.Windows.Forms.Button buttonUpSpeed;
        private System.Windows.Forms.TextBox textSpeed;
        private System.Windows.Forms.GroupBox groupAltitute;
        private System.Windows.Forms.TextBox textAltitute;
        private System.Windows.Forms.Button buttonDownAltitute;
        private System.Windows.Forms.Button buttonUpAltitute;
        private System.Windows.Forms.GroupBox groupDepth;
        private System.Windows.Forms.Button buttonDownDepth;
        private System.Windows.Forms.TextBox textDepth;
        private System.Windows.Forms.Button buttonUpDepth;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button upgradeButton;
    }
}

