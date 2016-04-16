// --------------------------------------------------------------------------------------------------------------------
// <summary>
//    Defines the DetailView type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace ATControl.Droid.Views
{
    using Android.App;
    using Android.OS;

    /// <summary>
    /// Defines the DetailView type.
    /// </summary>
    [Activity(Label = "View for DetailView")]
    public class  DetailView : BaseView
    {
        /// <summary>
        /// Called when [create].
        /// </summary>
        /// <param name="bundle">The bundle.</param>
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            this.SetContentView(Resource.Layout.DetailView);
        }
    }
}
