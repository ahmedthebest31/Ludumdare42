using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TypeManager : MonoBehaviour
{

    [SerializeField] Text displayText;
    [SerializeField] string paragraph = "The beginning of story \n Your lovely old computer had been invaded by the most dangers and harmful viruses \n You the last hope \n Try your best to help it before it going to running out of control and space...................";
    int index = 0;

    private void Start()
    {
        InvokeRepeating("Type", 0.1f, .1f);
    }

    private void Type()
    {
        if (index == paragraph.Length)
            Invoke("TypeCompleated", 0.1f);
        else
        {
            displayText.text += paragraph[index];
            index++;
        }

    }

    private void TypeCompleated()
    {
        Debug.Log("paragraph compleated");
        //displayText.text = "";
        //index = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
} // end class