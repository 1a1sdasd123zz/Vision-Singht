#nullable enable
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
            // 1. 定义libs根目录路径（相对于可执行文件目录）
            string libsRootPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "libs");

            // 2. 检查libs目录是否存在
            if (!Directory.Exists(libsRootPath))
            {
                MessageBox.Show($"依赖库目录不存在：{libsRootPath}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. 遍历libs目录及其所有子目录，收集所有路径
            var dllPaths = new List<string> {
                // 添加根目录
                libsRootPath };
            // 递归添加所有子目录
            foreach (var subDir in Directory.GetDirectories(libsRootPath, "*", SearchOption.AllDirectories))
            {
                dllPaths.Add(subDir);
            }

            // 4. 将所有收集到的路径添加到系统PATH环境变量（临时生效，仅当前进程）
            var currentPath = Environment.GetEnvironmentVariable("PATH");
            var newPath = string.Join(";", dllPaths) + ";" + currentPath;
            Environment.SetEnvironmentVariable("PATH", newPath);

            // 4. 注册托管程序集解析事件（处理托管DLL如MvCameraControl.Net.dll）
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        
        private static Assembly? CurrentDomain_AssemblyResolve(object? sender, ResolveEventArgs args)
        {
            // 解析程序集名称（去掉版本信息，只保留文件名）
            string assemblyName = new AssemblyName(args.Name).Name + ".dll";
            if (string.IsNullOrEmpty(assemblyName)) return null;

            // 搜索libs目录及其所有子目录
            string libsRootPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "libs");
            if (!Directory.Exists(libsRootPath)) return null;

            // 递归查找目标DLL
            string[] foundDlls = Directory.GetFiles(libsRootPath, assemblyName, SearchOption.AllDirectories);
            if (foundDlls.Length == 0) return null;

            // 加载找到的第一个DLL
            try
            {
                return Assembly.LoadFrom(foundDlls[0]);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"加载程序集 {assemblyName} 失败：{ex.Message}");
                return null;
            }
        }
    }
}
