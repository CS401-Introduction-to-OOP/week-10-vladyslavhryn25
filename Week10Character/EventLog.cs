using System;
using System.Collections;

namespace Week10Character
{
    public class EventLog : IEnumerable<GameEvent>
    {
      
        private readonly List<GameEvent> _events = new List<GameEvent>();

        public void Add(GameEvent gameEvent)
        {
            _events.Add(gameEvent);
        }
        
        public IEnumerator<GameEvent> GetEnumerator()
        {
            foreach (var gameEvent in _events.OrderBy(e => e.TurnNumber))
            {
                yield return gameEvent;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

       
        public IEnumerable<GameEvent> GetEventsOfType(EventType type)
        {
            foreach (var gameEvent in _events)
            {
                if (gameEvent.Type == type)
                {
                    yield return gameEvent;
                }
            }
        }
        
        public IEnumerable<GameEvent> GetLastNEvents(int count)
        {
            int startIndex = Math.Max(0, _events.Count - count);
            for (int i = startIndex; i < _events.Count; i++)
            {
                yield return _events[i];
            }
        }
    }
}