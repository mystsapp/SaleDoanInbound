﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class addTbls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DMKhachHangs",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaCN = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true),
                    TenGiaoDich = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    TenThuongMai = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MaQuocGia = table.Column<int>(nullable: false),
                    MaThanhPho = table.Column<int>(nullable: false),
                    Telephone = table.Column<string>(type: "varchar(20)", maxLength: 15, nullable: true),
                    Tax = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Fax = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    NguoiLH = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiTao = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    NgaySua = table.Column<DateTime>(nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    GhiChuKhiGiaoDich = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MaNganhNghe = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMKhachHangs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TourTMPs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sgtcode = table.Column<string>(type: "varchar(17)", maxLength: 17, nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    KhachLe = table.Column<bool>(nullable: false),
                    TenGiaoDich = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    TuyenTQ = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ChuDeTour = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    BatDau = table.Column<DateTime>(nullable: false),
                    KetThuc = table.Column<DateTime>(nullable: false),
                    SoCho = table.Column<int>(nullable: false),
                    ChoConLai = table.Column<int>(nullable: false),
                    NguoiTaoTour = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    MaCN = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourTMPs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TourLogs",
                columns: table => new
                {
                    Id = table.Column<decimal>(nullable: false),
                    IdTour = table.Column<decimal>(nullable: false),
                    SgtCode = table.Column<string>(type: "varchar(17)", maxLength: 17, nullable: true),
                    ChuDeTour = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ThiTruong = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiTao = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    BatDau = table.Column<DateTime>(nullable: false),
                    KetThuc = table.Column<DateTime>(nullable: false),
                    TuyenTQ = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DiemTQ = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SoKhachDK = table.Column<int>(nullable: false),
                    DoanhThuDK = table.Column<decimal>(nullable: false),
                    IdKH = table.Column<long>(nullable: false),
                    NgayDamPhan = table.Column<DateTime>(nullable: false),
                    HinhThucGiaoDich = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayKyHopDong = table.Column<DateTime>(nullable: false),
                    NguoiKyHopDong = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HanXuatVMB = table.Column<DateTime>(nullable: false),
                    NgayThanhLyHD = table.Column<DateTime>(nullable: false),
                    SoKhachTT = table.Column<int>(nullable: false),
                    DoanhThuTT = table.Column<decimal>(nullable: false),
                    ChuongTrinhTour = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    NoiDungThanhLyHD = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DichVu = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DaiLy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IdLoaiTour = table.Column<int>(nullable: false),
                    TrangThai = table.Column<string>(nullable: true),
                    NgaySua = table.Column<DateTime>(nullable: false),
                    NguoiSua = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    MaCN = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: true),
                    NgayNhanDuTien = table.Column<DateTime>(nullable: false),
                    LyDoNhanDu = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SoHopDong = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    LaiChuaVe = table.Column<decimal>(nullable: false),
                    LaiGomVe = table.Column<decimal>(nullable: false),
                    LaiThucTeGomVe = table.Column<decimal>(nullable: false),
                    NguyenNhanHuyThau = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NguonTour = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FileKhachDiTour = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    FileVeMayBay = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    fileBienNhan = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    NguoiDaiDien = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DoiTacNuocNgoai = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    NgayHuyTour = table.Column<DateTime>(nullable: false),
                    NguoiThaoTac = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HanhDong = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ThoiGianThaoTac = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TourLogs_DMKhachHangs_IdKH",
                        column: x => x.IdKH,
                        principalTable: "DMKhachHangs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TourLogs_LoaiTours_IdLoaiTour",
                        column: x => x.IdLoaiTour,
                        principalTable: "LoaiTours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sgtcode = table.Column<string>(type: "varchar(17)", maxLength: 17, nullable: true),
                    ChuDeTour = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ThiTruong = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiTao = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    BatDau = table.Column<DateTime>(nullable: false),
                    KetThuc = table.Column<DateTime>(nullable: false),
                    TuyenTQ = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SoKhachDK = table.Column<int>(nullable: false),
                    DoanhtTuDK = table.Column<decimal>(nullable: false),
                    IdKH = table.Column<long>(nullable: false),
                    NgayDamPhan = table.Column<DateTime>(nullable: false),
                    HinhThucGiaoDich = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayKyHopDong = table.Column<DateTime>(nullable: false),
                    NguoiKyHopDong = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HanXuatVe = table.Column<DateTime>(nullable: false),
                    NgayThanhLyHD = table.Column<DateTime>(nullable: false),
                    SoKhachTT = table.Column<int>(nullable: false),
                    DoanhThuTT = table.Column<decimal>(nullable: false),
                    ChuongTrinhTour = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    NoiDungThanhLyHD = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DichVu = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DaiLy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TrangThai = table.Column<bool>(nullable: false),
                    NgaySua = table.Column<DateTime>(nullable: false),
                    NguoiSua = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    IdLoaiTour = table.Column<int>(nullable: false),
                    DiemTQ = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MaCN = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: true),
                    NgayNhanDuTien = table.Column<DateTime>(nullable: false),
                    LyDoNhanDu = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SoHopDong = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    LaiChuaVe = table.Column<decimal>(nullable: false),
                    LaiGomVe = table.Column<decimal>(nullable: false),
                    LaiThucTeGomVe = table.Column<decimal>(nullable: false),
                    NguyenNhanHuyThau = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NguonTour = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    FileKhachDiTour = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    FileVeMayBay = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    FileBienNhan = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    NguoiDaiDien = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DoiTacNuocNgoai = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    NgayHuytTour = table.Column<DateTime>(nullable: false),
                    LogFile = table.Column<string>(type: "nvarchar(MAX)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tours_DMKhachHangs_IdKH",
                        column: x => x.IdKH,
                        principalTable: "DMKhachHangs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tours_LoaiTours_IdLoaiTour",
                        column: x => x.IdLoaiTour,
                        principalTable: "LoaiTours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DatCocs",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayDatCoc = table.Column<DateTime>(nullable: true),
                    IdTour = table.Column<long>(nullable: false),
                    SoBienNhan = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    DaiLy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenKhach = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DienThoai = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    NoiDung = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SoTien = table.Column<decimal>(nullable: false),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiTao = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    NgaySua = table.Column<DateTime>(nullable: false),
                    NguoiSua = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    HinhThucThanhToan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ChungTuGoc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenMay = table.Column<string>(type: "nvarchar(3000)", maxLength: 300, nullable: true),
                    LoaiTien = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TyGia = table.Column<decimal>(nullable: false),
                    LogFile = table.Column<string>(type: "nvarchar(MAX)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatCocs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DatCocs_Tours_IdTour",
                        column: x => x.IdTour,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DMHoaHongs",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTour = table.Column<long>(nullable: false),
                    Sales = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Id_DMKH = table.Column<decimal>(nullable: false),
                    TenKhach = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SoCMNN = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    SoTien = table.Column<decimal>(nullable: false),
                    SalesNM = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMHoaHongs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DMHoaHongs_Tours_IdTour",
                        column: x => x.IdTour,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DMKhachTours",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTour = table.Column<long>(nullable: false),
                    TenKhach = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    HoChieu = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    HieuLucHoChieu = table.Column<DateTime>(nullable: false),
                    NgaySinh = table.Column<DateTime>(nullable: false),
                    SoCMND = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true),
                    NgayCMND = table.Column<DateTime>(nullable: false),
                    NoiCapCMND = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    DienThoai = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true),
                    QuocTich = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    TrangThai = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DMKhachTours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DMKhachTours_Tours_IdTour",
                        column: x => x.IdTour,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomingLists",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTour = table.Column<long>(nullable: false),
                    TenKhachSan = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NgayCheckIn = table.Column<DateTime>(nullable: false),
                    NgayCheckOut = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomingLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomingLists_Tours_IdTour",
                        column: x => x.IdTour,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThongTinTours",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTour = table.Column<long>(nullable: false),
                    NoiDungTin = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiTao = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    NguoiSua = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    NgaySua = table.Column<DateTime>(nullable: false),
                    LoaiTin = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinTours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ThongTinTours_Tours_IdTour",
                        column: x => x.IdTour,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VeMayBays",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTour = table.Column<long>(nullable: false),
                    ChuyenBay = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NgayBay = table.Column<DateTime>(nullable: false),
                    DiemDi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DiemDen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GioDi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    GioDen = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NguoiTao = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiSua = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    NgaySua = table.Column<DateTime>(nullable: false),
                    SoVe_ADL_D = table.Column<int>(nullable: false),
                    SoVe_CHL_D = table.Column<int>(nullable: false),
                    SoVe_INF_D = table.Column<int>(nullable: false),
                    SoVe_ADL_V = table.Column<int>(nullable: false),
                    SoVe_CHL_V = table.Column<int>(nullable: false),
                    SoVe_INF_V = table.Column<int>(nullable: false),
                    LuotDiVe = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeMayBays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VeMayBays_Tours_IdTour",
                        column: x => x.IdTour,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DatCocLogs",
                columns: table => new
                {
                    ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDatCoc = table.Column<long>(nullable: false),
                    NgayDatCoc = table.Column<DateTime>(nullable: false),
                    IdTour = table.Column<long>(nullable: false),
                    SoBienNhan = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    NguoiLamBN = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    DaiLy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenKhach = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DienThoai = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    NoiDung = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    SoTien = table.Column<decimal>(nullable: false),
                    NgayTao = table.Column<DateTime>(nullable: false),
                    NguoiTao = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    NgaySua = table.Column<DateTime>(nullable: false),
                    NguoiSua = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    HinhThucThanhToan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ChungTuGoc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TenMay = table.Column<string>(type: "nvarchar(3000)", maxLength: 300, nullable: true),
                    LoaiTienn = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TyGia = table.Column<decimal>(nullable: false),
                    NguoiThaoTac = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    HanhDong = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ThoiGianThaoTac = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatCocLogs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DatCocLogs_DatCocs_IdDatCoc",
                        column: x => x.IdDatCoc,
                        principalTable: "DatCocs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomingListDs",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoPhong = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    KhachTour = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LoaiPhong = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IdRoomingList = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomingListDs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomingListDs_RoomingLists_IdRoomingList",
                        column: x => x.IdRoomingList,
                        principalTable: "RoomingLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DatCocLogs_IdDatCoc",
                table: "DatCocLogs",
                column: "IdDatCoc");

            migrationBuilder.CreateIndex(
                name: "IX_DatCocs_IdTour",
                table: "DatCocs",
                column: "IdTour");

            migrationBuilder.CreateIndex(
                name: "IX_DMHoaHongs_IdTour",
                table: "DMHoaHongs",
                column: "IdTour");

            migrationBuilder.CreateIndex(
                name: "IX_DMKhachTours_IdTour",
                table: "DMKhachTours",
                column: "IdTour");

            migrationBuilder.CreateIndex(
                name: "IX_RoomingListDs_IdRoomingList",
                table: "RoomingListDs",
                column: "IdRoomingList");

            migrationBuilder.CreateIndex(
                name: "IX_RoomingLists_IdTour",
                table: "RoomingLists",
                column: "IdTour");

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinTours_IdTour",
                table: "ThongTinTours",
                column: "IdTour");

            migrationBuilder.CreateIndex(
                name: "IX_TourLogs_IdKH",
                table: "TourLogs",
                column: "IdKH");

            migrationBuilder.CreateIndex(
                name: "IX_TourLogs_IdLoaiTour",
                table: "TourLogs",
                column: "IdLoaiTour");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_IdKH",
                table: "Tours",
                column: "IdKH");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_IdLoaiTour",
                table: "Tours",
                column: "IdLoaiTour");

            migrationBuilder.CreateIndex(
                name: "IX_VeMayBays_IdTour",
                table: "VeMayBays",
                column: "IdTour");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DatCocLogs");

            migrationBuilder.DropTable(
                name: "DMHoaHongs");

            migrationBuilder.DropTable(
                name: "DMKhachTours");

            migrationBuilder.DropTable(
                name: "RoomingListDs");

            migrationBuilder.DropTable(
                name: "ThongTinTours");

            migrationBuilder.DropTable(
                name: "TourLogs");

            migrationBuilder.DropTable(
                name: "TourTMPs");

            migrationBuilder.DropTable(
                name: "VeMayBays");

            migrationBuilder.DropTable(
                name: "DatCocs");

            migrationBuilder.DropTable(
                name: "RoomingLists");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "DMKhachHangs");
        }
    }
}
