using BuilderPatternWinForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuilderPatternWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MilkTeaBuilder builder = new MilkTeaBuilder();

        private void button1_Click(object sender, EventArgs e)
        {
            CheckSize();
            CheckFlavor();
            CheckSugar();
            CheckIce();
            CheckTopping();
            string result = builder.Build().ToString();
            if(result != "" || result != null)
            {
                resultText.Text = result;
                builder.Reset();
                //Image
                pictureBox1.ImageLocation = "https://png.pngtree.com/png-vector/20230330/ourmid/pngtree-pearl-milk-tea-pearl-drink-transparent-png-image_6674261.png";
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }
        private void CheckSize()
        {
            builder.AddSize(sizeBtn1.Checked ? sizeBtn1.Text :
                            sizeBtn2.Checked ? sizeBtn2.Text :
                            sizeBtn3.Checked ? sizeBtn3.Text : throw new Exception("Vui lòng chọn size"));
        }
        private void CheckFlavor()
        {
            builder.AddFlavor(mTeaBtn1.Checked ? mTeaBtn1.Text :
                              mTeaBtn2.Checked ? mTeaBtn2.Text :
                              mTeaBtn3.Checked ? mTeaBtn3.Text : throw new Exception("Vui lòng chọn loại trà sữa"));
        }
        private void CheckSugar()
        {
            builder.AddSugar(sugarBtn1.Checked ? 0 :
                             sugarBtn2.Checked ? 30 :
                             sugarBtn3.Checked ? 50 :
                             sugarBtn4.Checked ? 70 :
                             sugarBtn5.Checked ? 100 : throw new Exception("Vui lòng chọn mức đường"));
        }
        private void CheckIce()
        {
            builder.AddIce(iceBtn1.Checked ? 0 :
                             iceBtn2.Checked ? 30 :
                             iceBtn3.Checked ? 50 :
                             iceBtn4.Checked ? 70 :
                             iceBtn5.Checked ? 100 : throw new Exception("Vui lòng chọn mức đường"));
        }
        private void CheckTopping()
        {
            if (tcBtn.Checked) builder.AddBubble(tcBtn.Checked);
            if (flanBtn.Checked) builder.AddFlan(flanBtn.Checked);
            if (creamBtn.Checked) builder.AddCream(creamBtn.Checked);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.ShowDialog();
        }
    }
}
