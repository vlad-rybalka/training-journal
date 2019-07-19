using my_work;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class DataBase
{
    TrainingProgram program;
    my_work.Directory directory = new my_work.Directory();
    TrainingLog mainForm;
    public DataBase(TrainingLog mainForm)
    {
        this.mainForm = mainForm;
    }
    public TrainingProgram Program
    {
        get {return program; }
    }
    public TrainingLog MainForm
    {
        get { return mainForm; }
    }
    public my_work.Directory Directory
    {
        get { return directory; }
    }
    public void LoadProgram(string nameFile)
    {
        program = new TrainingProgram(mainForm);
        program.FilePath = nameFile;
        Day day = new Day();
        Exercise exercise = new Exercise();
        Approach approach = new Approach();
        StreamReader sr = new StreamReader(nameFile);

        while (!sr.EndOfStream)
        {
            string temp = sr.ReadLine();
            if (temp.Contains("d?"))
            {
                day = new Day(temp.Substring(2));
                program.AddDay(day);
            }
            if (temp.Contains("e?"))
            {
                exercise = new Exercise(temp.Substring(2), this);
                day.AddExercise(exercise);
            }
            if (temp.Contains("a?"))
            {
                float weight = Convert.ToSingle(temp.Substring(2, temp.IndexOf("&") - 2));
                int repetition = Convert.ToInt32(temp.Substring(temp.IndexOf("&") + 1));
                approach = new Approach(weight, repetition);
                exercise.AddApproach(approach);
            }
        }
        sr.Close();
    }
    public void SaveProgram(string nameFile)
    {
        if (nameFile != null)
        {
            StreamWriter sw = new StreamWriter(nameFile);
            foreach (Day day in program.DayList)
            {
                sw.WriteLine("d?" + day.Date);
                foreach (Exercise exercise in day.ExerciseList)
                {
                    sw.WriteLine("e?" + exercise.Name);
                    foreach (Approach approach in exercise.ApproachList)
                    {
                        sw.WriteLine("a?" + approach.Weight + "&" + approach.Repetition);
                    }
                }
            }
            sw.Close();
        }
    }
    public void CreateProgram()
    {
        program = new TrainingProgram(mainForm);
    }
    public void DeleteProgram()
    {
        program = null;
    }
    public List<Exercise> LoadDirectory(int indexGroup)
    {
        switch (indexGroup)
        {
            case 0:
                LoadDirectory("Directory/biceps.txt", directory.bicepsList);
                return directory.bicepsList;
            case 1:
                LoadDirectory("Directory/triceps.txt", directory.tricepsList);
                return directory.tricepsList;
            case 2:
                LoadDirectory("Directory/forearms.txt", directory.forearmsList);
                return directory.forearmsList;
            case 3:
                LoadDirectory("Directory/chest.txt", directory.chestList);
                return directory.chestList;
            case 4:
                LoadDirectory("Directory/shoulder.txt", directory.shoulderList);
                return directory.shoulderList;
            case 5:
                LoadDirectory("Directory/press.txt", directory.pressList);
                return directory.pressList;
            case 6:
                LoadDirectory("Directory/back.txt", directory.backList);
                return directory.backList;
            case 7:
                LoadDirectory("Directory/foots.txt", directory.footsList);
                return directory.footsList;
            default:
                return new List<Exercise>();
        }
    }
    public void LoadDirectory(string nameFile, List<Exercise> listGroup)
    {
        listGroup.Clear();
        Exercise exercise = new Exercise();
        bool isInfo = false;
        StreamReader sr = new StreamReader(nameFile, Encoding.Default);
        while (!sr.EndOfStream)
        {
            string temp = sr.ReadLine();
            if (temp.Contains("n?"))
            {
                exercise = new Exercise(temp.Substring(2));
                listGroup.Add(exercise);
            }
            if (temp.Contains("img?"))
            {
                string img1 = temp.Substring(4, temp.IndexOf("&") - 4);
                string img2 = temp.Substring(temp.IndexOf("&") + 1);
                exercise.Img1 = img1;
                exercise.Img2 = img2;
            }
            if (temp.Contains("i/"))
            {
                isInfo = false;
            }
            if (isInfo)
            {
                exercise.Info += temp + "\n";
            }
            if (temp.Contains("i?"))
            {
                isInfo = true;
            }

        }
        sr.Close();
    }
}
