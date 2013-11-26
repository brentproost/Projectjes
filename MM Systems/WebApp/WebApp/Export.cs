using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace WebApp
{
    public class Export
    {
        public string ExportMultiple(DataGrid datagrid)
        {
            return ExportDataGrid(datagrid);
        }

        public Export(DataGrid datagrid)
        {
            string data = ExportDataGrid(datagrid);

            SaveFileDialog sfd = new SaveFileDialog()
            {
                DefaultExt = "csv",
                Filter = "CSV Files (*.csv)|*.csv|All files (*.*)|*.*",
                FilterIndex = 1
            };
            if (sfd.ShowDialog() == true)
            {
                try
                {
                    using (Stream stream = sfd.OpenFile())
                    {
                        using (StreamWriter writer = new StreamWriter(stream))
                        {
                            writer.Write(data);
                            writer.Close();
                        }
                        stream.Close();
                    }
                }
                catch (Exception except)
                {
                    MessageBox.Show(except.Message);
                }

            }
        }

        public Export(DataGrid datagrid, string directory, string filename)
        {
            string data = ExportDataGrid(datagrid);

            using (StreamWriter writer = new StreamWriter(@"" + directory + "/" + filename))
            {
                writer.Write(data);
                writer.Close();
            }
        }

        public Export()
        {
        }

        public String ExportDataGrid(DataGrid grid)
        {
            string colPath;
            System.Reflection.PropertyInfo propInfo;
            System.Windows.Data.Binding binding;
            System.Text.StringBuilder strBuilder = new System.Text.StringBuilder();
            System.Collections.IList source = (grid.ItemsSource as System.Collections.IList);
            if (source == null)
                return "";

            for (int i = 0; i < grid.Columns.Count; i++)
            {
                strBuilder.Append(grid.Columns[i].Header.ToString());
                strBuilder.Append(";");
            }

            strBuilder.Append("\r\n");

            foreach (Object data in source)
            {
                foreach (DataGridColumn col in grid.Columns)
                {
                    if (col is DataGridBoundColumn)
                    {
                        binding = (col as DataGridBoundColumn).Binding;
                        colPath = binding.Path.Path;
                        propInfo = data.GetType().GetProperty(colPath);
                        if (propInfo != null)
                        {
                            string propi = propInfo.GetValue(data, null).ToString();
                            strBuilder.Append(propi.Replace("\r", ""));
                            strBuilder.Append(";");
                        }
                    }
                }
                strBuilder.Append("\r\n");
            }
            return strBuilder.ToString().Replace(" ", string.Empty);
        }
    }
}
