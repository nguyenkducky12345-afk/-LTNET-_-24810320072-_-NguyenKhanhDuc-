# BÁO CÁO BÀI TẬP THỰC HÀNH LẬP TRÌNH C# WINFORMS

## I. THÔNG TIN SINH VIÊN

* **Họ và tên:** Nguyễn Khánh Đức
* **Mã số sinh viên:** 24810320072
* **Lớp học phần:** Lập trình .NET - Mã Lớp: LTTB01
* **Link Repository:** https://github.com/nguyenkducky12345-afk/-LTNET-_-24810320072-_-NguyenKhanhDuc-


---

## II. DANH SÁCH BÀI TẬP HOÀN THÀNH & TỰ ĐÁNH GIÁ

| Bài tập | Tiêu đề bài tập | Trạng thái | Mức độ hoàn thành (%) |
| :---: | :--- | :---: | :---: |
| **Bài 1** | Quản lý Dịch vụ Phòng Gym & Hội viên | Hoàn thành | 100% |
| **Bài 2** | Báo cáo & Lưu trữ Tài liệu Nhà sách | Hoàn thành | 100% |
| **Bài 3** | Hệ thống MDI Quản lý Bệnh viện & Async | Hoàn thành | 100% |
| **Bài 4** | Bảng điều khiển thống kê doanh thu Multi-Threading (ASYNC/AWAIT & Không khóa UI) | Hoàn thành | 100% |
| **Bài 5** | Mô phỏng giám sát tỷ giá tài chính thời gian thực (CROSS-THREAD SAFETY & PROCESSING) | Hoàn thành | 100% |


## III. MINH HỌA GIAO DIỆN & KỸ THUẬT NỔI BẬT

### 1. Bài 1: Quản lý Dịch vụ Phòng Gym & Hội viên
* **Kỹ thuật áp dụng:** Cấu hình DataGridView bằng code (`AutoGenerateColumns =
false`), Data Binding 2 chiều với `BindingSource`, Validation với `ErrorProvider`.
* **Hình ảnh minh họa Giao diện:**

![Giao diện chính Bài 1](docs/<img width="887" height="560" alt="bai_1(main)" src="https://github.com/user-attachments/assets/fb8b2c2d-7e16-4bfe-a8af-0059574ec9f6" />)
![Bắt lỗi Validation Bài 1]
<img width="884" height="557" alt="Screenshot 2026-10-23 183742" src="https://github.com/user-attachments/assets/5f81f702-2d1e-4531-9540-a4ae24500231" />

---

### 2. Bài 2: Quản lý & Xuất Báo cáo Nhà sách
* **Kỹ thuật áp dụng:** `OpenFileDialog` (Tải ảnh bìa), `SaveFileDialog` /
`OpenFileDialog` (Đọc/Ghi file CSV), Cập nhật `StatusStrip` theo thời gian thực.
* **Hình ảnh minh họa Giao diện:**

![Giao diện Bài 2 và Load Ảnh]
<img width="984" height="697" alt="Screenshot 2026-10-23 183952" src="https://github.com/user-attachments/assets/41e52ce9-becc-42f1-bda0-131a099f3030" />


---

### 3. Bài 3: Kiến trúc MDI & Xử lý Bất đồng bộ (Async/Await)
* **Kỹ thuật áp dụng:** MDI Container, Quản lý chống mở trùng Form con,
`async/await` chống treo UI, Safe Cross-Thread bằng `this.Invoke()`.
* **Hình ảnh minh họa Giao diện:**

![Giao diện Khung MDI]
<img width="1078" height="840" alt="Screenshot 2026-10-23 184156" src="https://github.com/user-attachments/assets/4e02030c-a84c-4efa-8f73-1ca135347ab5" />


![Minh họa Async không treo UI]
<img width="1077" height="845" alt="Screenshot 2026-10-23 184228" src="https://github.com/user-attachments/assets/fc605c8d-2e56-4a57-ac78-7b097abfa39e" />

---


### 4. Bài 4: Bảng Điều Khiển Thống Kê Doanh Thu Multi-Threading
* **Kỹ thuật áp dụng:** `async/await`, `Task.Run` (đẩy tác vụ nặng xuống Background Thread chống treo UI), Quản lý ngắt luồng an toàn với `CancellationTokenSource`, Cập nhật tiến độ `ProgressBar`.
* **Hình ảnh minh họa Giao diện:**

![Minh họa Async thống kê không treo UI]
<img width="1010" height="780" alt="Screenshot 2026-10-23 184809" src="https://github.com/user-attachments/assets/49382aa2-bc62-444d-9cf7-abdca00c09cb" />

![Hủy tác vụ an toàn bằng CancellationToken]
<img width="1015" height="780" alt="Screenshot 2026-10-23 184922" src="https://github.com/user-attachments/assets/7818cabf-ab12-41fd-8bfb-0c006d96bf80" />

---

### 5. Bài 5: Giám Sát Tỷ Giá Tài Chính Thời Gian Thực & Cross-Thread Safety
* **Kỹ thuật áp dụng:** Background Loop với `Task.Run` & `Task.Delay`, Safe Cross-Thread UI bằng `Control.InvokeRequired` và `this.Invoke()`, Cập nhật động UI (`Label` đổi màu Xanh/Đỏ theo giá, `StatusStrip`, `DataGridView`).
* **Hình ảnh minh họa Giao diện:**

![Giao diện Giám sát Tỷ giá thời gian thực]
<img width="777" height="685" alt="Screenshot 2026-10-23 185042" src="https://github.com/user-attachments/assets/afdb3299-e985-4511-8f11-fdb0df9f780f" />


![Cập nhật luồng an toàn bằng Invoke]
<img width="776" height="677" alt="Screenshot 2026-10-23 185138" src="https://github.com/user-attachments/assets/ec854dbb-7d88-4033-bb62-3db8f045840f" />


---


## IV. HƯỚNG DẪN CÀI ĐẶT & CHẠY DỰ ÁN
1. Clone Repository về máy:
```bash

git clone https://github.com/nguyenkducky12345-afk/-LTNET-_-24810320072-_-NguyenKhanhDuc-

2. Mở file solution src/WinFormsAppSolution.sln bằng Visual Studio 2022.
3. Bấm F5 hoặc chọn Start để biên dịch và chạy chương trình.
