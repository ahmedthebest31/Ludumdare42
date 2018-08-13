using UnityEngine;

public class Spowner : MonoBehaviour {

    [SerializeField] GameObject[] anemies;
    [SerializeField] Transform[] spownPoints;
    int index = 0;
    int anemyIndex = 0;
    private void Start()
    {
        InvokeRepeating("spowne", 1f,  2f);
    }
    private void spowne()
    {
        index = Random.Range(0, spownPoints.Length);
        anemyIndex= Random.Range(0, anemies.Length);

        Instantiate(anemies[anemyIndex], spownPoints[index].position, Quaternion.identity);
        GameManager.instance.anemyCound++;
   
    }


} // end class