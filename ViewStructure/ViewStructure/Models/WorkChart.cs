using System.Collections.Generic;

namespace ViewStructure.Models
{
	public class WorkChart
	{
		public WorkChart(string _teacherName, List<bool> _chart)
		{
			teacherName = _teacherName;
			chart = _chart;
		} 
		public string teacherName { get; set; }
		public List<bool> chart { get; set; }

	}
}
