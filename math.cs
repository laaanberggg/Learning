using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace MurzaevIR
{
    public partial class Service
    {
        public SolidColorBrush NewPrice
        {
            get
            {
                SolidColorBrush br = new SolidColorBrush(System.Windows.Media.Color.FromRgb(231, 250, 191));
                if (Discount > 0)
                {
                    return br;
                }
                else
                {
                    return System.Windows.Media.Brushes.White;
                }
            }
        }
        public string Sale
        {
            get
            {
                if (Discount > 0)
                {
                    return "Strikethrough";
                }
                else
                {
                    return "";
                }
            }
        }
        public string ItogPrice
        {
            get
            {
                if (Discount > 0)
                {
                    return (Convert.ToInt32(Cost) - (Convert.ToInt32(Cost) * Discount)).ToString();
                }
                else
                {
                    return "";
                }
            }
        }
        public string Duration
        {
            get
            {
                return "Продолжительность: " + (DurationInSeconds / 60).ToString() + " минут";
            }
        }
    }
}

