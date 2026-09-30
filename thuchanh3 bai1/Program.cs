using System;

// ==========================================
// LỚP CHA - TRỪU TƯỢNG
// ==========================================
abstract class BaiTap
{
    // ĐÓNG GÓI
    public string TenBai { get; set; }

    public BaiTap(string tenBai)
    {
        TenBai = tenBai;
    }

    // TRỪU TƯỢNG
    public abstract void ThucHien();
}


// ==========================================
// BÀI 1: TÍNH ĐIỂM CHỮ
// ==========================================
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


// ==========================================
// BÀI 2: TÍNH TIỀN
// ==========================================
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

        double giamGia;

        if (thanhTien > 100)
            giamGia = thanhTien * 0.03;
        else
            giamGia = 0;

        double tongTien = thanhTien - giamGia;

        Console.WriteLine($"Thanh tien: {thanhTien:F2}");
        Console.WriteLine($"Giam gia: {giamGia:F2}");
        Console.WriteLine($"Tong tien phai tra: {tongTien:F2}");
    }
}


// ==========================================
// BÀI 3: THÁNG
// ==========================================
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


// ==========================================
// BÀI 4:
// 1*2 + 2*3 + 3*4 + ... + n(n+1)
// ==========================================
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


// ==========================================
// BÀI 5:
// 1/(1*2*3) + 1/(2*3*4) + ... +
// 1/(n*(n+1)*(n+2))
// ==========================================
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


// ==========================================
// BÀI 6: HEX -> DECIMAL
// ==========================================
class Bai6 : BaiTap
{
    public Bai6() : base("Doi Hex sang Decimal")
    {
    }

    public override void ThucHien()
    {
        Console.Write("Nhap ky tu he thap luc phan: ");
        char c = char.Parse(Console.ReadLine());

        int ketQua;

        if (c >= '0' && c <= '9')
        {
            ketQua = c - '0';
        }
        else if (c >= 'A' && c <= 'F')
        {
            ketQua = c - 'A' + 10;
        }
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


// ==========================================
// BÀI 7: UCLN
// ==========================================
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


// ==========================================
// BÀI 8: TỔNG CÁC CHỮ SỐ
// ==========================================
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


// ==========================================
// BÀI 9: ĐẾM CHỮ SỐ CHẴN / LẺ
// ==========================================
class Bai9 : BaiTap
{
    public Bai9() : base("Dem chu so chan le")
    {
    }

    public override void ThucHien()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine());

        int soChan = 0;
        int soLe = 0;

        while (n > 0)
        {
            int chuSo = n % 10;

            if (chuSo % 2 == 0)
                soChan++;
            else
                soLe++;

            n /= 10;
        }

        Console.WriteLine($"So chu so chan: {soChan}");
        Console.WriteLine($"So chu so le: {soLe}");
    }
}


// ==========================================
// BÀI 10: GỬI NGÂN HÀNG
// ==========================================
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
        Console.WriteLine($"So tien sau khi gui: {n:F2} USD");
    }
}


// ==========================================
// CHƯƠNG TRÌNH CHÍNH
// ==========================================
class Program
{
    static void Main()
    {
        // KẾ THỪA + ĐA HÌNH
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
            new Bai10()
        };

        while (true)
        {
            Console.Clear();

            Console.WriteLine("========== MENU ==========");
            Console.WriteLine("1. Tinh diem chu");
            Console.WriteLine("2. Tinh tien phai tra");
            Console.WriteLine("3. Kiem tra thang");
            Console.WriteLine("4. Tinh tong i*(i+1)");
            Console.WriteLine("5. Tinh tong phan so");
            Console.WriteLine("6. Doi Hex sang Decimal");
            Console.WriteLine("7. Tim UCLN");
            Console.WriteLine("8. Tinh tong cac chu so");
            Console.WriteLine("9. Dem chu so chan le");
            Console.WriteLine("10. Tinh so thang gui ngan hang");
            Console.WriteLine("0. Thoat");
            Console.WriteLine("==========================");

            Console.Write("Nhap chon: ");
            int chon = int.Parse(Console.ReadLine());

            if (chon == 0)
                return;

            if (chon >= 1 && chon <= 10)
            {
                Console.Clear();

                // ĐA HÌNH
                danhSach[chon - 1].ThucHien();

                Console.WriteLine();
                Console.WriteLine("Nhan Enter de tiep tuc...");
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
