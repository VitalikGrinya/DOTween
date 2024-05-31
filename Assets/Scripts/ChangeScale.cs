using DG.Tweening;
using UnityEngine;

public class ChangeScale : DOMetods
{
    [SerializeField] private Vector3 _scale;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    protected void Start()
    {
        ChangeScale(_scale, _duration, _repeats, _loopType);
    }
}
