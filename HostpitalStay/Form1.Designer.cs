namespace HostpitalStay
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
            this.miscGB = new System.Windows.Forms.GroupBox();
            this.surgicalLB = new System.Windows.Forms.Label();
            this.rehabTB = new System.Windows.Forms.TextBox();
            this.labTB = new System.Windows.Forms.TextBox();
            this.surgicalTB = new System.Windows.Forms.TextBox();
            this.medsTB = new System.Windows.Forms.TextBox();
            this.rehabLB = new System.Windows.Forms.Label();
            this.medsLB = new System.Windows.Forms.Label();
            this.labLB = new System.Windows.Forms.Label();
            this.outputLB = new System.Windows.Forms.Label();
            this.daysLB = new System.Windows.Forms.Label();
            this.daysTB = new System.Windows.Forms.TextBox();
            this.miscGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // miscGB
            // 
            this.miscGB.Controls.Add(this.surgicalLB);
            this.miscGB.Controls.Add(this.rehabTB);
            this.miscGB.Controls.Add(this.labTB);
            this.miscGB.Controls.Add(this.surgicalTB);
            this.miscGB.Controls.Add(this.medsTB);
            this.miscGB.Controls.Add(this.rehabLB);
            this.miscGB.Controls.Add(this.medsLB);
            this.miscGB.Controls.Add(this.labLB);
            this.miscGB.Location = new System.Drawing.Point(12, 12);
            this.miscGB.Name = "miscGB";
            this.miscGB.Size = new System.Drawing.Size(215, 122);
            this.miscGB.TabIndex = 0;
            this.miscGB.TabStop = false;
            this.miscGB.Text = "Misc Costs ($)";
            // 
            // surgicalLB
            // 
            this.surgicalLB.AutoSize = true;
            this.surgicalLB.Location = new System.Drawing.Point(49, 46);
            this.surgicalLB.Name = "surgicalLB";
            this.surgicalLB.Size = new System.Drawing.Size(51, 13);
            this.surgicalLB.TabIndex = 10;
            this.surgicalLB.Text = "Surgical: ";
            // 
            // rehabTB
            // 
            this.rehabTB.Location = new System.Drawing.Point(106, 91);
            this.rehabTB.Name = "rehabTB";
            this.rehabTB.Size = new System.Drawing.Size(100, 20);
            this.rehabTB.TabIndex = 9;
            this.rehabTB.TextChanged += new System.EventHandler(this.rehabTB_TextChanged);
            // 
            // labTB
            // 
            this.labTB.Location = new System.Drawing.Point(106, 65);
            this.labTB.Name = "labTB";
            this.labTB.Size = new System.Drawing.Size(100, 20);
            this.labTB.TabIndex = 8;
            this.labTB.TextChanged += new System.EventHandler(this.labTB_TextChanged);
            // 
            // surgicalTB
            // 
            this.surgicalTB.Location = new System.Drawing.Point(106, 39);
            this.surgicalTB.Name = "surgicalTB";
            this.surgicalTB.Size = new System.Drawing.Size(100, 20);
            this.surgicalTB.TabIndex = 7;
            this.surgicalTB.TextChanged += new System.EventHandler(this.surgicalTB_TextChanged);
            // 
            // medsTB
            // 
            this.medsTB.Location = new System.Drawing.Point(106, 13);
            this.medsTB.Name = "medsTB";
            this.medsTB.Size = new System.Drawing.Size(100, 20);
            this.medsTB.TabIndex = 6;
            this.medsTB.TextChanged += new System.EventHandler(this.medsTB_TextChanged);
            // 
            // rehabLB
            // 
            this.rehabLB.AutoSize = true;
            this.rehabLB.Location = new System.Drawing.Point(6, 94);
            this.rehabLB.Name = "rehabLB";
            this.rehabLB.Size = new System.Drawing.Size(94, 13);
            this.rehabLB.TabIndex = 4;
            this.rehabLB.Text = "Physical Therapy: ";
            // 
            // medsLB
            // 
            this.medsLB.AutoSize = true;
            this.medsLB.Location = new System.Drawing.Point(35, 20);
            this.medsLB.Name = "medsLB";
            this.medsLB.Size = new System.Drawing.Size(65, 13);
            this.medsLB.TabIndex = 5;
            this.medsLB.Text = "Medication: ";
            // 
            // labLB
            // 
            this.labLB.AutoSize = true;
            this.labLB.Location = new System.Drawing.Point(46, 68);
            this.labLB.Name = "labLB";
            this.labLB.Size = new System.Drawing.Size(54, 13);
            this.labLB.TabIndex = 3;
            this.labLB.Text = "Lab fees: ";
            // 
            // outputLB
            // 
            this.outputLB.AutoSize = true;
            this.outputLB.Location = new System.Drawing.Point(236, 103);
            this.outputLB.Name = "outputLB";
            this.outputLB.Size = new System.Drawing.Size(91, 13);
            this.outputLB.TabIndex = 1;
            this.outputLB.Text = "Your total cost is: ";
            // 
            // daysLB
            // 
            this.daysLB.Location = new System.Drawing.Point(236, 32);
            this.daysLB.Name = "daysLB";
            this.daysLB.Size = new System.Drawing.Size(100, 29);
            this.daysLB.TabIndex = 0;
            this.daysLB.Text = "How many days ($350 a day): ";
            // 
            // daysTB
            // 
            this.daysTB.Location = new System.Drawing.Point(236, 64);
            this.daysTB.Name = "daysTB";
            this.daysTB.Size = new System.Drawing.Size(100, 20);
            this.daysTB.TabIndex = 11;
            this.daysTB.TextChanged += new System.EventHandler(this.daysTB_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 148);
            this.Controls.Add(this.daysTB);
            this.Controls.Add(this.daysLB);
            this.Controls.Add(this.outputLB);
            this.Controls.Add(this.miscGB);
            this.Name = "Form1";
            this.Text = "Medical Costs";
            this.miscGB.ResumeLayout(false);
            this.miscGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox miscGB;
        private System.Windows.Forms.Label labLB;
        private System.Windows.Forms.Label rehabLB;
        private System.Windows.Forms.Label medsLB;
        private System.Windows.Forms.TextBox rehabTB;
        private System.Windows.Forms.TextBox labTB;
        private System.Windows.Forms.TextBox surgicalTB;
        private System.Windows.Forms.TextBox medsTB;
        private System.Windows.Forms.Label surgicalLB;
        private System.Windows.Forms.Label outputLB;
        private System.Windows.Forms.Label daysLB;
        private System.Windows.Forms.TextBox daysTB;
    }
}

