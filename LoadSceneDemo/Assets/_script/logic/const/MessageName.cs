using System;

public struct MessageName
{
    //public const string MN_EVENT = "SgEvent";

    public const string MN_SCENE_CREATE_COMPLETE = "SceneCreateComplete";     //场景加载完成 
    public const string MN_SCENE_LOADING_PROGRESS = "SceneLoadingProgress";   //场景加载进度
    public const string MN_BATTLE_SHOW_GO = "BattleShowGo"; //战斗场景显示go按钮    
    public const string MN_BATTLE_SHOW_FIGHT = "BattleShowFight";   //战斗场景显示战斗按钮
    public const string MN_MAIN_CIYT_STATE = "MainCityState";//建筑模型显示状态
    public const string MN_BATTLE_SUMMON = "BattleSummon";  // 召唤兽
    public const string MN_BATTLE_TRIGGER_SUMMON = "BattleTriggerSummon"; //触发召唤兽特效
    public const string MN_SHAKE_NIAN_SHOU_BTN = "ShakeNianShouBtn";//年兽按钮震动
    public const string MN_BATTLE_CLOSE = "BattleClose"; //关闭战斗界面
    public const string MN_BATTLE_UI_VISIBLE = "BattleUIVisible"; //设置战斗界面是否可见
    public const string MN_BATTLE_COMBO_SHOW_NAME = "BattleComboShowName";  // 组合技显示名字
    public const string MN_BATTLE_COMBO_CHG_HP = "BattleComboChgHP";  // 组合技生命改变
    public const string MN_BATTLE_TIME_SPEED_CHG = "BattleTimeSpeedChg";    //游戏速度改变
    public const string MN_COMBOSHOW_LEFT_SELECT = "ComboShowLeftSelect";       //组合技展示选择
    public const string MN_BATTLE_INPUT_POS = "BattleInputPos";  // 战斗输入位置变化
    public const string MN_BATTLE_INPUT_TARGET = "BattleInputTarget";  // 战斗输入目标变化
    public const string MN_RACE_COUNTDOWN = "RaceCountDown"; //赛马倒计时
    public const string MN_RACE_START = "RaceStart"; //赛马开始
    public const string MN_RACE_END = "RaceEnd"; //赛马结束
    public const string MN_RACE_LAP_CHG = "RaceLapChg"; //赛马换圈
    public const string MN_RACE_MONSTAER_AHEAD = "RaceMonsterAhead"; //赛马机关兽超过玩家
    public const string MN_RACE_BATTLE_UI_VISIBLE = "RaceBattleUIVisible"; //设置战斗界面是否可见
    public const string MN_RACE_RESET = "MN_RACE_RESET";//购买赛马次数

    public const string MN_SIGN_REFRESH = "MN_SignAwardRefresh";//签到数据刷新
    public const string MN_SIGNAWARD_CHG = "MN_SignAwardChg";//签到数据变化
    public const string MN_ADD_PROMPT = "addPrompts";
    public const string MN_TALKPROMPT_OPEN = "TalkPromptOpen";
    public const string MN_WARLORDS_TALK_STATE_CHG = "WarlordsTalkStateChg";

    public const string MN_INTENSIFY_POINT_CHG = "IntensifyPointChg";//强化石数量改变
    public const string MN_SKILLPOINT_CHG = "skillPointChg";      //技能点改变
    public const string MN_SOUL_CHG = "soulChg";//将魂数量改变
    public const string MN_MONEY_CHG = "moneyChg";//银两,元宝变化
    public const string MN_DOUBI_CHG = "doubiChg";//斗币变化
    public const string MN_TOC_MONEY_CHG = "tocMoneyChg";//边关币变化
    public const string MN_GUILD_MONEY_CHG = "guildMoneyChg";//军团币变化
    public const string MN_DAIBI_CHG = "daibiChg";//行商币变化
    public const string MN_VIGOR_CHG = "vigorChg";      //体力精力改变
    public const string MN_DAOBI_CHG = "daobiChg";      //刀币变化
    public const string MN_YUBI_CHG = "yubiChg";        //玉币变化
    public const string MN_SANDCOIN_CHG = "sandCoinChg";//沙场币变化
    public const string MN_FEATS_CHG = "featsChg";//功勋变化
    public const string MN_ZHANHUN_CHG = "zhanHunChg";//战魂变化
    public const string MN_ACHIEVE_CHG = "NtfAchieveChg";//通知成就信息变化
    public const string MN_DAILY_CHG = "ntf_activity_chg";//通知每日活动变化
    public const string MN_ACHIEVE_AWARD_NFT = "Activitie_award_notice";//每日活动/成绩获得奖励通知
    public const string MN_BAG_ITEM_SELL_OK = "BagItemSellOK";//物品出售成功
    public const string MN_BAG_ITEM_USE_OK = "BagItemUseOK";//物品使用成功
    public const string MN_BAG_ITEM_RES_OK = "BagItemResolveOK";//物品分解成功
    public const string MN_BAG_ITEM_CHG = "BagItemChg";//背包物品有变化
    public const string MN_ROLE_CHG = "RoleChg";//信息发生变化的武将
    public const string MN_ROLE_POWER_CHG = "RolePowerChg";
    public const string MN_ROLE_UPSTAR_OK = "RoleUpStarOK";
    public const string MN_ROLE_UPEXP_OK = "RoleUpExpOK";
    public const string MN_ROLE_CALL_OK = "RoleCallOK";//武将召唤成功
    public const string MN_ROLE_EXP_CHG = "RoleExpChg";//武将经验发生变化
    public const string MN_ROLE_STAGE_OK = "RoleStageOK";//武将升阶成功
    public const string MN_ROLE_IMPROVE_GUANZHI = "RoleImproveGuanZhi";//武将升级官职成功
    public const string MN_ROLE_SHOW_CHG = "RoleShowChg";//武将是否显示模型
    public const string MN_ROLE_SHOW_UI_CHG = "RoleShowUIChg";
    public const string MN_ROLE_UP_STAR_SUCC = "RoleUpStarSucc";
    public const string MN_ROLE_GO_TO_ANIM = "RoleGoToAnim";
    public const string MN_ROLE_CAMERA_CHG_BEFORE_SHOW_UI = "RoleCameraChgBeforeShowUI";
    public const string MN_ROLE_CAMERA_SHAKE = "RoleCameraShake";
    public const string MN_ROLE_UP_SKILL_OK = "RoleUpSkillOK";//武将升级技能成功
    public const string MN_ROLE_SELECTED_SKILL_CHANGE = "RoleSelectedSkillChange";//切换选中武将技能
    public const string MN_ROLE_CHANGE = "RoleChange";//切换武将
    public const string MN_ROLE_CHANGE_OVER = "RoleChangeOver";//切换武将完毕
    public const string MN_DONT_CLEAR_HIRE_INFO = "";//不清除雇佣武将信息
    public const string MN_USERNAME_CHANGE = "UserNameChange";//主公昵称修改成功
    public const string MN_MAIN_TOP_SHOW_TYPE = "OnlyShowVigor";//顶部显示图标类型
    public const string MN_IS_FULL_SCREEN = "isFullScreen";//是否显示全屏窗口
    public const string MN_CLEAR_MESSAGE = "clearMessage";//清除浮动提示
    public const string MN_USER_LV_UP = "UserLvUp";//主公升级
    public const string MN_RIGHT_MENU_STATE = "RightMenuState";//左侧菜单显示状态
    public const string MN_RIGHT_MENU_SHOW = "RightMenuStateShow";
    public const string MN_TOP_STATE = "TopState";//顶部显示状态
    public const string MN_EAT_CHG = "eatChg";//吃饭状态变化
    public const string MN_ZHAOCAI_RESULT = "zhaocai_result";//招财的结果
    public const string MN_ZHAOCAI_CHG = "ntf_zhaocai_chg";//招财次数变化
    public const string MN_RANKING_LIST = "ranking_list";
    public const string MN_DEFEND_ROLE_INFO = "defend_wujiang_info";//玩家的防守信息
    public const string MN_ARENA_PERSONAL_PANEL = "arena_personal_panel";//竞技场个人面板信息
    public const string MN_ARENA_BUY_TIMES = "arena_buy_times";//竞技场购买次数
    public const string MN_ARENA_RESET_COOL = "arena_reset_cool";//重置竞技场失败冷却CD
    public const string MN_RAID_BUY_TIMES = "raid_buy_times";//抢夺购买次数
    public const string MN_ARENA_REFRESH_RIVAL = "arena_refresh_rival";//刷新对手
    public const string MN_ARENA_FIGHT_RECORD = "arena_fight_record";//对战记录
    public const string MN_ARENA_RECORD_CHANGE = "arena_record_change";//通知查看了对战记录
    public const string MN_MODULE_OPEN_CHG = "module_open_change";
    public const string MN_LOTTERY_RESULT = "LotteryResult";
    public const string MN_CHANGE_UI_LOTTERY_HERO = "ChangeUILotteryHero";//UI_LOTTERY_HERO开启或关闭
    public const string MN_GUILD_LIST = "guild_list";//军团简要列表
    public const string MN_GUILD_CHANG_ICON = "guild_change_ionc";//军团修改头像
    public const string MN_FIND_GUILD = "find_guild";//查找军团
    public const string MN_CREATE_GUILD = "create_guild";//创建军团
    public const string MN_APPLY_GUILD = "apply_guild";//申请入团
    public const string MN_EXAMINE_GUILD = "examine_guild";//审批入团
    public const string MN_GUILD_DETAIL = "MyGuildDetail";
    public const string MN_GUILD_APPLY_LIST = "GuildApplyList";
    public const string MN_GUILD_DETAIL_LIST = "GuildDetailList";//军团成员详细列表
    public const string MN_GUILD_MEMBERKICK_OK = "GuildMemberKickOK";//踢人成功
    public const string MN_JOIN_GUILD = "join_guild";//通知玩家入团
    public const string MN_NO_GUILD = "notHave_guild";//解散/退出军团团成功
    public const string MN_SET_GUILD_OK = "setGuildOK";//军团设置成功
    public const string MN_SET_GUILD_DES = "setGuildDesc";
    public const string MN_GUILD_POST_RENAME_OK = "guildPostRenameOK";//军团职位名称修改成功
    public const string MN_GUILD_POST_RENAME_UPATE = "guildPostRenameUP";//军团职位名称更新
    public const string MN_GUILD_POST_DEPLOY_OK = "guildPostDeployOK";//军团成员职位设置成功
    public const string MN_GUILD_TRNSFER_OK = "guildTrnsferOK";//团长移交成功
    public const string MN_GUILD_TRAVEL_INFO = "guildRoleTravelInfo";//军团武将游历信息
    public const string MN_GUILD_ADD_TRAVEL_ROLE = "guildAddTravelRole";//添加游历的武将
    public const string MN_GUILD_RECALL_ROLE = "guildRecallRole";//召回武将
    public const string MN_GUILD_GET_ENCOUNTER_AWARD = "guildGetEncounterAward";//领取奇遇奖励
    public const string MN_GUILD_WORSHIP_REWARD = "guildWorshipReward";//膜拜奖励
    public const string MN_GUILD_TAKE_REWARD = "guildTakeReward";//膜拜收获奖励
    public const string MN_GUILD_WORSHIP = "guildWorship";//膜拜他人
    public const string MN_GUILD_RED_POINT = "guildRedPoint";//军团红点提示
    public const string MN_GUILD_APPLY_REDDOT = "guildApplyRedDot";//军团申请红点
    public const string MN_GUILD_HIRE_ROLE_LIST = "guildHireRoleList";// 军团可雇佣的武将
    public const string MN_NANMAN_ENTER_BATTLE = "nanmanEnterNanMan";// 进入南蛮副本
    public const string MN_NANMAN_PANEL_INFO = "nanmanPanelInfo";// 南蛮面板信息
    public const string MN_NANMAN_FINISH_COPY = "nanmanFinishCopy"; // 南蛮关卡完成
    public const string MN_GUILD_LOGDATA = "guildlogdata";//军团日志
    public const string MN_GUILD_NAME_CHANGE="guildNameChange";//军团改名成功

