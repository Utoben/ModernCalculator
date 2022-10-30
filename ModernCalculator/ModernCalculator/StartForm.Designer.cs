namespace ModernCalculator
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.ExitButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TraseryPriceBaseButton = new System.Windows.Forms.Button();
            this.MainCalculationButton = new System.Windows.Forms.Button();
            this.ProductPriceButton = new System.Windows.Forms.Button();
            this.TonnageButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(140, 281);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(102, 32);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(371, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // TraseryPriceBaseButton
            // 
            this.TraseryPriceBaseButton.Location = new System.Drawing.Point(200, 66);
            this.TraseryPriceBaseButton.Name = "TraseryPriceBaseButton";
            this.TraseryPriceBaseButton.Size = new System.Drawing.Size(141, 80);
            this.TraseryPriceBaseButton.TabIndex = 2;
            this.TraseryPriceBaseButton.Text = "База цен узоров";
            this.TraseryPriceBaseButton.UseVisualStyleBackColor = true;
            // 
            // MainCalculationButton
            // 
            this.MainCalculationButton.Location = new System.Drawing.Point(24, 66);
            this.MainCalculationButton.Name = "MainCalculationButton";
            this.MainCalculationButton.Size = new System.Drawing.Size(157, 80);
            this.MainCalculationButton.TabIndex = 3;
            this.MainCalculationButton.Text = "Основная калькуляция";
            this.MainCalculationButton.UseVisualStyleBackColor = true;
            // 
            // ProductPriceButton
            // 
            this.ProductPriceButton.Location = new System.Drawing.Point(24, 176);
            this.ProductPriceButton.Name = "ProductPriceButton";
            this.ProductPriceButton.Size = new System.Drawing.Size(157, 78);
            this.ProductPriceButton.TabIndex = 4;
            this.ProductPriceButton.Text = "Прайс по изделиям";
            this.ProductPriceButton.UseVisualStyleBackColor = true;
            // 
            // TonnageButton
            // 
            this.TonnageButton.Location = new System.Drawing.Point(200, 176);
            this.TonnageButton.Name = "TonnageButton";
            this.TonnageButton.Size = new System.Drawing.Size(141, 78);
            this.TonnageButton.TabIndex = 5;
            this.TonnageButton.Text = "Тоннаж";
            this.TonnageButton.UseVisualStyleBackColor = true;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(371, 338);
            this.Controls.Add(this.TonnageButton);
            this.Controls.Add(this.ProductPriceButton);
            this.Controls.Add(this.MainCalculationButton);
            this.Controls.Add(this.TraseryPriceBaseButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "StartForm";
            this.Text = "Modern Calculation";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Button TraseryPriceBaseButton;
        private System.Windows.Forms.Button MainCalculationButton;
        private System.Windows.Forms.Button ProductPriceButton;
        private System.Windows.Forms.Button TonnageButton;
    }
}

