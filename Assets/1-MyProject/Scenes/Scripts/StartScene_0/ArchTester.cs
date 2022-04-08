//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Architecture;

namespace Scenes
{
    public class ArchTester : MonoBehaviour
    {/* Repository должны инициализироваться перед Interactor */
        private Player player;
        void Start() // русский
        {
            Game.Run();
            Game.OnGameInitializedEvent += OnGameInitialized;// подписка
            //Debug.Log(" *** 0 += ***");
        }
        private void OnGameInitialized()
        {
            Game.OnGameInitializedEvent -= OnGameInitialized;// отписка
            //Debug.Log(" *** 0 -= ***");
            // вытащить ссылку на игрока
            var playerInteractor = Game.GetInteractor<PlayerInteractor>();
            // ссылка
            this.player = playerInteractor.player;
        }
        void Update()// FixedUpdate()
        {
            if (!Bank.isInitialized) return;

            if (this.player == null) return;
            //Debug.Log($"0 Player position: {this.player.transform.position}");

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
            //if (Input.GetKeyDown(KeyCode.Z)) Scene0();
            if (Input.GetKeyDown(KeyCode.X)) Scene1();
        }
        //private void Scene0()// Z
        //{
        //    SceneManager.LoadScene(0);
        //}
        private void Scene1()// X
        {
            SceneManager.LoadScene(1);
        }
    }
}