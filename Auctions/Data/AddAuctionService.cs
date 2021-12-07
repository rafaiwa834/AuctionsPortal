using BlazorApp.Entities;
using BlazorInputFile;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class AddAuctionService
    {
        private AuctionsDbContext _dbContext;
        public AuctionsDto add = new AuctionsDto{ HowManyDays = 3};
        public IReadOnlyList<IBrowserFile> selectedImage;
        public IWebHostEnvironment _webHostEnvironment;
        public List<ImageName> images = new List<ImageName>();
       // public List<string> imageUrls = new List<string>();
        public Dictionary<string, IBrowserFile> imageTry = new Dictionary<string, IBrowserFile>();
        public IBrowserFile mainPhoto;
        public IBrowserFile MAINPHOTO;
        public string photoValidator = "";
        public List<Categories> categories;


        public AddAuctionService(AuctionsDbContext dbContext, IWebHostEnvironment webHostEnvironment)
        {
            _dbContext = dbContext;
            _webHostEnvironment = webHostEnvironment;

            categories = _dbContext
                        .Categories
                        .ToList();
        }

     
        public async Task AddNewAuction()
        {
            if (imageTry is null || MAINPHOTO is null)
            {
                photoValidator = "Dodaj zdjęcie/zdjęcia lub wybierz zdjęcie główne";
            }
            else
            {
                photoValidator = "";
                await FileUpload();
                Auctions addDB = Conversion(add);
                _dbContext.Auctions.Add(addDB);
                _dbContext.SaveChanges();
                imageTry = new Dictionary<string, IBrowserFile>();
                // imageUrls = new List<string>();
                add = new AuctionsDto { HowManyDays = 3, userID = add.userID };
            }
        }

        private Auctions Conversion(AuctionsDto auctionsDto)
        {
            Auctions addDB = new Auctions {
                BuyNowPrice = auctionsDto.BuyNowPrice,
                Title = auctionsDto.Title,
                Description = auctionsDto.Description,
                email = auctionsDto.email,
                HowManyDays = auctionsDto.HowManyDays,
                phone = auctionsDto.phone,
                StartPrice = auctionsDto.StartPrice,
                userID = auctionsDto.userID,
                Location = auctionsDto.Location,
                Images = images,
                categoryID = auctionsDto.categoryId,
                Date = DateTime.Now,
                active = true
            };

            return addDB;
        }

        private async Task FileUpload()
        {
            images = new List<ImageName>();
            var count = 0;
            foreach (var file in selectedImage)
            {
                count++;
                Stream stream = file.OpenReadStream(5000000);
                var name = $"{add.userID}--{count}--{DateTime.Now}";
                name = name.Replace(" ","").Replace(".",",").Replace(":",",");
                name = name + ".png";
                var path = $"{_webHostEnvironment.WebRootPath}\\Images\\{name}";
                FileStream fs = File.Create(path);
                await stream.CopyToAsync(fs);
                fs.Close();
                name = "Images/" + name;

                ImageName image = new ImageName { ImageLocation = name };
                if(file == MAINPHOTO)
                {
                    image.Main = true;
                }
                    images.Add(image);
                
            }
        }

        //public void SetMainPhoto(string imageSRC)
        //{
        //    MAINPHOTO = imageTry[imageSRC];
        //}

        public async Task OnInputFileChange(InputFileChangeEventArgs e)
        {
            photoValidator = "";
            imageTry = new Dictionary<string, IBrowserFile>();
            //imageUrls = new List<string>();
            var imagesFile = e.GetMultipleFiles();

           // selectedImage = imagesFile;
            selectedImage = imagesFile;
            var format = "image/png";

            foreach (var image in imagesFile)
            {
                var resizedImage = await image.RequestImageFileAsync(format, 100, 100);
                var buffer = new byte[resizedImage.Size];
                await resizedImage.OpenReadStream().ReadAsync(buffer);

                var imageUrl = $"data:{format};base64,{Convert.ToBase64String(buffer)}";

                if(!imageTry.ContainsKey(imageUrl))
                {
                    imageTry.Add(imageUrl, image);
                }
            }
        }

    }
}
