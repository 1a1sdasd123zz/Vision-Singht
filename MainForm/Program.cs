using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Vision_Sight
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!LoadAssemblies())
            {
                MessageBox.Show("关键DLL加载失败，程序无法启动！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Application.Run(new MainForm());
        }

        static bool LoadAssemblies()
        {
            try
            {
                // 指定根目录（debug目录下的libs文件夹）
                string rootFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "libs");

                // 检查根目录是否存在
                if (!Directory.Exists(rootFolder))
                {
                    Console.WriteLine($"根文件夹不存在: {rootFolder}");
                    return false;
                }

                // 获取所有子目录中的DLL文件（包括当前目录）
                string[] dllFiles = Directory.GetFiles(
                    rootFolder,
                    "*.dll",
                    SearchOption.AllDirectories  // 关键参数：搜索所有子目录
                );

                if (dllFiles.Length == 0)
                {
                    Console.WriteLine("指定文件夹及其子文件夹中没有找到DLL文件");
                    return false;
                }

                // 存储成功加载的程序集
                List<Assembly> loadedAssemblies = new List<Assembly>();

                // 逐个加载DLL
                foreach (string dllPath in dllFiles)
                {
                    try
                    {
                        Assembly assembly = Assembly.LoadFrom(dllPath);
                        loadedAssemblies.Add(assembly);
                        Console.WriteLine($"成功加载: {dllPath}");
                    }
                    catch (BadImageFormatException)
                    {
                        // 非.NET程序集（如原生C++ DLL）
                        Console.WriteLine($"跳过非.NET程序集: {dllPath}");
                    }
                    catch (UnauthorizedAccessException)
                    {
                        // 没有访问权限
                        Console.WriteLine($"没有权限访问: {dllPath}");
                    }
                    catch (PathTooLongException)
                    {
                        // 路径过长
                        Console.WriteLine($"路径过长: {dllPath}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"加载 {dllPath} 失败: {ex.Message}");
                    }
                }

                Console.WriteLine($"\n加载完成，共成功加载 {loadedAssemblies.Count} 个DLL");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"发生错误: {ex.Message}");
            }
            return false;
        }
    }
}
