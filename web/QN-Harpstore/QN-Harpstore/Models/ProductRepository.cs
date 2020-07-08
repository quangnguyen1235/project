using QN_Harpstore.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QN_Harpstore.Models
{
    public class ProductRepository
    {
        private List<Product> listProduct;

        public ProductRepository()
        {
            this.listProduct = new List<Product>()
            {
                //new Product()
                //{
                //    ProductId = "a13967b6-f6e2-4ad2-9ebc-8415505980da",
                //    ProductName = "Kèn Harmonica diatonic Easttop T008K BLUE Paddy Richter",
                //    ProductAvatar = "~/images/ken-harmonica-diatonic-easttop-t008k-paddy-2.jpg",
                //    ProducerId = Producer.Easttop,
                //    ProductTypeId = ProType.Diatonic,
                //    ProductPrice = 650000,
                //    IsUsed = false,
                //    FullDescription = "Kèn Harmonica diatonic Easttop T008K Paddy là dòng kèn diatonic đặc biệt có đầy đủ note như một cây kèn tremolo, dễ dàng chơi các bản nhạc Á châu.T008K Paddy thuộc phân khúc kèn harmonica diatonic cao cấp, là sự nâng cấp hoàn hảo khi bạn muốn theo đuổi Harmonica lâu dài." + "\n" +
                //    "Ngoài các ưu điểm của dòng diatonic T008K thông thường như sau:" + "\n" +
                //    "🔥Âm thanh chắc, vang to nhưng không quá chói ở quãng cao, ở quãng trầm và quãng trung, các nốt thổi cực nhẹ" + "\n" +
                //    "🔥Kèn được thiết kế khá tối ưu nên có thể áp dụng các kĩ thuật nâng cao như bend và overblow một cách dễ dàng" + "\n" +
                //    "🔥Vỏ kèn được sơn tĩnh điện nên loại bỏ hoàn toàn hiện tượng bám vân tay và cho khả năng di chuyển môi cực kì mượt mà." + "\n" +
                //    "🔥Thân kèn (Comb) được làm từ nhựa ABS màu nâu đỏ" + "\n" +
                //    "Kèn Harmonica diatonic Easttop T008K Paddy là dòng kèn harmonica diatonic đặc biệt, duy nhất chỉ có tại QN-Harpstore – Đại lý phân phối chính hãng của Easttop." + "\n" +
                //    "Đây là phiên bản diatonic có lỗ thổi số 3 được tăng cao độ lên 1 cung nên chơi được hầu hết các note như kèn tremolo, không lo thiếu note, dòng paddy sẽ phù hợp hơn với dòng nhạc châu Á." + "\n" +
                //    "Ví dụ: Diatonic tone C bản paddy sẽ có sẵn note La thấp ở lỗ +3 mà không cần độ kèn như các dòng diatonic thông thường." + "\n" +
                //    "Khi nhắc đến Diatonic Paddy Richter mọi người nghĩ ngay đến những cây kèn Seydel với mức giá đắt đỏ (giá bán niêm yết tại Harp Store cho cây Paddy rẻ nhất là 1660K). Mặc dù chất lượng Diatonic của Seydel thì rất tốt nhưng với những người mới bắt đầu chơi bỏ ra một số tiền nhiều như vậy cũng cần phải đắn đo 🙄" + "\n" +
                //    "🍀🍀 Bạn muốn sở hữu Paddy richter với giá cả hạt dẻ. Không muốn phải độ, phải đụng dao kéo lên cây Harmonica yêu thương thì Easttop T008K Paddy chính là sự lựa chọn lí tưởng cho bạn.",
                //    ShortDescription = "Kèn Harmonica diatonic Easttop T008K Paddy là dòng kèn diatonic đặc biệt có đầy đủ note như một cây kèn tremolo, dễ dàng chơi các bản nhạc Á châu.T008K Paddy thuộc phân khúc kèn harmonica diatonic cao cấp, là sự nâng cấp hoàn hảo khi bạn muốn theo đuổi Harmonica lâu dài.",
                //},
                //new Product()
                //{
                //    ProductId = "56420f5b-24d5-410a-9531-d891462c4a01",
                //    ProductName = "Kèn Harmonica Tremolo Seydel SKYDIVER",
                //    ProductAvatar = "~/images/ken-harmonica-tremolo-seydel-skydiver-1.jpg",
                //    ProducerI = Producer.Seydel,
                //    ProductType = ProType.Tremollo,
                //    ProductPrice = 3000000,
                //    IsUsed = false,
                //    FullDescription = "Dòng kèn tremolo đầu tiên trên thế giới có lưỡi gà làm từ thép không rỉ",
                //    ShortDescription = "Xuất xứ: Đức",
                //},
                //new Product()
                //{
                //    ProductId = "093e6579-89d7-4c91-a1f6-009d5cca3776",
                //    ProductName = "Kèn Harmonica Chromatic Suzuki G48 METAL",
                //    ProductAvatar = "~/images/ken-harmonica-chromatic-suzuki-maret-g48.jpg",
                //    Producer = Producer.Suzuki,
                //    ProductType = ProType.Chromatic,
                //    ProductPrice = 11500000,
                //    IsUsed = false,
                //    FullDescription = "Cây kèn chromatic đầu bảng của Suzuki, thổi cực nhẹ, âm thanh vượt trội so với các loại chromatic khác",
                //    ShortDescription = "Xuất xứ: Nhật Bản",
                //},
                //new Product()
                //{
                //    ProductId = "093e6579-89d7-4c91-a1f6-009d5cca3786",
                //    ProductName = "Kèn Harmonica Chromatic King Dream Easttop",
                //    ProductAvatar = "~/images/ken-harmonica-chromatic-easttop-king-dream-2.jpg",
                //    Producer = Producer.Easttop,
                //    ProductType = ProType.Chromatic,
                //    ProductPrice = 1500000,
                //    IsUsed = false,
                //    FullDescription = "Cây kèn chromatic đầu bảng của Suzuki, thổi cực nhẹ, âm thanh vượt trội so với các loại chromatic khác",
                //    ShortDescription = "Xuất xứ: Nhật Bản",
                //}
            };
        }

      
        //    public Product Create(Product product)
        //    {
        //        product.ProductId = $"{Guid.NewGuid()}";
        //        product.ProductAvatar = "~/images/Unknow.jpg";
        //        listProduct.Add(product);
        //        return product;
        //    }

        //    public bool Delete(string id)
        //    {
        //        var delProduct = Get(id);
        //        if (delProduct != null)
        //        {
        //            listProduct.Remove(delProduct);
        //            return true;
        //        }
        //        return false;
        //    }

        //    public Product Edit(Product product)
        //    {
        //        var editProduct = Get(product.ProductId);
        //        editProduct.ProductName = product.ProductName;
        //        editProduct.ProductPrice = product.ProductPrice;
        //        editProduct.ProductTypeId = product.ProductTypeId;
        //        editProduct.ProducerId = product.ProducerId;
        //        editProduct.ShortDescription = product.ShortDescription;
        //        editProduct.FullDescription = product.FullDescription;
        //        return product;
        //    }

        //    public Product Get(string id)
        //    {
        //        return listProduct.FirstOrDefault(e => e.ProductId == id);
        //    }

        //    public IEnumerable<Product> Gets()
        //    {
        //        return listProduct;
        //    }
        //}
    }
}
