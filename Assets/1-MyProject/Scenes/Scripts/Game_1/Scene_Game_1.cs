//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Architecture;

// ArchTester "StartScene"
namespace Scenes
{
    public class Scene_Game_1 : MonoBehaviour
    {
        private Player player;
        void Start()
        {
            Game.Game_1();
            Game.OnGameInitializedEvent += OnGame_1_Initialized;// подписка
            //Debug.Log(" *** 1 += ***");
        }
        private void OnGame_1_Initialized()
        {
            Game.OnGameInitializedEvent -= OnGame_1_Initialized;// отписка
            //Debug.Log(" *** 1 -= ***");
            // вытащить ссылку на игрока
            var playerInteractor = Game.GetInteractor<PlayerInteractor>();
            // ссылка
            this.player = playerInteractor.player;
        }
        void Update()
        {
            if (!Bank.isInitialized) return;

            if (this.player == null) return;
            //Debug.Log($"1 Player position: {this.player.transform.position}");

            if (Input.GetKeyDown(KeyCode.N))
            {// фассад
                Bank.AddCoins(this, 1);
                Debug.Log($"AddCoins(this, 1), {Bank.coins}");
            }
            if (Input.GetKeyDown(KeyCode.M))
            {// фассад
                Bank.SpendCoins(this, 1);
                Debug.Log($"Spend(this, -1), {Bank.coins}");
            }
            //---------------------------------------------
            if (Input.GetKeyDown(KeyCode.Z)) Scene0();
            //if (Input.GetKeyDown(KeyCode.X)) Scene1();
        }
        private void Scene0()// Z
        {
            SceneManager.LoadScene(0);
        }
        //private void Scene1()// X
        //{
        //    SceneManager.LoadScene(1);
        //}
    }
}
