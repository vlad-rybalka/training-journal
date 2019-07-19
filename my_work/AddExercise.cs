using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace my_work
{
    public partial class AddExercise : Form
    {
        TrainingLog main;
        List<Exercise> selectedGroup;
        public AddExercise(TrainingLog main)
        {
            InitializeComponent();
            this.main = main;
        }
        private void add_Click(object sender, EventArgs e)
        {
            Exercise exercise = new Exercise(exerciseBox.SelectedItem.ToString(), main.DataBase);
            if (main.SelectedDay == null)
            {
                main.SelectedDay = new Day(main.SelectedDate);
                main.DataBase.Program.AddDay(main.SelectedDay);
            }
            main.SelectedDay.AddExercise(exercise);
            main.LoadDay();
            this.Hide();
        }
        private void groupBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            exerciseBox.Items.Clear();
            selectedGroup = main.DataBase.LoadDirectory(groupBox.SelectedIndex);
            foreach (Exercise exercise in selectedGroup)
            {
                exerciseBox.Items.Add(exercise.Name);
            }
            exerciseBox.SelectedIndex = 0;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddExercise_Load(object sender, EventArgs e)
        {
            groupBox.SelectedIndex = 0;
        }

        private void AddExercise_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
