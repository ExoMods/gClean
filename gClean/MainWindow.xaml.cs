using System;
using System.Collections.Generic;
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
using System.Windows.Threading;
using System.IO;
using System.Diagnostics;

namespace gClean
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>


    // If you want to edit the Window it may act weird as a lot of components resize automatically, you can deactivate it to resize it correctly.
    // That's also why some objects may look off centered in the Designer, but they look good when built.
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void timer_tick(object sender, EventArgs e)
        {

        }

        public static string path = "";
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string path = textbox.Text;
            string dpath = "\\garrysmod\\data";
            string apath = "\\garrysmod\\addons";
            string cpath = "\\garrysmod\\cache\\lua";
            string upath = "\\garrysmod\\download\\user_custom";
            string wcpath = "\\garrysmod\\cache\\workshop";
            string dupepath = "\\garrysmod\\dupes";
            string savepath = "\\garrysmod\\saves";
            string demopath = "\\garrysmod\\demos";
            string configpath = "\\garrysmod\\cfg";
            string luapath = "\\garrysmod\\lua";
            // MessageBox.Show(textbox.Text + dpath);


            if (Directory.Exists(path))
            {
                var lw = new LoadingWindow();  // The following code is very skiddy, please don't judge me
                
                if (Directory.Exists(path + dpath))
                {
                    Directory.Delete(path + dpath, true);
                }

                if (Directory.Exists(path + cpath))
                {
                    Directory.Delete(path + cpath, true);
                }

                if (Directory.Exists(path + upath))
                {
                    Directory.Delete(path + upath, true);
                }

                if (Directory.Exists(path + configpath))
                {
                    Directory.Delete(path + configpath, true);
                }

                if (Directory.Exists(path + luapath))
                {
                    Directory.Delete(path + luapath, true);
                }

                if (Directory.Exists(path + dupepath))
                {
                    Directory.Delete(path + dupepath, true);
                }

                if (Directory.Exists(path + savepath))
                {
                    Directory.Delete(path + savepath, true);
                }

                if (Directory.Exists(path + demopath))
                {
                    Directory.Delete(path + demopath, true);
                }

                if (Directory.Exists(path + apath))
                {
                    Directory.Delete(path + apath, true);
                }

                // the following code is for removing the .cache files within the workshop folder, some sophisticated servers may leave traces there. 

                if (Directory.Exists(path + wcpath))
                {
                DirectoryInfo di = new DirectoryInfo(path + wcpath);
                FileInfo[] files = di.GetFiles("*.cache")
                                     .Where(p => p.Extension == ".cache").ToArray();
                foreach (FileInfo file in files)
                    try
                    {
                        file.Attributes = FileAttributes.Normal;
                        File.Delete(file.FullName);
                    }
                    catch { }
                }

                if (File.Exists(path + "\\garrysmod\\cl.db"))
                {
                    File.Delete(path + "\\garrysmod\\cl.db");
                }

                if (File.Exists(path + "\\garrysmod\\mn.db"))
                {
                    File.Delete(path + "\\garrysmod\\mn.db");
                }

                if (File.Exists(path + "\\garrysmod\\sv.db"))
                {
                    File.Delete(path + "\\garrysmod\\sv.db");
                }

                if (File.Exists(path + "\\garrysmod\\settings\\users.txt"))
                {
                    File.Delete(path + "\\garrysmod\\settings\\users.txt");
                }


                lw.Show();
            }
            else
            {
                var ew = new Error();
                ew.Show();
            }
        }

        private void Button_MouseHover(object sender, EventArgs e)
        {

        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Properties.Settings.Default.pathtxt = textbox.Text;
            Properties.Settings.Default.Save();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textbox.Text = Properties.Settings.Default.pathtxt;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var lw = new LoadingWindow();
            lw.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var sw = new SettingsWindow();
            sw.Show();
        }

        private void textbox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
