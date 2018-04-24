// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CoursePagerAdapter.cs" company="GSD Logic">
//   Copyright © 2018 GSD Logic. All Rights Reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Courses.AndroidBlankApp
{
    using Android.Support.V4.App;
    using Courses.Library;

    public class CoursePagerAdapter : FragmentStatePagerAdapter
    {
        private readonly CourseManager courseManager;

        public CoursePagerAdapter(FragmentManager fm, CourseManager courseManager)
            : base(fm)
        {
            this.courseManager = courseManager;
        }

        public override int Count => this.courseManager.Count;

        public override Fragment GetItem(int position)
        {
            this.courseManager.MoveTo(position);
            return new CourseFragment(this.courseManager.Current);
        }
    }
}