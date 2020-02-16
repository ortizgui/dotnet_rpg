using System.Collections.Generic;
using System.Threading.Tasks;
using rpg.Dtos.Character;
using rpg.Models;

namespace rpg.Services
{
    public interface ICharacterService
    {
         Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
         Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
         Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
         
    }
}