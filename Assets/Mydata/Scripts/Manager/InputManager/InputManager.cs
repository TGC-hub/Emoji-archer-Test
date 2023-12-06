
using UnityEngine;

public class InputManager : MonoBehaviour, IObserverWinLose
{
    private static InputManager instance;
    public static InputManager Instance => instance;

    private bool enableZoom = false;
    public bool EnableZoom => enableZoom;

    public bool lookInput = false;

    private void Awake()
    {
        if (instance != null) return;
        instance = this;
    }

    private void Start()
    {
        ObserverWinLose.Instance.AddObserver(this);
    }

    private void Update()
    {
        if (lookInput == true) return; 
        GetKeyZoom();
    }

    protected virtual void GetKeyZoom()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            enableZoom = true;
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            enableZoom = false;
        }
    }

    public void SendMessYouWin()
    {
        lookInput = true;
    }

    public void SendMessYouLoss()
    {
        lookInput = true;
    }
}
