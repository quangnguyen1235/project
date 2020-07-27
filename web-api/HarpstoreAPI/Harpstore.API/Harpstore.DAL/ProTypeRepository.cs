using Dapper;
using Harpstore.DAL.Interface;
using Harpstore.Domain;
using Harpstore.Domain.Request;
using Harpstore.Domain.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Harpstore.DAL
{
    public class ProTypeRepository:BaseRepository, IProTypeRepository
    {
        public async Task<ModifyProType> Delete(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ProTypeId", id);
            //return (await SqlMapper.QueryAsync<ModifyProducer>(cnn: conn,
            //                param: parameters,
            //                sql: "Producer.Delete",
            //                commandType: CommandType.StoredProcedure));
            return await SqlMapper.QueryFirstOrDefaultAsync<ModifyProType>(cnn: conn,
                            param: parameters,
                           sql: "ProType_Delete",
                           commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<ProType>> GetAll()
        {
            // List<Producer> listProducer = (List<Producer>)await SqlMapper.QueryAsync<Producer>(conn, "Producer.GetAll", CommandType.StoredProcedure);
            return await SqlMapper.QueryAsync<ProType>(conn, "ProType_GetAll", CommandType.StoredProcedure);
        }

        public async Task<ProType> GetById(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ProTypeId", id);
            return await SqlMapper.QueryFirstOrDefaultAsync<ProType>(cnn: conn,
                            param: parameters,
                            sql: "ProType_GetById",
                            commandType: CommandType.StoredProcedure);
        }

        public async Task<ModifyProType> Save(ProType request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ProTypeId", request.ProTypeId);
                parameters.Add("@ProTypeName", request.ProTypeName);
                return await SqlMapper.QueryFirstOrDefaultAsync<ModifyProType>(cnn: conn,
                                            sql: "ProType_Save",
                                            param: parameters,
                                            commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                return new ModifyProType()
                {
                    ProTypeId = 0,
                    Message = "Something went wrong, please try again"
                };
            }
        }
    }
}
