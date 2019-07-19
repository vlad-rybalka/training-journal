using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_work
{
    public class Day
    {
        string date;
        List<Exercise> exerciseList = new List<Exercise>();
        public Day(string date)
        {
            this.date = date;
        }
        public Day()
        {

        }
        public List<Exercise> ExerciseList
        {
            get { return exerciseList; }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public void AddExercise(Exercise exercise)
        {
            exerciseList.Add(exercise);
        }
        public void ShowExercises()
        {
            foreach(Exercise exercise in exerciseList)
            {
                exercise.Show();
            }
        }
    }
}
