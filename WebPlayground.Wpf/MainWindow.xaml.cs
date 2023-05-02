using CefSharp;
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

namespace WebPlayground.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            htmlTextBox.Text = Resource.HtmlBody;
            cssTextBox.Text = Resource.CssContent;
            jsTextBox.Text = Resource.JSContent;
            RunHtml();
        }
        private void Run_Click(object sender, RoutedEventArgs e)
        {
            RunHtml();
        }
        private void RunHtml()
        {
            string html = htmlTextBox.Text;
            string css = "<style>" + cssTextBox.Text + "</style>";
            string js = "<script>" + jsTextBox.Text + "</script>";

            string fullHtml = html + css + js;
            webBrowser.LoadHtml(fullHtml);
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            htmlTextBox.Clear();
            cssTextBox.Clear();
            jsTextBox.Clear();
            webBrowser.LoadHtml("");
        }
    }
}
