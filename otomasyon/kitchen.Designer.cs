namespace otomasyon
{
    partial class kitchen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitchen));
            this.btnReady = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lstKitchen = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnReady
            // 
            this.btnReady.Image = ((System.Drawing.Image)(resources.GetObject("btnReady.Image")));
            this.btnReady.Location = new System.Drawing.Point(371, 371);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(61, 52);
            this.btnReady.TabIndex = 2;
            this.btnReady.UseVisualStyleBackColor = true;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(683, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 52);
            this.button2.TabIndex = 3;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lstKitchen
            // 
            this.lstKitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstKitchen.FullRowSelect = true;
            this.lstKitchen.HideSelection = false;
            this.lstKitchen.Location = new System.Drawing.Point(148, 12);
            this.lstKitchen.Name = "lstKitchen";
            this.lstKitchen.Size = new System.Drawing.Size(482, 344);
            this.lstKitchen.TabIndex = 4;
            this.lstKitchen.UseCompatibleStateImageBehavior = false;
            this.lstKitchen.View = System.Windows.Forms.View.Details;
            // 
            // kitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstKitchen);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnReady);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "kitchen";
            this.Text = "kitchen";
            this.Load += new System.EventHandler(this.kitchen_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ListView lstKitchen;
    }
}