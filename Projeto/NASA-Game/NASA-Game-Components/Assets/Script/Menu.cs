//using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Menu : MonoBehaviour
{

  public void ChamaCenaDoJogo2D()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
  }

  public void ChamaSairDoJogo()
  {
    Application.Quit();
  }
}
