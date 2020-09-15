using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove : MonoBehaviour
{
    float _time = 0;
    Vector3 _target_pos = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        if (_time <= 0)
        {
            _time = 1f;
            _target_pos = new Vector3(Random.Range(0, 10f), Random.Range(0, 10f), Random.Range(0, 10f));
        }

        transform.position = Vector3.Lerp(_target_pos, transform.position, _time);
        _time -= Time.deltaTime;
    }
}
