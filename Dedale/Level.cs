using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dedale
{
    public class Level
    {
        //Properties
        public int LevelNumber { get; set; }
        public List<Room> Rooms { get; set; }
        public int StartRoomIndex { get; set; }
        public int EndRoomIndex { get; set; }
        private string _layout;

        public Level(int number, string layout, int start, int end)
        {
            Rooms = new List<Room>();

            LevelNumber = number;
            _layout = layout;
            StartRoomIndex = start;
            EndRoomIndex = end;

            generateLevelRooms();
        }

        private void generateLevelRooms()
        {
            try
            {
                //ligne lue
                var lignes = _layout.Replace("\r", "").Split('\n');

                // Lecture du fichier ligne par ligne
                int i = 0;

                foreach (string ligne in lignes)
                {
                    var roomTab = ligne.Split(';');
                    foreach (string room in roomTab)
                    {
                        Room r = new Room(i, int.Parse(room));
                        Rooms.Add(r);
                        i++;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Room GetRoom(int position)
        {
            foreach (Room r in Rooms)
            {
                if (r.Position == position)
                    return r;
            }
            return null;
        }
    }
}
