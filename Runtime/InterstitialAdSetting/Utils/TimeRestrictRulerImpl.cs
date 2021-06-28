
using System;

namespace RealbizGames.Settings
{
    public class TimeRestrictRulerImpl : ITimeRestrictRuler
    {
        private DateTime _startTime;
        public DateTime StartTime => _startTime;

        public double Interval => DateTime.Now.Subtract(_startTime).TotalSeconds;

        private float _restrictSeconds;

        public void Init(float restrictSeconds)
        {
            _startTime = DateTime.Now;
            _restrictSeconds = restrictSeconds;
        }

        public void Reset()
        {
            _startTime = DateTime.Now;
        }

        public bool Validate(bool resetIfOK = true)
        {
            double interval = Interval;
            bool ok = interval >= _restrictSeconds;
            if (ok && resetIfOK) {
                this.Reset();
            }
            return ok;
        }

        public void Update(float restrictSeconds)
        {
            _restrictSeconds = restrictSeconds;
        }
    }
}