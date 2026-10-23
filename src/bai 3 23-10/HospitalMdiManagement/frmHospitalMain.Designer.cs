namespace HospitalMdiManagement
{
    partial class frmHospitalMain
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReloadData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPatientProfiles = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoctorSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDepartments = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.lblDutyDoctor = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSpring = new System.Windows.Forms.ToolStripStatusLabel();
            this.prgOperation = new System.Windows.Forms.ToolStripProgressBar();
            this.lblClock = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuMain.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuSystem,
                this.mnuManage,
                this.mnuWindow
            });
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.MdiWindowListItem = this.mnuWindow;
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1184, 27);
            this.mnuMain.TabIndex = 1;
            // 
            // mnuSystem
            // 
            this.mnuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuLogout,
                this.mnuReloadData,
                this.toolStripMenuItem1,
                this.mnuExit
            });
            this.mnuSystem.Name = "mnuSystem";
            this.mnuSystem.Size = new System.Drawing.Size(79, 23);
            this.mnuSystem.Text = "Hệ thống";
            // 
            // mnuLogout
            // 
            this.mnuLogout.Name = "mnuLogout";
            this.mnuLogout.Size = new System.Drawing.Size(206, 24);
            this.mnuLogout.Text = "Đăng xuất";
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            // 
            // mnuReloadData
            // 
            this.mnuReloadData.Name = "mnuReloadData";
            this.mnuReloadData.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mnuReloadData.Size = new System.Drawing.Size(206, 24);
            this.mnuReloadData.Text = "Nạp lại dữ liệu";
            this.mnuReloadData.Click += new System.EventHandler(this.mnuReloadData_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(203, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuExit.Size = new System.Drawing.Size(206, 24);
            this.mnuExit.Text = "Thoát";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuManage
            // 
            this.mnuManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuPatientProfiles,
                this.mnuDoctorSchedule,
                this.mnuDepartments
            });
            this.mnuManage.Name = "mnuManage";
            this.mnuManage.Size = new System.Drawing.Size(70, 23);
            this.mnuManage.Text = "Quản lý";
            // 
            // mnuPatientProfiles
            // 
            this.mnuPatientProfiles.Name = "mnuPatientProfiles";
            this.mnuPatientProfiles.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mnuPatientProfiles.Size = new System.Drawing.Size(248, 24);
            this.mnuPatientProfiles.Text = "Hồ sơ Bệnh nhân";
            this.mnuPatientProfiles.Click += new System.EventHandler(this.mnuPatientProfiles_Click);
            // 
            // mnuDoctorSchedule
            // 
            this.mnuDoctorSchedule.Name = "mnuDoctorSchedule";
            this.mnuDoctorSchedule.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuDoctorSchedule.Size = new System.Drawing.Size(248, 24);
            this.mnuDoctorSchedule.Text = "Danh mục Bác sĩ";
            this.mnuDoctorSchedule.Click += new System.EventHandler(this.mnuDoctorSchedule_Click);
            // 
            // mnuDepartments
            // 
            this.mnuDepartments.Name = "mnuDepartments";
            this.mnuDepartments.Size = new System.Drawing.Size(248, 24);
            this.mnuDepartments.Text = "Danh mục Khoa/Phòng";
            this.mnuDepartments.Click += new System.EventHandler(this.mnuDepartments_Click);
            // 
            // mnuWindow
            // 
            this.mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuCascade,
                this.mnuTileHorizontal,
                this.mnuTileVertical,
                this.toolStripMenuItem2,
                this.mnuCloseAll
            });
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Size = new System.Drawing.Size(68, 23);
            this.mnuWindow.Text = "Cửa sổ";
            // 
            // mnuCascade
            // 
            this.mnuCascade.Name = "mnuCascade";
            this.mnuCascade.Size = new System.Drawing.Size(263, 24);
            this.mnuCascade.Text = "Sắp xếp Xếp tầng (Cascade)";
            this.mnuCascade.Click += new System.EventHandler(this.mnuCascade_Click);
            // 
            // mnuTileHorizontal
            // 
            this.mnuTileHorizontal.Name = "mnuTileHorizontal";
            this.mnuTileHorizontal.Size = new System.Drawing.Size(263, 24);
            this.mnuTileHorizontal.Text = "Ngang (Tile Horizontal)";
            this.mnuTileHorizontal.Click += new System.EventHandler(this.mnuTileHorizontal_Click);
            // 
            // mnuTileVertical
            // 
            this.mnuTileVertical.Name = "mnuTileVertical";
            this.mnuTileVertical.Size = new System.Drawing.Size(263, 24);
            this.mnuTileVertical.Text = "Dọc (Tile Vertical)";
            this.mnuTileVertical.Click += new System.EventHandler(this.mnuTileVertical_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(260, 6);
            // 
            // mnuCloseAll
            // 
            this.mnuCloseAll.Name = "mnuCloseAll";
            this.mnuCloseAll.Size = new System.Drawing.Size(263, 24);
            this.mnuCloseAll.Text = "Đóng tất cả";
            this.mnuCloseAll.Click += new System.EventHandler(this.mnuCloseAll_Click);
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.lblDutyDoctor,
                this.lblSpring,
                this.prgOperation,
                this.lblClock
            });
            this.statusMain.Location = new System.Drawing.Point(0, 719);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(1184, 24);
            this.statusMain.TabIndex = 2;
            // 
            // lblDutyDoctor
            // 
            this.lblDutyDoctor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDutyDoctor.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblDutyDoctor.Name = "lblDutyDoctor";
            this.lblDutyDoctor.Size = new System.Drawing.Size(430, 19);
            this.lblDutyDoctor.Text = "Bác sĩ trực: BS. CKII Lê Hoàng Minh | Sĩ quan trực ban: Thiếu tá Vũ An";
            // 
            // lblSpring
            // 
            this.lblSpring.Name = "lblSpring";
            this.lblSpring.Size = new System.Drawing.Size(459, 19);
            this.lblSpring.Spring = true;
            // 
            // prgOperation
            // 
            this.prgOperation.Name = "prgOperation";
            this.prgOperation.Size = new System.Drawing.Size(140, 18);
            this.prgOperation.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // lblClock
            // 
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(140, 19);
            this.lblClock.Text = "--:--:--";
            // 
            // frmHospitalMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 743);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmHospitalMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG MDI QUẢN LÝ BỆNH VIỆN & TRUY XUẤT HỒ SƠ BỆNH ÁN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.ToolStripMenuItem mnuReloadData;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuManage;
        private System.Windows.Forms.ToolStripMenuItem mnuPatientProfiles;
        private System.Windows.Forms.ToolStripMenuItem mnuDoctorSchedule;
        private System.Windows.Forms.ToolStripMenuItem mnuDepartments;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuCascade;
        private System.Windows.Forms.ToolStripMenuItem mnuTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem mnuTileVertical;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseAll;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripStatusLabel lblDutyDoctor;
        private System.Windows.Forms.ToolStripStatusLabel lblSpring;
        private System.Windows.Forms.ToolStripProgressBar prgOperation;
        private System.Windows.Forms.ToolStripStatusLabel lblClock;
    }
}