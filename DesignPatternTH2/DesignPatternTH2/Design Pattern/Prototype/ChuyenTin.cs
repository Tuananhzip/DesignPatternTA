using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTH2.Design_Pattern.Prototype
{
    internal class ChuyenTin : Student
    {
        public ChuyenTin(string name,string diaChi,int tuoi)
        {
            this.name = name;
            this.diaChi = diaChi;
            this.tuoi = tuoi;
        }
        public override Student Clone()
        {
            return (ChuyenTin)this.MemberwiseClone();
        }
        public string DiThiChuyenTin()
        {
            return "Di thi chuyen tin";
        }
    }
}
