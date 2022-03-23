﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_Encrypted_Notebook.Classes
{
    public class ImportExportManager
    {
        public static void ExportAll(string exportPassword, string exportPath)
        {
            List<string> exportData = new List<string>();
            //exportData = DBMgr.ExportAllNotebooks(exportPassword);
            //File.WriteAllLines($@"{exportPath}\ExportAllNotebooks-From-{UserInfoManager.userName}-At-{DateTime.Now.ToString("d")}.txt", exportData);
            MessageBox.Show("Attention: if you change the data in the file (it is enough only one letter!) then the file is corrupted (for EVER!)", "The export was successful", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        public static void ExportCustom(string exportPassword, string exportPath, List<string> listOfNotebooks)
        {
            List<string> exportData = new List<string>();
            //exportData = DBMgr.ExportCustomNotebooks(exportPassword, listOfNotebooks);
            //File.WriteAllLines($@"{exportPath}\ExportCustomNotebooks-From-{UserInfoManager.userName}-At-{DateTime.Now.ToString("d")}.txt", exportData);
            MessageBox.Show("Attention: if you change the data in the file (it is enough only one letter!) then the file is corrupted (for EVER!)", "The export was successful", MessageBoxButton.OK, MessageBoxImage.Warning);
        }
        public static void ImportAll(string importPassword, string importPath)
        {
            List<string> importData = new List<string>();
            string[] _tmp = File.ReadAllLines(importPath);
            for (int i = 1; i <= _tmp.Length; i++)
                importData.Add(_tmp[i - 1]);
            //if (DBMgr.ImportAllNotebooks(importPassword, importData) == null)
            //    MessageBox.Show("The import was NOT successful, maybe the password is wrong.", "The import was NOT successful", MessageBoxButton.OK, MessageBoxImage.Information);
            //else
            //    MessageBox.Show("The import was successful, all notebooks should be available.", "The import was successful", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}