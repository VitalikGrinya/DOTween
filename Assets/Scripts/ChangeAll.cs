using DG.Tweening;
using UnityEngine;

public class ChangeAll : MonoBehaviour
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private Vector3 _scale;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DOMove(_position, _duration).SetLoops(_repeats,_loopType);
        transform.DORotate(_rotation, _duration).SetLoops(_repeats,_loopType);
        transform.DOScale(_scale, _duration).SetLoops(_repeats,_loopType);
    }
}
