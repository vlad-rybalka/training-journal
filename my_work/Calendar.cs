using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_work
{
    public partial class Calendar : UserControl
    {

        public event ObjectStringDelegate SetDate;
        public event ObjectStringDelegate DrawCalendarEvent;
        Button[] buttonsCal;
        public DateTime dateStart;
        DateTime activeDate;
        Image hoverButtonBG;
        Color hoverButtonText;
        Image activeButtonBG;
        Color activeButtonTextColor;
        Button activeButton;

        public Calendar()
        {
            InitializeComponent();
        }
        public DateTime ValueDate
        {
            get { return activeDate; }
        }
        private void Calendar_Load(object sender, EventArgs e)
        {
            dateStart = DateTime.Now;
            buttonsCal = new Button[] 
            {
                butCal0, butCal1, butCal2, butCal3, butCal4, butCal5,
                butCal6, butCal7, butCal8, butCal9, butCal10, butCal11, butCal12, butCal13,
                butCal14, butCal15, butCal16, butCal17, butCal18, butCal19, butCal20, butCal21,
                butCal22, butCal23, butCal24, butCal25, butCal26, butCal27, butCal28, butCal29,
                butCal30, butCal31, butCal32, butCal33, butCal34, button2, button3, button4,
                button5, button6, button7, button8
            };
            DrawCalendar(dateStart);
        }
        public void DrawCalendar(DateTime date)
        {
            DelActiveButton();
            int month = Convert.ToInt32(date.ToString("MM"));
            int year = Convert.ToInt32(date.ToString("yyyy"));
            DateTime startDate = new DateTime(year, month, 1);
            month_year.Text = startDate.ToString("MMMM") + " " + startDate.ToString("yyyy");
            startDate = startDate.AddDays(-(double)startDate.DayOfWeek + 1);
            for (int i = 0; i < 42; i++)
            {
                buttonsCal[i].BackgroundImage = null;
                buttonsCal[i].Text = startDate.ToString("dd").TrimStart('0');
                buttonsCal[i].Name = startDate.ToShortDateString();
                if(startDate.ToString("MM") != date.ToString("MM"))
                {
                    buttonsCal[i].ForeColor = Color.FromArgb(140, 159, 167);
                    hoverButtonText = Color.FromArgb(140, 159, 167);
                }
                else
                {
                    buttonsCal[i].ForeColor = Color.FromArgb(0, 39, 57);
                    hoverButtonText = Color.FromArgb(0, 39, 57);
                }
                if (startDate.ToShortDateString() == DateTime.Now.ToShortDateString())
                {
                    SetActiveButton(buttonsCal[i]);
                    activeButtonBG = null;
                }
                startDate = startDate.AddDays(1);

            }
            DrawCalendarEvent?.Invoke(this);
        }
        private void PreviousMonth(object sender, EventArgs e)
        {
            dateStart = dateStart.AddMonths(-1);
            DrawCalendar(dateStart);
        }
        private void NextMonth(object sender, EventArgs e)
        {
            dateStart = dateStart.AddMonths(1);
            DrawCalendar(dateStart);
        }
        private void buttonOn(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            if (!but.Equals(activeButton))
            {
                hoverButtonBG = but.BackgroundImage;
                hoverButtonText = but.ForeColor;
                but.ForeColor = Color.FromArgb(234, 234, 234);
                but.BackgroundImage = Properties.Resources.hover;
            }
        }
        private void buttonDown(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            if (!but.Equals(activeButton))
            {
                but.BackgroundImage = hoverButtonBG;
                but.ForeColor = hoverButtonText;
            }
        }
        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            SetActiveButton((Button)sender);
        }
        private void SetActiveButton (Button button)
        {
            if (activeButton != button)
            {
                DelActiveButton();
                activeButtonBG = hoverButtonBG;
                activeButtonTextColor = hoverButtonText;
                hoverButtonText = Color.FromArgb(234, 234, 234);
                hoverButtonBG = Properties.Resources.active;
                activeButton = button;
                button.BackgroundImage = hoverButtonBG;
                button.ForeColor = hoverButtonText;
            }
            activeDate = DateTime.Parse(button.Name);
            SetDate?.Invoke(this);
        }
        private void DelActiveButton()
        {
            if (activeButton != null)
            {
                activeButton.BackgroundImage = activeButtonBG;
                activeButton.ForeColor = activeButtonTextColor;
                activeButtonBG = null;
                activeButton = null;
            }
        }
        public void ShowTrainingDay(Day trainingDay)
        {
            foreach(Button b in buttonsCal)
            {
                if (trainingDay.Date == b.Name && !b.Equals(activeButton))
                {
                    b.BackgroundImage = Properties.Resources.traningDay;
                }
                else if (trainingDay.Date == b.Name && b.Equals(activeButton))
                {
                    activeButtonBG = Properties.Resources.traningDay;
                }
                else if (trainingDay.Date != b.Name && b.Equals(activeButton))
                {
                    activeButtonBG = null;
                }
            }
        }
    }
}
