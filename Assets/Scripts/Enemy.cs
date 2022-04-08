using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    protected string _name;
    protected Rigidbody enemyRB;


    private void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
    }

    public abstract void MoveToPlayer();

    public abstract void MoveBack();
}
