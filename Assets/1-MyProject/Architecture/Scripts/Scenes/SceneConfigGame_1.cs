﻿using System;
//using System.Collections;
using System.Collections.Generic;
//using UnityEngine;

namespace Architecture
{
    public class SceneConfigGame_1 : SceneConfig
    {
        public const string SCENE_NAME = "Game-1";
        public override string sceneName => SCENE_NAME;
        public override Dictionary<Type, Repository> CreateAllRepositories()
        {
            var repositoriesMap = new Dictionary<Type, Repository>();
            this.CreateRepository<BankRepository>(repositoriesMap);// Bank
            return repositoriesMap;
        }
        public override Dictionary<Type, Interactor> CreateAllInteractors()
        {
            var interactorsMap = new Dictionary<Type, Interactor>();
            this.CreateInteractor<BankInteractor>(interactorsMap);// Bank
            this.CreateInteractor<PlayerInteractor>(interactorsMap);// Player
            return interactorsMap;
        }
    }
}