    public const string MN_LINEUP_CHG = "LineupChg";//布阵信息变化
    public const string MN_CLEAR_LINEUP = "ClearLineup";//清除布阵
    public const string MN_DO_LINEUP_MAIN_OPEN = "DoLineupMainOpen";//调用LineupMain的open函数
    public const string MN_LINEUP_HIRE_ROLE_CHG = "LineupHireRoleChg";//布阵的雇佣武将变化
    public const string MN_ZHENFA_CHG = "zhenFaDataChg";//阵法数据变化
    public const string MN_ZHENFA_GRID_CHG = "zhenFaGridDataChg";//阵法格子数据变化
    public const string MN_ZHENFA_IMPROVE = "zhenFaImprove";//阵法合成或者修炼

    public const string MN_MANOR_DETAIL = "ManorDetail";
    public const string MN_MANOR_IMPROVE_BUILDING = "ManorImproveBuilding";
    public const string MN_MANOR_GOODSLIST = "ManorGoodsList";
    public const string MN_MANOR_QUERY_TASK = "ManorQueryTask";
    public const string MN_MANOR_TASK_CHG = "ManorTaskChg";
    public const string MN_MANOR_TASK_ROLE = "ManorTaskRole";//给任务选武将
    public const string MN_MANOR_FINI_TASK = "ManorFinishTask";
    public const string MN_MANOR_IMPROVE_OFFICE = "ManorImproveOffice";
    public const string MN_MANOR_SHANGYU_CHG = "ManorShangyuChg";   //商誉值发生改变
    public const string MN_MANOR_SOLDIER_CHG = "ManorSoldierChg";   //领地士兵数量变化
    public const string MN_MANOR_SOLDIER_UPGRADE = "ManorSoldierUpgrade"; //兵种升级
    public const string MN_MANOR_MUBING_CLEAR_CD = "MN_MANOR_MUBING_CLEAR_CD";   //领地募兵清除CD

    public const string MN_WARLORDS_DETAIL = "WarlordsDetail";
    public const string MN_WARLORDS_REPORT_LIST = "WarlordsReport_list";
    public const string MN_WARLORDS_GUILDHURT_RANK_LIST = "WarlordsGuildHurtRankList";
    public const string MN_WARLORDS_USERHURT_RANK_LIST = "WarlordsUserGuildHurtRankList";

    public const string MN_EQUIP_IMPROVE_STAR = "EquipImproveStarOK";//装备升星成功
    public const string MN_EQUIP_IMPROVE_LEVEL_OK = "EquipImproveLevelOK";//装备强化成功
    public const string MN_EQUIP_MULTI_IMPROVE_LEVEL = "EquipMultiImproveLevel";//装备多次强化
    public const string MN_PUTON_EQUIP_RSP = "PutOnEquipRsp"; // 穿戴装备响应
    public const string MN_EQUIP_COMPOUND_SUCC = "equipCompoundSuccess"; // 装备合成成功
    public const string MN_SHOW_ITEM_GLOW_EFFECT = "ShowItemGlow";// 显示装备进阶成功特效
    public const string MN_EQUIP_BATCH_IMPROVE = "EquipBATCHIMPROVE"; // 装备批量强化

    public const string MN_ITEM_COMPOSE = "ItemComposeOK"; // 道具合成成功

