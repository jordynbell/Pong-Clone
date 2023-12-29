using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitGame : MonoBehaviour
{

    public string menuSceneName = "Menu";

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            Scene currentScene = SceneManager.GetActiveScene();

            if (currentScene.name != menuSceneName)
            {
                SceneManager.LoadScene(menuSceneName);
            }
            else
            {
                QuitGame();
            }           
        }
    }

    public void ExitClicked()
    {
        QuitGame();
    }

    void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

}
