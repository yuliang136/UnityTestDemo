using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game_Platform
{

    public class GAME_PLATFORM
    {
        public const string LOCAL_NET = "LOCAL_NET";
        public const string OUTER_NET = "OUTER_NET";

        //appstore
        public const string APPSTORE = "APPSTORE";        //1
        public const string JTZLWS = "JTZLWS";         //即拓2
        public const string JTJZCBP = "JTJZCBP";         //即拓
        public const string JTRXLJ = "JTRXLJ";
        public const string JTJSBY = "JTJSBY";
        public const string JTZLZT = "JTZLZT";
        public const string JTLJLM = "JTLJLM";
        public const string JTFHSG = "JTFHSG";  //即拓烽火三国
        public const string JTWSZJ = "JTWSZJ";  //即拓无双战将
        public const string JTLZWS = "JTLZWS";  //即拓
        public const string JTWHLJ = "JTWHLJ";  //即拓 卧虎龙将
		public const string JTJLXJ = "JTJLXJ";
        public const string IHXSG = "IHXSG";
        public const string JTJZJS = "JTJZJS";        //即拓剑指江山
        public const string IJTTWCBZZ = "IJTTWCBZZ";        // 即拓三國台灣
        public const string ZYTWYLBY = "ZYTWYLBY";        // 掌娱台湾御龍霸業
        public const string CXSGZJ = "CXSGZJ";        // 创星三国战记
        public const string CXRXSG = "CXRXSG";        // 创星热血三国
        public const string CXBWSG = "CXBWSG";        // 创星霸王三国
        public const string QWJGSG = "QWJGSG";        // 抢玩 金戈三国
        public const string RFQJSG = "RFQJSG";        // 热锋 权将三国
        public const string RFQHSG = "RFQHSG";        // 热锋 奇幻三国

        public const string TYSGWS = "TYSGWS";        //探娱三国之武圣春秋
        public const string TYSGLJ = "TYSGLJ";        //探娱三国龙将传

        public const string JSQQ = "JSQQ";  // 9377街霸天下
        public const string JSZSGYX = "JSZSGYX";  // 9377 真三国英雄
        public const string JSSGZFY = "JSSGZFY";  // 9377 三国志风云
        public const string JSJBSG = "JSJBSG";  // 9377 街霸三国
        public const string JSSGZB = "JSSGZB";  // 9377 三国争霸
        public const string JSJBTX = "JSJBTX";  // 9377 三国争霸

        public const string BMSSSGZ = "BMSSSGZ";  //白马 盛世三国传

        public const string CLZLZY = "CLZLZY";  // 苍鸾 逐鹿中原
        public const string JXYLSG = "JXYLSG";  // 景讯 御龙三国
        public const string JXYLTX = "JXYLTX";  // 景讯 御龙天下
        public const string JXSGQXZ = "JXSGQXZ";  //景讯 三国群雄传
        public const string JXSGJSLM = "JXSGJSLM";   //景讯 三国军师联盟
        public const string JXLZSG = "JXLZSG";   //景讯 龙战三国

        public const string HMSGLTCQ = "HMSGLTCQ";  // HIMA 三国腾龙传奇
        public const string HMSGJJTX = "HMSGJJTX";  // HIMA 三国军机天下
        public const string HMSGMNCL = "HMSGMNCL";  // HIMA 三国模拟策略游戏

        public const string WYSBSG = "WYSBSG";  // 微赢 神兵三国
        public const string WYSBYL = "WYSBYL";  // 微赢 神兵御龙
        public const string WYRXSGBZ = "WYRXSGBZ";  // 微赢 热血三国霸者
        public const string WYSGYLZ = "WYSGYLZ";  // 微赢 群英三国

        public const string MFYLSGZ = "MFYLSGZ";  // 墨菲 御龍三国志
        public const string QLYLLD = "QLYLLD";  // 麒麟游 御龙乱斗
        public const string QLSGZWS = "QLSGZWS";  // 麒麟游 三国战无双
        public const string QLWSJX = "QLWSJX";  // 麒麟游 武神觉醒
        public const string QLQMDSG = "QLQMDSG";  // 麒麟游 全民斗三国
        public const string CASGZY = "CASGZY";  // 超爱玩 三国之赵云超神
        public const string KYLJSG = "KYLJSG";  //  阔游 龙将三国
        public const string QKSGWSDJS = "QKSGWSDJS";  // 7k7k三国武圣斗军师
        public const string KCYLFYSG = "KCYLFYSG";  // 快船	御龙风云三国
        public const string KCZZRXSG = "KCZZRXSG";  // 快船	征战热血三国

        public const string ZJLSYX = "ZJLSYX";  // 指尖三国·乱世英雄

        public const string YMLTWS = "YMLTWS";  //游码 龙腾无双
        public const string YMASCL = "YMASCL";  //游码 傲视苍龙
        public const string YMZTFW = "YMZTFW";  //游码 征天凤舞
        public const string YMFCZH = "YMFCZH";  //游码 凤雏之魂

        public const string LYSGCLLM = "LYSGCLLM";  //乐游 三国策略联盟
        public const string LYSGWS = "LYSGWS";  //乐游 三国无双
        public const string LYSGY = "LYSGY";  //乐游 三国1

        public const string BYSGYLZ = "BYSGYLZ";   //北游 三国御龙传
        public const string BYYLBY = "BYYLBY";   //北游 御龙霸业
        public const string BYSGYLWS = "BYSGYLWS";   //北游 三国御龙无双
        public const string BYYLTX = "BYYLTX";   //北游 御龙天下
        public const string BYSGSJWS = "BYSGSJWS";   //北游 三国神将无双
        public const string BYSGYLKP = "BYSGYLKP";   //北游 三国御龙卡牌
        public const string BYDHSGZ = "BYDHSGZ";   //北游 大话三国志

        public const string QYSGKX = "QYSGKX";   //淸源 三国狂想
        public const string QYHDSG = "QYHDSG";   //清源 混沌三国

        public const string HFDWZY = "HFDWZY";   //汉风 帝王之业
        public const string HFLSRY = "HFLSRY";   //汉风 乱世荣耀
        public const string HFQYTX = "HFQYTX";   //汉风 权御天下
        public const string HFSGQYLM = "HFSGQYLM";   //汉风 三国群英联
        public const string HFHMTX = "HFHMTX";   //汉风 汉末天下
        public const string HFLSFY = "HFLSFY";   //汉风 乱世风云

        public const string BFSGKPQYZ = "BFSGKPQYZ";   //不凡 三国卡牌群英传

        public const string TRYLSG = "TRYLSG";   //天睿 御龙三国


        // 越狱
        public const string PP = "PP";                     //3
        public const string XY = "XY";                     //4
        public const string TB = "TB";                     // 同步推5
        public const string BD = "BD";                     // 91 baidu6
        public const string KY = "KY";                     // 快用7
        public const string HM = "HM";                     // 海马8
        public const string I4 = "I4";                     // 爱思9
        public const string IT = "IT";                     // ITOOLS10
        public const string GP = "GP";                     //叉叉助手果盘11
        public const string IGA = "IGA";                    //官方越狱12
        public const string YYAPPS = "YYAPPS";                 //YY玩13
        public const string WSSGZ = "WSSGZ";                  //无双三国志14
        public const string JTCBZZ = "JTCBZZ";                 //即拓赤壁之战15
        public const string JTSGBY = "JTSGBY";                // 三国霸业
        public const string JTCB = "JTCB";
        public const string WYAPPS = "WYAPPS";
        // 安卓
        public const string QH = "QH";                 // 360            
        public const string ABD = "ABD";                // 安卓百度
        public const string MI = "MI";                 //小米
        public const string WDJ = "WDJ";                //豌豆荚
        public const string UC = "UC";
        public const string HW = "HW";             // 华为
        public const string LX = "LX";             // LENOVO
        public const string JL = "JL";             //金立
        public const string OP = "OP";             //OPPO
        public const string VV = "VV";             // VIVO
        public const string KP = "KP";             // 酷派
        public const string DX = "DX";             //电信爱游戏
        public const string YYB = "YYB";            //应用宝
        public const string DL = "DL";             //当乐
        public const string PPS = "PPS";            //
        public const string BF = "BF";             // 暴风影音
        public const string AZ = "AZ";             // 安智
        public const string EW = "EW";         //益玩
        public const string MZW = "MZW";        //拇指玩
        public const string PJ = "PJ";             //泡椒
        public const string Y49 = "Y49";        //49游
        public const string SG = "SG";         //搜狗
        public const string YM = "YM";         //有米
        public const string HTC = "HTC";
        public const string YYH = "YYH";        //应用汇
        public const string ND = "ND";         //N多
        public const string M43 = "M43";       //4399
        public const string JF = "JF";         //机锋
        public const string YK = "YK";         //优酷
        public const string PPTV = "PPTV";
        public const string MZ = "MZ";         //魅族
        public const string AGP = "AGP";         //安卓叉叉助手果盘
        public const string SY37 = "SY37";         //37游
        public const string AIT = "AIT";        //itools安卓
        public const string LS = "LS";         //乐视
        public const string SYB = "SYB";        //手游吧
        public const string MG = "MG";         //咪咕游戏
        public const string TTYY = "TTYY";       //TT语音
        public const string AHM = "AHM";        //海马安卓
        public const string CCZS = "CCZS";       //虫虫助手
        public const string AGA = "AGA";        //官方安卓
        public const string PYW = "PYW";        //朋友玩
        public const string KPZS = "KPZS";       //靠谱助手
        public const string LY = "LY";         //麟游
        public const string QMZS = "QMZS";       //全民助手
        public const string SW = "SW";         //顺网
        public const string LB = "LB";         //猎宝网
        public const string QMYX = "QMYX";       //全民游戏
        public const string YX = "YX";         //游侠
        public const string YAYADZR = "YAYADZR";   //丫丫玩_帝之刃
        public const string YAYAQMGC = "YAYAQMGC";   //丫丫玩_全名攻城
        public const string YAYAYLWS = "YAYAYLWS";   //丫丫玩_御龙无双
        public const string YAYAQYDSG = "YAYAQYDSG";  //丫丫玩_群英大三国
        public const string JTRXWS = "JTRXWS"; // 即拓热血武圣 后改名为即拓御龙无双
        public const string HXYLWS = "HXYLWS";      // 浩信御龙无双
        public const string HXYLCPSSH = "HXYLCPSSH";    // 浩信御龙无双CPS神话
        public const string JLYLSW = "JLYLSW";      // 金立御龙无双
        public const string YIJIE = "YIJIE";    //易接
        public const string AZYTWYLBY = "AZYTWYLBY";      // 掌娱台湾御龙霸业
        public const string ACXRXSG = "ACXRXSG";        // Android 创星热血三国
        public const string HXBMYLWS = "HXBMYLWS";      //浩信白马御龙无双官方
    }

    public enum PLAT_COIN_TYPE
    {
        MONEY = 0,
        YUANBAO,
    }

    public class PlatEventType
    {
        public static string GAME_LOAD_START = "game_load_start";
        public static string DECOMPRESS_START = "decompress_start";
        public static string DECOMPRESS_END = "decompress_end";
        public static string UPDATE_START = "update_start";
        public static string UPDATE_END = "update_end";
        public static string GAME_LOAD_END = "game_load_end";
        public static string LOGIN_START = "login_start";
        public static string LOGIN_END = "login_end";
        public static string PROLOGUE_START = "prologue_start";
        public static string PROLOGUE_END = "prologue_end";
        public static string CREATE_ROLE_START = "create_role_start";
        public static string CREATE_ROLE_END = "create_role_end";
        public static string GUIDE_START = "guide_{0}_start";
        public static string GUIDE_END = "guide_{0}_end";
        public static string PLOT1_THEY_SHOW = "plot1_they_show"; //三人出现
        public static string PLOT1_FIGHT_START = "plot1_fight_start";   //战斗开始
        public static string PLOT1_COMBO_SHOW = "plot1_combo_show"; //组合技表演
        public static string PLOT1_FIGHT_END = "plot1_fight_end";   //战斗结束
        public static string PLOT1_TAOTIE_SHOW = "plot1_taotie_show";   //饕餮出场
        public static string PLOT1_TAOTIE_KILL_THEM = "plot1_taotie_kill_them"; //三人被饕餮击败
        public static string PLOT1_YAZI_SHOW = "plot1_yazi_show";   //睚眦出场
        public static string PLOT1_BOMB_DONE = "plot1_bomb_done";   //炸房子结束
    }
}
