using DG.Tweening;
using UnityEngine;

public class ChangeAll : DOMetods
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private Vector3 _scale;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        Move(_position, _duration, _repeats, _loopType);
        Rotate(_rotation, _duration, _repeats, _loopType);
        ChangeScale(_scale, _duration, _repeats, _loopType);
    }
}
