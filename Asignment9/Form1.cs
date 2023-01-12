using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asignment9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                MessageBox.Show("لا يمكن ترك مكان الكتابة فارغا");
                textBox1.Focus();
                return;
            }
            if (int.Parse(textBox1.Text.Trim()) >= 0 && int.Parse(textBox1.Text.Trim()) <= 49)
            {
                MessageBox.Show("للأسف، أنت راسب، حظ أوفر في العام القادم");
            }
           else if (int.Parse(textBox1.Text.Trim()) >= 50 && int.Parse(textBox1.Text.Trim()) <= 64)
            {
                MessageBox.Show("مقبول، حاول تحسين مستواك في العام القادم");
            }
           else if (int.Parse(textBox1.Text.Trim()) >= 65 && int.Parse(textBox1.Text.Trim()) <= 80)
            {
                MessageBox.Show("جيد، حاول الاجتهاد أكثر لكي تصل إلى تقدير أعلى في العام القادم");
            }
           else if (int.Parse(textBox1.Text.Trim()) >= 81 && int.Parse(textBox1.Text.Trim()) <= 90)
            {
                MessageBox.Show("جيد جدا، أحسنت، ننصحك بالاجتهاد أكثر لكي تصل إلى الممتاز");
            }
           else if (int.Parse(textBox1.Text.Trim()) >= 91 && int.Parse(textBox1.Text.Trim()) <= 100)
            {
                MessageBox.Show("ممتاز، أحسنت");
            }
            else
            {
                MessageBox.Show("من فضلك أدخل قيمة صحيحة بين 0 وا 100");
            }
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] names = { "أحمد", "محمد", "مصطفى", "محمود", "علاؤ", "حسام", "هيثم", "علي", "يوسف", "كريم" };
            foreach (string name in names)
            {
                MessageBox.Show(name);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] names = { "أحمد", "محمد", "مصطفى", "محمود", "علاؤ", "حسام", "هيثم", "علي", "يوسف", "كريم" };
            for (int i = 0; i <=names.Count()-1; i++)
            {
                if (i==4)
                {
                    MessageBox.Show("إن ترتيب " + names[i]+" هو "+i+1);
                }
                else if (i==9)
                {
                    MessageBox.Show("إن ترتيب " + names[i]+" هو "+i+1);
                }
                else
                {
                    MessageBox.Show(names[i]);
                }
            }
        }
    }
}
    