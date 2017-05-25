namespace ZooEmulation
{
    abstract class Animal
    {
        public enum State
        {
            Sated = 0,
            Hungry,
            Sick,
            Dead
        }

        protected readonly int _nMaxHealth;
		protected readonly string _sAlias;
        public State StateOfAnimal { get; set; }
        public string Alias
		{
			get
			{
				return _sAlias;
			}
		}
        public int Health { get; set; }

        public Animal(int maxHealth, string sAlies)
        {
            StateOfAnimal = State.Sated;
            _nMaxHealth = maxHealth;
			_sAlias = sAlies;
        }

		public bool Treat()
        {
            if (StateOfAnimal == State.Dead)
                return false;
            if (Health + 1 <= _nMaxHealth)
                Health++;
            return true;
        }

        public bool Feed()
        {
            if (StateOfAnimal == State.Dead)
                return false;
            else
                StateOfAnimal = State.Sated;
            return true;
        }

		public override string ToString()
		{
			return $"{GetType().Name} - {Alias} - {Health} - {StateOfAnimal.ToString()}";
		}
    }
}
