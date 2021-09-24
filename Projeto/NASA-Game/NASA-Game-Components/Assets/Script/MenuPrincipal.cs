//using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuPrincipal : MonoBehaviour
{

  public void ChamaCena()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
  }

  public void ChamaSairDoJogo()
  {
    Application.Quit();
  }
}
