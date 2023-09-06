using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitMenu : MonoBehaviour
{
   [SerializeField] private GameObject _canvasExit;
   
   public void ButtonExit()
   {
      Time.timeScale = 0;
      _canvasExit.SetActive(true);
   }

   public void CanvasExitMenu()
   {
      SceneManager.LoadScene(3);
   }

   public void CanvasExitOff()
   {
      Time.timeScale = 1;
      _canvasExit.SetActive(false);
   }
}
