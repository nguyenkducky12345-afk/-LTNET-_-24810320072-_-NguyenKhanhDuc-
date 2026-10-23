using System.Globalization;

namespace CryptoStockTicker
{
    public partial class frmCryptoStockTicker : Form
    {
        private CancellationTokenSource? _cancellationTokenSource;
        private readonly Random _random = new();

        private decimal _currentPrice = 65000.00m;
        private decimal? _previousPrice = null;
        private int _syncCount = 0;

        public frmCryptoStockTicker()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnPause.Enabled = true;

            _cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = _cancellationTokenSource.Token;

            Task.Run(async () =>
            {
                while (!token.IsCancellationRequested)
                {
                    try
                    {
                        double percentChange = (_random.NextDouble() * 4.0) - 2.0;
                        decimal changeAmount = _currentPrice * (decimal)(percentChange / 100.0);
                        decimal newPrice = Math.Round(_currentPrice + changeAmount, 2);
                        DateTime timestamp = DateTime.Now;

                        UpdateFinancialUI(newPrice, timestamp);

                        await Task.Delay(2000, token);
                    }
                    catch (TaskCanceledException)
                    {
                        break;
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"Error in background loop: {ex.Message}");
                    }
                }
            }, token);
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            StopMonitoring();
        }

        private void StopMonitoring()
        {
            if (_cancellationTokenSource != null && !_cancellationTokenSource.IsCancellationRequested)
            {
                _cancellationTokenSource.Cancel();
                _cancellationTokenSource.Dispose();
                _cancellationTokenSource = null;
            }

            btnStart.Enabled = true;
            btnPause.Enabled = false;
        }

        private void UpdateFinancialUI(decimal newPrice, DateTime timestamp)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => UpdateFinancialUI(newPrice, timestamp)));
                return;
            }

            _syncCount++;

            decimal diff = 0;
            string statusText = "Khởi tạo";
            Color trendColor = Color.Black;

            if (_previousPrice.HasValue)
            {
                diff = newPrice - _previousPrice.Value;
                if (diff > 0)
                {
                    statusText = "TĂNG ▲";
                    trendColor = Color.ForestGreen;
                }
                else if (diff < 0)
                {
                    statusText = "GIẢM ▼";
                    trendColor = Color.Red;
                }
                else
                {
                    statusText = "KHÔNG ĐỔI ▬";
                    trendColor = Color.DarkSlateGray;
                }
            }

            lblBTCPrice.Text = $"${newPrice.ToString("N2", CultureInfo.InvariantCulture)} USD";
            lblBTCPrice.ForeColor = trendColor;

            lblStatusUpdate.Text = $"Lần cập nhật cuối: {timestamp:HH:mm:ss}";
            lblStatusSyncCount.Text = $"Số lượt đồng bộ: {_syncCount}";

            string strDiff = (diff >= 0 ? "+" : "") + diff.ToString("N2", CultureInfo.InvariantCulture) + " USD";
            // ĐOẠN MỚI (ĐÃ SỬA):
            dgvHistoryLog.Rows.Insert(
                0,
                timestamp.ToString("HH:mm:ss"),
                "$" + newPrice.ToString("N2", CultureInfo.InvariantCulture),
                strDiff,
                statusText
            );
            int rowIndex = 0;

            dgvHistoryLog.Rows[rowIndex].Cells["colPrice"].Style.ForeColor = trendColor;
            dgvHistoryLog.Rows[rowIndex].Cells["colChange"].Style.ForeColor = trendColor;
            dgvHistoryLog.Rows[rowIndex].Cells["colStatus"].Style.ForeColor = trendColor;

            if (dgvHistoryLog.Rows.Count > 50)
            {
                dgvHistoryLog.Rows.RemoveAt(dgvHistoryLog.Rows.Count - 1);
            }

            _previousPrice = newPrice;
            _currentPrice = newPrice;
        }

        private void frmCryptoStockTicker_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopMonitoring();
        }
    }
}