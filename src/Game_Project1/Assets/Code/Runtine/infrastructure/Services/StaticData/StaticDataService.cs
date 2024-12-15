using System.Collections.Generic;
using System.Linq;
using Code.Runtine.infrastructure.GameStates.State;
using Code.Runtine.StaticData;
using UnityEngine;

namespace Code.Runtine.infrastructure.Services.StaticData
{
    public class StaticDataService : IStaticDataService
    {
        private Dictionary<string, LevelData> _levelsData;
        public HudConfig HUDConfig { get; private set; }
        public PlayerConfig PlayerConfig { get; private set; }

        public void LoadAll()
        {
            LoadPlayerConfig();
            LoaDHudConfig();
            LoadLevels();
        }

        public LevelData GetLevelData(string levelName) => _levelsData[levelName];
        private void LoadLevels()
        {
            _levelsData = Resources.LoadAll<LevelData>("Configs/Levels").ToDictionary((level => level.LevelName));
        }

        private PlayerConfig LoadPlayerConfig() =>
            PlayerConfig = Resources.Load<PlayerConfig>("Configs/PlayerConfig");

        private void LoaDHudConfig()
        {
           HUDConfig  = Resources.Load<HudConfig>("Configs/HudConfig");
        }
    }
}