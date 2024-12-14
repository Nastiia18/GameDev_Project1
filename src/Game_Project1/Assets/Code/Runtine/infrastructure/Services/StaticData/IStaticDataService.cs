using Code.Runtine.StaticData;

namespace Code.Runtine.infrastructure.Services.StaticData
{
    public interface IStaticDataService
    {
        HudConfig HUDConfig { get; }
        PlayerConfig PlayerConfig { get; }
        void LoadAll();
    }
}