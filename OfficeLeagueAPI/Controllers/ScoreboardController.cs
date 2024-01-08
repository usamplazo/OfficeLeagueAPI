﻿using Microsoft.AspNetCore.Mvc;
using OfficeLeagueAPI.Models;
using OfficeLeagueAPI.Repository;
using OfficeLeagueAPI.UnitOfWork;
using System.Net.Mime;

namespace OfficeLeagueAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoreboardController : ControllerBase
    {
        
        private readonly IUnitOfWork _unitOfWork;
        IRepository<OfficePremierLeagueScoreboard> scoreboardRepository;
         
        public ScoreboardController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            scoreboardRepository = new ScoreboardRepository(_unitOfWork);
        }


        /// <summary>
        /// Returns a scoreboard for a given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async  Task<ActionResult<OfficePremierLeagueScoreboard>> GetScoreById(string id)
        {
            if (!int.TryParse(id, out int scoreId))
                return NotFound();

            var response = await scoreboardRepository.GetById(scoreId);

            if (response is null)
                return NotFound();

            return Ok(response);
        }

        /// <summary>
        /// Return scoreboards
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<OfficePremierLeagueScoreboard>>> GetScores()
        {
            var allScores = await scoreboardRepository.Get();
            return allScores;
        }

        /// <summary>
        /// Creates new scoreboard for given data
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<OfficePremierLeagueScoreboard>> CreateNewScore(OfficePremierLeagueScoreboard scoreToAdd)
        {
            var response = await scoreboardRepository.Create(scoreToAdd);
            return Ok(response);
        }

        /// <summary>
        /// Updates existing scoreboard for given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPatch("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateScore(string id, OfficePremierLeagueScoreboard scoreToUpdate)
        {
            if (!int.TryParse(id, out int scoreId))
                return BadRequest();

            var response = await scoreboardRepository.Update(scoreId, scoreToUpdate);
            return Ok(response);
        }

        /// <summary>
        /// Delete existing scoreboard for given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteScore(int id)
        {
            var response = await scoreboardRepository.Delete(id);

            return Ok(response);
        }
    }
}
