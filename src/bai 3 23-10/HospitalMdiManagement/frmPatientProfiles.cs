using System.Data;

namespace HospitalMdiManagement
{
    public partial class frmPatientProfiles : Form
    {
        private DataTable dtPatients = new DataTable();

        public frmPatientProfiles()
        {
            InitializeComponent();
            InitPatientTable();
            cboDepartment.SelectedIndex = 0;
        }

        private void InitPatientTable()
        {
            dtPatients.Columns.Add("Mã BN", typeof(string));
            dtPatients.Columns.Add("Họ và Tên", typeof(string));
            dtPatients.Columns.Add("Ngày sinh", typeof(string));
            dtPatients.Columns.Add("Khoa điều trị", typeof(string));
            dtPatients.Columns.Add("Chẩn đoán", typeof(string));

            dtPatients.Rows.Add("BN001", "Trần Quốc Toản", "15/04/1988", "Khoa Cấp Cứu", "Đau thắt ngực không ổn định");
            dtPatients.Rows.Add("BN002", "Nguyễn Thị Mai", "22/11/1995", "Khoa Nội Tim Mạch", "Huyết áp cao độ 2");
            dtPatients.Rows.Add("BN003", "Lê Văn Hùng", "05/01/1976", "Khoa Ngoại Chấn Thương", "Gãy 1/3 dưới xương cẳng chân");

            dgvPatients.DataSource = dtPatients;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPatientId.Text) || string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã BN và Họ tên!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataRow row in dtPatients.Rows)
            {
                if (row["Mã BN"].ToString()?.Trim().ToUpper() == txtPatientId.Text.Trim().ToUpper())
                {
                    MessageBox.Show("Mã bệnh nhân này đã tồn tại trong danh sách!", "Cảnh báo trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            dtPatients.Rows.Add(
                txtPatientId.Text.Trim(),
                txtFullName.Text.Trim(),
                dtpDOB.Value.ToString("dd/MM/yyyy"),
                cboDepartment.SelectedItem?.ToString(),
                txtDiagnosis.Text.Trim()
            );

            MessageBox.Show("Đã thêm hồ sơ bệnh nhân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnClear_Click(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count > 0)
            {
                var rowView = dgvPatients.SelectedRows[0];
                dtPatients.Rows.RemoveAt(rowView.Index);
                MessageBox.Show("Đã xóa hồ sơ bệnh nhân được chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng bệnh nhân cần xóa trên bảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPatientId.Clear();
            txtFullName.Clear();
            txtDiagnosis.Clear();
            dtpDOB.Value = DateTime.Now;
            cboDepartment.SelectedIndex = 0;
            txtPatientId.Focus();
        }
    }
}