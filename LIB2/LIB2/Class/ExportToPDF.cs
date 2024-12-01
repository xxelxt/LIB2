using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System;
using System.Data;
using System.Diagnostics;
using PdfSharp;

namespace LIB2.Class
{
    public class ExportToPDF
    {
        public static void exportPNK(DataTable tblThongTinPNK, DataTable tblThongTinCTPNK, string outputPath)
        {
            try
            {
                if (tblThongTinPNK.Rows.Count == 0 || tblThongTinCTPNK.Rows.Count == 0)
                    throw new Exception("Dữ liệu không hợp lệ.");

                PdfDocument document = new PdfDocument();
                document.Info.Title = "PHIẾU NHẬP KHO";

                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);

                XFont titleFont = new XFont("Times New Roman", 12.5, XFontStyle.Bold);
                XFont normalFont = new XFont("Times New Roman", 12.5, XFontStyle.Regular);
                XFont footerFont = new XFont("Times New Roman", 12.5, XFontStyle.Bold);

                double y = 60;

                gfx.DrawString("HỌC VIỆN NGÂN HÀNG", titleFont, XBrushes.Black, new XRect(0, y, page.Width, 30), XStringFormats.TopCenter);
                y += 30;

                gfx.DrawString("PHIẾU NHẬP KHO", titleFont, XBrushes.Black, new XRect(0, y, page.Width, 30), XStringFormats.TopCenter);
                y += 30;

                // Thông tin chung
                DataRow info = tblThongTinPNK.Rows[0];

                // Tạo bảng và thêm viền
                double x = 40;
                double tableWidth = page.Width - 80; // Giảm bớt chiều rộng để đảm bảo viền không bị cắt
                double rowHeight = 20;

                // Header bảng
                gfx.DrawRectangle(XPens.Black, x, y, tableWidth, rowHeight); // Header viền
                gfx.DrawString("MÃ TÀI LIỆU", titleFont, XBrushes.Black, new XPoint(x + 5, y + 14));
                gfx.DrawString("TÊN TÀI LIỆU", titleFont, XBrushes.Black, new XPoint(x + 100, y + 14));
                gfx.DrawString("SỐ LƯỢNG", titleFont, XBrushes.Black, new XPoint(x + 240, y + 14));
                gfx.DrawString("ĐƠN GIÁ", titleFont, XBrushes.Black, new XPoint(x + 320, y + 14));
                gfx.DrawString("THÀNH TIỀN", titleFont, XBrushes.Black, new XPoint(x + 400, y + 14));
                y += rowHeight;

                // Vẽ các ô trong bảng
                foreach (DataRow row in tblThongTinCTPNK.Rows)
                {
                    gfx.DrawRectangle(XPens.Black, x, y, tableWidth, rowHeight); // Vẽ viền cho mỗi ô
                    gfx.DrawString(row["MaTL"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 5, y + 14));
                    gfx.DrawString(row["TenTL"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 100, y + 14));
                    gfx.DrawString(row["SoLuong"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 240, y + 14));
                    gfx.DrawString(Convert.ToDecimal(row["DonGia"]).ToString("N0"), normalFont, XBrushes.Black, new XPoint(x + 320, y + 14));
                    decimal thanhTien = Convert.ToDecimal(row["SoLuong"]) * Convert.ToDecimal(row["DonGia"]);
                    gfx.DrawString(thanhTien.ToString("N0"), normalFont, XBrushes.Black, new XPoint(x + 400, y + 14));
                    y += rowHeight;
                }

                // Thêm thông tin "Thư viện" và "Người lập báo cáo"
                y += 30; // Tạo khoảng trống trước footer

                // Thêm phần "Ngày lập" định dạng kiểu "Hà Nội, ngày ... tháng ... năm ..."
                DateTime ngayLap = Convert.ToDateTime(info["NgayLap"]);
                string ngayThangNam = $"Hà Nội, ngày {ngayLap.Day} tháng {ngayLap.Month} năm {ngayLap.Year}";
                gfx.DrawString(ngayThangNam, normalFont, XBrushes.Black, new XRect(125, y, page.Width, 20), XStringFormats.TopCenter);
                y += 35; // Tăng khoảng cách sau "Ngày lập"

                double footerLeftX = x + 50; // Vị trí bên trái
                double footerRightX = page.Width - x - 200; // Vị trí bên phải (cách lề phải 200 điểm)

                // "Thư viện" ở bên trái
                gfx.DrawString("THƯ VIỆN", footerFont, XBrushes.Black, new XPoint(footerLeftX + 35, y));
                gfx.DrawString("(Ký và ghi họ tên)", normalFont, XBrushes.Black, new XPoint(footerLeftX + 20, y + 20));

                // "Người lập báo cáo" ở bên phải
                gfx.DrawString("NGƯỜI LẬP BÁO CÁO", footerFont, XBrushes.Black, new XPoint(footerRightX, y));
                gfx.DrawString("(Ký và ghi họ tên)", normalFont, XBrushes.Black, new XPoint(footerRightX + 20, y + 20));

                // Tăng khoảng cách cho phần tên người lập và người duyệt
                y += 60;

                // Hiển thị tên "Người lập" và "Người duyệt" bên dưới
                //gfx.DrawString(info["TenNVLap"].ToString(), normalFont, XBrushes.Black, new XPoint(footerRightX, y)); // Người lập bên phải
                //gfx.DrawString(info["TenNVDuyet"].ToString(), normalFont, XBrushes.Black, new XPoint(footerLeftX, y)); // Người duyệt bên trái

                // Lưu file
                document.Save(outputPath);

                // Mở file PDF sau khi lưu
                Process.Start(new ProcessStartInfo(outputPath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xuất PDF với PdfSharp: " + ex.Message);
            }
        }

        public static void exportPL(DataTable tblThongTinPL, DataTable tblThongTinCTPL, string outputPath)
        {
            try
            {
                if (tblThongTinPL.Rows.Count == 0 || tblThongTinCTPL.Rows.Count == 0)
                    throw new Exception("Dữ liệu không hợp lệ.");

                PdfDocument document = new PdfDocument();
                document.Info.Title = "PHIẾU LỖI";

                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);

                XFont titleFont = new XFont("Times New Roman", 12.5, XFontStyle.Bold);
                XFont normalFont = new XFont("Times New Roman", 12.5, XFontStyle.Regular);
                XFont footerFont = new XFont("Times New Roman", 12.5, XFontStyle.Bold);

                double y = 60;

                gfx.DrawString("HỌC VIỆN NGÂN HÀNG", titleFont, XBrushes.Black, new XRect(0, y, page.Width, 30), XStringFormats.TopCenter);
                y += 30;

                gfx.DrawString("PHIẾU LỖI", titleFont, XBrushes.Black, new XRect(0, y, page.Width, 30), XStringFormats.TopCenter);
                y += 30;

                // Thông tin chung
                DataRow info = tblThongTinPL.Rows[0];

                // Tạo bảng và thêm viền
                double x = 40;
                double tableWidth = page.Width - 80; // Giảm bớt chiều rộng để đảm bảo viền không bị cắt
                double rowHeight = 20;

                // Header bảng
                gfx.DrawRectangle(XPens.Black, x, y, tableWidth, rowHeight); // Header viền
                gfx.DrawString("MÃ TÀI LIỆU", titleFont, XBrushes.Black, new XPoint(x + 5, y + 14));
                gfx.DrawString("TÊN TÀI LIỆU", titleFont, XBrushes.Black, new XPoint(x + 100, y + 14));
                gfx.DrawString("SL", titleFont, XBrushes.Black, new XPoint(x + 240, y + 14));
                gfx.DrawString("LỖI TÀI LIỆU", titleFont, XBrushes.Black, new XPoint(x + 280, y + 14));
                gfx.DrawString("ĐƠN GIÁ", titleFont, XBrushes.Black, new XPoint(x + 440, y + 14));
                y += rowHeight;

                // Vẽ các ô trong bảng
                foreach (DataRow row in tblThongTinCTPL.Rows)
                {
                    gfx.DrawRectangle(XPens.Black, x, y, tableWidth, rowHeight); // Vẽ viền cho mỗi ô
                    gfx.DrawString(row["MaTL"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 5, y + 14));
                    gfx.DrawString(row["TenTL"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 100, y + 14));
                    gfx.DrawString(row["SoLuong"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 240, y + 14));
                    gfx.DrawString(row["LoiTaiLieu"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 280, y + 14));
                    gfx.DrawString(Convert.ToDecimal(row["DonGia"]).ToString("N0"), normalFont, XBrushes.Black, new XPoint(x + 440, y + 14));
                    y += rowHeight;
                }

                // Thêm thông tin "Thư viện" và "Người lập báo cáo"
                y += 30; // Tạo khoảng trống trước footer

                // Thêm phần "Ngày lập" định dạng kiểu "Hà Nội, ngày ... tháng ... năm ..."
                DateTime ngayLap = Convert.ToDateTime(info["NgayLap"]);
                string ngayThangNam = $"Hà Nội, ngày {ngayLap.Day} tháng {ngayLap.Month} năm {ngayLap.Year}";
                gfx.DrawString(ngayThangNam, normalFont, XBrushes.Black, new XRect(125, y, page.Width, 20), XStringFormats.TopCenter);
                y += 35; // Tăng khoảng cách sau "Ngày lập"

                double footerLeftX = x + 50; // Vị trí bên trái
                double footerRightX = page.Width - x - 200; // Vị trí bên phải (cách lề phải 200 điểm)

                // "Thư viện" ở bên trái
                gfx.DrawString("THƯ VIỆN", footerFont, XBrushes.Black, new XPoint(footerLeftX + 35, y));
                gfx.DrawString("(Ký và ghi họ tên)", normalFont, XBrushes.Black, new XPoint(footerLeftX + 20, y + 20));

                // "Người lập báo cáo" ở bên phải
                gfx.DrawString("NGƯỜI LẬP BÁO CÁO", footerFont, XBrushes.Black, new XPoint(footerRightX, y));
                gfx.DrawString("(Ký và ghi họ tên)", normalFont, XBrushes.Black, new XPoint(footerRightX + 20, y + 20));

                // Tăng khoảng cách cho phần tên người lập và người duyệt
                y += 60;

                // Hiển thị tên "Người lập" và "Người duyệt" bên dưới
                //gfx.DrawString(info["TenNVLap"].ToString(), normalFont, XBrushes.Black, new XPoint(footerRightX, y)); // Người lập bên phải
                //gfx.DrawString(info["TenNVDuyet"].ToString(), normalFont, XBrushes.Black, new XPoint(footerLeftX, y)); // Người duyệt bên trái

                // Lưu file
                document.Save(outputPath);

                // Mở file PDF sau khi lưu
                Process.Start(new ProcessStartInfo(outputPath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xuất PDF với PdfSharp: " + ex.Message);
            }
        }

        public static void exportDMBT(DataTable tblThongTinDMBT, DataTable tblThongTinCTDMBT, string outputPath)
        {
            try
            {
                if (tblThongTinDMBT.Rows.Count == 0 || tblThongTinDMBT.Rows.Count == 0)
                    throw new Exception("Dữ liệu không hợp lệ.");

                PdfDocument document = new PdfDocument();
                document.Info.Title = "DANH MỤC TÀI LIỆU ĐƯỢC BỒI THƯỜNG";

                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);

                XFont titleFont = new XFont("Times New Roman", 12.5, XFontStyle.Bold);
                XFont normalFont = new XFont("Times New Roman", 12.5, XFontStyle.Regular);
                XFont footerFont = new XFont("Times New Roman", 12.5, XFontStyle.Bold);

                double y = 60;

                gfx.DrawString("HỌC VIỆN NGÂN HÀNG", titleFont, XBrushes.Black, new XRect(0, y, page.Width, 30), XStringFormats.TopCenter);
                y += 30;

                gfx.DrawString("DANH MỤC TÀI LIỆU ĐƯỢC BỒI THƯỜNG", titleFont, XBrushes.Black, new XRect(0, y, page.Width, 30), XStringFormats.TopCenter);
                y += 30;

                // Thông tin chung
                DataRow info = tblThongTinDMBT.Rows[0];

                // Tạo bảng và thêm viền
                double x = 40;
                double tableWidth = page.Width - 80; // Giảm bớt chiều rộng để đảm bảo viền không bị cắt
                double rowHeight = 20;

                // Header bảng
                gfx.DrawRectangle(XPens.Black, x, y, tableWidth, rowHeight); // Header viền
                gfx.DrawString("MÃ TÀI LIỆU", titleFont, XBrushes.Black, new XPoint(x + 5, y + 14));
                gfx.DrawString("TÊN TÀI LIỆU", titleFont, XBrushes.Black, new XPoint(x + 100, y + 14));
                gfx.DrawString("SỐ LƯỢNG", titleFont, XBrushes.Black, new XPoint(x + 240, y + 14));
                gfx.DrawString("ĐƠN GIÁ", titleFont, XBrushes.Black, new XPoint(x + 320, y + 14));
                gfx.DrawString("THÀNH TIỀN", titleFont, XBrushes.Black, new XPoint(x + 400, y + 14));
                y += rowHeight;

                // Vẽ các ô trong bảng
                foreach (DataRow row in tblThongTinCTDMBT.Rows)
                {
                    gfx.DrawRectangle(XPens.Black, x, y, tableWidth, rowHeight); // Vẽ viền cho mỗi ô
                    gfx.DrawString(row["MaTL"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 5, y + 14));
                    gfx.DrawString(row["TenTL"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 100, y + 14));
                    gfx.DrawString(row["SoLuong"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 240, y + 14));
                    gfx.DrawString(Convert.ToDecimal(row["DonGia"]).ToString("N0"), normalFont, XBrushes.Black, new XPoint(x + 320, y + 14));
                    decimal thanhTien = Convert.ToDecimal(row["SoLuong"]) * Convert.ToDecimal(row["DonGia"]);
                    gfx.DrawString(thanhTien.ToString("N0"), normalFont, XBrushes.Black, new XPoint(x + 400, y + 14));
                    y += rowHeight;
                }

                // Thêm thông tin "Thư viện" và "Người lập báo cáo"
                y += 30; // Tạo khoảng trống trước footer

                // Thêm phần "Ngày lập" định dạng kiểu "Hà Nội, ngày ... tháng ... năm ..."
                DateTime ngayLap = Convert.ToDateTime(info["NgayLap"]);
                string ngayThangNam = $"Hà Nội, ngày {ngayLap.Day} tháng {ngayLap.Month} năm {ngayLap.Year}";
                gfx.DrawString(ngayThangNam, normalFont, XBrushes.Black, new XRect(125, y, page.Width, 20), XStringFormats.TopCenter);
                y += 35; // Tăng khoảng cách sau "Ngày lập"

                double footerLeftX = x + 50; // Vị trí bên trái
                double footerRightX = page.Width - x - 200; // Vị trí bên phải (cách lề phải 200 điểm)

                // "Thư viện" ở bên trái
                //gfx.DrawString("THƯ VIỆN", footerFont, XBrushes.Black, new XPoint(footerLeftX + 35, y));
                //gfx.DrawString("(Ký và ghi họ tên)", normalFont, XBrushes.Black, new XPoint(footerLeftX + 20, y + 20));

                // "Người lập báo cáo" ở bên phải
                gfx.DrawString("NGƯỜI LẬP BÁO CÁO", footerFont, XBrushes.Black, new XPoint(footerRightX, y));
                gfx.DrawString("(Ký và ghi họ tên)", normalFont, XBrushes.Black, new XPoint(footerRightX + 20, y + 20));

                // Tăng khoảng cách cho phần tên người lập và người duyệt
                y += 60;

                // Hiển thị tên "Người lập" và "Người duyệt" bên dưới
                //gfx.DrawString(info["TenNVLap"].ToString(), normalFont, XBrushes.Black, new XPoint(footerRightX, y)); // Người lập bên phải
                //gfx.DrawString(info["TenNVDuyet"].ToString(), normalFont, XBrushes.Black, new XPoint(footerLeftX, y)); // Người duyệt bên trái

                // Lưu file
                document.Save(outputPath);

                // Mở file PDF sau khi lưu
                Process.Start(new ProcessStartInfo(outputPath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xuất PDF với PdfSharp: " + ex.Message);
            }
        }

        public static void exportDMSC(DataTable tblThongTinDMSC, DataTable tblThongTinCTDMSC, string outputPath)
        {
            try
            {
                if (tblThongTinDMSC.Rows.Count == 0 || tblThongTinCTDMSC.Rows.Count == 0)
                    throw new Exception("Dữ liệu không hợp lệ.");

                PdfDocument document = new PdfDocument();
                document.Info.Title = "DANH MỤC TÀI LIỆU CẦN SỬA CHỮA, PHỤC CHẾ";

                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);

                XFont titleFont = new XFont("Times New Roman", 12.5, XFontStyle.Bold);
                XFont normalFont = new XFont("Times New Roman", 12.5, XFontStyle.Regular);
                XFont footerFont = new XFont("Times New Roman", 12.5, XFontStyle.Bold);

                double y = 60;

                gfx.DrawString("HỌC VIỆN NGÂN HÀNG", titleFont, XBrushes.Black, new XRect(0, y, page.Width, 30), XStringFormats.TopCenter);
                y += 30;

                gfx.DrawString("DANH MỤC TÀI LIỆU CẦN SỬA CHỮA, PHỤC CHẾ", titleFont, XBrushes.Black, new XRect(0, y, page.Width, 30), XStringFormats.TopCenter);
                y += 30;

                // Thông tin chung
                DataRow info = tblThongTinDMSC.Rows[0];

                // Tạo bảng và thêm viền
                double x = 40;
                double tableWidth = page.Width - 80; // Giảm bớt chiều rộng để đảm bảo viền không bị cắt
                double rowHeight = 20;

                // Header bảng
                gfx.DrawRectangle(XPens.Black, x, y, tableWidth, rowHeight); // Header viền
                gfx.DrawString("MÃ TÀI LIỆU", titleFont, XBrushes.Black, new XPoint(x + 5, y + 14));
                gfx.DrawString("TÊN TÀI LIỆU", titleFont, XBrushes.Black, new XPoint(x + 100, y + 14));
                gfx.DrawString("SỐ LƯỢNG", titleFont, XBrushes.Black, new XPoint(x + 400, y + 14));
                y += rowHeight;

                // Vẽ các ô trong bảng
                foreach (DataRow row in tblThongTinCTDMSC.Rows)
                {
                    gfx.DrawRectangle(XPens.Black, x, y, tableWidth, rowHeight); // Vẽ viền cho mỗi ô
                    gfx.DrawString(row["MaTL"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 5, y + 14));
                    gfx.DrawString(row["TenTL"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 100, y + 14));
                    gfx.DrawString(row["SoLuong"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 400, y + 14));
                    y += rowHeight;
                }

                // Thêm thông tin "Thư viện" và "Người lập báo cáo"
                y += 30; // Tạo khoảng trống trước footer

                // Thêm phần "Ngày lập" định dạng kiểu "Hà Nội, ngày ... tháng ... năm ..."
                DateTime ngayLap = Convert.ToDateTime(info["NgayLap"]);
                string ngayThangNam = $"Hà Nội, ngày {ngayLap.Day} tháng {ngayLap.Month} năm {ngayLap.Year}";
                gfx.DrawString(ngayThangNam, normalFont, XBrushes.Black, new XRect(125, y, page.Width, 20), XStringFormats.TopCenter);
                y += 35; // Tăng khoảng cách sau "Ngày lập"

                double footerLeftX = x + 50; // Vị trí bên trái
                double footerRightX = page.Width - x - 200; // Vị trí bên phải (cách lề phải 200 điểm)

                // "Thư viện" ở bên trái
                //gfx.DrawString("THƯ VIỆN", footerFont, XBrushes.Black, new XPoint(footerLeftX + 35, y));
                //gfx.DrawString("(Ký và ghi họ tên)", normalFont, XBrushes.Black, new XPoint(footerLeftX + 20, y + 20));

                // "Người lập báo cáo" ở bên phải
                gfx.DrawString("NGƯỜI LẬP BÁO CÁO", footerFont, XBrushes.Black, new XPoint(footerRightX, y));
                gfx.DrawString("(Ký và ghi họ tên)", normalFont, XBrushes.Black, new XPoint(footerRightX + 20, y + 20));

                // Tăng khoảng cách cho phần tên người lập và người duyệt
                y += 60;

                // Hiển thị tên "Người lập" và "Người duyệt" bên dưới
                //gfx.DrawString(info["TenNVLap"].ToString(), normalFont, XBrushes.Black, new XPoint(footerRightX, y)); // Người lập bên phải
                //gfx.DrawString(info["TenNVDuyet"].ToString(), normalFont, XBrushes.Black, new XPoint(footerLeftX, y)); // Người duyệt bên trái

                // Lưu file
                document.Save(outputPath);

                // Mở file PDF sau khi lưu
                Process.Start(new ProcessStartInfo(outputPath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xuất PDF với PdfSharp: " + ex.Message);
            }
        }

        public static void exportPKK(DataTable tblThongTinPKK, DataTable tblThongTinCTPKK, string outputPath)
        {
            try
            {
                if (tblThongTinPKK.Rows.Count == 0 || tblThongTinCTPKK.Rows.Count == 0)
                    throw new Exception("Dữ liệu không hợp lệ.");

                PdfDocument document = new PdfDocument();
                document.Info.Title = "PHIẾU KIỂM KÊ";

                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);

                XFont titleFont = new XFont("Times New Roman", 12.5, XFontStyle.Bold);
                XFont normalFont = new XFont("Times New Roman", 12.5, XFontStyle.Regular);
                XFont footerFont = new XFont("Times New Roman", 12.5, XFontStyle.Bold);

                double y = 60;

                gfx.DrawString("HỌC VIỆN NGÂN HÀNG", titleFont, XBrushes.Black, new XRect(0, y, page.Width, 30), XStringFormats.TopCenter);
                y += 30;

                gfx.DrawString("PHIẾU KIỂM KÊ", titleFont, XBrushes.Black, new XRect(0, y, page.Width, 30), XStringFormats.TopCenter);
                y += 30;

                // Thông tin chung
                DataRow info = tblThongTinPKK.Rows[0];

                // Tạo bảng và thêm viền
                double x = 40;
                double tableWidth = page.Width - 80; // Giảm bớt chiều rộng để đảm bảo viền không bị cắt
                double rowHeight = 20;

                // Header bảng
                gfx.DrawRectangle(XPens.Black, x, y, tableWidth, rowHeight); // Header viền
                gfx.DrawString("MÃ TÀI LIỆU", titleFont, XBrushes.Black, new XPoint(x + 5, y + 14));
                gfx.DrawString("TÊN TÀI LIỆU", titleFont, XBrushes.Black, new XPoint(x + 100, y + 14));
                gfx.DrawString("SỐ LƯỢNG", titleFont, XBrushes.Black, new XPoint(x + 240, y + 14));
                gfx.DrawString("ĐƠN GIÁ", titleFont, XBrushes.Black, new XPoint(x + 320, y + 14));
                gfx.DrawString("THÀNH TIỀN", titleFont, XBrushes.Black, new XPoint(x + 400, y + 14));
                y += rowHeight;

                // Vẽ các ô trong bảng
                foreach (DataRow row in tblThongTinCTPKK.Rows)
                {
                    gfx.DrawRectangle(XPens.Black, x, y, tableWidth, rowHeight); // Vẽ viền cho mỗi ô
                    gfx.DrawString(row["MaTL"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 5, y + 14));
                    gfx.DrawString(row["TenTL"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 100, y + 14));
                    gfx.DrawString(row["SoLuong"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 240, y + 14));
                    gfx.DrawString(Convert.ToDecimal(row["DonGia"]).ToString("N0"), normalFont, XBrushes.Black, new XPoint(x + 320, y + 14));
                    decimal thanhTien = Convert.ToDecimal(row["SoLuong"]) * Convert.ToDecimal(row["DonGia"]);
                    gfx.DrawString(thanhTien.ToString("N0"), normalFont, XBrushes.Black, new XPoint(x + 400, y + 14));
                    y += rowHeight;
                }

                // Thêm thông tin "Thư viện" và "Người lập báo cáo"
                y += 30; // Tạo khoảng trống trước footer

                // Thêm phần "Ngày lập" định dạng kiểu "Hà Nội, ngày ... tháng ... năm ..."
                DateTime ngayLap = Convert.ToDateTime(info["NgayLap"]);
                string ngayThangNam = $"Hà Nội, ngày {ngayLap.Day} tháng {ngayLap.Month} năm {ngayLap.Year}";
                gfx.DrawString(ngayThangNam, normalFont, XBrushes.Black, new XRect(125, y, page.Width, 20), XStringFormats.TopCenter);
                y += 35; // Tăng khoảng cách sau "Ngày lập"

                double footerLeftX = x + 50; // Vị trí bên trái
                double footerRightX = page.Width - x - 200; // Vị trí bên phải (cách lề phải 200 điểm)

                // "Thư viện" ở bên trái
                //gfx.DrawString("THƯ VIỆN", footerFont, XBrushes.Black, new XPoint(footerLeftX + 35, y));
                //gfx.DrawString("(Ký và ghi họ tên)", normalFont, XBrushes.Black, new XPoint(footerLeftX + 20, y + 20));

                // "Người lập báo cáo" ở bên phải
                gfx.DrawString("NGƯỜI LẬP BÁO CÁO", footerFont, XBrushes.Black, new XPoint(footerRightX, y));
                gfx.DrawString("(Ký và ghi họ tên)", normalFont, XBrushes.Black, new XPoint(footerRightX + 20, y + 20));

                // Tăng khoảng cách cho phần tên người lập và người duyệt
                y += 60;

                // Hiển thị tên "Người lập" và "Người duyệt" bên dưới
                //gfx.DrawString(info["TenNVLap"].ToString(), normalFont, XBrushes.Black, new XPoint(footerRightX, y)); // Người lập bên phải
                //gfx.DrawString(info["TenNVDuyet"].ToString(), normalFont, XBrushes.Black, new XPoint(footerLeftX, y)); // Người duyệt bên trái

                // Lưu file
                document.Save(outputPath);

                // Mở file PDF sau khi lưu
                Process.Start(new ProcessStartInfo(outputPath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xuất PDF với PdfSharp: " + ex.Message);
            }
        }

        public static void exportDMTL(DataTable tblThongTinDMTL, DataTable tblThongTinCTDMTL, string outputPath)
        {
            try
            {
                if (tblThongTinDMTL.Rows.Count == 0 || tblThongTinCTDMTL.Rows.Count == 0)
                    throw new Exception("Dữ liệu không hợp lệ.");

                PdfDocument document = new PdfDocument();
                document.Info.Title = "DANH MỤC TÀI LIỆU XỬ LÝ, THANH LỌC";

                // Tạo trang PDF ở chế độ ngang (landscape)
                PdfPage page = document.AddPage();
                page.Orientation = PageOrientation.Landscape;

                XGraphics gfx = XGraphics.FromPdfPage(page);

                XFont titleFont = new XFont("Times New Roman", 12.5, XFontStyle.Bold);
                XFont normalFont = new XFont("Times New Roman", 12.5, XFontStyle.Regular);
                XFont footerFont = new XFont("Times New Roman", 12.5, XFontStyle.Bold);

                double y = 60;

                gfx.DrawString("HỌC VIỆN NGÂN HÀNG", titleFont, XBrushes.Black, new XRect(0, y, page.Width, 30), XStringFormats.TopCenter);
                y += 30;

                gfx.DrawString("DANH MỤC TÀI LIỆU XỬ LÝ, THANH LỌC", titleFont, XBrushes.Black, new XRect(0, y, page.Width, 30), XStringFormats.TopCenter);
                y += 30;

                // Thông tin chung
                DataRow info = tblThongTinDMTL.Rows[0];

                // Tạo bảng và thêm viền
                double x = 40;
                double tableWidth = page.Width - 80; // Giảm bớt chiều rộng để đảm bảo viền không bị cắt
                double rowHeight = 20;

                // Header bảng
                gfx.DrawRectangle(XPens.Black, x, y, tableWidth, rowHeight); // Header viền
                gfx.DrawString("MÃ TÀI LIỆU", titleFont, XBrushes.Black, new XPoint(x + 5, y + 14));
                gfx.DrawString("TÊN TÀI LIỆU", titleFont, XBrushes.Black, new XPoint(x + 100, y + 14));
                gfx.DrawString("SL", titleFont, XBrushes.Black, new XPoint(x + 240, y + 14));
                gfx.DrawString("ĐƠN GIÁ", titleFont, XBrushes.Black, new XPoint(x + 280, y + 14));
                gfx.DrawString("LÝ DO THANH LỌC", titleFont, XBrushes.Black, new XPoint(x + 360, y + 14));
                gfx.DrawString("PHƯƠNG ÁN XỬ LÝ", titleFont, XBrushes.Black, new XPoint(x + 540, y + 14));
                y += rowHeight;

                // Vẽ các ô trong bảng
                foreach (DataRow row in tblThongTinCTDMTL.Rows)
                {
                    gfx.DrawRectangle(XPens.Black, x, y, tableWidth, rowHeight); // Vẽ viền cho mỗi ô
                    gfx.DrawString(row["MaTL"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 5, y + 14));
                    gfx.DrawString(row["TenTL"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 100, y + 14));
                    gfx.DrawString(row["SoLuong"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 240, y + 14));
                    gfx.DrawString(Convert.ToDecimal(row["DonGia"]).ToString("N0"), normalFont, XBrushes.Black, new XPoint(x + 280, y + 14));
                    gfx.DrawString(row["LyDoThanhLoc"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 360, y + 14));
                    gfx.DrawString(row["PhuongAnXuLy"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 540, y + 14));
                    y += rowHeight;
                }

                // Thêm thông tin "Thư viện" và "Người lập báo cáo"
                y += 30; // Tạo khoảng trống trước footer

                // Thêm phần "Ngày lập" định dạng kiểu "Hà Nội, ngày ... tháng ... năm ..."
                DateTime ngayLap = Convert.ToDateTime(info["NgayLap"]);
                string ngayThangNam = $"Hà Nội, ngày {ngayLap.Day} tháng {ngayLap.Month} năm {ngayLap.Year}";
                gfx.DrawString(ngayThangNam, normalFont, XBrushes.Black, new XRect(250, y, page.Width, 20), XStringFormats.TopCenter);
                y += 35; // Tăng khoảng cách sau "Ngày lập"

                double footerLeftX = x + 50; // Vị trí bên trái
                double footerRightX = page.Width - x - 200; // Vị trí bên phải (cách lề phải 200 điểm)

                // "Thư viện" ở bên trái
                gfx.DrawString("THƯ VIỆN", footerFont, XBrushes.Black, new XPoint(footerLeftX + 35, y));
                gfx.DrawString("(Ký và ghi họ tên)", normalFont, XBrushes.Black, new XPoint(footerLeftX + 20, y + 20));

                // "Người lập báo cáo" ở bên phải
                gfx.DrawString("NGƯỜI LẬP BÁO CÁO", footerFont, XBrushes.Black, new XPoint(footerRightX, y));
                gfx.DrawString("(Ký và ghi họ tên)", normalFont, XBrushes.Black, new XPoint(footerRightX + 20, y + 20));

                // Tăng khoảng cách cho phần tên người lập và người duyệt
                y += 60;

                // Hiển thị tên "Người lập" và "Người duyệt" bên dưới
                //gfx.DrawString(info["TenNVLap"].ToString(), normalFont, XBrushes.Black, new XPoint(footerRightX, y)); // Người lập bên phải
                //gfx.DrawString(info["TenNVDuyet"].ToString(), normalFont, XBrushes.Black, new XPoint(footerLeftX, y)); // Người duyệt bên trái

                // Lưu file
                document.Save(outputPath);

                // Mở file PDF sau khi lưu
                Process.Start(new ProcessStartInfo(outputPath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xuất PDF với PdfSharp: " + ex.Message);
            }
        }

        public static void exportBCKK(DataTable tblThongTinBCKK, DataTable tblThongTinCTBCKK, string outputPath)
        {
            try
            {
                if (tblThongTinBCKK.Rows.Count == 0 || tblThongTinCTBCKK.Rows.Count == 0)
                    throw new Exception("Dữ liệu không hợp lệ.");

                PdfDocument document = new PdfDocument();
                document.Info.Title = "BÁO CÁO KẾT QUẢ KIỂM KÊ";

                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);

                XFont titleFont = new XFont("Times New Roman", 12.5, XFontStyle.Bold);
                XFont normalFont = new XFont("Times New Roman", 12.5, XFontStyle.Regular);
                XFont footerFont = new XFont("Times New Roman", 12.5, XFontStyle.Bold);

                double y = 60;

                gfx.DrawString("HỌC VIỆN NGÂN HÀNG", titleFont, XBrushes.Black, new XRect(0, y, page.Width, 30), XStringFormats.TopCenter);
                y += 30;

                gfx.DrawString("BÁO CÁO KẾT QUẢ KIỂM KÊ", titleFont, XBrushes.Black, new XRect(0, y, page.Width, 30), XStringFormats.TopCenter);
                y += 50;

                // Thông tin chung
                DataRow info = tblThongTinBCKK.Rows[0];

                // Hiển thị thông tin chung
                //gfx.DrawString($"Mã báo cáo kiểm kê: {info["MaBCKiemKe"]}", normalFont, XBrushes.Black, new XPoint(40, y));
                //y += 20;
                //gfx.DrawString($"Người lập: {info["TenNVLap"]}", normalFont, XBrushes.Black, new XPoint(40, y));
                //y += 20;
                //gfx.DrawString($"Người duyệt: {info["TenNVDuyet"]}", normalFont, XBrushes.Black, new XPoint(40, y));
                //y += 20;
                //gfx.DrawString($"Ngày lập: {Convert.ToDateTime(info["NgayLap"]).ToString("dd/MM/yyyy")}", normalFont, XBrushes.Black, new XPoint(40, y));
                //y += 20;
                //gfx.DrawString($"Ngày duyệt: {Convert.ToDateTime(info["NgayDuyet"]).ToString("dd/MM/yyyy")}", normalFont, XBrushes.Black, new XPoint(40, y));
                //y += 20;
                gfx.DrawString($"Thời gian bắt đầu: {Convert.ToDateTime(info["TGBD"]).ToString("dd/MM/yyyy")}", normalFont, XBrushes.Black, new XPoint(40, y));
                y += 20;
                gfx.DrawString($"Thời gian kết thúc: {Convert.ToDateTime(info["TGKT"]).ToString("dd/MM/yyyy")}", normalFont, XBrushes.Black, new XPoint(40, y));
                y += 30; // Tạo khoảng trống trước khi vẽ bảng

                gfx.DrawString($"Số tài liệu xếp nhầm kho: {info["SoTLXepNhamKho"]}", normalFont, XBrushes.Black, new XPoint(40, y));
                y += 20;
                gfx.DrawString($"Số tài liệu mất: {info["SoTLMat"]} (Tổng tiền: {Convert.ToDecimal(info["TongTienTLMat"]).ToString("N0")} VNĐ)", normalFont, XBrushes.Black, new XPoint(40, y));
                y += 20;
                gfx.DrawString($"Số tài liệu sửa chữa: {info["SoTLSuaChua"]}", normalFont, XBrushes.Black, new XPoint(40, y));
                y += 20;
                gfx.DrawString($"Số tài liệu bồi thường: {info["SoTLBoiThuong"]} (Tổng tiền: {Convert.ToDecimal(info["TongTienBoiThuong"]).ToString("N0")} VNĐ)", normalFont, XBrushes.Black, new XPoint(40, y));
                y += 30; // Tạo khoảng trống trước khi vẽ bảng


                // Tạo bảng và thêm viền
                double x = 40;
                double tableWidth = page.Width - 80; // Giảm bớt chiều rộng để đảm bảo viền không bị cắt
                double rowHeight = 20;

                // Header bảng
                gfx.DrawRectangle(XPens.Black, x, y, tableWidth, rowHeight); // Header viền
                gfx.DrawString("MÃ KHO", titleFont, XBrushes.Black, new XPoint(x + 5, y + 14));
                gfx.DrawString("TÊN KHO", titleFont, XBrushes.Black, new XPoint(x + 100, y + 14));
                gfx.DrawString("SỐ TÀI LIỆU", titleFont, XBrushes.Black, new XPoint(x + 300, y + 14));
                gfx.DrawString("SỐ BẢN TÀI LIỆU", titleFont, XBrushes.Black, new XPoint(x + 400, y + 14));
                y += rowHeight;

                // Vẽ các ô trong bảng
                foreach (DataRow row in tblThongTinCTBCKK.Rows)
                {
                    gfx.DrawRectangle(XPens.Black, x, y, tableWidth, rowHeight); // Vẽ viền cho mỗi ô
                    gfx.DrawString(row["MaKho"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 5, y + 14));
                    gfx.DrawString(row["TenKho"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 100, y + 14));
                    gfx.DrawString(row["SoTL"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 300, y + 14));
                    gfx.DrawString(row["SoBanTL"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 400, y + 14));
                    y += rowHeight;
                }

                // Thêm thông tin "Thư viện" và "Người lập báo cáo"
                y += 30; // Tạo khoảng trống trước footer

                // Thêm phần "Ngày lập" định dạng kiểu "Hà Nội, ngày ... tháng ... năm ..."
                DateTime ngayLap = Convert.ToDateTime(info["NgayLap"]);
                string ngayThangNam = $"Hà Nội, ngày {ngayLap.Day} tháng {ngayLap.Month} năm {ngayLap.Year}";
                gfx.DrawString(ngayThangNam, normalFont, XBrushes.Black, new XRect(125, y, page.Width, 20), XStringFormats.TopCenter);
                y += 35; // Tăng khoảng cách sau "Ngày lập"

                double footerLeftX = x + 50; // Vị trí bên trái
                double footerRightX = page.Width - x - 200; // Vị trí bên phải (cách lề phải 200 điểm)

                // "Thư viện" ở bên trái
                gfx.DrawString("THƯ VIỆN", footerFont, XBrushes.Black, new XPoint(footerLeftX + 35, y));
                gfx.DrawString("(Ký và ghi họ tên)", normalFont, XBrushes.Black, new XPoint(footerLeftX + 20, y + 20));

                // "Người lập báo cáo" ở bên phải
                gfx.DrawString("NGƯỜI LẬP BÁO CÁO", footerFont, XBrushes.Black, new XPoint(footerRightX, y));
                gfx.DrawString("(Ký và ghi họ tên)", normalFont, XBrushes.Black, new XPoint(footerRightX + 20, y + 20));

                // Tăng khoảng cách cho phần tên người lập và người duyệt
                y += 60;

                // Hiển thị tên "Người lập" và "Người duyệt" bên dưới
                //gfx.DrawString(info["TenNVLap"].ToString(), normalFont, XBrushes.Black, new XPoint(footerRightX, y)); // Người lập bên phải
                //gfx.DrawString(info["TenNVDuyet"].ToString(), normalFont, XBrushes.Black, new XPoint(footerLeftX, y)); // Người duyệt bên trái

                // Lưu file
                document.Save(outputPath);

                // Mở file PDF sau khi lưu
                Process.Start(new ProcessStartInfo(outputPath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xuất PDF với PdfSharp: " + ex.Message);
            }
        }

        public static void exportBCTL(DataTable tblThongTinBCTL, DataTable tblThongTinCTDMTL, string outputPath)
        {
            try
            {
                if (tblThongTinBCTL.Rows.Count == 0 || tblThongTinCTDMTL.Rows.Count == 0)
                    throw new Exception("Dữ liệu không hợp lệ.");

                PdfDocument document = new PdfDocument();
                document.Info.Title = "BÁO CÁO XỬ LÝ, THANH LỌC TÀI LIỆU";

                PdfPage page = document.AddPage();
                page.Orientation = PageOrientation.Landscape;

                XGraphics gfx = XGraphics.FromPdfPage(page);

                XFont titleFont = new XFont("Times New Roman", 12.5, XFontStyle.Bold);
                XFont normalFont = new XFont("Times New Roman", 12.5, XFontStyle.Regular);
                XFont footerFont = new XFont("Times New Roman", 12.5, XFontStyle.Bold);

                double y = 60;

                gfx.DrawString("HỌC VIỆN NGÂN HÀNG", titleFont, XBrushes.Black, new XRect(0, y, page.Width, 30), XStringFormats.TopCenter);
                y += 30;

                gfx.DrawString("BÁO CÁO XỬ LÝ, THANH LỌC TÀI LIỆU", titleFont, XBrushes.Black, new XRect(0, y, page.Width, 30), XStringFormats.TopCenter);
                y += 50;

                // Thông tin chung
                DataRow info = tblThongTinBCTL.Rows[0];

                gfx.DrawString($"Số tài liệu chuyển đổi mục đích: {info["SoTLChuyenDoiMD"]}", normalFont, XBrushes.Black, new XPoint(40, y));
                y += 20;
                gfx.DrawString($"Số tài liệu thanh lọc: {info["SoTLThanhLoc"]} (Tổng tiền: {Convert.ToDecimal(info["TongTien"]).ToString("N0")} VNĐ)", normalFont, XBrushes.Black, new XPoint(40, y));
                y += 30; // Tạo khoảng trống trước khi vẽ bảng

                // Tạo bảng và thêm viền
                double x = 40;
                double tableWidth = page.Width - 80; // Giảm bớt chiều rộng để đảm bảo viền không bị cắt
                double rowHeight = 20;

                // Header bảng
                gfx.DrawRectangle(XPens.Black, x, y, tableWidth, rowHeight); // Header viền
                gfx.DrawString("MÃ TÀI LIỆU", titleFont, XBrushes.Black, new XPoint(x + 5, y + 14));
                gfx.DrawString("TÊN TÀI LIỆU", titleFont, XBrushes.Black, new XPoint(x + 100, y + 14));
                gfx.DrawString("SL", titleFont, XBrushes.Black, new XPoint(x + 240, y + 14));
                gfx.DrawString("ĐƠN GIÁ", titleFont, XBrushes.Black, new XPoint(x + 280, y + 14));
                gfx.DrawString("LÝ DO THANH LỌC", titleFont, XBrushes.Black, new XPoint(x + 360, y + 14));
                gfx.DrawString("PHƯƠNG ÁN XỬ LÝ", titleFont, XBrushes.Black, new XPoint(x + 540, y + 14));
                y += rowHeight;

                // Vẽ các ô trong bảng
                foreach (DataRow row in tblThongTinCTDMTL.Rows)
                {
                    gfx.DrawRectangle(XPens.Black, x, y, tableWidth, rowHeight); // Vẽ viền cho mỗi ô
                    gfx.DrawString(row["MaTL"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 5, y + 14));
                    gfx.DrawString(row["TenTL"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 100, y + 14));
                    gfx.DrawString(row["SoLuong"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 240, y + 14));
                    gfx.DrawString(Convert.ToDecimal(row["DonGia"]).ToString("N0"), normalFont, XBrushes.Black, new XPoint(x + 280, y + 14));
                    gfx.DrawString(row["LyDoThanhLoc"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 360, y + 14));
                    gfx.DrawString(row["PhuongAnXuLy"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 540, y + 14));
                    y += rowHeight;
                }

                // Thêm thông tin "Thư viện" và "Người lập báo cáo"
                y += 30; // Tạo khoảng trống trước footer

                // Thêm phần "Ngày lập" định dạng kiểu "Hà Nội, ngày ... tháng ... năm ..."
                DateTime ngayLap = Convert.ToDateTime(info["NgayLap"]);
                string ngayThangNam = $"Hà Nội, ngày {ngayLap.Day} tháng {ngayLap.Month} năm {ngayLap.Year}";
                gfx.DrawString(ngayThangNam, normalFont, XBrushes.Black, new XRect(125, y, page.Width, 20), XStringFormats.TopCenter);
                y += 35; // Tăng khoảng cách sau "Ngày lập"

                double footerLeftX = x + 50; // Vị trí bên trái
                double footerRightX = page.Width - x - 200; // Vị trí bên phải (cách lề phải 200 điểm)

                // "Thư viện" ở bên trái
                gfx.DrawString("THƯ VIỆN", footerFont, XBrushes.Black, new XPoint(footerLeftX + 35, y));
                gfx.DrawString("(Ký và ghi họ tên)", normalFont, XBrushes.Black, new XPoint(footerLeftX + 20, y + 20));

                // "Người lập báo cáo" ở bên phải
                gfx.DrawString("NGƯỜI LẬP BÁO CÁO", footerFont, XBrushes.Black, new XPoint(footerRightX, y));
                gfx.DrawString("(Ký và ghi họ tên)", normalFont, XBrushes.Black, new XPoint(footerRightX + 20, y + 20));

                // Tăng khoảng cách cho phần tên người lập và người duyệt
                y += 60;

                // Hiển thị tên "Người lập" và "Người duyệt" bên dưới
                //gfx.DrawString(info["TenNVLap"].ToString(), normalFont, XBrushes.Black, new XPoint(footerRightX, y)); // Người lập bên phải
                //gfx.DrawString(info["TenNVDuyet"].ToString(), normalFont, XBrushes.Black, new XPoint(footerLeftX, y)); // Người duyệt bên trái

                // Lưu file
                document.Save(outputPath);

                // Mở file PDF sau khi lưu
                Process.Start(new ProcessStartInfo(outputPath) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xuất PDF với PdfSharp: " + ex.Message);
            }
        }

        public static void exportPYCBS(DataTable tblThongTinPYCBS, DataTable tblThongTinCTPYCBS, string outputPath, bool forEmail = false)
        {
            try
            {
                if (tblThongTinPYCBS.Rows.Count == 0 || tblThongTinCTPYCBS.Rows.Count == 0)
                    throw new Exception("Dữ liệu không hợp lệ.");

                PdfDocument document = new PdfDocument();
                document.Info.Title = "PHIẾU YÊU CẦU BỔ SUNG TÀI LIỆU";

                PdfPage page = document.AddPage();
                page.Orientation = PageOrientation.Landscape;

                XGraphics gfx = XGraphics.FromPdfPage(page);

                XFont titleFont = new XFont("Times New Roman", 12.5, XFontStyle.Bold);
                XFont normalFont = new XFont("Times New Roman", 12.5, XFontStyle.Regular);
                XFont footerFont = new XFont("Times New Roman", 12.5, XFontStyle.Bold);

                double y = 60;

                gfx.DrawString("HỌC VIỆN NGÂN HÀNG", titleFont, XBrushes.Black, new XRect(0, y, page.Width, 30), XStringFormats.TopCenter);
                y += 30;

                gfx.DrawString("PHIẾU YÊU CẦU BỔ SUNG TÀI LIỆU", titleFont, XBrushes.Black, new XRect(0, y, page.Width, 30), XStringFormats.TopCenter);
                y += 30;

                // Thông tin chung
                DataRow info = tblThongTinPYCBS.Rows[0];

                // Tạo bảng và thêm viền
                double x = 40;
                double tableWidth = page.Width - 80; // Giảm bớt chiều rộng để đảm bảo viền không bị cắt
                double rowHeight = 20;

                // Header bảng
                gfx.DrawRectangle(XPens.Black, x, y, tableWidth, rowHeight); // Header viền
                gfx.DrawString("MÃ PHIẾU", titleFont, XBrushes.Black, new XPoint(x + 5, y + 14));
                gfx.DrawString("TÊN TÀI LIỆU", titleFont, XBrushes.Black, new XPoint(x + 100, y + 14));
                gfx.DrawString("TÁC GIẢ", titleFont, XBrushes.Black, new XPoint(x + 200, y + 14));
                gfx.DrawString("NXB", titleFont, XBrushes.Black, new XPoint(x + 300, y + 14));
                gfx.DrawString("NĂM XB", titleFont, XBrushes.Black, new XPoint(x + 380, y + 14));
                gfx.DrawString("MÔ TẢ", titleFont, XBrushes.Black, new XPoint(x + 450, y + 14));
                gfx.DrawString("LOẠI T/L", titleFont, XBrushes.Black, new XPoint(x + 550, y + 14));
                gfx.DrawString("SL", titleFont, XBrushes.Black, new XPoint(x + 625, y + 14));
                gfx.DrawString("MỨC ĐỘ Y/C", titleFont, XBrushes.Black, new XPoint(x + 675, y + 14));
                y += rowHeight;

                // Vẽ các ô trong bảng
                foreach (DataRow row in tblThongTinCTPYCBS.Rows)
                {
                    gfx.DrawRectangle(XPens.Black, x, y, tableWidth, rowHeight); // Vẽ viền cho mỗi ô
                    gfx.DrawString(row["MaPhieuYCBS"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 5, y + 14));
                    gfx.DrawString(row["TenTL"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 100, y + 14));
                    gfx.DrawString(row["TacGia"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 200, y + 14));
                    gfx.DrawString(row["NhaXuatBan"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 300, y + 14));
                    gfx.DrawString(row["NamXuatBan"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 380, y + 14));
                    gfx.DrawString(row["MoTa"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 450, y + 14));
                    gfx.DrawString(row["LoaiAnPham"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 550, y + 14));
                    gfx.DrawString(row["SoLuong"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 625, y + 14));
                    gfx.DrawString(row["MucDoYC"].ToString(), normalFont, XBrushes.Black, new XPoint(x + 675, y + 14));
                    y += rowHeight;
                }

                // Thêm thông tin "Thư viện" và "Người lập báo cáo"
                y += 30; // Tạo khoảng trống trước footer

                if (!forEmail)
                {
                    // Thêm phần "Ngày lập" định dạng kiểu "Hà Nội, ngày ... tháng ... năm ..."
                    DateTime ngayLap = Convert.ToDateTime(info["NgayLap"]);
                    string ngayThangNam = $"Hà Nội, ngày {ngayLap.Day} tháng {ngayLap.Month} năm {ngayLap.Year}";
                    gfx.DrawString(ngayThangNam, normalFont, XBrushes.Black, new XRect(250, y, page.Width, 20), XStringFormats.TopCenter);
                    y += 35; // Tăng khoảng cách sau "Ngày lập"

                    double footerLeftX = x + 50; // Vị trí bên trái
                    double footerRightX = page.Width - x - 200; // Vị trí bên phải (cách lề phải 200 điểm)

                    // "Thư viện" ở bên trái
                    gfx.DrawString("THƯ VIỆN", footerFont, XBrushes.Black, new XPoint(footerLeftX + 35, y));
                    gfx.DrawString("(Ký và ghi họ tên)", normalFont, XBrushes.Black, new XPoint(footerLeftX + 20, y + 20));

                    // "Người lập báo cáo" ở bên phải
                    gfx.DrawString("NGƯỜI LẬP BÁO CÁO", footerFont, XBrushes.Black, new XPoint(footerRightX, y));
                    gfx.DrawString("(Ký và ghi họ tên)", normalFont, XBrushes.Black, new XPoint(footerRightX + 20, y + 20));

                    // Tăng khoảng cách cho phần tên người lập và người duyệt
                    y += 60;

                    // Hiển thị tên "Người lập" và "Người duyệt" bên dưới
                    //gfx.DrawString(info["TenNVLap"].ToString(), normalFont, XBrushes.Black, new XPoint(footerRightX, y)); // Người lập bên phải
                    //gfx.DrawString(info["TenNVDuyet"].ToString(), normalFont, XBrushes.Black, new XPoint(footerLeftX, y)); // Người duyệt bên trái
                }

                // Lưu file
                document.Save(outputPath);

                if (!forEmail)
                {
                    // Mở file PDF sau khi lưu
                    Process.Start(new ProcessStartInfo(outputPath) { UseShellExecute = true });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi xuất PDF với PdfSharp: " + ex.Message);
            }
        }
    }
}
