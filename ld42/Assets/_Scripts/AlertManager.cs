using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class AlertManager : MonoBehaviour {

    [SerializeField] GameObject alert;
    int alertnompers = 20;
    [SerializeField] Transform contaner;
    private void Start()
    {
      //  InvokeRepeating("spownalert", 1, 1);
    }
    private IEnumerator spownalert()
    {
        int i = 0;
        while (i <= alertnompers)
        {
            GameObject courentAlert = Instantiate(alert, transform.position, Quaternion.identity);
            courentAlert.transform.SetParent(contaner);
           yield return   new WaitForSeconds(1);
            i++;
        }
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);


    }


} // end class