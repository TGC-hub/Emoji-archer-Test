using UnityEngine.SceneManagement;

public class ButtonRepeat : BaseButton
{
    protected override void OnClick()
    {
        SceneManager.LoadScene(0);
        InputManager.Instance.lookInput = false;
    }
}
