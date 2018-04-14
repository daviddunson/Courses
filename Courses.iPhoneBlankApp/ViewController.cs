// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ViewController.cs" company="GSD Logic">
//   Copyright © 2018 GSD Logic. All Rights Reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Courses.iPhoneBlankApp
{
    using System;
    using Courses.Library;
    using UIKit;

    public partial class ViewController : UIViewController
    {
        private CourseManager courseManager;

        public ViewController() : base("ViewController", null)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            this.previousButton.TouchUpInside += this.PreviousButton_TouchUpInside;
            this.nextButton.TouchUpInside += this.NextButton_TouchUpInside;
            this.courseManager = new CourseManager();
            this.courseManager.MoveFirst();

            this.Refresh();
        }

        private void NextButton_TouchUpInside(object sender, EventArgs e)
        {
            this.courseManager.MoveNext();
            this.Refresh();
        }

        private void PreviousButton_TouchUpInside(object sender, EventArgs e)
        {
            this.courseManager.MovePrevious();
            this.Refresh();
        }

        private void Refresh()
        {
            this.titleLabel.Text = this.courseManager.Current.Title;
            this.descriptionLabel.Text = this.courseManager.Current.Description;
            this.imageView.Image = UIImage.FromBundle(string.Concat(this.courseManager.Current.Image, ".jpg"));
            this.previousButton.Enabled = this.courseManager.HasPrevious;
            this.nextButton.Enabled = this.courseManager.HasNext;
        }
    }
}