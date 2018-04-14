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

    [Activity(Label = "Courses", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private Button buttonNext;
        private Button buttonPrevious;
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
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            this.textTitle.Text = "Next Clicked";
            this.textDescription.Text = "The next button was clicked.";
            this.imageView.SetImageResource(Resource.Drawable.img33279);
        }

        private void ButtonPrevious_Click(object sender, EventArgs e)
        {
            this.textTitle.Text = "Previous Clicked";
            this.textDescription.Text = "The previous button was clicked.";
            this.imageView.SetImageResource(Resource.Drawable.img33280);
        }
    }
}