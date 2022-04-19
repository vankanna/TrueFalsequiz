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
            questions.Add(new Question("Apples are a fruit.", true));
            questions.Add(new Question("The sun is a star.", true));
            questions.Add(new Question("True is equal to False.", false));
            questions.Add(new Question("Water freezes at 54.3 degrees fahrenheit.", false));;
            questions.Add(new Question("South Korea is a peninsula.", true));
            prompt.Text = questions[counter].question;

        }

        async void OnButtonClicked(object sender, EventArgs args)
        {

            if (((Button)sender).Text == "True" && questions[counter].answer == true)
            {
                results += 1;
                result.Text = results.ToString();
            }
            else if (((Button)sender).Text == "False" && questions[counter].answer == false)
            {
                results += 1;
                result.Text = results.ToString();

            }

            if (counter >= questions.Count - 1)
            {
                prompt.Text = "Your got " + results + "/5 correct!";
            } else
            {

                counter++;
                prompt.Text = questions[counter].question;

            }




            // Create a True/False Quiz App.  This has one page with a Label for the question and two Buttons: True and False.

            //After five questions, the Buttons should cease to be displayed and results should be displayed in the question label.

            //Make this app look as professional as possible.

            //Use Shared Resources, etc...  This will require that you read online documentation, etc...

            //Additionally, provide a wireframe for the App.





        }
    }
}
