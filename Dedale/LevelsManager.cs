using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dedale
{
    static class LevelsManager
    {
        private static List<Level> Levels;

        static LevelsManager()
        {
            Levels = new List<Level>();
            int no = 1;

            string layout1 = 
@"00;00;08;00;00
00;00;06;00;00
00;09;00;11;00
00;00;06;00;00
00;00;12;00;00";

            Level lvl1 = new Level(no++, layout1, 22, 2);

            string layout2 =
@"05;13;13;13;10
06;05;13;10;06
06;06;09;14;06
06;07;13;13;14
07;13;11;15;15";

            Level lvl2 = new Level(no++, layout2, 22, 2);

            string layout3 =
@"05;13;13;13;10
06;05;13;10;06
06;06;09;14;06
06;07;13;13;14
07;13;11;15;15";
            
            Level lvl3 = new Level(no++, layout3, 22, 2);

            string layout4 =
@"05;13;13;13;10
06;05;13;10;06
06;06;09;14;06
06;07;13;13;14
07;13;11;15;15";
            
            Level lvl4 = new Level(no++, layout4, 22, 2);

            string layout5 =
@"05;13;13;13;10
06;05;13;10;06
06;06;09;14;06
06;07;13;13;14
07;13;11;15;15";

            Level lvl5 = new Level(no++, layout5, 22, 2);

            string layout6 =
@"05;13;13;13;10
06;05;13;10;06
06;06;09;14;06
06;07;13;13;14
07;13;11;15;15";

            Level lvl6 = new Level(no++, layout6, 22, 2);

            Levels.Add(lvl1);
            Levels.Add(lvl2);
            Levels.Add(lvl3);
            Levels.Add(lvl4);
            Levels.Add(lvl5);
            Levels.Add(lvl6);
        }

        public static List<Level> GetAllLevels()
        {
            return Levels;
        }
    }
}
