using System;
using System.IO;
using System.Linq;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
//            AL6_P1_7_DirInfo();
//            AL6_P2_7_FileInfo();
//            AL6_P4_7_CopyFile();
//            AL6_P5_7_FileChat();
//            SongSrlznDsrnl.AL6_P6_7_ConsoleSrlzn();
            SongSrlznDsrnl.AL6_P7_7_FileSrlz();
        }

        /// <summary>
        /// AL6-P1/7-DirInfo. Вывести на консоль следующую информацию о каталоге “c://Program Files”:
        /// Имя
        /// Дата создания
        /// </summary>
        public static void AL6_P1_7_DirInfo()
        {
            // Specify the directories you want to manipulate.
            var di = new DirectoryInfo(@"c://Program Files");

            try
            {
                // Determine whether the directory exists.
                if (di.Exists)
                {
                    var namedir = di.FullName;
                    var creationTime = di.CreationTime;

                    Console.WriteLine(namedir);
                    Console.WriteLine(creationTime);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e);
            }
        }

        /// <summary>
        /// AL6-P2/7-FileInfo. Получить список файлов каталога и для каждого вывести значение:
        /// Имя
        /// Дата создания
        /// Размер 
        /// </summary>
        public static void AL6_P2_7_FileInfo()
        {
            var di = new DirectoryInfo(@"c://Program Files");
            // в папке только папки и один файл. Берем первую папку и показываем все файлы из нее (все вложенные)
            var firstDir = di.GetDirectories().FirstOrDefault();
            var files = firstDir?.GetFiles("*", SearchOption.AllDirectories);
            if (files == null || !files.Any())
            {
                return;
            }

            foreach (var info in files)
            {
                Console.WriteLine($"{info.Name} {info.CreationTime} {info.Length}");
            }
        }


        /// <summary>
        /// AL6-P4/7-CopyFile. Скопировать первый файл из Program Files в новую папку.
        /// </summary>
        public static void AL6_P4_7_CopyFile()
        {
            var di = new DirectoryInfo(@"c://Program Files");
            var files = di.GetFiles();

            if (!files.Any())
            {
                return;
            }

            var sourceFile = files.First().Name;

            const string targetPath = @"c://temp";

            if (!Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
            }

            try
            {
                File.Copy(sourceFile, Path.Combine(targetPath, sourceFile), true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// AL6-P5/7-FileChat. Написать программу имитирующую чат. 
        /// Пускай в ней будут по очереди запрашивается реплики для User 1 и User 2 (используйте цикл из 5-10 итераций).  Сохраняйте данные реплики с ником пользователя и датой в файл на диске.
        /// </summary>

        private static void AL6_P5_7_FileChat()
        {
            var fileName = "chat_history.txt";
            var currentDictionary = Directory.GetCurrentDirectory();

            var fullPath = Path.Combine(currentDictionary, fileName);

            // create / overwrite file with empty string
            File.WriteAllText(fullPath, string.Empty);

            Console.WriteLine("User 1, Enter your nick name");
            var nickName1 = Console.ReadLine();
            Console.WriteLine("User 2, Enter your nick name");
            var nickName2 = Console.ReadLine();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{nickName1}, enter your message");
                var message1 = Console.ReadLine();

                Console.WriteLine($"{nickName2}, enter your message");
                var message2 = Console.ReadLine();

                try
                {
                    // Add line in the end
                    File.AppendAllLines(fullPath, new[]
                    {
                        $"{nickName1} : {message1}",
                        $"{nickName2} : {message2}",
                    });
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return;
                }
            }
        }
    }
}