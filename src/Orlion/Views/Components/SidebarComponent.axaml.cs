using System.Windows.Input;
using Avalonia;
using Avalonia.Controls.Primitives;
using Gml.Launcher.ViewModels.Components;

namespace Gml.Launcher.Views.Components;

public class SidebarComponent : TemplatedControl
{
    public static readonly StyledProperty<bool> IsBackendInactiveProperty =
        AvaloniaProperty.Register<SidebarComponent, bool>(
            nameof(IsBackendInactive), false);

    public static readonly StyledProperty<ICommand> LogoutCommandProperty =
        AvaloniaProperty.Register<SidebarComponent, ICommand>(
            nameof(LogoutCommand));

    public static readonly StyledProperty<ListViewModel> ListViewModelProperty =
        AvaloniaProperty.Register<SidebarComponent, ListViewModel>(
            nameof(ListViewModel));

    public bool IsBackendInactive
    {
        get => GetValue(IsBackendInactiveProperty);
    }

    public ListViewModel ListViewModel
    {
        get => GetValue(ListViewModelProperty);
        set => SetValue(ListViewModelProperty, value);
    }

    public ICommand LogoutCommand
    {
        get => GetValue(LogoutCommandProperty);
        set => SetValue(LogoutCommandProperty, value);
    }
}
