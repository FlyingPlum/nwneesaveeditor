using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace nwneesaveeditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //localization
            this.Title = (string)Application.Current.FindResource("MainWindowTitle");
            this.filemenu.Header = (string)Application.Current.FindResource("FileMenuHeader");
            this.helpmenu.Header = (string)Application.Current.FindResource("HelpMenuHeader");
            this.openfile.Icon = new System.Windows.Controls.Image
            {
                Source = new BitmapImage(new Uri("pack://application:,,,/Resources/Images/OpenFile_16x.png"))
            };
            this.openfile.Header = (string)Application.Current.FindResource("OpenFileHeader");
            this.closefile.Icon = new System.Windows.Controls.Image
            {
                Source = new BitmapImage(new Uri("pack://application:,,,/Resources/Images/CloseDocument_16x.png"))
            };
            this.closefile.Header = (string)Application.Current.FindResource("CloseFileHeader");
            this.savefile.Icon = new System.Windows.Controls.Image
            {
                Source = new BitmapImage(new Uri("pack://application:,,,/Resources/Images/Save_16x.png"))
            };
            this.savefile.Header = (string)Application.Current.FindResource("SaveFileHeader");
            this.saveasfile.Icon = new System.Windows.Controls.Image
            {
                Source = new BitmapImage(new Uri("pack://application:,,,/Resources/Images/SaveAs_16x.png"))
            };
            this.saveasfile.Header = (string)Application.Current.FindResource("SaveAsFileHeader");
            this.lang.Icon = new System.Windows.Controls.Image
            {
                Source = new BitmapImage(new Uri("pack://application:,,,/Resources/Images/LanguagePackageApplication_16x.png"))
            };
            this.lang.Header = (string)Application.Current.FindResource("LangHeader");
            this.about.Header = (string)Application.Current.FindResource("AboutHeader");
            this.feattab.Header = (string)Application.Current.FindResource("FeatTabHeader");
            this.spelltab.Header = (string)Application.Current.FindResource("SpellTabHeader");
            //add list and button
            //add message box for further information
            //add filter
            //click event handle
        }
    }
}
