// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CourseManager.cs" company="GSD Logic">
//   Copyright © 2018 GSD Logic. All Rights Reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Courses.Library
{
    using System.Collections.Generic;

    public class CourseManager
    {
        private readonly List<Course> courses;
        private int courseIndex;

        public CourseManager()
        {
            this.courses = new List<Course>
            {
                new Course
                {
                    Title = "Android for .NET Developers",
                    Description = "Development for Android.",
                    Image = "ps_top_card_01"
                },
                new Course
                {
                    Title = "iOS for .NET Developers",
                    Description = "Development for iOS.",
                    Image = "ps_top_card_02"
                },
                new Course
                {
                    Title = "Windows for .NET Developers",
                    Description = "Development for Windows.",
                    Image = "ps_top_card_03"
                }
            };
        }

        public Course Current => this.courses[this.courseIndex];

        public bool HasNext => this.courseIndex < this.courses.Count - 1;

        public bool HasPrevious => this.courseIndex > 0;

        public void MoveFirst()
        {
            this.courseIndex = 0;
        }

        public void MoveNext()
        {
            if (this.HasNext)
            {
                this.courseIndex++;
            }
        }

        public void MovePrevious()
        {
            if (this.HasPrevious)
            {
                this.courseIndex--;
            }
        }
    }
}