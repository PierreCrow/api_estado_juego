using ApiGame.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGame.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameStateController : Controller
    {
        //private readonly GameDbContext _context;

        public GameStateController()
        {
        }

        //[HttpPost]
        //public async Task<ActionResult<GameState>> PostGameState(GameState gameState)
        //{
        //    _context.GameStates.Add(gameState);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetGameState", new { id = gameState.Id }, gameState);
        //}

        //[HttpGet("{id}")]
        //public async Task<ActionResult<GameState>> GetGameState(int id)
        //{
        //    var gameState = await _context.GameStates.FindAsync(id);

        //    if (gameState == null)
        //    {
        //        return NotFound();
        //    }

        //    return gameState;
        //}

        [HttpGet]
        public async Task<ActionResult<GameState>> GetGameStates()
        {
            //Complete
            GameState gameState = AutoComplete();
            return gameState;
        }

        public GameState AutoComplete()
        {
            GameCard gameCard1 = new GameCard(1, "1", 1, "SinVoltear");
            GameCard gameCard2 = new GameCard(2, "2", 4, "Incorrecto");
            GameCard gameCard3 = new GameCard(3, "3", 1, "SinVoltear");
            GameCard gameCard4 = new GameCard(4, "4", 1, "SinVoltear");
            GameCard gameCard5 = new GameCard(5, "5", 1, "SinVoltear");
            GameCard gameCard6 = new GameCard(6, "6", 1, "SinVoltear");
            GameCard gameCard7 = new GameCard(7, "7", 1, "SinVoltear");
            GameCard gameCard8 = new GameCard(8, "8", 3, "Match");
            GameCard gameCard9 = new GameCard(9, "1", 2, "Volteado");
            GameCard gameCard10 = new GameCard(10, "2", 1, "SinVoltear");
            GameCard gameCard11 = new GameCard(11, "3", 1, "SinVoltear");
            GameCard gameCard12 = new GameCard(12, "4", 1, "SinVoltear");
            GameCard gameCard13 = new GameCard(13, "5", 1, "SinVoltear");
            GameCard gameCard14 = new GameCard(14, "6", 1, "SinVoltear");
            GameCard gameCard15 = new GameCard(15, "7", 4, "Incorrecto");
            GameCard gameCard16 = new GameCard(16, "8", 3, "Match");

            List <GameCard> lista = new List<GameCard>();
            lista.Add(gameCard1);
            lista.Add(gameCard2);
            lista.Add(gameCard3);
            lista.Add(gameCard4);
            lista.Add(gameCard5);
            lista.Add(gameCard6);
            lista.Add(gameCard7);
            lista.Add(gameCard8);
            lista.Add(gameCard9);
            lista.Add(gameCard10);
            lista.Add(gameCard11);
            lista.Add(gameCard12);
            lista.Add(gameCard13);
            lista.Add(gameCard14);
            lista.Add(gameCard15);
            lista.Add(gameCard16);

            GameState gameState = new GameState();
            gameState.Id = 1;
            gameState.IsGameComplete = false;
            gameState.Cards = lista;
            //1 - SinVoltear
            //2 - Volteado
            //3 - Match
            //4 - Incorrecto

            return  gameState;
        }
    }
}
