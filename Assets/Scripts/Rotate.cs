using DG.Tweening;
using UnityEngine;

public class Rotate : DOMetods
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        Rotate(_rotation, _duration, _repeats, _loopType);
    }
}
