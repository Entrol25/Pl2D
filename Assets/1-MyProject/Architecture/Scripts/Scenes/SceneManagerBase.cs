using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Architecture
{
    public abstract class SceneManagerBase
    {
        // событие по окончанию загрузки сцены 
        public event Action<Scene> OnSceneLoadedEvent;
        public Scene scene { get; private set; }// текущая сцена
        public bool isLoading { get; private set; }// загружает ли?
        protected Dictionary<string, SceneConfig> sceneConfigMap;// хранит конфиги всех сцен
        public SceneManagerBase()// конструктор
        {
            this.sceneConfigMap = new Dictionary<string, SceneConfig>();
        }
        public abstract void InitSceneMap();// SceneManagerExample
        // загрузка первой сцены (при загузке игры)   --------------------------------------
        public Coroutine LoadCurrentSceneAsync()
        {
            if (this.isLoading) { throw new Exception("Scene is loading now Current_Scene"); }
            var sceneName = SceneManager.GetActiveScene().name;
            var config = this.sceneConfigMap[sceneName];
            return Coroutines.StartRoutine(this.LoadCurrentSceneRoutine(config));
        }
        private IEnumerator LoadCurrentSceneRoutine(SceneConfig sceneConfig)
        {
            this.isLoading = true;
            yield return Coroutines.StartRoutine(this.InitializeSceneRoutine(sceneConfig));
            this.isLoading = false;
            this.OnSceneLoadedEvent?.Invoke(this.scene);
        }//---------------------------------------------------------------------------------
        // загрузка новой сцены
        public Coroutine LoadNewSceneAsync(string sceneName)
        {
            if (this.isLoading) { throw new Exception("Scene is loading now New_Scene"); }
            var config = this.sceneConfigMap[sceneName];
            return Coroutines.StartRoutine(this.LoadNewSceneRoutine(config));
        }
        private IEnumerator LoadNewSceneRoutine(SceneConfig sceneConfig)
        {
            this.isLoading = true;
            yield return Coroutines.StartRoutine(this.LoadSceneRoutine(sceneConfig));
            yield return Coroutines.StartRoutine(this.InitializeSceneRoutine(sceneConfig));
            this.isLoading = false;
            this.OnSceneLoadedEvent?.Invoke(this.scene);
        }//---------------------------------------------------------------------------------
        private IEnumerator LoadSceneRoutine(SceneConfig sceneConfig)
        {// карутина загружает сцену
            var async = SceneManager.LoadSceneAsync(sceneConfig.sceneName);
            async.allowSceneActivation = false;// блокировка смены сцены
            while (async.progress < 0.9f)// ждём загрузку
            { yield return null; }
            async.allowSceneActivation = true;
        }
        private IEnumerator InitializeSceneRoutine(SceneConfig sceneConfig)
        {// карутина Initialize сцену
            this.scene = new Scene(sceneConfig);
            yield return this.scene.InitializeAsync();
        }
        public T GetRepository<T>() where T : Repository
        {
            return this.scene.GetRepository<T>();
        }
        public T GetInteractor<T>() where T : Interactor
        {
            return this.scene.GetInteractor<T>();
        }
    }
}
