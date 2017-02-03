using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copy
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length<2)
            {
                Console.Out.WriteLine("此程序会自动将源文件复制到目标目录下，如果目标");
                 Console.Out.WriteLine("目录已经有相同的文件，则更改源文件名，增加更高的数字后缀");
                Console.Out.WriteLine("请指定复制源文件和目标目录：");
                Console.Out.WriteLine("参数1：源文件");
                Console.Out.WriteLine("参数2:目标目录");
                return;
            }
            Console.Out.WriteLine(string.Format("复制 {0} 到 {1}",args[0],args[1]));

            string fileName;
            int indexPath = args[0].LastIndexOf('/');
            int indexDll = args[0].LastIndexOf('.');

            if (indexDll == -1)
            {
                indexDll = args[0].Length;
                args[0] += ".dll";
            }

            if (indexPath != -1)
            {
                fileName = args[0].Substring(indexPath, indexDll - indexPath);
            }
            else
                fileName = args[0].Substring(0, indexDll);


            DirectoryInfo targetFolder = new DirectoryInfo(args[1]);


            if(!Directory.Exists(args[1]))
            {
                Directory.CreateDirectory(args[1]);
            }

            Console.Out.WriteLine("检测最新文件...");

            int max_number = 0;
            FileInfo[] files = targetFolder.GetFiles();
            foreach (FileInfo fi in files)
            {
                int startIndex = fi.Name.LastIndexOf('-') + 1;
                int endIndex = fi.Name.LastIndexOf('.');
                string f = fi.Name.Substring(startIndex, endIndex - startIndex);
                try
                {
                    int num = Int32.Parse(f);
                    if (num >= max_number)
                    {
                        max_number = num + 1;
                    }
                }
                catch (Exception e)
                {
                    Console.Out.WriteLine(fi.Name + " 名称错误：" + e.Message);
                }

            }

            //目录补上反斜杠
            if (args[1][args[1].Length - 1] != '/')
                args[1] += "/";

            string targetFileName = args[1] + fileName +"-"+ max_number + ".dll";

            //string targetFileName = args[1] + args[0];
            try
            {
                File.Copy(args[0], targetFileName,true);
                Console.Out.WriteLine("复制成功 " + targetFileName);
            }
            catch(Exception e)
            {
                Console.Out.WriteLine("复制失败:"+e.Message);
            }
            
        }
    }
}
