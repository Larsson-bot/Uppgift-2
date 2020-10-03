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
    /// Interaction logic for MessageControl.xaml
    /// </summary>
    public partial class MessageControl : UserControl
    {
        public MessageControl()
        {
            InitializeComponent();
        }
    
        public string Subject
        {
            get { return tbSubject.Text; }
            set { tbSubject.Text = value; }
        }
        public string Time
        {
            get { return tbTime.Text; }
            set { tbTime.Text = value; }
        }
        public string Date
        {
            get { return tbDate.Text; }
            set { tbDate.Text = value; }
        }
        public string To
        {
            get { return tbFrom.Text; }
            set { tbFrom.Text = value; }
        }


    }
}
