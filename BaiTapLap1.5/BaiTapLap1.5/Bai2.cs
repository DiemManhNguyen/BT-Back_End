using System;
using System.Collections.Generic;

abstract class Hinh
{
    public abstract double ChuVi();
    public abstract double DienTich();
}

class HinhTron : Hinh
{
    public double BanKinh { get; set; }

    public HinhTron(double r)
    {
        BanKinh = r;
    }

    public override double ChuVi() => 2 * Math.PI * BanKinh;

    public override double DienTich() => Math.PI * BanKinh * BanKinh;
}

class HinhVuong : Hinh
{
    public double Canh { get; set; }

    public HinhVuong(double canh)
    {
        Canh = canh;
    }

    public override double ChuVi() => 4 * Canh;

    public override double DienTich() => Canh * Canh;
}

class HinhChuNhat : Hinh
{
    public double Dai { get; set; }
    public double Rong { get; set; }

    public HinhChuNhat(double dai, double rong)
    {
        Dai = dai;
        Rong = rong;
    }

    public override double ChuVi() => 2 * (Dai + Rong);

    public override double DienTich() => Dai * Rong;
}

class HinhTamGiac : Hinh
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public HinhTamGiac(double a, double b, double c)
    {
        A = a; B = b; C = c;
    }

    public override double ChuVi() => A + B + C;

    public override double DienTich()
    {
        double p = ChuVi() / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }
}

class Bai2
{
    static void Main(string[] args)
    {
        List<Hinh> danhSachHinh = new List<Hinh>
           {
               new HinhTron(3),
               new HinhVuong(4),
               new HinhChuNhat(5, 2),
               new HinhTamGiac(3, 4, 5)
           };

        double tongChuVi = 0, tongDienTich = 0;
        foreach (var hinh in danhSachHinh)
        {
            tongChuVi += hinh.ChuVi();
            tongDienTich += hinh.DienTich();
        }

        Console.WriteLine($"Tổng chu vi các hình: {tongChuVi:F2}");
        Console.WriteLine($"Tổng diện tích các hình: {tongDienTich:F2}");
    }
}
