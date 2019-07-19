using System;
using my_work;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace my_work
{

    public partial class TrainingLog : Form
    {
        Day selectedDay;
        string selectedDate;
        List<Exercise> selectedGroup = new List<Exercise>();
        Point moveStart;
        DataBase db;

        int exercisesGroupPage = 0;
        int programPage = 1;
        int exercisesPage = 2;
        public TrainingLog()
        {
            InitializeComponent();
            db = new DataBase(this);
        }
        public DataBase DataBase
        {
            get { return db; }
        }
        public string SelectedDate
        {
            get { return selectedDate; }
        }
        public Day SelectedDay
        {
            set { selectedDay = value; }
            get { return selectedDay; }
        }

        //form
        private void TrainingLog_Load(object sender, EventArgs e)
        {
            TabControl.ItemSize = new Size(0, 1);
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Turn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void TrainingLog_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                moveStart = new Point(e.X, e.Y);
            }
        }
        private void TrainingLog_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                Point deltaPos = new Point(e.X - moveStart.X, e.Y - moveStart.Y);
                this.Location = new Point(this.Location.X + deltaPos.X,
                  this.Location.Y + deltaPos.Y);
            }
        }

        //directory
        private void Directory_B_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab(exercisesGroupPage);
            lineDirectory.Visible = true;
            lineProgram.Visible = false;
        }
        private void backB_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab(0);
        }
        private void LogButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int indexGroup = Convert.ToInt32(button.Name.Substring(1));
            selectedGroup = db.LoadDirectory(indexGroup);
            LoadExercisesList();
        }
        private void LoadExercisesList()
        {
            treeExercises.Nodes.Clear();
            foreach (Exercise exercise in selectedGroup)
            {
                treeExercises.Nodes.Add(exercise.Name);
            }
            TabControl.SelectTab(exercisesPage);
        }
        private void treeExercises_AfterSelect(object sender, TreeViewEventArgs e)
        {
            nameExercise.Text = selectedGroup[treeExercises.SelectedNode.Index].Name;
            infoExercise.Text = selectedGroup[treeExercises.SelectedNode.Index].Info;
            image1.BackgroundImage = (Bitmap)Image.FromFile("img/"+ selectedGroup[treeExercises.SelectedNode.Index].Img1); 
            image2.BackgroundImage = (Bitmap)Image.FromFile("img/" + selectedGroup[treeExercises.SelectedNode.Index].Img2);
        }

        //training program
        private void Program_B_Click(object sender, EventArgs e)
        {
            if(DataBase.Program == null)
            {
                CreateProgram();
            }
            else
            {
                TabControl.SelectTab(programPage);
            }
            TabControl.SelectTab(programPage);
            lineDirectory.Visible = false;
            lineProgram.Visible = true;
        }
        public void LoadDay()
        {
            ListExersises.Controls.Clear();
            selectDayText.Text = Calendar.ValueDate.ToLongDateString();
            if (selectedDay != null)
            {
                selectedDay.ShowExercises();
            }
            else
            {
                //подсказка для создания упражнения
            }
            ListExersises.Controls.Add(CreateAddButton());
            DataBase.Program.ShowTrainingDaysInCalendar();
        }
        private Button CreateAddButton()
        {
            Button button = new Button();
            button.Size = new Size(615, 50);
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Franklin Gothic Medium", 15);
            button.Text = "+ Добавить";
            button.ForeColor = Color.FromArgb(0, 39, 57);
            button.BackColor = Color.FromArgb(248, 248, 248);
            button.Click += new EventHandler(AddExercise);
            button.Margin = new Padding(0, 0, 0, 20);
            return button;
        }
        private void AddExercise(object sender, EventArgs e)
        {
            AddExercise addForm =  new AddExercise(this);
            addForm.ShowDialog();
        }
        private void Calendar_SetDate(object sender)
        {
            selectedDate = Calendar.ValueDate.ToShortDateString();
            selectedDay = db.Program.FindTrainingDay(selectedDate);
            LoadDay();
        }
        public void ShowError(string text)
        {
            MessageBox.Show(
                text,
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
        }
        public void ShowExercise(Exercise exercise)
        {
            ListExersises.Controls.Add(exercise);
        }
        private void sortDown_Click(object sender, EventArgs e)
        {
            db.Directory.Sort(selectedGroup, 1);
            LoadExercisesList();
        }
        private void sortUp_Click(object sender, EventArgs e)
        {
            db.Directory.Sort(selectedGroup, -1);
            LoadExercisesList();
        }
        public void ShowTariningDayInCalendar(Day day)
        {
            Calendar.ShowTrainingDay(day);
        }
        private void Calendar_DrawCalendarEvent(object sender)
        {
            DataBase.Program.ShowTrainingDaysInCalendar();
        }

        private void CreateProgram()
        {
            DataBase.CreateProgram();
            TabControl.SelectTab(programPage);
            Calendar.dateStart = DateTime.Now;
            Calendar.DrawCalendar(Calendar.dateStart);
        }
        private bool CloseProgram()
        {
            DialogResult delete = MessageBox.Show(
                       "Вы хотите сохранить программу перед закрытием?",
                       "Закрыть",
                       MessageBoxButtons.YesNoCancel,
                       MessageBoxIcon.Warning,
                       MessageBoxDefaultButton.Button1);
            if (delete == DialogResult.Yes)
            {
                SaveProgram();
                DataBase.DeleteProgram();
                return true;
            }
            else if (delete == DialogResult.No)
            {
                DataBase.DeleteProgram();
                return true;
            }
            return false;
        }
            
            

        private void SaveProgram()
        {
            if (DataBase.Program.FilePath == null)
            {
                SelectDirectory();
            }
            DataBase.SaveProgram(DataBase.Program.FilePath); 
        }
        private void SelectDirectory()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text files(*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                DataBase.Program.FilePath = sfd.FileName;
            }
        }
        private void OpenProgram_Click(object sender, EventArgs e)
        {
            bool isClose = CloseProgram();
            if (isClose)
            {
                string filePath = "";
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text files(*.txt)|*.txt";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filePath = ofd.FileName;
                    DataBase.LoadProgram(filePath);
                    Calendar.DrawCalendar(Calendar.dateStart);
                }
                else
                {
                    CreateProgram();
                }
            }
        }
        private void CreateProgram_Click(object sender, EventArgs e)
        {
            bool isClose = CloseProgram();
            if (isClose)
            {
                CreateProgram();
            }
        }
        private void SaveProgram_Click(object sender, EventArgs e)
        {
            SaveProgram();
        }
        private void SaveAsProgram_Click(object sender, EventArgs e)
        {
            SelectDirectory();
            if (DataBase.Program.FilePath != null)
            {
                DataBase.SaveProgram(DataBase.Program.FilePath);
            }
        }
        private void TrainingLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !CloseProgram();
        }
    }
}
