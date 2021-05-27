namespace QuizAgit
{
    partial class Form2
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
            this.expintoPDF = new System.Windows.Forms.Button();
            this.expintoExcel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // expintoPDF
            // 
            this.expintoPDF.Location = new System.Drawing.Point(234, 85);
            this.expintoPDF.Name = "expintoPDF";
            this.expintoPDF.Size = new System.Drawing.Size(117, 23);
            this.expintoPDF.TabIndex = 0;
            this.expintoPDF.Text = "Export into PDF";
            this.expintoPDF.UseVisualStyleBackColor = true;
            this.expintoPDF.Click += new System.EventHandler(this.expintoPDF_Click);
            // 
            // expintoExcel
            // 
            this.expintoExcel.Location = new System.Drawing.Point(357, 85);
            this.expintoExcel.Name = "expintoExcel";
            this.expintoExcel.Size = new System.Drawing.Size(109, 23);
            this.expintoExcel.TabIndex = 1;
            this.expintoExcel.Text = "Export into Excel";
            this.expintoExcel.UseVisualStyleBackColor = true;
            this.expintoExcel.Click += new System.EventHandler(this.expintoExcel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 322);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.expintoExcel);
            this.Controls.Add(this.expintoPDF);
            this.Name = "Form2";
            this.Text = "ReportBarang002";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button expintoPDF;
        private System.Windows.Forms.Button expintoExcel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}