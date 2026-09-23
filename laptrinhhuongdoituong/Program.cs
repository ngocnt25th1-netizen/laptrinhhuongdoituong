using System;

struct PHANSO
{
    public int tu;
    public int mau;
}

class Program
{
    // Nhập 1 phân số
    static void Nhap1PS(ref PHANSO ps)
    {
        Console.Write("Nhap tu so: ");
        ps.tu = int.Parse(Console.ReadLine());

        Console.Write("Nhap mau so: ");
        ps.mau = int.Parse(Console.ReadLine());
    }

    // Câu 1a: Nhập một mảng phân số
    static void NhapMangPS(PHANSO[] A, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Nhap phan so thu " + (i + 1));
            Nhap1PS(ref A[i]);
        }
    }

    static void Main()
    {
        Console.Write("Nhap so luong phan so: ");
        int n = int.Parse(Console.ReadLine());

        PHANSO[] A = new PHANSO[n];

        NhapMangPS(A, n);

        Console.WriteLine("Da nhap xong mang phan so.");
        Console.ReadKey();
    }
}     
