using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

//namespace DG.Tweening
//{
    [System.Serializable]
    public class TweenSettings
    {
        public float duration = 1;
        public float delay = 0;
        public Ease ease = Ease.Linear;
        public int loops = 1;
    }

    public static class TweenUtils {
        public static Tweener Set(this Tweener tweener, TweenSettings settings) {
            return tweener.SetDelay(settings.delay)
                          .SetEase(settings.ease)
                          .SetLoops(settings.loops);
        }
    }
//}