    public const string MN_SHOP_CHG = "MN_SHOP_CHG";  //商店数据变化
    public const string MN_SHOP_CHG_INDEX = "MN_SHOP_CHG_INDEX";  //商店单个数据变化
    public const string MN_SHOP_SHOW_DIALOG = "MN_SHOP_SHOW_DIALOG";//商店显示对话

    public const string MN_JIANGHUN_SHOP_CHG = "MN_JIANGHUN_SHOP_CHG";  //将魂商店数据变化
    public const string MN_JIANGHUN_SHOP_CHG_INDEX = "MN_JIANGHUN_SHOP_CHG_INDEX";  //将魂商店单个数据变化
    public const string MN_JIANGHUN_SHOP_SHOW_DIALOG = "MN_JIANGHUN_SHOP_SHOW_DIALOG";//交运商店显示对话

    public const string MN_ARENA_SHOP_CHG = "MN_ARENA_SHOP_CHG";  //竞技场商店数据变化
    public const string MN_ARENA_SHOP_CHG_INDEX = "MN_ARENA_SHOP_CHG_INDEX";  //竞技场商店单个数据变化
    public const string MN_ARENA_SHOP_SHOW_DIALOG = "MN_ARENA_SHOP_SHOW_DIALOG";//竞技场商店显示对话

    public const string MN_TOC_SHOP_CHG = "MN_TOC_SHOP_CHG";    //过关斩将商店数据变化
    public const string MN_TOC_SHOP_CHG_INDEX = "MN_TOC_SHOP_CHG_INDEX";    //过关斩将商店单个数据变化
    public const string MN_TOC_SHOP_SHOW_DIALOG = "MN_TOC_SHOP_SHOW_DIALOG"; //过关斩将商店显示对话

    public const string MN_GUILD_SHOP_CHG = "MN_GUILD_SHOP_CHG";    //军团商店数据变化
    public const string MN_GUILD_SHOP_CHG_INDEX = "MN_GUILD_SHOP_CHG_INDEX";    //军团商店单个数据变化
    public const string MN_GUILD_SHOP_SHOW_DIALOG = "MN_GUILD_SHOP_SHOW_DIALOG"; //军团商店显示对话

    public const string MN_BLACK_SHOP_CHG = "MN_BLACK_SHOP_CHG";    //黑市商店数据变化
    public const string MN_BLACK_SHOP_CHG_INDEX = "MN_BLACK_SHOP_CHG_INDEX";    //黑市商店单个数据变化
    public const string MN_BLACK_SHOP_SHOW_DIALOG = "MN_BLACK_SHOP_SHOW_DIALOG"; //黑市商店显示对话
    public const string MN_BLACK_SHOP_REFRESHTIME = "BlackShopRefreshTime";       //黑市商店刷新时间
    public const string MN_BLACK_MONEY_CHG = "BlackMoneyChg";//黑市商店货币变化
    public const string UI_SHOP_BLACK_POPUR = "UI_SHOP_BLACK_POPUR";
    public const string MN_BLACK_STATE_CHG = "MN_BLACK_STATE_CHG";  

    public const string MN_LIEZHUAN_RSP_INFO = "LieZhuanRspInfo";//三国列传获取信息
    public const string MN_ENTER_LIEZHUAN = "EnterLieZhuan"; // 进入三国列传副本
    public const string MN_FINISH_LIEZHUAN = "FinishLieZhuan"; // 通关三国列传副本
    public const string MN_LIEZHUAN_BUY_LEFT_TIME = "MN_LIEZHUAN_BUY_LEFT_TIME";//列传购买挑战次数

    public const string MN_EMAIL_INIT = "EmailInit";    //初始化邮件列表    
    public const string MN_EMAIL_DELETE = "EmailDelete";    //删除一封邮件    
    public const string MN_EMAIL_ORDER_CHG = "EmailOrderChg"; //邮件列表顺序变化    
    public const string MN_EMAIL_ATTCH_MSG = "EmailAttchMsg"; //领取邮件附件显示获得物品
    public const string MN_EMAIL_CHANGE = "EmailChange";          //邮件发生变化，包括初始化、读取、领取、删除邮件
    public const string MN_EMAIL_READ = "EmailRead";//邮件被读取

    public const string MN_SHOP_REFRESHTIME = "ShopRefreshTime";//商店刷新时间
    public const string MN_ARENA_SHOP_REFRESHTIME = "GuildShopRefreshTime";      //军团商店刷新时间
    public const string MN_GUILD_SHOP_REFRESHTIME = "ArenaShopRefreshTime";      //竞技场商店刷新时间
    public const string MN_JIANGHUN_SHOP_REFRESHTIME = "JianghunShopRefreshTime";      //将魂商店刷新时间
    public const string MN_TOC_SHOP_REFRESHTIME = "TocShopRefreshTime";       //过关斩将刷新时间
    public const string MN_ARENA_NTF_RESULT = "ntf_rival_fight_result";

    public const string MN_COPY_SELECT_COPY = "CopySelectCopy"; // 选择副本
    public const string MN_COPY_SWEEP_RESULT = "CopySweepResult"; // 副本扫荡结果
    public const string MN_COPY_COPY_UPDATE = "CopyUpdate"; // 副本数据更新
    public const string MN_COPY_ENTER = "EnterCopy"; // 进入副本    
    public const string MN_COPY_FINISH = "FinishCopy"; // 副本通关
    public const string MN_COPY_BOX_LIST = "copyboxlist"; // 宝箱列表
    public const string MN_GET_BOX_AWARD = "boxaward";//宝箱奖励
    public const string MN_STAR_CHANGE = "starchange";//星星数改变
    //public const string MN_BATTLE_DROP_LIST = "BattleDropList";//战斗普通掉落    
    //public const string MN_BATTLE_BOSS_DROP_LIST = "BattleBossDropList";//战斗BOSS掉落
    public const string MN_BATTLE_DROP_SHOW_COMPLETE = "BattleDropShowComplete";//战斗掉落显示完成
    public const string MN_BATTLE_PLOT_ROLE = "BattlePlotRole";//战斗剧情角色
    public const string MN_BATTLE_REFLESH_ROLES = "BattleRoleListReflesh";//战斗角色列表更新
    public const string MN_BATTLE_REFLESH_COMBOS = "BattleComboListReflesh";//战斗角色组合技更新

    //public const string MN_TIME_EVENT = "TimeEvent";    // 定时事件
    public const string MN_RIGHT_REDSPOT = "RightRedSpot";         // 右侧红点事件
    //进入竞技场
    public const string MN_ARENA_ENTER = "EnterArena";
    //竞技场战斗完成
    //public const string MN_ARENA_FINISH = "FinishArena";
    //竞技场敌方武将列表
    //public const string MN_ARENA_ENEMY_LIST = "ArenaEnemyList";

    //播放战斗录像
    public const string MN_PLAY_VIDEO = "PlayVideo";
    public const string MN_GET_FIGHT_VIDEO = "GetFightVideo";

    public const string MN_MONEYCOPY_ENTER = "EnterMoneyCopy";
    public const string MN_MONEYCOPY_FINISH = "FinishMoneyCopy";

    public const string MN_TOC_ENTER = "EnterToc";
    public const string MN_TOC_FINISH = "FinishToc";

    public const string MN_GGZJ_ENTER = "EnterGGZJ";
    public const string MN_GGZJ_FINISH = "FinishGGZJ";
    // 功能开放
    //public const string MN_FUNCTION_TRIGGER_LEVEL = "FunctionTriggerLevel"; // 关闭升级提示窗

    //显示聊天消息
    public const string MN_SHOW_CHAT = "ShowChat";
    //选择聊天表情
    public const string MN_SELECT_CHAT_FACE = "SelectChatFace";
    //私聊
    public const string MN_PRIVATE_CHAT = "PrivateChat";

