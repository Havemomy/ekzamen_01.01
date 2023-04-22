namespace mebelnoye_bezumie {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.mebels_datagrid = new System.Windows.Forms.DataGridView();
            this.search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mebels_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mebels_datagrid
            // 
            this.mebels_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mebels_datagrid.Location = new System.Drawing.Point(73, 24);
            this.mebels_datagrid.Name = "mebels_datagrid";
            this.mebels_datagrid.Size = new System.Drawing.Size(594, 315);
            this.mebels_datagrid.TabIndex = 0;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(259, 372);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(185, 23);
            this.search.TabIndex = 1;
            this.search.Text = "Поиск";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.search);
            this.Controls.Add(this.mebels_datagrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mebels_datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView mebels_datagrid;
        private System.Windows.Forms.Button search;
    }
}

