
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static InputManager instance;
    public static InputManager Instance => instance;

    private bool enableZoom = false;
    public bool EnableZoom => enableZoom;

    private void Awake()
    {
        if (instance != null) return;
        instance = this;
    }

    private void Update()
    {
        GetKeyZoom();
    }

    protected virtual void GetKeyZoom()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            enableZoom = true;
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            enableZoom = false;
        }
    }

}
