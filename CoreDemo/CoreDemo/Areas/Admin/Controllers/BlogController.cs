using ClosedXML.Excel;
using CoreDemo.Areas.Admin.Models;
using DataAccessLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {

        public IActionResult ExportStaticExcelBlogList()
        {
            // Excel Export 
            // excel workbook umuzu oluşturduk
            using (var workbook = new XLWorkbook())
            {
                //Excel worksheeti oluşturduk yani sayfayı
                var worksheet = workbook.Worksheets.Add("Blog Listesi");
                // A1 ve B1 de ne yazmalı
                // 1.satır 1.sütun
                worksheet.Cell(1, 1).Value = "Blog ID";
                worksheet.Cell(1, 2).Value = "Blog Adı";

                // 2 başlama sebebi 1.satıra başlık yazılıcak 
                int BlogRowCount = 2;
                foreach (var item in GetBlogList())
                {
                    // Satırın 1. sütununa şunu yaz veya 
                    worksheet.Cell(BlogRowCount, 1).Value = item.ID;
                    // Satırın 2. sütununa şunu yaz veya 
                    worksheet.Cell(BlogRowCount, 2).Value = item.BlogName;
                    BlogRowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Calisma1.xlsx");
                }

            }

        }

        public List<BlogModel> GetBlogList()
        {
            List<BlogModel> bm = new List<BlogModel> {  new BlogModel { ID = 1, BlogName = "Asp.net Programlama" } ,
                                                        new BlogModel{ ID= 2,BlogName = "C# Proglamlama" },
                                                        new BlogModel{ ID= 3,BlogName = "Jquery Proglamlama" }};
            return bm;
        }

        public IActionResult BlogListExcel()
        {

            return View();
        }


        public IActionResult ExportDinamicExcelBlogList()
        {
            using (var workbook = new XLWorkbook())
            {
                //Excel worksheeti oluşturduk yani sayfayı
                var worksheet = workbook.Worksheets.Add("Blog Listesi");
                // A1 ve B1 de ne yazmalı
                // 1.satır 1.sütun
                worksheet.Cell(1, 1).Value = "Blog ID";
                worksheet.Cell(1, 2).Value = "Blog Adı";

                // 2 başlama sebebi 1.satıra başlık yazılıcak 
                int BlogRowCount = 2;
                foreach (var item in BlogTitleList())
                {
                    // Satırın 1. sütununa şunu yaz veya 
                    worksheet.Cell(BlogRowCount, 1).Value = item.ID;
                    // Satırın 2. sütununa şunu yaz veya 
                    worksheet.Cell(BlogRowCount, 2).Value = item.BlogName;
                    BlogRowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Calisma1.xlsx");
                }

            }
        }

        public List<BlogModel2> BlogTitleList(){

            List<BlogModel2> bm = new List<BlogModel2>();
            using (var c = new context())
            {
                bm = c.blogs.Select(x => new BlogModel2
                {
                    ID = x.blogID,
                    BlogName = x.blogTitle
                }).ToList();
            }
            return bm;
        }

        public IActionResult BlogTitleListExcel()
        {
            return View();
        }

    }
}
