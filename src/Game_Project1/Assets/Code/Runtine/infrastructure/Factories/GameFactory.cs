using Code.Runtine.Gameplay.Logic;
 using Code.Runtine.Gameplay.View.UI;
 using Code.Runtine.infrastructure.Services.StaticData;
 using Unity.VisualScripting;
 using UnityEditor;
 using System;
 using UnityEngine;
 using Zenject;


 namespace Code.Runtine.infrastructure.Factories
 {
     public class GameFactory : IGameFactory
     {
         private readonly IStaticDataService _staticDataService;
         private readonly IInstantiator _instantiator;

         public GameFactory(IStaticDataService staticDataService, IInstantiator instantiator)
         {
             _staticDataService = staticDataService;
             _instantiator = instantiator;
         }
 
         public GameObject CreatePlayer(Vector3 position)
         {
            GameObject player = _instantiator.InstantiatePrefab(_staticDataService.PlayerConfig.PlayerPrefab, position, Quaternion.identity, null);
            player.GetComponent<Health>().CurrentHealth =_staticDataService.PlayerConfig.Starthealth;
            return player;
         }
 
         public GameObject CreateHud(GameObject player)
         {
             Wallet wallet = player.GetComponent<Wallet>();
             Health health = player.GetComponent<Health>();
             Hud hud = _instantiator.InstantiatePrefabForComponent<Hud>(_staticDataService.HUDConfig.HudPrefab);

             hud.SetUp(wallet, health);
             return hud.gameObject;
         }
     }
 }