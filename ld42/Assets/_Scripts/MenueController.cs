using UnityEngine;
using UnityEngine.SceneManagement;

public class MenueController :
    MonoBehaviour {

    private void Update()
    {
        if (Input.GetKey(KeyCode.N))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        else if (Input.GetKey(KeyCode.A))
            return;
        if (Input.GetKey(KeyCode.O))
            Application.OpenURL("https://ahmedthebest31.itch.io/");
        else if (Input.GetKey(KeyCode.Q))
            Application.Quit();
            
    }

} // end class