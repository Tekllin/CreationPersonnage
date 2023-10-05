using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CreationPersonnage.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ClasseController : ControllerBase
	{
		private static List<Classe> Classes = new List<Classe>
		{
			new Classe
			{
				ImageUrl = "https://www.gamosaurus.com/wp-content/uploads/dofus/sacrieur/icone-sacri-feu.png",
				Nom = "Sacrieur",

			},
			new Classe
			{
				ImageUrl = "https://www.gamosaurus.com/wp-content/uploads/dofus/eniripsa/icone-eni-eau.png",
				Nom = "Eniripsa",

			},
			new Classe
			{
				ImageUrl = "https://www.gamosaurus.com/wp-content/uploads/dofus/steamer/icone-steam-air.png",
				Nom = "Steamer",

			},
			new Classe
			{
				ImageUrl = "https://www.gamosaurus.com/wp-content/uploads/dofus/eliotrope/icone-elio-eau.png",
				Nom = "Eliotrope",
			}
		};
		[HttpGet]
		public async Task<IActionResult> GetClasse()
		{
			return Ok(Classes);
		}
	}
}
