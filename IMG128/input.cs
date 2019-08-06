using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IMG128
{
    public partial class input : UserControl
    {
        public input()
        {
            InitializeComponent();
        }
        public void updateShow(TYPE_INPUT inputs)
        {
            if (tools.IS_INPUT_LEARN(inputs))
                cBoxInputModeLvl.Text = "进入学习模式";
            else if (tools.IS_INPUT_FIRING(inputs))
                cBoxInputModeLvl.Text = "触发采样";
            else if (tools.IS_INPUT_SETUP(inputs))
                cBoxInputModeLvl.Text = "进入设置模式";
            if (tools.IS_INPPUT_POS(inputs))
                cBoxInputPolLvl.Text = "上升沿触发";
            else
                cBoxInputPolLvl.Text = "下降沿触发";
        }
        public UInt32 updateInfo()          //更新设置时通过控件获取信息
        {
            UInt32 input = 0;
            if (cBoxInputModeLvl.Text == "进入学习模式")
                input |= (UInt32)TYPE_INPUT.INPUT_LEARN;
            else if (cBoxInputModeLvl.Text == "触发采样")
                input |= (UInt32)TYPE_INPUT.INPUT_FIRING;
            else if (cBoxInputModeLvl.Text == "进入设置模式")
                input |= (UInt32)TYPE_INPUT.INPUT_SETUP;

            if (cBoxInputPolLvl.Text == " 上升沿触发")
                input |= (UInt32)TYPE_INPUT.INPUT_POS;
            else if (cBoxInputPolLvl.Text == "下降沿触发")
                input |= (UInt32)TYPE_INPUT.INPUT_NEG;
            return input;
        }
        private void Input_Load(object sender, EventArgs e)
        {

        }
    }
}
