using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
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

        //Bài 5: Viết chương trình nhập vào tháng bất kỳ từ bàn phím, hiển thị số ngày có trong tháng ra màn hình.
        //Check năm mà user nhâp vào có phải là năm nhuận hay không.
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        public static int HienThiNgayTrongThang(int month, int year)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    return IsLeapYear(year) ? 29 : 28;
                default:
                    return 0;

            }
        }

        //Bài 6 và 7, 9 không tạo function mà viết trực tiếp vào chương trình.

        //Bài 8: Nhập vào số nguyên dương n, hiển thị ra màn hình các số nguyên tố từ 1 đến n.
        public static bool CheckSoNguyento(int num)
        {
            if (num <= 1)
                return false;
            if (num == 2)
                return true;
            if (num % 2 == 0)
                return false;
            int n = (int)Math.Floor(Math.Sqrt(num));
            for (int i = 3; i <= n; i++)
                {
                    if (num % i == 0)
                        return false;
                }
            return true;
        }

        //Bài 10: Nhập vào số nguyên dương n, tính toán và hiển thị dãy Fibonacci ra màn hình.
        public static void Fibonacci(int num)
        {
            long first = 0, second = 1;
            for (int i = 0; i < num; i++)
            {
                Console.Write(first + "    ");
                long next = first + second;
                first = second;
                second = next;
            }
        }

        static void Main(string[] args)
        {
            //Bài 1: 
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
            //    CheckDivisibleByThree(num);
            //    Console.WriteLine();
            //    Console.Write("Nhap 'Y' de tiep tuc chuong trinh, hoac mot phim khac 'Y' de ket thuc: ");
            //    continueOption = Char.ToUpper(Console.ReadKey().KeyChar);
            //    Console.WriteLine();
            //} while (continueOption == 'Y');
            //Console.Write("Chuong trinh ket thuc.");

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

            //Bài 5
            //Console.Write("Nhap thang ban muon check ngay (tu 1-12): ");
            //int month = int.Parse(Console.ReadLine());
            //if (month < 1 || month > 12)
            //{
            //    Console.WriteLine("Thang nhap khong hop le. Vui long nhap tu 1 den 12.");
            //}
            //else
            //{
            //    Console.Write(" Nhap nam: ");
            //    int year = int.Parse(Console.ReadLine());
            //    int day = HienThiNgayTrongThang(month, year);
            //    Console.Write("Thang {0} nam {1} co {2} ngay.", month, year, day);
            //}

            //Bài 6
            //try
            //{
            //    Console.Write("Nhap 1 so nguyen duong: ");
            //    int num = int.Parse(Console.ReadLine());
            //    long sum = 0;
            //    for (int i = 1; i <= num; i++)
            //    {
            //        sum += (long)Math.Pow(i, i);
            //    }
            //    Console.WriteLine("Tong S la: {0}", sum);
            //}
            //catch(FormatException)
            //{
            //    Console.WriteLine("Sai dinh dang.");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Da xay ra loi");
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine(e.ToString());
            //}

            //Bài 7: Viết chương trình nhập vào số nguyên n, tính tổng các số lẽ từ 1 đến n và hiển thị kết quả ra màn hình.
            //try
            //{
            //    Console.Write("Nhap so nguyen n: ");
            //    int num = int.Parse(Console.ReadLine());
            //    long sum = 0;
            //    for (int i = 1; i <= num; i++)
            //    {
            //        if (i % 2 != 0)
            //        {
            //            sum += i;
            //        }
            //    }
            //    Console.Write("Tong cac so le tu 1 den {0} la: {1}",num, sum);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Sai dinh dang.");
            //}
            //catch (Exception)
            //{
            //    Console.Write("Da xay ra loi.");
            //}

            //Bài 8: Nhập vào số nguyên dương n, hiển thị ra màn hình các số nguyên tố từ 1 đến n.
            //try
            //{
            //    Console.Write("Nhap 1 so nguyen n: ");
            //    int num = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Cac so nguyen to tu 1 den {0} la: ", num);
            //    for (int i = 0; i <= num; i++)
            //    {
            //        if (CheckSoNguyento(i))
            //        {
            //            Console.Write(i + " ");
            //        }
            //    }
            //}
            //catch (FormatException) {
            //    Console.Write("Sai dinh dang.");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Da xay ra loi");
            //}

            //Bài 9: Viết chương trình nhập vào số hàng n, vẽ tam giác *với số hàng tương ứng.
            //try
            //{
            //    Console.Write("Nhap 1 so nguyen n: ");
            //    int num = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Tam giac vuong voi {0} hang: ", num);
            //    for (int i = 1; i <= num; i++)
            //    {
            //        Console.WriteLine(new String('*', i));
            //    }

            //    Console.WriteLine();
            //    Console.WriteLine("Tam giac vuong nguoc voi {0} hang: ", num);
            //    for (int i = num; i >= 1; i--)
            //    {
            //        Console.WriteLine(new String('*', i));
            //    }

            //    Console.WriteLine();
            //    Console.WriteLine("Tam giac deu voi {0} hang: ", num);
            //    for (int i = 1; i <= num; i++)
            //    {
            //        Console.Write(new String(' ', num - i));
            //        Console.WriteLine(new String('*', 2 * i - 1));
            //    }

            //    Console.WriteLine();
            //    Console.WriteLine("Tam giac deu nguoc voi {0} hang: ", num);
            //    for (int i = num; i >= 1; i--)
            //    {
            //        Console.Write(new String(' ', num - i));
            //        Console.WriteLine(new String('*', 2 * i - 1));
            //    }
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Sai dinh dang");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Da co loi");
            //}

            //Bài 10: Nhập vào số nguyên dương n, tính toán và hiển thị dãy Fibonacci ra màn hình.
            //Console.Write("Nhap vao 1 so nguyen duong: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("Day Fibonacci voi {0} phan tu la: ", num);
            //Fibonacci(num);


            //================Bai tap mang==================
            //Nhập vào mảng gồm n phần tử, với giá trị n được nhập từ người dùng.
            try
            {
                Console.Write("Nhap so luong phan tu cua mang: ");
                int n = int.Parse(Console.ReadLine());
                int[] array = new int[n];
                Console.WriteLine("Nhap cac phan tu cua mang:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Phan tu thu {0}: ", i + 1);
                    array[i] = int.Parse(Console.ReadLine());
                }

                //Bài 1: Đọc và in các phần tử trong mảng vừa nhập.
                Console.WriteLine("Cac phan tu trong mang la:");
                foreach (var item in array)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();

                //Bài 2: In mảng dữ liệu trên theo chiều đảo ngược.
                Console.WriteLine("Cac phan tu trong mang theo thu tu đao nguoc la:");
                for (int i = n - 1; i >= 0; i--)
                {
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
            }
            catch (FormatException)
            {
                Console.Write("Sai dinh dang.");
            }
            catch (Exception)
            {
                Console.Write("Da xay ra loi");
            }
            







            Console.ReadKey();





        }

    }
}
