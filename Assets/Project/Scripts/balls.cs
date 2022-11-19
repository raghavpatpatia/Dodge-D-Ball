using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balls : MonoBehaviour
{
    [SerializeField] GameObject[] ballPrefab;
    [SerializeField] float secondSpwan = 0.25f;
    [SerializeField] float minTras;
    [SerializeField] float maxTras;

    public static bool spwaning;
    private void Awake()
    {
        spwaning = true;    
    }

    public void Start()
    {
        StartCoroutine(ballSpwan());
    }

    IEnumerator ballSpwan()
    {
        while (spwaning)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(ballPrefab[Random.Range(0, ballPrefab.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpwan);
            Destroy(gameObject, 10f);
        }
    }
}
