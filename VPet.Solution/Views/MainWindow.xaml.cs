﻿using HKW.HKWUtils;
using Panuon.WPF.UI;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using VPet.Solution.ViewModels;
using VPet.Solution.Views.SaveViewer;
using VPet.Solution.Views.SettingEditor;

namespace VPet.Solution.Views;

/// <summary>
/// MainWindow.xaml 的交互逻辑
/// </summary>
public partial class MainWindow : WindowX
{
    public MainWindowVM ViewModel => (MainWindowVM)DataContext;

    public SettingWindow SettingWindow { get; } = new();
    public SaveWindow SaveWindow { get; } = new();

    public MainWindow()
    {
        if (App.IsDone)
        {
            Close();
            return;
        }
        InitializeComponent();
        this.SetViewModel<MainWindowVM>();

        Closed += MainWindow_Closed;
    }

    private void MainWindow_Closed(object sender, EventArgs e)
    {
        SettingWindow.CloseX();
        SaveWindow.CloseX();
    }

    private void Button_OpenSettingEditor_Click(object sender, RoutedEventArgs e)
    {
        SettingWindow.ShowOrActivate();
    }

    private void Button_OpenSaveEditor_Click(object sender, RoutedEventArgs e)
    {
        SaveWindow.ShowOrActivate();
    }
}
