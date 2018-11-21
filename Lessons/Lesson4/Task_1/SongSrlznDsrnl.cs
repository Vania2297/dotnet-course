using System;
using System.IO;
using System.Xml.Serialization;

namespace Task_1
{
    public static class SongSrlznDsrnl
    {
        /// <summary>
        /// AL6-P6/7-ConsoleSrlz. (Демонстрация). 
        /// Сериализовать обьект класса Song в XML.Вывести на консоль.
        /// Десериализовать XML из строковой переменной в объект.
        /// </summary>
        public static void AL6_P6_7_ConsoleSrlzn()
        {
            var song = new Song
            {
                Artist = new Artist
                {
                    Name = "Artist name"
                },
                Duration = 111,
                Title = "Title",
                Lyrics = "blah blah"
            };

            XmlSerializer formatter = new XmlSerializer(typeof(Song));

            string songXmlString = null;
            using (StringWriter fs = new StringWriter())
            {
                formatter.Serialize(fs, song);

                songXmlString = fs.ToString();
                Console.WriteLine(songXmlString);
            }
            
            using (var stringReader = new StringReader(songXmlString))
            {
                var newSong = (Song)formatter.Deserialize(stringReader);
                
                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"{newSong.Duration} {newSong.Artist.Name}");
            }
        }

        /// <summary>
        /// AL6-P7/7-FileSrlz.
        /// Отредактировать предыдущий пример для поддержки сериализации и десериализации в файл.
        /// </summary>
        ///

        public static void AL6_P7_7_FileSrlz()
        {
            var song = new Song
            {
                Artist = new Artist
                {
                    Name = "Artist name"
                },
                Duration = 111,
                Title = "Title",
                Lyrics = "blah blah"
            };
            
            var fileName = "Deserialize.xml";
            var currentDictionary = Directory.GetCurrentDirectory();
            
            var fullPath = Path.Combine(currentDictionary, fileName);
            
            XmlSerializer formatter = new XmlSerializer(typeof(Song));
            
            using (FileStream fs = new FileStream(fullPath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, song);
 
                Console.WriteLine(fs.ToString());
            }
            
            using (FileStream fs = new FileStream(fullPath, FileMode.Open))
            {
                Song newSong = (Song)formatter.Deserialize(fs);
 
                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"{newSong.Duration} {newSong.Artist.Name}");
            }
        }
    }
}