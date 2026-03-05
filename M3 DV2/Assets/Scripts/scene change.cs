using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechange : MonoBehaviour
{
    public void LoadNextScene() {
        SceneManager.LoadScene("Scene_1");
    }

}
