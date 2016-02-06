using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Threading;

namespace Dedale
{
    public class Controller
    {
        public enum DIRECTIONS
        {
            LEFT,
            UP,
            RIGHT,
            DOWN
        }

        //Case sur laquelle se trouve actuellement le joueur
        public Level CurrentLevel { get; set; }
        public Room CurrentRoom { get; set; }

        public void initialisePartie()
        {
            try
            {
                SoundManager.playTitleAmbience();

                this.CurrentLevel = LevelsManager.GetAllLevels()[0];
                this.CurrentRoom = this.CurrentLevel.GetRoom(this.CurrentLevel.StartRoomIndex);
                this.CurrentLevel.GetRoom(this.CurrentRoom.Position).Echo();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public Controller()
        {
        }

        public void deplaceJoueur(DIRECTIONS dir)
        {
            int direction = 0;

            switch (dir)
            {
                case DIRECTIONS.LEFT:
                    if (!CurrentRoom.WallLeft)
                        direction = -1;
                    break;

                case DIRECTIONS.UP:
                    if (!CurrentRoom.WallUp)
                        direction = -5;
                    break;

                case DIRECTIONS.RIGHT:
                    if (!CurrentRoom.WallRight)
                        direction = -1;
                    break;

                case DIRECTIONS.DOWN:
                    if (!CurrentRoom.WallDown)
                        direction = 5;
                    break;
            }

            if (direction == 0)
            {
                SoundManager.playSound(@"media\invalid.wav");
                Thread.Sleep(700);
            }
                
            CurrentRoom = CurrentLevel.Rooms[CurrentRoom.Position + direction];
            CurrentRoom.Echo();
        }
    }
}