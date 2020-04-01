namespace CourseWork
{
    partial class ClientRequests
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
            this.RequestsStatusDgv = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Area_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Request_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rooms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.square = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RequestsStatusDgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(8)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.RequestsStatusDgv);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 635);
            this.panel1.TabIndex = 1;
            // 
            // RequestsStatusDgv
            // 
            this.RequestsStatusDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RequestsStatusDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Area_id,
            this.Request_id,
            this.ClientName,
            this.ClientSurname,
            this.AreaName,
            this.Rooms,
            this.square,
            this.price,
            this.Paid});
            this.RequestsStatusDgv.Location = new System.Drawing.Point(92, 164);
            this.RequestsStatusDgv.Name = "RequestsStatusDgv";
            this.RequestsStatusDgv.Size = new System.Drawing.Size(756, 231);
            this.RequestsStatusDgv.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 107);
            this.panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(889, 0);
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
            this.label1.Size = new System.Drawing.Size(919, 107);
            this.label1.TabIndex = 0;
            this.label1.Text = "Статус ваших заявок";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Area_id
            // 
            this.Area_id.HeaderText = "Area_id";
            this.Area_id.Name = "Area_id";
            this.Area_id.Visible = false;
            // 
            // Request_id
            // 
            this.Request_id.HeaderText = "Request_id";
            this.Request_id.Name = "Request_id";
            this.Request_id.Visible = false;
            // 
            // ClientName
            // 
            this.ClientName.HeaderText = "ClientName";
            this.ClientName.Name = "ClientName";
            // 
            // ClientSurname
            // 
            this.ClientSurname.HeaderText = "ClientSurname";
            this.ClientSurname.Name = "ClientSurname";
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
            // square
            // 
            this.square.HeaderText = "square";
            this.square.Name = "square";
            // 
            // price
            // 
            this.price.HeaderText = "price";
            this.price.Name = "price";
            // 
            // Paid
            // 
            this.Paid.HeaderText = "Paid";
            this.Paid.Name = "Paid";
            // 
            // ClientRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 635);
            this.Controls.Add(this.panel1);
            this.Name = "ClientRequests";
            this.Text = "ClientRequests";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RequestsStatusDgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView RequestsStatusDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Request_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn square;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Paid;
    }
}