using Godot;
using MiniAbyss.Instances;

namespace MiniAbyss.StatusEffects
{
    public abstract class StatusHandler : Node
    {
        public int Turn;

        public abstract string GetDisplay();

        public abstract void Tick(Creature creature);

        public abstract void Extend(StatusHandler other);
    }
}
