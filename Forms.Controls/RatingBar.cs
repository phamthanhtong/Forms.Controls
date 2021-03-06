﻿using Xamarin.Forms;

namespace Messier16.Forms.Controls
{
    public class RatingBar : View
    {
        public static readonly BindableProperty RatingProperty =
            BindableProperty.Create(nameof(Rating), typeof(int), typeof(RatingBar), 0);

        public static readonly BindableProperty ImageProperty =
            BindableProperty.Create(nameof(Image), typeof(FileImageSource), typeof(RatingBar),
                default(FileImageSource));

        public static readonly BindableProperty FilledImageProperty =
            BindableProperty.Create(nameof(FilledImage), typeof(FileImageSource), typeof(RatingBar),
                default(FileImageSource));

        public static readonly BindableProperty FillColorProperty =
            BindableProperty.Create(nameof(FillColor), typeof(Color), typeof(RatingBar), default(Color));

        public int Rating
        {
            get => (int) GetValue(RatingProperty);
            set => SetValue(RatingProperty, value);
        }

        public FileImageSource Image
        {
            get => (FileImageSource) GetValue(ImageProperty);
            set => SetValue(ImageProperty, value);
        }

        public FileImageSource FilledImage
        {
            get => (FileImageSource) GetValue(FilledImageProperty);
            set => SetValue(FilledImageProperty, value);
        }

        public Color FillColor
        {
            get => (Color) GetValue(FillColorProperty);
            set => SetValue(FillColorProperty, value);
        }

        public int MaxRating { get; set; }
    }
}