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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedChild = comboBox1.SelectedItem.ToString();
                Director director = new Director();
                MilkTeaBuilder builder = new MilkTeaBuilder();
                switch (selectedChild)
                {
                    case "Trà sữa truyền thống":
                        director.MilkTeaTradional(builder);
                        break;
                    case "Trà sữa kem cheese":
                        director.MilkTeaCream(builder);
                        break;
                    case "Trà sữa bánh flan":
                        director.MilkTeaFlan(builder);
                        break;
                    case "Trà sữa trân châu bánh flan":
                        director.MilkTeaBubbleAndFlan(builder);
                        break;
                    case "Trà sữa trân châu kem cheese":
                        director.MilkTeaBubbleAndCream(builder);
                        break;
                    case "Trà sữa full topping":
                        director.MilkTeaFullTopping(builder);
                        break;
                    default:
                        director.MilkTeaTradional(builder);
                        break;
                }
                DialogResult result = MessageBox.Show("Order của bạn: " + selectedChild,"Xác nhận order",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                if(result == DialogResult.OK)
                {
                    resultText.Text = builder.Build().ToString();
                    pictureBox1.ImageLocation = "https://i.pinimg.com/originals/f6/3c/4a/f63c4ae3414576d8e378327146c21ebe.png";
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show("Order không thành công !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resultText.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn trà sữa muốn order !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
