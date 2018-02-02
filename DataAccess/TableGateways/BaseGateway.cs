using DataAccess.DataModel;
using System.Collections.Generic;
using System.Data;

namespace DataAccess.TableGateways
{
    public abstract class BaseGateway<T> where T : IDataObject
    {
        public List<T> ExecuteRead(IDbCommand command)
        {
            var result = new List<T>();
            var reader = command.ExecuteReader();
            while(reader.Read())
            {
                result.Add(Map(reader));
            }            
            return result;
        }
        public abstract T Map(IDataRecord record);
    }
}
