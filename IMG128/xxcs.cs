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
            if (true == ckBoxCorePos2.Checked)
                type |= (UInt32)ANAL_TYPE.ANAL_CORE_POS;
            if (true == ckBoxSeal2.Checked)
                type |= (UInt32)ANAL_TYPE.ANAL_SEAL_POS;
            if (true == ckBoxStripPos2.Checked)
                type |= (UInt32)ANAL_TYPE.ANAL_STRIP_POS;
            if (true == ckBoxCoreWidth2.Checked)
                type |= (UInt32)ANAL_TYPE.ANAL_CORE_WIDTH;
            if (true == ckBoxSealWidth2.Checked)
                type |= (UInt32)ANAL_TYPE.ANAL_SEAL_WIDTH;
            if (true == ckBoxStripLen2.Checked)
                type |= (UInt32)ANAL_TYPE.ANAL_STRIP_LEN;
            if (true == ckBoxSplay2.Checked)
                type |= (UInt32)ANAL_TYPE.ANAL_SPLAY;
            if (true == ckBoxSeal2.Checked)
                type |= (UInt32)ANAL_TYPE.ANAL_SEAL;
            wire.tol.analEN = (ANAL_TYPE)type;

            wire.tol.sealPosP = Convert.ToSingle(GetNumber(tBoxSealPosP2.Text));		//mm
            wire.tol.sealPosN = Convert.ToSingle(GetNumber(tBoxSealPosN2.Text));		//mm
            wire.tol.corePosP = Convert.ToSingle(GetNumber(tBoxCorePosP2.Text));		//mm
            wire.tol.corePosN = Convert.ToSingle(GetNumber(tBoxCorePosN2.Text));		//mm
            wire.tol.stripPosP = Convert.ToSingle(GetNumber(tBoxStripPosP2.Text));		//mm
            wire.tol.stripPosN = Convert.ToSingle(GetNumber(tBoxStripPosN2.Text));		//mm
            wire.tol.stripLenP = Convert.ToSingle(GetNumber(tBoxStripLenP2.Text));		//mm
            wire.tol.stripLenN = Convert.ToSingle(GetNumber(tBoxStripLenN2.Text));		//mm

            wire.tol.sealWidthP = Convert.ToSingle(GetNumber(tBoxSealWidthP2.Text));	//%
            wire.tol.sealWidthN = Convert.ToSingle(GetNumber(tBoxSealWidthN2.Text));	//%
            wire.tol.coreWidthP = Convert.ToSingle(GetNumber(tBoxCoreWidthP2.Text));	//%
            wire.tol.coreWidthN = Convert.ToSingle(GetNumber(tBoxCoreWidthN2.Text));	//%

            wire.tol.wireSplay = Convert.ToSingle(GetNumber(tBoxSprayP2.Text));		    //%

            wire.tol.variationFilter = Convert.ToSingle(GetNumber(tBoxVariationFilter2.Text));//mm
            wire.tol.sealRatio = Convert.ToSingle(GetNumber(tBoxSealRatio2.Text));		//%
            wire.tol.sealLimit = Convert.ToSingle(GetNumber(tBoxSealLimit2.Text));		//%
            wire.tol.stripLimit = Convert.ToSingle(GetNumber(tBoxStripLimit2.Text));	//%
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