    //创建角色成功
    public const string MN_CREATE_ROLE = "CreateName";
    //获取随机名字
    public const string MN_RADOM_NAME = "RadomName";

    public const string MN_USER_ICON_LIST = "UserIconList";
    public const string MN_USER_ICON_CHANGE = "UserIconChange";
    public const string MN_USER_VIP_CHANGE = "UserVipChange";
    public const string MN_VIP_EXP_CHANGE = "VipExpChange";
    public const string MN_USER_STAMINA_CHANGE = "UserStaminaChange";
    public const string MN_USER_FIGHTWAR_DATA = "UserFightwarData";

    public const string MN_SELECT_ZHENFAID = "SelectZhenfaId";

    public const string MN_WORLD_BOSS_INFO = "WorldBossInfo";
    public const string MN_WORLD_BOSS_ENHANCE_ATK = "WorldBossEnhanceAtk";
    public const string MN_WORLD_BOSS_ENTER = "WorldBossEnter";
    public const string MN_WORLD_BOSS_FINISH = "WorldBossFinish";
    public const string MN_WORLD_BOSS_RANK = "WorldBossRank";
    public const string MN_WORLD_BOSS_YESTERDAY_RANK = "WorldBossYesterdayRank";
    public const string MN_WORLD_BOSS_BUY_FIGHT_COUNT = "MN_WORLD_BOSS_BUY_FIGHT_COUNT";

    public const string MN_SUMMON_IMPROVE_RESULT = "SummonImproveResult";
    public const string MN_SUMMON_CHANGE = "SummonChange";
    public const string MN_SUMMON_ROLE_SHOW_CHG = "SummonRoleShowChg";//是否显示模型

    public const string MN_NIAN_SHOU_INFO = "NianShouInfo";
    public const string MN_NIAN_SHOU_ENTER = "NianShouEnter";
    public const string MN_NIAN_SHOU_FINISH = "NianShouFinish";

    // 聊天
    public const string MN_CHAT_BLACK_LIST = "ChatBlackList";
    public const string MN_CHAT_ADD_BLACK_LIST = "ChatAddBlackList";
    public const string MN_CHAT_DEL_BLACK_LIST = "ChatDelBlackList";
    public const string MN_CHAT_WROLD_SEND_SUCCESS = "ChatWorldMsgSendSuccess";
    public const string MN_CHAT_TIME_CD = "ChatTimeCD";
    public const string MN_CHAT_SYSTEM_NOTICE = "ChatSystemNotice";
    public const string MN_CHAT_SYSTEM_NOTICE_NORMAL = "ChatSystemNoticeNormal";
    public const string MN_CHAT_SEND_MSG_SUCCESS = "ChatSendMsgSuccess";

    public const string MN_BATTLE_CHECK = "battleCheck";
    // 进入战斗失败，现用于发送雇佣武将已经被收回消息
    public const string MN_ENTER_BATTLE_FAILED_OF_HIRE_FAIL = "enterBattleFailedOfHireFail";
    //7天登入
    public const string MN_SEVENDAY_PANEL = "sevendaypanel";
    public const string MN_SEVENDAY_GETAWARD = "sevendaygetaward";
    public const string MN_SEVENDAY_CHANGE = "sevendaychange";
    public const string MN_SEVENDAY_AWARD_CLOSE = "sevendayawardClose";
    
    //元宝商城
    public const string MN_YUANBAOSHOP_BUY = "yuaobaoshopbuy";
    public const string MN_YUANBAOSHOP_OPEN = "yuanbaoshopopen";

    //充值验证
    public const string MN_RECHARGE_VERIFY = "rechargeVerify";

	//精彩活动
    public const string MN_WONACT_LIST = "wonderfulactivitylist";
    public const string MN_WONACT_TAKEAWARD = "wonderfulactivitytake";
    public const string MN_WONACT_UPDARIGHT = "wonderfulactivityright";
    public const string MN_WONACT_FRESH = "wonderfulfresh";
    public const string MN_BUYJIJIN_SUCCESS = "buyjijinsuccess";
    public const string MN_WXSHARE_SUCCESS = "wxsharesuccess";
    public const string MN_READ_SUCCESS = "readsuccess"; //查看过了新活动
	
    public const string MN_RACE_STATE_INFO = "MN_RACE_STATE_INFO";  // 赛马面板信息
    public const string MN_RACE_FREE_ROLE_LIST = "MN_RACE_FREE_ROLE_LIST";  // 赛马可用武将列表
    public const string MN_RACE_RIVAL_LIST = "MN_RACE_RIVAL_LIST";  // 赛马敌人列表
    public const string MN_RACE_MY_ROLE = "MN_RACE_MY_ROLE";  // 我的武将
    public const string MN_RACE_ENTER = "MN_RACE_ENTER";
    public const string MN_RACE_FINISH = "MN_RACE_FINISH";
    public const string MN_RACE_UPDATE_RANK = "MN_RACE_UPDATE_RANK";//赛马更新排名（扫荡后）

    public const string MN_HEART_BEAT = "MN_HEART_BEAT"; // 心跳事件


    public const string MN_CAMPS_RUSH_ENTER = "EnterCampsRush"; // 进入闯连营    
    public const string MN_CAMPS_RUSH_INFO = "CampsRushInfo"; // 闯连营信息 
    public const string MN_CAMPS_RUSH_FINISH = "FinishCampsRush"; // 通关闯连营
    public const string MN_CAMPS_RUSH_SWEEP_RESULT = "CampsRushSweepResult"; // 闯连营扫荡结果
    //public const string MN_CAMPS_RUSH_RANKING = "CampsRushRank";  // 闯连营排行榜信息


    public const string MN_OPEN_DIANJIANGTAI = "OpenDianJiangTai";//打开点将台界面
    public const string MN_DIANJIANG = "DianJiang";//点将
    public const string MN_GET_DIANJIANG_BOX_AWARD = "GetDianJiangBoxAward";//获取点将宝箱奖励
    public const string MN_DIANJIANG_REDDOT_CHG = "DianJiangRedDotChg";//点将红点改变
    
    //招亲
    public const string MN_OPEN_ZHAOQIN = "OpenZhaoQin";//打开比武招亲界面
    public const string MN_OPENZHAOQINSHOP = "OpenZhaoQinShop";
    public const string MN_JOINSUCCESS = "JoinSuccess";//比武招亲报名成功
    public const string MN_ZHAOQINSAICHENG = "ZhaoQinSaiCheng";//打开赛程界面
    public const string MN_ZHAOQIN_SUPPORT_SUCCESS = "SuportSuccess";//支持成功
    public const string MN_ZHAOQIN_BUYSHOP_SUCCESS = "BuySuccess";//购买成功

    public const string MN_CAMPS_RUSH_FIRST_AWARD_CLOSE = "CampsRushFirstAwardClose"; // 闯连营关闭首次奖励

    public const string MN_MONEY_COPY_INFO = "MN_MONEY_COPY_INFO"; // 摸金信息更新

    public const string MN_LAND_LADY_SHOP_INFO_CHANGE = "LandLadyShopInfoChange";       //老板娘商店信息变化
    public const string MN_LAND_LADY_SHOP_TIME_CHANGE = "LandLadyShopTimeChange";       //老板娘商店出现时间变化
    public const string MN_LAND_LADY_SHOP_SHOW = "LandLadyShopShow";                  //老板娘商店出现

    public const string MN_TURNTABLE_PLAY_RESULT = "turntablePlayResult";
    public const string MN_TURNTABLE_TAKE_AWARD = "turntableTakeAward";
    public const string MN_TURNTABLE_PRICE_CHANGE = "turntablePriceChange";
    public const string MN_TURNTABLE_BOX_PRICE_CHANGE = "turntableBoxPriceChange";
    public const string MN_TURNTABLE_SHUFFLE_RESULT = "turntableShuffleResult";
    public const string MN_TURNTABLE_TAKE_BOX_AWARD = "turntableTakeBoxAward";

