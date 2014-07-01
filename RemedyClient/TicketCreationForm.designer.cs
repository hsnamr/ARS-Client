namespace RemedyClient
{
    partial class TicketCreationForm
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
            this.txtRequirments = new System.Windows.Forms.TextBox();
            this.cmboAssigned = new System.Windows.Forms.ComboBox();
            this.lstAttachments = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAttach = new System.Windows.Forms.Button();
            this.btnTicketCreate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSeqAdd = new System.Windows.Forms.Button();
            this.dTP = new System.Windows.Forms.DateTimePicker();
            this.cmboSeqLength = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtRequirments
            // 
            this.txtRequirments.Location = new System.Drawing.Point(100, 118);
            this.txtRequirments.MaxLength = 255;
            this.txtRequirments.Multiline = true;
            this.txtRequirments.Name = "txtRequirments";
            this.txtRequirments.Size = new System.Drawing.Size(200, 81);
            this.txtRequirments.TabIndex = 3;
            // 
            // cmboAssigned
            // 
            this.cmboAssigned.FormattingEnabled = true;
            this.cmboAssigned.Location = new System.Drawing.Point(261, 12);
            this.cmboAssigned.Name = "cmboAssigned";
            this.cmboAssigned.Size = new System.Drawing.Size(171, 21);
            this.cmboAssigned.TabIndex = 4;
            // 
            // lstAttachments
            // 
            this.lstAttachments.FormattingEnabled = true;
            this.lstAttachments.Location = new System.Drawing.Point(100, 44);
            this.lstAttachments.Name = "lstAttachments";
            this.lstAttachments.Size = new System.Drawing.Size(200, 69);
            this.lstAttachments.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Assigned:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Attachments:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Requirments:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Due Date:";
            // 
            // btnAttach
            // 
            this.btnAttach.Location = new System.Drawing.Point(312, 48);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(120, 23);
            this.btnAttach.TabIndex = 11;
            this.btnAttach.Text = "Add Attachments";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // btnTicketCreate
            // 
            this.btnTicketCreate.Location = new System.Drawing.Point(312, 228);
            this.btnTicketCreate.Name = "btnTicketCreate";
            this.btnTicketCreate.Size = new System.Drawing.Size(120, 23);
            this.btnTicketCreate.TabIndex = 12;
            this.btnTicketCreate.Text = "Create Ticket";
            this.btnTicketCreate.UseVisualStyleBackColor = true;
            this.btnTicketCreate.Click += new System.EventHandler(this.btnTicketCreate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(312, 77);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 23);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remove Attachments";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 238);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(101, 13);
            this.lblMessage.TabIndex = 14;
            this.lblMessage.Text = "Print Any Messages";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sequence Length:";
            // 
            // btnSeqAdd
            // 
            this.btnSeqAdd.Location = new System.Drawing.Point(312, 198);
            this.btnSeqAdd.Name = "btnSeqAdd";
            this.btnSeqAdd.Size = new System.Drawing.Size(120, 23);
            this.btnSeqAdd.TabIndex = 17;
            this.btnSeqAdd.Text = "Create Ticket";
            this.btnSeqAdd.UseVisualStyleBackColor = true;
            this.btnSeqAdd.Click += new System.EventHandler(this.btnSeqAdd_Click);
            // 
            // dTP
            // 
            this.dTP.Location = new System.Drawing.Point(100, 205);
            this.dTP.Name = "dTP";
            this.dTP.Size = new System.Drawing.Size(200, 20);
            this.dTP.TabIndex = 18;
            // 
            // cmboSeqLength
            // 
            this.cmboSeqLength.FormattingEnabled = true;
            this.cmboSeqLength.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmboSeqLength.Location = new System.Drawing.Point(100, 12);
            this.cmboSeqLength.Name = "cmboSeqLength";
            this.cmboSeqLength.Size = new System.Drawing.Size(46, 21);
            this.cmboSeqLength.TabIndex = 19;
            this.cmboSeqLength.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmboSeqLength_MouseClick);
            // 
            // TicketCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 265);
            this.Controls.Add(this.cmboSeqLength);
            this.Controls.Add(this.dTP);
            this.Controls.Add(this.btnSeqAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnTicketCreate);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAttachments);
            this.Controls.Add(this.cmboAssigned);
            this.Controls.Add(this.txtRequirments);
            this.Name = "TicketCreationForm";
            this.Text = "Ticket Creation Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRequirments;
        private System.Windows.Forms.ComboBox cmboAssigned;
        private System.Windows.Forms.ListBox lstAttachments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Button btnTicketCreate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSeqAdd;
        private System.Windows.Forms.DateTimePicker dTP;
        private System.Windows.Forms.ComboBox cmboSeqLength;
    }
}