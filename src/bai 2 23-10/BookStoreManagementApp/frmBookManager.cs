using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookStoreManagementApp
{
    public partial class frmBookManager : Form
    {
        private BindingList<BookModel> _bookList = new BindingList<BookModel>();
        private BindingSource _bindingSource = new BindingSource();
        private string _currentCoverPath = string.Empty;

        public frmBookManager()
        {
            InitializeComponent();
            InitIcons();
            InitCategories();
            SetupDataGridView();
            SetupDataBinding();
            LoadDefaultSampleData();
            UpdateStatusStrip();
            UpdateClock();
        }

        private void InitIcons()
        {
            tsbOpen.Image = CreateColorIcon(Color.DarkGoldenrod, "O");
            tsbSave.Image = CreateColorIcon(Color.DodgerBlue, "S");
            tsbAdd.Image = CreateColorIcon(Color.ForestGreen, "+");
        }

        private Image CreateColorIcon(Color bg, string symbol)
        {
            Bitmap bmp = new Bitmap(16, 16);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(bg);
                using (Font font = new Font("Arial", 8, FontStyle.Bold))
                using (Brush brush = new SolidBrush(Color.White))
                {
                    var size = g.MeasureString(symbol, font);
                    g.DrawString(symbol, font, brush, (16 - size.Width) / 2, (16 - size.Height) / 2);
                }
            }
            return bmp;
        }

        private void InitCategories()
        {
            cboCategory.Items.Clear();
            cboCategory.Items.AddRange(new object[] {
                "Công nghệ thông tin",
                "Kinh tế - Kinh doanh",
                "Văn học - Nghệ thuật",
                "Khoa học - Kỹ thuật",
                "Ngoại ngữ - Từ điển"
            });
            cboCategory.SelectedIndex = 0;
        }

        private void SetupDataGridView()
        {
            dgvBooks.AutoGenerateColumns = false;
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.MultiSelect = false;
            dgvBooks.ReadOnly = true;
            dgvBooks.Columns.Clear();

            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(BookModel.BookId),
                HeaderText = "Mã sách",
                Width = 90
            });

            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(BookModel.Title),
                HeaderText = "Tên sách",
                Width = 230
            });

            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(BookModel.Author),
                HeaderText = "Tác giả",
                Width = 140
            });

            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(BookModel.Category),
                HeaderText = "Thể loại",
                Width = 130
            });

            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(BookModel.Quantity),
                HeaderText = "Số lượng",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(BookModel.Price),
                HeaderText = "Đơn giá",
                Width = 110,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(BookModel.TotalAmount),
                HeaderText = "Thành tiền",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight }
            });

            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(BookModel.CoverImageName),
                HeaderText = "Ảnh bìa",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        private void SetupDataBinding()
        {
            _bindingSource.DataSource = _bookList;
            dgvBooks.DataSource = _bindingSource;
            _bookList.ListChanged += (s, e) => UpdateStatusStrip();
        }

        private void LoadDefaultSampleData()
        {
            _bookList.Add(new BookModel
            {
                BookId = "B001",
                Title = "Lập trình C# từ cơ bản đến nâng cao",
                Author = "Phạm Văn Minh",
                Category = "Công nghệ thông tin",
                Quantity = 25,
                Price = 135000,
                CoverImagePath = "csharp_cover.jpg"
            });

            _bookList.Add(new BookModel
            {
                BookId = "B002",
                Title = "Tư duy làm giàu & khởi nghiệp",
                Author = "Napoleon Hill",
                Category = "Kinh tế - Kinh doanh",
                Quantity = 40,
                Price = 98000,
                CoverImagePath = "think_rich.png"
            });
        }

        private void btnUploadCover_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh bìa sách";
                ofd.Filter = "Tệp hình ảnh (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp|Tất cả tệp (*.*)|*.*";
                ofd.FilterIndex = 1;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        byte[] fileBytes = File.ReadAllBytes(ofd.FileName);
                        using (MemoryStream ms = new MemoryStream(fileBytes))
                        {
                            picBookCover.Image?.Dispose();
                            picBookCover.Image = Image.FromStream(ms);
                        }
                        _currentCoverPath = ofd.FileName;
                        lblCoverName.Text = Path.GetFileName(ofd.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể tải ảnh bìa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SetCoverImage(string path)
        {
            picBookCover.Image?.Dispose();
            picBookCover.Image = null;
            lblCoverName.Text = string.IsNullOrWhiteSpace(path) ? "Chưa có ảnh" : Path.GetFileName(path);

            if (!string.IsNullOrWhiteSpace(path) && File.Exists(path))
            {
                try
                {
                    byte[] fileBytes = File.ReadAllBytes(path);
                    using (MemoryStream ms = new MemoryStream(fileBytes))
                    {
                        picBookCover.Image = Image.FromStream(ms);
                    }
                }
                catch
                {
                    picBookCover.Image = null;
                }
            }
        }

        private void dgvBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (_bindingSource.Current is BookModel current)
            {
                txtBookId.Text = current.BookId;
                txtTitle.Text = current.Title;
                txtAuthor.Text = current.Author;
                cboCategory.SelectedItem = current.Category;
                numQuantity.Value = current.Quantity > 0 ? current.Quantity : 1;
                txtPrice.Text = current.Price.ToString("N0");
                _currentCoverPath = current.CoverImagePath;
                SetCoverImage(current.CoverImagePath);
            }
        }

        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            if (_bookList.Count == 0)
            {
                MessageBox.Show("Danh sách sách hiện đang trống, không thể xuất báo cáo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Lưu báo cáo danh sách sách ra file CSV";
                sfd.Filter = "Tệp CSV (*.csv)|*.csv|Tất cả tệp (*.*)|*.*";
                sfd.FileName = $"BaoCaoKhoSach_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine("MaSach,TenSach,TacGia,TheLoai,SoLuong,DonGia,ThanhTien,HinhAnh");

                        foreach (var book in _bookList)
                        {
                            sb.AppendLine(string.Join(",",
                                EscapeCsv(book.BookId),
                                EscapeCsv(book.Title),
                                EscapeCsv(book.Author),
                                EscapeCsv(book.Category),
                                book.Quantity,
                                book.Price,
                                book.TotalAmount,
                                EscapeCsv(book.CoverImageName)
                            ));
                        }

                        File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                        MessageBox.Show("Xuất dữ liệu ra file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi lưu file: " + ex.Message, "Lỗi I/O", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn tệp CSV danh sách sách";
                ofd.Filter = "Tệp CSV (*.csv)|*.csv|Tất cả tệp (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(ofd.FileName, Encoding.UTF8);
                        if (lines.Length <= 1)
                        {
                            MessageBox.Show("Tệp CSV không có dữ liệu sách hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        _bookList.Clear();

                        for (int i = 1; i < lines.Length; i++)
                        {
                            string line = lines[i].Trim();
                            if (string.IsNullOrWhiteSpace(line)) continue;

                            var parts = ParseCsvLine(line);
                            if (parts.Length >= 6)
                            {
                                int.TryParse(parts[4], out int qty);
                                decimal.TryParse(parts[5], out decimal price);

                                string cover = parts.Length >= 8 ? parts[7] : (parts.Length >= 7 ? parts[6] : "");

                                _bookList.Add(new BookModel
                                {
                                    BookId = parts[0],
                                    Title = parts[1],
                                    Author = parts[2],
                                    Category = parts[3],
                                    Quantity = qty > 0 ? qty : 1,
                                    Price = price,
                                    CoverImagePath = cover
                                });
                            }
                        }

                        MessageBox.Show($"Đã nhập thành công {_bookList.Count} đầu sách từ file CSV!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi đọc file CSV: " + ex.Message, "Lỗi I/O", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private string EscapeCsv(string field)
        {
            if (string.IsNullOrEmpty(field)) return "";
            if (field.Contains(",") || field.Contains("\"") || field.Contains("\n") || field.Contains("\r"))
            {
                return $"\"{field.Replace("\"", "\"\"")}\"";
            }
            return field;
        }

        private string[] ParseCsvLine(string line)
        {
            var result = new System.Collections.Generic.List<string>();
            bool inQuotes = false;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];
                if (c == '\"')
                {
                    if (inQuotes && i + 1 < line.Length && line[i + 1] == '\"')
                    {
                        sb.Append('\"');
                        i++;
                    }
                    else
                    {
                        inQuotes = !inQuotes;
                    }
                }
                else if (c == ',' && !inQuotes)
                {
                    result.Add(sb.ToString().Trim());
                    sb.Clear();
                }
                else
                {
                    sb.Append(c);
                }
            }
            result.Add(sb.ToString().Trim());
            return result.ToArray();
        }

        private void UpdateStatusStrip()
        {
            int totalTitles = _bookList.Count;
            decimal totalStockValue = _bookList.Sum(b => b.TotalAmount);

            tsslTotalTitles.Text = $"Tổng số đầu sách: {totalTitles}";
            tsslTotalValue.Text = $"Tổng giá trị tiền sách trong kho: {totalStockValue:N0} VNĐ";
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }

        private void UpdateClock()
        {
            tsslDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            string id = txtBookId.Text.Trim();
            if (_bookList.Any(b => b.BookId.Equals(id, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã sách này đã tồn tại trong danh mục!", "Cảnh báo trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal price = decimal.Parse(txtPrice.Text.Trim().Replace(",", "").Replace(".", ""));

            var newBook = new BookModel
            {
                BookId = id,
                Title = txtTitle.Text.Trim(),
                Author = txtAuthor.Text.Trim(),
                Category = cboCategory.SelectedItem?.ToString() ?? "Khác",
                Quantity = (int)numQuantity.Value,
                Price = price,
                CoverImagePath = _currentCoverPath
            };

            _bookList.Add(newBook);
            _bindingSource.Position = _bookList.IndexOf(newBook);
            MessageBox.Show("Đã thêm sách mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current is not BookModel current)
            {
                MessageBox.Show("Vui lòng chọn một quyển sách cần chỉnh sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            decimal price = decimal.Parse(txtPrice.Text.Trim().Replace(",", "").Replace(".", ""));

            current.Title = txtTitle.Text.Trim();
            current.Author = txtAuthor.Text.Trim();
            current.Category = cboCategory.SelectedItem?.ToString() ?? current.Category;
            current.Quantity = (int)numQuantity.Value;
            current.Price = price;
            current.CoverImagePath = _currentCoverPath;

            _bindingSource.ResetCurrentItem();
            UpdateStatusStrip();
            MessageBox.Show("Cập nhật thông tin sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current is not BookModel current)
            {
                MessageBox.Show("Vui lòng chọn quyển sách cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialog = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa đầu sách '{current.Title}' (Mã: {current.BookId})?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dialog == DialogResult.Yes)
            {
                _bookList.Remove(current);
                ClearInputs();
                MessageBox.Show("Đã xóa đầu sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mnuEditSearch_Click(object sender, EventArgs e)
        {
            string keyword = Microsoft.VisualBasic.Interaction.InputBox("Nhập tên sách, tác giả hoặc mã sách cần tìm:", "Tìm kiếm sách", "");
            if (string.IsNullOrWhiteSpace(keyword)) return;

            keyword = keyword.Trim().ToLower();
            var found = _bookList.FirstOrDefault(b =>
                b.BookId.ToLower().Contains(keyword) ||
                b.Title.ToLower().Contains(keyword) ||
                b.Author.ToLower().Contains(keyword)
            );

            if (found != null)
            {
                _bindingSource.Position = _bookList.IndexOf(found);
                MessageBox.Show($"Đã tìm thấy sách: {found.Title} ({found.BookId})", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy đầu sách nào phù hợp!", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtBookId.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            if (cboCategory.Items.Count > 0) cboCategory.SelectedIndex = 0;
            numQuantity.Value = 1;
            txtPrice.Clear();
            _currentCoverPath = string.Empty;
            picBookCover.Image?.Dispose();
            picBookCover.Image = null;
            lblCoverName.Text = "Chưa có ảnh";
            dgvBooks.ClearSelection();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtBookId.Text))
            {
                MessageBox.Show("Mã sách không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBookId.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Tên sách không được để trống!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return false;
            }

            string priceRaw = txtPrice.Text.Trim().Replace(",", "").Replace(".", "");
            if (!decimal.TryParse(priceRaw, out decimal price) || price < 0)
            {
                MessageBox.Show("Đơn giá sách phải là số hợp lệ (>= 0)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return false;
            }

            return true;
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
