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
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public async Task<ModifyProduct> Delete(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ProductId", id);
            return await SqlMapper.QueryFirstOrDefaultAsync<ModifyProduct>(cnn: conn,
                            param: parameters,
                           sql: "Product_Delete",
                           commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await SqlMapper.QueryAsync<Product>(conn, "Product_GetAll", CommandType.StoredProcedure);
        }

        public async Task<Product> GetById(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ProductId", id);
            return await SqlMapper.QueryFirstOrDefaultAsync<Product>(cnn: conn,
                            param: parameters,
                            sql: "Product_GetById",
                            commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<Product>> GetbyProducerId(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ProducerId", id);
            return await SqlMapper.QueryAsync<Product>(cnn: conn,
                            param: parameters,
                            sql: "Product_GetByProducerId",
                            commandType: CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<Product>> GetbyProTypeId(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ProTypeId", id);
            return await SqlMapper.QueryAsync<Product>(cnn: conn,
                            param: parameters,
                            sql: "Product_GetByProTypeId",
                            commandType: CommandType.StoredProcedure);
        }

        public async Task<ModifyProduct> Save(Product request)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ProductId", request.ProductId);
                parameters.Add("@ProductName", request.ProductName);
                parameters.Add("@ShortDescription", request.ShortDescription);
                parameters.Add("@FullDescription", request.FullDescription);
                parameters.Add("@AvataPath", request.AvataPath);
                parameters.Add("@ProducerId", request.ProducerId);
                parameters.Add("@ProTypeId", request.ProTypeId);
                parameters.Add("@ProductPrice", request.ProductPrice);
                return await SqlMapper.QueryFirstOrDefaultAsync<ModifyProduct>(cnn: conn,
                                            sql: "Product_Save",
                                            param: parameters,
                                            commandType: CommandType.StoredProcedure);
            }
            catch (Exception ex)
            {
                return new ModifyProduct()
                {
                    ProductId = 0,
                    Message = "Something went wrong, please try again"
                };
            }
        }

        public async Task<IEnumerable<Product>> Search(string keyword)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@keyword", keyword);
            return await SqlMapper.QueryAsync<Product>(cnn: conn, sql: "Product_Search",
                                               param: parameters,
                                               commandType: CommandType.StoredProcedure);
        }
    }
}
