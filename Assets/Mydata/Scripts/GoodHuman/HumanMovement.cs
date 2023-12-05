public class HumanMovement : BaseMovement, IObserverShot
{
    protected override void Start()
    {
        base.Start();
        ObserverShot.Instance.AddObserver(this);
    }
    public void FinishShootArrow()
    {
        speed = initialSpeed;
    }

    public void StartShootArrow()
    {
        speed = 0f;
    }
}
