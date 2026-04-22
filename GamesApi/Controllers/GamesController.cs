using GamesApi.Models;
using GamesApi.Data;
using Microsoft.AspNetCore.Mvc;

namespace GamesApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GamesController : ControllerBase { }
[HttpGet]
    public ActionResult<List<Game>> GetAll()
    {
        return Ok(GamesStore.Games);
    }
    [HttpGet("{id}")]
    public ActionResult<Game> GetById(int id)
    {
        var game = GamesStore.Games.FirstOrDefault(g => g.Id == id);
        if (game is null)
        {
            return NotFound(new { message = $"Игра с id = {id} не найдена" });
        }
        return Ok(game);
    }
    [HttpPut("{id}")]
    public ActionResult<Game> Update(int id, [FromBody] Game updated)
    {
        var game = GamesStore.Games.FirstOrDefault(g => g.Id == id);
        if (game is null)
        {
            return NotFound(new { message = $"Игра с id = {id} не найдена" });
        }
        game.Title = updated.Title;
        game.Genre = updated.Genre;
        game.ReleaseYear = updated.ReleaseYear;
        return Ok(game);
    }
}