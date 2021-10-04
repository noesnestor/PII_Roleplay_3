namespace RoleplayGame
{
    public class Staff: Atk_DefItem
    {
        public override int AttackValue 
        {
            get
            {
                return 100;
            } 
        }

        public override int DefenseValue
        {
            get
            {
                return 100;
            }
        }
    }
}