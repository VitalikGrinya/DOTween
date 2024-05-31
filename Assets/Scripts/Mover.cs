using DG.Tweening;
using UnityEngine;

public class Mover : DOMetods
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    protected void Start()
    {
        Move(_position, _duration, _repeats, _loopType);
    }
}
