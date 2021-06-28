
namespace RealbizGames.Settings
{
    public interface ITimeRestrictRulerDictionary
    {
        void Put(string id, float restrictSeconds);
        void Set(string id, float restrictSeconds);

        bool Contains(string id);

        bool Validate(string id, bool resetIfOK = true);

        double GetInterval(string id);

        System.DateTime GetStartTime(string id);

        void Reset(string id);

        void Delete(string id);
    }
}