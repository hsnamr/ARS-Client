namespace RemedyClient
{
    partial class MemberForm
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
            this.lstHeader = new System.Windows.Forms.ListBox();
            this.lstTickets = new System.Windows.Forms.ListBox();
            this.lblMessages = new System.Windows.Forms.Label();
            this.radWorkOnProgress = new System.Windows.Forms.RadioButton();
            this.radJobDone = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpCombo = new System.Windows.Forms.GroupBox();
            this.grpCombo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstHeader
            // 
            this.lstHeader.FormattingEnabled = true;
            this.lstHeader.Items.AddRange(new object[] {
            "Number\tIssue Date\tStatus\tDue Date"});
            this.lstHeader.Location = new System.Drawing.Point(12, 12);
            this.lstHeader.Name = "lstHeader";
            this.lstHeader.Size = new System.Drawing.Size(301, 17);
            this.lstHeader.TabIndex = 3;
            // 
            // lstTickets
            // 
            this.lstTickets.FormattingEnabled = true;
            this.lstTickets.Location = new System.Drawing.Point(12, 35);
            this.lstTickets.Name = "lstTickets";
            this.lstTickets.Size = new System.Drawing.Size(301, 147);
            this.lstTickets.TabIndex = 4;
            this.lstTickets.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseClick);
            this.lstTickets.DoubleClick += new System.EventHandler(this.lstTickets_DoubleClick);
            // 
            // lblMessages
            // 
            this.lblMessages.AutoSize = true;
            this.lblMessages.Location = new System.Drawing.Point(9, 299);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(101, 13);
            this.lblMessages.TabIndex = 5;
            this.lblMessages.Text = "Print Any Messages";
            // 
            // radWorkOnProgress
            // 
            this.radWorkOnProgress.AutoSize = true;
            this.radWorkOnProgress.Location = new System.Drawing.Point(16, 16);
            this.radWorkOnProgress.Name = "radWorkOnProgress";
            this.radWorkOnProgress.Size = new System.Drawing.Size(112, 17);
            this.radWorkOnProgress.TabIndex = 6;
            this.radWorkOnProgress.TabStop = true;
            this.radWorkOnProgress.Text = "Work On Progress";
            this.radWorkOnProgress.UseVisualStyleBackColor = true;
            // 
            // radJobDone
            // 
            this.radJobDone.AutoSize = true;
            this.radJobDone.Location = new System.Drawing.Point(16, 39);
            this.radJobDone.Name = "radJobDone";
            this.radJobDone.Size = new System.Drawing.Size(70, 17);
            this.radJobDone.TabIndex = 7;
            this.radJobDone.TabStop = true;
            this.radJobDone.Text = "Job Done";
            this.radJobDone.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(192, 39);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grpCombo
            // 
            this.grpCombo.Controls.Add(this.btnUpdate);
            this.grpCombo.Controls.Add(this.radJobDone);
            this.grpCombo.Controls.Add(this.radWorkOnProgress);
            this.grpCombo.Enabled = false;
            this.grpCombo.Location = new System.Drawing.Point(21, 206);
            this.grpCombo.Name = "grpCombo";
            this.grpCombo.Size = new System.Drawing.Size(282, 69);
            this.grpCombo.TabIndex = 9;
            this.grpCombo.TabStop = false;
            this.grpCombo.Text = "Update Ticket Status";
            // 
            // MemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 321);
            this.Controls.Add(this.grpCombo);
            this.Controls.Add(this.lblMessages);
            this.Controls.Add(this.lstTickets);
            this.Controls.Add(this.lstHeader);
            this.Name = "MemberForm";
            this.Text = "Remedy Client Member";
            this.grpCombo.ResumeLayout(false);
            this.grpCombo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstHeader;
        private System.Windows.Forms.ListBox lstTickets;
        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.RadioButton radWorkOnProgress;
        private System.Windows.Forms.RadioButton radJobDone;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox grpCombo;

    }
}