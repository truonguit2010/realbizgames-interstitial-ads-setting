using System;
using System.Collections.Generic;

namespace RealbizGames.Settings
{
    public class TimeRestrictRulerDictionaryImpl : ITimeRestrictRulerDictionary
    {

        private Dictionary<string, ITimeRestrictRuler> dict = new Dictionary<string, ITimeRestrictRuler>();

        public bool Contains(string id)
        {
            return dict.ContainsKey(id);
        }

        public void Delete(string id)
        {
            dict.Remove(id);
        }

        public double GetInterval(string id)
        {
            if (dict.ContainsKey(id))
            {
                return dict[id].Interval;
            }
            else
            {
                return 0;
            }
        }

        public DateTime GetStartTime(string id)
        {
            if (dict.ContainsKey(id))
            {
                return dict[id].StartTime;
            }
            else
            {
                return DateTime.Now;
            }
        }

        public void Put(string id, float restrictSeconds)
        {
            dict[id] = new TimeRestrictRulerImpl();
            dict[id].Init(restrictSeconds);
        }

        public void Reset(string id)
        {
            if (dict.ContainsKey(id))
            {
                dict[id].Reset();
            }
        }

        public void Set(string id, float restrictSeconds)
        {
            if (!dict.ContainsKey(id))
            {
                dict[id] = new TimeRestrictRulerImpl();
                dict[id].Init(restrictSeconds);
            }
            else
            {
                dict[id].Update(restrictSeconds: restrictSeconds);
            }
        }

        public bool Validate(string id, bool resetIfOK = true)
        {
            if (dict.ContainsKey(id))
            {
                return dict[id].Validate(resetIfOK: resetIfOK);
            }
            else
            {
                return false;
            }
        }
    }
}