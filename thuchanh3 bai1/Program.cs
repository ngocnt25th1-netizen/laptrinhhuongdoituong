using System;

// ======================================================
// LỚP CHA
// ======================================================
abstract class BaiTap
{
    // 1. ĐÓNG GÓI (Encapsulation)
    public string TenBai { get; set; }

    public BaiTap(string tenBai)
    {
        TenBai = tenBai;
    }

    // 2. TRỪU TƯỢNG (Abstraction)
    public abstract void ThucHien();
}


// ======================================================
// BÀI 1: TÍNH ĐIỂM CHỮ
// ======================================================
class Bai1 : BaiTap
{
    public Bai1() : base("Tinh diem chu")
    {
    }

    public override void ThucHien()
    {
        Console.Write("Nhap diem tieu luan: ");
        double tl = double.Parse(Console.ReadLine());

        Console.Write("Nhap diem giua ky: ");
        double gk = double.Parse(Console.ReadLine());

        Console.Write("Nhap diem cuoi ky: ");
        double ck = double.Parse(Console.ReadLine());

        double diem = tl * 0.2 + gk * 0.3 + ck * 0.5;

        char diemChu;

        if (diem >= 8.5)
            diemChu = 'A';
        else if (diem >= 7.0)
            diemChu = 'B';
        else if (diem >= 5.5)
            diemChu = 'C';
        else if (diem >= 4.0)
            diemChu = 'D';
        else
            diemChu = 'F';

        Console.WriteLine($"Diem he 10: {diem:F2}");
        Console.WriteLine($"Diem chu: {diemChu}");
    }
}


// ======================================================
// BÀI 2: TÍNH TIỀN
// ======================================================
class Bai2 : BaiTap
{
    public Bai2() : base("Tinh tien phai tra")
    {
    }

    public override void ThucHien()
    {
        Console.Write("Nhap don gia: ");
        double donGia = double.Parse(Console.ReadLine());

        Console.Write("Nhap so luong: ");
        int soLuong = int.Parse(Console.ReadLine());

        double thanhTien = donGia * soLuong;

        double giamGia = 0;

        if (thanhTien > 100)
            giamGia = thanhTien * 0.03;

        double tongTien = thanhTien - giamGia;

        Console.WriteLine($"Thanh tien: {thanhTien:F2}");
        Console.WriteLine($"Giam gia: {giamGia:F2}");
        Console.WriteLine($"Tong tien phai tra: {tongTien:F2}");
    }
}


// ======================================================
// BÀI 3: KIỂM TRA THÁNG
// ======================================================
class Bai3 : BaiTap
{
    public Bai3() : base("Kiem tra thang")
    {
    }

    public override void ThucHien()
    {
        Console.Write("Nhap thang: ");
        int thang = int.Parse(Console.ReadLine());

        switch (thang)
        {
            case 1:
                Console.WriteLine("January - 31 days");
                break;
            case 2:
                Console.WriteLine("February - 28 days");
                break;
            case 3:
                Console.WriteLine("March - 31 days");
                break;
            case 4:
                Console.WriteLine("April - 30 days");
                break;
            case 5:
                Console.WriteLine("May - 31 days");
                break;
            case 6:
                Console.WriteLine("June - 30 days");
                break;
            case 7:
                Console.WriteLine("July - 31 days");
                break;
            case 8:
                Console.WriteLine("August - 31 days");
                break;
            case 9:
                Console.WriteLine("September - 30 days");
                break;
            case 10:
                Console.WriteLine("October - 31 days");
                break;
            case 11:
                Console.WriteLine("November - 30 days");
                break;
            case 12:
                Console.WriteLine("December - 31 days");
                break;
            default:
                Console.WriteLine("Month is invalid");
                break;
        }
    }
}


// ======================================================
// BÀI 4: TỔNG 1*2 + 2*3 + ... + n(n+1)
// ======================================================
class Bai4 : BaiTap
{
    public Bai4() : base("Tinh tong i*(i+1)")
    {
    }

