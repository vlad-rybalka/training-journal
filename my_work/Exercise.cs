using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace my_work
{
    public partial class Exercise : UserControl
    {
        List<Approach> approachesList = new List<Approach>();
        Label[] arrayNumberApproachUI;
        Label[] arrayRepetitionUI;
        Label[] arrayWeightUI;
        DataBase db;
        int sumRepetition;
        float sumWeight;
        string info;
        public Exercise()
        {
            InitializeComponent();
        }
        public Exercise(string name)
        {
            InitializeComponent();
            Name = name;
        }
        public Exercise(string name, DataBase db)
        {
            InitializeComponent();
            Name = name;
            this.db = db;
        }
        public string Img1 { get; set; }
        public string Img2 { get; set; }
        public List<Approach> ApproachList
        {
            get { return approachesList; }
        }
        public DataBase DataBase
        {
            get { return db; }
        }
        public new string Name
        {
            get { return name.Text; }
            set { name.Text = value; }
        }
        public string Info
        {
            get { return info; }
            set { info = value; }
        }
        public void AddApproach(Approach approach)
        {
            if (approachesList.Count < 5)
            {
                approachesList.Add(approach);
                sumWeight += approach.Weight;
                sumRepetition += approach.Repetition;
            }
            ShowApproches();
        }
        public void DeleteApproach(Approach approach)
        {
            sumWeight -= approach.Weight;
            sumRepetition -= approach.Repetition;
            approachesList.Remove(approach);
            ShowApproches();
        }
        public void ShowApproches()
        { 
            arrayNumberApproachUI = new Label[] { app1, app2, app3, app4, app5};
            arrayWeightUI = new Label[] { weight1, weight2, weight3, weight4, weight5 };
            arrayRepetitionUI = new Label[] { repetition1, repetition2, repetition3, repetition4, repetition5 };
            for(int i = 4; i>=0; i--)
            {
                if ((i - 4 + approachesList.Count) > 0)
                {
                    arrayNumberApproachUI[i].Text = (i - 4 + approachesList.Count).ToString();
                    arrayWeightUI[i].Text = approachesList[i - 5 + approachesList.Count].Weight.ToString();
                    arrayRepetitionUI[i].Text = approachesList[i - 5 + approachesList.Count].Repetition.ToString();
                }
                else
                {
                    arrayNumberApproachUI[i].Text = " ";
                    arrayWeightUI[i].Text = " ";
                    arrayRepetitionUI[i].Text = " ";
                }
            }
            repetitionSum.Text = sumRepetition.ToString();
            weightSum.Text = sumWeight.ToString();
            HideInfo();
        }
        public void MoveUpApproaches(int index)
        {
            if (index > 0)
            {
                Approach a;
                a = approachesList[index];
                approachesList[index] = approachesList[index - 1];
                approachesList[index - 1] = a;
                ShowApproches();
            }
        }
        public void MoveDownApproaches(int index)
        {
            if (index < approachesList.Count-1)
            {
                Approach a;
                a = approachesList[index];
                approachesList[index] = approachesList[index + 1];
                approachesList[index + 1] = a;
                ShowApproches();
            }
        }
        public new void Show()
        {
            db.MainForm.ShowExercise(this);
        }
        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show(
                    "Вы действительно хотите удалить упражнение?",
                    "Удаление",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
            if (delete == DialogResult.Yes)
            {
                db.MainForm.SelectedDay.ExerciseList.Remove(this);
                db.MainForm.LoadDay();
            }
        }
        private void edit_Click(object sender, EventArgs e)
        {
            EditExercise editForm = new EditExercise(this);
            editForm.ShowDialog();
        }

        private void HideInfo()
        {
            if(approachesList.Count > 0)
            {
                infoPanel.BackgroundImage = null;
            }
        }

    }
}
