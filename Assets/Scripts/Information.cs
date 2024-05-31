using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class Information : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;

    private Tween _tween;
    private void Start()
    {
        DOTween.Sequence()
            .Append(_text.DOText("������ ���������", _duration))
            .Append(_text.DOText(" \n�����", _duration).SetRelative())
            .Append(_text.DOText("������ ������...", _duration, true, ScrambleMode.All));
    }
}
