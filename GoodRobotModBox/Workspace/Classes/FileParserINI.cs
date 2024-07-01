using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IniParser;
using IniParser.Model;

namespace GoodRobotModBox.Workspace.Classes
{
    public class FileParserINI : IFileParserINI
    {
        public void Parse(string filePath)
        {
            var path = filePath;
            var parser = new IniParser.Parser.IniDataParser();
            parser.Configuration.CommentString = "#";
            IniData data = parser.Parse(File.ReadAllText(filePath));
            foreach (var item in data.Sections)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
        }
    }
}
