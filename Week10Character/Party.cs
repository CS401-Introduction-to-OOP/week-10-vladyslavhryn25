using System.Collections;
using System.Collections.Generic;
namespace Week10Character
{
    public class Party : IEnumerable<Character>
    {
        private readonly List<Character> _characters = new List<Character>();

        public void Add(Character character)
        {
            _characters.Add(character);
        }
        
        public IEnumerator<Character> GetEnumerator()
        {
            foreach (var character in _characters)
            {
                yield return character;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
        
        public IEnumerable<Character> GetAliveCharacters()
        {
            foreach (var character in _characters)
            {
                if (character.Status != CharacterStatus.Dead)
                {
                    yield return character;
                }
            }
        }
        
        public IEnumerable<Character> GetCharactersInDanger(int hpThreshold)
        {
            foreach (var character in _characters)
            {
                if (character.HP < hpThreshold && character.Status != CharacterStatus.Dead)
                {
                    yield return character;
                }
            }
        }
    }
}