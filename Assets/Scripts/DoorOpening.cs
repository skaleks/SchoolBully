using UnityEngine;

public class DoorOpening : MonoBehaviour
{
    private const string _animatorFlagName = "hasAnyCollision";
    private bool _hasAnyCollision = false;
    private Animator _animator;

    private void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
    }

    public void OpenDoor()
    {
        _hasAnyCollision = true;
        _animator.SetBool(_animatorFlagName, _hasAnyCollision);
    }

    public void CloseDoor()
    {
        _hasAnyCollision = false;
        _animator.SetBool(_animatorFlagName, _hasAnyCollision);
    }
}
