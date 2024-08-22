using AuthenticationViewModelPlugin;
using Avalonia.Controls;
using MockAuthentication;

namespace AuthPluginTest.Views;

public partial class MainView : UserControl
{
    AuthenticationViewModel _authVm = new AuthenticationViewModel();


    public MainView()
    {
        _authVm.TheAuthenticationService = new MockAuthenticationService();
        this.DataContext = _authVm;

        _authVm.PropertyChanged += _authVm_PropertyChanged;

        InitializeComponent();
    }

    private void _authVm_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        
    }
}