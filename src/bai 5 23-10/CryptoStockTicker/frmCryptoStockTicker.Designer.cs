namespace CryptoStockTicker
{
    partial class frmCryptoStockTicker
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();

            this.grpControls = new System.Windows.Forms.GroupBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlPriceBoard = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBTCPrice = new System.Windows.Forms.Label();
            this.dgvHistoryLog = new System.Windows.Forms.DataGridView();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChange = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatusUpdate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusSyncCount = new System.Windows.Forms.ToolStripStatusLabel();

            this.grpControls.SuspendLayout();
            this.pnlPriceBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryLog)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();

            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.btnPause);
            this.grpControls.Controls.Add(this.btnStart);
            this.grpControls.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpControls.Location = new System.Drawing.Point(14, 12);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(656, 75);
            this.grpControls.TabIndex = 0;
            this.grpControls.TabStop = false;
            this.grpControls.Text = " Khu vực điều khiển ";

            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(20, 26);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(160, 36);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Bắt đầu Giám sát";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnPause.Enabled = false;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.Location = new System.Drawing.Point(195, 26);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(130, 36);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "Tạm dừng";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);

            // 
            // pnlPriceBoard
            // 
            this.pnlPriceBoard.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.pnlPriceBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPriceBoard.Controls.Add(this.lblTitle);
            this.pnlPriceBoard.Controls.Add(this.lblBTCPrice);
            this.pnlPriceBoard.Location = new System.Drawing.Point(14, 95);
            this.pnlPriceBoard.Name = "pnlPriceBoard";
            this.pnlPriceBoard.Size = new System.Drawing.Size(656, 85);
            this.pnlPriceBoard.TabIndex = 1;

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(70, 80, 95);
            this.lblTitle.Location = new System.Drawing.Point(18, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(155, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TỶ GIÁ BTC / USD HIỆN TẠI";

            // 
            // lblBTCPrice
            // 
            this.lblBTCPrice.AutoSize = true;
            this.lblBTCPrice.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblBTCPrice.ForeColor = System.Drawing.Color.Gray;
            this.lblBTCPrice.Location = new System.Drawing.Point(14, 32);
            this.lblBTCPrice.Name = "lblBTCPrice";
            this.lblBTCPrice.Size = new System.Drawing.Size(183, 45);
            this.lblBTCPrice.TabIndex = 1;
            this.lblBTCPrice.Text = "--- USD";

            // 
            // dgvHistoryLog
            // 
            this.dgvHistoryLog.AllowUserToAddRows = false;
            this.dgvHistoryLog.AllowUserToDeleteRows = false;
            this.dgvHistoryLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistoryLog.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(230, 235, 240);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistoryLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistoryLog.ColumnHeadersHeight = 32;
            this.dgvHistoryLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colTime,
                this.colPrice,
                this.colChange,
                this.colStatus
            });
            this.dgvHistoryLog.EnableHeadersVisualStyles = false;
            this.dgvHistoryLog.Location = new System.Drawing.Point(14, 190);
            this.dgvHistoryLog.Name = "dgvHistoryLog";
            this.dgvHistoryLog.ReadOnly = true;
            this.dgvHistoryLog.RowHeadersVisible = false;
            this.dgvHistoryLog.RowTemplate.Height = 26;
            this.dgvHistoryLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistoryLog.Size = new System.Drawing.Size(656, 260);
            this.dgvHistoryLog.TabIndex = 2;

            // 
            // colTime
            // 
            this.colTime.HeaderText = "Thời gian";
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;

            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Giá BTC/USD";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;

            // 
            // colChange
            // 
            this.colChange.HeaderText = "Biến động";
            this.colChange.Name = "colChange";
            this.colChange.ReadOnly = true;

            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Trạng thái";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;

            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.lblStatusUpdate,
                this.lblStatusSyncCount
            });
            this.statusStrip.Location = new System.Drawing.Point(0, 460);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(684, 25);
            this.statusStrip.TabIndex = 3;

            // 
            // lblStatusUpdate
            // 
            this.lblStatusUpdate.AutoSize = false;
            this.lblStatusUpdate.Name = "lblStatusUpdate";
            this.lblStatusUpdate.Size = new System.Drawing.Size(320, 20);
            this.lblStatusUpdate.Text = "Lần cập nhật cuối: Chưa có dữ liệu";
            this.lblStatusUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // lblStatusSyncCount
            // 
            this.lblStatusSyncCount.AutoSize = false;
            this.lblStatusSyncCount.Name = "lblStatusSyncCount";
            this.lblStatusSyncCount.Size = new System.Drawing.Size(320, 20);
            this.lblStatusSyncCount.Text = "Số lượt đồng bộ: 0";
            this.lblStatusSyncCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // frmCryptoStockTicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 485);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.dgvHistoryLog);
            this.Controls.Add(this.pnlPriceBoard);
            this.Controls.Add(this.grpControls);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCryptoStockTicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mô phỏng Giám sát Tỷ giá Tài chính Thời gian thực";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCryptoStockTicker_FormClosing);

            this.grpControls.ResumeLayout(false);
            this.pnlPriceBoard.ResumeLayout(false);
            this.pnlPriceBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoryLog)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Panel pnlPriceBoard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBTCPrice;
        private System.Windows.Forms.DataGridView dgvHistoryLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusUpdate;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusSyncCount;
    }
}