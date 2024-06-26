﻿using SuperHeroAPI.Models;

namespace SuperHeroAPI.Services.SuperHeroService;

public interface ISuperHeroService
{
    Task<List<SuperHero>> GetAllHeroes();

    Task<SuperHero?> GetSingleHero(Guid id);

    Task<List<SuperHero>> AddHero(SuperHero hero);

    Task<List<SuperHero>?> UpdateHero(Guid id, SuperHero request);

    Task<List<SuperHero>?> DeleteHero(Guid id);
}