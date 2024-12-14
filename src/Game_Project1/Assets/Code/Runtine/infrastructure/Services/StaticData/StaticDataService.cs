using Code.Runtine.StaticData;
using UnityEngine;

namespace Code.Runtine.infrastructure.Services.StaticData
{
    public class StaticDataService : IStaticDataService
    {
        public HudConfig HUDConfig { get; private set; }
        public PlayerConfig PlayerConfig { get; private set; }


        public void LoadAll()
        {
            LoadPlayerConfig();
            LoaDHudConfig();
        }
        
        private PlayerConfig LoadPlayerConfig() =>
            PlayerConfig = Resources.Load<PlayerConfig>("Configs/PlayerConfig");

        private void LoaDHudConfig()
        {
           HUDConfig  = Resources.Load<HudConfig>("Configs/HudConfig");
        }
    }
}