// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CourseActivity.cs" company="GSD Logic">
//   Copyright © 2018 GSD Logic. All Rights Reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Courses.AndroidBlankApp
{
    using Android.App;
    using Android.OS;
    using Android.Support.V4.App;
    using Android.Support.V4.View;
    using Courses.Library;

    [Activity(Label = "Courses", MainLauncher = true)]
    public class CourseActivity : FragmentActivity
    {
        private CourseManager courseManager;
        private CoursePagerAdapter coursePagerAdapter;
        private ViewPager viewPager;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            this.SetContentView(Resource.Layout.CourseActivity);

            this.courseManager = new CourseManager();
            this.courseManager.MoveFirst();

            this.coursePagerAdapter = new CoursePagerAdapter(this.SupportFragmentManager, this.courseManager);

            this.viewPager = this.FindViewById<ViewPager>(Resource.Id.coursePager);
            this.viewPager.Adapter = this.coursePagerAdapter;
        }
    }
}