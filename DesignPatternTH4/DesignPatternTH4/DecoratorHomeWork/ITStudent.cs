using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH4.DecoratorHomeWork
{
    internal class ITStudent : AbstractDecorator
    {
        public Student student;
        public ITStudent(Student student)
        {
            this.student = student;
        }

        public override void DiHoc()
        {
            base.DiHoc();
            DiThiTinHoc();
        }

        private void DiThiTinHoc()
        {
            Console.WriteLine($"Sinh vien {student.name} di thi tin hoc");
        }
    }
}
