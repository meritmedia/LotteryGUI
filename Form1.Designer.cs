namespace LotteryGUI
{
    partial class frmLotto
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
            this.txtLotto1 = new System.Windows.Forms.TextBox();
            this.txtLotto2 = new System.Windows.Forms.TextBox();
            this.txtLotto3 = new System.Windows.Forms.TextBox();
            this.btnReveal = new System.Windows.Forms.Button();
            this.txtGuess1 = new System.Windows.Forms.TextBox();
            this.txtGuess2 = new System.Windows.Forms.TextBox();
            this.txtGuess3 = new System.Windows.Forms.TextBox();
            this.lblInstruction1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTryAgainKeepNumbers = new System.Windows.Forms.Button();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.lblEvents = new System.Windows.Forms.Label();
            this.lblTicket = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.llblFacebook = new System.Windows.Forms.LinkLabel();
            this.llblTwitter = new System.Windows.Forms.LinkLabel();
            this.llblWebsite = new System.Windows.Forms.LinkLabel();
            this.txtTicketID = new System.Windows.Forms.TextBox();
            this.lblRules = new System.Windows.Forms.Label();
            this.btnClaimTicket = new System.Windows.Forms.Button();
            this.btnEditTicket = new System.Windows.Forms.Button();
            this.btnGetNewTicket = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLotto1
            // 
            this.txtLotto1.BackColor = System.Drawing.Color.Gold;
            this.txtLotto1.Enabled = false;
            this.txtLotto1.Font = new System.Drawing.Font("Kimberley", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLotto1.Location = new System.Drawing.Point(77, 258);
            this.txtLotto1.Name = "txtLotto1";
            this.txtLotto1.ReadOnly = true;
            this.txtLotto1.Size = new System.Drawing.Size(75, 39);
            this.txtLotto1.TabIndex = 100;
            this.txtLotto1.Text = "?";
            this.txtLotto1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLotto2
            // 
            this.txtLotto2.BackColor = System.Drawing.Color.Gold;
            this.txtLotto2.Enabled = false;
            this.txtLotto2.Font = new System.Drawing.Font("Kimberley", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLotto2.Location = new System.Drawing.Point(196, 258);
            this.txtLotto2.Name = "txtLotto2";
            this.txtLotto2.ReadOnly = true;
            this.txtLotto2.Size = new System.Drawing.Size(75, 39);
            this.txtLotto2.TabIndex = 100;
            this.txtLotto2.Text = "?";
            this.txtLotto2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLotto3
            // 
            this.txtLotto3.BackColor = System.Drawing.Color.Gold;
            this.txtLotto3.Enabled = false;
            this.txtLotto3.Font = new System.Drawing.Font("Kimberley", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLotto3.Location = new System.Drawing.Point(315, 258);
            this.txtLotto3.Name = "txtLotto3";
            this.txtLotto3.ReadOnly = true;
            this.txtLotto3.Size = new System.Drawing.Size(75, 39);
            this.txtLotto3.TabIndex = 100;
            this.txtLotto3.Text = "?";
            this.txtLotto3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReveal
            // 
            this.btnReveal.BackColor = System.Drawing.Color.Transparent;
            this.btnReveal.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReveal.Location = new System.Drawing.Point(34, 226);
            this.btnReveal.Name = "btnReveal";
            this.btnReveal.Size = new System.Drawing.Size(398, 30);
            this.btnReveal.TabIndex = 4;
            this.btnReveal.Text = "Scratch \'em!";
            this.btnReveal.UseVisualStyleBackColor = false;
            this.btnReveal.Click += new System.EventHandler(this.btnReveal_Click);
            // 
            // txtGuess1
            // 
            this.txtGuess1.BackColor = System.Drawing.Color.SeaShell;
            this.txtGuess1.Font = new System.Drawing.Font("Kimberley", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuess1.Location = new System.Drawing.Point(76, 184);
            this.txtGuess1.MaxLength = 1;
            this.txtGuess1.Name = "txtGuess1";
            this.txtGuess1.Size = new System.Drawing.Size(75, 39);
            this.txtGuess1.TabIndex = 1;
            this.txtGuess1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGuess1.TextChanged += new System.EventHandler(this.txtGuess1_TextChanged);
            // 
            // txtGuess2
            // 
            this.txtGuess2.BackColor = System.Drawing.Color.SeaShell;
            this.txtGuess2.Font = new System.Drawing.Font("Kimberley", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuess2.Location = new System.Drawing.Point(195, 184);
            this.txtGuess2.MaxLength = 1;
            this.txtGuess2.Name = "txtGuess2";
            this.txtGuess2.Size = new System.Drawing.Size(75, 39);
            this.txtGuess2.TabIndex = 2;
            this.txtGuess2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGuess2.TextChanged += new System.EventHandler(this.txtGuess2_TextChanged);
            // 
            // txtGuess3
            // 
            this.txtGuess3.BackColor = System.Drawing.Color.SeaShell;
            this.txtGuess3.Font = new System.Drawing.Font("Kimberley", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuess3.Location = new System.Drawing.Point(314, 184);
            this.txtGuess3.MaxLength = 1;
            this.txtGuess3.Name = "txtGuess3";
            this.txtGuess3.Size = new System.Drawing.Size(75, 39);
            this.txtGuess3.TabIndex = 3;
            this.txtGuess3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGuess3.TextChanged += new System.EventHandler(this.txtGuess3_TextChanged);
            // 
            // lblInstruction1
            // 
            this.lblInstruction1.AutoSize = true;
            this.lblInstruction1.BackColor = System.Drawing.Color.Transparent;
            this.lblInstruction1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction1.Location = new System.Drawing.Point(94, 163);
            this.lblInstruction1.Name = "lblInstruction1";
            this.lblInstruction1.Size = new System.Drawing.Size(277, 18);
            this.lblInstruction1.TabIndex = 102;
            this.lblInstruction1.Text = "Pick 3 numbers between 1 and X";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(239, 553);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(193, 28);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTryAgainKeepNumbers
            // 
            this.btnTryAgainKeepNumbers.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTryAgainKeepNumbers.Location = new System.Drawing.Point(34, 308);
            this.btnTryAgainKeepNumbers.Name = "btnTryAgainKeepNumbers";
            this.btnTryAgainKeepNumbers.Size = new System.Drawing.Size(398, 63);
            this.btnTryAgainKeepNumbers.TabIndex = 211;
            this.btnTryAgainKeepNumbers.Text = "Try again";
            this.btnTryAgainKeepNumbers.UseVisualStyleBackColor = true;
            this.btnTryAgainKeepNumbers.Click += new System.EventHandler(this.btnTryAgainKeepNumbers_Click);
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorMsg.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMsg.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorMsg.Location = new System.Drawing.Point(31, 143);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(0, 18);
            this.lblErrorMsg.TabIndex = 216;
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.BackColor = System.Drawing.Color.Yellow;
            this.lblEvents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEvents.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvents.ForeColor = System.Drawing.Color.Black;
            this.lblEvents.Location = new System.Drawing.Point(239, 461);
            this.lblEvents.MaximumSize = new System.Drawing.Size(192, 0);
            this.lblEvents.MinimumSize = new System.Drawing.Size(192, 0);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.lblEvents.Size = new System.Drawing.Size(192, 30);
            this.lblEvents.TabIndex = 217;
            this.lblEvents.Text = "(events) ";
            this.lblEvents.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblEvents.Click += new System.EventHandler(this.lblEvents_Click);
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.BackColor = System.Drawing.Color.Transparent;
            this.lblTicket.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicket.Location = new System.Drawing.Point(60, 117);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(88, 18);
            this.lblTicket.TabIndex = 218;
            this.lblTicket.Text = "Ticket ID:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(31, 461);
            this.lblInfo.MaximumSize = new System.Drawing.Size(175, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(28, 13);
            this.lblInfo.TabIndex = 220;
            this.lblInfo.Text = "info";
            // 
            // llblFacebook
            // 
            this.llblFacebook.AutoSize = true;
            this.llblFacebook.BackColor = System.Drawing.Color.Transparent;
            this.llblFacebook.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblFacebook.Location = new System.Drawing.Point(33, 529);
            this.llblFacebook.Name = "llblFacebook";
            this.llblFacebook.Size = new System.Drawing.Size(60, 13);
            this.llblFacebook.TabIndex = 221;
            this.llblFacebook.TabStop = true;
            this.llblFacebook.Text = "Facebook";
            this.llblFacebook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblFacebook_LinkClicked);
            // 
            // llblTwitter
            // 
            this.llblTwitter.AutoSize = true;
            this.llblTwitter.BackColor = System.Drawing.Color.Transparent;
            this.llblTwitter.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblTwitter.Location = new System.Drawing.Point(99, 529);
            this.llblTwitter.Name = "llblTwitter";
            this.llblTwitter.Size = new System.Drawing.Size(43, 13);
            this.llblTwitter.TabIndex = 222;
            this.llblTwitter.TabStop = true;
            this.llblTwitter.Text = "twitter";
            this.llblTwitter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblTwitter_LinkClicked);
            // 
            // llblWebsite
            // 
            this.llblWebsite.AutoSize = true;
            this.llblWebsite.BackColor = System.Drawing.Color.Transparent;
            this.llblWebsite.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblWebsite.Location = new System.Drawing.Point(148, 529);
            this.llblWebsite.Name = "llblWebsite";
            this.llblWebsite.Size = new System.Drawing.Size(50, 13);
            this.llblWebsite.TabIndex = 223;
            this.llblWebsite.TabStop = true;
            this.llblWebsite.Text = "website";
            this.llblWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblWebsite_LinkClicked);
            // 
            // txtTicketID
            // 
            this.txtTicketID.Enabled = false;
            this.txtTicketID.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicketID.Location = new System.Drawing.Point(150, 107);
            this.txtTicketID.MaxLength = 5;
            this.txtTicketID.Name = "txtTicketID";
            this.txtTicketID.Size = new System.Drawing.Size(86, 31);
            this.txtTicketID.TabIndex = 224;
            this.txtTicketID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.BackColor = System.Drawing.Color.Transparent;
            this.lblRules.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules.Location = new System.Drawing.Point(-1, 0);
            this.lblRules.MaximumSize = new System.Drawing.Size(420, 200);
            this.lblRules.Name = "lblRules";
            this.lblRules.Padding = new System.Windows.Forms.Padding(5);
            this.lblRules.Size = new System.Drawing.Size(55, 24);
            this.lblRules.TabIndex = 225;
            this.lblRules.Text = "label1";
            this.lblRules.Click += new System.EventHandler(this.lblRules_Click);
            // 
            // btnClaimTicket
            // 
            this.btnClaimTicket.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClaimTicket.Location = new System.Drawing.Point(286, 107);
            this.btnClaimTicket.Name = "btnClaimTicket";
            this.btnClaimTicket.Size = new System.Drawing.Size(117, 30);
            this.btnClaimTicket.TabIndex = 226;
            this.btnClaimTicket.Text = "Claim Ticket";
            this.btnClaimTicket.UseVisualStyleBackColor = true;
            this.btnClaimTicket.Visible = false;
            this.btnClaimTicket.Click += new System.EventHandler(this.btnClaimTicket_Click);
            this.btnClaimTicket.Leave += new System.EventHandler(this.btnClaimTicket_Leave);
            // 
            // btnEditTicket
            // 
            this.btnEditTicket.BackColor = System.Drawing.Color.Transparent;
            this.btnEditTicket.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTicket.Image = global::LotteryGUI.Properties.Resources.edit;
            this.btnEditTicket.Location = new System.Drawing.Point(239, 107);
            this.btnEditTicket.Name = "btnEditTicket";
            this.btnEditTicket.Size = new System.Drawing.Size(45, 30);
            this.btnEditTicket.TabIndex = 227;
            this.btnEditTicket.Text = "Edit";
            this.btnEditTicket.UseVisualStyleBackColor = false;
            this.btnEditTicket.Click += new System.EventHandler(this.btnEditTicket_Click);
            this.btnEditTicket.Leave += new System.EventHandler(this.btnEditTicket_Leave);
            // 
            // btnGetNewTicket
            // 
            this.btnGetNewTicket.Enabled = false;
            this.btnGetNewTicket.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetNewTicket.Location = new System.Drawing.Point(34, 553);
            this.btnGetNewTicket.Name = "btnGetNewTicket";
            this.btnGetNewTicket.Size = new System.Drawing.Size(202, 28);
            this.btnGetNewTicket.TabIndex = 228;
            this.btnGetNewTicket.Text = "Get New Ticket";
            this.btnGetNewTicket.UseVisualStyleBackColor = true;
            this.btnGetNewTicket.Click += new System.EventHandler(this.btnGetNewTicket_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lblRules);
            this.panel1.Location = new System.Drawing.Point(34, 377);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 30);
            this.panel1.TabIndex = 229;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frmLotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LotteryGUI.Properties.Resources.bkg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(464, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGetNewTicket);
            this.Controls.Add(this.btnEditTicket);
            this.Controls.Add(this.btnClaimTicket);
            this.Controls.Add(this.txtTicketID);
            this.Controls.Add(this.llblWebsite);
            this.Controls.Add(this.llblTwitter);
            this.Controls.Add(this.llblFacebook);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblTicket);
            this.Controls.Add(this.lblEvents);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.btnTryAgainKeepNumbers);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblInstruction1);
            this.Controls.Add(this.txtGuess3);
            this.Controls.Add(this.txtGuess2);
            this.Controls.Add(this.txtGuess1);
            this.Controls.Add(this.btnReveal);
            this.Controls.Add(this.txtLotto3);
            this.Controls.Add(this.txtLotto2);
            this.Controls.Add(this.txtLotto1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmLotto";
            this.Text = "SPARKS LOUNGE BAR Pick 3";
            this.Load += new System.EventHandler(this.frmLotto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLotto1;
        private System.Windows.Forms.TextBox txtLotto2;
        private System.Windows.Forms.TextBox txtLotto3;
        private System.Windows.Forms.Button btnReveal;
        private System.Windows.Forms.TextBox txtGuess1;
        private System.Windows.Forms.TextBox txtGuess2;
        private System.Windows.Forms.TextBox txtGuess3;
        private System.Windows.Forms.Label lblInstruction1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTryAgainKeepNumbers;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.LinkLabel llblFacebook;
        private System.Windows.Forms.LinkLabel llblTwitter;
        private System.Windows.Forms.LinkLabel llblWebsite;
        private System.Windows.Forms.TextBox txtTicketID;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.Button btnClaimTicket;
        private System.Windows.Forms.Button btnEditTicket;
        private System.Windows.Forms.Button btnGetNewTicket;
        private System.Windows.Forms.Panel panel1;
    }
}

