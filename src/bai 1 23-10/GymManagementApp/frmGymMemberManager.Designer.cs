namespace GymManagementApp
{
    partial class frmGymMemberManager
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPackage = new System.Windows.Forms.Label();
            this.cboPackage = new System.Windows.Forms.ComboBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblFee = new System.Windows.Forms.Label();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.gbList = new System.Windows.Forms.GroupBox();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);

            this.gbInfo.SuspendLayout();
            this.gbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();

            // gbInfo
            this.gbInfo.Controls.Add(this.lblMemberId);
            this.gbInfo.Controls.Add(this.txtMemberId);
            this.gbInfo.Controls.Add(this.lblFullName);
            this.gbInfo.Controls.Add(this.txtFullName);
            this.gbInfo.Controls.Add(this.lblPhone);
            this.gbInfo.Controls.Add(this.txtPhone);
            this.gbInfo.Controls.Add(this.lblPackage);
            this.gbInfo.Controls.Add(this.cboPackage);
            this.gbInfo.Controls.Add(this.lblStartDate);
            this.gbInfo.Controls.Add(this.dtpStartDate);
            this.gbInfo.Controls.Add(this.lblFee);
            this.gbInfo.Controls.Add(this.txtFee);
            this.gbInfo.Controls.Add(this.btnThem);
            this.gbInfo.Controls.Add(this.btnSua);
            this.gbInfo.Controls.Add(this.btnXoa);
            this.gbInfo.Controls.Add(this.btnLamMoi);
            this.gbInfo.Location = new System.Drawing.Point(12, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(860, 180);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Khu vực thông tin hội viên & chức năng";

            // lblMemberId & txtMemberId
            this.lblMemberId.Location = new System.Drawing.Point(20, 30);
            this.lblMemberId.Text = "Mã hội viên:";
            this.lblMemberId.Size = new System.Drawing.Size(90, 20);
            this.txtMemberId.Location = new System.Drawing.Point(115, 27);
            this.txtMemberId.Size = new System.Drawing.Size(260, 27);
            this.txtMemberId.ReadOnly = true;

            // lblFullName & txtFullName
            this.lblFullName.Location = new System.Drawing.Point(20, 70);
            this.lblFullName.Text = "Họ và tên:";
            this.lblFullName.Size = new System.Drawing.Size(90, 20);
            this.txtFullName.Location = new System.Drawing.Point(115, 67);
            this.txtFullName.Size = new System.Drawing.Size(260, 27);

            // lblPhone & txtPhone
            this.lblPhone.Location = new System.Drawing.Point(20, 110);
            this.lblPhone.Text = "Số điện thoại:";
            this.lblPhone.Size = new System.Drawing.Size(90, 20);
            this.txtPhone.Location = new System.Drawing.Point(115, 107);
            this.txtPhone.Size = new System.Drawing.Size(260, 27);

            // lblPackage & cboPackage
            this.lblPackage.Location = new System.Drawing.Point(420, 30);
            this.lblPackage.Text = "Gói tập:";
            this.lblPackage.Size = new System.Drawing.Size(95, 20);
            this.cboPackage.Location = new System.Drawing.Point(520, 27);
            this.cboPackage.Size = new System.Drawing.Size(280, 28);
            this.cboPackage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // lblStartDate & dtpStartDate
            this.lblStartDate.Location = new System.Drawing.Point(420, 70);
            this.lblStartDate.Text = "Ngày đăng ký:";
            this.lblStartDate.Size = new System.Drawing.Size(95, 20);
            this.dtpStartDate.Location = new System.Drawing.Point(520, 67);
            this.dtpStartDate.Size = new System.Drawing.Size(280, 27);
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // lblFee & txtFee
            this.lblFee.Location = new System.Drawing.Point(420, 110);
            this.lblFee.Text = "Phí dịch vụ:";
            this.lblFee.Size = new System.Drawing.Size(95, 20);
            this.txtFee.Location = new System.Drawing.Point(520, 107);
            this.txtFee.Size = new System.Drawing.Size(280, 27);

            // Buttons
            this.btnThem.Location = new System.Drawing.Point(380, 142);
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.Text = "Thêm mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnSua.Location = new System.Drawing.Point(495, 142);
            this.btnSua.Size = new System.Drawing.Size(100, 30);
            this.btnSua.Text = "Sửa thông tin";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            this.btnXoa.Location = new System.Drawing.Point(610, 142);
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.Text = "Xóa hội viên";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnLamMoi.Location = new System.Drawing.Point(725, 142);
            this.btnLamMoi.Size = new System.Drawing.Size(100, 30);
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            // gbList & dgvMembers
            this.gbList.Controls.Add(this.dgvMembers);
            this.gbList.Location = new System.Drawing.Point(12, 200);
            this.gbList.Size = new System.Drawing.Size(860, 310);
            this.gbList.Text = "Danh sách hội viên";

            this.dgvMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMembers.Location = new System.Drawing.Point(3, 23);
            this.dgvMembers.Size = new System.Drawing.Size(854, 284);

            // errorProvider
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;

            // frmGymMemberManager
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 521);
            this.Controls.Add(this.gbList);
            this.Controls.Add(this.gbInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Dịch Vụ Phòng Gym & Hội Viên";

            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPackage;
        private System.Windows.Forms.ComboBox cboPackage;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
