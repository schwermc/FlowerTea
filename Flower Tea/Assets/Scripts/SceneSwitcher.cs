using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public int SceneIndex = -1;

    public void ChangeScene()
    {
        if (SceneIndex != -1) { SceneManager.LoadScene(SceneIndex); }
    }

    public void ChangeScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
