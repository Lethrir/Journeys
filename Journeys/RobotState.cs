namespace Journeys
{
    public class RobotState
    {
        public int X { get; }
        public int Y { get; }
        public int Facing { get; }

        public RobotState(int x, int y, Facing facing) : this(x, y, (int)facing)
        {
        }

        public RobotState(int x, int y, int facing)
        {
            X = x;
            Y = y;
            Facing = facing;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is RobotState))
            {
                return false;
            }

            var compareState = obj as RobotState;

            return compareState.Facing == Facing && compareState.X == X && compareState.Y == Y;
        }

        public override string ToString()
        {
            var facing = (Facing) Facing;
            return $"X: {X}, Y: {Y}, Facing: {facing}";
        }
    }
}
