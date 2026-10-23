using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RevenueAnalyticsApp.Models;

namespace RevenueAnalyticsApp
{
    public partial class frmRevenueAnalytics : Form
    {
        private CancellationTokenSource? _cts;

        public frmRevenueAnalytics()
        {
            InitializeComponent();
            ConfigureInitialData();
            ConfigureDataGridView();
        }

        private void ConfigureInitialData()
        {
            dtpFromDate.Value = DateTime.Today.AddDays(-30);
            dtpToDate.Value = DateTime.Today;

            cboBranch.Items.AddRange(new object[]
            {
                "Tất cả chi nhánh",
                "Chi nhánh Hà Nội",
                "Chi nhánh TP. Hồ Chí Minh",
                "Chi nhánh Đà Nẵng",
                "Chi nhánh Cần Thơ"
            });
            cboBranch.SelectedIndex = 0;
        }

        private void ConfigureDataGridView()
        {
            dgvRevenueData.AutoGenerateColumns = false;
            dgvRevenueData.Columns.Clear();

            dgvRevenueData.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Transaction.TransactionId),
                HeaderText = "Mã Giao Dịch",
                FillWeight = 100
            });
            dgvRevenueData.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Transaction.TransactionDate),
                HeaderText = "Ngày Giao Dịch",
                DefaultCellStyle = { Format = "dd/MM/yyyy HH:mm" },
                FillWeight = 120
            });
            dgvRevenueData.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Transaction.BranchName),
                HeaderText = "Chi Nhánh",
                FillWeight = 130
            });
            dgvRevenueData.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Transaction.CustomerName),
                HeaderText = "Khách Hàng",
                FillWeight = 140
            });
            dgvRevenueData.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Transaction.Amount),
                HeaderText = "Doanh Thu (VNĐ)",
                DefaultCellStyle = { Format = "#,##0 VNĐ", Alignment = DataGridViewContentAlignment.MiddleRight },
                FillWeight = 120
            });
            dgvRevenueData.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Transaction.PaymentMethod),
                HeaderText = "Phương Thức",
                FillWeight = 100
            });
            dgvRevenueData.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Transaction.Status),
                HeaderText = "Trạng Thái",
                FillWeight = 90
            });
        }

        private async void btnAnalyze_Click(object sender, EventArgs e)
        {
            if (dtpFromDate.Value > dtpToDate.Value)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _cts?.Dispose();
            _cts = new CancellationTokenSource();
            CancellationToken token = _cts.Token;

            SetProcessingState(isProcessing: true);
            dgvRevenueData.DataSource = null;
            pgbLoading.Value = 0;
            lblProcessingStatus.Text = "Đang kết nối CSDL và xử lý dữ liệu giao dịch lớn...";
            lblProcessingStatus.ForeColor = Color.DarkBlue;

            var progress = new Progress<(int Percent, string Message)>(report =>
            {
                pgbLoading.Value = Math.Clamp(report.Percent, 0, 100);
                lblProcessingStatus.Text = $"{report.Message} ({report.Percent}%)";
            });

            DateTime fromDate = dtpFromDate.Value;
            DateTime toDate = dtpToDate.Value;
            string selectedBranch = cboBranch.SelectedItem?.ToString() ?? "Tất cả chi nhánh";

            try
            {
                List<Transaction> resultData = await Task.Run(() =>
                    SimulateHeavyDatabaseWorkload(fromDate, toDate, selectedBranch, progress, token), token);

                dgvRevenueData.DataSource = resultData;
                lblProcessingStatus.Text = $"Hoàn tất thống kê! Tổng cộng {resultData.Count} giao dịch.";
                lblProcessingStatus.ForeColor = Color.DarkGreen;
                pgbLoading.Value = 100;
            }
            catch (OperationCanceledException)
            {
                pgbLoading.Value = 0;
                lblProcessingStatus.Text = "Đã hủy thao tác!";
                lblProcessingStatus.ForeColor = Color.Crimson;
                MessageBox.Show("Đã hủy thao tác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lblProcessingStatus.Text = $"Đã xảy ra lỗi: {ex.Message}";
                lblProcessingStatus.ForeColor = Color.Red;
                MessageBox.Show($"Lỗi trong quá trình xử lý: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SetProcessingState(isProcessing: false);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_cts != null && !_cts.IsCancellationRequested)
            {
                btnCancel.Enabled = false;
                lblProcessingStatus.Text = "Đang gửi yêu cầu dừng tiến trình...";
                _cts.Cancel();
            }
        }

        private List<Transaction> SimulateHeavyDatabaseWorkload(
            DateTime fromDate,
            DateTime toDate,
            string branchFilter,
            IProgress<(int Percent, string Message)> progress,
            CancellationToken token)
        {
            token.ThrowIfCancellationRequested();

            int totalSteps = 10;
            int delayPerStep = 500; // 10 x 500ms = 5 giây

            string[] stepDescriptions =
            {
                "Đang mở kết nối Pool tới CSDL...",
                "Đang truy xuất bảng hóa đơn giao dịch...",
                "Đang tính toán chiết khấu và thuế VAT...",
                "Đang nhóm doanh thu theo khu vực...",
                "Đang lọc dữ liệu chi nhánh đã chọn...",
                "Đang kiểm tra tính toàn vẹn số liệu...",
                "Đang đồng bộ dòng tiền với các cổng thanh toán...",
                "Đang xử lý thuật toán dự phóng doanh số...",
                "Đang hoàn thiện danh mục giao dịch chi tiết...",
                "Đang chuyển dữ liệu về giao diện..."
            };

            for (int i = 0; i < totalSteps; i++)
            {
                token.ThrowIfCancellationRequested();
                Thread.Sleep(delayPerStep);
                token.ThrowIfCancellationRequested();

                int percent = (i + 1) * 10;
                progress.Report((percent, stepDescriptions[i]));
            }

            return GenerateMockTransactions(fromDate, toDate, branchFilter, token);
        }

        private List<Transaction> GenerateMockTransactions(DateTime from, DateTime to, string branch, CancellationToken token)
        {
            var list = new List<Transaction>();
            var random = new Random();
            string[] customers = { "Nguyễn Văn An", "Trần Thị Bích", "Lê Hoàng Nam", "Phạm Thu Thảo", "Vũ Đình Trọng", "Đặng Thùy Dung" };
            string[] methods = { "Chuyển khoản QR", "Tiền mặt", "Thẻ POS", "Ví điện tử MoMo" };
            string[] branches = { "Chi nhánh Hà Nội", "Chi nhánh TP. Hồ Chí Minh", "Chi nhánh Đà Nẵng", "Chi nhánh Cần Thơ" };

            int numberOfRecords = 120;
            int totalDays = Math.Max(1, (int)(to - from).TotalDays);

            for (int i = 1; i <= numberOfRecords; i++)
            {
                if (i % 20 == 0)
                {
                    token.ThrowIfCancellationRequested();
                }

                string assignedBranch = (branch == "Tất cả chi nhánh")
                    ? branches[random.Next(branches.Length)]
                    : branch;

                list.Add(new Transaction
                {
                    TransactionId = $"GD{DateTime.Now:yyyyMM}{i:D5}",
                    TransactionDate = from.AddDays(random.Next(0, totalDays)).AddHours(random.Next(8, 21)),
                    BranchName = assignedBranch,
                    CustomerName = customers[random.Next(customers.Length)],
                    Amount = random.Next(150, 4500) * 10_000m,
                    PaymentMethod = methods[random.Next(methods.Length)],
                    Status = "Thành công"
                });
            }

            return list;
        }

        private void SetProcessingState(bool isProcessing)
        {
            btnAnalyze.Enabled = !isProcessing;
            btnCancel.Enabled = isProcessing;
            dtpFromDate.Enabled = !isProcessing;
            dtpToDate.Enabled = !isProcessing;
            cboBranch.Enabled = !isProcessing;
            Cursor = isProcessing ? Cursors.AppStarting : Cursors.Default;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_cts != null)
            {
                _cts.Cancel();
                _cts.Dispose();
            }
            base.OnFormClosing(e);
        }
    }
}