    public const string MN_WONDERFUL_TURNTABLE_INFO = "wonderfulTurntableInfo";
    public const string MN_WONDERFUL_TURNTABLE_LOTTERY = "wonderfulTurntableLottery";
    public const string MN_WONDERFUL_TURNTABLE_TAKE_AWARD = "wonderfulTurntableTakeAward";
    public const string MN_WONDERFUL_TURNTABLE_AWARD_TAKEN = "wonderfulTurntableAwardTaken";

    public const string MN_GUILD_REPOSITORY_CHANGE = "MN_GUILD_REPOSITORY_CHANGE"; // 军团仓库更新
    public const string MN_GUILD_DISTRIBUTION_LIST = "MN_GUILD_DISTRIBUTION_LIST"; // 军团仓库分配信息

    public const string MN_TILED_MAP_ZONE_CREATED = "MN_TILED_MAP_ZONE_CREATED"; // 地图块创建完成
    public const string MN_TILED_MAP_OBJECT_ZONE_REQUEST = "MN_TILED_MAP_OBJECT_ZONE_REQUEST"; // 地图物件信息更新请求
    public const string MN_TILED_MAP_OBJECT_ZONE_UPDATE = "MN_TILED_MAP_OBJECT_ZONE_UPDATE"; // 地图物件信息更新
    public const string MN_TILED_MAP_OBJECT_ZONE_BLOCK_UPDATE = "MN_TILED_MAP_OBJECT_UPDATE"; // 地图物件信息更新
    public const string MN_TILED_MAP_OBJECT_UPDATE = "MN_TILED_MAP_OBJECT_UPDATE"; // 地图物件信息更新
    public const string MN_TILED_MAP_OBJECT_ADD = "MN_TILED_MAP_OBJECT_ADD"; // 地图物件信息添加
    public const string MN_TILED_MAP_OBJECT_DEL = "MN_TILED_MAP_OBJECT_DEL"; // 地图物件信息删除
    public const string MN_TILED_MAP_MONSTER_UPDATE = "MN_TILED_MAP_MONSTER_UPDATE"; // 地图怪物信息更新
    public const string MN_TILED_MAP_MONSTER_ADD = "MN_TILED_MAP_MONSTER_ADD"; // 地图怪物信息添加
    public const string MN_TILED_MAP_MONSTER_DEL = "MN_TILED_MAP_MONSTER_DEL"; // 地图怪物信息删除
    public const string MN_TILED_MAP_ARMY_MARCH_ADD = "MN_TILED_MAP_ARMY_MARCH_ADD";//地图行军信息添加
    public const string MN_TILED_MAP_ARMY_MARCH_UPDATE = "MN_TILED_MAP_ARMY_MARCH_UPDATE";//地图行军信息更新
    public const string MN_TILED_MAP_ARMY_MARCH_DEL = "MN_TILED_MAP_ARMY_MARCH_DEL";//地图行军信息删除
    //public const string MN_MANORSLG_MAIN_CITY_UPDATE = "manorSLGMainCityUpdate";// 领地世界主城信息更新
    public const string MN_TILED_MAP_AUTO_MOVE = "MN_TILED_MAP_AUTO_MOVE"; // 
    public const string MN_TILED_MAP_CLICK = "MN_TILED_MAP_CLICK"; // 
    public const string MN_TILED_MAP_MENU_SHOW = "MN_TILED_MAP_MENU_SHOW";     //显示地图菜单
    public const string MN_TILED_MAP_MENU_CLOSE = "MN_TILED_MAP_MENU_CLOSE";     //关闭地图菜单
    public const string MN_SLG_LOCATE_COORDINATE = "slgLocateCoordinate";       //定位到固定坐标
    public const string MN_SLG_LOCATE_MARCH = "MN_SLG_LOCATE_MARCH";            //定位到固定行军
    public const string MN_SLG_MOVE_CITY = "slgMoveCity";                     //迁城
    public const string MN_SLG_MY_MARCH_ADD = "MN_SLG_MY_MARCH_ADD";            //我的行军增加
    public const string MN_SLG_MY_MARCH_UPDATE = "MN_SLG_MY_MARCH_UPATE";            //我的行军更新
    public const string MN_SLG_MY_MARCH_DEL = "MN_SLG_MY_MARCH_DEL";            //我的行军删除
    public const string MN_SLG_SHOW_MENU_BY_COORD = "MN_SLG_SHOW_MENU_BY_COORD"; //根据坐标显示地图菜单
    public const string MN_SLG_SHOW_MENU_BY_MARCH = "MN_SLG_SHOW_MENU_BY_MARCH"; //根据行军显示地图菜单
    public const string MN_SLG_CREATE_CITY_COMPLETE = "MN_SLG_CREATE_CITY_COMPLETE";//地图创建城市完成
    public const string MN_SLG_MAP_OBJECT_MENU_ON_SHOW = "MN_SLG_MAP_OBJECT_MENU_ON_SHOW";//地图菜单显示后
    public const string MN_SLG_MAP_OBJECT_MENU_ON_CLOSE = "MN_SLG_MAP_OBJECT_MENU_ON_CLOSE";//地图菜单隐藏后

    public const string MN_SHOW_CHAT_IN_GUILD_BATTLE = "MN_SHOW_CHAT_IN_GUILD_BATTLE";//军团战显示聊天
    public const string MN_GUILD_BATTLE_STATE_UPDATE = "MN_GUILD_BATTLE_STATE_UPDATE";//军团战信息更新

    public const string MN_GUILD_WAR_ENTER_CHG = "MN_GUILD_WAR_ENTER_CHG";//军团战入口
    public const string MN_GUILD_WAR_PANEL_INFO = "MN_GUILD_WAR_PANEL_INFO";//军团战对阵表
    public const string MN_GUILD_WAR_LINEUP = "MN_GUILD_WAR_LINEUP";//军团战布阵
    public const string MN_GUILD_WAR_DETAIL = "MN_GUILD_WAR_DETAIL";//军团战详情
    public const string MN_GUILD_WAR_LOG = "MN_GUILD_WAR_LOG";//军团战日志


    public const string MN_FRIENDLY_ENTER = "MN_FRIENDLY_ENTER"; //进入切磋
    public const string MN_SCENE_EFFECT_CHG = "MN_SCENE_EFFECT_CHG"; // 主场景特效变化
    public const string MN_MAIN_CITY_ATTACKED_TIME_CHG = "MN_MAIN_CITY_ATTACKED_TIME_CHG";//主城被攻击时间变化
    public const string MN_MAIN_CITY_WILL_BE_ATTACKED_ALERT = "MN_MAIN_CITY_WILL_BE_ATTACKED_ALERT";//主城即将被攻击提醒

    public const string MN_SLG_MYCITY_UISTATE = "MN_SLG_MYCITY_UISTATE"; //  
    public const string MN_SLG_MYCITY_MANOR_DETAIL = "MN_SLG_MYCITY_MANOR_DETAIL"; //  领地详情信息

    public const string MN_SLG_IMPROVE_RSP = "MN_SLG_IMPROVE_RSP";        //升级响应
    public const string MN_SLG_UPGRADE_BUILDING_INFO = "MN_SLG_UPGRADE_BUILDING_INFO";      //SLG建筑升级信息
    public const string MN_SLG_SEND_HELP_BUILDING = "MN_SLG_SEND_HELP_BUILDING";        //成功发送求助建造
    public const string MN_SLG_UPGRADE_TIPS = "MN_SLG_UPGRADE_TIPS";        //显示升级提示框

