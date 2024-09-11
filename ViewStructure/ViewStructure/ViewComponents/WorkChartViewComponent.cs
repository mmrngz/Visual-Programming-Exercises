using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ViewStructure.Models;

namespace ViewStructure.ViewComponents
{
	public class WorkChartViewComponent : ViewComponent
	{
		List<WorkChart> workChart = new List<WorkChart>() 
		{
			new WorkChart("Muhammet",new List<bool>(){true,false,true,true,true}),
			new WorkChart("Marangoz",new List<bool>(){true,true,true,true,true}),
			new WorkChart("Kiraz",new List<bool>(){true,false,false,false,true}),
			new WorkChart("Cartcurt",new List<bool>(){true,false,true,false,true}),
		};
		public IViewComponentResult Invoke() 
		{
			return View(workChart); 
		}	

	}
}
