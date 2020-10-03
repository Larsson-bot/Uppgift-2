using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Uppgift_2_FörsökTillVG.Controls
{
    /// <summary>
    /// Interaction logic for ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        public ContactControl()
        {
            InitializeComponent();
        }
        public ImageSource ContactImage
        {
            get { return igecontactImage.Source; }
            set { igecontactImage.Source = value; }
        }
        public string ContactName
        {
            get { return tbfullName.Text; }
            set { tbfullName.Text = value; }
        }
        public string Catagory
        {
            get { return tbcategory.Text;}
            set { tbcategory.Text = value; }
        }
    }
}
