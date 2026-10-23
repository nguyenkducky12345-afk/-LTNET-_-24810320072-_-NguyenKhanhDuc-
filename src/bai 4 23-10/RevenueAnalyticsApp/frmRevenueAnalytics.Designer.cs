namespace RevenueAnalyticsApp
{
    partial class frmRevenueAnalytics
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
            grpFilter = new GroupBox();
            lblBranch = new Label();
            cboBranch = new ComboBox();
            lblToDate = new Label();
            dtpToDate = new DateTimePicker();
            lblFromDate = new Label();
            dtpFromDate = new DateTimePicker();
            btnAnalyze = new Button();
            btnCancel = new Button();
            grpStatus = new GroupBox();
            lblProcessingStatus = new Label();
            pgbLoading = new ProgressBar();
            grpResult = new GroupBox();
            dgvRevenueData = new DataGridView();
            grpFilter.SuspendLayout();
            grpStatus.SuspendLayout();
            grpResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRevenueData).BeginInit();
            SuspendLayout();
            // 
            // grpFilter
            // 
            grpFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpFilter.Controls.Add(lblBranch);
            grpFilter.Controls.Add(cboBranch);
            grpFilter.Controls.Add(lblToDate);
            grpFilter.Controls.Add(dtpToDate);
            grpFilter.Controls.Add(lblFromDate);
            grpFilter.Controls.Add(dtpFromDate);
            grpFilter.Controls.Add(btnAnalyze);
            grpFilter.Controls.Add(btnCancel);
            grpFilter.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpFilter.Location = new Point(12, 12);
            grpFilter.Name = "grpFilter";
            grpFilter.Size = new Size(860, 95);
            grpFilter.TabIndex = 0;
            grpFilter.TabStop = false;
            grpFilter.Text = "Khu vực tiêu chí lọc dữ liệu";
            // 
            // lblFromDate
            // 
            lblFromDate.AutoSize = true;
            lblFromDate.Font = new Font("Segoe UI", 9F);
            lblFromDate.Location = new Point(15, 27);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new Size(52, 15);
            lblFromDate.TabIndex = 0;
            lblFromDate.Text = "Từ ngày:";
            // 
            // dtpFromDate
            // 
            dtpFromDate.CustomFormat = "dd/MM/yyyy";
            dtpFromDate.Font = new Font("Segoe UI", 9F);
            dtpFromDate.Format = DateTimePickerFormat.Custom;
            dtpFromDate.Location = new Point(18, 48);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(130, 23);
            dtpFromDate.TabIndex = 1;
            // 
            // lblToDate
            // 
            lblToDate.AutoSize = true;
            lblToDate.Font = new Font("Segoe UI", 9F);
            lblToDate.Location = new Point(165, 27);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new Size(60, 15);
            lblToDate.TabIndex = 2;
            lblToDate.Text = "Đến ngày:";
            // 
            // dtpToDate
            // 
            dtpToDate.CustomFormat = "dd/MM/yyyy";
            dtpToDate.Font = new Font("Segoe UI", 9F);
            dtpToDate.Format = DateTimePickerFormat.Custom;
            dtpToDate.Location = new Point(168, 48);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(130, 23);
            dtpToDate.TabIndex = 3;
            // 
            // lblBranch
            // 
            lblBranch.AutoSize = true;
            lblBranch.Font = new Font("Segoe UI", 9F);
            lblBranch.Location = new Point(315, 27);
            lblBranch.Name = "lblBranch";
            lblBranch.Size = new Size(65, 15);
            lblBranch.TabIndex = 4;
            lblBranch.Text = "Chi nhánh:";
            // 
            // cboBranch
            // 
            cboBranch.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBranch.Font = new Font("Segoe UI", 9F);
            cboBranch.FormattingEnabled = true;
            cboBranch.Location = new Point(318, 48);
            cboBranch.Name = "cboBranch";
            cboBranch.Size = new Size(170, 23);
            cboBranch.TabIndex = 5;
            // 
            // btnAnalyze
            // 
            btnAnalyze.BackColor = Color.FromArgb(0, 122, 204);
            btnAnalyze.Cursor = Cursors.Hand;
            btnAnalyze.FlatStyle = FlatStyle.Flat;
            btnAnalyze.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAnalyze.ForeColor = Color.White;
            btnAnalyze.Location = new Point(510, 42);
            btnAnalyze.Name = "btnAnalyze";
            btnAnalyze.Size = new Size(160, 34);
            btnAnalyze.TabIndex = 6;
            btnAnalyze.Text = "Thống Kê Doanh Thu";
            btnAnalyze.UseVisualStyleBackColor = false;
            btnAnalyze.Click += btnAnalyze_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(217, 83, 79);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Enabled = false;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(685, 42);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 34);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Hủy Thao Tác";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // grpStatus
            // 
            grpStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpStatus.Controls.Add(lblProcessingStatus);
            grpStatus.Controls.Add(pgbLoading);
            grpStatus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpStatus.Location = new Point(12, 113);
            grpStatus.Name = "grpStatus";
            grpStatus.Size = new Size(860, 85);
            grpStatus.TabIndex = 1;
            grpStatus.TabStop = false;
            grpStatus.Text = "Khu vực trạng thái tiến trình";
            // 
            // pgbLoading
            // 
            pgbLoading.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pgbLoading.Location = new Point(18, 25);
            pgbLoading.Name = "pgbLoading";
            pgbLoading.Size = new Size(825, 23);
            pgbLoading.TabIndex = 0;
            // 
            // lblProcessingStatus
            // 
            lblProcessingStatus.AutoSize = true;
            lblProcessingStatus.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblProcessingStatus.ForeColor = Color.FromArgb(64, 64, 64);
            lblProcessingStatus.Location = new Point(18, 55);
            lblProcessingStatus.Name = "lblProcessingStatus";
            lblProcessingStatus.Size = new Size(125, 15);
            lblProcessingStatus.TabIndex = 1;
            lblProcessingStatus.Text = "Sẵn sàng nhận tác vụ.";
            // 
            // grpResult
            // 
            grpResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpResult.Controls.Add(dgvRevenueData);
            grpResult.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpResult.Location = new Point(12, 204);
            grpResult.Name = "grpResult";
            grpResult.Size = new Size(860, 345);
            grpResult.TabIndex = 2;
            grpResult.TabStop = false;
            grpResult.Text = "Khu vực kết quả: Danh sách giao dịch chi tiết";
            // 
            // dgvRevenueData
            // 
            dgvRevenueData.AllowUserToAddRows = false;
            dgvRevenueData.AllowUserToDeleteRows = false;
            dgvRevenueData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRevenueData.BackgroundColor = SystemColors.Window;
            dgvRevenueData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRevenueData.Dock = DockStyle.Fill;
            dgvRevenueData.Location = new Point(3, 20);
            dgvRevenueData.Name = "dgvRevenueData";
            dgvRevenueData.ReadOnly = true;
            dgvRevenueData.RowHeadersVisible = false;
            dgvRevenueData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRevenueData.Size = new Size(854, 322);
            dgvRevenueData.TabIndex = 0;
            // 
            // frmRevenueAnalytics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(884, 561);
            Controls.Add(grpResult);
            Controls.Add(grpStatus);
            Controls.Add(grpFilter);
            MinimumSize = new Size(700, 450);
            Name = "frmRevenueAnalytics";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bảng Điều Khiển Thống Kê Doanh Thu (Multi-Threading Async/Await)";
            grpFilter.ResumeLayout(false);
            grpFilter.PerformLayout();
            grpStatus.ResumeLayout(false);
            grpStatus.PerformLayout();
            grpResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRevenueData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpFilter;
        private Label lblFromDate;
        private DateTimePicker dtpFromDate;
        private Label lblToDate;
        private DateTimePicker dtpToDate;
        private Label lblBranch;
        private ComboBox cboBranch;
        private Button btnAnalyze;
        private Button btnCancel;
        private GroupBox grpStatus;
        private ProgressBar pgbLoading;
        private Label lblProcessingStatus;
        private GroupBox grpResult;
        private DataGridView dgvRevenueData;
    }
}