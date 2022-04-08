using System;
using UnityEngine;
public class Wiper : Enemy
{

    public override void MoveBack()
    {
        throw new NotImplementedException();
    }

    public override void MoveToPlayer()
    {
        //Vector3 directionToPlayer = new Vector3(player.transform.position.x, 0, player.transform.position.z);
        //transform.Translate(directionToPlayer);
    }
}
