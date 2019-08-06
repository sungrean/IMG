using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace IMG128
{
    public static class tools
    {
        //StructToBytes
        public static byte[] StructToBytes(object obj)
        {
            int rawsize = Marshal.SizeOf(obj);
            IntPtr buffer = Marshal.AllocHGlobal(rawsize);
            Marshal.StructureToPtr(obj, buffer, false);
            byte[] rawdatas = new byte[rawsize];
            Marshal.Copy(buffer, rawdatas, 0, rawsize);
            Marshal.FreeHGlobal(buffer);
            return rawdatas;
        }
        //BytesToStruct
        public static object BytesToStruct(byte[] buf, int len, Type type)
        {
            object rtn;
            IntPtr buffer = Marshal.AllocHGlobal(len);
            Marshal.Copy(buf, 0, buffer, len);
            rtn = Marshal.PtrToStructure(buffer, type);
            Marshal.FreeHGlobal(buffer);
            return rtn;
        }
        //提取字符串中前部数字部分
        public static  string GetNumber(string str)
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

        #region 属性定义
        //获取输出引脚属性
        public static bool IS_OUTPUT_NO(TYPE_OUTPUT outputMode) { return TYPE_OUTPUT.OUTPUT_NO == (TYPE_OUTPUT)((UInt32)outputMode & 0x0001); }
        public static bool IS_OUTPUT_NC(TYPE_OUTPUT outputMode) { return TYPE_OUTPUT.OUTPUT_NC == (TYPE_OUTPUT)((UInt32)outputMode & 0x0001); }
        public static bool IS_OUTPUT_PASS(TYPE_OUTPUT outputMode) { return TYPE_OUTPUT.OUTPUT_PASS == (TYPE_OUTPUT)((UInt32)outputMode & (UInt32)TYPE_OUTPUT.OUTPUT_PASS); }
        public static bool IS_OUTPUT_FAIL(TYPE_OUTPUT outputMode) { return TYPE_OUTPUT.OUTPUT_FAIL == (TYPE_OUTPUT)((UInt32)outputMode & (UInt32)TYPE_OUTPUT.OUTPUT_FAIL); }
        public static bool IS_OUTPUT_ANY(TYPE_OUTPUT outputMode) { return TYPE_OUTPUT.OUTPUT_ANY == (TYPE_OUTPUT)((UInt32)outputMode & (UInt32)TYPE_OUTPUT.OUTPUT_ANY); }
        public static bool IS_OUTPUT_ING_FIRST(TYPE_OUTPUT outputMode) { return TYPE_OUTPUT.OUTPUT_IGN_FIRST == (TYPE_OUTPUT)((UInt32)outputMode & (UInt32)TYPE_OUTPUT.OUTPUT_IGN_FIRST); }
        public static bool IS_OUTPUT_ING_LEARN(TYPE_OUTPUT outputMode) { return TYPE_OUTPUT.OUTPUT_IGN_LEARN == (TYPE_OUTPUT)((UInt32)outputMode & (UInt32)TYPE_OUTPUT.OUTPUT_IGN_LEARN); }
        public static bool IS_OUTPUT_SEN_EN(TYPE_OUTPUT outputMode) { return TYPE_OUTPUT.OUTPUT_SEN_EN == (TYPE_OUTPUT)((UInt32)outputMode & (UInt32)TYPE_OUTPUT.OUTPUT_SEN_EN); }

        //获取输入引脚属性
        public static bool IS_INPUT_EDGE(TYPE_INPUT input) { return 0 == ((UInt32)input & (UInt32)TYPE_INPUT.INPUT_TRIG); }
        public static bool IS_INPUT_LEVEL(TYPE_INPUT input) { return TYPE_INPUT.INPUT_TRIG == (TYPE_INPUT)((UInt32)input & (UInt32)TYPE_INPUT.INPUT_TRIG); }
        public static bool IS_INPUT_LEARN(TYPE_INPUT input) { return TYPE_INPUT.INPUT_LEARN == (TYPE_INPUT)((UInt32)input & 0x0006); }
        public static bool IS_INPUT_FIRING(TYPE_INPUT input) { return TYPE_INPUT.INPUT_FIRING == (TYPE_INPUT)((UInt32)input & 0x0006); }
        public static bool IS_INPUT_SETUP(TYPE_INPUT input) { return TYPE_INPUT.INPUT_SETUP == (TYPE_INPUT)((UInt32)input & 0x0006); }
        public static bool IS_INPPUT_POS(TYPE_INPUT input) { return TYPE_INPUT.INPUT_POS == (TYPE_INPUT)((UInt32)input & (UInt32)TYPE_INPUT.INPUT_POS); }
        public static bool IS_INPPUT_NEG(TYPE_INPUT input) { return TYPE_INPUT.INPUT_NEG == (TYPE_INPUT)((UInt32)input & (UInt32)TYPE_INPUT.INPUT_NEG); }

        //获取检测模式
        public static bool IS_ANAL_CORE_POS(ANAL_TYPE type) { return (UInt32)ANAL_TYPE.ANAL_CORE_POS == ((UInt32)type & (UInt32)ANAL_TYPE.ANAL_CORE_POS); }
        public static bool IS_ANAL_CORE_WIDTH(ANAL_TYPE type) { return (UInt32)ANAL_TYPE.ANAL_CORE_WIDTH == ((UInt32)type & (UInt32)ANAL_TYPE.ANAL_CORE_WIDTH); }
        public static bool IS_ANAL_SEAL_POS(ANAL_TYPE type) { return (UInt32)ANAL_TYPE.ANAL_SEAL_POS == ((UInt32)type & (UInt32)ANAL_TYPE.ANAL_SEAL_POS); }
        public static bool IS_ANAL_SEAL_WIDTH(ANAL_TYPE type) { return (UInt32)ANAL_TYPE.ANAL_SEAL_WIDTH == ((UInt32)type & (UInt32)ANAL_TYPE.ANAL_SEAL_WIDTH); }
        public static bool IS_ANAL_STRIP_POS(ANAL_TYPE type) { return (UInt32)ANAL_TYPE.ANAL_STRIP_POS == ((UInt32)type & (UInt32)ANAL_TYPE.ANAL_STRIP_POS); }
        public static bool IS_ANAL_STRIP_LEN(ANAL_TYPE type) { return (UInt32)ANAL_TYPE.ANAL_STRIP_LEN == ((UInt32)type & (UInt32)ANAL_TYPE.ANAL_STRIP_LEN); }
        public static bool IS_ANAL_SPLAY(ANAL_TYPE type) { return (UInt32)ANAL_TYPE.ANAL_SPLAY == ((UInt32)type & (UInt32)ANAL_TYPE.ANAL_SPLAY); }
        public static bool IS_ANAL_SEAL(ANAL_TYPE type) { return (UInt32)ANAL_TYPE.ANAL_SEAL == ((UInt32)type & (UInt32)ANAL_TYPE.ANAL_SEAL); }
        #endregion
    }
}
