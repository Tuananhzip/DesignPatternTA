using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH2.Design_Pattern.Prototype
{
    internal class ChuyenToan : Student
    {
        public ChuyenToan(string name,string diaChi,int tuoi)
        {
            this.name = name;
            this.diaChi = diaChi;
            this.tuoi = tuoi;
        }
        public override Student Clone()
        {
            return (ChuyenToan)this.MemberwiseClone();
        }
        public string DiThiChuyenToan()
        {
            return "Di thi chuyen toan";
        }
    }
}
