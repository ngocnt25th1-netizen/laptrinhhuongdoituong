using System;

// ==========================================
// LỚP TRỪU TƯỢNG
// ==========================================
abstract class PhanSoCoBan
{
    public abstract void Nhap();
    public abstract void Xuat();
}

// ==========================================
// LỚP PHÂN SỐ
// KẾ THỪA từ PhanSoCoBan
// ==========================================
class PhanSo : PhanSoCoBan
{
    // ======================================
    // ĐÓNG GÓI
    // ======================================
    private int tu;
    private int mau;

    public int Tu
    {
        get { return tu; }
        set { tu = value; }
    }

    public int Mau
    {
        get { return mau; }
        set
        {
            if (value != 0)
                mau = value;
            else
                mau = 1;
        }
    }

    // ======================================
    // HÀM KHỞI TẠO
    // ======================================
    public PhanSo()
    {
        tu = 0;
        mau = 1;
    }

    public PhanSo(int tu, int mau)
    {
        this.tu = tu;
        this.mau = mau;
    }

    // ======================================
    // ĐA HÌNH - override hàm Nhap()
    // ======================================
    public override void Nhap()
    {
        Console.Write("Nhap tu so: ");
        tu = int.Parse(Console.ReadLine());

        do
        {
            Console.Write("Nhap mau so: ");
            mau = int.Parse(Console.ReadLine());

            if (mau == 0)
                Console.WriteLine("Mau so phai khac 0!");

        } while (mau == 0);
    }

    // ======================================
    // ĐA HÌNH - override hàm Xuat()
    // ======================================
    public override void Xuat()
    {
        RutGon();

        if (mau == 1)
            Console.Write(tu);
        else
            Console.Write(tu + "/" + mau);
    }

    // ======================================
    // RÚT GỌN PHÂN SỐ
    // ======================================
    private int UCLN(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);

        while (b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }

        return a;
    }

    private void RutGon()
    {
        int ucln = UCLN(tu, mau);

        tu = tu / ucln;
        mau = mau / ucln;

        if (mau < 0)
        {
            tu = -tu;
            mau = -mau;
        }
    }

    // ======================================
    // ĐỔI PHÂN SỐ SANG SỐ THỰC
    // ======================================
    public double GiaTri()
    {
        return (double)tu / mau;
    }

    // ======================================
    // CÁC PHÉP TÍNH
    // ======================================

    // Tổng
    public PhanSo Cong(PhanSo ps)
    {
        return new PhanSo(
            tu * ps.mau + ps.tu * mau,
            mau * ps.mau
        );
    }

    // Hiệu
    public PhanSo Tru(PhanSo ps)
    {
        return new PhanSo(
            tu * ps.mau - ps.tu * mau,
            mau * ps.mau
        );
    }

    // Tích
    public PhanSo Nhan(PhanSo ps)
    {
        return new PhanSo(
            tu * ps.tu,
            mau * ps.mau
        );
    }

    // Thương
    public PhanSo Chia(PhanSo ps)
    {
        return new PhanSo(
            tu * ps.mau,
            mau * ps.tu
        );
    }
}

// ==========================================
// CLASS PROGRAM
// ==========================================
class Program
{
    // ======================================
    // CÂU a: NHẬP MẢNG PHÂN SỐ
    // ======================================
    static void NhapMangPS(PhanSo[] A, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nNhap phan so thu " + (i + 1));

            A[i] = new PhanSo();

            // Gọi hàm nhập 1 phân số
            A[i].Nhap();
        }
    }

    // ======================================
    // CÂU b: XUẤT MẢNG PHÂN SỐ
    // ======================================
    static void XuatMangPS(PhanSo[] A, int n)
    {
        for (int i = 0; i < n; i++)
        {
            A[i].Xuat();

            if (i < n - 1)
                Console.Write(" ; ");
        }

        Console.WriteLine();
    }

    // ======================================
    // CÂU c: TÌM PHÂN SỐ LỚN NHẤT
    // ======================================
    static PhanSo TimPSMax(PhanSo[] A, int n)
    {
        PhanSo max = A[0];

        for (int i = 1; i < n; i++)
        {
            if (A[i].GiaTri() > max.GiaTri())
            {
                max = A[i];
            }
        }

        return max;
    }

    // ======================================
    // TÌM PHÂN SỐ NHỎ NHẤT
    // ======================================
    static PhanSo TimPSMin(PhanSo[] A, int n)
    {
        PhanSo min = A[0];

        for (int i = 1; i < n; i++)
        {
            if (A[i].GiaTri() < min.GiaTri())
            {
                min = A[i];
            }
        }

        return min;
    }

    // ======================================
    // CÂU d: SẮP XẾP TĂNG DẦN
    // ======================================
    static void SortMangPS(PhanSo[] A, int n)
    {
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (A[i].GiaTri() > A[j].GiaTri())
                {
                    PhanSo temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                }
            }
        }
    }

    // ======================================
    // MAIN
    // ======================================
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Nhập số lượng phân số
        Console.Write("Nhap so luong phan so n = ");
        int n = int.Parse(Console.ReadLine());

        // Tạo mảng
        PhanSo[] A = new PhanSo[n];

        // ==================================
        // CÂU a
        // ==================================
        Console.WriteLine("\n===== CAU a: NHAP MANG PHAN SO =====");
        NhapMangPS(A, n);

        // ==================================
        // CÂU b
        // ==================================
        Console.WriteLine("\n===== CAU b: XUAT MANG PHAN SO =====");
        XuatMangPS(A, n);

        // ==================================
        // CÂU c
        // ==================================
        Console.WriteLine("\n===== CAU c: TIM MAX VA MIN =====");

        PhanSo max = TimPSMax(A, n);
        PhanSo min = TimPSMin(A, n);

        Console.Write("Phan so lon nhat: ");
        max.Xuat();

        Console.WriteLine();

        Console.Write("Phan so nho nhat: ");
        min.Xuat();

        Console.WriteLine();

        // ==================================
        // CÂU d
        // ==================================
        Console.WriteLine("\n===== CAU d: SAP XEP TANG DAN =====");

        SortMangPS(A, n);

        Console.Write("Mang sau khi sap xep: ");
        XuatMangPS(A, n);

        // ==================================
        // CÂU e
        // ==================================
        Console.WriteLine("\n===== CAU e: TINH TOAN =====");

        // Lấy lại MAX và MIN
        max = TimPSMax(A, n);
        min = TimPSMin(A, n);

        Console.Write("Phan so lon nhat: ");
        max.Xuat();

        Console.WriteLine();

        Console.Write("Phan so nho nhat: ");
        min.Xuat();

        Console.WriteLine();

        // Tổng
        PhanSo tong = max.Cong(min);
        Console.Write("Tong = ");
        tong.Xuat();

        Console.WriteLine();

        // Hiệu
        PhanSo hieu = max.Tru(min);
        Console.Write("Hieu = ");
        hieu.Xuat();

        Console.WriteLine();

        // Tích
        PhanSo tich = max.Nhan(min);
        Console.Write("Tich = ");
        tich.Xuat();

        Console.WriteLine();

        // Thương
        if (min.Tu != 0)
        {
            PhanSo thuong = max.Chia(min);

            Console.Write("Thuong = ");
            thuong.Xuat();
        }
        else
        {
            Console.WriteLine("Khong the chia cho 0!");
        }

        Console.WriteLine();

        Console.WriteLine("\nNhan phim bat ky de ket thuc...");
        Console.ReadKey();
    }
}