    public const string MN_SLG_SOLDIER_LIST = "MN_SLG_SOLDIER_LIST";        //士兵列表更新
    public const string MN_SLG_RECRUIT_TIME_CHG = "MN_SLG_RECRUIT_TIME_CHG";
    public const string MN_SLG_SEND_HELP_RECRUIT = "MN_SLG_SEND_HELP_RECRUIT";        //成功发送求助募兵
    public const string MN_SLG_RECRUIT_TIME_UPDATE = "MN_SLG_UPGRADE_BUILDING_INFO";      //SLG建筑升级信息
    public const string MN_SLG_TRAIN_SOLDIER = "MN_SLG_TRAIN_SOLDIER";        //成功训练士兵
    public const string MN_SLG_RECOVER_SOLDIER = "MN_SLG_RECOVER_SOLDIER";        //成功回复士兵

    //public const string MN_SLG_MARCH_PANEL = "MN_SLG_MARCH_PANEL";        //出征界面数据
    //public const string MN_SLG_DEFENCE_PANEL = "MN_SLG_DEFENCE_PANEL";        //防守界面数据

    public const string MN_SLG_MARK_REPORTS_READ = "MN_SLG_MARK_REPORTS_READ";//标记战报已读
    public const string MN_SLG_DELETE_REPORTS = "MN_SLG_DELETE_REPORTS";//删除战报


    public const string MN_MANOR_MAP_DRAG = "MN_MANOR_MAP_DRAG"; // 
    public const string MN_MANOR_MAP_INFO = "MN_MANOR_MAP_INFO"; // 地图信息
    public const string MN_MANOR_MAP_CITY_INFO = "MN_MANOR_MAP_CITY_INFO";
    public const string MN_MANOR_MAP_BATTLE_PANEL = "MN_MANOR_MAP_BATTLE_PANEL";        //出征界面数据
    public const string MN_MANOR_MAP_APPLY_VASSAL_LIST = "MN_MANOR_MAP_APPLY_LIST";//领地地图城市附庸申请列表
    public const string MN_MANOR_MAP_ADD_VASSAL_APPLY = "MN_MANOR_MAP_ADD_VASSAL_APPLY";//添加领地地图城市附庸申请
    public const string MN_MANOR_MAP_REMOVE_VASSAL_APPLY = "MN_MANOR_MAP_REMOVE_VASSAL_APPLY";//移除领地地图城市附庸申请
    public const string MN_MANOR_MAP_VASSAL_LIST = "MN_MANOR_MAP_VASSAL_LIST";//领地地图城市附庸列表
    public const string MN_MANOR_MAP_ADD_VASSAL = "MN_MANOR_MAP_ADD_VASSAL";//添加领地地图城市附庸
    public const string MN_MANOR_MAP_REMOVE_VASSAL = "MN_MANOR_MAP_REMOVE_VASSAL";//移除领地地图城市附庸
    public const string MN_MANOR_MAP_EDIT_CITY_STATEMENT_SUCCEED = "MN_MANOR_MAP_EDIT_CITY_STATEMENT_SUCCEED";//修改城市宣言成功
    public const string MN_MANOR_MAP_EDIT_CITY_STATEMENT_CHG = "MN_MANOR_MAP_EDIT_CITY_STATEMENT_CHG";//城市宣言变化
    public const string MN_MANOR_MAP_CITY_RECORD_LIST = "MN_MANOR_MAP_CITY_RECORD_LIST";//城市记录列表
    public const string MN_MANOR_MAP_MY_INFO_CHG = "MN_MANOR_MAP_MY_INFO_CHG"; // 玩家信息变化
    public const string MN_MANOR_MAP_WORLD_RECORD_LIST = "MN_MANOR_MAP_WORLD_RECORD_LIST";//天下大事列表
    public const string MN_MANOR_MAP_REPORT_CHANGE = "MN_MANOR_MAP_REPORT_CHANGE";//领地地图战报变化
    public const string MN_MANOR_MAP_WAR_TARGET_CHG = "MN_MANOR_MAP_WAR_TARGET_CHG";//战争目的变化
    public const string MN_MANOR_MAP_CREATED = "MN_MANOR_MAP_CREATED"; // 
    public const string MN_MANOR_MAP_ATKED = "MN_MANOR_MAP_ATKED";                  //领地地图城市被攻击
    public const string MN_MANOR_MAP_CHAT_VISIBLE = "MN_MANOR_MAP_CHAT_VISIBLE";      //领地地图聊天显示与隐藏

    //答题
    public const string MN_QUIZ_INFO = "MN_QUIZ_INFO";          //题目信息
    public const string MN_QUIZ_ANSWER = "MN_QUIZ_ANSWER";      //回答

    public const string MN_SHENBING_MULTI_WASH = "MN_SHENBING_MULTI_WASH";    //批量洗练神兵
    public const string MN_SHENBING_ACTIVE = "MN_SHENBING_ACTIVE";          //激活神兵
    public const string MN_SHENBING_SELECT_ATTR = "MN_SHENBING_SELECT_ATTR";          //选择属性
    public const string MN_SHENBING_SHOW_ATRR_SKILL = "MN_SHENBING_SHOW_ATRR_SKILL";   //显示属性技能
    public const string MN_WASH_STONE_CHG = "MN_WASH_STONE_CHG";  //神兵洗练石
    public const string MN_SHENBING_ATTR_SKILL_TURN = "MN_SHENBING_ATTR_SKILL_TURN";  //神兵属性技能切换
    public const string MN_SHENBING_ATTR_SKILL_CLOSE = "MN_SHENBING_ATTR_SKILL_CLOSE";     //神兵属性技能关闭
    public const string MN_SHENBING_SINGLE_WASH = "MN_SHENBING_SINGLE_WASH";    //单次洗练神兵

    public const string MN_MULTI_KILL = "MN_MULTI_KILL"; //千人斩连杀
    public const string MN_QIANRENZHAN_ENTER_BATTLE = "MN_QIANRENZHAN_ENTER_BATTLE";// 进入千人斩副本
    public const string MN_QIANRENZHAN_FINISH_BATTLE = "MN_QIANRENZHAN_FINISH_BATTLE";// 结束千人斩副本
    public const string MN_QIANRENZHAN_INFO = "MN_QIANRENZHAN_INFO";// 千人斩信息
    public const string MN_WS_KILL = "MN_WS_KILL"; //千人斩无双
    public const string MN_QIANRENZHAN_GET_AWARD = "MN_QIANRENZHAN_GET_AWARD";// 千人斩领取奖励
    public const string MN_QIANRENZHAN_RESET_FIGHT = "MN_QIANRENZHAN_RESET_FIGHT";//千人斩重置挑战次数

    public const string MN_ENTER_LGTB = "EnterLGTB";//进入龙宫探宝副本
    public const string MN_FINISH_LGTB = "FinishLGTB"; // 通关龙宫探宝副本
    public const string MN_NTF_FLOP_INFO = "NTFFlopInfo";//翻牌结果
    public const string MN_UPDATE_UI_LGTB_SELECT_COPY = "UpdateUILGTBSelectCopy";//更新界面UILGTBSelectCopy
    public const string MN_BOX_CHANGE_DEPTH = "MN_BOX_CHANGE_DEPTH";    //更改翻牌界面的Depth

    //世界野怪
    public const string MN_UPDATE_WORLD_MONSTER = "MN_UPDATE_WORLD_MONSTER";   //更新世界野怪信息
    public const string OPEN_WORLD_MONSTER_DETAIL = "OPEN_WORLD_MONSTER_DETAIL";    //打开世界野怪信息界面

