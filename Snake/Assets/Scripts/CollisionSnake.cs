using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSnake : MonoBehaviour
{
    [SerializeField] private GameObject _snake = default;
    [SerializeField] private GameObject _snakeManager = default;

    private void Start()
    {
        _snakeManager = GameObject.FindGameObjectWithTag("SnakeManager");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (gameObject.CompareTag("Apple"))
            {
                _snakeManager.GetComponent<SnakeManager>().AddPartList(_snake,2);
                Destroy(gameObject);
            }
            if (gameObject.CompareTag("Cube"))
            {
                _snakeManager.GetComponent<SnakeManager>().AddPartList(_snake,1);
                Destroy(gameObject);
            }
            _snakeManager.GetComponent<SnakeManager>().AddPartList(_snake,3);
            Destroy(gameObject);
        }
       
    }
}
