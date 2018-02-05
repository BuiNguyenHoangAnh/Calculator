using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double Mem =new double();
        bool b = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.tb_KetQua.Text.Length > 0)
            {
                if (this.tb_PhepTinh.Text.Length > 0)
                {
                    double ketqua;
                    double so2 = Convert.ToDouble(this.tb_KetQua.Text);
                    int dodai = this.tb_PhepTinh.Text.Length;
                    string chuoi = this.tb_PhepTinh.Text;
                    string chuoitam = null;
                    string pheptoan = null;
                    for (int i = 0; i < dodai; i++)
                    {
                        if (i < dodai - 1)
                            chuoitam += chuoi[i];
                        else
                            pheptoan += chuoi[i];
                    }
                    double so1 = Convert.ToDouble(chuoitam);
                    if (pheptoan == "+")
                        ketqua = so1 + so2;
                    else
                    {
                        if (pheptoan == "-")
                            ketqua = so1 - so2;
                        else
                        {
                            if (pheptoan == "x")
                                ketqua = so1 * so2;
                            else
                                ketqua = so1 / so2;
                        }
                    }
                    this.tb_PhepTinh.Text = null;
                    this.tb_PhepTinh.Text += ketqua.ToString();
                    this.tb_PhepTinh.Text += "/";
                }
                else
                {
                    this.tb_PhepTinh.Text = this.tb_KetQua.Text;
                    this.tb_PhepTinh.Text += "/";
                }
            }
            this.tb_KetQua.Text = null;
        }

        private void bt_0_Click(object sender, EventArgs e)
        {
            this.tb_KetQua.Text += "0";
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            this.tb_KetQua.Text += "3";
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            this.tb_KetQua.Text += "2";
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            this.tb_KetQua.Text += "1";
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            this.tb_KetQua.Text += "4";
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            this.tb_KetQua.Text += "5";
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            this.tb_KetQua.Text += "6";
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            this.tb_KetQua.Text += "7";
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            this.tb_KetQua.Text += "8";
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            this.tb_KetQua.Text += "9";
        }

        private void bt_Cham_Click(object sender, EventArgs e)
        {
            this.tb_KetQua.Text += ".";
        }

        private void bt_Cong_Click(object sender, EventArgs e)
        {
            if(this.tb_KetQua.Text.Length > 0)
            {
                if (this.tb_PhepTinh.Text.Length > 0)
                {
                    double ketqua;
                    double so2 = Convert.ToDouble(this.tb_KetQua.Text);
                    int dodai = this.tb_PhepTinh.Text.Length;
                    string chuoi = this.tb_PhepTinh.Text;
                    string chuoitam = null;
                    string pheptoan = null;
                    for (int i = 0; i < dodai; i++)
                    {
                        if (i < dodai - 1)
                            chuoitam += chuoi[i];
                        else
                            pheptoan += chuoi[i];
                    }
                    double so1 = Convert.ToDouble(chuoitam);
                    if (pheptoan == "+")
                        ketqua = so1 + so2;
                    else
                    {
                        if (pheptoan == "-")
                            ketqua = so1 - so2;
                        else
                        {
                            if (pheptoan == "x")
                                ketqua = so1 * so2;
                            else
                                ketqua = so1 / so2;
                        }
                    }
                    this.tb_PhepTinh.Text = null;
                    this.tb_PhepTinh.Text += ketqua.ToString();
                    this.tb_PhepTinh.Text += "+";
                }
                else
                {
                    this.tb_PhepTinh.Text = this.tb_KetQua.Text;
                    this.tb_PhepTinh.Text += "+";
                }
            }
            this.tb_KetQua.Text = null;
        }

        private void bt_Tru_Click(object sender, EventArgs e)
        {
            if (this.tb_KetQua.Text.Length > 0)
            {
                if (this.tb_PhepTinh.Text.Length > 0)
                {
                    double ketqua;
                    double so2 = Convert.ToDouble(this.tb_KetQua.Text);
                    int dodai = this.tb_PhepTinh.Text.Length;
                    string chuoi = this.tb_PhepTinh.Text;
                    string chuoitam = null;
                    string pheptoan = null;
                    for (int i = 0; i < dodai; i++)
                    {
                        if (i < dodai - 1)
                            chuoitam += chuoi[i];
                        else
                            pheptoan += chuoi[i];
                    }
                    double so1 = Convert.ToDouble(chuoitam);
                    if (pheptoan == "+")
                        ketqua = so1 + so2;
                    else
                    {
                        if (pheptoan == "-")
                            ketqua = so1 - so2;
                        else
                        {
                            if (pheptoan == "x")
                                ketqua = so1 * so2;
                            else
                                ketqua = so1 / so2;
                        }
                    }
                    this.tb_PhepTinh.Text = null;
                    this.tb_PhepTinh.Text += ketqua.ToString();
                    this.tb_PhepTinh.Text += "-";
                }
                else
                {
                    this.tb_PhepTinh.Text = this.tb_KetQua.Text;
                    this.tb_PhepTinh.Text += "-";
                }
            }
            this.tb_KetQua.Text = null;
        }

        private void bt_Nhan_Click(object sender, EventArgs e)
        {
            if(this.tb_KetQua.Text.Length > 0)
            {
                if (this.tb_PhepTinh.Text.Length > 0)
                {
                    double ketqua;
                    double so2 = Convert.ToDouble(this.tb_KetQua.Text);
                    int dodai = this.tb_PhepTinh.Text.Length;
                    string chuoi = this.tb_PhepTinh.Text;
                    string chuoitam = null;
                    string pheptoan = null;
                    for (int i = 0; i < dodai; i++)
                    {
                        if (i < dodai - 1)
                            chuoitam += chuoi[i];
                        else
                            pheptoan += chuoi[i];
                    }
                    double so1 = Convert.ToDouble(chuoitam);
                    if (pheptoan == "+")
                        ketqua = so1 + so2;
                    else
                    {
                        if (pheptoan == "-")
                            ketqua = so1 - so2;
                        else
                        {
                            if (pheptoan == "x")
                                ketqua = so1 * so2;
                            else
                                ketqua = so1 / so2;
                        }
                    }
                    this.tb_PhepTinh.Text = null;
                    this.tb_PhepTinh.Text += ketqua.ToString();
                    this.tb_PhepTinh.Text += "x";
                }
                else
                {
                    this.tb_PhepTinh.Text = this.tb_KetQua.Text;
                    this.tb_PhepTinh.Text += "x";
                }
            }
            this.tb_KetQua.Text = null;
        }

        private void bt_Bang_Click(object sender, EventArgs e)
        {
            if(this.tb_PhepTinh.Text.Length > 0)
            {
                if(this.tb_KetQua.Text.Length > 0)
                {
                    double ketqua;
                    double so2 = Convert.ToDouble(this.tb_KetQua.Text);
                    int dodai = this.tb_PhepTinh.Text.Length;
                    string chuoi = this.tb_PhepTinh.Text;
                    string chuoitam = null;
                    string pheptoan = null;
                    for (int i = 0; i < dodai; i++)
                    {
                        if (i < dodai - 1)
                            chuoitam += chuoi[i];
                        else
                            pheptoan += chuoi[i];
                    }
                    double so1 = Convert.ToDouble(chuoitam);
                    if (pheptoan == "+")
                        ketqua = so1 + so2;
                    else
                    {
                        if (pheptoan == "-")
                            ketqua = so1 - so2;
                        else
                        {
                            if (pheptoan == "x")
                                ketqua = so1 * so2;
                            else
                                ketqua = so1 / so2;
                        }
                    }
                    this.tb_PhepTinh.Text = null;
                    this.tb_KetQua.Text = ketqua.ToString();
                }
                else
                {
                    int dodai = this.tb_PhepTinh.Text.Length;
                    string chuoi = this.tb_PhepTinh.Text;
                    string chuoitam = null;
                    for (int i = 0; i < dodai - 1; i++)
                        chuoitam += chuoi[i];
                    this.tb_KetQua.Text = chuoitam;
                    this.tb_PhepTinh.Text = null;
                }
            }
        }

        private void bt_XoaKiTu_Click(object sender, EventArgs e)
        {
            int ChieuDai = this.tb_KetQua.Text.Length;
            string Chuoi = this.tb_KetQua.Text;
            string ChuoiMoi = null;
            for (int i = 0; i < ChieuDai - 1; i++)
                ChuoiMoi += Chuoi[i];
            this.tb_KetQua.Text = ChuoiMoi;
        }

        private void bt_C_Click(object sender, EventArgs e)
        {
            this.tb_PhepTinh.Text = null;
            this.tb_KetQua.Text = null;
            b = false;
            this.groupBox1.Text = null;
            Mem = 0;
        }

        private void bt_BinhPhuong_Click(object sender, EventArgs e)
        {
            if (this.tb_KetQua.Text.Length > 0)
            {
                double temp1 = 0;
                double temp2 = Convert.ToDouble(this.tb_KetQua.Text);
                temp1 = temp2 * temp2;
                this.tb_KetQua.Text = temp1.ToString();
            }
        }

        private void bt_CongTru_Click(object sender, EventArgs e)
        {
            if(this.tb_KetQua.Text.Length > 0)
            {
                double temp = Convert.ToDouble(this.tb_KetQua.Text);
                temp = -temp;
                this.tb_KetQua.Text = temp.ToString();
            }
        }

        private void bt_CE_Click(object sender, EventArgs e)
        {
            this.tb_KetQua.Text = null;
        }

        private void bt_PhanX_Click(object sender, EventArgs e)
        {
            if (this.tb_KetQua.Text.Length > 0)
            {
                double temp1 = 0;
                double temp2 = Convert.ToDouble(this.tb_KetQua.Text);
                if (temp2 == 0)
                {
                    MessageBox.Show("Can't devide by zero", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.tb_KetQua.Text = null;
                }
                else
                    temp1 = 1 / temp2;
                this.tb_KetQua.Text = temp1.ToString();
            }
        }

        private void bt_CanBacHai_Click(object sender, EventArgs e)
        {
            if (this.tb_KetQua.Text.Length > 0)
            {
                double temp1 = 0;
                double temp2 = Convert.ToDouble(this.tb_KetQua.Text);
                temp1 = Math.Sqrt(temp2);
                this.tb_KetQua.Text = temp1.ToString();
            }
        }

        private void bt_MCong_Click(object sender, EventArgs e)
        {
            if (b)
            {
                Mem += Convert.ToDouble(this.tb_KetQua.Text);
                this.label1.Text = Mem.ToString();
            }
        }

        private void bt_MC_Click(object sender, EventArgs e)
        {
            b = true;
            this.groupBox1.Text = "M";
        }

        private void bt_MTru_Click(object sender, EventArgs e)
        {
            if (b)
            {
                Mem -= Convert.ToDouble(this.tb_KetQua.Text);
                this.label1.Text = Mem.ToString();
            }
        }

        private void bt_MR_Click(object sender, EventArgs e)
        {
            if (b)
                this.tb_KetQua.Text = Mem.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_PhanTram_Click(object sender, EventArgs e)
        {
            if (this.tb_KetQua.Text.Length > 0 && this.tb_PhepTinh.Text.Length > 0)
            {
                int dodai = this.tb_PhepTinh.Text.Length;
                string chuoi = this.tb_PhepTinh.Text;
                string chuoitam = null;
                for (int i = 0; i < dodai - 1; i++)
                    chuoitam += chuoi[i];
                double so1 = Convert.ToDouble(chuoitam);
                double so2 = Convert.ToDouble(this.tb_KetQua.Text);
                double ketqua = so1 * (so2 / 100);
                this.tb_KetQua.Text = ketqua.ToString();
            }
        }
    }
}
