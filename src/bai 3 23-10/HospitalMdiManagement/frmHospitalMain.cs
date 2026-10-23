namespace HospitalMdiManagement
{
    public partial class frmHospitalMain : Form
    {
        private System.Windows.Forms.Timer? clockTimer;

        public frmHospitalMain()
        {
            InitializeComponent();
            SetupSystemClock();
        }

        private void SetupSystemClock()
        {
            clockTimer = new System.Windows.Forms.Timer();
            clockTimer.Interval = 1000;
            clockTimer.Tick += (s, e) =>
            {
                lblClock.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            };
            clockTimer.Start();
        }

        public void OpenChildForm<T>() where T : Form, new()
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is T targetForm)
                {
                    if (targetForm.WindowState == FormWindowState.Minimized)
                    {
                        targetForm.WindowState = FormWindowState.Normal;
                    }
                    targetForm.Activate();
                    return;
                }
            }

            T newChild = new T();
            newChild.MdiParent = this;
            newChild.Show();
        }

        private void mnuPatientProfiles_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmPatientProfiles>();
        }

        private void mnuDoctorSchedule_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmDoctorSchedule>();
        }

        private void mnuDepartments_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Danh mục Khoa/Phòng đang được đồng bộ trực tuyến.",
                "Khoa/Phòng Bệnh Viện",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void mnuCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuTileHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuTileVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuCloseAll_Click(object sender, EventArgs e)
        {
            for (int i = this.MdiChildren.Length - 1; i >= 0; i--)
            {
                this.MdiChildren[i].Close();
            }
        }

        private async void mnuReloadData_Click(object sender, EventArgs e)
        {
            prgOperation.Value = 0;
            for (int i = 0; i <= 100; i += 25)
            {
                prgOperation.Value = i;
                await Task.Delay(120);
            }

            MessageBox.Show("Nạp lại dữ liệu hệ thống thành công!", "Nạp dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            prgOperation.Value = 0;
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn muốn đăng xuất khỏi phiên làm việc hiện tại?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                mnuCloseAll_Click(sender, e);
                lblDutyDoctor.Text = "Chưa có cán bộ/bác sĩ trực đăng nhập.";
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}