namespace GradeCalc;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Calculate(object sender, EventArgs e)
    {
        if (!int.TryParse(TextNumGrade.Text, out int num))
        {
            LetterGrade.Text = "Please enter a valid number";
            return;
        }
        
        string letterGrade = "";
        if (num >= 90 && num <= 100)
        {
            letterGrade = "A+";
        }
        else if (num >= 85 && num <= 89)
        {
            letterGrade = "A";
        } 
        else if (num >= 80 && num <= 84)
        {
            letterGrade = "A-";
        }
        else if (num >= 77 && num <= 79)
        {
            letterGrade = "B+";
        }
        else if (num >= 73 && num <= 76)
        {
            letterGrade = "B";
        }
        else if (num >= 70 && num <= 72)
        {
            letterGrade = "B-";
        }
        else if (num >= 65 && num <= 69)
        {
            letterGrade = "C+";
        }
        else if (num >= 60 && num <= 64)
        {
            letterGrade = "C";
        }
        else if (num >= 55 && num <= 59)
        {
            letterGrade = "C-";
        }
        else if (num >= 50 && num <= 54)
        {
            letterGrade = "D";
        }
        else if (num >= 0 && num <= 49)
        {
            letterGrade = "F";
        }
        else
        {
            letterGrade = "Please enter a grade from 0-100";
        }

        if (letterGrade.Length == 1)
        {
            LetterGrade.Text = "Letter Grade: " + letterGrade;
        }
        else
        {
            LetterGrade.Text = letterGrade;
            return;
        }
    }
}