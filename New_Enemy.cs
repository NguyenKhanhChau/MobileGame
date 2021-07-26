using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_Enemy : MonoBehaviour
{
    private GameObject[] ene = new GameObject[8];
    private int[] dead = new int[8] ;
    private int[] dead_count = new int[8] ;

    public GameObject ene_1 ;
    public GameObject ene_2 ;
    public GameObject ene_3 ;
    public GameObject ene_4 ;
    public GameObject ene_5 ;
    public GameObject ene_6 ;
    public GameObject ene_7 ;
    public GameObject ene_8 ;

    void Start()
    {
        for (int i = 0; i < 8; i++)
        {
            dead[i] = 0 ;
            dead_count[i] = 0 ;
        }
        ene[0] = ene_1 ;
        ene[1] = ene_2 ;
        ene[2] = ene_3 ;
        ene[3] = ene_4 ;
        ene[4] = ene_5 ;
        ene[5] = ene_6 ;
        ene[6] = ene_7 ;
        ene[7] = ene_8 ;
        StartCoroutine(loop()) ;
    }

    IEnumerator loop ()
    {
        for ( ; ; )
        {
            yield return new WaitForSeconds(5.0f) ;
            for (int i = 0; i < 8; i++)
            {
                yield return new WaitForSeconds(5.0f) ;
                if ( ene[i].activeSelf == false )
                {
                    switch (dead[i])
                    {
                        case 0 :
                            dead_count[i] = 250 ;
                            dead[i]++ ;
                            break ;
                        
                        case 1 :
                            dead_count[i]-- ;
                            if ( dead_count[i] <= 0)
                                dead[i]++ ;
                            break ;

                        case 2 :
                            ene[i].SetActive(true) ;
                            ene[i].GetComponent<Enemy_AI>().New_Life() ;
                            ene[i].GetComponent<Enemy_Pro>().New_Life() ;
                            ene[i].GetComponent<Enemy_Ani>().New_Life() ;
                            dead[i] = 0 ;
                            break ;

                        default:
                            break ;
                    }
                }
            }
        }
    }
}
