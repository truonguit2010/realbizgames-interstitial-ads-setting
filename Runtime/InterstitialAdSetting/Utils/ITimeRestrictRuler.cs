
namespace RealbizGames.Settings
{
    public interface ITimeRestrictRuler
    {
        void Init(float restrictSeconds);

        bool Validate(bool resetIfOK = true);

        void Reset();

        System.DateTime StartTime
        {
            get;
        }

        double Interval {
            get;
        }
    }
}