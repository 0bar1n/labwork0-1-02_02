
namespace labwork_0
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
            this.Names = new System.Windows.Forms.Label();
            this.bthAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Names
            // 
            this.Names.AutoSize = true;
            this.Names.Location = new System.Drawing.Point(12, 9);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(40, 13);
            this.Names.TabIndex = 0;
            this.Names.Text = "Names";
            this.Names.Click += new System.EventHandler(this.label1_Click);
            // 
            // bthAdd
            // 
            this.bthAdd.Location = new System.Drawing.Point(138, 55);
            this.bthAdd.Name = "bthAdd";
            this.bthAdd.Size = new System.Drawing.Size(100, 23);
            this.bthAdd.TabIndex = 1;
            this.bthAdd.Text = "Add Name";
            this.bthAdd.UseVisualStyleBackColor = true;
            this.bthAdd.Click += new System.EventHandler(this.bthAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(138, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // lstNames
            // 
            this.lstNames.FormattingEnabled = true;
            this.lstNames.Location = new System.Drawing.Point(12, 27);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(120, 95);
            this.lstNames.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 142);
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.bthAdd);
            this.Controls.Add(this.Names);
            this.Name = "Form1";
            this.Text = "Names";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Names;
        private System.Windows.Forms.Button bthAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ListBox lstNames;
    }
}

