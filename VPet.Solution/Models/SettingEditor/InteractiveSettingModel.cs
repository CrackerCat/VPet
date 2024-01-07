﻿using HKW.HKWUtils.Observable;
using VPet_Simulator.Core;

namespace VPet.Solution.Models.SettingEditor;

public class InteractiveSettingModel : ObservableClass<InteractiveSettingModel>
{
    private string _petName;

    /// <summary>
    /// 宠物名称
    /// </summary>
    public string PetName
    {
        get => _petName;
        set => SetProperty(ref _petName, value);
    }

    private double _voiceVolume;

    /// <summary>
    /// 播放声音大小
    /// </summary>
    public double VoiceVolume
    {
        get => _voiceVolume;
        set => SetProperty(ref _voiceVolume, value);
    }

    private GameSave.ModeType _calFunState;

    /// <summary>
    /// 非计算模式下默认模式
    /// </summary>
    public GameSave.ModeType CalFunState
    {
        get => _calFunState;
        set => SetProperty(ref _calFunState, value);
    }

    private bool _petHelper;

    /// <summary>
    /// 是否显示宠物帮助窗口
    /// </summary>
    public bool PetHelper
    {
        get => _petHelper;
        set => SetProperty(ref _petHelper, value);
    }

    private DateTime _lastCacheDate;

    /// <summary>
    /// 上次清理缓存日期
    /// </summary>
    public DateTime LastCacheDate
    {
        get => _lastCacheDate;
        set => SetProperty(ref _lastCacheDate, value);
    }

    private int _saveTimes;

    /// <summary>
    /// 储存顺序次数
    /// </summary>
    public int SaveTimes
    {
        get => _saveTimes;
        set => SetProperty(ref _saveTimes, value);
    }

    private int _pressLength;

    /// <summary>
    /// 按多久视为长按 单位毫秒
    /// </summary>
    public int PressLength
    {
        get => _pressLength;
        set => SetProperty(ref _pressLength, value);
    }

    private int _interactionCycle;

    /// <summary>
    /// 互动周期
    /// </summary>
    public int InteractionCycle
    {
        get => _interactionCycle;
        set => SetProperty(ref _interactionCycle, value);
    }

    private double _logicInterval;

    /// <summary>
    /// 计算间隔 (秒)
    /// </summary>
    public double LogicInterval
    {
        get => _logicInterval;
        set => SetProperty(ref _logicInterval, value);
    }

    private double _petHelpLeft;

    /// <summary>
    /// 计算间隔
    /// </summary>
    public double PetHelpLeft
    {
        get => _petHelpLeft;
        set => SetProperty(ref _petHelpLeft, value);
    }

    private double _petHelpTop;

    /// <summary>
    /// 计算间隔
    /// </summary>
    public double PetHelpTop
    {
        get => _petHelpTop;
        set => SetProperty(ref _petHelpTop, value);
    }

    private bool _allowMove;

    /// <summary>
    /// 允许移动事件
    /// </summary>
    public bool AllowMove
    {
        get => _allowMove;
        set => SetProperty(ref _allowMove, value);
    }

    private bool _smartMove;

    /// <summary>
    /// 智能移动
    /// </summary>
    public bool SmartMove
    {
        get => _smartMove;
        set => SetProperty(ref _smartMove, value);
    }

    private bool _enableFunction;

    /// <summary>
    /// 启用计算等数据功能
    /// </summary>
    public bool EnableFunction
    {
        get => _enableFunction;
        set => SetProperty(ref _enableFunction, value);
    }

    private int _smartMoveInterval;

    /// <summary>
    /// 智能移动周期 (秒)
    /// </summary>
    public int SmartMoveInterval
    {
        get => _smartMoveInterval;
        set => SetProperty(ref _smartMoveInterval, value);
    }

    private bool _messageBarOutside;

    /// <summary>
    /// 消息框外置
    /// </summary>
    public bool MessageBarOutside
    {
        get => _messageBarOutside;
        set => SetProperty(ref _messageBarOutside, value);
    }

    private string _petGraph;

    /// <summary>
    /// 桌宠选择内容
    /// </summary>
    public string PetGraph
    {
        get => _petGraph;
        set => SetProperty(ref _petGraph, value);
    }

    private double _musicCatch;

    /// <summary>
    /// 当实时播放音量达到该值时运行音乐动作
    /// </summary>
    public double MusicCatch
    {
        get => _musicCatch;
        set => SetProperty(ref _musicCatch, value);
    }

    private double _musicMax;

    /// <summary>
    /// 当实时播放音量达到该值时运行特殊音乐动作
    /// </summary>
    public double MusicMax
    {
        get => _musicMax;
        set => SetProperty(ref _musicMax, value);
    }

    private bool _autoBuy;

    /// <summary>
    /// 允许桌宠自动购买食品
    /// </summary>
    public bool AutoBuy
    {
        get => _autoBuy;
        set => SetProperty(ref _autoBuy, value);
    }

    private bool _autoGift;

    /// <summary>
    /// 允许桌宠自动购买礼物
    /// </summary>
    public bool AutoGift
    {
        get => _autoGift;
        set => SetProperty(ref _autoGift, value);
    }

    private bool _moveAreaDefault;
    public bool MoveAreaDefault
    {
        get => _moveAreaDefault;
        set => SetProperty(ref _moveAreaDefault, value);
    }
    private System.Drawing.Rectangle _moveArea;
    public System.Drawing.Rectangle MoveArea
    {
        get => _moveArea;
        set => SetProperty(ref _moveArea, value);
    }
}