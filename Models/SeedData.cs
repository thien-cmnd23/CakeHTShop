using Microsoft.EntityFrameworkCore;
using CakeHTShop.Data;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeHTShop.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CakeHTShopContext(
 serviceProvider.GetRequiredService<
 DbContextOptions<CakeHTShopContext>>()))
            {
                // Kiểm tra thông tin cuốn sách đã tồn tại hay chưa
                if (context.Cake.Any())
                {
                    return; // Không thêm nếu cuốn sách đã tồn tại trong DB
                }
                context.Cake.AddRange(
                new Cake
                {
                    Title = "Bánh sinh nhật",
                    ReleaseDate = DateTime.Parse("2018-10-16"),
                    Genre = "Bánh socola",
                    Price = 11.98M
                },
                new Cake
                {
                    Title = "Bánh đám cưới",
                    ReleaseDate = DateTime.Parse("2021-8-3"),
                    Genre = "Bánh ba tầng",
                    Price = 18.59M
                }
                );
                context.SaveChanges();//lưu dữ liệu
            }
        }
    }
}
