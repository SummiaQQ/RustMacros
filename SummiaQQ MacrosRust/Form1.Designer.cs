namespace SummiaQQ_MacrosRust
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Aka_47 = new System.Windows.Forms.Timer(this.components);
            this.LR_300 = new System.Windows.Forms.Timer(this.components);
            this.Tommy_Gun = new System.Windows.Forms.Timer(this.components);
            this.MP5K = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Aka_47
            // 
            this.Aka_47.Interval = 10;
            // 
            // LR_300
            // 
            this.LR_300.Interval = 10;
            // 
            // MP5K
            // 
            this.MP5K.Interval = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 154);
            this.Name = "Form1";
            this.Text = "Macros";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Aka_47;
        private System.Windows.Forms.Timer LR_300;
        private System.Windows.Forms.Timer Tommy_Gun;
        private System.Windows.Forms.Timer MP5K;
    }
}

