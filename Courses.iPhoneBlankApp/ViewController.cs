// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ViewController.cs" company="GSD Logic">
//   Copyright © 2018 GSD Logic. All Rights Reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Courses.iPhoneBlankApp
{
    using System;
    using UIKit;

    public partial class ViewController : UIViewController
    {
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
        }

        private void NextButton_TouchUpInside(object sender, EventArgs e)
        {
            this.titleLabel.Text = "Next Clicked";
            this.descriptionLabel.Text = "The next button was clicked.";
            this.imageView.Image = UIImage.FromBundle("img33278.jpg");
        }

        private void PreviousButton_TouchUpInside(object sender, EventArgs e)
        {
            this.titleLabel.Text = "Previous Clicked";
            this.descriptionLabel.Text = "The previous button was clicked.";
            this.imageView.Image = UIImage.FromBundle("img33279.jpg");
        }
    }
}