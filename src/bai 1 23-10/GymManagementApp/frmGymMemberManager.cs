using System;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GymManagementApp
{
    public partial class frmGymMemberManager : Form
    {
        private BindingList<MemberModel> _memberList = new BindingList<MemberModel>();
        private BindingSource _bindingSource = new BindingSource();

        public frmGymMemberManager()
        {
            InitializeComponent();
            InitComboBox();
            SetupDataGridView();
            SetupDataBinding();
            LoadSampleData();
            ClearAndPrepareNew();
        }

        private void InitComboBox()
        {
            cboPackage.Items.Clear();
            cboPackage.Items.AddRange(new object[] { "Theo tháng", "6 tháng", "1 năm" });
            cboPackage.SelectedIndex = 0;
        }

        private void SetupDataGridView()
        {
            dgvMembers.AutoGenerateColumns = false;
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.MultiSelect = false;
            dgvMembers.ReadOnly = true;
            dgvMembers.Columns.Clear();

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(MemberModel.MemberId),
                HeaderText = "Mã HV",
                Name = "colMemberId",
                Width = 100
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(MemberModel.FullName),
                HeaderText = "Tên hội viên",
                Name = "colFullName",
                Width = 180
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(MemberModel.Phone),
                HeaderText = "SĐT",
                Name = "colPhone",
                Width = 120
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(MemberModel.Package),
                HeaderText = "Gói tập",
                Name = "colPackage",
                Width = 120
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(MemberModel.StartDate),
                HeaderText = "Ngày ĐK",
                Name = "colStartDate",
                Width = 110,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dgvMembers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(MemberModel.Fee),
                HeaderText = "Phí dịch vụ",
                Name = "colFee",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });
        }

        private void SetupDataBinding()
        {
            _bindingSource.DataSource = _memberList;
            dgvMembers.DataSource = _bindingSource;

            txtMemberId.DataBindings.Add("Text", _bindingSource, nameof(MemberModel.MemberId), true, DataSourceUpdateMode.Never);
            txtFullName.DataBindings.Add("Text", _bindingSource, nameof(MemberModel.FullName), true, DataSourceUpdateMode.Never);
            txtPhone.DataBindings.Add("Text", _bindingSource, nameof(MemberModel.Phone), true, DataSourceUpdateMode.Never);
            cboPackage.DataBindings.Add("SelectedItem", _bindingSource, nameof(MemberModel.Package), true, DataSourceUpdateMode.Never);
            dtpStartDate.DataBindings.Add("Value", _bindingSource, nameof(MemberModel.StartDate), true, DataSourceUpdateMode.Never);

            var feeBinding = new Binding("Text", _bindingSource, nameof(MemberModel.Fee), true, DataSourceUpdateMode.Never, 0, "0");
            txtFee.DataBindings.Add(feeBinding);

            _bindingSource.CurrentChanged += (s, e) => errorProvider.Clear();
        }

        private void LoadSampleData()
        {
            _memberList.Add(new MemberModel
            {
                MemberId = "HV001",
                FullName = "Nguyễn Văn An",
                Phone = "0912345678",
                Package = "6 tháng",
                StartDate = DateTime.Now.AddMonths(-1),
                Fee = 3000000
            });

            _memberList.Add(new MemberModel
            {
                MemberId = "HV002",
                FullName = "Trần Thị Bình",
                Phone = "0987654321",
                Package = "1 năm",
                StartDate = DateTime.Now.AddDays(-10),
                Fee = 5500000
            });
        }

        private string GenerateNextMemberId()
        {
            int maxId = 0;
            var regex = new Regex(@"^HV(\d+)$");

            foreach (var item in _memberList)
            {
                var match = regex.Match(item.MemberId);
                if (match.Success && int.TryParse(match.Groups[1].Value, out int idNum))
                {
                    if (idNum > maxId) maxId = idNum;
                }
            }
            return $"HV{(maxId + 1):D3}";
        }

        private bool ValidateInputs()
        {
            bool isValid = true;
            errorProvider.Clear();

            string name = txtFullName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                errorProvider.SetError(txtFullName, "Tên hội viên không được để trống.");
                isValid = false;
            }
            else if (!Regex.IsMatch(name, @"^[\p{L}\s]+$"))
            {
                errorProvider.SetError(txtFullName, "Tên hội viên không được chứa số hoặc ký tự đặc biệt.");
                isValid = false;
            }

            string phone = txtPhone.Text.Trim();
            if (!Regex.IsMatch(phone, @"^\d{10}$"))
            {
                errorProvider.SetError(txtPhone, "Số điện thoại phải bao gồm đúng 10 chữ số.");
                isValid = false;
            }

            string feeRaw = txtFee.Text.Trim().Replace(",", "").Replace(".", "");
            if (!long.TryParse(feeRaw, out long feeVal) || feeVal <= 0)
            {
                errorProvider.SetError(txtFee, "Phí dịch vụ phải là số nguyên dương (> 0).");
                isValid = false;
            }

            if (cboPackage.SelectedItem == null)
            {
                errorProvider.SetError(cboPackage, "Vui lòng chọn một gói tập.");
                isValid = false;
            }

            return isValid;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            string newId = GenerateNextMemberId();
            decimal fee = decimal.Parse(txtFee.Text.Trim().Replace(",", "").Replace(".", ""));

            var newMember = new MemberModel
            {
                MemberId = newId,
                FullName = txtFullName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Package = cboPackage.SelectedItem?.ToString() ?? "Theo tháng",
                StartDate = dtpStartDate.Value,
                Fee = fee
            };

            _memberList.Add(newMember);
            _bindingSource.Position = _memberList.IndexOf(newMember);

            MessageBox.Show($"Thêm thành công hội viên {newMember.MemberId}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current is not MemberModel currentMember)
            {
                MessageBox.Show("Vui lòng chọn một hội viên trên danh sách để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInputs()) return;

            decimal fee = decimal.Parse(txtFee.Text.Trim().Replace(",", "").Replace(".", ""));

            currentMember.FullName = txtFullName.Text.Trim();
            currentMember.Phone = txtPhone.Text.Trim();
            currentMember.Package = cboPackage.SelectedItem?.ToString() ?? currentMember.Package;
            currentMember.StartDate = dtpStartDate.Value;
            currentMember.Fee = fee;

            MessageBox.Show("Cập nhật thông tin hội viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_bindingSource.Current is not MemberModel currentMember)
            {
                MessageBox.Show("Vui lòng chọn hội viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa hội viên '{currentMember.FullName}' ({currentMember.MemberId}) không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                _bindingSource.RemoveCurrent();
                ClearAndPrepareNew();
                MessageBox.Show("Xóa hội viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearAndPrepareNew();
        }

        private void ClearAndPrepareNew()
        {
            errorProvider.Clear();
            _bindingSource.SuspendBinding();

            txtMemberId.Text = GenerateNextMemberId();
            txtFullName.Clear();
            txtPhone.Clear();
            if (cboPackage.Items.Count > 0) cboPackage.SelectedIndex = 0;
            dtpStartDate.Value = DateTime.Now;
            txtFee.Clear();

            _bindingSource.ResumeBinding();
            dgvMembers.ClearSelection();
        }
    }
}
