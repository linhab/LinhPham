using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaitapC_
{
    internal class Program
    {
        // Bài 1: Viết chương trình nhập vào số nguyên và kiểm tra xem số đó có chia hết cho 3 hay không. Hiển thị kết quả ra màn hình.
        public static void CheckDivisibleByThree(int num)
        {
            if (num % 3 == 0)
            {
                Console.WriteLine("So {0} chia het cho 3", num);
            }
            else
            {
                Console.WriteLine("So {0} khong chia het 3", num);
            }
        }

        //Bài 2: Nhập vào số nguyên dương n, hiển thị bảng cửu chương từ 1 đến n ra màn hình.
        public static void CuuChuong(int num)
        {
            Console.WriteLine("Bang cuu chuong cua {0}:", num);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}",num, i, num*i);
            }
        }

        //Bài 3: Nhập vào số nguyên dương từ n từ bàn phím, tính tổng giai thừa từ 1 đến n và hiển thị kết quả ra màn hình.
        public static long TongGiaiThua(int num)
        {
            long sum = 0;
            for (int i = 1; i <= num; i++)
            {
                long giaiThua = 1;
                for (int j = 1; j <= i; j++)
                { 
                    giaiThua  = giaiThua*j;
                }  
                sum += giaiThua;
            }
            return sum;
        }

        //Bài 4: Viết chương trình nhập vào số nguyên từ bàn phím, kiểm tra xem số đó có phải là số chính phương hay không.Hiển thị kết quả đạt được ra màn hình.
        public static bool CheckSoChinhPhuong(int num)
        {
            int sqrt = (int)Math.Sqrt(num);
            return sqrt * sqrt == num;
        }
        static void Main(string[] args)
        {
            //Bài 1: 
            char continueOption;
            do
            {
                int num;
                do
                {
                    Console.Write("Hay nhap vao 1 so nguyen duong: ");
                    num = int.Parse(Console.ReadLine());
                    if (num <= 0)
                    {
                        Console.WriteLine("Vui long nhap mot so nguyen duong!");
                    }
                } while (num <= 0);
                CheckDivisibleByThree(num);
                Console.WriteLine();
                Console.Write("Nhap 'Y' de tiep tuc chuong trinh, hoac mot phim khac 'Y' de ket thuc: ");
                continueOption = Char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
            } while (continueOption == 'Y');
            Console.Write("Chuong trinh ket thuc.");
            Console.ReadKey();


            //Bài 2: 
            //char continueOption;
            //do
            //{
            //    int num;
            //    do
            //    {
            //        Console.Write("Ban muon hien thi bang cuu chuong may? ");
            //        num = int.Parse(Console.ReadLine());
            //        if (num <= 0)
            //        {
            //            Console.WriteLine("Vui long nhap mot so nguyen duong!");
            //        }
            //    } while (num <= 0);
            //    CuuChuong(num);
            //    Console.WriteLine();
            //    Console.Write("Nhap 'Y' de tiep tuc chuong trinh, hoac mot phim khac 'Y' de ket thuc: ");
            //    continueOption = Char.ToUpper(Console.ReadKey().KeyChar);
            //    Console.WriteLine();
            //} while (continueOption == 'Y');
            //Console.Write("Chuong trinh ket thuc.");
            //Console.ReadKey();

            //Bai 3:
            //char continueOption;
            //do
            //{
            //    int num;
            //    do
            //    {
            //        Console.Write("Hay nhap vao 1 so nguyen duong: ");
            //        num = int.Parse(Console.ReadLine());
            //        if (num <= 0)
            //        {
            //            Console.WriteLine("Vui long nhap mot so nguyen duong!");
            //        }
            //    } while (num <= 0);
            //    long ketQua = TongGiaiThua(num);
            //    Console.WriteLine("Tong giai thua tu 1 den {0} la {1}.", num, ketQua);
            //    Console.WriteLine();
            //    Console.Write("Nhap 'Y' de tiep tuc chuong trinh, hoac mot phim khac 'Y' de ket thuc: ");
            //    continueOption = Char.ToUpper(Console.ReadKey().KeyChar);
            //    Console.WriteLine();
            //} while (continueOption == 'Y');
            //Console.Write("Chuong trinh ket thuc.");
            //Console.ReadKey();

            //Bai 4:
            //    char continueOption;
            //    do
            //    {
            //        int num;
            //        do
            //        {
            //            Console.Write("Nhap vao 1 so nguyen duong: ");
            //            num = int.Parse(Console.ReadLine());
            //            if (num <= 0)
            //            {
            //                Console.WriteLine("Vui long nhap mot so nguyen duong!");
            //            }
            //        } while (num <= 0);
            //        if (CheckSoChinhPhuong(num))
            //        {
            //            Console.WriteLine("So {0} la so chinh phuong.", num);
            //        }
            //        else
            //        {
            //            Console.WriteLine("So {0} khong phai la so chinh phuong.", num);
            //        }
            //        Console.WriteLine();
            //        Console.Write("Nhap 'Y' de tiep tuc chuong trinh, hoac mot phim khac 'Y' de ket thuc: ");
            //        continueOption = Char.ToUpper(Console.ReadKey().KeyChar);
            //        Console.WriteLine();
            //    } while (continueOption == 'Y');
            //    Console.Write("Chuong trinh ket thuc.");
            //    Console.ReadKey();
        }
    }
}
