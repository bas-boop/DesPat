using AI;
using Event;
using UnityEngine;

public sealed class TheGame : MonoBehaviour
{
    private const int MINUTES_IN_SECONDS = 60;
    private const int MOVE_MOMENTS_PER_HOUR = 12;
    
    private Animatronic _freddy;
    private Animatronic _springtrap;

    private void Start()
    {
        _freddy = new Animatronic.AnimatronicBuilder()
            .SetName("Freddy")
            .SetStartCamera(0)
            .SetRespawnCamera(1)
            .SetLevel(19)
            .SetPath(new []{0, 1, 2, 5, 7, 10})
            .Build();
        
        _springtrap = new Animatronic.AnimatronicBuilder()
            .SetName("Springtrap")
            .SetStartCamera(3)
            .SetRespawnCamera(3)
            .SetLevel(15)
            .SetPath(new []{3, 4, 6, 7, 8, 9})
            .Build();
        
        _freddy.Start();
        //_springtrap.Start();
        
        for (int i = 1; i <= 5; i++) // for the 5 hour changes
        {
            Invoke(nameof(InvokeTimeEvent), MINUTES_IN_SECONDS * i);

            for (int j = 0; j < MOVE_MOMENTS_PER_HOUR; j++) // for each move moment
            {
                Invoke(nameof(InvokeMoveMomentEvent), j * MINUTES_IN_SECONDS * i);
            }
        }
    }

    private void Update()
    {
        
    }

    private void InvokeTimeEvent() => EventManager.InvokeEvent(Event.EventType.TIME);
    private void InvokeMoveMomentEvent() => EventManager.InvokeEvent(Event.EventType.MOVE_MOMENT);
}
