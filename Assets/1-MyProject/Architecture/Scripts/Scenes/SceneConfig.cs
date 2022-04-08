using System;// Type
//using System.Collections;
using System.Collections.Generic;
//using UnityEngine;

namespace Architecture
{
    public abstract class SceneConfig
    {
        public abstract Dictionary<Type, Repository> CreateAllRepositories();
        public abstract Dictionary<Type, Interactor> CreateAllInteractors();
        public abstract string sceneName { get; }
        /* генерик метод <T> / T наследуется от Interactor /
             * new - создать экземпляр типа T */
        public void CreateInteractor<T>(Dictionary<Type, Interactor> interactorsMap) where T : Interactor, new()
        {
            var interactor = new T();// с пустым конструктором
            var type = typeof(T);// ключ
            interactorsMap[type] = interactor;// interactor в массив
        }
        public void CreateRepository<T>(Dictionary<Type, Repository> repositoriesMap) where T : Repository, new()
        {
            var repository = new T();// с пустым конструктором
            var type = typeof(T);// ключ
            repositoriesMap[type] = repository;// repository в массив
        }
    }
}

