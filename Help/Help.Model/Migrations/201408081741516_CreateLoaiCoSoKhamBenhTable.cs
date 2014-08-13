namespace Help.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateLoaiCoSoKhamBenhTable : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.BacSi",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Ten = c.String(maxLength: 50),
            //            Tuoi = c.Int(),
            //            DiaChi = c.String(maxLength: 255),
            //            SoDienThoai = c.String(maxLength: 15, fixedLength: true, unicode: false),
            //            BangCapCaoNhat = c.String(maxLength: 50),
            //            TruongTotNghiep = c.String(maxLength: 10, fixedLength: true),
            //            NamTotNghiep = c.String(maxLength: 10, fixedLength: true, unicode: false),
            //            NguoiTao = c.Int(),
            //            NguoiChinhSua = c.Int(),
            //            NgayTao = c.DateTime(),
            //            NgayChinhSua = c.DateTime(),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.ChiTietBacSi",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            BacSiId = c.Int(),
            //            ChuyenKhoaId = c.Int(),
            //            NoiCongTac = c.Int(),
            //            NguoiTao = c.Int(),
            //            NguoiChinhSua = c.Int(),
            //            NgayTao = c.DateTime(),
            //            NgayChinhSua = c.DateTime(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.BacSi", t => t.BacSiId)
            //    .Index(t => t.BacSiId);
            
            //CreateTable(
            //    "dbo.LichKhamBenh",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            CoSoKhamBenhId = c.Int(),
            //            DichVuKhamId = c.Int(),
            //            KhungGioId = c.Int(),
            //            SoLuongDangKi = c.Int(),
            //            UserId = c.Int(),
            //            BacSiId = c.Int(),
            //            NgayDangKi = c.DateTime(),
            //            NgayChinhSua = c.DateTime(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.BacSi", t => t.BacSiId)
            //    .ForeignKey("dbo.DichVuKham", t => t.DichVuKhamId)
            //    .ForeignKey("dbo.CoSoKhamBenh", t => t.CoSoKhamBenhId)
            //    .ForeignKey("dbo.KhungGio", t => t.KhungGioId)
            //    .ForeignKey("dbo.User", t => t.UserId)
            //    .Index(t => t.CoSoKhamBenhId)
            //    .Index(t => t.DichVuKhamId)
            //    .Index(t => t.KhungGioId)
            //    .Index(t => t.UserId)
            //    .Index(t => t.BacSiId);

            CreateTable(
                "dbo.CoSoKhamBenh",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenCS = c.String(maxLength: 255),
                        DiaChi = c.String(),
                        LoaiCoSo = c.Int(),
                        LoaiDieuTri = c.Int(),
                        ThongTinChung = c.String(),
                        ChuThich = c.String(maxLength: 50),
                        NguoiTao = c.Int(),
                        NguoiChinhSua = c.Int(),
                        NgayTao = c.DateTime(),
                        NgayChinhSua = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LoaiCoSoKhamBenh", t => t.LoaiCoSo)
                .ForeignKey("dbo.LoaiDieuTri", t => t.LoaiDieuTri)
                .Index(t => t.LoaiCoSo)
                .Index(t => t.LoaiDieuTri);

            CreateTable(
               "dbo.LoaiCoSoKhamBenh",
               c => new
               {
                   Id = c.Int(nullable: false, identity: true),
                   Ten = c.String(maxLength: 50),
                   MoTa = c.String(maxLength: 50),
                   NgayTao = c.DateTime(),
                   NgayChinhSua = c.DateTime(),
                   Status = c.Byte(true),
               })
               .PrimaryKey(t => t.Id);

            CreateTable(
               "dbo.LoaiDieuTri",
               c => new
               {
                   Id = c.Int(nullable: false, identity: true),
                   Ten = c.String(maxLength: 50),
                   MoTa = c.String(maxLength: 50),
                   NgayTao = c.DateTime(),
                   NgayChinhSua = c.DateTime(),
                   Status = c.Byte(true),
               })
               .PrimaryKey(t => t.Id);


            //CreateTable(
            //    "dbo.DichVuKham",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            CoSoId = c.Int(),
            //            ChuyenKhoaId = c.Int(),
            //            TenDichVu = c.String(maxLength: 50),
            //            MoTa = c.String(),
            //            KhungGio = c.Int(),
            //            SoLuongPhucVu = c.Int(),
            //            GiaCa = c.Decimal(precision: 18, scale: 2),
            //            NguoiTao = c.Int(),
            //            NguoiChinhSua = c.Int(),
            //            NgayTao = c.DateTime(),
            //            NgayChinhSua = c.DateTime(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.ChuyenKhoa", t => t.ChuyenKhoaId)
            //    .ForeignKey("dbo.CoSoKhamBenh", t => t.CoSoId)
            //    .Index(t => t.CoSoId)
            //    .Index(t => t.ChuyenKhoaId);
            
            //CreateTable(
            //    "dbo.ChuyenKhoa",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            TenChuyenKhoa = c.String(maxLength: 50),
            //            MoTa = c.String(maxLength: 50),
            //            NguoiTao = c.Int(),
            //            NguoiChinhSua = c.Int(),
            //            NgayTao = c.DateTime(),
            //            NgayChinhSua = c.DateTime(),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.KhungGio",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            KhungGio = c.String(maxLength: 20, fixedLength: true, unicode: false),
            //            MoTa = c.String(maxLength: 10, fixedLength: true),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.User",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Ten = c.String(maxLength: 50),
            //            Email = c.String(maxLength: 50),
            //            SoDienThoai = c.String(maxLength: 15, fixedLength: true, unicode: false),
            //            DiaChi = c.String(maxLength: 255),
            //            NamSinh = c.DateTime(storeType: "date"),
            //            GioiTinh = c.String(maxLength: 10, fixedLength: true),
            //            ChieuCao = c.String(maxLength: 10, fixedLength: true, unicode: false),
            //            CanNang = c.String(maxLength: 10, fixedLength: true, unicode: false),
            //            UserGroup = c.Int(),
            //            Status = c.Byte(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.UserGroup", t => t.UserGroup)
            //    .Index(t => t.UserGroup);
            
            //CreateTable(
            //    "dbo.HoSoBenhAn",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            UserId = c.Int(),
            //            CoSoKhamBenhId = c.Int(),
            //            BacSiId = c.Int(),
            //            LoaiBenhId = c.Int(),
            //            KetQua = c.String(maxLength: 255),
            //            NguoiTao = c.Int(),
            //            NguoiChinhSua = c.Int(),
            //            NgayTao = c.DateTime(),
            //            NgayChinhSua = c.DateTime(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.Benh", t => t.LoaiBenhId)
            //    .ForeignKey("dbo.User", t => t.UserId)
            //    .Index(t => t.UserId)
            //    .Index(t => t.LoaiBenhId);
            
            //CreateTable(
            //    "dbo.Benh",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            TenBenh = c.String(maxLength: 50),
            //            MoTa = c.String(maxLength: 50),
            //            NguoiTao = c.Int(),
            //            NguoiChinhSua = c.Int(),
            //            NgayTao = c.DateTime(),
            //            NgayChinhSua = c.DateTime(),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.UserGroup",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Ten = c.String(maxLength: 50),
            //            MoTa = c.String(maxLength: 50),
            //        })
            //    .PrimaryKey(t => t.Id);
            
            //CreateTable(
            //    "dbo.UserAdmin",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Username = c.String(maxLength: 50),
            //            Password = c.String(maxLength: 50),
            //            Email = c.String(maxLength: 50),
            //            UserGroup = c.Int(nullable: false),
            //            NgayTao = c.DateTime(),
            //            NgayChinhSua = c.DateTime(),
            //            Status = c.Byte(),
            //        })
            //    .PrimaryKey(t => t.Id)
            //    .ForeignKey("dbo.UserGroup", t => t.UserGroup)
            //    .Index(t => t.UserGroup);

           


        }
        
        public override void Down()
        {
            DropForeignKey("dbo.User", "UserGroup", "dbo.UserGroup");
            DropForeignKey("dbo.UserAdmin", "UserGroup", "dbo.UserGroup");
            DropForeignKey("dbo.LichKhamBenh", "UserId", "dbo.User");
            DropForeignKey("dbo.HoSoBenhAn", "UserId", "dbo.User");
            DropForeignKey("dbo.HoSoBenhAn", "LoaiBenhId", "dbo.Benh");
            DropForeignKey("dbo.LichKhamBenh", "KhungGioId", "dbo.KhungGio");
            DropForeignKey("dbo.LichKhamBenh", "CoSoKhamBenhId", "dbo.CoSoKhamBenh");
            DropForeignKey("dbo.DichVuKham", "CoSoId", "dbo.CoSoKhamBenh");
            DropForeignKey("dbo.LichKhamBenh", "DichVuKhamId", "dbo.DichVuKham");
            DropForeignKey("dbo.DichVuKham", "ChuyenKhoaId", "dbo.ChuyenKhoa");
            DropForeignKey("dbo.LichKhamBenh", "BacSiId", "dbo.BacSi");
            DropForeignKey("dbo.ChiTietBacSi", "BacSiId", "dbo.BacSi");
            DropIndex("dbo.UserAdmin", new[] { "UserGroup" });
            DropIndex("dbo.HoSoBenhAn", new[] { "LoaiBenhId" });
            DropIndex("dbo.HoSoBenhAn", new[] { "UserId" });
            DropIndex("dbo.User", new[] { "UserGroup" });
            DropIndex("dbo.DichVuKham", new[] { "ChuyenKhoaId" });
            DropIndex("dbo.DichVuKham", new[] { "CoSoId" });
            DropIndex("dbo.LichKhamBenh", new[] { "BacSiId" });
            DropIndex("dbo.LichKhamBenh", new[] { "UserId" });
            DropIndex("dbo.LichKhamBenh", new[] { "KhungGioId" });
            DropIndex("dbo.LichKhamBenh", new[] { "DichVuKhamId" });
            DropIndex("dbo.LichKhamBenh", new[] { "CoSoKhamBenhId" });
            DropIndex("dbo.ChiTietBacSi", new[] { "BacSiId" });
            DropTable("dbo.UserAdmin");
            DropTable("dbo.UserGroup");
            DropTable("dbo.Benh");
            DropTable("dbo.HoSoBenhAn");
            DropTable("dbo.User");
            DropTable("dbo.KhungGio");
            DropTable("dbo.ChuyenKhoa");
            DropTable("dbo.DichVuKham");
            DropTable("dbo.CoSoKhamBenh");
            DropTable("dbo.LichKhamBenh");
            DropTable("dbo.ChiTietBacSi");
            DropTable("dbo.BacSi");
        }
    }
}