    //军团宣战
    public const string GUILD_CANDECLAREWAR_UPDATE_LIST = "GUILD_CANDECLAREWAR_UPDATE_LIST";  //更新可宣战军团列表
    public const string GUILD_DECLAREWAR_UPDATE_LIST = "GUILD_DECLAREWAR_UPDATE_LIST";  //更新已经宣战的军团列表
    public const string GUILD_UPDATE_GUILD_DETAILINFO = "GUILD_UPDATE_GUILD_DETAILINFO";    //显示某个军团的详细信息
    public const string OPERATE_GUILD_DECLAREWAR = "OPERATE_GUILD_DECLAREWAR";      //完成对某个军团的宣战操作
    public const string GUILD_DECLAREWAR_ENTER_BATTLE = "GUILD_DECLAREWAR_ENTER_BATTLE";    //进入军团个人决斗战斗
    public const string GUILD_DECLAREWAR_OVER = "GUILD_DECLAREWAR_OVER";        //军团宣战结束
    public const string GUILD_DECLAREWAR_CHANGE_PROTECTTIME = "GUILD_DECLAREWAR_CHANGE_PROTECTTIME";//对方的保护时间清零
    public const string CHECK_IS_IN_DECLAREWAR = "CHECK_IS_IN_DECLAREWAR";//检查是否处于宣战状态（是否应该显示主界面的军团宣战按钮）
	    
	//开服七天活动
    public const string SEVENDAY_SHOP_OPEN_UPDATE = "SEVENDAY_SHOP_OPEN_UPDATE";//更新七天特价商店的详细信息
    public const string SEVENDAY_SHOP_BUY_SUCCESS = "SEVENDAY_SHOP_BUY_SUCCESS";  //购买商品成功
    public const string SEVENDAY_FLASH_SALE_CROSSDAY = "SEVENDAY_FLASH_SALE_CROSSDAY";//七天特价商店--跨天时更新界面信息
    public const string SEVENDAY_SOLD_OUT = "SEVENDAY_SOLD_OUT";//七天特价商店--已经卖光了
    public const string SEVENDAY_TAKE_RANKING_AWARD = "SEVENDAY_TAKE_RANKING_AWARD";    //七天冲榜活动-领奖成功

    //好友界面
    public const string FRIEND_PRIVATE_CHAT = "FriendPrivateChat";
    public const string FRIEND_CHALLENGE = "FriendChallenge";
    public const string FRIEND_APPLY_OPERATE = "FriendApplyOperate";    //同意好友申请
    public const string FRIEND_APPLY_REFUSE = "FriendApplyRefuse";    //拒绝好友申请
    public const string FRIEND_UPDATE_FRIENDLIST = "FriendUpdateFriendList";    //更新好友列表
    public const string FRIEND_SEARCH_PLAYER = "FriendSearchPlayer";        //搜索好友
    public const string FRIEND_APPLY_FRIENDLIST = "FriendApplyFriendList";  //获取其他玩家申请好友列表
    public const string FRIEND_CHANGE_APPLY_COMMAND = "FriendChangeApplyCommand";   //关闭/开启好友申请按钮
    public const string FRIEND_NTF_APPLY_FRIEND = "FriendNtfApplyFriend";       //通知有新的好友申请
    public const string FRIEND_NTF_DEL_FRIEND = "FriendNtfDelFriend";               //通知删除好友（自己被删除）
    public const string FRIEND_ANSWER_ADD_FRIEND = "FriendAnswerAddFriend";         //回应添加好友
    public const string FRIEND_NTF_ANSWER_ADD_FRIEND = "FriendNtfAnswerAddFriend";         //通知回应添加好友（别的玩家同意了自己的好友申请）
    public const string FRIEND_DEL_ALL_APPLY_RECORD = "FriendDelAllApplyRecord";    //删除全部好友申请记录
    public const string FRIEND_GET_BLACKLIST = "FriendGetBlackList";        //获取黑名单
    public const string FRIEND_ADD_BLACKLIST = "FriendAddBlackList";        //把其他玩家添加到黑名单中
    public const string FRIEND_FINISH_ADD_BLACKLIST = "FriendFinishAddBlackList";   //成功把其他玩家添加到黑名单中（从服务器接收到回复）
    public const string FRIEND_NTF_ADD_BLACKLIST = "FriendNtfAddBlackList";     //成功把其他玩家添加到黑名单中（通知）
    public const string FRIEND_BLACKLIAT_REMOVE = "FriendBlackListRemove";  //移除黑名單中的項
    public const string FRIEND_FINISH_REMOVE_BLACKLIST = "FriendFinishRemoveBlackList"; //完成把其他玩家移除黑名单（从服务器接收到回复）
    public const string FRIEND_AWARD_STAMINALIST = "FriendAwarStaminaList";     //获取赠送体力列表
    public const string FRIEND_GET_AWARD_STAMINA = "FriendGetAwarStamina";     //领取体力
    public const string FRIEND_FINISH_GET_AWARD_STAMINA = "FriendFinishGetAwarStamina";     //成功领取体力（从服务器接收到回复）
    public const string FRIEND_AWARD_ALL_STAMINA = "FriendAwardAllStamina";         //获得全部体力
    public const string FRIEND_CLICK_GIVE_STAMINA = "FriendClickGiveStamina";          //点击赠送体力给其他玩家
    public const string FRIEND_GIVE_STAMINA = "FriendGiveStamina";          //完成赠送体力给其他玩家
    public const string FRIEND_GIVE_ALL_STAMINA = "FriendGiveAllStamina";          //完成一键赠送体力给其他玩家
    public const string FRIEND_NTF_GIVE_STAMINA = "FriendNtfGiveStamina";       //其他玩家赠送体力给自己（收到通知）
    public const string FRIEND_DEL_FRIEND = "FriendDelFriend";  //删除好友
    public const string FRIEND_FINISH_DEL_FRIEND = "FriendFinishDelFriend";  //成功删除好友（从服务器接收到回复）
    public const string FRIEND_CHAT_SEND_MSG_SUCCESS = "FriendChatSendMsgSuccess";  //成功发送聊天信息
    public const string FRIEND_CHAT_RECEIVE_MSG = "FriendChatReceiveMsg";           //接收到新消息
    public const string FRIEND_CHAT_RECEIVE_LEAVE_MSG = "FriendChatReceiveLeaveMsg";           //接收到新消息
    public const string FRIEND_LOGIN_OR_LOGOUT = "FriendLoginOrLogout";     //通知好友上线或下线
    public const string MN_FRIEND_CHG = "friendDataChg";//好友数据变化
    public const string FRIEND_APPLY_AREADY_BE_FRIEND = "FRIEND_APPLY_AREADY_BE_FRIEND";//同意好友申请时，发现彼此已经是好朋友了

    //军令
    public const string MN_GUILD_ORDER_LIST = "MN_GUILD_ORDER_LIST";                                    //军令列表
    public const string MN_GUILD_ORDER_UPDATE_STATE = "MN_GUILD_ORDER_UPDATE_STATE";                    //军令状态更新
    public const string MN_GUILD_ORDER_TASK_UPDATE = "MN_GUILD_ORDER_TASK_SINGLE_UPDATE";               //军令任务更新
    public const string MN_GUILD_ORDER_TASK_ROLE = "MN_GUILD_ORDER_TASK_ROLE";                          //军令任务选武将
    public const string MN_GUILD_ORDER_GET_AWARD = "MN_GUILD_ORDER_GET_AWARD";                          //军令领取奖励
    public const string MN_GUILD_ORDER_INFO = "MN_GUILD_ORDER_INFO";                                    //军令其他数据

    //军团签到
    public const string GUILD_SIGN_GETAWARD = "GuildSignGetAward";//军团签到领奖成功
    //vip币商店
    public const string MN_VIP_COIN_SHOP_CHG = "MN_VIP_COIN_SHOP_CHG";    //VIP币商店数据变化
    public const string MN_VIP_COIN_SHOP_CHG_INDEX = "MN_VIP_COIN_SHOP_CHG_INDEX";    //VIP币商店单个数据变化
    public const string MN_VIP_COIN_SHOP_SHOW_DIALOG = "MN_VIP_COIN_SHOP_SHOW_DIALOG"; //VIP币商店显示对话
    public const string MN_VIP_COIN_SHOP_REFRESHTIME = "VipCoinShopRefreshTime";       //VIP币商店刷新时间
    public const string MN_VIP_COIN_MONEY_CHG = "vipCoinMoneyChg";//VIP币变化

