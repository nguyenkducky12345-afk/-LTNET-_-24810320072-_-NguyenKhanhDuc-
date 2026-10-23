namespace BookStoreManagementApp
{
    partial class frmBookManager
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSep = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditSearch = new System.Windows.Forms.ToolStripMenuItem();

            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsSep = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();

            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tsslTotalTitles = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslTotalValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSpring = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslDateTime = new System.Windows.Forms.ToolStripStatusLabel();

            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.lblBookId = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.picBookCover = new System.Windows.Forms.PictureBox();
            this.btnUploadCover = new System.Windows.Forms.Button();
            this.lblCoverName = new System.Windows.Forms.Label();

            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();

            this.gbList = new System.Windows.Forms.GroupBox();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.timerClock = new System.Windows.Forms.Timer(this.components);

            this.msMain.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.ssStatus.SuspendLayout();
            this.gbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBookCover)).BeginInit();
            this.gbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();

            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuFile,
                this.mnuEdit
            });
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(984, 28);
            this.msMain.TabIndex = 0;

            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuFileOpen,
                this.mnuFileSave,
                this.mnuFileSep,
                this.mnuFileExit
            });
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Text = "&File";

            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuFileOpen.Text = "Mở file CSV...";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);

            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuFileSave.Text = "Lưu file CSV...";
            this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);

            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuFileExit.Text = "Thoát";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);

            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuEditAdd,
                this.mnuEditDelete,
                this.mnuEditSearch
            });
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Text = "&Edit";

            this.mnuEditAdd.Name = "mnuEditAdd";
            this.mnuEditAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuEditAdd.Text = "Thêm";
            this.mnuEditAdd.Click += new System.EventHandler(this.btnThem_Click);

            this.mnuEditDelete.Name = "mnuEditDelete";
            this.mnuEditDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.mnuEditDelete.Text = "Xóa";
            this.mnuEditDelete.Click += new System.EventHandler(this.btnXoa_Click);

            this.mnuEditSearch.Name = "mnuEditSearch";
            this.mnuEditSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuEditSearch.Text = "Tìm kiếm...";
            this.mnuEditSearch.Click += new System.EventHandler(this.mnuEditSearch_Click);

            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsbOpen,
                this.tsbSave,
                this.tsSep,
                this.tsbAdd
            });
            this.tsMain.Location = new System.Drawing.Point(0, 28);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(984, 27);
            this.tsMain.TabIndex = 1;

            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Text = "Mở file";
            this.tsbOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);

            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Text = "Lưu file";
            this.tsbSave.Click += new System.EventHandler(this.mnuFileSave_Click);

            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Text = "Thêm mới";
            this.tsbAdd.Click += new System.EventHandler(this.btnThem_Click);

            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsslTotalTitles,
                this.tsslTotalValue,
                this.tsslSpring,
                this.tsslDateTime
            });
            this.ssStatus.Location = new System.Drawing.Point(0, 635);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(984, 26);
            this.ssStatus.TabIndex = 2;

            this.tsslTotalTitles.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslTotalTitles.Name = "tsslTotalTitles";
            this.tsslTotalTitles.Size = new System.Drawing.Size(145, 21);
            this.tsslTotalTitles.Text = "Tổng số đầu sách: 0";

            this.tsslTotalValue.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsslTotalValue.Name = "tsslTotalValue";
            this.tsslTotalValue.Size = new System.Drawing.Size(210, 21);
            this.tsslTotalValue.Text = "Tổng giá trị tiền sách: 0 VNĐ";

            this.tsslSpring.Name = "tsslSpring";
            this.tsslSpring.Size = new System.Drawing.Size(460, 21);
            this.tsslSpring.Spring = true;

            this.tsslDateTime.Name = "tsslDateTime";
            this.tsslDateTime.Size = new System.Drawing.Size(154, 21);
            this.tsslDateTime.Text = "01/01/2026 00:00:00";

            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);

            this.gbDetail.Controls.Add(this.lblBookId);
            this.gbDetail.Controls.Add(this.txtBookId);
            this.gbDetail.Controls.Add(this.lblTitle);
            this.gbDetail.Controls.Add(this.txtTitle);
            this.gbDetail.Controls.Add(this.lblAuthor);
            this.gbDetail.Controls.Add(this.txtAuthor);
            this.gbDetail.Controls.Add(this.lblCategory);
            this.gbDetail.Controls.Add(this.cboCategory);
            this.gbDetail.Controls.Add(this.lblQuantity);
            this.gbDetail.Controls.Add(this.numQuantity);
            this.gbDetail.Controls.Add(this.lblPrice);
            this.gbDetail.Controls.Add(this.txtPrice);
            this.gbDetail.Controls.Add(this.picBookCover);
            this.gbDetail.Controls.Add(this.btnUploadCover);
            this.gbDetail.Controls.Add(this.lblCoverName);
            this.gbDetail.Controls.Add(this.btnThem);
            this.gbDetail.Controls.Add(this.btnSua);
            this.gbDetail.Controls.Add(this.btnXoa);
            this.gbDetail.Controls.Add(this.btnLamMoi);
            this.gbDetail.Location = new System.Drawing.Point(12, 58);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(960, 220);
            this.gbDetail.TabIndex = 3;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Thông tin chi tiết tài liệu sách";

            this.lblBookId.Location = new System.Drawing.Point(20, 28);
            this.lblBookId.Text = "Mã sách:";
            this.lblBookId.Size = new System.Drawing.Size(80, 23);
            this.txtBookId.Location = new System.Drawing.Point(105, 25);
            this.txtBookId.Size = new System.Drawing.Size(180, 27);

            this.lblTitle.Location = new System.Drawing.Point(20, 68);
            this.lblTitle.Text = "Tên sách:";
            this.lblTitle.Size = new System.Drawing.Size(80, 23);
            this.txtTitle.Location = new System.Drawing.Point(105, 65);
            this.txtTitle.Size = new System.Drawing.Size(320, 27);

            this.lblAuthor.Location = new System.Drawing.Point(20, 108);
            this.lblAuthor.Text = "Tác giả:";
            this.lblAuthor.Size = new System.Drawing.Size(80, 23);
            this.txtAuthor.Location = new System.Drawing.Point(105, 105);
            this.txtAuthor.Size = new System.Drawing.Size(320, 27);

            this.lblCategory.Location = new System.Drawing.Point(20, 148);
            this.lblCategory.Text = "Thể loại:";
            this.lblCategory.Size = new System.Drawing.Size(80, 23);
            this.cboCategory.Location = new System.Drawing.Point(105, 145);
            this.cboCategory.Size = new System.Drawing.Size(180, 28);
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblQuantity.Location = new System.Drawing.Point(445, 28);
            this.lblQuantity.Text = "Số lượng:";
            this.lblQuantity.Size = new System.Drawing.Size(80, 23);
            this.numQuantity.Location = new System.Drawing.Point(530, 25);
            this.numQuantity.Size = new System.Drawing.Size(160, 27);
            this.numQuantity.Maximum = 100000;
            this.numQuantity.Minimum = 1;
            this.numQuantity.Value = 1;

            this.lblPrice.Location = new System.Drawing.Point(445, 68);
            this.lblPrice.Text = "Đơn giá:";
            this.lblPrice.Size = new System.Drawing.Size(80, 23);
            this.txtPrice.Location = new System.Drawing.Point(530, 65);
            this.txtPrice.Size = new System.Drawing.Size(160, 27);

            this.picBookCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBookCover.Location = new System.Drawing.Point(720, 22);
            this.picBookCover.Name = "picBookCover";
            this.picBookCover.Size = new System.Drawing.Size(120, 150);
            this.picBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.btnUploadCover.Location = new System.Drawing.Point(850, 60);
            this.btnUploadCover.Name = "btnUploadCover";
            this.btnUploadCover.Size = new System.Drawing.Size(95, 32);
            this.btnUploadCover.Text = "Tải ảnh bìa";
            this.btnUploadCover.Click += new System.EventHandler(this.btnUploadCover_Click);

            this.lblCoverName.Location = new System.Drawing.Point(715, 180);
            this.lblCoverName.Size = new System.Drawing.Size(230, 25);
            this.lblCoverName.Text = "Chưa có ảnh";

            this.btnThem.Location = new System.Drawing.Point(295, 180);
            this.btnThem.Size = new System.Drawing.Size(95, 30);
            this.btnThem.Text = "Thêm mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnSua.Location = new System.Drawing.Point(400, 180);
            this.btnSua.Size = new System.Drawing.Size(95, 30);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            this.btnXoa.Location = new System.Drawing.Point(505, 180);
            this.btnXoa.Size = new System.Drawing.Size(95, 30);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnLamMoi.Location = new System.Drawing.Point(610, 180);
            this.btnLamMoi.Size = new System.Drawing.Size(95, 30);
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);

            this.gbList.Controls.Add(this.dgvBooks);
            this.gbList.Location = new System.Drawing.Point(12, 285);
            this.gbList.Name = "gbList";
            this.gbList.Size = new System.Drawing.Size(960, 340);
            this.gbList.TabIndex = 4;
            this.gbList.TabStop = false;
            this.gbList.Text = "Danh mục sách trong kho";

            this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooks.Location = new System.Drawing.Point(3, 23);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.Size = new System.Drawing.Size(954, 314);
            this.dgvBooks.SelectionChanged += new System.EventHandler(this.dgvBooks_SelectionChanged);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.gbList);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Tài Liệu Sách & Báo Cáo Kho (System Dialogs & File I/O)";

            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBookCover)).EndInit();
            this.gbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripSeparator mnuFileSep;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuEditAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuEditDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuEditSearch;

        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripSeparator tsSep;
        private System.Windows.Forms.ToolStripButton tsbAdd;

        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotalTitles;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotalValue;
        private System.Windows.Forms.ToolStripStatusLabel tsslSpring;
        private System.Windows.Forms.ToolStripStatusLabel tsslDateTime;

        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.PictureBox picBookCover;
        private System.Windows.Forms.Button btnUploadCover;
        private System.Windows.Forms.Label lblCoverName;

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;

        private System.Windows.Forms.GroupBox gbList;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Timer timerClock;
    }
}
