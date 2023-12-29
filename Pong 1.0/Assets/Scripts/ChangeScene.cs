using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    // Changes Scenes according to scene Id

    public void MoveToScene(int sceneId)
    {
        SceneManager.LoadScene(sceneId);
    }

}
