namespace Archon.SwissArmyLib.Automata
{
    public class State<TMachine, TContext> : IState<TMachine, TContext>
    {
        public TMachine Machine { get; set; }
        public TContext Context { get; set; }

        public float TimeInState { get; private set; }

        /// <summary>
        /// Called when the state is entered.
        /// </summary>
        public virtual void Begin()
        {
            TimeInState = 0;
        }

        /// <summary>
        /// Called every frame just before <see cref="Update"/>. 
        /// Use this to check whether you should change state.
        /// </summary>
        public virtual void Reason() { }

        /// <summary>
        /// Called every frame after <see cref="Reason"/>, if the state hasn't been changed.
        /// </summary>
        public virtual void Update(float deltaTime)
        {
            TimeInState += deltaTime;
        }

        /// <summary>
        /// Called when the state is exited.
        /// </summary>
        public virtual void End() { }
    }
}