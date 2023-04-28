using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27._04._23
{
    public partial class BestOil : Form
    {
        public BestOil()
        {
            InitializeComponent();
        }
        private double a92 = 40.00;
        private double a95 = 46.00;
        private double DP = 45.00;
       
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(rB_L.Checked)
            {
                kol_L.ReadOnly = false;
                sum_grn.ReadOnly = true;
                kol_L.Text = 10.ToString("N2");  
                sum_grn.Text = string.Empty;
            }
            else if (rB_sum.Checked)
            {
                kol_L.ReadOnly = true;
                sum_grn.ReadOnly = false;
                sum_grn.Text = 100.ToString("N2");
                kol_L.Text = string.Empty;
            }
        }
        private double RozrahAvtozapravka()
        {
            double toOplata = 0;
             if (rB_L.Checked)
            {
                toOplata = double.Parse(Cena.Text) * double.Parse(kol_L.Text);
                sum_grn.Text = toOplata.ToString("N2");
            }
             else if (rB_sum.Checked)
            {
                toOplata = double.Parse(sum_grn.Text);
                kol_L.Text = (toOplata / double.Parse(Cena.Text)).ToString("N2"); 
            }
             return toOplata;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                Cena.Text = a92.ToString();
            else if (comboBox1.SelectedIndex == 1)
                Cena.Text = a95.ToString();
            else if (comboBox1.SelectedIndex == 2)
                Cena.Text = DP.ToString();
            itogoAvto.Text = RozrahAvtozapravka().ToString("N2");
        }
        private void BestOil_Load(object sender, EventArgs e)
        {
            // Автозаправка
            comboBox1.SelectedIndex = 1;
            rB_L.Checked = true;
            // Кафе
            price_coffee.Text = 20.ToString();
            textBox6.Text = 1.ToString();
            price_tea.Text = 15.ToString();
            textBox7.Text = 1.ToString();
            price_burger.Text = 50.ToString();
            textBox8.Text = 1.ToString();
            price_hot_dog.Text = 40.ToString();
            textBox9.Text = 1.ToString();
            price_croissant.Text = 30.ToString();
            textBox10.Text = 1.ToString();
        }

        private void kol_L_TextChanged(object sender, EventArgs e)
        {
            itogoAvto.Text = RozrahAvtozapravka().ToString("N2");
        }
        
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            itogoCafe.Text = RozrahCofe().ToString("N2");
        }

        private double RozrahCofe()
        {
            double toOplata = 0;
            if (coffee.Checked) //кофе
            {
                toOplata += double.Parse(price_coffee.Text) * double.Parse(textBox6.Text);
            }
            if (tea.Checked) //Чай
            {
                toOplata += double.Parse(price_tea.Text) * double.Parse(textBox7.Text);
            }
            if (burger.Checked) //Бургер
            {
                toOplata += double.Parse(price_burger.Text) * double.Parse(textBox8.Text);
            }
            if (hot_dog.Checked) //Хот-дог
            {
                toOplata += double.Parse(price_hot_dog.Text) * double.Parse(textBox9.Text);
            }
            if (croissant.Checked) //Круасан
            {
                toOplata += double.Parse(price_croissant.Text) * double.Parse(textBox10.Text);
            }
            return toOplata;
        }
        private void buttonResult_Click(object sender, EventArgs e)
        {
            labRezult.Text = (double.Parse(itogoAvto.Text) + double.Parse(itogoCafe.Text)).ToString("N2");
        }
    }
}
