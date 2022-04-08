using System;
//using System.Collections;
using System.Collections.Generic;
//using UnityEngine;

namespace Architecture
{
    public class RepositoriesBase
    {
        private Dictionary<Type, Repository> repositoriesMap;// массив
        private SceneConfig sceneConfig;
        public RepositoriesBase(SceneConfig sceneConfig)// конструктор
        {
            this.sceneConfig = sceneConfig;
        }
        public void CreateAllRepositories()// создаёт Repositoryes
        {
            this.repositoriesMap = this.sceneConfig.CreateAllRepositories();
        }
        public void SendOnCreateToAllRepositories()// OnCreate();
        {// достаём значения allInteractors из Map
            var allRepositories = this.repositoriesMap.Values;
            foreach (var repository in allRepositories)
            { repository.OnCreate(); }
        }
        public void InitializeAllRepositories()// Initialize();
        {// достаём значения allRepositories из Map
            var allRepositories = this.repositoriesMap.Values;
            foreach (var repository in allRepositories)
            { repository.Initialize(); }
        }
        public void SendOnStartToAllRepositories()// OnStart();
        {// достаём значения allRepositories из Map
            var allRepositories = this.repositoriesMap.Values;
            foreach (var repository in allRepositories)
            { repository.OnStart(); }
        }
        /* генерик метод <T> / T наследуется от Repository */
        public T GetRepository<T>() where T : Repository
        {
            var type = typeof(T);// ключ
            return (T)this.repositoriesMap[type];
        }
    }
}
