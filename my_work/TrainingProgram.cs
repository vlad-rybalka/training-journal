using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_work
{
    public class TrainingProgram
    {
        string filePath;
        TrainingLog mainForm;
        List<Day> dayList = new List<Day>();
        public TrainingProgram(TrainingLog mainForm)
        {
            this.mainForm = mainForm;
        }
        public TrainingProgram()
        {

        }
        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        public List<Day> DayList
        {
            get { return dayList; }
        }
        public void AddDay(Day day)
        {
            dayList.Add(day);
        }
        public Day FindTrainingDay (string date)
        {
            foreach(Day trainingDay in dayList)
            {
                if(trainingDay.Date == date)
                {
                    return trainingDay;
                }
            }
            return null;
        }
        public void ShowTrainingDaysInCalendar()
        {
            foreach(Day day in dayList)
            {
                if (day.ExerciseList.Count > 0)
                {
                    mainForm.ShowTariningDayInCalendar(day);
                }
            }
        }
    }
}
