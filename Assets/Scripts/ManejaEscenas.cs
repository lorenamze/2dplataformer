using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManejaEscenas : MonoBehaviour
{
    public static void ChangeScene(string scene){
			SceneManager.LoadScene(scene);
			if (scene == "Salir")
            Application.Quit();
		}
}
