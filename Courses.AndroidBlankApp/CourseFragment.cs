// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CourseFragment.cs" company="GSD Logic">
//   Copyright © 2018 GSD Logic. All Rights Reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Courses.AndroidBlankApp
{
    using Android.OS;
    using Android.Support.V4.App;
    using Android.Views;
    using Android.Widget;
    using Courses.Library;

    public class CourseFragment : Fragment
    {
        private ImageView imageView;
        private TextView textDescription;
        private TextView textTitle;

        public CourseFragment(Course course)
        {
            this.Course = course;
        }

        public Course Course { get; }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var view = inflater.Inflate(Resource.Layout.CourseFragment, container, false);

            this.textTitle = view.FindViewById<TextView>(Resource.Id.textTitle);
            this.textDescription = view.FindViewById<TextView>(Resource.Id.textDescription);
            this.imageView = view.FindViewById<ImageView>(Resource.Id.imageView);

            this.textTitle.Text = this.Course.Title;
            this.textDescription.Text = this.Course.Description;
            this.imageView.SetImageResource(Resource.Drawable.FromString(this.Course.Image));

            return view;
        }
    }
}