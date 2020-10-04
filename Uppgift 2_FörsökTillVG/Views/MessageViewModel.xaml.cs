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

namespace Uppgift_2_FörsökTillVG.Views
{
    /// <summary>
    /// Interaction logic for MessageViewModel.xaml
    /// </summary>
    public partial class MessageViewModel : UserControl
    {
        public MessageViewModel()
        {
            InitializeComponent();
        }

       

        private void ReadMessage1_Click(object sender, RoutedEventArgs e)
        {
            tbFrom.Text = "Elizabeth II";
            tbTo.Text = "Karl Andersson";
            tbSubject.Text = "Invitation";
            tbTime.Text = "09:14";
            tbDate.Text = "21 Augusti 2020";
            tbMessage.Text = "Greetings. I would like to invite you over to my birthdayparty. Please reply soon in order to get a good seat.";
            tbEnd.Text = "Sincerely Queen Elizabeth";
        }

        private void ReadMessage2_Click(object sender, RoutedEventArgs e)
        {
            tbFrom.Text = "Bert Karlsson";
            tbTo.Text = "Karl Andersson";
            tbSubject.Text = "Secret recipe!";
            tbTime.Text = "03:21";
            tbDate.Text = "12 Mars 2020";
            tbMessage.Text = "Hello there. I just wanted to say that i have finally discovered the semmelrecipe that i´ve been looking for and that i will share it with you when the time is right.";
            tbEnd.Text = "Sincerely Bert Karlsson King of Semlor";
        }

        private void ReadMessage3_Click(object sender, RoutedEventArgs e)
        {
            tbFrom.Text = "Frida Nilsson";
            tbTo.Text = "Karl Andersson";
            tbSubject.Text = "158 years!";
            tbTime.Text = "07:34";
            tbDate.Text = "2 Januari 2020";
            tbMessage.Text = "Hi! We would like your opinion on how we can celebrate Cloettas birthday. Do you have any flavorideas or eventideas? If you do, please reply as soon as possible so Cloettas 158ths birthday can be as good as possible ";
            tbEnd.Text = "Sincerely Frida Nilsson Cloetta AB";
        }

        private void ReadMessage4_Click(object sender, RoutedEventArgs e)
        {
            tbFrom.Text = "Peter Wilson";
            tbTo.Text = "Karl Andersson";
            tbSubject.Text = "We´ve been attacked!";
            tbTime.Text = "16:40";
            tbDate.Text = "9 December 2019";
            tbMessage.Text = "Hi. We discovered a hackingattempt this morning. We don´t know if they got hold on to any information but just in case, Please change your password.";
            tbEnd.Text = "Many Thanks Peter Wilson Ikea IT-Department";
        }

    }
}
