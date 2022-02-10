namespace CoralReefResortHND2
{
    partial class frmReportDiv
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.listReport = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Aquamarine;
            this.btnExit.Location = new System.Drawing.Point(369, 410);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 25);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.BackColor = System.Drawing.Color.Transparent;
            this.lblDisplay.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.ForeColor = System.Drawing.Color.Black;
            this.lblDisplay.Location = new System.Drawing.Point(301, 9);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(203, 19);
            this.lblDisplay.TabIndex = 22;
            this.lblDisplay.Text = "Click \"View\" to see the report";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Aquamarine;
            this.btnView.Location = new System.Drawing.Point(345, 46);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(126, 25);
            this.btnView.TabIndex = 20;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // listReport
            // 
            this.listReport.FormattingEnabled = true;
            this.listReport.Location = new System.Drawing.Point(32, 79);
            this.listReport.Name = "listReport";
            this.listReport.Size = new System.Drawing.Size(737, 303);
            this.listReport.TabIndex = 21;
            // 
            // frmReportDiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(793, 447);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.listReport);
            this.Name = "frmReportDiv";
            this.Text = "Report Diving";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ListBox listReport;
    }
}