//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

namespace Architecture
{
    public class BankRepository : Repository
    {
        private const string KEY = "BANK_KEY";// PlayerPrefs
        public int coins { get; set; }// свойство
        public override void OnCreate() { }
        public override void Initialize()
        {
            this.coins = PlayerPrefs.GetInt(KEY, 0);
        }
        public override void Save()
        {
            PlayerPrefs.SetInt(KEY, this.coins);
        }
        public override void OnStart() { }
    }
}
