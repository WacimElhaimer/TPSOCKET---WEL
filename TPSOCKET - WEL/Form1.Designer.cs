using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

namespace TPSocket.Properties
{
    partial class Communication
    {
        private Socket SSocketUDP;

        private EndPoint Destination, Reception;

        private Stopwatch Timer = new Stopwatch();
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
            this.buttonCreer = new System.Windows.Forms.Button();
            this.buttonFerme = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonTimeout = new System.Windows.Forms.Button();
            this.buttonRecTimer = new System.Windows.Forms.Button();
            this.buttonRecThread = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelRec = new System.Windows.Forms.Label();
            this.labelDest = new System.Windows.Forms.Label();
            this.ipRec = new System.Windows.Forms.TextBox();
            this.ipDest = new System.Windows.Forms.TextBox();
            this.portRec = new System.Windows.Forms.TextBox();
            this.portDest = new System.Windows.Forms.TextBox();
            this.textLineSend = new System.Windows.Forms.TextBox();
            this.textLineRec = new System.Windows.Forms.TextBox();
            this.labelSend = new System.Windows.Forms.Label();
            this.labelReceived = new System.Windows.Forms.Label();
            this.labelCIDR1 = new System.Windows.Forms.Label();
            this.labelCIDR2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCreer
            // 
            this.buttonCreer.Location = new System.Drawing.Point(15, 84);
            this.buttonCreer.Name = "buttonCreer";
            this.buttonCreer.Size = new System.Drawing.Size(232, 23);
            this.buttonCreer.TabIndex = 0;
            this.buttonCreer.Text = "Créer & Bind socket";
            this.buttonCreer.UseVisualStyleBackColor = true;
            this.buttonCreer.Click += new System.EventHandler(this.buttonCreer_click);
            // 
            // buttonFerme
            // 
            this.buttonFerme.Location = new System.Drawing.Point(15, 114);
            this.buttonFerme.Name = "buttonFerme";
            this.buttonFerme.Size = new System.Drawing.Size(232, 23);
            this.buttonFerme.TabIndex = 1;
            this.buttonFerme.Text = "Fermer socket";
            this.buttonFerme.UseVisualStyleBackColor = true;
            this.buttonFerme.Click += new System.EventHandler(this.buttonFerme_click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(12, 348);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(340, 49);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Transmettre";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_click);
            // 
            // buttonTimeout
            // 
            this.buttonTimeout.Location = new System.Drawing.Point(274, 19);
            this.buttonTimeout.Name = "buttonTimeout";
            this.buttonTimeout.Size = new System.Drawing.Size(182, 48);
            this.buttonTimeout.TabIndex = 3;
            this.buttonTimeout.Text = "Timeout";
            this.buttonTimeout.UseVisualStyleBackColor = true;
            // 
            // buttonRecTimer
            // 
            this.buttonRecTimer.Location = new System.Drawing.Point(253, 84);
            this.buttonRecTimer.Name = "buttonRecTimer";
            this.buttonRecTimer.Size = new System.Drawing.Size(203, 24);
            this.buttonRecTimer.TabIndex = 4;
            this.buttonRecTimer.Text = "Receive (timer)";
            this.buttonRecTimer.UseVisualStyleBackColor = true;
            // 
            // buttonRecThread
            // 
            this.buttonRecThread.Location = new System.Drawing.Point(253, 115);
            this.buttonRecThread.Name = "buttonRecThread";
            this.buttonRecThread.Size = new System.Drawing.Size(203, 22);
            this.buttonRecThread.TabIndex = 5;
            this.buttonRecThread.Text = "Receive (thread)";
            this.buttonRecThread.UseVisualStyleBackColor = true;
            this.buttonRecThread.Click += new System.EventHandler(this.buttonRecThread_click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(358, 348);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(339, 52);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.Text = "Reset Transmission";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // labelRec
            // 
            this.labelRec.AutoSize = true;
            this.labelRec.Location = new System.Drawing.Point(12, 22);
            this.labelRec.Name = "labelRec";
            this.labelRec.Size = new System.Drawing.Size(72, 13);
            this.labelRec.TabIndex = 7;
            this.labelRec.Text = "IP Reception:";
            // 
            // labelDest
            // 
            this.labelDest.AutoSize = true;
            this.labelDest.Location = new System.Drawing.Point(12, 50);
            this.labelDest.Name = "labelDest";
            this.labelDest.Size = new System.Drawing.Size(73, 13);
            this.labelDest.TabIndex = 8;
            this.labelDest.Text = "IP Destination";
            // 
            // ipRec
            // 
            this.ipRec.Location = new System.Drawing.Point(90, 19);
            this.ipRec.Name = "ipRec";
            this.ipRec.Size = new System.Drawing.Size(100, 20);
            this.ipRec.TabIndex = 11;
            // 
            // ipDest
            // 
            this.ipDest.Location = new System.Drawing.Point(90, 45);
            this.ipDest.Name = "ipDest";
            this.ipDest.Size = new System.Drawing.Size(100, 20);
            this.ipDest.TabIndex = 12;
            // 
            // portRec
            // 
            this.portRec.Location = new System.Drawing.Point(214, 19);
            this.portRec.Name = "portRec";
            this.portRec.Size = new System.Drawing.Size(54, 20);
            this.portRec.TabIndex = 13;
            // 
            // portDest
            // 
            this.portDest.Location = new System.Drawing.Point(214, 45);
            this.portDest.Name = "portDest";
            this.portDest.Size = new System.Drawing.Size(53, 20);
            this.portDest.TabIndex = 14;
            // 
            // textLineSend
            // 
            this.textLineSend.Location = new System.Drawing.Point(12, 176);
            this.textLineSend.Multiline = true;
            this.textLineSend.Name = "textLineSend";
            this.textLineSend.Size = new System.Drawing.Size(340, 166);
            this.textLineSend.TabIndex = 15;
            // 
            // textLineRec
            // 
            this.textLineRec.Location = new System.Drawing.Point(358, 176);
            this.textLineRec.Multiline = true;
            this.textLineRec.Name = "textLineRec";
            this.textLineRec.Size = new System.Drawing.Size(334, 166);
            this.textLineRec.TabIndex = 16;
            // 
            // labelSend
            // 
            this.labelSend.AutoSize = true;
            this.labelSend.Location = new System.Drawing.Point(12, 160);
            this.labelSend.Name = "labelSend";
            this.labelSend.Size = new System.Drawing.Size(90, 13);
            this.labelSend.TabIndex = 17;
            this.labelSend.Text = "Texte à envoyer :";
            // 
            // labelReceived
            // 
            this.labelReceived.AutoSize = true;
            this.labelReceived.Location = new System.Drawing.Point(355, 160);
            this.labelReceived.Name = "labelReceived";
            this.labelReceived.Size = new System.Drawing.Size(98, 13);
            this.labelReceived.TabIndex = 18;
            this.labelReceived.Text = "Transmission reçu :";
            // 
            // labelCIDR1
            // 
            this.labelCIDR1.AutoSize = true;
            this.labelCIDR1.Location = new System.Drawing.Point(196, 22);
            this.labelCIDR1.Name = "labelCIDR1";
            this.labelCIDR1.Size = new System.Drawing.Size(12, 13);
            this.labelCIDR1.TabIndex = 19;
            this.labelCIDR1.Text = "/";
            // 
            // labelCIDR2
            // 
            this.labelCIDR2.AutoSize = true;
            this.labelCIDR2.Location = new System.Drawing.Point(196, 45);
            this.labelCIDR2.Name = "labelCIDR2";
            this.labelCIDR2.Size = new System.Drawing.Size(12, 13);
            this.labelCIDR2.TabIndex = 20;
            this.labelCIDR2.Text = "/";
            // 
            // Communication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 408);
            this.Controls.Add(this.labelCIDR2);
            this.Controls.Add(this.labelCIDR1);
            this.Controls.Add(this.labelReceived);
            this.Controls.Add(this.labelSend);
            this.Controls.Add(this.textLineRec);
            this.Controls.Add(this.textLineSend);
            this.Controls.Add(this.portDest);
            this.Controls.Add(this.portRec);
            this.Controls.Add(this.ipDest);
            this.Controls.Add(this.ipRec);
            this.Controls.Add(this.labelDest);
            this.Controls.Add(this.labelRec);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonRecThread);
            this.Controls.Add(this.buttonRecTimer);
            this.Controls.Add(this.buttonTimeout);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonFerme);
            this.Controls.Add(this.buttonCreer);
            this.Name = "Communication";
            this.Text = "TPSocket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreer;
        private System.Windows.Forms.Button buttonFerme;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonTimeout;
        private System.Windows.Forms.Button buttonRecTimer;
        private System.Windows.Forms.Button buttonRecThread;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelRec;
        private System.Windows.Forms.Label labelDest;
        private System.Windows.Forms.TextBox ipRec;
        private System.Windows.Forms.TextBox ipDest;
        private System.Windows.Forms.TextBox portRec;
        private System.Windows.Forms.TextBox portDest;
        private System.Windows.Forms.TextBox textLineSend;
        private System.Windows.Forms.TextBox textLineRec;
        private System.Windows.Forms.Label labelSend;
        private System.Windows.Forms.Label labelReceived;
        private System.Windows.Forms.Label labelCIDR1;
        private System.Windows.Forms.Label labelCIDR2;
    }
}