using System;
//using System.Collections;
using System.Collections.Generic;
//using UnityEngine;

namespace Architecture
{
    public class InteractorsBase
    {
        private Dictionary<Type, Interactor> interactorsMap;// массив
        private SceneConfig sceneConfig;
        public InteractorsBase(SceneConfig sceneConfig)// конструктор
        {
            this.sceneConfig = sceneConfig;
        }
        public void CreateAllInteractors()// создаёт все Interactors
        {
            this.interactorsMap = this.sceneConfig.CreateAllInteractors();
        }
        public void SendOnCreateToAllInteractors()// OnCreate();
        {// достаём значения allInteractors из Map
            var allInteractors = this.interactorsMap.Values;
            foreach(var interactor in allInteractors)
            { interactor.OnCreate(); }
        }
        public void InitializeAllInteractors()// Initialize();
        {// достаём значения allInteractors из Map
            var allInteractors = this.interactorsMap.Values;
            foreach (var interactor in allInteractors)
            { interactor.Initialize(); }
        }
        public void SendOnStartToAllInteractors()// OnStart();
        {// достаём значения allInteractors из Map
            var allInteractors = this.interactorsMap.Values;
            foreach (var interactor in allInteractors)
            { interactor.OnStart(); }
        }
        /* генерик метод <T> / T наследуется от Interactor */
        public T GetInteractor<T>() where T : Interactor
        {
            var type = typeof(T);// ключ
            return (T)this.interactorsMap[type];
        }
    }
}
