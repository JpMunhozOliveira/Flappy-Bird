using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private float maxTime = 1f;
    private float timer = 0f;
    [SerializeField] private GameObject pipe;
    [SerializeField] private float height;

    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(transform.position.x, Random.Range(height, -height), transform.position.z);
            Destroy(newpipe, 10f);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
