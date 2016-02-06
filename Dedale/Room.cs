using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Dedale
{
    public class Room
    {
        public int Position { get; set; }
        public int Code { get; set; }

        public bool WallLeft { get; set; }
        public bool WallUp { get; set; }
        public bool WallRight { get; set; }
        public bool WallDown { get; set; }

        public Room(int position, int code)
        {
            this.Position = position;
            this.Code = code;

            switch (this.Code)
            {
                case 0:
                    WallLeft = false;
                    WallUp = false;
                    WallRight = false;
                    WallDown = false;
                    break;

                case 1:
                    WallLeft = true;
                    WallUp = false;
                    WallRight = false;
                    WallDown = false;
                    break;

                case 2:
                    WallLeft = false;
                    WallUp = true;
                    WallRight = false;
                    WallDown = false;
                    break;

                case 3:
                    WallLeft = false;
                    WallUp = false;
                    WallRight = true;
                    WallDown = false;
                    break;

                case 4:
                    WallLeft = false;
                    WallUp = false;
                    WallRight = false;
                    WallDown = true;
                    break;

                case 5:
                    WallLeft = true;
                    WallUp = true;
                    WallRight = false;
                    WallDown = false;
                    break;

                case 6:
                    WallLeft = true;
                    WallUp = false;
                    WallRight = true;
                    WallDown = false;
                    break;

                case 7:
                    WallLeft = true;
                    WallUp = false;
                    WallRight = false;
                    WallDown = true;
                    break;

                case 8:
                    WallLeft = true;
                    WallUp = true;
                    WallRight = true;
                    WallDown = false;
                    break;

                case 9:
                    WallLeft = true;
                    WallUp = true;
                    WallRight = false;
                    WallDown = true;
                    break;

                case 10:
                    WallLeft = false;
                    WallUp = true;
                    WallRight = true;
                    WallDown = false;
                    break;

                case 11:
                    WallLeft = false;
                    WallUp = true;
                    WallRight = true;
                    WallDown = true;
                    break;

                case 12:
                    WallLeft = true;
                    WallUp = false;
                    WallRight = true;
                    WallDown = true;
                    break;

                case 13:
                    WallLeft = false;
                    WallUp = true;
                    WallRight = false;
                    WallDown = true;
                    break;

                case 14:
                    WallLeft = false;
                    WallUp = false;
                    WallRight = true;
                    WallDown = true;
                    break;

                case 15:
                    WallLeft = true;
                    WallUp = true;
                    WallRight = true;
                    WallDown = true;
                    break;

                default:
                    break;
            }
        }

        public override string ToString()
        {
            string R = "";

            switch (this.Code)
            {
                case 0:
                    R = "";
                    break;

                case 1:
                    R = "| .";
                    break;

                case 2:
                    R = "_ \n.";
                    break;

                case 3:
                    R = ". |";
                    break;

                case 4:
                    R = ".\n_";
                    break;

                case 5:
                    R = "_ \n|";
                    break;

                case 6:
                    R = "| |";
                    break;

                case 7:
                    R = "|\n_";
                    break;

                case 8:
                    R = "_ \n| |";
                    break;

                case 9:
                    R = "_ \n|\n_";
                    break;

                case 10:
                    R = "_ \n |";
                    break;

                case 11:
                    R = "_ \n |\n_";
                    break;

                case 12:
                    R = "| |\n_";
                    break;

                default:
                    break;
            }

            return R;
        }

        public void Echo()
        {
            if (WallLeft) 
                SoundManager.playSound(@"media\wall_left.wav");
            Thread.Sleep(500);

            if (WallUp)
                SoundManager.playSound(@"media\wall_up.wav");
            Thread.Sleep(500);

            if (WallRight)
                SoundManager.playSound(@"media\wall_right.wav");
            Thread.Sleep(500);       

            if (WallDown)
                SoundManager.playSound(@"media\wall_down.wav");
            Thread.Sleep(500);  
        }
    }
}
