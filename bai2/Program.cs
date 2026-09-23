using System;

// =====================================================
// LỚP TRỪU TƯỢNG
// =====================================================
abstract class PhimCoBan
{
    public abstract void Nhap();
    public abstract void Xuat();
}


// =====================================================
// LỚP PHIM
// KẾ THỪA từ PhimCoBan
// =====================================================
class Phim : PhimCoBan
{
    // =================================================
    // ĐÓNG GÓI
    // Các thuộc tính được khai báo private
    // =================================================
    private string tenPhim;
    private double doanhThu;
    private int theLoai;
    private int namSanXuat;
    private bool phimVietNam;


    // =================================================
    // PROPERTY
    // =================================================
    public string TenPhim
    {
        get { return tenPhim; }
        set { tenPhim = value; }
    }

    public double DoanhThu
    {
        get { return doanhThu; }
        set { doanhThu = value; }
    }

    public int TheLoai
    {
        get { return theLoai; }
        set { theLoai = value; }
    }

    public int NamSanXuat
    {
        get { return namSanXuat; }
        set { namSanXuat = value; }
    }

    public bool PhimVietNam
    {
        get { return phimVietNam; }
        set { phimVietNam = value; }
    }


    // =================================================
    // HÀM KHỞI TẠO
    // =================================================
    public Phim()
    {
        tenPhim = "";
        doanhThu = 0;
        theLoai = 0;
        namSanXuat = 0;
        phimVietNam = false;
    }


    // =================================================
    // CÂU a
    // NHẬP 1 BỘ PHIM
    // =================================================
    public override void Nhap()
    {
        // Nhập tên phim
        do
        {
            Console.Write("Nhap ten phim: ");
            tenPhim = Console.ReadLine();

            if (tenPhim.Length > 50)
            {
                Console.WriteLine(
                    "Ten phim khong duoc qua 50 ky tu!");
            }

        } while (tenPhim.Length > 50);


        // Nhập doanh thu
        do
        {
            Console.Write("Nhap doanh thu: ");
            doanhThu = double.Parse(Console.ReadLine());

            if (doanhThu < 0)
            {
                Console.WriteLine(
                    "Doanh thu phai >= 0!");
            }

        } while (doanhThu < 0);


        // Nhập thể loại
        do
        {
            Console.WriteLine("0 - Hinh su");
            Console.WriteLine("1 - Tinh cam");
            Console.WriteLine("2 - Hai");

            Console.Write("Nhap the loai: ");
            theLoai = int.Parse(Console.ReadLine());

            if (theLoai < 0 || theLoai > 2)
            {
                Console.WriteLine(
                    "The loai chi duoc nhap 0, 1 hoac 2!");
            }

        } while (theLoai < 0 || theLoai > 2);


        // Nhập năm sản xuất
        Console.Write("Nhap nam san xuat: ");
        namSanXuat = int.Parse(Console.ReadLine());


        // Nhập phim Việt Nam
        Console.Write(
            "Phim Viet Nam? (true = Viet Nam, false = nuoc ngoai): ");

        phimVietNam = bool.Parse(Console.ReadLine());
    }


    // =================================================
    // CÂU c
    // XUẤT 1 BỘ PHIM
    // =================================================
    public override void Xuat()
    {
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine("Ten phim : " + tenPhim);
        Console.WriteLine("Doanh thu : " + doanhThu);
        Console.WriteLine("The loai : " + LayTenTheLoai());
        Console.WriteLine("Nam san xuat : " + namSanXuat);

        if (phimVietNam)
        {
            Console.WriteLine("San xuat : Viet Nam");
        }
        else
        {
            Console.WriteLine("San xuat : Nuoc ngoai");
        }
    }


    // =================================================
    // HÀM ĐỔI MÃ THỂ LOẠI THÀNH TÊN
    // =================================================
    public string LayTenTheLoai()
    {
        switch (theLoai)
        {
            case 0:
                return "Hinh su";

            case 1:
                return "Tinh cam";

            case 2:
                return "Hai";

            default:
                return "Khong xac dinh";
        }
    }
}


// =====================================================
// CLASS PROGRAM
// =====================================================
class Program
{
    // =================================================
    // CÂU a
    // HÀM NHẬP 1 BỘ PHIM
    // =================================================
    static void Nhap1Phim(Phim phim)
    {
        phim.Nhap();
    }


