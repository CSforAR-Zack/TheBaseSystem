using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigator : MonoBehaviour
{
    public void LoadScene(int targetScene)
    {
        SceneManager.LoadScene(targetScene);
    }
}
