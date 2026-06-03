using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{


    [SerializeField] float activeTime = 5.0f;

    [SerializeField] float offset = 1.5f;
    [SerializeField] GameObject elemental;

    [SerializeField] int count = 0;
    [SerializeField] float time = 0.0f;

    [SerializeField] List<GameObject> list;

    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject clone = Instantiate(elemental, transform);

            clone.transform.position = new Vector3(-3 + (offset * i), 0, 0);
            
            clone.SetActive(false);

            list.Add(clone);
        }

        StartCoroutine(Coroutime());
    }

    IEnumerator Coroutime()
    {
        Debug.Log("Start Coroutine");

        yield return new WaitForSeconds(5.0f);

        Debug.Log("Stop Coroutine");
    }


}
