using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Architecture
{
    public static class Bank// Фассад // Bank по сути Interactor
    {
        public static event Action OnBankInitializedEvent;
        public static int coins
        {
            get
            {
                CheckClass();
                return bankInteractor.coins;// достать монеты
            }
        }
        // проверить инициализацию банка
        public static bool isInitialized { get; private set; }

        private static BankInteractor bankInteractor;// храним ссылку

        public static void Initialize(BankInteractor interactor)
        {
            bankInteractor = interactor;// храним ссылку
            isInitialized = true;// Bank => Interactor.Initialize()
            OnBankInitializedEvent?.Invoke();
        }
        //----------  BankInteractor  ---------------------------------
        public static bool IsEnougthCoins(int value)// хватает ли монет
        {
            CheckClass();
            return bankInteractor.IsEnougthCoins(value);
        }
        public static void AddCoins(object sender, int value)// sender - для аналитики, ...
        {
            CheckClass();
            bankInteractor.AddCoins(sender, value);
        }
        public static void SpendCoins(object sender, int value)// sender - для аналитики, ...
        {
            CheckClass();
            bankInteractor.SpendCoins(sender, value);
        }
        private static void CheckClass()// проверить инициализацию банка
        {
            if(!isInitialized)
            { throw new Exception("Bank is not initialize yet"); }
        }
    }
}