    //优惠商店
    public const string MN_DISCOUNT_SHOP_CHG = "MN_DISCOUNT_SHOP_CHG";    //优惠商店数据变化
    public const string MN_DISCOUNT_SHOP_CHG_INDEX = "MN_DISCOUNT_SHOP_CHG_INDEX";    //优惠商店单个数据变化
    public const string MN_DISCOUNT_SHOP_SHOW_DIALOG = "MN_DISCOUNT_SHOP_SHOW_DIALOG"; //优惠商店显示对话
    public const string MN_DISCOUNT_SHOP_REFRESHTIME = "MN_DISCOUNT_SHOP_REFRESHTIME";       //优惠商店刷新时间


    //头像框
    public const string MN_USER_HEAD_BOX_ICON_CHANGE = "MN_USER_HEAD_BOX_ICON_CHANGE";//更换头像框
    public const string MN_USER_HEAD_BOX_LIST = "MN_USER_HEAD_BOX_LIST";//请求所有可用的头像框
    public const string MN_USER_HEAD_BOX_CHANGE_SUCC = "MN_USER_HEAD_BOX_CHANGE_SUCC";//成功更换头像框

    public const string MN_TOC_BUY_CHALLENGE_TIMES = "MN_TOC_BUY_CHALLENGE_TIMES";//过关斩将购买挑战次数
    public const string MN_CAMPSRUSH_BUY_RESET_TIMES = "MN_CAMPSRUSH_BUY_RESET_TIMES";//闯连营购买重置次数
    
    //酒馆买酒排行
    public const string MN_LOTTERY_RANK_CHANGE = "MN_LOTTERY_RANK_CHANGE";//买酒排行榜数据变化
    public const string MN_LOTTERY_BUYTIMES_CHANGE = "MN_LOTTERY_BUYTIMES_CHANGE";//本人买酒数量发生变化（更新进度条的显示）

    //千人斩通关
    public const string BATTLE_QIANRENZHAN_FINISH = "BATTLE_QIANRENZHAN_FINISH";//千人斩通关

    //跨服赛-天下无双
    public const string TIANXIAWUSHAUNG_UPDATE_PANEL_INFO = "TIANXIAWUSHAUNG_UPDATE_PANEL_INFO";//更新天下无双主界面的显示
    public const string TIANXIAWUSHUANG_RECEIVE_RECORD = "TIANXIAWUSHUANG_RECEIVE_RECORD";//接收到战报信息

    //流寇攻城
    public const string MANORMAP_CONVENE_ALL_ARMY_INFO = "MANORMAP_CONVENE_ALL_ARMY_INFO";//接收到所有流浪军的行程信息
    public const string MANORMAP_CONVENE_ARMY_DETAIL_INFO = "MANORMAP_CONVENE_ARMY_DETAIL_INFO";//接收到某支流浪军的详细信息
    public const string MANORMAP_CONVENE_RECEIVE_BATTLERESULT = "MANORMAP_CONVENE_RECEIVE_BATTLERESULT";//接收到战报信息
    public const string MANORMAP_CONVENE_DELETE_JOINER = "MANORMAP_CONVENE_DELETE_JOINER";      //把某个部队从攻城队伍中踢出

    public const string REBIRTH_SUCCESS = "REBIRTH_SUCCESS";//转生成功
    //竞技场3V3
    public const string MN_ARENA3V3_EXCHANGE_LIVEUP = "MN_ARENA3V3_EXCHANGE_LIVEUP";//交换阵容
    public const string MN_ARENA3V3_REFRESH_RIVAL = "arena_refresh3V3_rival";//刷新对手
    public const string MN_ARENA3V3_PERSONAL_PANEL = "arena3V3_personal_panel";//竞技场个人面板信息
    public const string MN_ARENA3V3_BUY_TIMES = "arena3V3_buy_times";//竞技场购买次数
    public const string MN_ARENA3V3_RESET_COOL = "arena3V3_reset_cool";//重置竞技场失败冷却CD
    public const string MN_DEFEND3V3_ROLE_INFO = "defend3V3_wujiang_info";//玩家的防守信息
    public const string MN_ARENA3V3_GETAWARD = "MN_ARENA3V3_GETAWARD";  //竞技场3V3领取奖励
    public const string MN_ARENA3V3_FIGHT_RECORD = "arena3v3_fight_record";//对战记录
    public const string MN_GET_FIGHT_VIDEO_LIST = "GetFightVideos";        //多条录像    
    public const string MN_ARENA3V3_SHOP_CHG = "MN_ARENA3V3_SHOP_CHG";                //竞技场3V3商店数据变化
    public const string MN_ARENA3V3_SHOP_CHG_INDEX = "MN_ARENA3V3_SHOP_CHG_INDEX";    //竞技场3V3商店单个数据变化
    public const string MN_ARENA3V3_SHOP_SHOW_DIALOG = "MN_ARENA3V3_SHOP_SHOW_DIALOG";//竞技场3V3商店显示对话
    public const string MN_ARENA3V3_SHOP_REFRESHTIME = "MN_ARENA3V3_SHOP_REFRESHTIME";//竞技场3V3商店刷新时间

    //回收商店
    public const string MN_RECYCLE_SHOP_CHG = "MN_RECYCLE_SHOP_CHG";//回收商店数据变化
    public const string MN_RECYCLE_SHOP_CHG_INDEX = "MN_RECYCLE_SHOP_CHG_INDEX";  //回收商店单个数据变化
    public const string MN_RECYCLE_SHOP_SHOW_DIALOG = "MN_RECYCLE_SHOP_SHOW_DIALOG";//回收商店显示对话
    public const string MN_RECYCLE_SHOP_REFRESHTIME = "MN_RECYCLE_SHOP_REFRESHTIME";      //回收商店刷新时间
    public const string UI_SHOP_RECYCLE_POPUP = "UI_SHOP_RECYCLE_POPUP";    //打开ItemPopup界面

    //鉴宝行
    public const string MN_TREASURESTORE_DAILY_TEMINFO = "MN_TREASURESTORE_UPDATEI_TEMINFO";//更新每日信物数据
    public const string MN_TREASURESTORE_SOLD_SUCC = "MN_TREASURESTORE_SOLD_SUCC";//鉴宝成功
    public const string MN_TREASURESTORE_SOLD_MULTIPLE = "MN_TREASURESTORE_SOLD_MULTIPLE";//鉴宝后的倍数

    //军团boss
    public const string MN_GUILD_BOSS_INFO = "GuildBossInfo";
    public const string MN_GUILD_BOSS_ENHANCE_ATK = "GuildBossEnhanceAtk";
    public const string MN_GUILD_BOSS_ENTER = "GuildBossEnter";
    public const string MN_GUILD_BOSS_FINISH = "GuildBossFinish";
    public const string MN_GUILD_BOSS_MEMBER_RANK = "GuildBossRank";
    public const string MN_GUILD_BOSS_GUILD_RANK = "GuildBossYesterdayRank";
    public const string MN_GUILD_BOSS_BUY_FIGHT_COUNT = "MN_GUILD_BOSS_BUY_FIGHT_COUNT";
    public const string MN_GUILD_BOSS_SHOW_MAIN_PANEL = "MN_GUILD_BOSS_SHOW_MAIN_PANEL";
    public const string MN_GUILD_BOSS_FRENZY_TIME_BATTLE = "MN_GUILD_BOSS_FRENZY_TIME_BATTLE";      //战斗界面更新boss狂暴次数
} 

