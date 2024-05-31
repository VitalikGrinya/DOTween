using DG.Tweening;
using UnityEngine;
using UnityEngine.UIElements;

public class DOMetods : MonoBehaviour
{
    public void Move(Vector3 position, float duration, int repeats, LoopType loopType)
    {
        transform.DOMove(position, duration).SetLoops(repeats, loopType);
    }

    public void Rotate(Vector3 rotation, float duration, int repeats, LoopType loopType)
    {
        transform.DORotate(rotation, duration).SetLoops(repeats, loopType).SetEase(Ease.Linear);
    }

    public void ChangeScale(Vector3 scale, float duration, int repeats, LoopType loopType)
    {
        transform.DOScale(scale, duration).SetLoops(repeats, loopType);
    }
}
