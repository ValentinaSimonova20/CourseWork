namespace CourseWork
{
    partial class ContractsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ContractDataGridView = new System.Windows.Forms.DataGridView();
            this.OwnerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnerSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SquareMetrs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(8)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.ContractDataGridView);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 616);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 107);
            this.panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(947, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 29);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(977, 107);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ваши контракты";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CourseWork.Properties.Resources.y1;
            this.pictureBox3.Location = new System.Drawing.Point(12, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ContractDataGridView
            // 
            this.ContractDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContractDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OwnerName,
            this.OwnerSurname,
            this.AreaName,
            this.Rooms,
            this.SquareMetrs,
            this.Price});
            this.ContractDataGridView.Location = new System.Drawing.Point(133, 161);
            this.ContractDataGridView.Name = "ContractDataGridView";
            this.ContractDataGridView.Size = new System.Drawing.Size(681, 255);
            this.ContractDataGridView.TabIndex = 1;
            // 
            // OwnerName
            // 
            this.OwnerName.HeaderText = "OwnerName";
            this.OwnerName.Name = "OwnerName";
            // 
            // OwnerSurname
            // 
            this.OwnerSurname.HeaderText = "OwnerSurname";
            this.OwnerSurname.Name = "OwnerSurname";
            // 
            // AreaName
            // 
            this.AreaName.HeaderText = "AreaName";
            this.AreaName.Name = "AreaName";
            // 
            // Rooms
            // 
            this.Rooms.HeaderText = "Rooms";
            this.Rooms.Name = "Rooms";
            // 
            // SquareMetrs
            // 
            this.SquareMetrs.HeaderText = "SquareMetrs";
            this.SquareMetrs.Name = "SquareMetrs";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // ContractsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 616);
            this.Controls.Add(this.panel1);
            this.Name = "ContractsForm";
            this.Text = "ContractsForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView ContractDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnerSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn SquareMetrs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}