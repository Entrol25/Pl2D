//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

namespace Architecture
{
    public class PlayerInteractor : Interactor
    {
        public Player player { get; private set; }
        public override void Initialize()
        {
            base.Initialize();
            var goPlayer = new GameObject("Player");// через ресурсы
            this.player = goPlayer.AddComponent<Player>();// через ресурсы
        }
    }
}
