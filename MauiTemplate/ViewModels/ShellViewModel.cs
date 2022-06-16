using MauiTemplate.Models;
using MauiTemplate.Pages;
using MauiTemplate.Resources.Strings;
using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTemplate.ViewModels
{
    public class ShellViewModel : BaseViewModel
    {
        public AppSection Discover { get; set; }
        public AppSection Subscriptions { get; set; }
        public AppSection Lists { get; set; }
        public AppSection ListenLater { get; set; }
        public AppSection Settings { get; set; }
        public AppSection ListenTogether { get; set; }

        public ShellViewModel()
        {
            Discover = new AppSection() { Title = AppResource.wellcome, Icon = "discover.png", IconDark = "discover_dark.png", TargetType = typeof(DiscoverPage) };
            //Subscriptions = new AppSection() { Title = AppResource.wellcome, Icon = "subscriptions.png", IconDark = "subscriptions_dark.png", TargetType = typeof(SubscriptionsPage) };
            //ListenLater = new AppSection() { Title = Config.Desktop ? AppResource.wellcome : AppResource.wellcome, Icon = "clock.png", IconDark = "clock_dark.png", TargetType = typeof(ListenLaterPage) };
            //ListenTogether = new AppSection() { Title = Config.Desktop ? AppResource.wellcome : AppResource.wellcome, Icon = "listentogether.png", IconDark = "listentogether_dark.png", TargetType = typeof(SettingsPage) };
            Settings = new AppSection() { Title = AppResource.wellcome, Icon = "settings.png", IconDark = "settings_dark.png", TargetType = typeof(SettingsPage) };
        }
    }
}
