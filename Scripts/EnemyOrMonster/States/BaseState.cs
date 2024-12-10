public abstract class BaseState
{
    public Enemy enemy;
    // instance of statemachine class / brain 
    public StateMachine stateMachine;

    // like monobehavior start, setup game properties we need to 
    public abstract void Enter();

    // update, will run every frame when the state is active 
    public abstract void Perform();

    // called into the active state before changing to a new state, cleanup
    public abstract void Exit();
}