    // =================================================
    // CÂU b
    // NHẬP DANH SÁCH n PHIM
    // n được nhập trực tiếp trong hàm
    // =================================================
    static void NhapDanhSach(Phim[] ds, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine();
            Console.WriteLine(
                "========== NHAP PHIM THU " + (i + 1) +
                " ==========");

            ds[i] = new Phim();

            Nhap1Phim(ds[i]);
        }
    }


    // =================================================
    // CÂU c
    // HÀM XUẤT 1 BỘ PHIM
    // =================================================
    static void Xuat1Phim(Phim phim)
    {
        phim.Xuat();
    }


    // =================================================
    // CÂU d
    // XUẤT DANH SÁCH PHIM
    // =================================================
    static void XuatDanhSach(Phim[] ds, int n)
    {
        Console.WriteLine();
        Console.WriteLine(
            "========== DANH SACH PHIM ==========");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(
                "\nPhim thu " + (i + 1) + ":");

            Xuat1Phim(ds[i]);
        }
    }


    // =================================================
    // CÂU e
    // NHẬP MỘT THỂ LOẠI
    // IN RA PHIM THUỘC THỂ LOẠI ĐÓ
    // =================================================
    static void TimTheoTheLoai(Phim[] ds, int n)
    {
        int loai;

        do
        {
            Console.WriteLine();
            Console.WriteLine("0 - Hinh su");
            Console.WriteLine("1 - Tinh cam");
            Console.WriteLine("2 - Hai");

            Console.Write("Nhap the loai can tim: ");
            loai = int.Parse(Console.ReadLine());

            if (loai < 0 || loai > 2)
            {
                Console.WriteLine(
                    "Chi duoc nhap 0, 1 hoac 2!");
            }

        } while (loai < 0 || loai > 2);


        Console.WriteLine();
        Console.WriteLine(
            "========== PHIM THUOC THE LOAI " +
            TenTheLoai(loai) + " ==========");

        bool timThay = false;

        for (int i = 0; i < n; i++)
        {
            if (ds[i].TheLoai == loai)
            {
                Xuat1Phim(ds[i]);
                timThay = true;
            }
        }

        if (!timThay)
        {
            Console.WriteLine(
                "Khong co phim nao thuoc the loai nay.");
        }
    }


    // =================================================
    // CÂU f
    // TỔNG DOANH THU PHIM VIỆT NAM
    // =================================================
    static double TongDoanhThuPhimVietNam(
        Phim[] ds, int n)
    {
        double tong = 0;

        for (int i = 0; i < n; i++)
        {
            if (ds[i].PhimVietNam == true)
            {
                tong += ds[i].DoanhThu;
            }
        }

        return tong;
    }


    // =================================================
    // CÂU g
    // DOANH THU TRUNG BÌNH
    // TỪ FromYear ĐẾN ToYear
    // =================================================
    static double DoanhThuTrungBinh(
        Phim[] ds,
        int n,
        int FromYear,
        int ToYear)
    {
        double tong = 0;
        int dem = 0;

        for (int i = 0; i < n; i++)
        {
            if (ds[i].NamSanXuat >= FromYear &&
                ds[i].NamSanXuat <= ToYear)
            {
                tong += ds[i].DoanhThu;
                dem++;
            }
        }

        // Không có phim nào trong khoảng năm
        if (dem == 0)
        {
            return 0;
        }

        return tong / dem;
    }


    // =================================================
    // CÂU h
    // ĐẾM SỐ PHIM:
    // DOANH THU < LowerBound
    // HOẶC
    // DOANH THU > UpperBound
    // =================================================
    static int DemPhimNgoaiKhoang(
        Phim[] ds,
        int n,
        int LowerBound,
        int UpperBound)
    {
        int dem = 0;

        for (int i = 0; i < n; i++)
        {
            if (ds[i].DoanhThu < LowerBound ||
                ds[i].DoanhThu > UpperBound)
            {
                dem++;
            }
        }

        return dem;
    }


    // =================================================
    // HÀM HỖ TRỢ ĐỔI THỂ LOẠI
    // =================================================
    static string TenTheLoai(int loai)
    {
        switch (loai)
        {
            case 0:
                return "Hinh su";

            case 1:
                return "Tinh cam";

            case 2:
                return "Hai";

            default:
                return "Khong xac dinh";
        }
    }


    // =================================================
    // MAIN
    // =================================================
    static void Main(string[] args)
    {
        Console.OutputEncoding =
            System.Text.Encoding.UTF8;


        // =============================================
        // NHẬP SỐ LƯỢNG PHIM
        // =============================================
        Console.Write("Nhap so luong phim n = ");
        int n = int.Parse(Console.ReadLine());

        Phim[] ds = new Phim[n];


        // =============================================
        // CÂU a + b
        // =============================================
        Console.WriteLine();
        Console.WriteLine(
            "========== CAU a + b ==========");

        NhapDanhSach(ds, n);


        // =============================================
        // CÂU c + d
        // =============================================
        Console.WriteLine();
        Console.WriteLine(
            "========== CAU c + d ==========");

        XuatDanhSach(ds, n);


        // =============================================
        // CÂU e
        // =============================================
        Console.WriteLine();
        Console.WriteLine(
            "========== CAU e ==========");

        TimTheoTheLoai(ds, n);


        // =============================================
        // CÂU f
        // =============================================
        Console.WriteLine();
        Console.WriteLine(
            "========== CAU f ==========");

        double tongVN =
            TongDoanhThuPhimVietNam(ds, n);

        Console.WriteLine(
            "Tong doanh thu phim Viet Nam = "
            + tongVN);


        // =============================================
        // CÂU g
        // =============================================
        Console.WriteLine();
        Console.WriteLine(
            "========== CAU g ==========");

        Console.Write("Nhap FromYear: ");
        int FromYear = int.Parse(Console.ReadLine());

        Console.Write("Nhap ToYear: ");
        int ToYear = int.Parse(Console.ReadLine());

        double trungBinh =
            DoanhThuTrungBinh(
                ds,
                n,
                FromYear,
                ToYear);

        Console.WriteLine(
            "Doanh thu trung binh tu "
            + FromYear + " den " + ToYear
            + " = " + trungBinh);


        // =============================================
        // CÂU h
        // =============================================
        Console.WriteLine();
        Console.WriteLine(
            "========== CAU h ==========");

        Console.Write("Nhap LowerBound: ");
        int LowerBound =
            int.Parse(Console.ReadLine());

        Console.Write("Nhap UpperBound: ");
        int UpperBound =
            int.Parse(Console.ReadLine());

        int soLuong =
            DemPhimNgoaiKhoang(
                ds,
                n,
                LowerBound,
                UpperBound);

        Console.WriteLine(
            "So phim co doanh thu < LowerBound "
            + "hoac > UpperBound = "
            + soLuong);


        // =============================================
        // KẾT THÚC
        // =============================================
        Console.WriteLine();
        Console.WriteLine(
            "Nhan phim bat ky de ket thuc...");
        Console.ReadKey();
    }
}
