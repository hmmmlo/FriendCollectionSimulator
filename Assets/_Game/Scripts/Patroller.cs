using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patroller : MonoBehaviour
{
    public float _enemySpeed = 1;

    public Transform _point1;
    public Transform _point2;

    IEnumerator Start()
    {
        Transform target = _point1;

        while (true)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, _enemySpeed * Time.deltaTime);
            if (Vector3.Distance(transform.position, target.position) <= 0)
            {
                target = target == _point1 ? _point2 : _point1;
                yield return new WaitForSeconds(0.5f);
            }
            yield return null;
        }
    }
}
