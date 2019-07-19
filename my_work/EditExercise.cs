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
    public partial class EditExercise : Form
    {
        Exercise exercise;
        public EditExercise(Exercise exercise)
        {
            InitializeComponent();
            this.exercise = exercise;
        }
        private void LoadApproaches()
        {
            listApproaches.Items.Clear();
            int i = 1;
            foreach(Approach approach in exercise.ApproachList)
            {
                listApproaches.Items.Add(i + ". Вес(кг): " + approach.Weight + " Повторы(раз): " + approach.Repetition);
                i++;
            }
        }

        private void EditExercise_Load(object sender, EventArgs e)
        {
            LoadApproaches();
        }

        private void add_Click(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(repetition.Value);
            float w = Convert.ToSingle(weight.Value);
            exercise.AddApproach(new Approach(w,r));
            LoadApproaches();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (listApproaches.SelectedItem != null)
            {
                exercise.DeleteApproach(exercise.ApproachList[listApproaches.SelectedIndex]);
                LoadApproaches();
            }
            else
            {
                exercise.DataBase.MainForm.ShowError("Выберите подход!");
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void moveUp_Click(object sender, EventArgs e)
        {
            if (listApproaches.SelectedItem != null)
            {
                exercise.MoveUpApproaches(listApproaches.SelectedIndex);
                LoadApproaches();
            }
            else
            {
                exercise.DataBase.MainForm.ShowError("Выберите подход!");
            }
        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            if (listApproaches.SelectedItem != null)
            {
                exercise.MoveDownApproaches(listApproaches.SelectedIndex);
                LoadApproaches();
            }
            else
            {
                exercise.DataBase.MainForm.ShowError("Выберите подход!");
            }
        }

        private void EditExercise_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