    public override void ThucHien()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        long tong = 0;

        for (int i = 1; i <= n; i++)
        {
            tong += i * (i + 1);
        }

        Console.WriteLine($"Tong = {tong}");
    }
}


// ======================================================
// BÀI 5: TỔNG PHÂN SỐ
// 1/(1*2*3) + ... + 1/(n*(n+1)*(n+2))
// ======================================================
class Bai5 : BaiTap
{
    public Bai5() : base("Tinh tong phan so")
    {
    }

    public override void ThucHien()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        double tong = 0;

        for (int i = 1; i <= n; i++)
        {
            tong += 1.0 / (i * (i + 1) * (i + 2));
        }

        Console.WriteLine($"Tong = {tong:F4}");
    }
}


// ======================================================
// BÀI 6: HEX -> DECIMAL
// ======================================================
class Bai6 : BaiTap
{
    public Bai6() : base("Doi Hex sang Decimal")
    {
    }

    public override void ThucHien()
    {
        Console.Write("Nhap ky tu Hex: ");
        char c = char.Parse(Console.ReadLine());

        int ketQua;

        if (c >= '0' && c <= '9')
            ketQua = c - '0';
        else if (c >= 'A' && c <= 'F')
            ketQua = c - 'A' + 10;
        else if (c >= 'a' && c <= 'f')
            ketQua = c - 'a' + 10;
        else
        {
            Console.WriteLine(
                "He thap luc phan khong dung ky so nay"
            );
            return;
        }

        Console.WriteLine($"Gia tri thap phan: {ketQua}");
    }
}


// ======================================================
// BÀI 7: TÌM UCLN
// ======================================================
class Bai7 : BaiTap
{
    public Bai7() : base("Tim UCLN")
    {
    }

    public override void ThucHien()
    {
        Console.Write("Nhap a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Nhap b: ");
        int b = int.Parse(Console.ReadLine());

        while (b != 0)
        {
            int temp = a % b;
            a = b;
            b = temp;
        }

        Console.WriteLine($"UCLN = {a}");
    }
}


// ======================================================
// BÀI 8: TỔNG CÁC CHỮ SỐ
// ======================================================
class Bai8 : BaiTap
{
    public Bai8() : base("Tinh tong cac chu so")
    {
    }

    public override void ThucHien()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        int tong = 0;

        while (n > 0)
        {
            tong += n % 10;
            n /= 10;
        }

        Console.WriteLine($"Tong cac chu so = {tong}");
    }
}


// ======================================================
// BÀI 9: ĐẾM CHỮ SỐ CHẴN / LẺ
// ======================================================
class Bai9 : BaiTap
{
    public Bai9() : base("Dem chu so chan le")
    {
    }

    public override void ThucHien()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        int chan = 0;
        int le = 0;

        while (n > 0)
        {
            int chuSo = n % 10;

            if (chuSo % 2 == 0)
                chan++;
            else
                le++;

            n /= 10;
        }

        Console.WriteLine($"So chu so chan: {chan}");
        Console.WriteLine($"So chu so le: {le}");
    }
}


// ======================================================
// BÀI 10: GỬI NGÂN HÀNG
// ======================================================
class Bai10 : BaiTap
{
    public Bai10() : base("Tinh so thang gui ngan hang")
    {
    }

    public override void ThucHien()
    {
        Console.Write("Nhap so tien n (<1000): ");
        double n = double.Parse(Console.ReadLine());

        int soThang = 0;

        while (n < 1000)
        {
            n = n + n * 0.007;
            soThang++;
        }

        Console.WriteLine($"So thang toi thieu: {soThang}");
        Console.WriteLine($"So tien: {n:F2} USD");
    }
}


// ======================================================
// BÀI 11: TOÀN CHẴN / TOÀN LẺ
// ======================================================
class Bai11 : BaiTap
{
    public Bai11() : base("Kiem tra toan chan hoac toan le")
    {
    }

