using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH4.DecoratorHomeWork
{
    internal class MathStudent : AbstractDecorator
    {
        public Student student;
        public MathStudent(Student student)
        {
            this.student = student;
        }

        public override void DiHoc()
        {
            base.DiHoc();
            DiThiToan();
        }

        private void DiThiToan()
        {
            Console.WriteLine($"Sinh vien {student.name} di thi toan");
        }
    }
}
