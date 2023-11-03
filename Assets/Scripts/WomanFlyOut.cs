using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WomanFlyOut : MonoBehaviour
{


    public GameObject[] womans;
    public Transform spawnPosition;
    int randomInt;
    
    // public SlimWoman slimWoman;
    void Start()
    {

        StartCoroutine(instObj());

    }

    
    IEnumerator instObj()
    {
        while (Move.score < 5)
        // while (5 > 0)
        {
            randomInt = Random.Range(1, womans.Length);

            
            Quaternion rot = Quaternion.Euler(transform.eulerAngles.x + 90, 0, 0);
            GameObject woman = Instantiate(womans[randomInt], spawnPosition.position, rot);
            float xForce = Random.Range(30f, 250f);
            woman.GetComponent<Rigidbody>().AddForce(new Vector3(-xForce, 130));

            yield return new WaitForSeconds(3f);



            if (Move.score == 5)
            {
               // yield break;
                yield return StartCoroutine(instObj2());
            }

        }


        IEnumerator instObj2()
        {
            if (Move.score == 5)

                while (Move.score < 10)
                {
                    randomInt = Random.Range(1, womans.Length);

                    GameObject woman = Instantiate(womans[randomInt], spawnPosition.position, Quaternion.identity);
                    float xForce = Random.Range(30f, 250f);
                    woman.GetComponent<Rigidbody>().AddForce(new Vector3(-xForce, 150));

                    yield return new WaitForSeconds(2f);

                    if (Move.score == 10)
                    {
                        //yield break;
                        yield return StartCoroutine(instObj3());

                    }
                }
        }

        IEnumerator instObj3()
        {
            if (Move.score == 10)

                while (5>0)
                {
                    randomInt = Random.Range(1, womans.Length);

                    GameObject woman = Instantiate(womans[randomInt], spawnPosition.position, Quaternion.identity);
                    float xForce = Random.Range(30f, 250f);
                    woman.GetComponent<Rigidbody>().AddForce(new Vector3(-xForce, 150));

                    yield return new WaitForSeconds(1f);

                    



                }
        }
    }
}
    



    

