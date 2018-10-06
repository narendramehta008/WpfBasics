using BaseLib.ConfigPack.StringUtils;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace BaseUIUtility.Convertor
{
    [ValueConversion (typeof(string),typeof(BitmapImage))]

    public class HeaderToImageConvertor : IValueConverter
    {
        public static HeaderToImageConvertor Instance = new HeaderToImageConvertor();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var path = (string)value;

            //MaterialDesignThemes.Wpf.PackIcon packIcon = new MaterialDesignThemes.Wpf.PackIcon();
            //packIcon.Kind = PackIconKind.Folder;

            if (path == null)
                return null;
            string name = StringHelper.GetFileFolderName(path);
            var image = @"D:\Programming\Programs\GitHub Repositories\WpfBasics\WpfBasics\BaseUIUtility\Assets\file.png";

            if (string.IsNullOrEmpty(name))
                image = @"D:\Programming\Programs\GitHub Repositories\WpfBasics\WpfBasics\BaseUIUtility\Assets\device-drive-icon.png";
           else if (new FileInfo(path).Attributes.HasFlag(FileAttributes.Directory))
                image = @"D:\Programming\Programs\GitHub Repositories\WpfBasics\WpfBasics\BaseUIUtility\Assets\if_folder_299060.png";

            try
            {
                string demos = @"D:\Programming\Programs\GitHub Repositories\WpfBasics\WpfBasics\BaseUIUtility\Assets\device-drive-icon.png";
                var fileInfo = new FileInfo(demos);
                var demo= new BitmapImage(new Uri($"{image}"));
            }
            catch(Exception ex)
            {

            }

            return new BitmapImage(new Uri($"{image}"));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
