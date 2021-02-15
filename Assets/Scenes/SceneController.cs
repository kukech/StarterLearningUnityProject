using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab; //[SerializeField] позволяет отображать и изменять в инспекторе private поля
    private GameObject _enemy;
    void Update()
    {
        if (_enemy == null)
        {
            _enemy = Instantiate(enemyPrefab) as GameObject; //было написано что метод возвращает object, который нужно приводить
                                                             //к GameObject, но видимо в этой версии уже переделали
            _enemy.transform.position = new Vector3(0, 0.25f, 0);
            float angle = Random.Range(0, 360);
            _enemy.transform.Rotate(0, angle, 0);
        }
    }
}
