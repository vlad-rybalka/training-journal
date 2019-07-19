using System;

public class Calendar
{
    DateTime date = DateTime.Now;
    String month = date.ToShortDateString().Substring(3, 2);
    String year = date.ToShortDateString().Substring(6, 4);
	public Calendar()
	{

	}
}
