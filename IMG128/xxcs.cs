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
    public partial class xxcs : UserControl
    {
        public xxcs()
        {
            InitializeComponent();
        }

        private void GBoxModel1_Enter(object sender, EventArgs e)
        {

        }

        public WIRE_SETTING_T GetWIRE_SETTING()
        {
            WIRE_SETTING_T wire = new WIRE_SETTING_T();
            //wire[1]   能不能将控件做成数组？这样就可以用for循环，就不用以下拷贝代码

            UInt32 type = 0;
            if (true == ckBoxCorePos.Checked)
                type |= (UInt32)ANAL_TYPE.ANAL_CORE_POS;
            if (true == ckBoxSeal.Checked)
                type |= (UInt32)ANAL_TYPE.ANAL_SEAL_POS;
            if (true == ckBoxStripPos.Checked)
                type |= (UInt32)ANAL_TYPE.ANAL_STRIP_POS;
            if (true == ckBoxCoreWidth.Checked)
                type |= (UInt32)ANAL_TYPE.ANAL_CORE_WIDTH;
            if (true == ckBoxSealWidth.Checked)
                type |= (UInt32)ANAL_TYPE.ANAL_SEAL_WIDTH;
            if (true == ckBoxStripLen.Checked)
                type |= (UInt32)ANAL_TYPE.ANAL_STRIP_LEN;
            if (true == ckBoxSplay.Checked)
                type |= (UInt32)ANAL_TYPE.ANAL_SPLAY;
            if (true == ckBoxSeal.Checked)
                type |= (UInt32)ANAL_TYPE.ANAL_SEAL;
            wire.tol.analEN = (ANAL_TYPE)type;

            wire.tol.sealPosP = Convert.ToSingle(GetNumber(tBoxSealPosP.Text));		//mm
            wire.tol.sealPosN = Convert.ToSingle(GetNumber(tBoxSealPosN.Text));		//mm
            wire.tol.corePosP = Convert.ToSingle(GetNumber(tBoxCorePosP.Text));		//mm
            wire.tol.corePosN = Convert.ToSingle(GetNumber(tBoxCorePosN.Text));		//mm
            wire.tol.stripPosP = Convert.ToSingle(GetNumber(tBoxStripPosP.Text));		//mm
            wire.tol.stripPosN = Convert.ToSingle(GetNumber(tBoxStripPosN.Text));		//mm
            wire.tol.stripLenP = Convert.ToSingle(GetNumber(tBoxStripLenP.Text));		//mm
            wire.tol.stripLenN = Convert.ToSingle(GetNumber(tBoxStripLenN.Text));		//mm

            wire.tol.sealWidthP = Convert.ToSingle(GetNumber(tBoxSealWidthP.Text));	//%
            wire.tol.sealWidthN = Convert.ToSingle(GetNumber(tBoxSealWidthN.Text));	//%
            wire.tol.coreWidthP = Convert.ToSingle(GetNumber(tBoxCoreWidthP.Text));	//%
            wire.tol.coreWidthN = Convert.ToSingle(GetNumber(tBoxCoreWidthN.Text));	//%

            wire.tol.wireSplay = Convert.ToSingle(GetNumber(tBoxSprayP.Text));		    //%

            wire.tol.variationFilter = Convert.ToSingle(GetNumber(tBoxVariationFilter.Text));//mm
            wire.tol.sealRatio = Convert.ToSingle(GetNumber(tBoxSealRatio.Text));		//%
            wire.tol.sealLimit = Convert.ToSingle(GetNumber(tBoxSealLimit.Text));		//%
            wire.tol.stripLimit = Convert.ToSingle(GetNumber(tBoxStripLimit.Text));	//%
            return wire;
        }

        //提取字符串中前部数字部分
        private string GetNumber(string str)
        {
            int len = str.Length;
            int i;
            for (i = 0; i < len; i++)
                if (((str[i] < '0') || (str[i] > '9')) && (str[i] != '.'))
                    break;
            if (i > 0)
                str = str.Substring(0, i);
            else
                str = "0";
            return str;
        }

        private void GBoxModel2_Enter(object sender, EventArgs e)
        {

        }
    }
}
