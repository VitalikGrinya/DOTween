using DG.Tweening;
using UnityEngine;

public class Object : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private Color _color;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        _renderer.DOColor(_color, _duration).SetLoops(_repeats, _loopType);
    }
}
