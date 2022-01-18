using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;


namespace Utilitario
{
    public class Structure2DataTable<T>  

 {  
     private DataTable dt = new DataTable();  
     public DataTable GetDataTable(T t)  
     {  
         DataTable dt = new DataTable();  
         Type tipo = t.GetType();  
         if (tipo.IsArray)  
         {  
             Array arr = (t as Array);  
             foreach (object obj in arr)  
             {  
                 tipo = obj.GetType();  
                 PropertyInfo[] propriedades = tipo.GetProperties();  
                 if (propriedades.Length > 0)  
                 {  
                     DataRow row = dt.NewRow();  
                     foreach (PropertyInfo p in propriedades)  
                     {  
                         if (!dt.Columns.Contains(p.Name)) dt.Columns.Add(p.Name, p.PropertyType);  
                         row[p.Name] = p.GetValue(obj, null);  
                     }  
                     dt.Rows.Add(row);  
                     dt.AcceptChanges();  
                 }  
             }  
         }  
         else 
         {  
             PropertyInfo[] propriedades = tipo.GetProperties();  
             if (propriedades.Length > 0)  
             {  
                 DataRow row = dt.NewRow();  
                 foreach (PropertyInfo p in propriedades)  
                 {  
                     if (!dt.Columns.Contains(p.Name)) dt.Columns.Add(p.Name, p.PropertyType);  
                     row[p.Name] = p.GetValue(t, null);  
                 }  
                 dt.Rows.Add(row);  
                 dt.AcceptChanges();  
             }  
         }  
         return dt;  
     }  
 } 
}
