using AI;
using UnityEngine;

public sealed class TheGame : MonoBehaviour
{
    private Enemy _goblin;
    private float _time;

    private void Start()
    {
        _goblin = new Enemy();
        _goblin.Start();
    }

    private void Update()
    {
        _time += Time.deltaTime;

        if (_time >= 24)
            _time = 0;
        
        if (Almost(_time, 8))
        {
            _goblin.ChangeBehaviour(0);
        }
        else if (Almost(_time, 9))
        {
            _goblin.ChangeBehaviour(1);
        }
        else if (Almost(_time, 12))
        {
            _goblin.ChangeBehaviour(0);
        }
        else if (Almost(_time, 18))
        {
            _goblin.ChangeBehaviour(1);
        }
        else if (Almost(_time, 21))
        {
            _goblin.ChangeBehaviour(2);
        }
    }

    private bool Almost(float time, float target)
    {
        const float margin = 0.01f;

        return time + margin >= target
               && time - margin <= target;
    }
}
