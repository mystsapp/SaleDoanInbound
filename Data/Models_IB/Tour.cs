﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models_IB
{
    public class Tour
    {
        public long Id { get; set; }

        [MaxLength(17), Column(TypeName = "varchar(17)")]
        public string Sgtcode { get; set; }

        [DisplayName("Chủ đề tour")]
        [MaxLength(250), Column(TypeName = "nvarchar(250)")]
        public string ChuDeTour { get; set; }

        // PhongBan -> qltour
        [DisplayName("Thị Trường")]
        [MaxLength(150), Column(TypeName = "nvarchar(150)")]
        public string ThiTruong { get; set; }

        public DateTime NgayTao { get; set; }

        [DisplayName("Người tạo")]
        [MaxLength(50), Column(TypeName = "varchar(50)")]
        public string NguoiTao { get; set; }

        [DisplayName("Bắt đầu")]
        public DateTime BatDau { get; set; }

        [DisplayName("Kết thúc")]
        public DateTime KetThuc { get; set; }

        [DisplayName("Tuyến TQ")]
        [MaxLength(250), Column(TypeName = "nvarchar(250)")]
        public string TuyenTQ { get; set; }

        [DisplayName("Số khách DK")]
        public int SoKhachDK { get; set; }

        [DisplayName("Doanh thu DK")]
        public decimal DoanhtTuDK { get; set; }

        [DisplayName("Công ty")]
        public long IdKH { get; set; }

        [ForeignKey("IdKH")]
        public virtual DMKhachHang DMKhachHang { get; set; }

        //public string TenKH { get; set; }
        //public string DiaChi { get; set; }
        //public string DienThoai { get; set; }
        //public string Fax { get; set; }
        //public string Email { get; set; }
        [DisplayName("Ngày đàm phán")]
        public DateTime NgayDamPhan { get; set; }

        [DisplayName("Hình thức giao dịch")]
        [MaxLength(50), Column(TypeName = "nvarchar(50)")]
        public string HinhThucGiaoDich { get; set; }

        [DisplayName("Ngày ký hợp đồng")]
        public DateTime NgayKyHopDong { get; set; }

        [DisplayName("Người ký HĐ")]
        [MaxLength(50), Column(TypeName = "nvarchar(50)")]
        public string NguoiKyHopDong { get; set; }

        [DisplayName("Hạn xuất vé")]
        public DateTime HanXuatVe { get; set; }

        [DisplayName("Ngày thanh lý HĐ")]
        public DateTime NgayThanhLyHD { get; set; }

        [DisplayName("Số khách TT")]
        public int SoKhachTT { get; set; }

        [DisplayName("Doanh thu TT")]
        public decimal DoanhThuTT { get; set; }

        [DisplayName("Chương trình tour")]
        [MaxLength(300), Column(TypeName = "nvarchar(300)")]
        public string ChuongTrinhTour { get; set; }

        [DisplayName("Nội dung thanh lý HĐ")]
        [MaxLength(250), Column(TypeName = "nvarchar(250)")]
        public string NoiDungThanhLyHD { get; set; }

        [DisplayName("Dịch vụ")]
        [MaxLength(150), Column(TypeName = "nvarchar(150)")]
        public string DichVu { get; set; }

        [DisplayName("Đại lý")]
        [MaxLength(100), Column(TypeName = "nvarchar(100)")]
        public string DaiLy { get; set; }

        [DisplayName("Trạng thái")]
        public bool TrangThai { get; set; }

        public DateTime NgaySua { get; set; }

        [DisplayName("Người sửa")]
        [MaxLength(50), Column(TypeName = "varchar(50)")]
        public string NguoiSua { get; set; }

        [DisplayName("Loại tour")]
        public int IdLoaiTour { get; set; }

        [ForeignKey("IdLoaiTour")]
        public virtual LoaiTour LoaiTour { get; set; }

        [DisplayName("Điểm tham quan")]
        [MaxLength(250), Column(TypeName = "nvarchar(250)")]
        public string DiemTQ { get; set; }

        [DisplayName("Chi nhánh")]
        [MaxLength(5), Column(TypeName = "varchar(5)")]
        public string MaCN { get; set; }

        public DateTime NgayNhanDuTien { get; set; }

        [MaxLength(250), Column(TypeName = "nvarchar(250)")]
        public string LyDoNhanDu { get; set; }

        [DisplayName("Số HĐ")]
        [MaxLength(50), Column(TypeName = "varchar(50)")]
        public string SoHopDong { get; set; }

        public decimal LaiChuaVe { get; set; }
        public decimal LaiGomVe { get; set; }
        public decimal LaiThucTeGomVe { get; set; }

        [DisplayName("Nguyên nhân hủy")]
        [MaxLength(250), Column(TypeName = "nvarchar(250)")]
        public string NguyenNhanHuyThau { get; set; }

        [DisplayName("Nguồn tour")]
        [MaxLength(100), Column(TypeName = "nvarchar(100)")]
        public string NguonTour { get; set; }

        [DisplayName("File khách đi tour")]
        [MaxLength(100), Column(TypeName = "varchar(100)")]
        public string FileKhachDiTour { get; set; }

        [DisplayName("File VMB")]
        [MaxLength(100), Column(TypeName = "varchar(100)")]
        public string FileVeMayBay { get; set; }

        [DisplayName("File biên nhận")]
        [MaxLength(100), Column(TypeName = "varchar(100)")]
        public string FileBienNhan { get; set; }

        [DisplayName("Người đại diện")]
        [MaxLength(100), Column(TypeName = "nvarchar(100)")]
        public string NguoiDaiDien { get; set; }

        [DisplayName("Đối tác nước ngoài")]
        [MaxLength(150), Column(TypeName = "nvarchar(150)")]
        public string DoiTacNuocNgoai { get; set; }

        [DisplayName("Ngày hủy tour")]
        public DateTime NgayHuytTour { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string LogFile { get; set; }
    }
}