    public override void ThucHien()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        int temp = n;

        bool toanChan = true;
        bool toanLe = true;

        while (temp > 0)
        {
            int chuSo = temp % 10;

            if (chuSo % 2 == 0)
                toanLe = false;
            else
                toanChan = false;

            temp /= 10;
        }

        if (toanChan)
            Console.WriteLine("Cac chu so deu chan");
        else if (toanLe)
            Console.WriteLine("Cac chu so deu le");
        else
            Console.WriteLine("Khong phai toan chan hoac toan le");
    }
}


// ======================================================
// BÀI 12: CHỮ SỐ TĂNG DẦN
// ======================================================
class Bai12 : BaiTap
{
    public Bai12() : base("Kiem tra chu so tang dan")
    {
    }

    public override void ThucHien()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        string s = n.ToString();

        bool tangDan = true;

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] >= s[i + 1])
            {
                tangDan = false;
                break;
            }
        }

        if (tangDan)
            Console.WriteLine("Cac chu so tang dan");
        else
            Console.WriteLine("Cac chu so khong tang dan");
    }
}


// ======================================================
// BÀI 13: CHỮ SỐ GIẢM DẦN
// ======================================================
class Bai13 : BaiTap
{
    public Bai13() : base("Kiem tra chu so giam dan")
    {
    }

    public override void ThucHien()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        string s = n.ToString();

        bool giamDan = true;

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] <= s[i + 1])
            {
                giamDan = false;
                break;
            }
        }

        if (giamDan)
            Console.WriteLine("Cac chu so giam dan");
        else
            Console.WriteLine("Cac chu so khong giam dan");
    }
}


// ======================================================
// BÀI 14: TÌM m LỚN NHẤT
// 1 + 2 + ... + m < n
// ======================================================
class Bai14 : BaiTap
{
    public Bai14() : base("Tim m lon nhat sao cho tong < n")
    {
    }

    public override void ThucHien()
    {
        Console.Write("Nhap n > 0: ");
        int n = int.Parse(Console.ReadLine());

        int m = 0;
        int tong = 0;

        while (tong + m + 1 < n)
        {
            m++;
            tong += m;
        }

        Console.WriteLine($"m lon nhat = {m}");
        Console.WriteLine($"Tong = {tong}");
    }
}


// ======================================================
// BÀI 15: TÌM m NHỎ NHẤT
// 1 + 2 + ... + m > n
// ======================================================
class Bai15 : BaiTap
{
    public Bai15() : base("Tim m nho nhat sao cho tong > n")
    {
    }

    public override void ThucHien()
    {
        Console.Write("Nhap n > 0: ");
        int n = int.Parse(Console.ReadLine());

        int m = 0;
        int tong = 0;

        while (tong <= n)
        {
            m++;
            tong += m;
        }

        Console.WriteLine($"m nho nhat = {m}");
        Console.WriteLine($"Tong = {tong}");
    }
}


// ======================================================
// BÀI 16: SỐ ĐẢO
// ======================================================
class Bai16 : BaiTap
{
    public Bai16() : base("Xuat so dao")
    {
    }

    public override void ThucHien()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        int dao = 0;

        while (n > 0)
        {
            dao = dao * 10 + n % 10;
            n /= 10;
        }

        Console.WriteLine($"So dao = {dao}");
    }
}


// ======================================================
// BÀI 17: HỆ 10 -> HỆ 2
// ======================================================
class Bai17 : BaiTap
{
    public Bai17() : base("Doi he 10 sang he 2")
    {
    }

    public override void ThucHien()
    {
        Console.Write("Nhap n he 10: ");
        int n = int.Parse(Console.ReadLine());

        if (n == 0)
        {
            Console.WriteLine("He 2: 0");
            return;
        }

        string ketQua = "";

        while (n > 0)
        {
            int du = n % 2;
            ketQua = du + ketQua;
            n /= 2;
        }

        Console.WriteLine($"He 2: {ketQua}");
    }
}


