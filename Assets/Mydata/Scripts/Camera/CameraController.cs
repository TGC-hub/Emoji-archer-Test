using UnityEngine;

public class CameraController : MyMonoBehavior
{
    [SerializeField] protected Camera mainCamera;
    [SerializeField] protected Camera camera1;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        LoadMainCamera();
        LoadCameraZoom();
    }

    protected virtual void LoadMainCamera()
    {
        if (mainCamera != null) return;
        mainCamera = Camera.main;
    }

    protected virtual void LoadCameraZoom()
    {
        if(camera1 != null) return;
        camera1 = GameObject.FindGameObjectWithTag("CameraZoom").GetComponent<Camera>();
    }

    protected override void Start()
    {
        base.Start();
        camera1.gameObject.SetActive(false);
        mainCamera.gameObject.SetActive(true);
    }

    private void Update()
    {
        SetCamera();
    }

    protected virtual void SetCamera()
    {
        if (InputManager.Instance.EnableZoom == true)
        {
            OnEnableCameraZoom();
        }
        else
        {
            OnDisableCameraZoom();
        }

    }

    protected virtual void OnEnableCameraZoom()
    {
        mainCamera.gameObject.SetActive(false);
        camera1.gameObject.SetActive(true);
    }
    protected virtual void OnDisableCameraZoom()
    {
        camera1.gameObject.SetActive(false);
        mainCamera.gameObject.SetActive(true);
    }
}
