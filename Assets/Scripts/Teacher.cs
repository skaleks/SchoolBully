using System;
using UnityEngine;


public class Teacher : Enemy
{
    [SerializeField]
    private GameObject _player;

    public float speed;
    private Transform teacherPos;


    private void Start()
    {
        teacherPos = GetComponent<Transform>();
    }
    public override void MoveBack()
    {
        throw new NotImplementedException();
    }

    public override void MoveToPlayer()
    {
        Vector3 directionToPlayer = new Vector3(_player.transform.position.x, 0, _player.transform.position.z);
        transform.Translate(directionToPlayer * speed * Time.deltaTime);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            MoveToPlayer();
        }
        if(Input.GetKey(KeyCode.Tab))
        {
            ExitFromClass();
        }
    }

    private void ExitFromClass()
    {

    }
}
