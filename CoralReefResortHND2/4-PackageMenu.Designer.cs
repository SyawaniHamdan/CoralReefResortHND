namespace CoralReefResortHND2
{
    partial class frmPackageMenu
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
            this.btnClick = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.grpMenu = new System.Windows.Forms.GroupBox();
            this.rdbDivPack = new System.Windows.Forms.RadioButton();
            this.rdbSnorPack = new System.Windows.Forms.RadioButton();
            this.lblQuote = new System.Windows.Forms.Label();
            this.lblResort = new System.Windows.Forms.Label();
            this.grpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.BackColor = System.Drawing.Color.Aquamarine;
            this.btnClick.Location = new System.Drawing.Point(158, 283);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(116, 40);
            this.btnClick.TabIndex = 18;
            this.btnClick.TabStop = false;
            this.btnClick.Text = "Click Here To Continue";
            this.btnClick.UseVisualStyleBackColor = false;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Aquamarine;
            this.btnLogOut.Location = new System.Drawing.Point(316, 283);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(116, 40);
            this.btnLogOut.TabIndex = 17;
            this.btnLogOut.TabStop = false;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // grpMenu
            // 
            this.grpMenu.Controls.Add(this.rdbDivPack);
            this.grpMenu.Controls.Add(this.rdbSnorPack);
            this.grpMenu.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMenu.Location = new System.Drawing.Point(158, 117);
            this.grpMenu.Name = "grpMenu";
            this.grpMenu.Size = new System.Drawing.Size(274, 119);
            this.grpMenu.TabIndex = 16;
            this.grpMenu.TabStop = false;
            this.grpMenu.Text = "MAIN MENU";
            // 
            // rdbDivPack
            // 
            this.rdbDivPack.AutoSize = true;
            this.rdbDivPack.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDivPack.Location = new System.Drawing.Point(56, 72);
            this.rdbDivPack.Name = "rdbDivPack";
            this.rdbDivPack.Size = new System.Drawing.Size(134, 25);
            this.rdbDivPack.TabIndex = 1;
            this.rdbDivPack.Text = "Diving Package";
            this.rdbDivPack.UseVisualStyleBackColor = true;
            // 
            // rdbSnorPack
            // 
            this.rdbSnorPack.AutoSize = true;
            this.rdbSnorPack.Font = new System.Drawing.Font("Sitka Text", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSnorPack.Location = new System.Drawing.Point(56, 41);
            this.rdbSnorPack.Name = "rdbSnorPack";
            this.rdbSnorPack.Size = new System.Drawing.Size(163, 25);
            this.rdbSnorPack.TabIndex = 0;
            this.rdbSnorPack.Text = "Snorkeling Package";
            this.rdbSnorPack.UseVisualStyleBackColor = true;
            // 
            // lblQuote
            // 
            this.lblQuote.AutoSize = true;
            this.lblQuote.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuote.Location = new System.Drawing.Point(172, 44);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(244, 18);
            this.lblQuote.TabIndex = 15;
            this.lblQuote.Text = "Have a Glorious Stay in Redang Island!";
            // 
            // lblResort
            // 
            this.lblResort.AutoSize = true;
            this.lblResort.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResort.Location = new System.Drawing.Point(171, 12);
            this.lblResort.Name = "lblResort";
            this.lblResort.Size = new System.Drawing.Size(246, 23);
            this.lblResort.TabIndex = 14;
            this.lblResort.Text = "Welcome To Coral Reef Resort";
            // 
            // frmPackageMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(591, 334);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.grpMenu);
            this.Controls.Add(this.lblQuote);
            this.Controls.Add(this.lblResort);
            this.Name = "frmPackageMenu";
            this.Text = "Package Menu";
            this.grpMenu.ResumeLayout(false);
            this.grpMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.GroupBox grpMenu;
        private System.Windows.Forms.RadioButton rdbDivPack;
        private System.Windows.Forms.RadioButton rdbSnorPack;
        private System.Windows.Forms.Label lblQuote;
        private System.Windows.Forms.Label lblResort;
    }
}