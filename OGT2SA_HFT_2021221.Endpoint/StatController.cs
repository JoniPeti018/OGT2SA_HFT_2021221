﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OGT2SA_HFT_2021221.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OGT2SA_HFT_2021221.Endpoint
{
    [Route("[controller]")]
    [ApiController]
    public class StatController : ControllerBase
    {
        IAnimeLogic animeLogic;
        ICharacterLogic characterLogic;
        IStudioLogic studioLogic;

        public StatController(IAnimeLogic animeLogic, ICharacterLogic characterLogic, IStudioLogic studioLogic)
        {
            this.animeLogic = animeLogic;
            this.characterLogic = characterLogic;
            this.studioLogic = studioLogic;
        }

        // GET: stat/driversofateam
        [HttpGet]
        public IEnumerable<string> AnimesWhereCharacterName(string name)
        {
            return animeLogic.AnimesWhereCharacterName(name);
        }

        // GET: stat/teamchiefbydrivers
        [HttpGet]
        public IEnumerable<string> StudiosNameWhereAnimeName(string name)
        {
            return animeLogic.StudiosNameWhereAnimeName(name);
        }

        // GET: stat/avgage
        [HttpGet]
        public IEnumerable<KeyValuePair<string, string>> AnimeNameCharacterNameWhereSource(string source)
        {
            return animeLogic.AnimeNameCharacterNameWhereSource(source);
        }

        // GET: stat/teamwins
        [HttpGet]
        public IEnumerable<string> CharacterNameWhereStudio(string studio)
        {
            return animeLogic.CharacterNameWhereStudio(studio);
        }

        // GET: stat/teamsbymotor
        [HttpGet]
        public IEnumerable<string> AiredWhereStudioName(string studio)
        {
            return animeLogic.AiredWhereStudioName(studio);
        }
    }
}
