namespace CoralReefResortHND2
{
    partial class frmReportMenu
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
            this.lblQuote = new System.Windows.Forms.Label();
            this.lblResort = new System.Windows.Forms.Label();
            this.btnClick = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.rdbReportSnor = new System.Windows.Forms.RadioButton();
            this.rdbReportDiv = new System.Windows.Forms.RadioButton();
            this.grpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuote
            // 
            this.lblQuote.AutoSize = true;
            this.lblQuote.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuote.Location = new System.Drawing.Point(177, 61);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(244, 18);
            this.lblQuote.TabIndex = 28;
            this.lblQuote.Text = "Have a Glorious Stay in Redang Island!";
            // 
            // lblResort
            // 
            this.lblResort.AutoSize = true;
            this.lblResort.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResort.Location = new System.Drawing.Point(176, 29);
            this.lblResort.Name = "lblResort";
            this.lblResort.Size = new System.Drawing.Size(246, 23);
            this.lblResort.TabIndex = 27;
            this.lblResort.Text = "Welcome To Coral Reef Resort";
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.Color.Aquamarine;
            this.btnClick.Location = new System.Drawing.Point(158, 266);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(116, 40);
            this.btnClick.TabIndex = 26;
            this.btnClick.TabStop = false;
            this.btnClick.Text = "Click Here To Continue";
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Aquamarine;
            this.btnLogOut.Location = new System.Drawing.Point(316, 266);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(116, 40);
            this.btnLogOut.TabIndex = 25;
            this.btnLogOut.TabStop = false;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.rdbReportSnor);
            this.grpMenu.Controls.Add(this.rdbReportDiv);
            this.grpMenu.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMenu.Location = new System.Drawing.Point(158, 122);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(274, 119);
            this.grpMenu.TabIndex = 24;
            this.grpMenu.TabStop = false;
            this.grpMenu.Text = "MAIN MENU";
            // 
            // rdbReportSnor
            // 
            this.rdbReportSnor.AutoSize = true;
            this.rdbReportSnor.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbReportSnor.Location = new System.Drawing.Point(66, 44);
            this.rdbReportSnor.Name = "rdbReportSnor";
            this.rdbReportSnor.Size = new System.Drawing.Size(155, 25);
            this.rdbReportSnor.TabIndex = 2;
            this.rdbReportSnor.Text = "Report Snorkeling";
            this.rdbReportSnor.UseVisualStyleBackColor = true;
            // 
            // rdbReportDiv
            // 
            this.rdbReportDiv.AutoSize = true;
            this.rdbReportDiv.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbReportDiv.Location = new System.Drawing.Point(66, 72);
            this.rdbReportDiv.Name = "rdbReportDiv";
            this.rdbReportDiv.Size = new System.Drawing.Size(126, 25);
            this.rdbReportDiv.TabIndex = 1;
            this.rdbReportDiv.Text = "Report Diving";
            this.rdbReportDiv.UseVisualStyleBackColor = true;
            // 
            // frmReportMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(591, 334);
            this.Controls.Add(this.lblQuote);
            this.Controls.Add(this.lblResort);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.grpMenu);
            this.Name = "frmReportMenu";
            this.Text = "_7_ReportMenu";
            this.grpMenu.ResumeLayout(false);
            this.grpMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuote;
        private System.Windows.Forms.Label lblResort;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.RadioButton rdbReportSnor;
        private System.Windows.Forms.RadioButton rdbReportDiv;
    }
}