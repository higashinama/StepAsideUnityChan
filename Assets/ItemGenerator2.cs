using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator2 : MonoBehaviour
{
    public GameObject Carprefab;
    public GameObject Coneprefab;
    public GameObject Coinprefab;
    private GameObject unitychan;
    private int goalpos = 280;
    private float posrange = 3.4f;
    private int i = 40;

    // Start is called before the first frame update
    void Start()
    {
        this.unitychan = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
            if (unitychan.transform.position.z > i)
            {
                for (int k = i; k < i + 40; k += 20)
                {
                    int ran = Random.Range(1, 10);
                    if (ran <= 2)
                    {
                        for (float j = -1; j <= 1; j += 0.4f)
                        {
                            GameObject cone = Instantiate(Coneprefab);
                        cone.transform.position = new Vector3(4 * j, cone.transform.position.y, k+20) ;
                        }
                    }
                    else
                    {
                        for(int j =-1; j<=1; j++)
                        {
                            int item = Random.Range(1, 11);
                            int offsetZ = Random.Range(20, 40);
                            if (1 <= item && item <= 6)
                            {
                                GameObject coin = Instantiate(Coinprefab);
                                coin.transform.position = new Vector3(posrange * j, coin.transform.position.y, k + offsetZ);
                            }
                            else if (7 <= item && item <= 9)
                            {
                                GameObject car = Instantiate(Carprefab);
                                car.transform.position = new Vector3(posrange * j, car.transform.position.y, k + offsetZ);
                            }
                        }
                    }

                }
            if(i<goalpos)
            {
                i += 40;
            }
            else
            {
                i += 200;
            }
            }

            
        
    }
}
