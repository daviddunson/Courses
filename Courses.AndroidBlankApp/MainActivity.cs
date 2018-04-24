// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainActivity.cs" company="GSD Logic">
//   Copyright © 2018 GSD Logic. All Rights Reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Courses.AndroidBlankApp
{
    using System;
    using Android.App;
    using Android.OS;
    using Android.Widget;
    using Courses.Library;

    //[Activity(Label = "Courses", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private Button buttonNext;
        private Button buttonPrevious;
        private CourseManager courseManager;
        private ImageView imageView;
        private TextView textDescription;
        private TextView textTitle;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            this.SetContentView(Resource.Layout.Main);

            this.buttonPrevious = this.FindViewById<Button>(Resource.Id.buttonPrevious);
            this.buttonPrevious.Click += this.ButtonPrevious_Click;
            this.buttonNext = this.FindViewById<Button>(Resource.Id.buttonNext);
            this.buttonNext.Click += this.ButtonNext_Click;
            this.textTitle = this.FindViewById<TextView>(Resource.Id.textTitle);
            this.textDescription = this.FindViewById<TextView>(Resource.Id.textDescription);
            this.imageView = this.FindViewById<ImageView>(Resource.Id.imageView);
            this.courseManager = new CourseManager();
            this.courseManager.MoveFirst();

            this.Refresh();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            this.courseManager.MoveNext();
            this.Refresh();
        }

        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            this.courseManager.MovePrevious();
            this.Refresh();
        }

        private void Refresh()
        {
            this.textTitle.Text = this.courseManager.Current.Title;
            this.textDescription.Text = this.courseManager.Current.Description;
            this.imageView.SetImageResource(Resource.Drawable.FromString(this.courseManager.Current.Image));
            this.buttonPrevious.Enabled = this.courseManager.HasPrevious;
            this.buttonNext.Enabled = this.courseManager.HasNext;
        }
    }
}