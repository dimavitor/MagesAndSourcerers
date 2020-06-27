using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField]
    private int alcance;

    public Vector2 target;
    public bool mirando;

    public GameObject inimigoMaisProximo;

    private GameObject[] enemies;

    private void Start()
    {
        target = Vector2.zero;
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        
        mirando = false;
    }

    private void Update()
    {
        Mirar();
    }

    void Mirar()
    {
        foreach (GameObject obj in enemies)
        {
            bool valid = false;
            for(int i=0; i<enemies.Length; i++)
            {
               
                if (Vector2.Distance(obj.transform.position, transform.position) <= Vector2.Distance(enemies[i].transform.position, transform.position))
                {
                    valid = true;
                }
                else
                {
                    valid = false;
                    break;
                }

            }

            if (valid && Vector2.Distance(obj.transform.position, transform.position) <= alcance)
            {
                inimigoMaisProximo = obj;
            }
        }


        if(inimigoMaisProximo != null && Vector2.Distance(inimigoMaisProximo.transform.position, transform.position) <= alcance)
        {
            mirando = true;
            target = inimigoMaisProximo.transform.position - transform.position;
        }
        else
        {
            target = Vector2.zero;
            mirando = false;

            GiroCajado giroCajado = GetComponentInChildren<GiroCajado>();
            giroCajado.MovimentarArma();
        }
        
    }
}
