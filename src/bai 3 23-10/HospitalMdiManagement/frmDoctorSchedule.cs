using System.Data;

namespace HospitalMdiManagement
{
    public partial class frmDoctorSchedule : Form
    {
        private DataTable dtSchedule = new DataTable();

        public frmDoctorSchedule()
        {
            InitializeComponent();
            InitScheduleTable();
            cboFilterDept.SelectedIndex = 0;
        }

        private void InitScheduleTable()
        {
            dtSchedule.Columns.Add("Mã BS", typeof(string));
            dtSchedule.Columns.Add("Họ và Tên", typeof(string));
            dtSchedule.Columns.Add("Cấp bậc / Chức danh", typeof(string));
            dtSchedule.Columns.Add("Khoa Trực", typeof(string));
            dtSchedule.Columns.Add("Ca Trực", typeof(string));
            dtSchedule.Columns.Add("Điện thoại nội bộ", typeof(string));

            dtSchedule.Rows.Add("BS01", "Lê Hoàng Minh", "BS. CKII - Trưởng khoa", "Khoa Cấp Cứu", "Ca đêm (18h - 06h)", "102");
            dtSchedule.Rows.Add("BS02", "Vũ An", "Thạc sĩ - Sĩ quan trực", "Khoa Cấp Cứu", "Ca đêm (18h - 06h)", "103");
            dtSchedule.Rows.Add("BS03", "Trần Kim Oanh", "Bác sĩ CKI", "Khoa Hồi Sức Tích Cực", "Ca ngày (06h - 18h)", "105");
            dtSchedule.Rows.Add("BS04", "Phạm Quốc Dũng", "Bác sĩ Chuyên khoa", "Khoa Ngoại Chấn Thương", "24/24", "109");

            dgvSchedule.DataSource = dtSchedule;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string selectedDept = cboFilterDept.SelectedItem?.ToString() ?? "";
            
            if (selectedDept == "-- Tất cả các khoa --" || string.IsNullOrEmpty(selectedDept))
            {
                dtSchedule.DefaultView.RowFilter = "";
            }
            else
            {
                dtSchedule.DefaultView.RowFilter = $"[Khoa Trực] = '{selectedDept}'";
            }
        }
    }
}