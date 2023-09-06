using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingAnim : MonoBehaviour
{
    public void LoadingSceneGame()
    {
        SceneManager.LoadScene(2);
    }
    
    public void LoadingSceneMenu()
    {
        SceneManager.LoadScene(0);
    }
}
