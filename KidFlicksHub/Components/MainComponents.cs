using Microsoft.AspNetCore.Mvc;

namespace KidFlicksHub.Components
{
	public class MainComponents : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return await Task.FromResult<IViewComponentResult>(View());
		}
	}
}
