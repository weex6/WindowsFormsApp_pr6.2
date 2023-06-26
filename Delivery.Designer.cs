namespace WindowsFormsApp_pr6._2
{
    partial class Delivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delivery));
            this.label1 = new System.Windows.Forms.Label();
            this.btnInCity = new System.Windows.Forms.Button();
            this.btnOutCity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(46, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Куда необходима доставка?";
            // 
            // btnInCity
            // 
            this.btnInCity.Location = new System.Drawing.Point(50, 86);
            this.btnInCity.Name = "btnInCity";
            this.btnInCity.Size = new System.Drawing.Size(123, 49);
            this.btnInCity.TabIndex = 1;
            this.btnInCity.Text = "В черте города";
            this.btnInCity.UseVisualStyleBackColor = true;
            this.btnInCity.Click += new System.EventHandler(this.btnInCity_Click);
            // 
            // btnOutCity
            // 
            this.btnOutCity.Location = new System.Drawing.Point(190, 86);
            this.btnOutCity.Name = "btnOutCity";
            this.btnOutCity.Size = new System.Drawing.Size(123, 49);
            this.btnOutCity.TabIndex = 2;
            this.btnOutCity.Text = "За пределы города";
            this.btnOutCity.UseVisualStyleBackColor = true;
            this.btnOutCity.Click += new System.EventHandler(this.btnOutCity_Click);
            // 
            // Delivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(357, 181);
            this.Controls.Add(this.btnOutCity);
            this.Controls.Add(this.btnInCity);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(373, 220);
            this.MinimumSize = new System.Drawing.Size(373, 220);
            this.Name = "Delivery";
            this.Text = "Доставка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInCity;
        private System.Windows.Forms.Button btnOutCity;
    }
}