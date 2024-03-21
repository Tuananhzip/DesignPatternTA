
using BuilderPattern.Model;
using System;
using System.Runtime.InteropServices;
using System.Text;
class Program
{

    [DllImport("kernel32.dll")]
    static extern bool SetConsoleOutputCP(uint wCodePageID);
    static void Main(string[] args)
    {
        SetConsoleOutputCP(65001);
        Console.OutputEncoding = System.Text.Encoding.UTF8;


        //Telescope contructor

        ProblemMilkTea milkTea1 = new ProblemMilkTea("M");
        ProblemMilkTea milkTea2 = new ProblemMilkTea("L", "tra lai");
        ProblemMilkTea milkTea3 = new ProblemMilkTea("XL", "tra gao rang", 30);
        ProblemMilkTea milkTea4 = new ProblemMilkTea("XL", "tra gao rang", 70, 100);//...
        Console.WriteLine(milkTea1 + "\t\t\t\t\t\tproblem milk tea");
        Console.WriteLine(milkTea2 + "\t\t\t\t\tproblem milk tea");
        Console.WriteLine(milkTea3 + "\t\t\t\tproblem milk tea");
        Console.WriteLine(milkTea4 + "\t\t\t\tproblem milk tea\n");




        //Telescope contructor
        TelescopeContructorMilkTea milkTeaTelescope = new TelescopeContructorMilkTea("M", "tra lai", 70, 50, true, false,true);
        Console.WriteLine(milkTeaTelescope + "\t\t\ttelescope contructor milk tea\n");


        //Để giải quyết mình dùng Builder Pattern
        var milkTea = new MilkTea("XL", "tra lai", 70, 30, true, true, false);
        Console.WriteLine(milkTea + "\t\t\tbasic milk tea\n"); // cách khởi tạo bình thường

        var milkTeaBuilder = new MilkTeaBuilder()
                                          .AddSize("L")
                                          .AddFlavor("tra gao rang")
                                          .AddSugar(30)
                                          .AddIce(50)
                                          .AddBubble(true)
                                          .AddFlan(true)
                                          .AddCream(true)
                                          .Build();

        Console.WriteLine(milkTeaBuilder + "\tbuilder milk tea\n");
        // Dùng builder thì nó phức tạp và code dài ra nhưng mà về mặt cấu trúc dễ đọc, dễ hiểu hơn và dễ phát triển hơn

        // Lớp Director ...
        // Như là 1 lớp xây dựng sẵn những thiết kế nên có.
        Director director = new Director();
        MilkTeaBuilder builder = new MilkTeaBuilder();
        int loop = 0;
        do
        {
            Console.WriteLine("\n\t1 = Tra sua truyen thong\n\t2 = Tra sua kem cheese\n\t3 = Tra sua banh flan\n\t4 = Tra sua tran chau banh flan\n\t5 = Tra sua tran chau kem cheese\n\t6 = Tra sua full topping");
            int loaiTS;
            Console.Write("\t\tChon so theo loai tra sua: ");
            while (!int.TryParse(Console.ReadLine(), out loaiTS) || loaiTS < 1 || loaiTS > 6)
            {
                Console.WriteLine("\tVui long nhap so tu 1 den 6 thoi. Vui long nhap lai !!!");
                Console.Write("\t\tChon so theo loai tra sua: ");
            }
            switch (loaiTS)
            {
                case 1:
                    director.MilkTeaTradional(builder);
                    break;
                case 2:
                    director.MilkTeaCream(builder);
                    break;
                case 3:
                    director.MilkTeaFlan(builder);
                    break;
                case 4:
                    director.MilkTeaBubbleAndFlan(builder);
                    break;
                case 5:
                    director.MilkTeaBubbleAndCream(builder);
                    break;
                case 6:
                    director.MilkTeaFullTopping(builder);
                    break;
                default:
                    director.MilkTeaTradional(builder);
                    break;
            }
            loop++;
            MilkTea result = builder.Build();
            Console.WriteLine("\t\t\t\t\tKet qua: " + result);
        } while (loop < 6);
        Console.WriteLine("\n\t\t\t\t\t\t****** Ket thuc order ******\t\t\t\t\t\t");
        Console.ReadLine();
    }
}
/*//cách giải quyết telescope contructor là sử dụng JavaBeans
        TelescopeContructorMilkTea javaBeansMilkTea = new TelescopeContructorMilkTea();
        javaBeansMilkTea.setSize("XL");
        javaBeansMilkTea.setFlavor("tra xanh");
        javaBeansMilkTea.setIce(30);
        javaBeansMilkTea.setBubble(true);
        Console.WriteLine(javaBeansMilkTea + "\t\t\t\tjavabeans milk tea\n");
        //nhưng 1 vấn đề nữa nếu ở đây có 100 thuộc tính thì mình phải set
        //nhiều quá nó dài lắm và làm phình to cái lớp cơ sở của mình là class TelescopeContructorMilkTea
        //dẫn đến khó bảo trì và phát triển nhưng nếu lớp cơ sở của mình có ít thuộc tính thì không sao
        //còn nếu nhiều thuộc tính thì chúng ta nên cân nhắc sử dụng ...*/

