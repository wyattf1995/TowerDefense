using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Level
    {
        private readonly Invader[] _invaders;

        //a property of the level is an indeterminate array of towers that can be set from other classes
        public Tower[] Towers { get; set; }

        //constructor instantiates the level object which is passed the array of invaders
        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }

        //Returns true if the player wins, false otherwise
        public bool Play()
        {
            //Level will run until all invaders are neautralized or an invader reacher the end of the path
            int remainingInvaders = _invaders.Length;

            while (remainingInvaders > 0)
            {
                //Each tower has an opportunity to fire on the invaders
                foreach (Tower tower in Towers)
                {
                    tower.FireOnInvaders(_invaders);
                }

                //Count and move the invaders that are still active
                remainingInvaders = 0;
                foreach (Invader invader in _invaders)
                {
                    if(invader.IsActive)
                    {
                        invader.Move();

                        if(invader.HasScored)
                        {
                            return false;
                        }

                        remainingInvaders++;
                    }
                }

            }
            return true;
        }
    }
}
