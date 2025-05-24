using System;
using System.Collections.Generic;

class PhanSo
{
    public int Tu { get; set; }
    public int Mau { get; set; }

    public PhanSo(int tu, int mau)
    {
        if (mau == 0)
            throw new ArgumentException("Mẫu số không được bằng 0");
        Tu = tu;
        Mau = mau;
    }

    public void Nhap()
    {
        Console.Write("Nhập tử số: ");
        Tu = int.Parse(Console.ReadLine());
        do
        {
            Console.Write("Nhập mẫu số (khác 0): ");
            Mau = int.Parse(Console.ReadLine());
        } while (Mau == 0);
    }

    public static PhanSo Cong(PhanSo a, PhanSo b)
    {
        int tu = a.Tu * b.Mau + b.Tu * a.Mau;
        int mau = a.Mau * b.Mau;
        return RutGon(new PhanSo(tu, mau));
    }

    public static PhanSo RutGon(PhanSo p)
    {
        int ucln = UCLN(Math.Abs(p.Tu), Math.Abs(p.Mau));
        p.Tu /= ucln;
        p.Mau /= ucln;
        return p;
    }

    private static int UCLN(int a, int b)
    {
        while (b != 0)
        {
            int t = a % b;
            a = b;
            b = t;
        }
        return a;
    }

    public override string ToString()
    {
        return $"{Tu}/{Mau}";
    }
}

class Program
{
    static void Main()
    {
        List<PhanSo> danhSach = new List<PhanSo>();

        Console.Write("Nhập số lượng phân số: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Phân số {i + 1}: ");
            PhanSo ps = new PhanSo(1, 1);
            ps.Nhap();
            danhSach.Add(ps);
        }

        PhanSo tong = new PhanSo(0, 1);
        foreach (var ps in danhSach)
        {
            tong = PhanSo.Cong(tong, ps);
        }

        Console.WriteLine($"Tổng các phân số là: {tong}");
    }
}
