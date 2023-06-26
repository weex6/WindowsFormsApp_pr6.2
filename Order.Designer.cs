namespace WindowsFormsApp_pr6._2
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.rtbOrder = new System.Windows.Forms.RichTextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbOrder = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.lbConfirm = new System.Windows.Forms.Label();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbOrder
            // 
            this.rtbOrder.BackColor = System.Drawing.Color.Bisque;
            this.rtbOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbOrder.Location = new System.Drawing.Point(57, 42);
            this.rtbOrder.Name = "rtbOrder";
            this.rtbOrder.ReadOnly = true;
            this.rtbOrder.Size = new System.Drawing.Size(230, 199);
            this.rtbOrder.TabIndex = 0;
            this.rtbOrder.Text = "";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPrice.Location = new System.Drawing.Point(28, 244);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(85, 25);
            this.lbPrice.TabIndex = 1;
            this.lbPrice.Text = "lbPrice";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbOrder
            // 
            this.lbOrder.AutoSize = true;
            this.lbOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbOrder.Location = new System.Drawing.Point(105, 14);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(124, 25);
            this.lbOrder.TabIndex = 2;
            this.lbOrder.Text = "Ваш заказ:";
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.YellowGreen;
            this.btnYes.Location = new System.Drawing.Point(84, 325);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 3;
            this.btnYes.Text = "Да";
            this.btnYes.UseVisualStyleBackColor = false;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // lbConfirm
            // 
            this.lbConfirm.AutoSize = true;
            this.lbConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbConfirm.Location = new System.Drawing.Point(129, 288);
            this.lbConfirm.Name = "lbConfirm";
            this.lbConfirm.Size = new System.Drawing.Size(86, 25);
            this.lbConfirm.TabIndex = 4;
            this.lbConfirm.Text = "Верно?";
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.Salmon;
            this.btnNo.Location = new System.Drawing.Point(184, 325);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 23);
            this.btnNo.TabIndex = 5;
            this.btnNo.Text = "Нет";
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(348, 374);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.lbConfirm);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lbOrder);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.rtbOrder);
            this.MaximumSize = new System.Drawing.Size(364, 413);
            this.MinimumSize = new System.Drawing.Size(364, 413);
            this.Name = "Order";
            this.Text = "Заказ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOrder;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbOrder;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Label lbConfirm;
        private System.Windows.Forms.Button btnNo;
    }
}