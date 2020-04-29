using System.Collections;
using UnityEngine;

public class changeScene : MonoBehaviour
{
    public void SceneChange(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
