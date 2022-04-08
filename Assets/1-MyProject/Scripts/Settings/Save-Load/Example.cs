//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

namespace Save_Load
{
    public class Example : MonoBehaviour
    {
        public GameObject go;// игрок

        private Storage storage;
        private GameData gameData;
        void Start()
        {
            storage = new Storage();
            //FirstSave();// Первый запуск игры
            Load();// выгрузить
        }
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.O)) Save();
            if (Input.GetKeyDown(KeyCode.P)) Load();
        }
        private void FirstSave()// Первый запуск игры
        {
            gameData = (GameData)storage.Load(new GameData());
            //
            Debug.Log($"langUI = {gameData.langUI}");
            Debug.Log($"voidDataTest = {gameData.voidDataTest}");

            if (gameData.voidDataTest == null)
            { 
                Debug.Log("gameData.voidDataTest == null");
                gameData.langUI = "RU"; storage.Save(gameData);
            }

            Debug.Log($"langUI = {gameData.langUI}");
            Debug.Log("+++ FirstSave +++");
        }
        private void Save()// Сохранить
        {
            gameData.position = go.transform.position;
            gameData.rotation = go.transform.rotation;
            //----------------------------------------------//
            //gameData.langUI = "RU";
            //----------------------------------------------//
            storage.Save(gameData);
            Debug.Log("Game saved");
        }
        private void Load()// выгрузить
        {
            gameData = (GameData)storage.Load(new GameData());
            go.transform.position = gameData.position;
            go.transform.rotation = gameData.rotation;
            Debug.Log($"Loaded speed = {gameData.speed}");
            //----------------------------------------------//
            Debug.Log($"langUI = {gameData.langUI}");

            Debug.Log($"voidDataTest = {gameData.voidDataTest}");
            if(gameData.voidDataTest == null)
            { Debug.Log("gameData.voidDataTest == null"); }

            Debug.Log("Game loaded"); 
        }
    }
}
