using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DS4Key
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string fangkuang;
        string sanjiao;
        string cha;
        string yuan;
        string L1;
        string L2;
        string L3;
        string R1;
        string R2;
        string R3;
        string TP;
        string PS;
        string OPTION;
        string SHARE;
        string TempT;
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fangkuang = comboBox1.SelectedItem.ToString();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            sanjiao = comboBox2.SelectedItem.ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cha = comboBox3.SelectedItem.ToString();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            yuan = comboBox4.SelectedItem.ToString();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            L1 = comboBox5.SelectedItem.ToString();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            L2 = comboBox6.SelectedItem.ToString();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            R1 = comboBox7.SelectedItem.ToString();
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            R2 = comboBox8.SelectedItem.ToString();
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            L3 = comboBox9.SelectedItem.ToString();
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            R3 = comboBox10.SelectedItem.ToString();
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            TP = comboBox11.SelectedItem.ToString();
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            PS = comboBox12.SelectedItem.ToString();
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            OPTION = comboBox13.SelectedItem.ToString();
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            SHARE = comboBox14.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Check = fangkuang+sanjiao+yuan+cha+L1+L2+L3+R1+R2+R3+TP+PS+OPTION+SHARE;
                string she = "射击/Shooting";
                string ge = "格斗/Melee";
                string pen = "喷射/Boost";
                string qie = "切锁/Target";
                string tong = "通信/Start";

                if (!Check.Contains(she) || !Check.Contains(ge) || !Check.Contains(pen) ||!Check.Contains(qie) || !Check.Contains(tong))
                    throw new Exception();

                string DS4Key;
                textBox1.Clear();

                string A = "A = ";
                string B = "B = ";
                string C = "C = ";
                string D = "D = ";
                string S = "Start = ";
                string CO = "Coin = ";
                string CD = "Card = ";
                string TE = "Test = ";

                /*    射击/Shooting 格斗/Melee 喷射/Boost 切锁/Target 副射/SubShooting 特射/SpecialShooting 特格/SpecialMelee 觉醒/EX-BURST 通信/Start test 刷卡/Card 无/None    */
                #region 框
                if (fangkuang == "射击/Shooting")
                {
                    TempT = "1,";
                    A += TempT;
                }
                else if (fangkuang == "格斗/Melee")
                {
                    TempT = "1,";
                    B += TempT;
                }
                else if (fangkuang == "喷射/Boost")
                {
                    TempT = "1,";
                    C += TempT;
                }
                else if (fangkuang == "切锁/Target")
                {
                    TempT = "1,";
                    D += TempT;
                }
                else if (fangkuang == "副射/SubShooting")
                {
                    TempT = "1,";
                    A += TempT;
                    B += TempT;
                }
                else if (fangkuang == "特射/SpecialShooting")
                {
                    TempT = "1,";
                    A += TempT;
                    C += TempT;
                }
                else if (fangkuang == "特格/SpecialMelee")
                {
                    TempT = "1,";
                    B += TempT;
                    C += TempT;
                }
                else if (fangkuang == "觉醒/EX-BURST")
                {
                    TempT = "1,";
                    A += TempT;
                    B += TempT;
                    C += TempT;
                }
                else if (fangkuang == "通信/Start")
                {
                    TempT = "1,";
                    S += TempT;
                }
                else if (fangkuang == "test")
                {
                    TempT = "1,";
                    TE += TempT;
                }
                else if (fangkuang == "刷卡/Card")
                {
                    TempT = "1,";
                    CD += TempT;
                }
                else if (fangkuang == "投币/Coin")
                {
                    TempT = "1,";
                    CO += TempT;
                }
                else { }
                #endregion
                #region 角
                if (sanjiao == "射击/Shooting")
                {
                    TempT = "4,";
                    A += TempT;
                }
                else if (sanjiao == "格斗/Melee")
                {
                    TempT = "4,";
                    B += TempT;
                }
                else if (sanjiao == "喷射/Boost")
                {
                    TempT = "4,";
                    C += TempT;
                }
                else if (sanjiao == "切锁/Target")
                {
                    TempT = "4,";
                    D += TempT;
                }
                else if (sanjiao == "副射/SubShooting")
                {
                    TempT = "4,";
                    A += TempT;
                    B += TempT;
                }
                else if (sanjiao == "特射/SpecialShooting")
                {
                    TempT = "4,";
                    A += TempT;
                    C += TempT;
                }
                else if (sanjiao == "特格/SpecialMelee")
                {
                    TempT = "4,";
                    B += TempT;
                    C += TempT;
                }
                else if (sanjiao == "觉醒/EX-BURST")
                {
                    TempT = "4,";
                    A += TempT;
                    B += TempT;
                    C += TempT;
                }
                else if (sanjiao == "通信/Start")
                {
                    TempT = "4,";
                    S += TempT;
                }
                else if (sanjiao == "test")
                {
                    TempT = "4,";
                    TE += TempT;
                }
                else if (sanjiao == "刷卡/Card")
                {
                    TempT = "4,";
                    CD += TempT;
                }
                else if (sanjiao == "投币/Coin")
                {
                    TempT = "4,";
                    CO += TempT;
                }
                else { }
                #endregion
                #region 圆
                if (yuan == "射击/Shooting")
                {
                    TempT = "3,";
                    A += TempT;
                }
                else if (yuan == "格斗/Melee")
                {
                    TempT = "3,";
                    B += TempT;
                }
                else if (yuan == "喷射/Boost")
                {
                    TempT = "3,";
                    C += TempT;
                }
                else if (yuan == "切锁/Target")
                {
                    TempT = "3,";
                    D += TempT;
                }
                else if (yuan == "副射/SubShooting")
                {
                    TempT = "3,";
                    A += TempT;
                    B += TempT;
                }
                else if (yuan == "特射/SpecialShooting")
                {
                    TempT = "3,";
                    A += TempT;
                    C += TempT;
                }
                else if (yuan == "特格/SpecialMelee")
                {
                    TempT = "3,";
                    B += TempT;
                    C += TempT;
                }
                else if (yuan == "觉醒/EX-BURST")
                {
                    TempT = "3,";
                    A += TempT;
                    B += TempT;
                    C += TempT;
                }
                else if (yuan == "通信/Start")
                {
                    TempT = "3,";
                    S += TempT;
                }
                else if (yuan == "test")
                {
                    TempT = "3,";
                    TE += TempT;
                }
                else if (yuan == "刷卡/Card")
                {
                    TempT = "3,";
                    CD += TempT;
                }
                else if (yuan == "投币/Coin")
                {
                    TempT = "3,";
                    CO += TempT;
                }
                else { }
                #endregion
                #region 叉
                if (cha == "射击/Shooting")
                {
                    TempT = "2,";
                    A += TempT;
                }
                else if (cha == "格斗/Melee")
                {
                    TempT = "2,";
                    B += TempT;
                }
                else if (cha == "喷射/Boost")
                {
                    TempT = "2,";
                    C += TempT;
                }
                else if (cha == "切锁/Target")
                {
                    TempT = "2,";
                    D += TempT;
                }
                else if (cha == "副射/SubShooting")
                {
                    TempT = "2,";
                    A += TempT;
                    B += TempT;
                }
                else if (cha == "特射/SpecialShooting")
                {
                    TempT = "2,";
                    A += TempT;
                    C += TempT;
                }
                else if (cha == "特格/SpecialMelee")
                {
                    TempT = "2,";
                    B += TempT;
                    C += TempT;
                }
                else if (cha == "觉醒/EX-BURST")
                {
                    TempT = "2,";
                    A += TempT;
                    B += TempT;
                    C += TempT;
                }
                else if (cha == "通信/Start")
                {
                    TempT = "2,";
                    S += TempT;
                }
                else if (cha == "test")
                {
                    TempT = "2,";
                    TE += TempT;
                }
                else if (cha == "刷卡/Card")
                {
                    TempT = "2,";
                    CD += TempT;
                }
                else if (cha == "投币/Coin")
                {
                    TempT = "2,";
                    CO += TempT;
                }
                else { }
                #endregion
                #region L1
                if (L1 == "射击/Shooting")
                {
                    TempT = "5,";
                    A += TempT;
                }
                else if (L1 == "格斗/Melee")
                {
                    TempT = "5,";
                    B += TempT;
                }
                else if (L1 == "喷射/Boost")
                {
                    TempT = "5,";
                    C += TempT;
                }
                else if (L1 == "切锁/Target")
                {
                    TempT = "5,";
                    D += TempT;
                }
                else if (L1 == "副射/SubShooting")
                {
                    TempT = "5,";
                    A += TempT;
                    B += TempT;
                }
                else if (L1 == "特射/SpecialShooting")
                {
                    TempT = "5,";
                    A += TempT;
                    C += TempT;
                }
                else if (L1 == "特格/SpecialMelee")
                {
                    TempT = "5,";
                    B += TempT;
                    C += TempT;
                }
                else if (L1 == "觉醒/EX-BURST")
                {
                    TempT = "5,";
                    A += TempT;
                    B += TempT;
                    C += TempT;
                }
                else if (L1 == "通信/Start")
                {
                    TempT = "5,";
                    S += TempT;
                }
                else if (L1 == "test")
                {
                    TempT = "5,";
                    TE += TempT;
                }
                else if (L1 == "刷卡/Card")
                {
                    TempT = "5,";
                    CD += TempT;
                }
                else if (L1 == "投币/Coin")
                {
                    TempT = "5,";
                    CO += TempT;
                }
                else { }
                #endregion
                #region L2
                if (L2 == "射击/Shooting")
                {
                    TempT = "7,";
                    A += TempT;
                }
                else if (L2 == "格斗/Melee")
                {
                    TempT = "7,";
                    B += TempT;
                }
                else if (L2 == "喷射/Boost")
                {
                    TempT = "7,";
                    C += TempT;
                }
                else if (L2 == "切锁/Target")
                {
                    TempT = "7,";
                    D += TempT;
                }
                else if (L2 == "副射/SubShooting")
                {
                    TempT = "7,";
                    A += TempT;
                    B += TempT;
                }
                else if (L2 == "特射/SpecialShooting")
                {
                    TempT = "7,";
                    A += TempT;
                    C += TempT;
                }
                else if (L2 == "特格/SpecialMelee")
                {
                    TempT = "7,";
                    B += TempT;
                    C += TempT;
                }
                else if (L2 == "觉醒/EX-BURST")
                {
                    TempT = "7,";
                    A += TempT;
                    B += TempT;
                    C += TempT;
                }
                else if (L2 == "通信/Start")
                {
                    TempT = "7,";
                    S += TempT;
                }
                else if (L2 == "test")
                {
                    TempT = "7,";
                    TE += TempT;
                }
                else if (L2 == "刷卡/Card")
                {
                    TempT = "7,";
                    CD += TempT;
                }
                else if (L2 == "投币/Coin")
                {
                    TempT = "7,";
                    CO += TempT;
                }
                else { }
                #endregion
                #region L3
                if (L3 == "射击/Shooting")
                {
                    TempT = "11,";
                    A += TempT;
                }
                else if (L3 == "格斗/Melee")
                {
                    TempT = "11,";
                    B += TempT;
                }
                else if (L3 == "喷射/Boost")
                {
                    TempT = "11,";
                    C += TempT;
                }
                else if (L3 == "切锁/Target")
                {
                    TempT = "11,";
                    D += TempT;
                }
                else if (L3 == "副射/SubShooting")
                {
                    TempT = "11,";
                    A += TempT;
                    B += TempT;
                }
                else if (L3 == "特射/SpecialShooting")
                {
                    TempT = "11,";
                    A += TempT;
                    C += TempT;
                }
                else if (L3 == "特格/SpecialMelee")
                {
                    TempT = "11,";
                    B += TempT;
                    C += TempT;
                }
                else if (L3 == "觉醒/EX-BURST")
                {
                    TempT = "11,";
                    A += TempT;
                    B += TempT;
                    C += TempT;
                }
                else if (L3 == "通信/Start")
                {
                    TempT = "11,";
                    S += TempT;
                }
                else if (L3 == "test")
                {
                    TempT = "11,";
                    TE += TempT;
                }
                else if (L3 == "刷卡/Card")
                {
                    TempT = "11,";
                    CD += TempT;
                }
                else if (L3 == "投币/Coin")
                {
                    TempT = "11,";
                    CO += TempT;
                }
                else { }
                #endregion
                #region R1
                if (R1 == "射击/Shooting")
                {
                    TempT = "6,";
                    A += TempT;
                }
                else if (R1 == "格斗/Melee")
                {
                    TempT = "6,";
                    B += TempT;
                }
                else if (R1 == "喷射/Boost")
                {
                    TempT = "6,";
                    C += TempT;
                }
                else if (R1 == "切锁/Target")
                {
                    TempT = "6,";
                    D += TempT;
                }
                else if (R1 == "副射/SubShooting")
                {
                    TempT = "6,";
                    A += TempT;
                    B += TempT;
                }
                else if (R1 == "特射/SpecialShooting")
                {
                    TempT = "6,";
                    A += TempT;
                    C += TempT;
                }
                else if (R1 == "特格/SpecialMelee")
                {
                    TempT = "6,";
                    B += TempT;
                    C += TempT;
                }
                else if (R1 == "觉醒/EX-BURST")
                {
                    TempT = "6,";
                    A += TempT;
                    B += TempT;
                    C += TempT;
                }
                else if (R1 == "通信/Start")
                {
                    TempT = "6,";
                    S += TempT;
                }
                else if (R1 == "test")
                {
                    TempT = "6,";
                    TE += TempT;
                }
                else if (R1 == "刷卡/Card")
                {
                    TempT = "6,";
                    CD += TempT;
                }
                else if (R1 == "投币/Coin")
                {
                    TempT = "6,";
                    CO += TempT;
                }
                else { }
                #endregion
                #region R2
                if (R2 == "射击/Shooting")
                {
                    TempT = "8,";
                    A += TempT;
                }
                else if (R2 == "格斗/Melee")
                {
                    TempT = "8,";
                    B += TempT;
                }
                else if (R2 == "喷射/Boost")
                {
                    TempT = "8,";
                    C += TempT;
                }
                else if (R2 == "切锁/Target")
                {
                    TempT = "8,";
                    D += TempT;
                }
                else if (R2 == "副射/SubShooting")
                {
                    TempT = "8,";
                    A += TempT;
                    B += TempT;
                }
                else if (R2 == "特射/SpecialShooting")
                {
                    TempT = "8,";
                    A += TempT;
                    C += TempT;
                }
                else if (R2 == "特格/SpecialMelee")
                {
                    TempT = "8,";
                    B += TempT;
                    C += TempT;
                }
                else if (R2 == "觉醒/EX-BURST")
                {
                    TempT = "8,";
                    A += TempT;
                    B += TempT;
                    C += TempT;
                }
                else if (R2 == "通信/Start")
                {
                    TempT = "8,";
                    S += TempT;
                }
                else if (R2 == "test")
                {
                    TempT = "8,";
                    TE += TempT;
                }
                else if (R2 == "刷卡/Card")
                {
                    TempT = "8,";
                    CD += TempT;
                }
                else if (R2 == "投币/Coin")
                {
                    TempT = "8,";
                    CO += TempT;
                }
                else { }
                #endregion
                #region R3
                if (R3 == "射击/Shooting")
                {
                    TempT = "12,";
                    A += TempT;
                }
                else if (R3 == "格斗/Melee")
                {
                    TempT = "12,";
                    B += TempT;
                }
                else if (R3 == "喷射/Boost")
                {
                    TempT = "12,";
                    C += TempT;
                }
                else if (R3 == "切锁/Target")
                {
                    TempT = "12,";
                    D += TempT;
                }
                else if (R3 == "副射/SubShooting")
                {
                    TempT = "12,";
                    A += TempT;
                    B += TempT;
                }
                else if (R3 == "特射/SpecialShooting")
                {
                    TempT = "12,";
                    A += TempT;
                    C += TempT;
                }
                else if (R3 == "特格/SpecialMelee")
                {
                    TempT = "12,";
                    B += TempT;
                    C += TempT;
                }
                else if (R3 == "觉醒/EX-BURST")
                {
                    TempT = "12,";
                    A += TempT;
                    B += TempT;
                    C += TempT;
                }
                else if (R3 == "通信/Start")
                {
                    TempT = "12,";
                    S += TempT;
                }
                else if (R3 == "test")
                {
                    TempT = "12,";
                    TE += TempT;
                }
                else if (R3 == "刷卡/Card")
                {
                    TempT = "12,";
                    CD += TempT;
                }
                else if (R3 == "投币/Coin")
                {
                    TempT = "12,";
                    CO += TempT;
                }
                else { }
                #endregion
                #region PS
                if (PS == "射击/Shooting")
                {
                    TempT = "13,";
                    A += TempT;
                }
                else if (PS == "格斗/Melee")
                {
                    TempT = "13,";
                    B += TempT;
                }
                else if (PS == "喷射/Boost")
                {
                    TempT = "13,";
                    C += TempT;
                }
                else if (PS == "切锁/Target")
                {
                    TempT = "13,";
                    D += TempT;
                }
                else if (PS == "副射/SubShooting")
                {
                    TempT = "13,";
                    A += TempT;
                    B += TempT;
                }
                else if (PS == "特射/SpecialShooting")
                {
                    TempT = "13,";
                    A += TempT;
                    C += TempT;
                }
                else if (PS == "特格/SpecialMelee")
                {
                    TempT = "13,";
                    B += TempT;
                    C += TempT;
                }
                else if (PS == "觉醒/EX-BURST")
                {
                    TempT = "13,";
                    A += TempT;
                    B += TempT;
                    C += TempT;
                }
                else if (PS == "通信/Start")
                {
                    TempT = "13,";
                    S += TempT;
                }
                else if (PS == "test")
                {
                    TempT = "13,";
                    TE += TempT;
                }
                else if (PS == "刷卡/Card")
                {
                    TempT = "13,";
                    CD += TempT;
                }
                else if (PS == "投币/Coin")
                {
                    TempT = "13,";
                    CO += TempT;
                }
                else { }
                #endregion
                #region OPTION
                if (OPTION == "射击/Shooting")
                {
                    TempT = "10,";
                    A += TempT;
                }
                else if (OPTION == "格斗/Melee")
                {
                    TempT = "10,";
                    B += TempT;
                }
                else if (OPTION == "喷射/Boost")
                {
                    TempT = "10,";
                    C += TempT;
                }
                else if (OPTION == "切锁/Target")
                {
                    TempT = "10,";
                    D += TempT;
                }
                else if (OPTION == "副射/SubShooting")
                {
                    TempT = "10,";
                    A += TempT;
                    B += TempT;
                }
                else if (OPTION == "特射/SpecialShooting")
                {
                    TempT = "10,";
                    A += TempT;
                    C += TempT;
                }
                else if (OPTION == "特格/SpecialMelee")
                {
                    TempT = "10,";
                    B += TempT;
                    C += TempT;
                }
                else if (OPTION == "觉醒/EX-BURST")
                {
                    TempT = "10,";
                    A += TempT;
                    B += TempT;
                    C += TempT;
                }
                else if (OPTION == "通信/Start")
                {
                    TempT = "10,";
                    S += TempT;
                }
                else if (OPTION == "test")
                {
                    TempT = "10,";
                    TE += TempT;
                }
                else if (OPTION == "刷卡/Card")
                {
                    TempT = "10,";
                    CD += TempT;
                }
                else if (OPTION == "投币/Coin")
                {
                    TempT = "10,";
                    CO += TempT;
                }
                else { }
                #endregion
                #region SHARE
                if (SHARE == "射击/Shooting")
                {
                    TempT = "9,";
                    A += TempT;
                }
                else if (SHARE == "格斗/Melee")
                {
                    TempT = "9,";
                    B += TempT;
                }
                else if (SHARE == "喷射/Boost")
                {
                    TempT = "9,";
                    C += TempT;
                }
                else if (SHARE == "切锁/Target")
                {
                    TempT = "9,";
                    D += TempT;
                }
                else if (SHARE == "副射/SubShooting")
                {
                    TempT = "9,";
                    A += TempT;
                    B += TempT;
                }
                else if (SHARE == "特射/SpecialShooting")
                {
                    TempT = "9,";
                    A += TempT;
                    C += TempT;
                }
                else if (SHARE == "特格/SpecialMelee")
                {
                    TempT = "9,";
                    B += TempT;
                    C += TempT;
                }
                else if (SHARE == "觉醒/EX-BURST")
                {
                    TempT = "9,";
                    A += TempT;
                    B += TempT;
                    C += TempT;
                }
                else if (SHARE == "通信/Start")
                {
                    TempT = "9,";
                    S += TempT;
                }
                else if (SHARE == "test")
                {
                    TempT = "9,";
                    TE += TempT;
                }
                else if (SHARE == "刷卡/Card")
                {
                    TempT = "9,";
                    CD += TempT;
                }
                else if (SHARE == "投币/Coin")
                {
                    TempT = "9,";
                    CO += TempT;
                }
                else { }
                #endregion
                #region TP
                if (TP == "射击/Shooting")
                {
                    TempT = "14,";
                    A += TempT;
                }
                else if (TP == "格斗/Melee")
                {
                    TempT = "14,";
                    B += TempT;
                }
                else if (TP == "喷射/Boost")
                {
                    TempT = "14,";
                    C += TempT;
                }
                else if (TP == "切锁/Target")
                {
                    TempT = "14,";
                    D += TempT;
                }
                else if (TP == "副射/SubShooting")
                {
                    TempT = "14,";
                    A += TempT;
                    B += TempT;
                }
                else if (TP == "特射/SpecialShooting")
                {
                    TempT = "14,";
                    A += TempT;
                    C += TempT;
                }
                else if (TP == "特格/SpecialMelee")
                {
                    TempT = "14,";
                    B += TempT;
                    C += TempT;
                }
                else if (TP == "觉醒/EX-BURST")
                {
                    TempT = "14,";
                    A += TempT;
                    B += TempT;
                    C += TempT;
                }
                else if (TP == "通信/Start")
                {
                    TempT = "14,";
                    S += TempT;
                }
                else if (TP == "test")
                {
                    TempT = "14,";
                    TE += TempT;
                }
                else if (TP == "刷卡/Card")
                {
                    TempT = "14,";
                    CD += TempT;
                }
                else if (TP == "投币/Coin")
                {
                    TempT = "14,";
                    CO += TempT;
                }
                else { }
                #endregion

                DS4Key = A + "\r\n" + B + "\r\n" + C + "\r\n" + D + "\r\n" + S + "\r\n" + CO + "\r\n" + CD + "\r\n" + TE + "\r\n";
                DS4Key=DS4Key.Replace(",\r\n", "\r\n");

                textBox1.Text = DS4Key;
            }
            catch (Exception)
            {
                textBox1.Text = "射击、格斗、喷射、切锁、通信 \r\n键位不能为空！\r\n \r\nShooting、Melee、Boost、Target、Start \r\nmust keys assigned!";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
