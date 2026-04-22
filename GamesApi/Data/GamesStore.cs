using GamesApi.Models;
namespace GamesApi.Data;

public static class GamesStore
{
    private static int _nextId = 4;
    public static List<Game> Games { get; } = new()
    {
        new Game
        {
            Id = 1,
            Title = "1",
            Genre = "RPG",
ReleaseYear = 2006,
        },
new Game
{
    Id = 2,
    Title = "2",
    Genre = "RPG",
    ReleaseYear = 2015,
},
    };
    public static int NextId() => _nextId++;
}
