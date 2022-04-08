
namespace Architecture
{
    public class BankInteractor : Interactor
    {
        private BankRepository repository;// ссылка
        public int coins => this.repository.coins;// достать монеты
        public override void OnCreate()// Interactor
        {
            base.OnCreate();
            this.repository = Game.GetRepository<BankRepository>();
        }
        public override void Initialize()// для фассад
        {
            Bank.Initialize(this);
        }
        public bool IsEnougthCoins(int value)// хватает ли монет
        {
            return coins >= value;
        }
        public void AddCoins(object sender, int value)// sender - для аналитики, ...
        {
            this.repository.coins += value;
            this.repository.Save();
        }
        public void SpendCoins(object sender, int value)// sender - для аналитики, ...
        {
            this.repository.coins -= value;
            this.repository.Save();
        }
    }
}
