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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RequestsStatusDgv = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ContractDataGridView = new System.Windows.Forms.DataGridView();
            this.Contracts = new System.Windows.Forms.Label();
            this.ClientName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientSurname2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rooms2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.square2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(8)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.Contracts);
            this.panel1.Controls.Add(this.ContractDataGridView);
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
            this.RequestsStatusDgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.RequestsStatusDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RequestsStatusDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RequestsStatusDgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.RequestsStatusDgv.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RequestsStatusDgv.Location = new System.Drawing.Point(72, 113);
            this.RequestsStatusDgv.Name = "RequestsStatusDgv";
            this.RequestsStatusDgv.Size = new System.Drawing.Size(793, 231);
            this.RequestsStatusDgv.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(24)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 107);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseWork.Properties.Resources.y1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // ContractDataGridView
            // 
            this.ContractDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContractDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientName2,
            this.ClientSurname2,
            this.AreaName2,
            this.Rooms2,
            this.square2,
            this.price2});
            this.ContractDataGridView.Location = new System.Drawing.Point(72, 422);
            this.ContractDataGridView.Name = "ContractDataGridView";
            this.ContractDataGridView.Size = new System.Drawing.Size(645, 150);
            this.ContractDataGridView.TabIndex = 2;
            // 
            // Contracts
            // 
            this.Contracts.AutoSize = true;
            this.Contracts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Contracts.Location = new System.Drawing.Point(90, 384);
            this.Contracts.Name = "Contracts";
            this.Contracts.Size = new System.Drawing.Size(192, 25);
            this.Contracts.TabIndex = 3;
            this.Contracts.Text = "Ваши контракты";
            // 
            // ClientName2
            // 
            this.ClientName2.HeaderText = "ClientName2";
            this.ClientName2.Name = "ClientName2";
            // 
            // ClientSurname2
            // 
            this.ClientSurname2.HeaderText = "ClientSurname2";
            this.ClientSurname2.Name = "ClientSurname2";
            // 
            // AreaName2
            // 
            this.AreaName2.HeaderText = "AreaName2";
            this.AreaName2.Name = "AreaName2";
            // 
            // Rooms2
            // 
            this.Rooms2.HeaderText = "Rooms2";
            this.Rooms2.Name = "Rooms2";
            // 
            // square2
            // 
            this.square2.HeaderText = "square2";
            this.square2.Name = "square2";
            // 
            // price2
            // 
            this.price2.HeaderText = "price2";
            this.price2.Name = "price2";
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
            this.ClientName.HeaderText = "Имя клиента";
            this.ClientName.Name = "ClientName";
            // 
            // ClientSurname
            // 
            this.ClientSurname.HeaderText = "Фамилия клиента";
            this.ClientSurname.Name = "ClientSurname";
            // 
            // AreaName
            // 
            this.AreaName.HeaderText = "Название помещения";
            this.AreaName.Name = "AreaName";
            // 
            // Rooms
            // 
            this.Rooms.HeaderText = "Комнаты";
            this.Rooms.Name = "Rooms";
            // 
            // square
            // 
            this.square.HeaderText = "Площадь(м^2)";
            this.square.Name = "square";
            this.square.Width = 120;
            // 
            // price
            // 
            this.price.HeaderText = "Цена";
            this.price.Name = "price";
            // 
            // Paid
            // 
            this.Paid.HeaderText = "Оплачено";
            this.Paid.Name = "Paid";
            this.Paid.ReadOnly = true;
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
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RequestsStatusDgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView RequestsStatusDgv;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Contracts;
        private System.Windows.Forms.DataGridView ContractDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientSurname2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rooms2;
        private System.Windows.Forms.DataGridViewTextBoxColumn square2;
        private System.Windows.Forms.DataGridViewTextBoxColumn price2;
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