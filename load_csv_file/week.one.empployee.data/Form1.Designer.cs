namespace week.one.empployee.data
{
    partial class Form1
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
            this.dgvEmployeeData = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.radioBtnLoad3 = new System.Windows.Forms.RadioButton();
            this.radioBtnLoad5 = new System.Windows.Forms.RadioButton();
            this.radioBtnLoadAll = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployeeData
            // 
            this.dgvEmployeeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeData.Location = new System.Drawing.Point(12, 35);
            this.dgvEmployeeData.Name = "dgvEmployeeData";
            this.dgvEmployeeData.Size = new System.Drawing.Size(1463, 405);
            this.dgvEmployeeData.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // radioBtnLoad3
            // 
            this.radioBtnLoad3.AutoSize = true;
            this.radioBtnLoad3.Location = new System.Drawing.Point(12, 12);
            this.radioBtnLoad3.Name = "radioBtnLoad3";
            this.radioBtnLoad3.Size = new System.Drawing.Size(131, 17);
            this.radioBtnLoad3.TabIndex = 4;
            this.radioBtnLoad3.TabStop = true;
            this.radioBtnLoad3.Text = "Load 3 Employee Files";
            this.radioBtnLoad3.UseVisualStyleBackColor = true;
            this.radioBtnLoad3.CheckedChanged += new System.EventHandler(this.radioBtnLoad3_CheckedChanged);
            // 
            // radioBtnLoad5
            // 
            this.radioBtnLoad5.AutoSize = true;
            this.radioBtnLoad5.Location = new System.Drawing.Point(161, 12);
            this.radioBtnLoad5.Name = "radioBtnLoad5";
            this.radioBtnLoad5.Size = new System.Drawing.Size(131, 17);
            this.radioBtnLoad5.TabIndex = 5;
            this.radioBtnLoad5.TabStop = true;
            this.radioBtnLoad5.Text = "Load 5 Employee Files";
            this.radioBtnLoad5.UseVisualStyleBackColor = true;
            this.radioBtnLoad5.CheckedChanged += new System.EventHandler(this.radioBtnLoad5_CheckedChanged);
            // 
            // radioBtnLoadAll
            // 
            this.radioBtnLoadAll.AutoSize = true;
            this.radioBtnLoadAll.Location = new System.Drawing.Point(312, 12);
            this.radioBtnLoadAll.Name = "radioBtnLoadAll";
            this.radioBtnLoadAll.Size = new System.Drawing.Size(136, 17);
            this.radioBtnLoadAll.TabIndex = 6;
            this.radioBtnLoadAll.TabStop = true;
            this.radioBtnLoadAll.Text = "Load All Employee Files";
            this.radioBtnLoadAll.UseVisualStyleBackColor = true;
            this.radioBtnLoadAll.CheckedChanged += new System.EventHandler(this.radioBtnLoadAll_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 457);
            this.Controls.Add(this.radioBtnLoadAll);
            this.Controls.Add(this.radioBtnLoad5);
            this.Controls.Add(this.radioBtnLoad3);
            this.Controls.Add(this.dgvEmployeeData);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Week One Assignment";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployeeData;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton radioBtnLoad3;
        private System.Windows.Forms.RadioButton radioBtnLoad5;
        private System.Windows.Forms.RadioButton radioBtnLoadAll;
    }
}

