using System;
using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

namespace Architecture
{
    public static class Game
    {
        public static event Action OnGameInitializedEvent;
        public static SceneManagerBase sceneManager { get; private set; }
        //-------------------------------------------------------
        public static void Run()// StartScene
        {
            sceneManager = new SceneManagerExample();
            Coroutines.StartRoutine(InitializeGameRoutine());
        }
        private static IEnumerator InitializeGameRoutine()
        {
            // инициализация карту сцен SceneManagerExample
            sceneManager.InitSceneMap();
            // ждём загрузки сцены
            yield return sceneManager.LoadCurrentSceneAsync();
            // event
            OnGameInitializedEvent?.Invoke();
        }
        //-------------------------------------------------------
        public static void Game_1()
        {
            Coroutines.StartRoutine(InitializeGame_1_Routine());
        }
        private static IEnumerator InitializeGame_1_Routine()
        {
            // ждём загрузки сцены
            yield return sceneManager.LoadCurrentSceneAsync();// StartScene
            //yield return sceneManager.LoadNewSceneAsync("Game-1");
            // event
            OnGameInitializedEvent?.Invoke();
        }
        //-------------------------------------------------------
        public static T GetInteractor<T>() where T : Interactor
        {
            return sceneManager.GetInteractor<T>();
        }
        public static T GetRepository<T>() where T : Repository
        {
            return sceneManager.GetRepository<T>();
        }
    }
}
