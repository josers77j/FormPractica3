using CommonLayer.Common;
using DataLayer.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BussinesLayer.Crud
{
    public class CharacterBussines
    {
        CharacterData characterData = new CharacterData();
       

        public DataTable getCharacters()
        {
            DataTable characterTable = new DataTable();
            characterTable = characterData.getAllCharacters();
            return characterTable;
        }

        public void addCharacter(Character character)
        {
            characterData.addCharacter(character);
        }

        public void updateCharacter(Character character)
        {
            characterData.addCharacter(character);
        }

        public void deleteCharacter(Character character)
        {
            characterData.addCharacter(character);
        }
    }
}
