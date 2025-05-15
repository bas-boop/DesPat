using AI;
using UnityEngine;

public sealed class TheGame : MonoBehaviour
{
    private Enemy _goblin;
    private Animatronic _freddy;

    private void Start()
    {
        _goblin = new Enemy();
        _goblin.Start();

        _freddy = new Animatronic.AnimatronicBuilder()
            .SetName("Freddy")
            .SetStartCamera(2)
            .SetRespawnCamera(3)
            .SetLevel(5)
            .Build();
    }

    private void Update()
    {
        
    }
}
