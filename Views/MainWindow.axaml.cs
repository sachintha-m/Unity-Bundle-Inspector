using Avalonia.Controls;
using UnityBundleInspector.ViewModels;

namespace UnityBundleInspector.Views;

public partial class MainWindow : Window
{
    public MainWindow(MainViewModel viewModel)
    {
        InitializeComponent();
        
        DataContext = viewModel;
    }
}