using System;
using System.Xml;

public class database
{
    XmlDocument xDoc = new XmlDocument();
    TrainingProgram[] arrProgram;
    ExerciseGroup[] arrGroup;
    public database()
	{
 
	}
    static string Load()
    {
        xDoc.Load("database.xml");
        XmlNode node = xDoc.SelectSingleNode("root/programs");
    }
}
