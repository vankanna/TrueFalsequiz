using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TrueFalsequiz
{
    public partial class MainPage : ContentPage
    {

        private List<Question> questions = new List<Question>();
        private int counter = 0;
        private int results = 0;
            
        
        public MainPage()
        {
            InitializeComponent();
            questions.Add(new Question("Apples are a fruit.", true, "apple.jpg")) ;
            questions.Add(new Question("The sun is a star.", true, "sun.jpg"));
            questions.Add(new Question("True is equal to False.", false, "truefalse.jpg"));
            questions.Add(new Question("Water freezes at 54.3 degrees fahrenheit.", false, "ice.jpg"));;
            questions.Add(new Question("South Korea is a peninsula.", true, "korea.jpg"));
            prompt.Text = questions[counter].question;
            img.Source = questions[counter].imgPath;


        }


        async void OnSwiped(object sender, SwipedEventArgs e)
        {
            if (counter < questions.Count)
            {
                if (e.Direction == SwipeDirection.Right && questions[counter].answer == true)
                {
                    results += 1;

                }
                else if (e.Direction == SwipeDirection.Left && questions[counter].answer == false)
                {
                    results += 1;

                }
            }
            counter++;

            if (counter >= questions.Count)
            {
            
                prompt.Text = "Your got " + results + "/5 correct!";
            }
            else
            {
                img.Source = questions[counter].imgPath;

                prompt.Text = questions[counter].question;

            }

        }
    }
}
