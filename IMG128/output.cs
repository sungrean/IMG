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
    public partial class output : UserControl
    {
        public output()
        {
            InitializeComponent();
        }
        public void updateShow(CFG_T cfg)
        {
            TYPE_OUTPUT outputs = cfg.outputMode[0];
            if (tools.IS_OUTPUT_NO(outputs))
                rBtnNO.Checked = true;
            else
                rBtnNC.Checked = true;
            if (tools.IS_OUTPUT_PASS(outputs))
                cBoxOutMode.Text = "合格品输出脉冲";
            else if (tools.IS_OUTPUT_FAIL(outputs))
                cBoxOutMode.Text = "不良品输出脉冲";
            else if (tools.IS_OUTPUT_ANY(outputs))
                cBoxOutMode.Text = "合格/不良品都输出脉冲";
            if (tools.IS_OUTPUT_ING_FIRST(outputs))
                rBtnIgnoreFirst.Checked = true;
            else if (tools.IS_OUTPUT_ING_LEARN(outputs))
                rBtnIgnoreLearn.Checked = true;
            else
                rBtnNormal.Checked = true;
            tBoxOutDelay.Text = cfg.outputDelay[1].ToString();
            tBoxDuration.Text = cfg.outputWidth[1].ToString();
        }

        public UInt32 getOutputMode()
        {
            UInt32 outputs = 0;
            if (rBtnNC.Checked)
                outputs |= (UInt32)TYPE_OUTPUT.OUTPUT_NC;
            if (cBoxOutMode.Text == "合格品输出脉冲")
                outputs |= (UInt32)TYPE_OUTPUT.OUTPUT_PASS;
            else if (cBoxOutMode.Text == "不良品输出脉冲")
                outputs |= (UInt32)TYPE_OUTPUT.OUTPUT_FAIL;
            else if (cBoxOutMode.Text == "合格/不良品都输出脉冲")
                outputs |= (UInt32)TYPE_OUTPUT.OUTPUT_ANY;
            if (rBtnIgnoreFirst.Checked)
                outputs |= (UInt32)TYPE_OUTPUT.OUTPUT_IGN_FIRST;
            else if (rBtnIgnoreLearn.Checked)
                outputs |= (UInt32)TYPE_OUTPUT.OUTPUT_IGN_LEARN;
            return outputs;
        }
        private void Output_Load(object sender, EventArgs e)
        {
             
        }
    }
}
