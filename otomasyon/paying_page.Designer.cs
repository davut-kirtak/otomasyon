namespace otomasyon
{
    partial class paying_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paying_page));
            this.lstPayment = new System.Windows.Forms.ListView();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.bckBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPayment
            // 
            this.lstPayment.HideSelection = false;
            this.lstPayment.Location = new System.Drawing.Point(164, 45);
            this.lstPayment.Name = "lstPayment";
            this.lstPayment.Size = new System.Drawing.Size(459, 305);
            this.lstPayment.TabIndex = 0;
            this.lstPayment.UseCompatibleStateImageBehavior = false;
            this.lstPayment.View = System.Windows.Forms.View.Details;
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.AutoSize = true;
            this.lblTableNumber.BackColor = System.Drawing.Color.White;
            this.lblTableNumber.Location = new System.Drawing.Point(92, 28);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(44, 16);
            this.lblTableNumber.TabIndex = 1;
            this.lblTableNumber.Text = "label1";
            // 
            // btnCash
            // 
            this.btnCash.Image = ((System.Drawing.Image)(resources.GetObject("btnCash.Image")));
            this.btnCash.Location = new System.Drawing.Point(164, 372);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(79, 56);
            this.btnCash.TabIndex = 2;
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCard
            // 
            this.btnCard.Image = ((System.Drawing.Image)(resources.GetObject("btnCard.Image")));
            this.btnCard.Location = new System.Drawing.Point(544, 372);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(79, 56);
            this.btnCard.TabIndex = 3;
            this.btnCard.UseVisualStyleBackColor = true;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(359, 382);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 16);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "label2";
            // 
            // bckBttn
            // 
            this.bckBttn.Image = ((System.Drawing.Image)(resources.GetObject("bckBttn.Image")));
            this.bckBttn.Location = new System.Drawing.Point(24, 28);
            this.bckBttn.Name = "bckBttn";
            this.bckBttn.Size = new System.Drawing.Size(53, 34);
            this.bckBttn.TabIndex = 5;
            this.bckBttn.UseVisualStyleBackColor = true;
            this.bckBttn.Click += new System.EventHandler(this.bckBttn_Click);
            // 
            // paying_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bckBttn);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCard);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.lblTableNumber);
            this.Controls.Add(this.lstPayment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "paying_page";
            this.Text = "paying_page";
            this.Load += new System.EventHandler(this.paying_page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstPayment;
        public System.Windows.Forms.Label lblTableNumber;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button bckBttn;
    }
}