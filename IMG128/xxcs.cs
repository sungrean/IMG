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
        public void ShowWIRE_SETTING(WIRE_SETTING_T wire)
        {

            //检测模式
            ANAL_TYPE type = wire.tol.analEN;
            ckBoxCorePos.Checked = tools.IS_ANAL_CORE_POS(type);
            ckBoxCoreWidth.Checked = tools.IS_ANAL_CORE_WIDTH(type);
            ckBoxSealPos.Checked = tools.IS_ANAL_SEAL_POS(type);
            ckBoxSealWidth.Checked = tools.IS_ANAL_SEAL_WIDTH(type);
            ckBoxStripPos.Checked = tools.IS_ANAL_STRIP_POS(type);
            ckBoxStripLen.Checked = tools.IS_ANAL_STRIP_LEN(type);
            ckBoxSplay.Checked = tools.IS_ANAL_SPLAY(type);
            //ckBoxSeal.Checked = tools.IS_ANAL_SEAL(type);
            ckBoxSeal.Checked = tools.IS_ANAL_IS_SEAL(type);
            ckBoxSealOri.Checked = tools.IS_ANAL_SEAL_ORI(type);
            //检测参数设置
            tBoxCorePosN.Text = wire.tol.corePosN.ToString() + "mm";
            tBoxCorePosP.Text = wire.tol.corePosP.ToString() + "mm";
            tBoxSealPosN.Text = wire.tol.sealPosN.ToString() + "mm";
            tBoxSealPosP.Text = wire.tol.sealPosP.ToString() + "mm";
            tBoxStripPosN.Text = wire.tol.stripPosN.ToString() + "mm";
            tBoxStripPosP.Text = wire.tol.stripPosP.ToString() + "mm";
            tBoxStripLenN.Text = wire.tol.stripLenN.ToString() + "mm";
            tBoxStripLenP.Text = wire.tol.stripLenP.ToString() + "mm";
            tBoxCoreWidthN.Text = wire.tol.coreWidthN.ToString() + "%";
            tBoxCoreWidthP.Text = wire.tol.coreWidthP.ToString() + "%";
            tBoxSealWidthN.Text = wire.tol.sealWidthN.ToString() + "%";
            tBoxSealWidthP.Text = wire.tol.sealWidthP.ToString() + "%";
            tBoxVariationFilter.Text = wire.tol.variationFilter.ToString() + "mm";
            tBoxSealLimit.Text = wire.tol.sealLimit.ToString() + "%";
            tBoxStripLimit.Text = wire.tol.stripLimit.ToString() + "%";
            tBoxSealRatio.Text = wire.tol.sealRatio.ToString() + "%";
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
            if (true == ckBoxSeal.Checked)//
                type |= (UInt32)ANAL_TYPE.ANAL_IS_SEAL;
            if (true == ckBoxSealOri.Checked)//
                type |= (UInt32)ANAL_TYPE.ANAL_SEAL_ORI;
            wire.tol.analEN = (ANAL_TYPE)type;

            wire.tol.sealPosP = Convert.ToSingle(tools.GetNumber(tBoxSealPosP.Text));		//mm
            wire.tol.sealPosN = Convert.ToSingle(tools.GetNumber(tBoxSealPosN.Text));		//mm
            wire.tol.corePosP = Convert.ToSingle(tools.GetNumber(tBoxCorePosP.Text));		//mm
            wire.tol.corePosN = Convert.ToSingle(tools.GetNumber(tBoxCorePosN.Text));		//mm
            wire.tol.stripPosP = Convert.ToSingle(tools.GetNumber(tBoxStripPosP.Text));		//mm
            wire.tol.stripPosN = Convert.ToSingle(tools.GetNumber(tBoxStripPosN.Text));		//mm
            wire.tol.stripLenP = Convert.ToSingle(tools.GetNumber(tBoxStripLenP.Text));		//mm
            wire.tol.stripLenN = Convert.ToSingle(tools.GetNumber(tBoxStripLenN.Text));		//mm

            wire.tol.sealWidthP = Convert.ToSingle(tools.GetNumber(tBoxSealWidthP.Text));	//%
            wire.tol.sealWidthN = Convert.ToSingle(tools.GetNumber(tBoxSealWidthN.Text));	//%
            wire.tol.coreWidthP = Convert.ToSingle(tools.GetNumber(tBoxCoreWidthP.Text));	//%
            wire.tol.coreWidthN = Convert.ToSingle(tools.GetNumber(tBoxCoreWidthN.Text));	//%

            wire.tol.wireSplay = Convert.ToSingle(tools.GetNumber(tBoxSprayP.Text));		    //%

            wire.tol.variationFilter = Convert.ToSingle(tools.GetNumber(tBoxVariationFilter.Text));//mm
            wire.tol.sealRatio = Convert.ToSingle(tools.GetNumber(tBoxSealRatio.Text));		//%
            wire.tol.sealLimit = Convert.ToSingle(tools.GetNumber(tBoxSealLimit.Text));		//%
            wire.tol.stripLimit = Convert.ToSingle(tools.GetNumber(tBoxStripLimit.Text));	//%
            return wire;
        }


        private void GBoxModel2_Enter(object sender, EventArgs e)
        {

        }
    }
}
