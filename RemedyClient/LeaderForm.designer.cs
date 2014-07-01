namespace RemedyClient
{
    partial class LeaderForm
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
            this.btnMember = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstTickets = new System.Windows.Forms.ListBox();
            this.lstHeader = new System.Windows.Forms.ListBox();
            this.lblMessages = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMember
            // 
            this.btnMember.Location = new System.Drawing.Point(32, 189);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(132, 23);
            this.btnMember.TabIndex = 0;
            this.btnMember.Text = "Create New Member";
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(189, 189);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(132, 23);
            this.btnTicket.TabIndex = 1;
            this.btnTicket.Text = "Create New Ticket";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstTickets);
            this.groupBox1.Controls.Add(this.lstHeader);
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 171);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Tickets Information";
            // 
            // lstTickets
            // 
            this.lstTickets.FormattingEnabled = true;
            this.lstTickets.Location = new System.Drawing.Point(6, 42);
            this.lstTickets.Name = "lstTickets";
            this.lstTickets.Size = new System.Drawing.Size(321, 121);
            this.lstTickets.TabIndex = 1;
            this.lstTickets.DoubleClick += new System.EventHandler(this.lstTickets_DoubleClick);
            // 
            // lstHeader
            // 
            this.lstHeader.FormattingEnabled = true;
            this.lstHeader.Items.AddRange(new object[] {
            "Number\tIssue Date\tStatus\tDue Date"});
            this.lstHeader.Location = new System.Drawing.Point(6, 19);
            this.lstHeader.Name = "lstHeader";
            this.lstHeader.Size = new System.Drawing.Size(321, 17);
            this.lstHeader.TabIndex = 0;
            // 
            // lblMessages
            // 
            this.lblMessages.AutoSize = true;
            this.lblMessages.Location = new System.Drawing.Point(12, 250);
            this.lblMessages.Name = "lblMessages";
            this.lblMessages.Size = new System.Drawing.Size(101, 13);
            this.lblMessages.TabIndex = 3;
            this.lblMessages.Text = "Print Any Messages";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(32, 218);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Existing Member";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // LeaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 272);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblMessages);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.btnMember);
            this.Name = "LeaderForm";
            this.Text = "Remedy Client Leader";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstTickets;
        private System.Windows.Forms.ListBox lstHeader;
        private System.Windows.Forms.Label lblMessages;
        private System.Windows.Forms.Button btnDelete;

    }
}