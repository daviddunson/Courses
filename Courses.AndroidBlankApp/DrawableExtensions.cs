// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DrawableExtensions.cs" company="GSD Logic">
//   Copyright © 2018 GSD Logic. All Rights Reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Courses.AndroidBlankApp
{
    public partial class Resource
    {
        public partial class Drawable
        {
            public static int FromString(string resourceName)
            {
                return (int)typeof(Drawable).GetField(resourceName).GetValue(null);
            }
        }
    }
}