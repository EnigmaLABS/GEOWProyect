using System;
using System.Drawing;
using System.Reflection;
using System.Data;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GEOWObj;
using GEOWObj.DTO;

namespace GEOWData.utiles
{
    public static class Reflections
    {
        public static DataTable CreateDataTable<T>(IEnumerable<T> list, List<string> ExcludedProp)
        {
            Type type = typeof(T);
            var properties = type.GetProperties();

            DataTable dataTable = new DataTable();

            int numElems = 0;

            foreach (PropertyInfo info in properties)
            {
                if (!ExcludedProp.Exists(pn => pn == info.Name))
                {
                    dataTable.Columns.Add(new DataColumn(info.Name, Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType));
                    numElems++;
                }
            }

            foreach (T entity in list)
            {
                object[] values = new object[numElems];

                for (int i = 0; i < numElems; i++)
                {
                    values[i] = properties[i].GetValue(entity);
                }

                dataTable.Rows.Add(values);
            }

            return dataTable;
        }

        public static DataTable GetPositionsDataTable(List<InsertPositionDTO> Positions)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add(new DataColumn("GUIDObject", typeof(string)));
            dataTable.Columns.Add(new DataColumn("PointDesc", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Height", typeof(int)));
            dataTable.Columns.Add(new DataColumn("Width", typeof(int)));
            dataTable.Columns.Add(new DataColumn("Color", typeof(string)));
            dataTable.Columns.Add(new DataColumn("X", typeof(int)));
            dataTable.Columns.Add(new DataColumn("Y", typeof(int)));
            dataTable.Columns.Add(new DataColumn("idJourney", typeof(long)));

            foreach (InsertPositionDTO _pos in Positions)
            {
                dataTable.Rows.Add(_pos.GUIDObject, _pos.PointDesc, _pos.Height, _pos.Width, _pos.Color, _pos.X, _pos.Y, _pos.idJourney);
            }

            return dataTable;
        }

        public static DataTable GetPointsDataTable(List<PointObj> Points)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add(new DataColumn("PointDesc", typeof(string)));
            dataTable.Columns.Add(new DataColumn("Height", typeof(int)));
            dataTable.Columns.Add(new DataColumn("Width", typeof(int)));
            dataTable.Columns.Add(new DataColumn("Color", typeof(string)));
            dataTable.Columns.Add(new DataColumn("idOrientation", typeof(int)));
            dataTable.Columns.Add(new DataColumn("GUIDObject", typeof(string)));
            

            foreach (PointObj _point in Points)
            {
                dataTable.Rows.Add(_point.NombreObjeto, _point.Ancho, _point.Alto, _point.ColorFigura.Name, (int)_point.Direccion, _point.GUIDObject);
            }

            return dataTable;
        }
    }
}
