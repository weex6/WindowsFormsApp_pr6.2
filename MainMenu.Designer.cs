namespace WindowsFormsApp_pr6._2
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.chlMenu = new System.Windows.Forms.CheckedListBox();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PeachPuff;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "Меню";
            // 
            // chlMenu
            // 
            this.chlMenu.BackColor = System.Drawing.Color.Bisque;
            this.chlMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chlMenu.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chlMenu.FormattingEnabled = true;
            this.chlMenu.Items.AddRange(new object[] {
            "Маргарита 330 гр, 330 р",
            "Ветчина грибы 410 гр, 430 р",
            "Четыре сыра 400 гр, 470 р",
            "Креветка ананас 390 гр, 550 р",
            "Пепперони 430 гр, 450 р",
            "Вегетерианская 430 гр, 430 р"});
            this.chlMenu.Location = new System.Drawing.Point(73, 84);
            this.chlMenu.Name = "chlMenu";
            this.chlMenu.Size = new System.Drawing.Size(336, 200);
            this.chlMenu.TabIndex = 6;
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.BackColor = System.Drawing.Color.Coral;
            this.btnMakeOrder.Location = new System.Drawing.Point(183, 290);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(120, 44);
            this.btnMakeOrder.TabIndex = 5;
            this.btnMakeOrder.Text = "Сделать заказ";
            this.btnMakeOrder.UseVisualStyleBackColor = false;
            this.btnMakeOrder.Click += new System.EventHandler(this.btnMakeOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(204, 362);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(81, 38);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(478, 427);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chlMenu);
            this.Controls.Add(this.btnMakeOrder);
            this.Controls.Add(this.btnExit);
            this.MaximumSize = new System.Drawing.Size(494, 466);
            this.MinimumSize = new System.Drawing.Size(494, 466);
            this.Name = "MainMenu";
            this.Text = "Пиццерия";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckedListBox chlMenu;
        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.Button btnExit;
    }
}