// ======================================================
// BÀI 18: HỆ 2 -> HỆ 10
// ======================================================
class Bai18 : BaiTap
{
    public Bai18() : base("Doi he 2 sang he 10")
    {
    }

    public override void ThucHien()
    {
        Console.Write("Nhap n he 2: ");
        string n = Console.ReadLine();

        int ketQua = 0;

        foreach (char c in n)
        {
            if (c != '0' && c != '1')
            {
                Console.WriteLine("So nhi phan khong hop le!");
                return;
            }

            ketQua = ketQua * 2 + (c - '0');
        }

        Console.WriteLine($"He 10: {ketQua}");
    }
}


// ======================================================
// BÀI 19: HỆ 10 -> HỆ 16
// ======================================================
class Bai19 : BaiTap
{
    public Bai19() : base("Doi he 10 sang he 16")
    {
    }

    public override void ThucHien()
    {
        Console.Write("Nhap n he 10: ");
        int n = int.Parse(Console.ReadLine());

        if (n == 0)
        {
            Console.WriteLine("He 16: 0");
            return;
        }

        string kyTuHex = "0123456789ABCDEF";
        string ketQua = "";

        while (n > 0)
        {
            int du = n % 16;

            ketQua = kyTuHex[du] + ketQua;

            n /= 16;
        }

        Console.WriteLine($"He 16: {ketQua}");
    }
}


// ======================================================
// BÀI 20: HỆ 16 -> HỆ 10
// ======================================================
class Bai20 : BaiTap
{
    public Bai20() : base("Doi he 16 sang he 10")
    {
    }

    public override void ThucHien()
    {
        Console.Write("Nhap n he 16: ");
        string n = Console.ReadLine().ToUpper();

        int ketQua = 0;

        foreach (char c in n)
        {
            int giaTri;

            if (c >= '0' && c <= '9')
            {
                giaTri = c - '0';
            }
            else if (c >= 'A' && c <= 'F')
            {
                giaTri = c - 'A' + 10;
            }
            else
            {
                Console.WriteLine("So he 16 khong hop le!");
                return;
            }

            ketQua = ketQua * 16 + giaTri;
        }

        Console.WriteLine($"He 10: {ketQua}");
    }
}


// ======================================================
// CHƯƠNG TRÌNH CHÍNH
// ======================================================
class Program
{
    static void Main()
    {
        // 3. KẾ THỪA + ĐA HÌNH
        BaiTap[] danhSach =
        {
            new Bai1(),
            new Bai2(),
            new Bai3(),
            new Bai4(),
            new Bai5(),
            new Bai6(),
            new Bai7(),
            new Bai8(),
            new Bai9(),
            new Bai10(),
            new Bai11(),
            new Bai12(),
            new Bai13(),
            new Bai14(),
            new Bai15(),
            new Bai16(),
            new Bai17(),
            new Bai18(),
            new Bai19(),
            new Bai20()
        };

        while (true)
        {
            Console.Clear();

            Console.WriteLine("================================================");
            Console.WriteLine("              MENU BAI TAP 1 - 20");
            Console.WriteLine("================================================");

            for (int i = 0; i < danhSach.Length; i++)
            {
                Console.WriteLine(
                    $"{i + 1}. {danhSach[i].TenBai}"
                );
            }

            Console.WriteLine("0. Thoat");

            Console.WriteLine("================================================");
            Console.Write("Nhap chon: ");

            int chon = int.Parse(Console.ReadLine());

            if (chon == 0)
                return;

            if (chon >= 1 && chon <= 20)
            {
                Console.Clear();

                // 4. ĐA HÌNH
                danhSach[chon - 1].ThucHien();

                Console.WriteLine();
                Console.WriteLine("Nhan Enter de quay lai menu...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Lua chon khong hop le!");
                Console.ReadLine();
            }
        }
    }
}

