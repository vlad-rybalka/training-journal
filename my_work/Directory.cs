using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_work
{
    public class Directory
    {
        public List<Exercise> bicepsList = new List<Exercise>();
        public List<Exercise> tricepsList = new List<Exercise>();
        public List<Exercise> forearmsList = new List<Exercise>();
        public List<Exercise> chestList = new List<Exercise>();
        public List<Exercise> shoulderList = new List<Exercise>();
        public List<Exercise> pressList = new List<Exercise>();
        public List<Exercise> backList = new List<Exercise>();
        public List<Exercise> footsList = new List<Exercise>();
        public Directory()
        {

        }
        public void Sort(List<Exercise> listExercise,int direction)
        {
            for (int i = 0; i < listExercise.Count; i++)
            {
                for (int j = 0; j < listExercise.Count - 1; j++)
                {
                    bool needToReOrderBool = false;
                    switch(direction)
                    {
                        case 1:
                            needToReOrderBool = IsNeedToReOrder(listExercise[j].Name, listExercise[j + 1].Name);
                            break;
                        case -1:
                            needToReOrderBool = IsNeedToReOrder(listExercise[j+1].Name, listExercise[j].Name);
                            break;
                    }
                    if (needToReOrderBool)
                    {
                        Exercise e = listExercise[j];
                        listExercise[j] = listExercise[j + 1];
                        listExercise[j + 1] = e;
                    }
                }
            }
        }
        protected static bool IsNeedToReOrder(string s1, string s2)
        {
            for (int i = 0; i < (s1.Length > s2.Length ? s2.Length : s1.Length); i++)
            {
                if (s1.ToCharArray()[i] < s2.ToCharArray()[i]) return false;
                if (s1.ToCharArray()[i] > s2.ToCharArray()[i]) return true;
            }
            return false;
        }
    }
}
