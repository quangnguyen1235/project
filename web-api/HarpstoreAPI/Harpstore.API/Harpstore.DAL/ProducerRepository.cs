using Dapper;
using Harpstore.DAL.Interface;
using Harpstore.Domain;
using Harpstore.Domain.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Linq;
using Harpstore.Domain.Request;

namespace Harpstore.DAL
{
    public class ProducerRepository : BaseRepository, IProducerRepository
    {
        public async Task<ModifyProducer> Delete(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ProducerId", id);
            //return (await SqlMapper.QueryAsync<ModifyProducer>(cnn: conn,
            //                param: parameters,
            //                sql: "Producer.Delete",
            //                commandType: CommandType.StoredProcedure));
            return await SqlMapper.QueryFirstOrDefaultAsync<ModifyProducer>(cnn: conn,
                            param: parameters,
                            sql: "Producer_Delete",
                            commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<Producer>> GetAll()
        {
           // List<Producer> listProducer = (List<Producer>)await SqlMapper.QueryAsync<Producer>(conn, "Producer.GetAll", CommandType.StoredProcedure);
            return await SqlMapper.QueryAsync<Producer>(conn, "Producer_GetAll", CommandType.StoredProcedure);
        }

        public async Task<Producer> GetById(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ProducerId", id);
            return await SqlMapper.QueryFirstOrDefaultAsync<Producer>(cnn: conn,
                            param: parameters,
                            sql: "Producer_GetById",
                            commandType: CommandType.StoredProcedure);
        }

        public async Task<ModifyProducer> Save(Producer request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ProducerId", request.ProducerId);
                parameters.Add("@ProducerName", request.ProducerName);
                return await SqlMapper.QueryFirstOrDefaultAsync<ModifyProducer>(cnn: conn,
                                            sql: "Producer_Save",
                                            param: parameters,
                                            commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                return new ModifyProducer()
                {
                    ProducerId = 0,
                    Message = "Something went wrong, please try again"
                };
            }
        }
    }
}
