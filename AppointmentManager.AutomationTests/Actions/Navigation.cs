using AppointmentManager.AutomationTests.Helpers;

namespace AppointmentManager.AutomationTests.Actions
{
    public class Navigation
    {
        public static void NavigateTo()
        {
            Browser.NavigateTo(AppSettings.BaseUrl);
        }
    }
}