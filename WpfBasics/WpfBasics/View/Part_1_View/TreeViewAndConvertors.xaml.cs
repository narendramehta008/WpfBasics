using BaseLib.ConfigPack.GeneralConfig;
using BaseLib.ConfigPack.StringUtils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfBasics.View.Part_1_View
{
    /// <summary>
    /// Interaction logic for TreeViewAndConvertors.xaml
    /// </summary>
    public partial class TreeViewAndConvertors : UserControl
    {
        string ImagePath = @"D:\Programming\Programs\GitHub Repositories\WpfBasics\WpfBasics\BaseUIUtility\Assets\device-drive-icon"; //device-drive-icon
        public TreeViewAndConvertors()
        {
            InitializeComponent();
        }

        private static TreeViewAndConvertors SingletonObj;

        public static TreeViewAndConvertors GetSingletonObj()
            => SingletonObj ?? (SingletonObj = new TreeViewAndConvertors());

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach( var drive in Directory.GetLogicalDrives())
                {
                    var item = new TreeViewItem();
                    item.Header = drive;
                    item.Tag = drive;
                    item.Items.Add(null);
                    item.Expanded += FolderExpanded;
                    FolderView.Items.Add(item);
                }
            }catch(Exception ex)
            {
                ex.ErrorLog();
            }

        }

        private void FolderExpanded(object sender, RoutedEventArgs e)
        {
            try
            {
                #region initial check 
                var item = (TreeViewItem)sender;
                if (item.Items.Count != 1 || item.Items[0] != null)
                    return;

                item.Items.Clear();
                var fullPath = item.Tag as string;
                #endregion

                #region get directories
                var directories = new List<string>();

                try
                {
                    var tempdirectories = Directory.GetDirectories(fullPath);
                    if (tempdirectories.Length > 0)
                        directories.AddRange(tempdirectories);
                }
                catch (Exception ex)
                {
                    ex.ErrorLog();
                }
                #endregion

                #region set folder event on fetched dir
                directories.ForEach(dir =>
                      {
                          var treeViewItem = new TreeViewItem()
                          {
                              Header = StringHelper.GetFileFolderName(dir),
                              Tag = dir
                          };
                    //dummy item so we expand folder
                    treeViewItem.Items.Add(null);
                    //adding event when folder expanded
                    treeViewItem.Expanded += FolderExpanded;
                          // Add this item to the parent
                          item.Items.Add(treeViewItem);

                      });
                #endregion

                #region Get Files

                // Create a blank list for files
                var files = new List<string>();

                // Try and get files from the folder
                // ignoring any issues doing so
                try
                {
                    var fs = Directory.GetFiles(fullPath);

                    if (fs.Length > 0)
                        files.AddRange(fs);
                }
                catch { }

                // For each file...
                files.ForEach(filePath =>
                {
                    // Create file item
                    var subItem = new TreeViewItem()
                    {
                        // Set header as file name
                        Header = StringHelper.GetFileFolderName(filePath),
                        // And tag as full path
                        Tag = filePath
                    };

                    // Add this item to the parent
                    item.Items.Add(subItem);
                });

                #endregion

            }
            catch (Exception ex)
            {
                ex.ErrorLog();
            }
        }
    }
}
