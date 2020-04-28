using System.Collections.Generic;
using rpg.Models;

namespace rpg.Services.CharacterServices
{
    public interface ICharacterService
    {
         List<Character> GetAllCharacters();
         Character GetCharacterById(int id);
         List<Character> AddCharacter(Character newCharacter);
    }
}