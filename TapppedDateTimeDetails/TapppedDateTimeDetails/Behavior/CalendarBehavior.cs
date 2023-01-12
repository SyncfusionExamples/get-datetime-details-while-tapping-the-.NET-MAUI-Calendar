using Syncfusion.Maui.Calendar;

namespace TapppedDateTimeDetails
{
    public class CalendarBehavior : Behavior<SfCalendar>
    {
        private SfCalendar calendar;

        protected override void OnAttachedTo(SfCalendar bindable)
        {
            base.OnAttachedTo(bindable);
            this.calendar = bindable;
            this.calendar.Tapped += calendar_Tapped;
        }

        private void calendar_Tapped(object sender, CalendarTappedEventArgs e)
        {
            App.Current.MainPage.DisplayAlert("Tapped date details", e.Date.ToString("dddd, dd MMMM yyyy"), "OK");
        }

        protected override void OnDetachingFrom(SfCalendar bindable)
        {
            base.OnDetachingFrom(bindable);

            if (this.calendar != null)
            {
                this.calendar.Tapped -= calendar_Tapped;
            }

            this.calendar = null;
        }
    }
}
